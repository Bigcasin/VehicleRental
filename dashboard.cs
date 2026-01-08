using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VehicleRENTAL.Classes;

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
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // initialize UI
            lblTitle.Text = "HOME";
            InitializeKpis();
            InitializeChartPlaceholder();
            InitializeRecentGrid();
            LoadSampleData();

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

		private void RefreshVehicleTable()
		{
			dgvVehicles.AutoGenerateColumns = false;
			dgvVehicles.DataSource = VehicleManager.Instance.Vehicles;
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
                    $"R-{rng.Next(1000,9999)}",
                    $"Customer {rng.Next(1,200)}",
                    $"Vehicle {rng.Next(100,999)}",
                    DateTime.Today.AddDays(rng.Next(-5, 3)),
                    DateTime.Today.AddDays(rng.Next(4, 12))
                );
            }
        }

        // Simple search/filter implementation across recentTable
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (recentTable == null) return;
            var filter = txtSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(filter)) {
                dgvRecent.DataSource = recentTable;
            } else {
                var dv = recentTable.DefaultView;
                dv.RowFilter = $"ReservationID LIKE '%{filter}%' OR Customer LIKE '%{filter}%' OR Vehicle LIKE '%{filter}%'";
                dgvRecent.DataSource = dv;
            }
        }

        // Navigation button handlers — show different pages in the main area.
        private void btnCar_Click(object sender, EventArgs e) {
            lblTitle.Text = "VEHICLES";
            LoadSampleData();
            // TODO: open Vehicle Management user control or form inside panelDesktop
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            lblTitle.Text = "CUSTOMERS";
            LoadSampleData();
            // TODO: open Customer Profile management UI
        }

        private void btnRental_Click(object sender, EventArgs e) {
            lblTitle.Text = "RESERVATIONS";
            LoadSampleData();
            // TODO: open Reservation wizard
        }

        private void btnReturn_Click(object sender, EventArgs e) {
            lblTitle.Text = "RETURNS";
            LoadSampleData();
            // TODO: open Return interface
        }

        private void btnUsers_Click(object sender, EventArgs e) {
            lblTitle.Text = "USERS";
            LoadSampleData();
            // TODO: open user management
        }

        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
			AddVehicleForm form = new AddVehicleForm();

			if (form.ShowDialog() == DialogResult.OK)
			{
				dgvVehicles.DataSource = null;
				dgvVehicles.DataSource = VehicleManager.Instance.Vehicles;
			}
		}

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     


    }
}
