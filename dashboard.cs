using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VehicleRENTAL {
    public partial class dashboard : MaterialForm {
        private Random rng = new Random();
        private DataTable recentTable;

        // P/Invoke for cue banner (placeholder) on .NET Framework
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        private const uint EM_SETCUEBANNER = 0x1501;

        public dashboard() {
            InitializeComponent();

            // Apply MaterialSkin theme + color scheme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Teal200, TextShade.WHITE
            );
        }

        private void dashboard_Load(object sender, EventArgs e) {
            // initialize UI
            lblTitle.Text = "HOME";
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
                // if it fails (very old OS), igntre
            }

            EnsureMenuOrder();
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
            // Align dashboard colors with Login and LoadingScreen designs
            var sidebar = System.Drawing.Color.LightSteelBlue;          // matches Login panel1
            var header = SystemColors.ActiveCaption;                   // matches LoadingScreen panelMain
            var surface = Color.White;                                 // content area like Login panel2
            var card = Color.WhiteSmoke;                               // subtle card background
            var accent = Color.FromArgb(100, 210, 145);                // loading progress accent
            var lightText = Color.FromArgb(40, 40, 40);                // dark text on light surfaces
            var mutedText = Color.DimGray;

            // Form background
            this.BackColor = surface;

            // Sidebar
            panelMenu.BackColor = sidebar;
            foreach (Control c in panelMenu.Controls) {
                if (c is Button b) {
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.ForeColor = Color.White;            // white text on colored sidebar (like Login)
                    b.BackColor = sidebar;
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Padding = new Padding(18, 0, 0, 0);
                    b.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    b.Cursor = Cursors.Hand;
                    // make hover feedback subtle (works at runtime)
                    b.FlatAppearance.MouseOverBackColor = ControlPaint.Light(sidebar);
                    b.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(sidebar);
                }
            }

            // Header
            panelHeader.BackColor = header;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtSearch.BackColor = Color.FromArgb(240, 248, 250); // very light to read on white surface
            txtSearch.ForeColor = lightText;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;

            // Desktop surface
            panelDesktop.BackColor = surface;

            // KPI cards (light theme version)
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

            // Metrics panel
            pnlMetrics.BackColor = card;

            // Recent grid theming (light)
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

            // KPI explicit label colours
            lblKpi1Value.ForeColor = accent;
            lblKpi2Value.ForeColor = accent;
            lblKpi3Value.ForeColor = accent;
            lblKpi4Value.ForeColor = accent;

            lblKpi1Title.ForeColor = mutedText;
            lblKpi2Title.ForeColor = mutedText;
            lblKpi3Title.ForeColor = mutedText;
            lblKpi4Title.ForeColor = mutedText;

            // Ensure logo panel looks correct on light sidebar
            panelLogo.BackColor = ControlPaint.Dark(sidebar);
            lblBrand.ForeColor = Color.White;
        }

        private void InitializeKpis() {
            // set initial friendly values (replace with real queries)
            lblKpi1Value.Text = "0";
            lblKpi2Value.Text = "0%";
            lblKpi3Value.Text = "$0";
            lblKpi4Value.Text = "0";
        }

        // Minimal, safe "chart" placeholder — avoids requiring System.Windows.Forms.DataVisualization
        private void InitializeChartPlaceholder() {
            pnlMetrics.Controls.Clear();
            var lbl = new Label {
                Text = "Metrics (placeholder)",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.DimGray
            };
            pnlMetrics.Controls.Add(lbl);
        }

        private void InitializeRecentGrid() {
            recentTable = new DataTable();
            recentTable.Columns.Add("ReservationID", typeof(string));
            recentTable.Columns.Add("Customer", typeof(string));
            recentTable.Columns.Add("Vehicle", typeof(string));
            recentTable.Columns.Add("From", typeof(DateTime));
            recentTable.Columns.Add("To", typeof(DateTime));
            dgvRecent.DataSource = recentTable;
        }

        private void LoadSampleData() {
            // sample KPI values — replace with real data binding
            lblKpi1Value.Text = rng.Next(5, 50).ToString();
            lblKpi2Value.Text = rng.Next(40, 95).ToString() + "%";
            lblKpi3Value.Text = "$" + rng.Next(2000, 20000).ToString("N0");
            lblKpi4Value.Text = rng.Next(0, 10).ToString();

            // update metric placeholder text with simple monthly numbers
            var monthly = Enumerable.Range(0, 12).Select(i => rng.Next(30, 95)).ToArray();
            var txt = "Utilization (last 12 months): " + string.Join(", ", monthly.Select(x => x + "%"));
            pnlMetrics.Controls.Clear();
            var lbl = new Label {
                Text = txt,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(35, 98, 170)
            };
            pnlMetrics.Controls.Add(lbl);

            recentTable.Rows.Clear();
            for (int i = 0; i < 8; i++) {
                recentTable.Rows.Add(
                    $"R-{rng.Next(1000, 9999)}",
                    $"Customer {rng.Next(1, 200)}",
                    $"Vehicle {rng.Next(100, 999)}",
                    DateTime.Today.AddDays(rng.Next(-5, 3)),
                    DateTime.Today.AddDays(rng.Next(4, 12))
                );
            }
        }

        // Simple search/filter implementation across recentTable
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (recentTable == null)
                return;
            var filter = txtSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(filter)) {
                dgvRecent.DataSource = recentTable;
            } else {
                var dv = recentTable.DefaultView;
                dv.RowFilter = $"ReservationID LIKE '%{filter}%' OR Customer LIKE '%{filter}%' OR Vehicle LIKE '%{filter}%'";
                dgvRecent.DataSource = dv;
            }
        }

        // Small helper to show a module placeholder inside the metrics panel area.
        private void ShowModulePlaceholder(string title, string message) {
            lblTitle.Text = title;
            pnlMetrics.Controls.Clear();

            var panel = new Panel { Dock = DockStyle.Fill, BackColor = pnlMetrics.BackColor };
            var lbl = new Label {
                Text = message,
                Dock = DockStyle.Top,
                Height = 44,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Padding = new Padding(8),
                ForeColor = Color.White
            };
            panel.Controls.Add(lbl);

            var btn = new Button {
                Text = "Open module (placeholder)",
                Dock = DockStyle.Top,
                Height = 34,
                Margin = new Padding(8),
                BackColor = ColorTranslator.FromHtml("#164F4A"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btn.FlatAppearance.BorderSize = 0;
            // short guidance click
            btn.Click += (s, e) => MessageBox.Show($"{title} module placeholder.\r\nImplement a UserControl and load into pnlMetrics via pnlMetrics.Controls.Add(control).", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel.Controls.Add(btn);

            pnlMetrics.Controls.Add(panel);
        }

        // Navigation button handlers — show different pages in the main area.
        private void btnCar_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("FLEET", "Fleet Management: implement list, filters, image upload (right panel).");
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("CUSTOMERS", "Customer Profile Management: view and edit customer details, upload documents.");
        }

        private void btnRental_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("RENTALS", "Reservation & Rental: reservation wizard, pickup, and payment processing.");
        }

        private void btnReturn_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("RETURNS", "Return & Damage Assessment: inspect damage, record fees and finalize return.");
        }

        private void btnDrivers_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("DRIVERS", "Driver Management: register drivers, assign to vehicles and manage driver documents.");
        }

        private void btnLicences_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("LICENSES", "Licences: record and validate driver licences, expiry and verification.");
        }

        private void btnUsers_Click(object sender, EventArgs e) {
            ShowModulePlaceholder("USERS", "User Management: create/edit users, roles and permissions.");
        }

        private void btnDashboard_Click(object sender, EventArgs e) {
            // restore home/dashboard
            lblTitle.Text = "HOME";
            InitializeKpis();
            InitializeChartPlaceholder();
            InitializeRecentGrid();
            LoadSampleData();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            // Show login and close this dashboard
            var login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            this.Close();
        }

        // Add this method to your dashboard class
        private void btnDriversLicences_Click(object sender, EventArgs e)
        {
            ShowModulePlaceholder("Drivers & Licences", "This module is under construction.");
        }

        private void EnsureMenuOrder() {
            // desired top-to-bottom order (panelLogo must be at the top)
            var desired = new[] {
                "panelLogo",
                "btnDashboard",
                "btnCar",
                "btnCustomer",
                "btnRental",
                "btnReturn",
                "btnDriversLicences",
                "btnUsers"
            };

            // find controls that exist
            var found = desired
                .Select(n => panelMenu.Controls.Find(n, searchAllChildren: false).FirstOrDefault())
                .Where(c => c != null)
                .ToList();

            var logout = panelMenu.Controls.Find("btnLogout", searchAllChildren: false).FirstOrDefault();

            panelMenu.SuspendLayout();
            try {
                // Remove the controls we will re-insert so we can guarantee order
                foreach (var c in found) panelMenu.Controls.Remove(c);
                if (logout != null) panelMenu.Controls.Remove(logout);

                // Insert controls in the desired top-to-bottom order.
                // For DockStyle.Top stacking we add each control and set Dock = Top.
                foreach (var ctrl in found) {
                    ctrl.Dock = DockStyle.Top;
                    panelMenu.Controls.Add(ctrl);
                    // Ensure it's positioned at the top-most z-order as we add
                    panelMenu.Controls.SetChildIndex(ctrl, 0);
                }

                // Finally add logout and keep it docked to bottom
                if (logout != null) {
                    logout.Dock = DockStyle.Bottom;
                    panelMenu.Controls.Add(logout);
                    // put logout at the end (bottom)
                    panelMenu.Controls.SetChildIndex(logout, panelMenu.Controls.Count - 1);
                }
            } finally {
                panelMenu.ResumeLayout();
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e) {

        }
    }
}
