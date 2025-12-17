using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRENTAL
{
    public partial class Form1 : Form
    {
        private int _percent = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // start with empty progress
            _percent = 0;
            UpdateProgressVisual();
            timer1.Start();
        }

        private void UpdateProgressVisual()
        {
            // guard against zero-width container
            var targetWidth = Math.Max(1, pnlBarBackground.ClientSize.Width);
            pnlProgress.Width = (_percent * targetWidth) / 100;
            lblPercent.Text = _percent + "%";
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            // progress steps: accelerate early, slow near completion for polish
            if (_percent < 70)
            {
                _percent += 2;
            }
            else if (_percent < 90)
            {
                _percent += 1;
            }
            else
            {
                _percent += 1; // slow finalization
            }

            if (_percent > 100) _percent = 100;

            UpdateProgressVisual();

            if (_percent >= 100)
            {
                timer1.Stop();

                // small pause so user sees 100%
                await Task.Delay(250);

                // optional fade-out effect
                for (double op = 1.0; op >= 0.0; op -= 0.08)
                {
                    this.Opacity = op;
                    await Task.Delay(20);
                }

                // show login and close/hide the loader
                var login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
