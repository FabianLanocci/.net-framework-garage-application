namespace TrabajoPracticoFinal
{
    partial class FormAddVehicle
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
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTYpeOfVehicle = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbTypeOfVehicle = new System.Windows.Forms.ComboBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lblNumberTitle = new System.Windows.Forms.Label();
            this.lblUbicationTitle = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblUbication = new System.Windows.Forms.Label();
            this.bttnEnd = new System.Windows.Forms.Button();
            this.maskDomain = new System.Windows.Forms.MaskedTextBox();
            this.bttnNew = new System.Windows.Forms.Button();
            this.bttnOld = new System.Windows.Forms.Button();
            this.panelChooseRental = new System.Windows.Forms.Panel();
            this.radBttnHour = new System.Windows.Forms.RadioButton();
            this.radBttnMonth = new System.Windows.Forms.RadioButton();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.bttnRenew = new System.Windows.Forms.Button();
            this.numRenew = new System.Windows.Forms.NumericUpDown();
            this.txtDomainComplete = new System.Windows.Forms.TextBox();
            this.panelChooseRental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRenew)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Location = new System.Drawing.Point(324, 9);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(149, 13);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Information of the new vehicle";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(26, 145);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(43, 13);
            this.lblDomain.TabIndex = 1;
            this.lblDomain.Text = "Domain";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(27, 171);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(27, 196);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model:";
            // 
            // lblTYpeOfVehicle
            // 
            this.lblTYpeOfVehicle.AutoSize = true;
            this.lblTYpeOfVehicle.Location = new System.Drawing.Point(26, 118);
            this.lblTYpeOfVehicle.Name = "lblTYpeOfVehicle";
            this.lblTYpeOfVehicle.Size = new System.Drawing.Size(83, 13);
            this.lblTYpeOfVehicle.TabIndex = 4;
            this.lblTYpeOfVehicle.Text = "Type of vehicle:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(327, 168);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(327, 194);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 7;
            // 
            // cmbTypeOfVehicle
            // 
            this.cmbTypeOfVehicle.FormattingEnabled = true;
            this.cmbTypeOfVehicle.Items.AddRange(new object[] {
            "Moto",
            "Car",
            "Pick up"});
            this.cmbTypeOfVehicle.Location = new System.Drawing.Point(327, 115);
            this.cmbTypeOfVehicle.Name = "cmbTypeOfVehicle";
            this.cmbTypeOfVehicle.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeOfVehicle.TabIndex = 8;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(699, 360);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 9;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(12, 360);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 10;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lblNumberTitle
            // 
            this.lblNumberTitle.AutoSize = true;
            this.lblNumberTitle.Location = new System.Drawing.Point(355, 55);
            this.lblNumberTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberTitle.Name = "lblNumberTitle";
            this.lblNumberTitle.Size = new System.Drawing.Size(47, 13);
            this.lblNumberTitle.TabIndex = 30;
            this.lblNumberTitle.Text = "Number:";
            // 
            // lblUbicationTitle
            // 
            this.lblUbicationTitle.AutoSize = true;
            this.lblUbicationTitle.Location = new System.Drawing.Point(355, 72);
            this.lblUbicationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUbicationTitle.Name = "lblUbicationTitle";
            this.lblUbicationTitle.Size = new System.Drawing.Size(55, 13);
            this.lblUbicationTitle.TabIndex = 31;
            this.lblUbicationTitle.Text = "Ubication:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(428, 55);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 32;
            // 
            // lblUbication
            // 
            this.lblUbication.AutoSize = true;
            this.lblUbication.Location = new System.Drawing.Point(428, 72);
            this.lblUbication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUbication.Name = "lblUbication";
            this.lblUbication.Size = new System.Drawing.Size(0, 13);
            this.lblUbication.TabIndex = 33;
            // 
            // bttnEnd
            // 
            this.bttnEnd.Location = new System.Drawing.Point(619, 358);
            this.bttnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnEnd.Name = "bttnEnd";
            this.bttnEnd.Size = new System.Drawing.Size(75, 23);
            this.bttnEnd.TabIndex = 34;
            this.bttnEnd.Text = "End rent";
            this.bttnEnd.UseVisualStyleBackColor = true;
            this.bttnEnd.Click += new System.EventHandler(this.bttnEnd_Click);
            // 
            // maskDomain
            // 
            this.maskDomain.Location = new System.Drawing.Point(327, 142);
            this.maskDomain.Mask = "000LLL";
            this.maskDomain.Name = "maskDomain";
            this.maskDomain.Size = new System.Drawing.Size(100, 20);
            this.maskDomain.TabIndex = 35;
            // 
            // bttnNew
            // 
            this.bttnNew.Location = new System.Drawing.Point(433, 142);
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(75, 23);
            this.bttnNew.TabIndex = 36;
            this.bttnNew.Text = "New domain";
            this.bttnNew.UseVisualStyleBackColor = true;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnOld
            // 
            this.bttnOld.Location = new System.Drawing.Point(514, 142);
            this.bttnOld.Name = "bttnOld";
            this.bttnOld.Size = new System.Drawing.Size(75, 23);
            this.bttnOld.TabIndex = 37;
            this.bttnOld.Text = "Old domain";
            this.bttnOld.UseVisualStyleBackColor = true;
            this.bttnOld.Click += new System.EventHandler(this.bttnOld_Click);
            // 
            // panelChooseRental
            // 
            this.panelChooseRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChooseRental.Controls.Add(this.radBttnHour);
            this.panelChooseRental.Controls.Add(this.radBttnMonth);
            this.panelChooseRental.Controls.Add(this.txtOwner);
            this.panelChooseRental.Controls.Add(this.lblOwner);
            this.panelChooseRental.Controls.Add(this.numMonth);
            this.panelChooseRental.Controls.Add(this.lblMonth);
            this.panelChooseRental.Controls.Add(this.lblChoose);
            this.panelChooseRental.Location = new System.Drawing.Point(30, 225);
            this.panelChooseRental.Name = "panelChooseRental";
            this.panelChooseRental.Size = new System.Drawing.Size(723, 111);
            this.panelChooseRental.TabIndex = 38;
            // 
            // radBttnHour
            // 
            this.radBttnHour.AutoSize = true;
            this.radBttnHour.Location = new System.Drawing.Point(191, 57);
            this.radBttnHour.Name = "radBttnHour";
            this.radBttnHour.Size = new System.Drawing.Size(90, 17);
            this.radBttnHour.TabIndex = 42;
            this.radBttnHour.TabStop = true;
            this.radBttnHour.Text = "Rent per hour";
            this.radBttnHour.UseVisualStyleBackColor = true;
            this.radBttnHour.CheckedChanged += new System.EventHandler(this.radBttnHour_CheckedChanged);
            // 
            // radBttnMonth
            // 
            this.radBttnMonth.AutoSize = true;
            this.radBttnMonth.Location = new System.Drawing.Point(191, 23);
            this.radBttnMonth.Name = "radBttnMonth";
            this.radBttnMonth.Size = new System.Drawing.Size(98, 17);
            this.radBttnMonth.TabIndex = 41;
            this.radBttnMonth.TabStop = true;
            this.radBttnMonth.Text = "Rent per month";
            this.radBttnMonth.UseVisualStyleBackColor = true;
            this.radBttnMonth.CheckedChanged += new System.EventHandler(this.radBttnMonth_CheckedChanged);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(543, 22);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(129, 20);
            this.txtOwner.TabIndex = 38;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(496, 24);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(41, 13);
            this.lblOwner.TabIndex = 37;
            this.lblOwner.Text = "Owner:";
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(446, 22);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(44, 20);
            this.numMonth.TabIndex = 36;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(391, 24);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(45, 13);
            this.lblMonth.TabIndex = 32;
            this.lblMonth.Text = "Months:";
            this.lblMonth.Visible = false;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(50, 46);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(128, 13);
            this.lblChoose.TabIndex = 29;
            this.lblChoose.Text = "Choose the type of rental:";
            // 
            // bttnRenew
            // 
            this.bttnRenew.Location = new System.Drawing.Point(477, 358);
            this.bttnRenew.Name = "bttnRenew";
            this.bttnRenew.Size = new System.Drawing.Size(75, 23);
            this.bttnRenew.TabIndex = 39;
            this.bttnRenew.Text = "Renew rent";
            this.bttnRenew.UseVisualStyleBackColor = true;
            this.bttnRenew.Click += new System.EventHandler(this.BttnRenew_Click);
            // 
            // numRenew
            // 
            this.numRenew.Location = new System.Drawing.Point(558, 360);
            this.numRenew.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numRenew.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRenew.Name = "numRenew";
            this.numRenew.Size = new System.Drawing.Size(44, 20);
            this.numRenew.TabIndex = 40;
            this.numRenew.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDomainComplete
            // 
            this.txtDomainComplete.Location = new System.Drawing.Point(327, 143);
            this.txtDomainComplete.Name = "txtDomainComplete";
            this.txtDomainComplete.ReadOnly = true;
            this.txtDomainComplete.Size = new System.Drawing.Size(100, 20);
            this.txtDomainComplete.TabIndex = 41;
            // 
            // FormAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 395);
            this.ControlBox = false;
            this.Controls.Add(this.txtDomainComplete);
            this.Controls.Add(this.numRenew);
            this.Controls.Add(this.bttnRenew);
            this.Controls.Add(this.panelChooseRental);
            this.Controls.Add(this.bttnOld);
            this.Controls.Add(this.bttnNew);
            this.Controls.Add(this.maskDomain);
            this.Controls.Add(this.bttnEnd);
            this.Controls.Add(this.lblUbication);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblUbicationTitle);
            this.Controls.Add(this.lblNumberTitle);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.cmbTypeOfVehicle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblTYpeOfVehicle);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblTitleForm);
            this.Name = "FormAddVehicle";
            this.Text = "Add a new vehicle";
            this.Load += new System.EventHandler(this.FormAddVehicle_Load);
            this.panelChooseRental.ResumeLayout(false);
            this.panelChooseRental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRenew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTYpeOfVehicle;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbTypeOfVehicle;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label lblNumberTitle;
        private System.Windows.Forms.Label lblUbicationTitle;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblUbication;
        private System.Windows.Forms.Button bttnEnd;
        private System.Windows.Forms.MaskedTextBox maskDomain;
        private System.Windows.Forms.Button bttnNew;
        private System.Windows.Forms.Button bttnOld;
        private System.Windows.Forms.Panel panelChooseRental;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button bttnRenew;
        private System.Windows.Forms.NumericUpDown numRenew;
        private System.Windows.Forms.RadioButton radBttnHour;
        private System.Windows.Forms.RadioButton radBttnMonth;
        private System.Windows.Forms.TextBox txtDomainComplete;
    }
}