namespace student_registration
{
    partial class frmStudentRegistration
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistration));
            this.tcStudentRegistration = new System.Windows.Forms.TabControl();
            this.tabStudentsData = new System.Windows.Forms.TabPage();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.btnStudentSave = new System.Windows.Forms.Button();
            this.dgvStudentsData = new System.Windows.Forms.DataGridView();
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
            this.lblSudentsData = new System.Windows.Forms.Label();
            this.tabClassSchedules = new System.Windows.Forms.TabPage();
            this.txtScheduleSearchStudent = new System.Windows.Forms.TextBox();
            this.cbScheduleSearchWeekDay = new System.Windows.Forms.ComboBox();
            this.cbScheduleSearch = new System.Windows.Forms.ComboBox();
            this.lblScheduleSearch = new System.Windows.Forms.Label();
            this.btnScheludeSave = new System.Windows.Forms.Button();
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.lblWeekDayTime = new System.Windows.Forms.Label();
            this.lblWeekDayStudent = new System.Windows.Forms.Label();
            this.mtxtScheludeTime = new System.Windows.Forms.MaskedTextBox();
            this.lblWeekDayRegister = new System.Windows.Forms.Label();
            this.cbScheludeDay = new System.Windows.Forms.ComboBox();
            this.cbScheludeStudent = new System.Windows.Forms.ComboBox();
            this.dgvClassSchedules = new System.Windows.Forms.DataGridView();
            this.tabClassControl = new System.Windows.Forms.TabPage();
            this.txtClassControlSearch = new System.Windows.Forms.TextBox();
            this.lblClassControlSearch = new System.Windows.Forms.Label();
            this.btnClassControlSave = new System.Windows.Forms.Button();
            this.dgvClassControl = new System.Windows.Forms.DataGridView();
            this.lblClassControlDone = new System.Windows.Forms.Label();
            this.lblClassControlPlanned = new System.Windows.Forms.Label();
            this.txtClassControlDone = new System.Windows.Forms.TextBox();
            this.txtClassControlPlanned = new System.Windows.Forms.TextBox();
            this.lblClassControlDate = new System.Windows.Forms.Label();
            this.dtpClassControlDate = new System.Windows.Forms.DateTimePicker();
            this.lblClassControlStudent = new System.Windows.Forms.Label();
            this.cbClassControlStudent = new System.Windows.Forms.ComboBox();
            this.lblClassControl = new System.Windows.Forms.Label();
            this.tabPaymentControl = new System.Windows.Forms.TabPage();
            this.btnPaymentControlSearch = new System.Windows.Forms.Button();
            this.btnPaymentControlDelete = new System.Windows.Forms.Button();
            this.btnPaymentControlSave = new System.Windows.Forms.Button();
            this.txtPaymentControlSearchStudent = new System.Windows.Forms.TextBox();
            this.txtPaymentControlSearchYear = new System.Windows.Forms.TextBox();
            this.cbPaymentControlSearchMonth = new System.Windows.Forms.ComboBox();
            this.cbPaymentControlSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPaymentControl = new System.Windows.Forms.DataGridView();
            this.lblClassControlYear = new System.Windows.Forms.Label();
            this.txtPaymentControlYear = new System.Windows.Forms.TextBox();
            this.lblClassControlMonth = new System.Windows.Forms.Label();
            this.cbPaymentControlMonth = new System.Windows.Forms.ComboBox();
            this.lblPaymentControl = new System.Windows.Forms.Label();
            this.tcStudentRegistration.SuspendLayout();
            this.tabStudentsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsData)).BeginInit();
            this.tabClassSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassSchedules)).BeginInit();
            this.tabClassControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassControl)).BeginInit();
            this.tabPaymentControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStudentRegistration
            // 
            this.tcStudentRegistration.Controls.Add(this.tabStudentsData);
            this.tcStudentRegistration.Controls.Add(this.tabClassSchedules);
            this.tcStudentRegistration.Controls.Add(this.tabClassControl);
            this.tcStudentRegistration.Controls.Add(this.tabPaymentControl);
            this.tcStudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStudentRegistration.Location = new System.Drawing.Point(-2, 1);
            this.tcStudentRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.tcStudentRegistration.Name = "tcStudentRegistration";
            this.tcStudentRegistration.SelectedIndex = 0;
            this.tcStudentRegistration.Size = new System.Drawing.Size(962, 721);
            this.tcStudentRegistration.TabIndex = 0;
            // 
            // tabStudentsData
            // 
            this.tabStudentsData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStudentsData.Controls.Add(this.txtSearchStudent);
            this.tabStudentsData.Controls.Add(this.lblSearchStudent);
            this.tabStudentsData.Controls.Add(this.btnStudentSave);
            this.tabStudentsData.Controls.Add(this.dgvStudentsData);
            this.tabStudentsData.Controls.Add(this.mtxtZipCode);
            this.tabStudentsData.Controls.Add(this.lblZipCode);
            this.tabStudentsData.Controls.Add(this.lblNumber);
            this.tabStudentsData.Controls.Add(this.txtNumber);
            this.tabStudentsData.Controls.Add(this.lblNeighborhood);
            this.tabStudentsData.Controls.Add(this.txtNeighborhood);
            this.tabStudentsData.Controls.Add(this.lblStreet);
            this.tabStudentsData.Controls.Add(this.txtStreet);
            this.tabStudentsData.Controls.Add(this.lblCity);
            this.tabStudentsData.Controls.Add(this.txtCity);
            this.tabStudentsData.Controls.Add(this.lblState);
            this.tabStudentsData.Controls.Add(this.txtState);
            this.tabStudentsData.Controls.Add(this.lblPaymentValor);
            this.tabStudentsData.Controls.Add(this.txtPaymentValor);
            this.tabStudentsData.Controls.Add(this.lblPaymentDay);
            this.tabStudentsData.Controls.Add(this.txtPaymentDay);
            this.tabStudentsData.Controls.Add(this.lblTelephone);
            this.tabStudentsData.Controls.Add(this.mtxtTelephone);
            this.tabStudentsData.Controls.Add(this.lblCpf);
            this.tabStudentsData.Controls.Add(this.mtxtCpf);
            this.tabStudentsData.Controls.Add(this.lblName);
            this.tabStudentsData.Controls.Add(this.txtName);
            this.tabStudentsData.Controls.Add(this.lblSudentsData);
            this.tabStudentsData.Location = new System.Drawing.Point(4, 29);
            this.tabStudentsData.Margin = new System.Windows.Forms.Padding(4);
            this.tabStudentsData.Name = "tabStudentsData";
            this.tabStudentsData.Padding = new System.Windows.Forms.Padding(4);
            this.tabStudentsData.Size = new System.Drawing.Size(954, 688);
            this.tabStudentsData.TabIndex = 0;
            this.tabStudentsData.Text = "Students\' Data";
            this.tabStudentsData.Enter += new System.EventHandler(this.tabStudentsData_Enter);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(257, 641);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(178, 27);
            this.txtSearchStudent.TabIndex = 27;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            this.txtSearchStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchStudent_KeyPress);
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(27, 641);
            this.lblSearchStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(273, 25);
            this.lblSearchStudent.TabIndex = 26;
            this.lblSearchStudent.Text = "Search for a student by name:";
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.Location = new System.Drawing.Point(375, 553);
            this.btnStudentSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(105, 35);
            this.btnStudentSave.TabIndex = 25;
            this.btnStudentSave.Text = "Save";
            this.btnStudentSave.UseVisualStyleBackColor = true;
            this.btnStudentSave.Click += new System.EventHandler(this.btnStudentSave_Click);
            // 
            // dgvStudentsData
            // 
            this.dgvStudentsData.AllowUserToAddRows = false;
            this.dgvStudentsData.AllowUserToDeleteRows = false;
            this.dgvStudentsData.AllowUserToResizeColumns = false;
            this.dgvStudentsData.AllowUserToResizeRows = false;
            this.dgvStudentsData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsData.Location = new System.Drawing.Point(29, 259);
            this.dgvStudentsData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudentsData.MultiSelect = false;
            this.dgvStudentsData.Name = "dgvStudentsData";
            this.dgvStudentsData.ReadOnly = true;
            this.dgvStudentsData.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentsData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentsData.RowTemplate.Height = 24;
            this.dgvStudentsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsData.Size = new System.Drawing.Size(882, 277);
            this.dgvStudentsData.TabIndex = 24;
            this.dgvStudentsData.DoubleClick += new System.EventHandler(this.dgvStudentsData_DoubleClick);
            // 
            // mtxtZipCode
            // 
            this.mtxtZipCode.Location = new System.Drawing.Point(814, 211);
            this.mtxtZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtZipCode.Mask = "99999-999";
            this.mtxtZipCode.Name = "mtxtZipCode";
            this.mtxtZipCode.ShortcutsEnabled = false;
            this.mtxtZipCode.Size = new System.Drawing.Size(79, 27);
            this.mtxtZipCode.TabIndex = 23;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(811, 171);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(155, 20);
            this.lblZipCode.TabIndex = 22;
            this.lblZipCode.Text = "Address - ZIP Code";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(672, 171);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(112, 20);
            this.lblNumber.TabIndex = 20;
            this.lblNumber.Text = "Address - No.";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(675, 211);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ShortcutsEnabled = false;
            this.txtNumber.Size = new System.Drawing.Size(78, 27);
            this.txtNumber.TabIndex = 19;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Location = new System.Drawing.Point(478, 171);
            this.lblNeighborhood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(190, 20);
            this.lblNeighborhood.TabIndex = 18;
            this.lblNeighborhood.Text = "Address - Neighborhood";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(481, 211);
            this.txtNeighborhood.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.ShortcutsEnabled = false;
            this.txtNeighborhood.Size = new System.Drawing.Size(133, 27);
            this.txtNeighborhood.TabIndex = 17;
            this.txtNeighborhood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNeighborhood_KeyPress);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(284, 171);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(132, 20);
            this.lblStreet.TabIndex = 16;
            this.lblStreet.Text = "Address - Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(287, 211);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ShortcutsEnabled = false;
            this.txtStreet.Size = new System.Drawing.Size(133, 27);
            this.txtStreet.TabIndex = 15;
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(127, 171);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(116, 20);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "Address - City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(130, 211);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.ShortcutsEnabled = false;
            this.txtCity.Size = new System.Drawing.Size(96, 27);
            this.txtCity.TabIndex = 13;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(26, 171);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(107, 20);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "Address - St.";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(29, 211);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.ShortcutsEnabled = false;
            this.txtState.Size = new System.Drawing.Size(40, 27);
            this.txtState.TabIndex = 11;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtState_KeyPress);
            // 
            // lblPaymentValor
            // 
            this.lblPaymentValor.AutoSize = true;
            this.lblPaymentValor.Location = new System.Drawing.Point(811, 84);
            this.lblPaymentValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentValor.Name = "lblPaymentValor";
            this.lblPaymentValor.Size = new System.Drawing.Size(118, 20);
            this.lblPaymentValor.TabIndex = 10;
            this.lblPaymentValor.Text = "Payment Valor";
            // 
            // txtPaymentValor
            // 
            this.txtPaymentValor.Location = new System.Drawing.Point(812, 116);
            this.txtPaymentValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentValor.Name = "txtPaymentValor";
            this.txtPaymentValor.ShortcutsEnabled = false;
            this.txtPaymentValor.Size = new System.Drawing.Size(77, 27);
            this.txtPaymentValor.TabIndex = 9;
            this.txtPaymentValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentValor_KeyPress);
            // 
            // lblPaymentDay
            // 
            this.lblPaymentDay.AutoSize = true;
            this.lblPaymentDay.Location = new System.Drawing.Point(674, 84);
            this.lblPaymentDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDay.Name = "lblPaymentDay";
            this.lblPaymentDay.Size = new System.Drawing.Size(109, 20);
            this.lblPaymentDay.TabIndex = 8;
            this.lblPaymentDay.Text = "Payment Day";
            // 
            // txtPaymentDay
            // 
            this.txtPaymentDay.Location = new System.Drawing.Point(678, 116);
            this.txtPaymentDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentDay.Name = "txtPaymentDay";
            this.txtPaymentDay.ShortcutsEnabled = false;
            this.txtPaymentDay.Size = new System.Drawing.Size(55, 27);
            this.txtPaymentDay.TabIndex = 7;
            this.txtPaymentDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentDay_KeyPress);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(482, 84);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(86, 20);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Telephone";
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(485, 116);
            this.mtxtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTelephone.Mask = "(99)99999-9999";
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.ShortcutsEnabled = false;
            this.mtxtTelephone.Size = new System.Drawing.Size(114, 27);
            this.mtxtTelephone.TabIndex = 5;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(293, 84);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 20);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(296, 116);
            this.mtxtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCpf.Mask = "999,999,999-99";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.ShortcutsEnabled = false;
            this.mtxtCpf.Size = new System.Drawing.Size(110, 27);
            this.mtxtCpf.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 84);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ShortcutsEnabled = false;
            this.txtName.Size = new System.Drawing.Size(178, 27);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblSudentsData
            // 
            this.lblSudentsData.AutoSize = true;
            this.lblSudentsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSudentsData.Location = new System.Drawing.Point(35, 30);
            this.lblSudentsData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSudentsData.Name = "lblSudentsData";
            this.lblSudentsData.Size = new System.Drawing.Size(296, 25);
            this.lblSudentsData.TabIndex = 0;
            this.lblSudentsData.Text = "Register the data of each student";
            // 
            // tabClassSchedules
            // 
            this.tabClassSchedules.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabClassSchedules.Controls.Add(this.txtScheduleSearchStudent);
            this.tabClassSchedules.Controls.Add(this.cbScheduleSearchWeekDay);
            this.tabClassSchedules.Controls.Add(this.cbScheduleSearch);
            this.tabClassSchedules.Controls.Add(this.lblScheduleSearch);
            this.tabClassSchedules.Controls.Add(this.btnScheludeSave);
            this.tabClassSchedules.Controls.Add(this.lblWeekDay);
            this.tabClassSchedules.Controls.Add(this.lblWeekDayTime);
            this.tabClassSchedules.Controls.Add(this.lblWeekDayStudent);
            this.tabClassSchedules.Controls.Add(this.mtxtScheludeTime);
            this.tabClassSchedules.Controls.Add(this.lblWeekDayRegister);
            this.tabClassSchedules.Controls.Add(this.cbScheludeDay);
            this.tabClassSchedules.Controls.Add(this.cbScheludeStudent);
            this.tabClassSchedules.Controls.Add(this.dgvClassSchedules);
            this.tabClassSchedules.Location = new System.Drawing.Point(4, 29);
            this.tabClassSchedules.Margin = new System.Windows.Forms.Padding(4);
            this.tabClassSchedules.Name = "tabClassSchedules";
            this.tabClassSchedules.Padding = new System.Windows.Forms.Padding(4);
            this.tabClassSchedules.Size = new System.Drawing.Size(954, 688);
            this.tabClassSchedules.TabIndex = 1;
            this.tabClassSchedules.Text = "Class schedules";
            this.tabClassSchedules.Enter += new System.EventHandler(this.tabDaysOfTheWeek_Enter);
            // 
            // txtScheduleSearchStudent
            // 
            this.txtScheduleSearchStudent.Location = new System.Drawing.Point(133, 638);
            this.txtScheduleSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtScheduleSearchStudent.Name = "txtScheduleSearchStudent";
            this.txtScheduleSearchStudent.Size = new System.Drawing.Size(178, 27);
            this.txtScheduleSearchStudent.TabIndex = 37;
            this.txtScheduleSearchStudent.Visible = false;
            this.txtScheduleSearchStudent.TextChanged += new System.EventHandler(this.txtScheduleSearchStudent_TextChanged);
            this.txtScheduleSearchStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScheduleSearchStudent_KeyPress);
            // 
            // cbScheduleSearchWeekDay
            // 
            this.cbScheduleSearchWeekDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheduleSearchWeekDay.FormattingEnabled = true;
            this.cbScheduleSearchWeekDay.Items.AddRange(new object[] {
            "1. Monday",
            "2. Tuesday",
            "3. Wednesday",
            "4. Thursday",
            "5. Friday"});
            this.cbScheduleSearchWeekDay.Location = new System.Drawing.Point(133, 638);
            this.cbScheduleSearchWeekDay.Name = "cbScheduleSearchWeekDay";
            this.cbScheduleSearchWeekDay.Size = new System.Drawing.Size(130, 28);
            this.cbScheduleSearchWeekDay.TabIndex = 36;
            this.cbScheduleSearchWeekDay.Visible = false;
            this.cbScheduleSearchWeekDay.SelectedIndexChanged += new System.EventHandler(this.cbScheduleSearchWeekDay_SelectedIndexChanged);
            // 
            // cbScheduleSearch
            // 
            this.cbScheduleSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheduleSearch.FormattingEnabled = true;
            this.cbScheduleSearch.Items.AddRange(new object[] {
            "Student",
            "Classes in a week day"});
            this.cbScheduleSearch.Location = new System.Drawing.Point(133, 590);
            this.cbScheduleSearch.Name = "cbScheduleSearch";
            this.cbScheduleSearch.Size = new System.Drawing.Size(166, 28);
            this.cbScheduleSearch.TabIndex = 35;
            this.cbScheduleSearch.SelectedIndexChanged += new System.EventHandler(this.cbScheduleSearch_SelectedIndexChanged);
            // 
            // lblScheduleSearch
            // 
            this.lblScheduleSearch.AutoSize = true;
            this.lblScheduleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleSearch.Location = new System.Drawing.Point(34, 589);
            this.lblScheduleSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduleSearch.Name = "lblScheduleSearch";
            this.lblScheduleSearch.Size = new System.Drawing.Size(81, 25);
            this.lblScheduleSearch.TabIndex = 34;
            this.lblScheduleSearch.Text = "Search:";
            // 
            // btnScheludeSave
            // 
            this.btnScheludeSave.Location = new System.Drawing.Point(414, 527);
            this.btnScheludeSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheludeSave.Name = "btnScheludeSave";
            this.btnScheludeSave.Size = new System.Drawing.Size(105, 35);
            this.btnScheludeSave.TabIndex = 33;
            this.btnScheludeSave.Text = "Save";
            this.btnScheludeSave.UseVisualStyleBackColor = true;
            this.btnScheludeSave.Click += new System.EventHandler(this.btnScheludeSave_Click);
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Location = new System.Drawing.Point(431, 96);
            this.lblWeekDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(129, 20);
            this.lblWeekDay.TabIndex = 32;
            this.lblWeekDay.Text = "Day of the week";
            // 
            // lblWeekDayTime
            // 
            this.lblWeekDayTime.AutoSize = true;
            this.lblWeekDayTime.Location = new System.Drawing.Point(829, 96);
            this.lblWeekDayTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekDayTime.Name = "lblWeekDayTime";
            this.lblWeekDayTime.Size = new System.Drawing.Size(46, 20);
            this.lblWeekDayTime.TabIndex = 31;
            this.lblWeekDayTime.Text = "Time";
            // 
            // lblWeekDayStudent
            // 
            this.lblWeekDayStudent.AutoSize = true;
            this.lblWeekDayStudent.Location = new System.Drawing.Point(33, 96);
            this.lblWeekDayStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekDayStudent.Name = "lblWeekDayStudent";
            this.lblWeekDayStudent.Size = new System.Drawing.Size(66, 20);
            this.lblWeekDayStudent.TabIndex = 30;
            this.lblWeekDayStudent.Text = "Student";
            // 
            // mtxtScheludeTime
            // 
            this.mtxtScheludeTime.Location = new System.Drawing.Point(832, 127);
            this.mtxtScheludeTime.Mask = "99:99";
            this.mtxtScheludeTime.Name = "mtxtScheludeTime";
            this.mtxtScheludeTime.Size = new System.Drawing.Size(44, 27);
            this.mtxtScheludeTime.TabIndex = 29;
            // 
            // lblWeekDayRegister
            // 
            this.lblWeekDayRegister.AutoSize = true;
            this.lblWeekDayRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekDayRegister.Location = new System.Drawing.Point(32, 31);
            this.lblWeekDayRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekDayRegister.Name = "lblWeekDayRegister";
            this.lblWeekDayRegister.Size = new System.Drawing.Size(563, 25);
            this.lblWeekDayRegister.TabIndex = 28;
            this.lblWeekDayRegister.Text = "Register the day(s) of the week that each student will have class";
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
            this.cbScheludeDay.Location = new System.Drawing.Point(434, 126);
            this.cbScheludeDay.Name = "cbScheludeDay";
            this.cbScheludeDay.Size = new System.Drawing.Size(122, 28);
            this.cbScheludeDay.TabIndex = 27;
            // 
            // cbScheludeStudent
            // 
            this.cbScheludeStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheludeStudent.FormattingEnabled = true;
            this.cbScheludeStudent.Location = new System.Drawing.Point(36, 126);
            this.cbScheludeStudent.Name = "cbScheludeStudent";
            this.cbScheludeStudent.Size = new System.Drawing.Size(189, 28);
            this.cbScheludeStudent.TabIndex = 26;
            this.cbScheludeStudent.DropDown += new System.EventHandler(this.cbWeekDayStudent_DropDown);
            // 
            // dgvClassSchedules
            // 
            this.dgvClassSchedules.AllowUserToAddRows = false;
            this.dgvClassSchedules.AllowUserToDeleteRows = false;
            this.dgvClassSchedules.AllowUserToResizeColumns = false;
            this.dgvClassSchedules.AllowUserToResizeRows = false;
            this.dgvClassSchedules.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClassSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassSchedules.Location = new System.Drawing.Point(273, 207);
            this.dgvClassSchedules.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClassSchedules.MultiSelect = false;
            this.dgvClassSchedules.Name = "dgvClassSchedules";
            this.dgvClassSchedules.ReadOnly = true;
            this.dgvClassSchedules.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClassSchedules.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassSchedules.RowTemplate.Height = 24;
            this.dgvClassSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassSchedules.Size = new System.Drawing.Size(418, 292);
            this.dgvClassSchedules.TabIndex = 25;
            this.dgvClassSchedules.DoubleClick += new System.EventHandler(this.dgvClassSchedules_DoubleClick);
            // 
            // tabClassControl
            // 
            this.tabClassControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabClassControl.Controls.Add(this.txtClassControlSearch);
            this.tabClassControl.Controls.Add(this.lblClassControlSearch);
            this.tabClassControl.Controls.Add(this.btnClassControlSave);
            this.tabClassControl.Controls.Add(this.dgvClassControl);
            this.tabClassControl.Controls.Add(this.lblClassControlDone);
            this.tabClassControl.Controls.Add(this.lblClassControlPlanned);
            this.tabClassControl.Controls.Add(this.txtClassControlDone);
            this.tabClassControl.Controls.Add(this.txtClassControlPlanned);
            this.tabClassControl.Controls.Add(this.lblClassControlDate);
            this.tabClassControl.Controls.Add(this.dtpClassControlDate);
            this.tabClassControl.Controls.Add(this.lblClassControlStudent);
            this.tabClassControl.Controls.Add(this.cbClassControlStudent);
            this.tabClassControl.Controls.Add(this.lblClassControl);
            this.tabClassControl.Location = new System.Drawing.Point(4, 29);
            this.tabClassControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabClassControl.Name = "tabClassControl";
            this.tabClassControl.Size = new System.Drawing.Size(954, 688);
            this.tabClassControl.TabIndex = 2;
            this.tabClassControl.Text = "Class control";
            this.tabClassControl.Enter += new System.EventHandler(this.tabClassControl_Enter);
            // 
            // txtClassControlSearch
            // 
            this.txtClassControlSearch.Location = new System.Drawing.Point(386, 637);
            this.txtClassControlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassControlSearch.Name = "txtClassControlSearch";
            this.txtClassControlSearch.Size = new System.Drawing.Size(178, 27);
            this.txtClassControlSearch.TabIndex = 42;
            this.txtClassControlSearch.TextChanged += new System.EventHandler(this.txtClassControlSearch_TextChanged);
            this.txtClassControlSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassControlSearch_KeyPress);
            // 
            // lblClassControlSearch
            // 
            this.lblClassControlSearch.AutoSize = true;
            this.lblClassControlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassControlSearch.Location = new System.Drawing.Point(20, 637);
            this.lblClassControlSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassControlSearch.Name = "lblClassControlSearch";
            this.lblClassControlSearch.Size = new System.Drawing.Size(439, 25);
            this.lblClassControlSearch.TabIndex = 41;
            this.lblClassControlSearch.Text = "Search for a class information by a student name:";
            // 
            // btnClassControlSave
            // 
            this.btnClassControlSave.Location = new System.Drawing.Point(395, 558);
            this.btnClassControlSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnClassControlSave.Name = "btnClassControlSave";
            this.btnClassControlSave.Size = new System.Drawing.Size(105, 35);
            this.btnClassControlSave.TabIndex = 40;
            this.btnClassControlSave.Text = "Save";
            this.btnClassControlSave.UseVisualStyleBackColor = true;
            this.btnClassControlSave.Click += new System.EventHandler(this.btnClassControlSave_Click);
            // 
            // dgvClassControl
            // 
            this.dgvClassControl.AllowUserToAddRows = false;
            this.dgvClassControl.AllowUserToDeleteRows = false;
            this.dgvClassControl.AllowUserToResizeColumns = false;
            this.dgvClassControl.AllowUserToResizeRows = false;
            this.dgvClassControl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClassControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassControl.Location = new System.Drawing.Point(32, 262);
            this.dgvClassControl.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClassControl.MultiSelect = false;
            this.dgvClassControl.Name = "dgvClassControl";
            this.dgvClassControl.ReadOnly = true;
            this.dgvClassControl.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClassControl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClassControl.RowTemplate.Height = 24;
            this.dgvClassControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassControl.Size = new System.Drawing.Size(866, 277);
            this.dgvClassControl.TabIndex = 39;
            this.dgvClassControl.DoubleClick += new System.EventHandler(this.dgvClassControl_DoubleClick);
            // 
            // lblClassControlDone
            // 
            this.lblClassControlDone.AutoSize = true;
            this.lblClassControlDone.Location = new System.Drawing.Point(545, 171);
            this.lblClassControlDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassControlDone.Name = "lblClassControlDone";
            this.lblClassControlDone.Size = new System.Drawing.Size(49, 20);
            this.lblClassControlDone.TabIndex = 38;
            this.lblClassControlDone.Text = "Done";
            // 
            // lblClassControlPlanned
            // 
            this.lblClassControlPlanned.AutoSize = true;
            this.lblClassControlPlanned.Location = new System.Drawing.Point(29, 171);
            this.lblClassControlPlanned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassControlPlanned.Name = "lblClassControlPlanned";
            this.lblClassControlPlanned.Size = new System.Drawing.Size(69, 20);
            this.lblClassControlPlanned.TabIndex = 37;
            this.lblClassControlPlanned.Text = "Planned";
            // 
            // txtClassControlDone
            // 
            this.txtClassControlDone.Location = new System.Drawing.Point(548, 204);
            this.txtClassControlDone.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassControlDone.Name = "txtClassControlDone";
            this.txtClassControlDone.ShortcutsEnabled = false;
            this.txtClassControlDone.Size = new System.Drawing.Size(350, 27);
            this.txtClassControlDone.TabIndex = 36;
            this.txtClassControlDone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassControlDone_KeyPress);
            // 
            // txtClassControlPlanned
            // 
            this.txtClassControlPlanned.Location = new System.Drawing.Point(32, 204);
            this.txtClassControlPlanned.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassControlPlanned.Name = "txtClassControlPlanned";
            this.txtClassControlPlanned.ShortcutsEnabled = false;
            this.txtClassControlPlanned.Size = new System.Drawing.Size(350, 27);
            this.txtClassControlPlanned.TabIndex = 35;
            this.txtClassControlPlanned.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassControlPlanned_KeyPress);
            // 
            // lblClassControlDate
            // 
            this.lblClassControlDate.AutoSize = true;
            this.lblClassControlDate.Location = new System.Drawing.Point(545, 85);
            this.lblClassControlDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassControlDate.Name = "lblClassControlDate";
            this.lblClassControlDate.Size = new System.Drawing.Size(45, 20);
            this.lblClassControlDate.TabIndex = 34;
            this.lblClassControlDate.Text = "Date";
            // 
            // dtpClassControlDate
            // 
            this.dtpClassControlDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClassControlDate.Location = new System.Drawing.Point(548, 117);
            this.dtpClassControlDate.Name = "dtpClassControlDate";
            this.dtpClassControlDate.Size = new System.Drawing.Size(97, 27);
            this.dtpClassControlDate.TabIndex = 33;
            // 
            // lblClassControlStudent
            // 
            this.lblClassControlStudent.AutoSize = true;
            this.lblClassControlStudent.Location = new System.Drawing.Point(29, 85);
            this.lblClassControlStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassControlStudent.Name = "lblClassControlStudent";
            this.lblClassControlStudent.Size = new System.Drawing.Size(66, 20);
            this.lblClassControlStudent.TabIndex = 32;
            this.lblClassControlStudent.Text = "Student";
            // 
            // cbClassControlStudent
            // 
            this.cbClassControlStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassControlStudent.FormattingEnabled = true;
            this.cbClassControlStudent.Location = new System.Drawing.Point(32, 115);
            this.cbClassControlStudent.Name = "cbClassControlStudent";
            this.cbClassControlStudent.Size = new System.Drawing.Size(189, 28);
            this.cbClassControlStudent.TabIndex = 31;
            this.cbClassControlStudent.DropDown += new System.EventHandler(this.cbClassControlStudent_DropDown);
            // 
            // lblClassControl
            // 
            this.lblClassControl.AutoSize = true;
            this.lblClassControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassControl.Location = new System.Drawing.Point(28, 24);
            this.lblClassControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassControl.Name = "lblClassControl";
            this.lblClassControl.Size = new System.Drawing.Size(334, 25);
            this.lblClassControl.TabIndex = 29;
            this.lblClassControl.Text = "Register the information of each class";
            // 
            // tabPaymentControl
            // 
            this.tabPaymentControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPaymentControl.Controls.Add(this.btnPaymentControlSearch);
            this.tabPaymentControl.Controls.Add(this.btnPaymentControlDelete);
            this.tabPaymentControl.Controls.Add(this.btnPaymentControlSave);
            this.tabPaymentControl.Controls.Add(this.txtPaymentControlSearchStudent);
            this.tabPaymentControl.Controls.Add(this.txtPaymentControlSearchYear);
            this.tabPaymentControl.Controls.Add(this.cbPaymentControlSearchMonth);
            this.tabPaymentControl.Controls.Add(this.cbPaymentControlSearch);
            this.tabPaymentControl.Controls.Add(this.label1);
            this.tabPaymentControl.Controls.Add(this.dgvPaymentControl);
            this.tabPaymentControl.Controls.Add(this.lblClassControlYear);
            this.tabPaymentControl.Controls.Add(this.txtPaymentControlYear);
            this.tabPaymentControl.Controls.Add(this.lblClassControlMonth);
            this.tabPaymentControl.Controls.Add(this.cbPaymentControlMonth);
            this.tabPaymentControl.Controls.Add(this.lblPaymentControl);
            this.tabPaymentControl.Location = new System.Drawing.Point(4, 29);
            this.tabPaymentControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabPaymentControl.Name = "tabPaymentControl";
            this.tabPaymentControl.Size = new System.Drawing.Size(954, 688);
            this.tabPaymentControl.TabIndex = 3;
            this.tabPaymentControl.Text = "Payment control";
            this.tabPaymentControl.Enter += new System.EventHandler(this.tabPaymentControl_Enter);
            // 
            // btnPaymentControlSearch
            // 
            this.btnPaymentControlSearch.Location = new System.Drawing.Point(304, 645);
            this.btnPaymentControlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentControlSearch.Name = "btnPaymentControlSearch";
            this.btnPaymentControlSearch.Size = new System.Drawing.Size(90, 26);
            this.btnPaymentControlSearch.TabIndex = 48;
            this.btnPaymentControlSearch.Text = "Search";
            this.btnPaymentControlSearch.UseVisualStyleBackColor = true;
            this.btnPaymentControlSearch.Visible = false;
            this.btnPaymentControlSearch.Click += new System.EventHandler(this.btnPaymentControlSearch_Click);
            // 
            // btnPaymentControlDelete
            // 
            this.btnPaymentControlDelete.Location = new System.Drawing.Point(608, 515);
            this.btnPaymentControlDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentControlDelete.Name = "btnPaymentControlDelete";
            this.btnPaymentControlDelete.Size = new System.Drawing.Size(105, 35);
            this.btnPaymentControlDelete.TabIndex = 47;
            this.btnPaymentControlDelete.Text = "Delete";
            this.btnPaymentControlDelete.UseVisualStyleBackColor = true;
            this.btnPaymentControlDelete.Click += new System.EventHandler(this.btnPaymentControlDelete_Click);
            // 
            // btnPaymentControlSave
            // 
            this.btnPaymentControlSave.Location = new System.Drawing.Point(208, 515);
            this.btnPaymentControlSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentControlSave.Name = "btnPaymentControlSave";
            this.btnPaymentControlSave.Size = new System.Drawing.Size(105, 35);
            this.btnPaymentControlSave.TabIndex = 46;
            this.btnPaymentControlSave.Text = "Save";
            this.btnPaymentControlSave.UseVisualStyleBackColor = true;
            this.btnPaymentControlSave.Click += new System.EventHandler(this.btnPaymentControlSave_Click);
            // 
            // txtPaymentControlSearchStudent
            // 
            this.txtPaymentControlSearchStudent.Location = new System.Drawing.Point(135, 645);
            this.txtPaymentControlSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentControlSearchStudent.Name = "txtPaymentControlSearchStudent";
            this.txtPaymentControlSearchStudent.Size = new System.Drawing.Size(178, 27);
            this.txtPaymentControlSearchStudent.TabIndex = 45;
            this.txtPaymentControlSearchStudent.Visible = false;
            this.txtPaymentControlSearchStudent.TextChanged += new System.EventHandler(this.txtPaymentControlSearchStudent_TextChanged);
            this.txtPaymentControlSearchStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentControlSearchStudent_KeyPress);
            // 
            // txtPaymentControlSearchYear
            // 
            this.txtPaymentControlSearchYear.Location = new System.Drawing.Point(208, 645);
            this.txtPaymentControlSearchYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentControlSearchYear.Name = "txtPaymentControlSearchYear";
            this.txtPaymentControlSearchYear.Size = new System.Drawing.Size(45, 27);
            this.txtPaymentControlSearchYear.TabIndex = 44;
            this.txtPaymentControlSearchYear.Visible = false;
            this.txtPaymentControlSearchYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentControlSearchYear_KeyPress);
            // 
            // cbPaymentControlSearchMonth
            // 
            this.cbPaymentControlSearchMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentControlSearchMonth.FormattingEnabled = true;
            this.cbPaymentControlSearchMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbPaymentControlSearchMonth.Location = new System.Drawing.Point(135, 643);
            this.cbPaymentControlSearchMonth.Name = "cbPaymentControlSearchMonth";
            this.cbPaymentControlSearchMonth.Size = new System.Drawing.Size(40, 28);
            this.cbPaymentControlSearchMonth.TabIndex = 43;
            this.cbPaymentControlSearchMonth.Visible = false;
            // 
            // cbPaymentControlSearch
            // 
            this.cbPaymentControlSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentControlSearch.FormattingEnabled = true;
            this.cbPaymentControlSearch.Items.AddRange(new object[] {
            "Student",
            "Date"});
            this.cbPaymentControlSearch.Location = new System.Drawing.Point(135, 603);
            this.cbPaymentControlSearch.Name = "cbPaymentControlSearch";
            this.cbPaymentControlSearch.Size = new System.Drawing.Size(78, 28);
            this.cbPaymentControlSearch.TabIndex = 42;
            this.cbPaymentControlSearch.SelectedIndexChanged += new System.EventHandler(this.cbPaymentControlSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 602);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search:";
            // 
            // dgvPaymentControl
            // 
            this.dgvPaymentControl.AllowUserToAddRows = false;
            this.dgvPaymentControl.AllowUserToDeleteRows = false;
            this.dgvPaymentControl.AllowUserToResizeColumns = false;
            this.dgvPaymentControl.AllowUserToResizeRows = false;
            this.dgvPaymentControl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaymentControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentControl.Location = new System.Drawing.Point(208, 215);
            this.dgvPaymentControl.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaymentControl.MultiSelect = false;
            this.dgvPaymentControl.Name = "dgvPaymentControl";
            this.dgvPaymentControl.ReadOnly = true;
            this.dgvPaymentControl.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPaymentControl.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentControl.RowTemplate.Height = 24;
            this.dgvPaymentControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentControl.Size = new System.Drawing.Size(505, 283);
            this.dgvPaymentControl.TabIndex = 40;
            this.dgvPaymentControl.DoubleClick += new System.EventHandler(this.dgvPaymentControl_DoubleClick);
            // 
            // lblClassControlYear
            // 
            this.lblClassControlYear.AutoSize = true;
            this.lblClassControlYear.Location = new System.Drawing.Point(164, 107);
            this.lblClassControlYear.Name = "lblClassControlYear";
            this.lblClassControlYear.Size = new System.Drawing.Size(43, 20);
            this.lblClassControlYear.TabIndex = 34;
            this.lblClassControlYear.Text = "Year";
            // 
            // txtPaymentControlYear
            // 
            this.txtPaymentControlYear.Location = new System.Drawing.Point(168, 147);
            this.txtPaymentControlYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentControlYear.Name = "txtPaymentControlYear";
            this.txtPaymentControlYear.ShortcutsEnabled = false;
            this.txtPaymentControlYear.Size = new System.Drawing.Size(45, 27);
            this.txtPaymentControlYear.TabIndex = 33;
            this.txtPaymentControlYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentControlYear_KeyPress);
            // 
            // lblClassControlMonth
            // 
            this.lblClassControlMonth.AutoSize = true;
            this.lblClassControlMonth.Location = new System.Drawing.Point(37, 107);
            this.lblClassControlMonth.Name = "lblClassControlMonth";
            this.lblClassControlMonth.Size = new System.Drawing.Size(55, 20);
            this.lblClassControlMonth.TabIndex = 32;
            this.lblClassControlMonth.Text = "Month";
            // 
            // cbPaymentControlMonth
            // 
            this.cbPaymentControlMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentControlMonth.FormattingEnabled = true;
            this.cbPaymentControlMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbPaymentControlMonth.Location = new System.Drawing.Point(39, 146);
            this.cbPaymentControlMonth.Name = "cbPaymentControlMonth";
            this.cbPaymentControlMonth.Size = new System.Drawing.Size(40, 28);
            this.cbPaymentControlMonth.TabIndex = 31;
            // 
            // lblPaymentControl
            // 
            this.lblPaymentControl.AutoSize = true;
            this.lblPaymentControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentControl.Location = new System.Drawing.Point(34, 34);
            this.lblPaymentControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentControl.Name = "lblPaymentControl";
            this.lblPaymentControl.Size = new System.Drawing.Size(496, 25);
            this.lblPaymentControl.TabIndex = 30;
            this.lblPaymentControl.Text = "Inform the month and the year of the student\'s payments";
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 719);
            this.Controls.Add(this.tcStudentRegistration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration (Teacher Craig Mitchell)";
            this.tcStudentRegistration.ResumeLayout(false);
            this.tabStudentsData.ResumeLayout(false);
            this.tabStudentsData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsData)).EndInit();
            this.tabClassSchedules.ResumeLayout(false);
            this.tabClassSchedules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassSchedules)).EndInit();
            this.tabClassControl.ResumeLayout(false);
            this.tabClassControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassControl)).EndInit();
            this.tabPaymentControl.ResumeLayout(false);
            this.tabPaymentControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStudentRegistration;
        private System.Windows.Forms.TabPage tabStudentsData;
        private System.Windows.Forms.TabPage tabClassSchedules;
        private System.Windows.Forms.TabPage tabClassControl;
        private System.Windows.Forms.TabPage tabPaymentControl;
        private System.Windows.Forms.Label lblSudentsData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPaymentDay;
        private System.Windows.Forms.TextBox txtPaymentDay;
        private System.Windows.Forms.Label lblPaymentValor;
        private System.Windows.Forms.TextBox txtPaymentValor;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.MaskedTextBox mtxtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.DataGridView dgvStudentsData;
        private System.Windows.Forms.Button btnStudentSave;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.Label lblWeekDayRegister;
        private System.Windows.Forms.ComboBox cbScheludeDay;
        private System.Windows.Forms.ComboBox cbScheludeStudent;
        private System.Windows.Forms.DataGridView dgvClassSchedules;
        private System.Windows.Forms.MaskedTextBox mtxtScheludeTime;
        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.Label lblWeekDayTime;
        private System.Windows.Forms.Label lblWeekDayStudent;
        private System.Windows.Forms.Button btnScheludeSave;
        private System.Windows.Forms.ComboBox cbScheduleSearch;
        private System.Windows.Forms.Label lblScheduleSearch;
        private System.Windows.Forms.TextBox txtScheduleSearchStudent;
        private System.Windows.Forms.ComboBox cbScheduleSearchWeekDay;
        private System.Windows.Forms.Label lblClassControlStudent;
        private System.Windows.Forms.ComboBox cbClassControlStudent;
        private System.Windows.Forms.Label lblClassControl;
        private System.Windows.Forms.DateTimePicker dtpClassControlDate;
        private System.Windows.Forms.Label lblClassControlDate;
        private System.Windows.Forms.TextBox txtClassControlDone;
        private System.Windows.Forms.TextBox txtClassControlPlanned;
        private System.Windows.Forms.DataGridView dgvClassControl;
        private System.Windows.Forms.Label lblClassControlDone;
        private System.Windows.Forms.Label lblClassControlPlanned;
        private System.Windows.Forms.Button btnClassControlSave;
        private System.Windows.Forms.TextBox txtClassControlSearch;
        private System.Windows.Forms.Label lblClassControlSearch;
        private System.Windows.Forms.ComboBox cbPaymentControlMonth;
        private System.Windows.Forms.Label lblPaymentControl;
        private System.Windows.Forms.TextBox txtPaymentControlYear;
        private System.Windows.Forms.Label lblClassControlMonth;
        private System.Windows.Forms.Label lblClassControlYear;
        private System.Windows.Forms.ComboBox cbPaymentControlSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPaymentControl;
        private System.Windows.Forms.TextBox txtPaymentControlSearchYear;
        private System.Windows.Forms.ComboBox cbPaymentControlSearchMonth;
        private System.Windows.Forms.TextBox txtPaymentControlSearchStudent;
        private System.Windows.Forms.Button btnPaymentControlDelete;
        private System.Windows.Forms.Button btnPaymentControlSave;
        private System.Windows.Forms.Button btnPaymentControlSearch;
    }
}

