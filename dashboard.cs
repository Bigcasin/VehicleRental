using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VehicleRENTAL.Classes;

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

        private void dashboard_Load(object sender, EventArgs e)
        {
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
            try
            {
                SetCueBanner(txtSearch, "Search vehicles, customers, bookings...");
            }
            catch
            {
                // if it fails (very old OS), ignore
            }

            //display table
            RefreshVehicleTable();
        }

		private void SetCueBanner(TextBox tb, string cue) {
            if (tb == null || tb.IsDisposed) return;
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
                }

                // Finally add logout and keep it docked to bottom
                if (logout != null) {
                    logout.Dock = DockStyle.Bottom;
                    panelMenu.Controls.Add(logout);
                }
            } finally {
                panelMenu.ResumeLayout();
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e) {

        }
    }
}
