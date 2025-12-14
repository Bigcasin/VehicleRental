using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRENTAL {
    public partial class dashboard : Form {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public dashboard() {
        InitializeComponent();
        random = new Random();
        }

        private Color SelectThemeColor() {
        int index = random.Next(themecolor.ColorList.Count);
        while (tempIndex== index ) {
            random.Next(themecolor.ColorList.Count);
        }
        tempIndex = index;
        string color = themecolor.ColorList[index];
        return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender) {

        if (btnSender == null) {

        if (currentButton != (Button)btnSender) {
        Color color = SelectThemeColor();
        currentButton = (Button)btnSender;
        currentButton.BackColor = color;
        currentButton.ForeColor = Color.White;
        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        }

     }

   }

        private void DisableButton() {
        foreach (Control previousBtn in panelMenu.Controls) {
        if (previousBtn.GetType() == typeof(Button)) {
        previousBtn.BackColor = Color.FromArgb(255, 255, 255);
        previousBtn.ForeColor = Color.Gainsboro;
        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        }

        }
        private void dashboard_Load(object sender, EventArgs e) {
        ActivateButton(sender);

        }

        private void button1_Click(object sender, EventArgs e) {
        ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e) {
        ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e) {
        ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e) {
        ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e) {
        ActivateButton(sender);
        }
    }
}
