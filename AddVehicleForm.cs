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
			Vehicle vehicle = new Vehicle
			{
				Make = txtMake.Text,
				Model = txtModel.Text,
				Year = int.Parse(txtYear.Text),
				Category = (VehicleCategory)cmbCategory.SelectedItem,
				FuelType = (FuelType)cmbFuelType.SelectedItem,
				Transmission = (TransmissionType)cmbTransmission.SelectedItem,
				Status = VehicleStatus.Available
			};

			VehicleManager.Instance.AddVehicle(vehicle);

			MessageBox.Show("Vehicle added successfully!");

			DialogResult = DialogResult.OK;
		}

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            dashboard Dashboard = new dashboard();
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
