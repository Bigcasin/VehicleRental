using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleRENTAL;

namespace VehicleRENTAL {
    public partial class Login : Form {
        // simple in-memory credential store for demo
        private readonly Dictionary<string, string> _credentials = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "admin", "admin123" },
            { "agent", "agent123" }
        };

        public Login() {
            InitializeComponent();

            // Pressing Enter activates the Sign in button
            this.AcceptButton = this.LoginButton;

            // Allow Esc to clear fields
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;

            // small UX: focus username on load
            this.Shown += (s, e) => textUsername.Focus();
        }

        private void Login_Load(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            var user = textUsername.Text?.Trim() ?? string.Empty;
            var pass = txtPassword.Text ?? string.Empty;

            if (string.IsNullOrEmpty(user)) {
                MessageBox.Show("Please enter a username.", "Missing username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass)) {
                MessageBox.Show("Please enter a password.", "Missing password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // check credentials against in-memory store
            if (_credentials.TryGetValue(user, out var expected) && expected == pass) {
                // credentials valid — open dashboard
                var dash = new DashboardForm();
                dash.StartPosition = FormStartPosition.CenterScreen;
                dash.Show();

                // hide login (do not call Close() to keep app message loop intact if needed)
                this.Hide();
            } else {
                MessageBox.Show("Invalid username or password.", "Sign in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // simple shake-like UX: clear password and focus
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {
        }

        private void label4_Click(object sender, EventArgs e) {
        }

        private void Login_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                // clear fields when user presses Esc
                textUsername.Clear();
                txtPassword.Clear();
                textUsername.Focus();
                e.Handled = true;
            }
        }
    }
}
