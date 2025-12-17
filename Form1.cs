using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRENTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            panel3.Width += 3;
        
        if (panel3.Width >= 881) {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
        }
        }
    }
}
