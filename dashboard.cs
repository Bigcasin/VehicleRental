using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VehicleRENTAL {
    public partial class dashboard : Form {
        private Random rng = new Random();
        private DataTable recentTable;

        // P/Invoke for cue banner (placeholder) on .NET Framework
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        private const uint EM_SETCUEBANNER = 0x1501;

        public dashboard() {
        InitializeComponent();
        // reduce flicker
        DoubleBuffered = true;
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
        // if it fails (very old OS), ignore
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
        // Core palette (close to the provided mock)
        var sidebar = ColorTranslator.FromHtml("#0F1724");    // deep navy
        var header = ColorTranslator.FromHtml("#102534");     // slightly lighter
        var surface = ColorTranslator.FromHtml("#0B1B2B");    // main surface
        var card = ColorTranslator.FromHtml("#0F2433");       // card background
        var accent = ColorTranslator.FromHtml("#16A085");     // teal accent
        var lightText = ColorTranslator.FromHtml("#E6EEF3");
        var mutedText = ColorTranslator.FromHtml("#97A6B2");

        // Form background
        this.BackColor = surface;

        // Sidebar
        panelMenu.BackColor = sidebar;
        foreach (Control c in panelMenu.Controls) {
        if (c is Button b) {
        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 0;
        b.ForeColor = lightText;
        b.BackColor = Color.Transparent;
        b.TextAlign = ContentAlignment.MiddleLeft;
        b.Padding = new Padding(18, 0, 0, 0);
        b.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }
        }

        // Header
        panelHeader.BackColor = header;
        lblTitle.ForeColor = lightText;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        txtSearch.BackColor = ColorTranslator.FromHtml("#122B3A");
        txtSearch.ForeColor = lightText;
        txtSearch.BorderStyle = BorderStyle.FixedSingle;

        // Desktop surface
        panelDesktop.BackColor = surface;

        // KPI cards
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
        lab.ForeColor = accent; // big value
        lab.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        }
        }
        }
        }

        // Metrics panel
        pnlMetrics.BackColor = card;
        // Recent grid dark theming
        dgvRecent.BackgroundColor = card;
        dgvRecent.ForeColor = lightText;
        dgvRecent.EnableHeadersVisualStyles = false;
        dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0E2A3A");
        dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = lightText;
        dgvRecent.RowTemplate.DefaultCellStyle.BackColor = card;
        dgvRecent.RowTemplate.DefaultCellStyle.ForeColor = lightText;
        dgvRecent.GridColor = ColorTranslator.FromHtml("#112B3A");
        dgvRecent.BorderStyle = BorderStyle.None;
        dgvRecent.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#133E48");
        dgvRecent.DefaultCellStyle.SelectionForeColor = lightText;

        // Tweak KPI value colors (explicit labels in Designer)
        lblKpi1Value.ForeColor = accent;
        lblKpi2Value.ForeColor = accent;
        lblKpi3Value.ForeColor = accent;
        lblKpi4Value.ForeColor = accent;

        lblKpi1Title.ForeColor = mutedText;
        lblKpi2Title.ForeColor = mutedText;
        lblKpi3Title.ForeColor = mutedText;
        lblKpi4Title.ForeColor = mutedText;
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
        ShowModulePlaceholder("VEHICLES", "Vehicle Management: implement list, filters, image upload (right panel).");
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
        ShowModulePlaceholder("CUSTOMERS", "Customer Profile Management: view and edit customer details, upload documents.");
        }

        private void btnRental_Click(object sender, EventArgs e) {
        ShowModulePlaceholder("RESERVATIONS", "Reservation Wizard: implement multi-step vehicle selection, calendar availability and extras.");
        }

        private void btnReturn_Click(object sender, EventArgs e) {
        ShowModulePlaceholder("RETURNS", "Return Interface: damage assessment and finalize return with billing.");
        }

        private void btnUsers_Click(object sender, EventArgs e) {
        ShowModulePlaceholder("USERS", "User Management: create/edit users and roles.");
        }
    }
}
