namespace VehicleRENTAL {

    partial class DashboardForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDriversLicences = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlMetrics = new System.Windows.Forms.Panel();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.kpiCard1.SuspendLayout();
            this.kpiCard2.SuspendLayout();
            this.kpiCard3.SuspendLayout();
            this.kpiCard4.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnCar);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnRental);
            this.panelMenu.Controls.Add(this.btnReturn);
            this.panelMenu.Controls.Add(this.btnDriversLicences);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 520);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogo.Controls.Add(this.lblBrand);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 336);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 72);
            this.panelLogo.TabIndex = 5;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint_1);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(12, 24);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(165, 20);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "VEHICLE RENTAL HUB";
            this.lblBrand.Click += new System.EventHandler(this.lblBrand_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(0, 288);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 48);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Transparent;
            this.btnCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCar.ForeColor = System.Drawing.Color.Black;
            this.btnCar.Location = new System.Drawing.Point(0, 240);
            this.btnCar.Name = "btnCar";
            this.btnCar.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCar.Size = new System.Drawing.Size(220, 48);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "Fleet";
            this.btnCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(0, 192);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(220, 48);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.Transparent;
            this.btnRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRental.FlatAppearance.BorderSize = 0;
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRental.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRental.ForeColor = System.Drawing.Color.Black;
            this.btnRental.Location = new System.Drawing.Point(0, 144);
            this.btnRental.Name = "btnRental";
            this.btnRental.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnRental.Size = new System.Drawing.Size(220, 48);
            this.btnRental.TabIndex = 2;
            this.btnRental.Text = "Rentals";
            this.btnRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(0, 96);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(220, 48);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Returns";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDriversLicences
            // 
            this.btnDriversLicences.BackColor = System.Drawing.Color.Transparent;
            this.btnDriversLicences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriversLicences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDriversLicences.FlatAppearance.BorderSize = 0;
            this.btnDriversLicences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriversLicences.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDriversLicences.ForeColor = System.Drawing.Color.Black;
            this.btnDriversLicences.Location = new System.Drawing.Point(0, 48);
            this.btnDriversLicences.Name = "btnDriversLicences";
            this.btnDriversLicences.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDriversLicences.Size = new System.Drawing.Size(220, 48);
            this.btnDriversLicences.TabIndex = 7;
            this.btnDriversLicences.Text = "Drivers & Licences";
            this.btnDriversLicences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriversLicences.UseVisualStyleBackColor = false;
            this.btnDriversLicences.Click += new System.EventHandler(this.btnDriversLicences_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(220, 48);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "User Management";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(0, 472);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 48);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(980, 72);
            this.panelHeader.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(700, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.flpKpi);
            this.panelDesktop.Controls.Add(this.panelContent);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(12);
            this.panelDesktop.Size = new System.Drawing.Size(980, 448);
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
            this.flpKpi.Size = new System.Drawing.Size(956, 120);
            this.flpKpi.TabIndex = 0;
            // 
            // kpiCard1
            // 
            this.kpiCard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kpiCard1.Controls.Add(this.lblKpi1Value);
            this.kpiCard1.Controls.Add(this.lblKpi1Title);
            this.kpiCard1.Location = new System.Drawing.Point(12, 12);
            this.kpiCard1.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard1.Name = "kpiCard1";
            this.kpiCard1.Size = new System.Drawing.Size(220, 96);
            this.kpiCard1.TabIndex = 0;
            // 
            // lblKpi1Value
            // 
            this.lblKpi1Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.lblKpi1Value.Location = new System.Drawing.Point(12, 34);
            this.lblKpi1Value.Name = "lblKpi1Value";
            this.lblKpi1Value.Size = new System.Drawing.Size(196, 32);
            this.lblKpi1Value.TabIndex = 1;
            this.lblKpi1Value.Text = "0";
            this.lblKpi1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi1Title.Location = new System.Drawing.Point(12, 12);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(196, 18);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "Active Reservations";
            // 
            // kpiCard2
            // 
            this.kpiCard2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kpiCard2.Controls.Add(this.lblKpi2Value);
            this.kpiCard2.Controls.Add(this.lblKpi2Title);
            this.kpiCard2.Location = new System.Drawing.Point(244, 12);
            this.kpiCard2.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard2.Name = "kpiCard2";
            this.kpiCard2.Size = new System.Drawing.Size(220, 96);
            this.kpiCard2.TabIndex = 1;
            // 
            // lblKpi2Value
            // 
            this.lblKpi2Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.lblKpi2Value.Location = new System.Drawing.Point(12, 34);
            this.lblKpi2Value.Name = "lblKpi2Value";
            this.lblKpi2Value.Size = new System.Drawing.Size(196, 32);
            this.lblKpi2Value.TabIndex = 1;
            this.lblKpi2Value.Text = "0";
            this.lblKpi2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi2Title.Location = new System.Drawing.Point(12, 12);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(196, 18);
            this.lblKpi2Title.TabIndex = 0;
            this.lblKpi2Title.Text = "Fleet Utilization %";
            // 
            // kpiCard3
            // 
            this.kpiCard3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kpiCard3.Controls.Add(this.lblKpi3Value);
            this.kpiCard3.Controls.Add(this.lblKpi3Title);
            this.kpiCard3.Location = new System.Drawing.Point(476, 12);
            this.kpiCard3.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard3.Name = "kpiCard3";
            this.kpiCard3.Size = new System.Drawing.Size(220, 96);
            this.kpiCard3.TabIndex = 2;
            // 
            // lblKpi3Value
            // 
            this.lblKpi3Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.lblKpi3Value.Location = new System.Drawing.Point(12, 34);
            this.lblKpi3Value.Name = "lblKpi3Value";
            this.lblKpi3Value.Size = new System.Drawing.Size(196, 32);
            this.lblKpi3Value.TabIndex = 1;
            this.lblKpi3Value.Text = "0";
            this.lblKpi3Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi3Title.Location = new System.Drawing.Point(12, 12);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(196, 18);
            this.lblKpi3Title.TabIndex = 0;
            this.lblKpi3Title.Text = "Revenue (30d)";
            // 
            // kpiCard4
            // 
            this.kpiCard4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kpiCard4.Controls.Add(this.lblKpi4Value);
            this.kpiCard4.Controls.Add(this.lblKpi4Title);
            this.kpiCard4.Location = new System.Drawing.Point(708, 12);
            this.kpiCard4.Margin = new System.Windows.Forms.Padding(6);
            this.kpiCard4.Name = "kpiCard4";
            this.kpiCard4.Size = new System.Drawing.Size(220, 96);
            this.kpiCard4.TabIndex = 3;
            // 
            // lblKpi4Value
            // 
            this.lblKpi4Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.lblKpi4Value.Location = new System.Drawing.Point(12, 34);
            this.lblKpi4Value.Name = "lblKpi4Value";
            this.lblKpi4Value.Size = new System.Drawing.Size(196, 32);
            this.lblKpi4Value.TabIndex = 1;
            this.lblKpi4Value.Text = "0";
            this.lblKpi4Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi4Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblKpi4Title.Location = new System.Drawing.Point(12, 12);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(196, 18);
            this.lblKpi4Title.TabIndex = 0;
            this.lblKpi4Title.Text = "Open Issues";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.splitContainerMain);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(6);
            this.panelContent.Size = new System.Drawing.Size(956, 424);
            this.panelContent.TabIndex = 2;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(6, 6);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMetrics);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dgvRecent);
            this.splitContainerMain.Panel2.Controls.Add(this.dgvVehicles);
            this.splitContainerMain.Size = new System.Drawing.Size(944, 412);
            this.splitContainerMain.SplitterDistance = 660;
            this.splitContainerMain.TabIndex = 2;
            // 
            // pnlMetrics
            // 
            this.pnlMetrics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetrics.Location = new System.Drawing.Point(0, 0);
            this.pnlMetrics.Name = "pnlMetrics";
            this.pnlMetrics.Size = new System.Drawing.Size(660, 412);
            this.pnlMetrics.TabIndex = 0;
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.Location = new System.Drawing.Point(0, 160);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRecent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecent.Size = new System.Drawing.Size(280, 252);
            this.dgvRecent.TabIndex = 0;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVehicles.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.Size = new System.Drawing.Size(280, 160);
            this.dgvVehicles.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 520);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "DashboardForm";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.flpKpi.ResumeLayout(false);
            this.kpiCard1.ResumeLayout(false);
            this.kpiCard2.ResumeLayout(false);
            this.kpiCard3.ResumeLayout(false);
            this.kpiCard4.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblBrand;
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
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlMetrics;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button btnDriversLicences;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
    }
}