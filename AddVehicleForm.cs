using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRENTAL.Classes;

namespace VehicleRENTAL
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void lblMake_Click(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblFuelType_Click(object sender, EventArgs e)
        {

        }

        private void lblTransmission_Click(object sender, EventArgs e)
        {

        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
			cmbCategory.DataSource = Enum.GetValues(typeof(VehicleCategory));
			cmbFuelType.DataSource = Enum.GetValues(typeof(FuelType));
			cmbTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));

			cmbCategory.SelectedIndex = 0;
			cmbFuelType.SelectedIndex = 0;
			cmbTransmission.SelectedIndex = 0;
		}

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
			// Basic validation
			if (string.IsNullOrWhiteSpace(txtMake.Text) ||
				string.IsNullOrWhiteSpace(txtModel.Text) ||
				string.IsNullOrWhiteSpace(txtYear.Text))
			{
				MessageBox.Show("Please fill in Make, Model and Year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(txtYear.Text, out int year))
			{
				MessageBox.Show("Year must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var vehicle = new Vehicle
			{
				Make = txtMake.Text,
				Model = txtModel.Text,
				Year = year,
				Category = (VehicleCategory)cmbCategory.SelectedItem,
				FuelType = (FuelType)cmbFuelType.SelectedItem,
				Transmission = (TransmissionType)cmbTransmission.SelectedItem,
				Status = VehicleStatus.Available
			};

			// Add directly to the Vehicles list to avoid depending on a specific method signature
			VehicleManager.Instance.Vehicles.Add(vehicle);

			MessageBox.Show("Vehicle added successfully!");

			DialogResult = DialogResult.OK;
		}

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm Dashboard = new DashboardForm();
            Dashboard.Show();
        }

        private void textMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void textModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
