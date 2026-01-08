using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VehicleRENTAL;

namespace VehicleRENTAL {
    public partial class DashboardForm : MaterialForm {
        private Random rng = new Random();
        private DataTable recentTable;

        // P/Invoke for cue banner (placeholder) on .NET Framework
       [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        private const uint EM_SETCUEBANNER = 0x1501;

        public DashboardForm() {
            InitializeComponent();

            // Apply MaterialSkin theme + color scheme (guard in case MaterialSkin not initialized)
            try {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900,
                    Primary.BlueGrey500, Accent.Teal200, TextShade.WHITE
                );
            } catch {
                // non-fatal: allow the form to load even if theme initialization fails
            }
        }

        private void dashboard_Load(object sender, EventArgs e) {
            // initialize UI with defensive null checks
            if (lblTitle != null) lblTitle.Text = "HOME";

            InitializeKpis();
            InitializeChartPlaceholder();
            InitializeRecentGrid();
            LoadSampleData();

            // theme and styling
            try {
                ApplyDarkTheme();
            } catch {
                // non-fatal
            }

            // set a cue banner for search textbox (works on .NET Framework)
            try {
                SetCueBanner(txtSearch, "Search vehicles, customers, bookings...");
            } catch {
                // if it fails (very old OS), ignore
            }

            EnsureMenuOrder();
            NormalizeMenuButtons(); // ensure consistent sizes/padding at runtime

            // Ensure vehicle grid is populated if the control and manager exist
            try {
                RefreshVehicleTable();
            } catch {
                // ignore - protects runtime if VehicleManager not ready during startup
            }
        }

        private void RefreshVehicleTable() {
            if (dgvVehicles == null)
                return;

            // If the VehicleManager type is available, bind its list; otherwise keep safe defaults.
            try {
                dgvVehicles.AutoGenerateColumns = true;
                var vm = Classes.VehicleManager.Instance;
                if (vm != null)
                    dgvVehicles.DataSource = vm.Vehicles;
            } catch {
                // fallback: clear datasource to avoid crashes during merge-incomplete state
                dgvVehicles.DataSource = null;
            }
        }

        private void SetCueBanner(TextBox tb, string cue) {
            if (tb == null || tb.IsDisposed)
                return;
            try {
                // Force handle creation safely and send the cue banner message
                var handle = tb.Handle;
                SendMessage(handle, EM_SETCUEBANNER, (IntPtr)1, cue);
            } catch {
                // ignore any failures (some OS/controls may not support)
            }
        }

        private void ApplyDarkTheme() {
            // If essential controls don't exist, skip theming (defensive)
            if (panelMenu == null || panelHeader == null || panelDesktop == null)
                return;

            // Align dashboard colors with Login and LoadingScreen designs
            var sidebar = Color.LightSteelBlue;          // matches Login panel1
            var header = SystemColors.ActiveCaption;    // matches LoadingScreen panelMain
            var surface = Color.White;                  // content area like Login panel2
            var card = Color.WhiteSmoke;                // subtle card background
            var accent = Color.FromArgb(100, 210, 145); // loading progress accent
            var lightText = Color.FromArgb(40, 40, 40); // dark text on light surfaces
            var mutedText = Color.DimGray;

            // Form background
            this.BackColor = surface;

            // Sidebar
            panelMenu.BackColor = sidebar;
            foreach (Control c in panelMenu.Controls) {
                if (c is Button b) {
                    b.FlatStyle = FlatStyle.Flat;
                    try {
                        b.FlatAppearance.BorderSize = 0;
                    } catch { }
                    b.ForeColor = Color.White;
                    b.BackColor = sidebar;
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Padding = new Padding(18, 0, 0, 0);
                    b.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    b.Cursor = Cursors.Hand;
                    try {
                        b.FlatAppearance.MouseOverBackColor = ControlPaint.Light(sidebar);
                        b.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(sidebar);
                    } catch {
                        // older frameworks may ignore
                    }
                }
            }

            // Header
            panelHeader.BackColor = header;
            if (lblTitle != null) {
                lblTitle.ForeColor = Color.White;
                lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            }
            if (txtSearch != null) {
                txtSearch.BackColor = Color.FromArgb(240, 248, 250);
                txtSearch.ForeColor = lightText;
                txtSearch.BorderStyle = BorderStyle.FixedSingle;
            }

            // Desktop surface
            panelDesktop.BackColor = surface;

            // KPI cards (light theme version)
            if (flpKpi != null) {
                foreach (Control cardPanel in flpKpi.Controls) {
                    if (cardPanel is Panel p) {
                        p.BackColor = card;
                        p.BorderStyle = BorderStyle.None;
                        p.Padding = new Padding(12);
                        foreach (Control c in p.Controls) {
                            if (c is Label lab) {
                                if (lab.Font.Size <= 9.5f) {
                                    lab.ForeColor = mutedText; // title
                                    lab.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                                } else {
                                    lab.ForeColor = accent; // big value accent
                                    lab.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                                }
                            }
                        }
                    }
                }
            }

            // Metrics panel
            if (pnlMetrics != null) pnlMetrics.BackColor = card;

            // Recent grid theming (light)
            if (dgvRecent != null) {
                dgvRecent.BackgroundColor = card;
                dgvRecent.ForeColor = lightText;
                dgvRecent.EnableHeadersVisualStyles = false;
                dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = lightText;
                dgvRecent.RowTemplate.DefaultCellStyle.BackColor = card;
                dgvRecent.RowTemplate.DefaultCellStyle.ForeColor = lightText;
                dgvRecent.GridColor = Color.FromArgb(230, 230, 230);
                dgvRecent.BorderStyle = BorderStyle.None;
                dgvRecent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 240, 230);
                dgvRecent.DefaultCellStyle.SelectionForeColor = lightText;
            }

            // KPI explicit label colours
            if (lblKpi1Value != null) lblKpi1Value.ForeColor = accent;
            if (lblKpi2Value != null) lblKpi2Value.ForeColor = accent;
            if (lblKpi3Value != null) lblKpi3Value.ForeColor = accent;
            if (lblKpi4Value != null) lblKpi4Value.ForeColor = accent;

            if (lblKpi1Title != null) lblKpi1Title.ForeColor = mutedText;
            if (lblKpi2Title != null) lblKpi2Title.ForeColor = mutedText;
            if (lblKpi3Title != null) lblKpi3Title.ForeColor = mutedText;
            if (lblKpi4Title != null) lblKpi4Title.ForeColor = mutedText;

            // Ensure logo panel looks correct on light sidebar
            if (panelLogo != null) panelLogo.BackColor = ControlPaint.Dark(sidebar);
            if (lblBrand != null) lblBrand.ForeColor = Color.White;
        }

        private void NormalizeMenuButtons() {
            if (panelMenu == null)
                return;

            // Ensure all menu buttons have consistent size/padding to match runtime look
            var menuButtons = new[] { "btnDashboard", "btnCar", "btnCustomer", "btnRental", "btnReturn", "btnDriversLicences", "btnUsers", "btnLogout" };
            foreach (var name in menuButtons) {
                var ctrl = panelMenu.Controls.Find(name, false).FirstOrDefault() as Button;
                if (ctrl != null) {
                    ctrl.Padding = new Padding(18, 0, 0, 0);
                    ctrl.TextAlign = ContentAlignment.MiddleLeft;
                    ctrl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    ctrl.Size = new Size(220, 48);
                    // Preserve logout docking to bottom
                    if (name == "btnLogout")
                        ctrl.Dock = DockStyle.Bottom;
                    else
                        ctrl.Dock = DockStyle.Top;
                }
            }
        }

        private void InitializeKpis() {
            // set initial friendly values (replace with real queries)
            if (lblKpi1Value != null) lblKpi1Value.Text = "0";
            if (lblKpi2Value != null) lblKpi2Value.Text = "0%";
            if (lblKpi3Value != null) lblKpi3Value.Text = "$0";
            if (lblKpi4Value != null) lblKpi4Value.Text = "0";
        }

        private void btnDriversLicences_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("Drivers & Licences", "This module is under construction.");
        }

        private void ShowModulePlaceholder(string title, string message) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnsureMenuOrder() {
            if (panelMenu == null)
                return;

            // Simplified and safer reordering: build list of controls we want in the exact visual order,
            // clear and re-add them. This avoids fragile SetChildIndex logic after merges.
            var desiredNames = new[] {
                "panelLogo",
                "btnDashboard",
                "btnCar",
                "btnCustomer",
                "btnRental",
                "btnReturn",
                "btnDriversLicences",
                "btnUsers"
            };

            // Collect available controls (keep the control instances)
            var controlMap = new Dictionary<string, Control>();
            foreach (Control c in panelMenu.Controls) {
                if (!string.IsNullOrEmpty(c.Name))
                    controlMap[c.Name] = c;
            }

            Control logout = null;
            controlMap.TryGetValue("btnLogout", out logout);

            panelMenu.SuspendLayout();
            try {
                // Remove all children before re-adding to guarantee order
                panelMenu.Controls.Clear();

                // Add panelLogo (if present) first
                if (controlMap.TryGetValue("panelLogo", out var logo)) {
                    logo.Dock = DockStyle.Top;
                    panelMenu.Controls.Add(logo);
                }

                // Add the other top items in order
                foreach (var name in desiredNames) {
                    if (name == "panelLogo")
                        continue; // already handled
                    if (controlMap.TryGetValue(name, out var ctrl) && ctrl != logo) {
                        ctrl.Dock = DockStyle.Top;
                        panelMenu.Controls.Add(ctrl);
                    }
                }

                // Add logout last and dock to bottom
                if (logout != null) {
                    logout.Dock = DockStyle.Bottom;
                    panelMenu.Controls.Add(logout);
                }
            } finally {
                panelMenu.ResumeLayout();
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e) { }

        private void LoadSampleData() {
            // Example: populate recentTable with sample data for demonstration
            recentTable = new DataTable();
            recentTable.Columns.Add("ID", typeof(int));
            recentTable.Columns.Add("Name", typeof(string));
            recentTable.Columns.Add("Type", typeof(string));
            recentTable.Columns.Add("Date", typeof(DateTime));

            // Add some sample rows
            recentTable.Rows.Add(1, "Toyota Camry", "Vehicle", DateTime.Now.AddDays(-1));
            recentTable.Rows.Add(2, "John Doe", "Customer", DateTime.Now.AddDays(-2));
            recentTable.Rows.Add(3, "Booking #1234", "Booking", DateTime.Now.AddDays(-3));

            // Bind to grid if available
            if (dgvRecent != null)
                dgvRecent.DataSource = recentTable;
        }

        private void InitializeChartPlaceholder() {
            // Placeholder for chart initialization logic
            // You can add chart setup code here if needed
        }

        private void InitializeRecentGrid() {
            // Example: basic setup for dgvRecent if needed
            if (dgvRecent != null) {
                dgvRecent.AutoGenerateColumns = true;
                dgvRecent.DataSource = null; // or keep as is, will be set in LoadSampleData
                dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRecent.MultiSelect = false;
                dgvRecent.ReadOnly = true;
                dgvRecent.AllowUserToAddRows = false;
                dgvRecent.AllowUserToDeleteRows = false;
                dgvRecent.AllowUserToResizeRows = false;
                dgvRecent.RowHeadersVisible = false;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e) {
            if (lblTitle != null) lblTitle.Text = "HOME";
            ShowModulePlaceholder("Dashboard", "Dashboard module opened.");
        }

        private void btnCar_Click(object sender, EventArgs e) {
            if (lblTitle != null) lblTitle.Text = "FLEET";
            ShowModulePlaceholder("Fleet", "Fleet module placeholder.");
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            if (lblTitle != null) lblTitle.Text = "CUSTOMERS";
            ShowModulePlaceholder("Customers", "Customers module placeholder.");
        }

        private void btnRental_Click(object sender, EventArgs e) {
            if (lblTitle != null) lblTitle.Text = "RENTALS";
            ShowModulePlaceholder("Rentals", "Rentals module placeholder.");
        }

        private void btnReturn_Click(object sender, EventArgs e) {
            if (lblTitle != null) lblTitle.Text = "RETURNS";
            ShowModulePlaceholder("Returns", "Returns module placeholder.");
        }

        private void btnUsers_Click(object sender, EventArgs e) {
            if (lblTitle != null) lblTitle.Text = "USER MANAGEMENT";
            ShowModulePlaceholder("User Management", "User management module placeholder.");
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            // Safe logout: close the dashboard (or navigate back to login as needed)
            try { this.Close(); } catch { /* ignore non-fatal close errors */ }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            // Minimal safe handler so designer wiring compiles.
            try {
                // no-op placeholder
            } catch {
                // ignore runtime errors in a best-effort handler
            }
        }
    }
}
