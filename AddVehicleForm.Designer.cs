namespace VehicleRENTAL
{
    partial class AddVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblMake = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblFuelType = new System.Windows.Forms.Label();
			this.lblTransmission = new System.Windows.Forms.Label();
			this.txtMake = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.cmbFuelType = new System.Windows.Forms.ComboBox();
			this.cmbTransmission = new System.Windows.Forms.ComboBox();
			this.btnAddVehicle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMake
			// 
			this.lblMake.AutoSize = true;
			this.lblMake.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMake.Location = new System.Drawing.Point(81, 44);
			this.lblMake.Name = "lblMake";
			this.lblMake.Size = new System.Drawing.Size(64, 30);
			this.lblMake.TabIndex = 0;
			this.lblMake.Text = "Make";
			this.lblMake.Click += new System.EventHandler(this.lblMake_Click);
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModel.Location = new System.Drawing.Point(81, 87);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(72, 30);
			this.lblModel.TabIndex = 1;
			this.lblModel.Text = "Model";
			this.lblModel.Click += new System.EventHandler(this.lblModel_Click);
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.Location = new System.Drawing.Point(81, 129);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(52, 30);
			this.lblYear.TabIndex = 2;
			this.lblYear.Text = "Year";
			this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(81, 174);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(96, 30);
			this.lblCategory.TabIndex = 3;
			this.lblCategory.Text = "Category";
			this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
			// 
			// lblFuelType
			// 
			this.lblFuelType.AutoSize = true;
			this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFuelType.Location = new System.Drawing.Point(81, 220);
			this.lblFuelType.Name = "lblFuelType";
			this.lblFuelType.Size = new System.Drawing.Size(100, 30);
			this.lblFuelType.TabIndex = 4;
			this.lblFuelType.Text = "Fuel Type";
			this.lblFuelType.Click += new System.EventHandler(this.lblFuelType_Click);
			// 
			// lblTransmission
			// 
			this.lblTransmission.AutoSize = true;
			this.lblTransmission.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransmission.Location = new System.Drawing.Point(81, 273);
			this.lblTransmission.Name = "lblTransmission";
			this.lblTransmission.Size = new System.Drawing.Size(131, 30);
			this.lblTransmission.TabIndex = 5;
			this.lblTransmission.Text = "Transmission";
			this.lblTransmission.Click += new System.EventHandler(this.lblTransmission_Click);
			// 
			// txtMake
			// 
			this.txtMake.Location = new System.Drawing.Point(226, 54);
			this.txtMake.Name = "txtMake";
			this.txtMake.Size = new System.Drawing.Size(247, 20);
			this.txtMake.TabIndex = 6;
			this.txtMake.TextChanged += new System.EventHandler(this.textMake_TextChanged);
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(226, 97);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(247, 20);
			this.txtModel.TabIndex = 7;
			this.txtModel.TextChanged += new System.EventHandler(this.textModel_TextChanged);
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(226, 139);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(247, 20);
			this.txtYear.TabIndex = 8;
			this.txtYear.TextChanged += new System.EventHandler(this.textYear_TextChanged);
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(226, 182);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(121, 21);
			this.cmbCategory.TabIndex = 9;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// cmbFuelType
			// 
			this.cmbFuelType.FormattingEnabled = true;
			this.cmbFuelType.Location = new System.Drawing.Point(226, 230);
			this.cmbFuelType.Name = "cmbFuelType";
			this.cmbFuelType.Size = new System.Drawing.Size(121, 21);
			this.cmbFuelType.TabIndex = 10;
			this.cmbFuelType.SelectedIndexChanged += new System.EventHandler(this.cmbFuelType_SelectedIndexChanged);
			// 
			// cmbTransmission
			// 
			this.cmbTransmission.FormattingEnabled = true;
			this.cmbTransmission.Location = new System.Drawing.Point(226, 282);
			this.cmbTransmission.Name = "cmbTransmission";
			this.cmbTransmission.Size = new System.Drawing.Size(121, 21);
			this.cmbTransmission.TabIndex = 11;
			this.cmbTransmission.SelectedIndexChanged += new System.EventHandler(this.cmbTransmission_SelectedIndexChanged);
			// 
			// btnAddVehicle
			// 
			this.btnAddVehicle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnAddVehicle.Location = new System.Drawing.Point(199, 350);
			this.btnAddVehicle.Name = "btnAddVehicle";
			this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
			this.btnAddVehicle.TabIndex = 12;
			this.btnAddVehicle.Text = "Add Vehicle";
			this.btnAddVehicle.UseVisualStyleBackColor = true;
			this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
			// 
			// AddVehicleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 450);
			this.Controls.Add(this.btnAddVehicle);
			this.Controls.Add(this.cmbTransmission);
			this.Controls.Add(this.cmbFuelType);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.txtMake);
			this.Controls.Add(this.lblTransmission);
			this.Controls.Add(this.lblFuelType);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblYear);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.lblMake);
			this.Name = "AddVehicleForm";
			this.Text = "AddVehicleForm";
			this.Load += new System.EventHandler(this.AddVehicleForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.ComboBox cmbTransmission;
        private System.Windows.Forms.Button btnAddVehicle;
    }
}