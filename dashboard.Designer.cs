namespace VehicleRENTAL {

    partial class dashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.kpiCard1 = new System.Windows.Forms.Panel();
            this.lblKpi1Value = new System.Windows.Forms.Label();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.kpiCard2 = new System.Windows.Forms.Panel();
            this.lblKpi2Value = new System.Windows.Forms.Label();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.kpiCard3 = new System.Windows.Forms.Panel();
            this.lblKpi3Value = new System.Windows.Forms.Label();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.kpiCard4 = new System.Windows.Forms.Panel();
            this.lblKpi4Value = new System.Windows.Forms.Label();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlMetrics = new System.Windows.Forms.Panel();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.kpiCard1.SuspendLayout();
            this.kpiCard2.SuspendLayout();
            this.kpiCard3.SuspendLayout();
            this.kpiCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnReturn);
            this.panelMenu.Controls.Add(this.btnRental);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnCar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 420);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 192);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 48);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(0, 144);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 48);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRental
            // 
            this.btnRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRental.FlatAppearance.BorderSize = 0;
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRental.ForeColor = System.Drawing.Color.White;
            this.btnRental.Location = new System.Drawing.Point(0, 96);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(200, 48);
            this.btnRental.TabIndex = 2;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(0, 48);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 48);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCar
            // 
            this.btnCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCar.ForeColor = System.Drawing.Color.White;
            this.btnCar.Location = new System.Drawing.Point(0, 0);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(200, 48);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "Vehicles";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.CadetBlue;
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 72);
            this.panelHeader.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(340, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Controls.Add(this.flpKpi);
            this.panelDesktop.Controls.Add(this.splitContainerMain);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(12);
            this.panelDesktop.Size = new System.Drawing.Size(600, 348);
            this.panelDesktop.TabIndex = 2;
            // 
            // flpKpi
            // 
            this.flpKpi.AutoSize = true;
            this.flpKpi.Controls.Add(this.kpiCard1);
            this.flpKpi.Controls.Add(this.kpiCard2);
            this.flpKpi.Controls.Add(this.kpiCard3);
            this.flpKpi.Controls.Add(this.kpiCard4);
            this.flpKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpKpi.Location = new System.Drawing.Point(12, 12);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Padding = new System.Windows.Forms.Padding(6);
            this.flpKpi.Size = new System.Drawing.Size(576, 216);
            this.flpKpi.TabIndex = 0;
            // 
            // kpiCard1
            // 
            this.kpiCard1.BackColor = System.Drawing.Color.White;
            this.kpiCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kpiCard1.Controls.Add(this.lblKpi1Value);
            this.kpiCard1.Controls.Add(this.lblKpi1Title);
            this.kpiCard1.Location = new System.Drawing.Point(12, 12);
            this.kpiCard1.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard1.Name = "kpiCard1";
            this.kpiCard1.Size = new System.Drawing.Size(200, 90);
            this.kpiCard1.TabIndex = 0;
            // 
            // lblKpi1Value
            // 
            this.lblKpi1Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.lblKpi1Value.Location = new System.Drawing.Point(12, 30);
            this.lblKpi1Value.Name = "lblKpi1Value";
            this.lblKpi1Value.Size = new System.Drawing.Size(176, 32);
            this.lblKpi1Value.TabIndex = 1;
            this.lblKpi1Value.Text = "0";
            this.lblKpi1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi1Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(176, 18);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "Active Reservations";
            // 
            // kpiCard2
            // 
            this.kpiCard2.BackColor = System.Drawing.Color.White;
            this.kpiCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kpiCard2.Controls.Add(this.lblKpi2Value);
            this.kpiCard2.Controls.Add(this.lblKpi2Title);
            this.kpiCard2.Location = new System.Drawing.Point(224, 12);
            this.kpiCard2.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard2.Name = "kpiCard2";
            this.kpiCard2.Size = new System.Drawing.Size(200, 90);
            this.kpiCard2.TabIndex = 1;
            // 
            // lblKpi2Value
            // 
            this.lblKpi2Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.lblKpi2Value.Location = new System.Drawing.Point(12, 30);
            this.lblKpi2Value.Name = "lblKpi2Value";
            this.lblKpi2Value.Size = new System.Drawing.Size(176, 32);
            this.lblKpi2Value.TabIndex = 1;
            this.lblKpi2Value.Text = "0";
            this.lblKpi2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi2Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(176, 18);
            this.lblKpi2Title.TabIndex = 0;
            this.lblKpi2Title.Text = "Fleet Utilization %";
            // 
            // kpiCard3
            // 
            this.kpiCard3.BackColor = System.Drawing.Color.White;
            this.kpiCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kpiCard3.Controls.Add(this.lblKpi3Value);
            this.kpiCard3.Controls.Add(this.lblKpi3Title);
            this.kpiCard3.Location = new System.Drawing.Point(12, 114);
            this.kpiCard3.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard3.Name = "kpiCard3";
            this.kpiCard3.Size = new System.Drawing.Size(200, 90);
            this.kpiCard3.TabIndex = 2;
            // 
            // lblKpi3Value
            // 
            this.lblKpi3Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.lblKpi3Value.Location = new System.Drawing.Point(12, 30);
            this.lblKpi3Value.Name = "lblKpi3Value";
            this.lblKpi3Value.Size = new System.Drawing.Size(176, 32);
            this.lblKpi3Value.TabIndex = 1;
            this.lblKpi3Value.Text = "0";
            this.lblKpi3Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi3Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(176, 18);
            this.lblKpi3Title.TabIndex = 0;
            this.lblKpi3Title.Text = "Revenue (30d)";
            // 
            // kpiCard4
            // 
            this.kpiCard4.BackColor = System.Drawing.Color.White;
            this.kpiCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kpiCard4.Controls.Add(this.lblKpi4Value);
            this.kpiCard4.Controls.Add(this.lblKpi4Title);
            this.kpiCard4.Location = new System.Drawing.Point(224, 114);
            this.kpiCard4.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard4.Name = "kpiCard4";
            this.kpiCard4.Size = new System.Drawing.Size(200, 90);
            this.kpiCard4.TabIndex = 3;
            // 
            // lblKpi4Value
            // 
            this.lblKpi4Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.lblKpi4Value.Location = new System.Drawing.Point(12, 30);
            this.lblKpi4Value.Name = "lblKpi4Value";
            this.lblKpi4Value.Size = new System.Drawing.Size(176, 32);
            this.lblKpi4Value.TabIndex = 1;
            this.lblKpi4Value.Text = "0";
            this.lblKpi4Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi4Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi4Title.Location = new System.Drawing.Point(12, 10);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(176, 18);
            this.lblKpi4Title.TabIndex = 0;
            this.lblKpi4Title.Text = "Open Issues";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(12, 144);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMetrics);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dgvRecent);
            this.splitContainerMain.Size = new System.Drawing.Size(576, 192);
            this.splitContainerMain.SplitterDistance = 492;
            this.splitContainerMain.TabIndex = 2;
            // 
            // pnlMetrics
            // 
            this.pnlMetrics.BackColor = System.Drawing.Color.White;
            this.pnlMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetrics.Location = new System.Drawing.Point(0, 0);
            this.pnlMetrics.Name = "pnlMetrics";
            this.pnlMetrics.Size = new System.Drawing.Size(492, 192);
            this.pnlMetrics.TabIndex = 0;
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.Location = new System.Drawing.Point(0, 0);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.Size = new System.Drawing.Size(80, 192);
            this.dgvRecent.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.flpKpi.ResumeLayout(false);
            this.kpiCard1.ResumeLayout(false);
            this.kpiCard2.ResumeLayout(false);
            this.kpiCard3.ResumeLayout(false);
            this.kpiCard4.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel kpiCard1;
        private System.Windows.Forms.Panel kpiCard2;
        private System.Windows.Forms.Panel kpiCard3;
        private System.Windows.Forms.Panel kpiCard4;
        private System.Windows.Forms.Label lblKpi1Value;
        private System.Windows.Forms.Label lblKpi1Title;
        private System.Windows.Forms.Label lblKpi2Value;
        private System.Windows.Forms.Label lblKpi2Title;
        private System.Windows.Forms.Label lblKpi3Value;
        private System.Windows.Forms.Label lblKpi3Title;
        private System.Windows.Forms.Label lblKpi4Value;
        private System.Windows.Forms.Label lblKpi4Title;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlMetrics;
        private System.Windows.Forms.DataGridView dgvRecent;
    }
}