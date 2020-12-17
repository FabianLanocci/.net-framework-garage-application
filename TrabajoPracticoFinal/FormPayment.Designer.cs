namespace TrabajoPracticoFinal
{
    partial class FormPayment
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.bttnCancelMakePayment = new System.Windows.Forms.Button();
            this.bttnPay = new System.Windows.Forms.Button();
            this.lblConcept = new System.Windows.Forms.Label();
            this.txtConcept = new System.Windows.Forms.TextBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 114);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(12, 130);
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(120, 20);
            this.numAmount.TabIndex = 1;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bttnCancelMakePayment
            // 
            this.bttnCancelMakePayment.Location = new System.Drawing.Point(12, 180);
            this.bttnCancelMakePayment.Name = "bttnCancelMakePayment";
            this.bttnCancelMakePayment.Size = new System.Drawing.Size(75, 23);
            this.bttnCancelMakePayment.TabIndex = 2;
            this.bttnCancelMakePayment.Text = "Cancel";
            this.bttnCancelMakePayment.UseVisualStyleBackColor = true;
            this.bttnCancelMakePayment.Click += new System.EventHandler(this.bttnCancelMakePayment_Click);
            // 
            // bttnPay
            // 
            this.bttnPay.Location = new System.Drawing.Point(235, 180);
            this.bttnPay.Name = "bttnPay";
            this.bttnPay.Size = new System.Drawing.Size(75, 23);
            this.bttnPay.TabIndex = 3;
            this.bttnPay.Text = "Pay";
            this.bttnPay.UseVisualStyleBackColor = true;
            this.bttnPay.Click += new System.EventHandler(this.bttnPay_Click);
            // 
            // lblConcept
            // 
            this.lblConcept.AutoSize = true;
            this.lblConcept.Location = new System.Drawing.Point(9, 14);
            this.lblConcept.Name = "lblConcept";
            this.lblConcept.Size = new System.Drawing.Size(50, 13);
            this.lblConcept.TabIndex = 4;
            this.lblConcept.Text = "Concept:";
            // 
            // txtConcept
            // 
            this.txtConcept.Location = new System.Drawing.Point(198, 31);
            this.txtConcept.Multiline = true;
            this.txtConcept.Name = "txtConcept";
            this.txtConcept.Size = new System.Drawing.Size(112, 20);
            this.txtConcept.TabIndex = 5;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Services",
            "Cleaning products",
            "Others"});
            this.cmbPayment.Location = new System.Drawing.Point(12, 31);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(121, 21);
            this.cmbPayment.TabIndex = 6;
            this.cmbPayment.SelectedIndexChanged += new System.EventHandler(this.cmbPayment_SelectedIndexChanged);
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "Internet",
            "Sanitary works",
            "Electricity",
            "Gas",
            "TV"});
            this.cmbService.Location = new System.Drawing.Point(12, 59);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(121, 21);
            this.cmbService.TabIndex = 7;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 342);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.txtConcept);
            this.Controls.Add(this.lblConcept);
            this.Controls.Add(this.bttnPay);
            this.Controls.Add(this.bttnCancelMakePayment);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button bttnCancelMakePayment;
        private System.Windows.Forms.Button bttnPay;
        private System.Windows.Forms.Label lblConcept;
        private System.Windows.Forms.TextBox txtConcept;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.ComboBox cmbService;
    }
}