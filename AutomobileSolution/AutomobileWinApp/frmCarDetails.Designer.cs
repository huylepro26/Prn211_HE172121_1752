namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            IbCarID = new Label();
            IbCarName = new Label();
            IbCarManufacturer = new Label();
            IbPrice = new Label();
            IbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            cboManufacturer = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // IbCarID
            // 
            IbCarID.AccessibleName = "";
            IbCarID.AutoSize = true;
            IbCarID.Location = new Point(98, 64);
            IbCarID.Name = "IbCarID";
            IbCarID.Size = new Size(39, 15);
            IbCarID.TabIndex = 0;
            IbCarID.Text = "Car ID";
            // 
            // IbCarName
            // 
            IbCarName.AutoSize = true;
            IbCarName.Location = new Point(98, 113);
            IbCarName.Name = "IbCarName";
            IbCarName.Size = new Size(60, 15);
            IbCarName.TabIndex = 1;
            IbCarName.Text = "Car Name";
            // 
            // IbCarManufacturer
            // 
            IbCarManufacturer.AutoSize = true;
            IbCarManufacturer.Location = new Point(98, 167);
            IbCarManufacturer.Name = "IbCarManufacturer";
            IbCarManufacturer.Size = new Size(79, 15);
            IbCarManufacturer.TabIndex = 2;
            IbCarManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            IbPrice.AutoSize = true;
            IbPrice.Location = new Point(98, 218);
            IbPrice.Name = "IbPrice";
            IbPrice.Size = new Size(33, 15);
            IbPrice.TabIndex = 3;
            IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            IbReleaseYear.AutoSize = true;
            IbReleaseYear.Location = new Point(98, 262);
            IbReleaseYear.Name = "IbReleaseYear";
            IbReleaseYear.Size = new Size(71, 15);
            IbReleaseYear.TabIndex = 4;
            IbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(205, 61);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(156, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(205, 110);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(156, 23);
            txtCarName.TabIndex = 6;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(205, 167);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(156, 23);
            cboManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(205, 215);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(156, 23);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(205, 262);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(156, 23);
            txtReleaseYear.TabIndex = 9;
            txtReleaseYear.Text = "0";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(121, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(307, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(IbReleaseYear);
            Controls.Add(IbPrice);
            Controls.Add(IbCarManufacturer);
            Controls.Add(IbCarName);
            Controls.Add(IbCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbCarID;
        private Label IbCarName;
        private Label IbCarManufacturer;
        private Label IbPrice;
        private Label IbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private ComboBox cboManufacturer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private Button btnSave;
        private Button btnCancel;
    }
}