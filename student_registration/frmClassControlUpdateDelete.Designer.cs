namespace student_registration
{
    partial class frmClassControlUpdateDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassControlUpdateDelete));
            this.lblClassControlDone = new System.Windows.Forms.Label();
            this.lblClassControlPlanned = new System.Windows.Forms.Label();
            this.txtClassControlDone = new System.Windows.Forms.TextBox();
            this.txtClassControlPlanned = new System.Windows.Forms.TextBox();
            this.lblClassControlDate = new System.Windows.Forms.Label();
            this.dtpClassControlDate = new System.Windows.Forms.DateTimePicker();
            this.lblClassControlStudent = new System.Windows.Forms.Label();
            this.cbClassControlStudent = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClassControlDone
            // 
            this.lblClassControlDone.AutoSize = true;
            this.lblClassControlDone.Location = new System.Drawing.Point(601, 116);
            this.lblClassControlDone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassControlDone.Name = "lblClassControlDone";
            this.lblClassControlDone.Size = new System.Drawing.Size(49, 20);
            this.lblClassControlDone.TabIndex = 46;
            this.lblClassControlDone.Text = "Done";
            // 
            // lblClassControlPlanned
            // 
            this.lblClassControlPlanned.AutoSize = true;
            this.lblClassControlPlanned.Location = new System.Drawing.Point(31, 116);
            this.lblClassControlPlanned.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassControlPlanned.Name = "lblClassControlPlanned";
            this.lblClassControlPlanned.Size = new System.Drawing.Size(69, 20);
            this.lblClassControlPlanned.TabIndex = 45;
            this.lblClassControlPlanned.Text = "Planned";
            // 
            // txtClassControlDone
            // 
            this.txtClassControlDone.Location = new System.Drawing.Point(605, 157);
            this.txtClassControlDone.Margin = new System.Windows.Forms.Padding(5);
            this.txtClassControlDone.Name = "txtClassControlDone";
            this.txtClassControlDone.Size = new System.Drawing.Size(465, 26);
            this.txtClassControlDone.TabIndex = 44;
            this.txtClassControlDone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassControlDone_KeyPress);
            // 
            // txtClassControlPlanned
            // 
            this.txtClassControlPlanned.Location = new System.Drawing.Point(34, 157);
            this.txtClassControlPlanned.Margin = new System.Windows.Forms.Padding(5);
            this.txtClassControlPlanned.Name = "txtClassControlPlanned";
            this.txtClassControlPlanned.Size = new System.Drawing.Size(465, 26);
            this.txtClassControlPlanned.TabIndex = 43;
            this.txtClassControlPlanned.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassControlPlanned_KeyPress);
            // 
            // lblClassControlDate
            // 
            this.lblClassControlDate.AutoSize = true;
            this.lblClassControlDate.Location = new System.Drawing.Point(602, 22);
            this.lblClassControlDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassControlDate.Name = "lblClassControlDate";
            this.lblClassControlDate.Size = new System.Drawing.Size(45, 20);
            this.lblClassControlDate.TabIndex = 42;
            this.lblClassControlDate.Text = "Date";
            // 
            // dtpClassControlDate
            // 
            this.dtpClassControlDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClassControlDate.Location = new System.Drawing.Point(606, 62);
            this.dtpClassControlDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpClassControlDate.Name = "dtpClassControlDate";
            this.dtpClassControlDate.Size = new System.Drawing.Size(128, 26);
            this.dtpClassControlDate.TabIndex = 41;
            // 
            // lblClassControlStudent
            // 
            this.lblClassControlStudent.AutoSize = true;
            this.lblClassControlStudent.Location = new System.Drawing.Point(31, 22);
            this.lblClassControlStudent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassControlStudent.Name = "lblClassControlStudent";
            this.lblClassControlStudent.Size = new System.Drawing.Size(66, 20);
            this.lblClassControlStudent.TabIndex = 40;
            this.lblClassControlStudent.Text = "Student";
            // 
            // cbClassControlStudent
            // 
            this.cbClassControlStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassControlStudent.FormattingEnabled = true;
            this.cbClassControlStudent.Location = new System.Drawing.Point(35, 59);
            this.cbClassControlStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cbClassControlStudent.Name = "cbClassControlStudent";
            this.cbClassControlStudent.Size = new System.Drawing.Size(251, 28);
            this.cbClassControlStudent.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 35);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 35);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(35, 188);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 26);
            this.txtId.TabIndex = 76;
            this.txtId.Visible = false;
            // 
            // frmClassControlUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 282);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblClassControlDone);
            this.Controls.Add(this.lblClassControlPlanned);
            this.Controls.Add(this.txtClassControlDone);
            this.Controls.Add(this.txtClassControlPlanned);
            this.Controls.Add(this.lblClassControlDate);
            this.Controls.Add(this.dtpClassControlDate);
            this.Controls.Add(this.lblClassControlStudent);
            this.Controls.Add(this.cbClassControlStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClassControlUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClassControlUpdateDelete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClassControlUpdateDelete_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassControlDone;
        private System.Windows.Forms.Label lblClassControlPlanned;
        private System.Windows.Forms.TextBox txtClassControlDone;
        private System.Windows.Forms.TextBox txtClassControlPlanned;
        private System.Windows.Forms.Label lblClassControlDate;
        private System.Windows.Forms.DateTimePicker dtpClassControlDate;
        private System.Windows.Forms.Label lblClassControlStudent;
        private System.Windows.Forms.ComboBox cbClassControlStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
    }
}