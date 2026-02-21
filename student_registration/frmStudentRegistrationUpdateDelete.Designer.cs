namespace student_registration
{
    partial class frmStudentRegistrationUpdateDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistrationUpdateDelete));
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblPaymentValor = new System.Windows.Forms.Label();
            this.txtPaymentValor = new System.Windows.Forms.TextBox();
            this.lblPaymentDay = new System.Windows.Forms.Label();
            this.txtPaymentDay = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(867, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(869, 48);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(73, 28);
            this.cbStatus.TabIndex = 48;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(314, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 35);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(617, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 35);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtxtZipCode
            // 
            this.mtxtZipCode.Location = new System.Drawing.Point(863, 143);
            this.mtxtZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtZipCode.Mask = "99999-999";
            this.mtxtZipCode.Name = "mtxtZipCode";
            this.mtxtZipCode.Size = new System.Drawing.Size(79, 27);
            this.mtxtZipCode.TabIndex = 73;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(860, 103);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(155, 20);
            this.lblZipCode.TabIndex = 72;
            this.lblZipCode.Text = "Address - ZIP Code";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(712, 103);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(112, 20);
            this.lblNumber.TabIndex = 71;
            this.lblNumber.Text = "Address - No.";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(715, 143);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(78, 27);
            this.txtNumber.TabIndex = 70;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(509, 103);
            this.lblNeighborhood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(172, 20);
            this.lblNeighborhood.TabIndex = 69;
            this.lblNeighborhood.Text = "Address - Neiborhood";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(512, 143);
            this.txtNeighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(133, 27);
            this.txtNeighborhood.TabIndex = 68;
            this.txtNeighborhood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNeighborhood_KeyPress);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(308, 103);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(132, 20);
            this.lblStreet.TabIndex = 67;
            this.lblStreet.Text = "Address - Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(309, 143);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(133, 27);
            this.txtStreet.TabIndex = 66;
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(140, 103);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(116, 20);
            this.lblCity.TabIndex = 65;
            this.lblCity.Text = "Address - City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(143, 143);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(96, 27);
            this.txtCity.TabIndex = 64;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(32, 103);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(107, 20);
            this.lblState.TabIndex = 63;
            this.lblState.Text = "Address - St.";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(35, 143);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(38, 27);
            this.txtState.TabIndex = 62;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtState_KeyPress);
            // 
            // lblPaymentValor
            // 
            this.lblPaymentValor.AutoSize = true;
            this.lblPaymentValor.Location = new System.Drawing.Point(729, 16);
            this.lblPaymentValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentValor.Name = "lblPaymentValor";
            this.lblPaymentValor.Size = new System.Drawing.Size(118, 20);
            this.lblPaymentValor.TabIndex = 61;
            this.lblPaymentValor.Text = "Payment Valor";
            // 
            // txtPaymentValor
            // 
            this.txtPaymentValor.Location = new System.Drawing.Point(732, 48);
            this.txtPaymentValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentValor.Name = "txtPaymentValor";
            this.txtPaymentValor.Size = new System.Drawing.Size(77, 27);
            this.txtPaymentValor.TabIndex = 60;
            this.txtPaymentValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentValor_KeyPress);
            // 
            // lblPaymentDay
            // 
            this.lblPaymentDay.AutoSize = true;
            this.lblPaymentDay.Location = new System.Drawing.Point(614, 16);
            this.lblPaymentDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDay.Name = "lblPaymentDay";
            this.lblPaymentDay.Size = new System.Drawing.Size(109, 20);
            this.lblPaymentDay.TabIndex = 59;
            this.lblPaymentDay.Text = "Payment Day";
            // 
            // txtPaymentDay
            // 
            this.txtPaymentDay.Location = new System.Drawing.Point(617, 48);
            this.txtPaymentDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentDay.Name = "txtPaymentDay";
            this.txtPaymentDay.Size = new System.Drawing.Size(55, 27);
            this.txtPaymentDay.TabIndex = 58;
            this.txtPaymentDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentDay_KeyPress);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(440, 16);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(86, 20);
            this.lblTelephone.TabIndex = 57;
            this.lblTelephone.Text = "Telephone";
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(443, 48);
            this.mtxtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTelephone.Mask = "(99)99999-9999";
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(114, 27);
            this.mtxtTelephone.TabIndex = 56;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(270, 16);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 20);
            this.lblCpf.TabIndex = 55;
            this.lblCpf.Text = "CPF";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(273, 48);
            this.mtxtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCpf.Mask = "999,999,999-99";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(110, 27);
            this.mtxtCpf.TabIndex = 54;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 16);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 27);
            this.txtName.TabIndex = 52;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(33, 187);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 27);
            this.txtId.TabIndex = 74;
            this.txtId.Visible = false;
            // 
            // frmStudentRegistrationUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 273);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.mtxtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNeighborhood);
            this.Controls.Add(this.txtNeighborhood);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblPaymentValor);
            this.Controls.Add(this.txtPaymentValor);
            this.Controls.Add(this.lblPaymentDay);
            this.Controls.Add(this.txtPaymentDay);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.mtxtTelephone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentRegistrationUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s data - Update/delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStudentRegistrationUpdateDelete_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox mtxtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblPaymentValor;
        private System.Windows.Forms.TextBox txtPaymentValor;
        private System.Windows.Forms.Label lblPaymentDay;
        private System.Windows.Forms.TextBox txtPaymentDay;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
    }
}