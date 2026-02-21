namespace student_registration
{
    partial class frmClassSchedulesUpdateDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassSchedulesUpdateDelete));
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.lblWeekDayTime = new System.Windows.Forms.Label();
            this.lblWeekDayStudent = new System.Windows.Forms.Label();
            this.mtxtScheludeTime = new System.Windows.Forms.MaskedTextBox();
            this.cbScheludeDay = new System.Windows.Forms.ComboBox();
            this.cbScheludeStudent = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Location = new System.Drawing.Point(376, 20);
            this.lblWeekDay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(129, 20);
            this.lblWeekDay.TabIndex = 38;
            this.lblWeekDay.Text = "Day of the week";
            // 
            // lblWeekDayTime
            // 
            this.lblWeekDayTime.AutoSize = true;
            this.lblWeekDayTime.Location = new System.Drawing.Point(593, 20);
            this.lblWeekDayTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeekDayTime.Name = "lblWeekDayTime";
            this.lblWeekDayTime.Size = new System.Drawing.Size(46, 20);
            this.lblWeekDayTime.TabIndex = 37;
            this.lblWeekDayTime.Text = "Time";
            // 
            // lblWeekDayStudent
            // 
            this.lblWeekDayStudent.AutoSize = true;
            this.lblWeekDayStudent.Location = new System.Drawing.Point(30, 20);
            this.lblWeekDayStudent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeekDayStudent.Name = "lblWeekDayStudent";
            this.lblWeekDayStudent.Size = new System.Drawing.Size(66, 20);
            this.lblWeekDayStudent.TabIndex = 36;
            this.lblWeekDayStudent.Text = "Student";
            // 
            // mtxtScheludeTime
            // 
            this.mtxtScheludeTime.Location = new System.Drawing.Point(596, 57);
            this.mtxtScheludeTime.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtScheludeTime.Mask = "99:99";
            this.mtxtScheludeTime.Name = "mtxtScheludeTime";
            this.mtxtScheludeTime.Size = new System.Drawing.Size(42, 26);
            this.mtxtScheludeTime.TabIndex = 35;
            // 
            // cbScheludeDay
            // 
            this.cbScheludeDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheludeDay.FormattingEnabled = true;
            this.cbScheludeDay.Items.AddRange(new object[] {
            "1. Monday",
            "2. Tuesday",
            "3. Wednesday",
            "4. Thursday",
            "5. Friday"});
            this.cbScheludeDay.Location = new System.Drawing.Point(379, 57);
            this.cbScheludeDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbScheludeDay.Name = "cbScheludeDay";
            this.cbScheludeDay.Size = new System.Drawing.Size(122, 28);
            this.cbScheludeDay.TabIndex = 34;
            // 
            // cbScheludeStudent
            // 
            this.cbScheludeStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheludeStudent.FormattingEnabled = true;
            this.cbScheludeStudent.Location = new System.Drawing.Point(33, 57);
            this.cbScheludeStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cbScheludeStudent.Name = "cbScheludeStudent";
            this.cbScheludeStudent.Size = new System.Drawing.Size(251, 28);
            this.cbScheludeStudent.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 35);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 35);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(33, 89);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 26);
            this.txtId.TabIndex = 75;
            this.txtId.Visible = false;
            // 
            // frmClassSchedulesUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 194);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWeekDay);
            this.Controls.Add(this.lblWeekDayTime);
            this.Controls.Add(this.lblWeekDayStudent);
            this.Controls.Add(this.mtxtScheludeTime);
            this.Controls.Add(this.cbScheludeDay);
            this.Controls.Add(this.cbScheludeStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClassSchedulesUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClassSchedulesUpdateDelete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClassSchedulesUpdateDelete_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.Label lblWeekDayTime;
        private System.Windows.Forms.Label lblWeekDayStudent;
        private System.Windows.Forms.MaskedTextBox mtxtScheludeTime;
        private System.Windows.Forms.ComboBox cbScheludeDay;
        private System.Windows.Forms.ComboBox cbScheludeStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
    }
}