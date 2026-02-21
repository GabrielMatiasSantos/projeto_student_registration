using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_registration
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        public void TableStudents()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand search = new SqlCommand("SELECT * FROM tb_students ORDER BY student_name", connection);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(search);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvStudentsData.DataSource = table;

                dgvStudentsData.Columns[0].Visible = false;

                dgvStudentsData.Columns[1].HeaderText = "Name";
                dgvStudentsData.Columns[2].HeaderText = "CPF";
                dgvStudentsData.Columns[3].HeaderText = "Telephone";
                dgvStudentsData.Columns[4].HeaderText = "Payment Day";
                dgvStudentsData.Columns[5].HeaderText = "Payment valor";
                dgvStudentsData.Columns[6].HeaderText = "Address - State";
                dgvStudentsData.Columns[7].HeaderText = "Address - City";
                dgvStudentsData.Columns[8].HeaderText = "Address - Street";
                dgvStudentsData.Columns[9].HeaderText = "Address - Neighborhood";
                dgvStudentsData.Columns[10].HeaderText = "Address - Number";
                dgvStudentsData.Columns[11].HeaderText = "Address - ZIP Code";
                dgvStudentsData.Columns[12].HeaderText = "Status";

                dgvStudentsData.Columns[1].Width = 200;
                dgvStudentsData.Columns[2].Width = 120;
                dgvStudentsData.Columns[3].Width = 120;
                dgvStudentsData.Columns[4].Width = 120;
                dgvStudentsData.Columns[5].Width = 125;
                dgvStudentsData.Columns[6].Width = 135;
                dgvStudentsData.Columns[7].Width = 125;
                dgvStudentsData.Columns[8].Width = 180;
                dgvStudentsData.Columns[9].Width = 190;
                dgvStudentsData.Columns[10].Width = 150;
                dgvStudentsData.Columns[11].Width = 160;
                dgvStudentsData.Columns[12].Width = 80;

                dgvStudentsData.Columns[1].DisplayIndex = 0;
                dgvStudentsData.Columns[2].DisplayIndex = 1;
                dgvStudentsData.Columns[3].DisplayIndex = 2;
                dgvStudentsData.Columns[4].DisplayIndex = 3;
                dgvStudentsData.Columns[5].DisplayIndex = 4;
                dgvStudentsData.Columns[6].DisplayIndex = 5;
                dgvStudentsData.Columns[7].DisplayIndex = 6;
                dgvStudentsData.Columns[8].DisplayIndex = 7;
                dgvStudentsData.Columns[9].DisplayIndex = 8;
                dgvStudentsData.Columns[10].DisplayIndex = 9;
                dgvStudentsData.Columns[11].DisplayIndex = 10;
                dgvStudentsData.Columns[12].DisplayIndex = 11;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }            
        }

        public void TableClassSchedules()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT schedule_id, student_name, schedule_day, schedule_time FROM tb_class_schedules INNER JOIN tb_students ON tb_class_schedules.schedule_student = tb_students.student_id ORDER BY schedule_day, schedule_time;", connection);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvClassSchedules.DataSource = table;

                dgvClassSchedules.Columns[0].Visible = false;

                dgvClassSchedules.Columns[1].HeaderText = "Student";
                dgvClassSchedules.Columns[2].HeaderText = "Week day";
                dgvClassSchedules.Columns[3].HeaderText = "Time";

                dgvClassSchedules.Columns[1].Width = 200;
                dgvClassSchedules.Columns[2].Width = 100;
                dgvClassSchedules.Columns[3].Width = 65;

                dgvClassSchedules.Columns[1].DisplayIndex = 0;
                dgvClassSchedules.Columns[2].DisplayIndex = 1;
                dgvClassSchedules.Columns[3].DisplayIndex = 2;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }            
        }

        public void TableClassControls()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT class_id, student_name, class_date, class_planned, class_done FROM tb_class_control INNER JOIN tb_students ON tb_class_control.class_student = tb_students.student_id ORDER BY class_date, student_name;", connection);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvClassControl.DataSource = table;

                dgvClassControl.Columns[0].Visible = false;

                dgvClassControl.Columns[1].HeaderText = "Name";
                dgvClassControl.Columns[2].HeaderText = "Class date";
                dgvClassControl.Columns[3].HeaderText = "Planned";
                dgvClassControl.Columns[4].HeaderText = "Done";

                dgvClassControl.Columns[1].Width = 200;
                dgvClassControl.Columns[2].Width = 102;
                dgvClassControl.Columns[3].Width = 255;
                dgvClassControl.Columns[4].Width = 255;

                dgvClassControl.Columns[1].DisplayIndex = 0;
                dgvClassControl.Columns[2].DisplayIndex = 1;
                dgvClassControl.Columns[3].DisplayIndex = 2;
                dgvClassControl.Columns[4].DisplayIndex = 3;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }            
        }

        public void TablePaymentControls()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT payment_id, student_name, payment_date, payment_status FROM tb_payment_control INNER JOIN tb_students ON tb_payment_control.payment_student = tb_students.student_id ORDER BY payment_date, student_name;", connection);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvPaymentControl.DataSource = table;

                dgvPaymentControl.Columns[0].Visible = false;

                dgvPaymentControl.Columns[1].HeaderText = "Student";
                dgvPaymentControl.Columns[2].HeaderText = "Payment date";
                dgvPaymentControl.Columns[3].HeaderText = "Payment status";

                dgvPaymentControl.Columns[1].Width = 200;
                dgvPaymentControl.Columns[2].Width = 120;
                dgvPaymentControl.Columns[3].Width = 130;

                dgvPaymentControl.Columns[1].DisplayIndex = 0;
                dgvPaymentControl.Columns[2].DisplayIndex = 1;
                dgvPaymentControl.Columns[3].DisplayIndex = 2;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }            
        }


        public int OpenTab
        {
            set { tcStudentRegistration.SelectedIndex = value; }
        }

        
        //Tab 'Student's data'

        private void tabStudentsData_Enter(object sender, EventArgs e)
        {           
            TableStudents();
           
            txtName.Clear();
            mtxtCpf.Clear();
            mtxtTelephone.Clear();
            txtPaymentDay.Clear();
            txtPaymentValor.Clear();
            txtState.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtNeighborhood.Clear();
            txtNumber.Clear();
            mtxtZipCode.Clear();
            txtSearchStudent.Clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtName.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPaymentDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPaymentDay.Text == "")
            {
                if (!char.IsDigit(e.KeyChar) || e.KeyChar == '0')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || txtPaymentDay.Text.Length == 2 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPaymentValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPaymentValor.Text == "")
            {
                if (!char.IsDigit(e.KeyChar) || e.KeyChar == '0')
                {
                    e.Handled = true;
                }
            }
            else if (txtPaymentValor.Text.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }

                if (txtPaymentValor.Text.Substring(txtPaymentValor.Text.IndexOf(',')).Length == 3)
                {
                    if (e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtState.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }

                if (txtState.Text.Length == 2)
                {
                    if (e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCity.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStreet.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNeighborhood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNeighborhood.Text == "")
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPaymentDay.Text == "" || txtPaymentValor.Text == "" || txtState.Text == "" || txtCity.Text == "" || txtStreet.Text == "" || txtNeighborhood.Text == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtxtCpf.Text.Length < 14)
            {
                MessageBox.Show("Fill in the field 'CPF' correctly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtxtTelephone.Text.Length < 14)
            {
                MessageBox.Show("Fill in the field 'Telephone' correctly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(txtPaymentDay.Text) > 30 || Convert.ToInt32(txtPaymentDay.Text) < 1)
            {
                MessageBox.Show("Invalid payment day", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtState.Text.Length < 2)
            {
                MessageBox.Show("Fill in the field 'Address - St.' correctly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtxtZipCode.Text.Length < 9)
            {
                MessageBox.Show("Fill in the field 'Address - Zip Code' correctly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var button = MessageBox.Show("Confirm the insertion of a new student?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        Student student = new Student(txtName.Text, mtxtCpf.Text, mtxtTelephone.Text, Convert.ToInt32(txtPaymentDay.Text), Convert.ToDecimal(txtPaymentValor.Text), txtState.Text.ToUpper(), txtCity.Text, txtStreet.Text, txtNeighborhood.Text, Convert.ToInt32(txtNumber.Text), mtxtZipCode.Text, "Active");

                        connection = new SqlConnection(ConnectionString.connectionString);

                        SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_students WHERE student_cpf = @cpf", connection);

                        query.Parameters.AddWithValue("@cpf", student.Cpf);

                        connection.Open();

                        int quantity = Convert.ToInt32(query.ExecuteScalar());

                        if (quantity > 0)
                        {
                            MessageBox.Show("There is already a student with this CPF", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            connection.Close();
                        }
                        else
                        {
                            SqlCommand query2 = new SqlCommand("SELECT COUNT(*) FROM tb_students WHERE student_telephone = @telephone;", connection);

                            query2.Parameters.AddWithValue("@telephone", student.Telephone);

                            int quantity2 = Convert.ToInt32(query2.ExecuteScalar());

                            if (quantity2 > 0)
                            {
                                MessageBox.Show("There is already a student with this telephone number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                connection.Close();
                            }
                            else
                            {
                                SqlCommand insert = new SqlCommand("INSERT INTO tb_students VALUES (@name, @cpf, @telephone, @paymentDay, @paymentValue, @state, @city, @street, @neighborhood, @number, @zipCode, @status);", connection);

                                insert.Parameters.AddWithValue("@name", student.Name);
                                insert.Parameters.AddWithValue("@cpf", student.Cpf);
                                insert.Parameters.AddWithValue("@telephone", student.Telephone);
                                insert.Parameters.AddWithValue("@paymentDay", student.Day);
                                insert.Parameters.AddWithValue("@paymentValue", student.Value);
                                insert.Parameters.AddWithValue("@state", student.State);
                                insert.Parameters.AddWithValue("@city", student.City);
                                insert.Parameters.AddWithValue("@street", student.Street);
                                insert.Parameters.AddWithValue("@neighborhood", student.Neighborhood);
                                insert.Parameters.AddWithValue("@number", student.Number);
                                insert.Parameters.AddWithValue("@zipCode", student.Zip);
                                insert.Parameters.AddWithValue("@status", student.Status);

                                insert.ExecuteNonQuery();

                                MessageBox.Show("New student registered successfully", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtName.Clear();
                                mtxtCpf.Clear();
                                mtxtTelephone.Clear();
                                txtPaymentDay.Clear();
                                txtPaymentValor.Clear();
                                txtState.Clear();
                                txtCity.Clear();
                                txtStreet.Clear();
                                txtNeighborhood.Clear();
                                txtNumber.Clear();
                                mtxtZipCode.Clear();

                                TableStudents();
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void txtSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchStudent.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand search = new SqlCommand("SELECT * FROM tb_students WHERE student_name LIKE @name ORDER BY student_name;", connection);

                search.Parameters.AddWithValue("@name", '%' + txtSearchStudent.Text + '%');

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(search);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvStudentsData.DataSource = table;                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void dgvStudentsData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudentsData.SelectedRows.Count == 1)
            {
                frmStudentRegistrationUpdateDelete student = new frmStudentRegistrationUpdateDelete(dgvStudentsData.SelectedRows[0].Cells[1].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[2].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[3].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[4].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[5].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[12].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[6].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[7].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[8].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[9].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[10].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[11].Value.ToString(), dgvStudentsData.SelectedRows[0].Cells[0].Value.ToString());

                student.Show();
                this.Hide();
            }
        }


        //Tab 'Day(s) of the week'
        
        private void tabDaysOfTheWeek_Enter(object sender, EventArgs e)
        {           
            TableClassSchedules();
            
            cbScheludeStudent.SelectedIndex = -1;
            mtxtScheludeTime.Clear();
            cbScheludeDay.SelectedIndex = -1;
            cbScheduleSearch.SelectedIndex = -1;
            cbScheduleSearchWeekDay.SelectedIndex = -1;
            txtScheduleSearchStudent.Clear();
            txtScheduleSearchStudent.Visible = false;
        }

        private void cbWeekDayStudent_DropDown(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT student_id, student_name FROM tb_students WHERE student_status = 'Active';", connection);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                cbScheludeStudent.ValueMember = "student_id";
                cbScheludeStudent.DisplayMember = "student_name";
                cbScheludeStudent.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("There are no active students registered", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void btnScheludeSave_Click(object sender, EventArgs e)
        {
            if (cbScheludeStudent.Text == "" || cbScheludeDay.Text == "" || mtxtScheludeTime.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtxtScheludeTime.Text.Length < 5)
            {
                MessageBox.Show("Fill in the field 'Time' correctly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClassSchedule classSchedule = new ClassSchedule(Convert.ToInt32(cbScheludeStudent.SelectedValue), cbScheludeDay.Text, mtxtScheludeTime.Text);

                var timeParts = classSchedule.Time.Split(':');

                if (Convert.ToInt32(timeParts[0]) > 23 || Convert.ToInt32(timeParts[1]) > 59)
                {
                    MessageBox.Show("Invalid time", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (timeParts[1] != "00" && timeParts[1] != "30")
                {
                    MessageBox.Show("Invalid schedule", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var button = MessageBox.Show("Confirm the insertion of a new class schedule?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (button == DialogResult.Yes)
                    {
                        SqlConnection connection = null;

                        try
                        {
                            string time = default;
                            string time2 = default;
                            string weekday = default;

                            if (timeParts[1] == "00" && timeParts[0] == "00")
                            {
                                if (classSchedule.WeekDay == "1. Monday")
                                {
                                    time2 = "00:30";
                                }
                                else if (cbScheludeDay.Text == "2. Tuesday")
                                {
                                    time = "23:30";
                                    weekday = "1. Monday";
                                    time2 = "00:30";
                                }
                                else if (classSchedule.WeekDay == "3. Wednesday")
                                {
                                    time = "23:30";
                                    weekday = "2. Tuesday";
                                    time2 = "00:30";
                                }
                                else if (classSchedule.WeekDay == "4. Thursday")
                                {
                                    time = "23:30";
                                    weekday = "3. Wednesday";
                                    time2 = "00:30";
                                }
                                else if (classSchedule.WeekDay == "5. Friday")
                                {
                                    time = "23:30";
                                    weekday = "4. Thurday";
                                    time2 = "00:30";
                                }
                            }
                            else if (timeParts[1] == "00" && timeParts[0] != "00")
                            {
                                time = Convert.ToString(Convert.ToInt32(timeParts[0]) - 1) + ":30";
                                time2 = timeParts[0] + ":30";
                            }
                            else if (timeParts[1] == "30" && timeParts[0] == "23")
                            {
                                if (classSchedule.WeekDay == "1. Monday")
                                {
                                    time = "23:00";
                                    time2 = "00:00";
                                    weekday = "2. Tuesday";
                                }
                                else if (classSchedule.WeekDay == "2. Tuesday")
                                {
                                    time = "23:00";
                                    time2 = "00:00";
                                    weekday = "3. Wednesday";
                                }
                                else if (classSchedule.WeekDay == "3. Wednesday")
                                {
                                    time = "23:00";
                                    time2 = "00:00";
                                    weekday = "4. Thursday";
                                }
                                else if (classSchedule.WeekDay == "4. Thursday")
                                {
                                    time = "23:00";
                                    time2 = "00:00";
                                    weekday = "5. Friday";
                                }
                                else if (classSchedule.WeekDay == "5. Friday")
                                {
                                    time = "23:00";
                                }
                            }
                            else if (timeParts[1] == "30" && timeParts[0] != "23")
                            {
                                time = timeParts[0] + ":00";
                                time2 = Convert.ToString(Convert.ToInt32(timeParts[0]) + 1) + ":00";
                            }

                            connection = new SqlConnection(ConnectionString.connectionString);

                            SqlCommand query = connection.CreateCommand();

                            if (timeParts[1] == "00" && timeParts[0] == "00")
                            {
                                if (classSchedule.WeekDay == "1. Monday")
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time OR schedule_day = @day AND schedule_time = @time2;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time2);
                                }
                                else
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time OR schedule_day = @day AND schedule_time = @time2 OR schedule_day = @day2 AND schedule_time = @time3;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@day2", weekday);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time2);
                                    query.Parameters.AddWithValue("@time3", time);                                    
                                }
                            }
                            else if (timeParts[1] == "30" && timeParts[0] == "23")
                            {
                                if (classSchedule.WeekDay == "5. Friday")
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time OR schedule_day = @day AND schedule_time = @time2;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time);
                                }
                                else
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time OR schedule_day = @day AND schedule_time = @time2 OR schedule_day = @day2 AND schedule_time = @time3;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@day2", weekday);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time);
                                    query.Parameters.AddWithValue("@time3", time2);
                                }
                            }
                            else
                            {
                                query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time OR schedule_day = @day AND schedule_time = @time2 OR schedule_day = @day AND schedule_time = @time3;";

                                query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                query.Parameters.AddWithValue("@time", classSchedule.Time);
                                query.Parameters.AddWithValue("@time2", time);
                                query.Parameters.AddWithValue("@time3", time2);
                            }

                            connection.Open();

                            int quantity = Convert.ToInt32(query.ExecuteScalar());

                            if (quantity != 0)
                            {
                                MessageBox.Show("There is already a class scheluded in this day and time", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                connection.Close();
                            }
                            else
                            {
                                SqlCommand insert = new SqlCommand("INSERT INTO tb_class_schedules VALUES (@student, @day, @time);", connection);

                                insert.Parameters.AddWithValue("@student", classSchedule.Student);
                                insert.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                insert.Parameters.AddWithValue("@time", classSchedule.Time);

                                insert.ExecuteNonQuery();

                                connection.Close();

                                MessageBox.Show("New class schelude registered successfully", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cbScheludeStudent.SelectedIndex = -1;
                                cbScheludeDay.SelectedIndex = -1;
                                mtxtScheludeTime.Clear();

                                TableClassSchedules();
                            }
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (connection != null && connection.State != ConnectionState.Closed)
                            {
                                connection.Close();
                            }
                        }
                    }                                      
                }
            }
        }

        private void cbScheduleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbScheduleSearch.Text == "Student")
            {
                cbScheduleSearchWeekDay.Visible = false;
                txtScheduleSearchStudent.Visible = true;
            }
            else if (cbScheduleSearch.Text == "Classes in a week day")
            {
                cbScheduleSearchWeekDay.Visible = true;
                txtScheduleSearchStudent.Visible = false;
            }
        }

        private void txtScheduleSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtScheduleSearchStudent.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtScheduleSearchStudent_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand search = new SqlCommand("SELECT schedule_id, student_name, schedule_day, schedule_time FROM tb_class_schedules INNER JOIN tb_students ON tb_class_schedules.schedule_student = tb_students.student_id  WHERE student_name LIKE @name ORDER BY schedule_day, schedule_time;", connection);

                search.Parameters.AddWithValue("@name", '%' + txtScheduleSearchStudent.Text + '%');

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(search);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvClassSchedules.DataSource = table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void cbScheduleSearchWeekDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                ClassSchedule classSchedule = new ClassSchedule(cbScheduleSearchWeekDay.Text);

                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand search = new SqlCommand("SELECT schedule_id, student_name, schedule_day, schedule_time FROM tb_class_schedules INNER JOIN tb_students ON tb_class_schedules.schedule_student = tb_students.student_id  WHERE schedule_day LIKE @day ORDER BY schedule_time;", connection);

                search.Parameters.AddWithValue("@day", classSchedule.WeekDay);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(search);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvClassSchedules.DataSource = table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void dgvClassSchedules_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClassSchedules.SelectedRows.Count == 1)
            {
                frmClassSchedulesUpdateDelete classSchedule = new frmClassSchedulesUpdateDelete(dgvClassSchedules.SelectedRows[0].Cells[1].Value.ToString(), dgvClassSchedules.SelectedRows[0].Cells[2].Value.ToString(), dgvClassSchedules.SelectedRows[0].Cells[3].Value.ToString(), dgvClassSchedules.SelectedRows[0].Cells[0].Value.ToString());

                classSchedule.Show();
                this.Hide();
            }
        }


        //Tab 'Class control'

        private void tabClassControl_Enter(object sender, EventArgs e)
        {         
            TableClassControls();
           
            cbClassControlStudent.SelectedIndex = -1;
            dtpClassControlDate.Value = DateTime.Today;
            txtClassControlPlanned.Clear();
            txtClassControlDone.Clear();
            txtClassControlSearch.Clear();
        }

        private void txtClassControlPlanned_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtClassControlPlanned.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtClassControlDone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtClassControlDone.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void cbClassControlStudent_DropDown(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT student_id, student_name FROM tb_students WHERE student_status = 'Active';", connection);

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                cbClassControlStudent.ValueMember = "student_id";
                cbClassControlStudent.DisplayMember = "student_name";
                cbClassControlStudent.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("There are no active students registered", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void btnClassControlSave_Click(object sender, EventArgs e)
        {
            if (cbClassControlStudent.Text == "" || txtClassControlPlanned.Text == "" || txtClassControlDone.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var button = MessageBox.Show("Confirm the insertion of a new class control?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        ClassControl classControl = new ClassControl(Convert.ToInt32(cbClassControlStudent.SelectedValue), dtpClassControlDate.Value, txtClassControlPlanned.Text, txtClassControlDone.Text);

                        connection = new SqlConnection(ConnectionString.connectionString);

                        SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_class_control WHERE class_student = @student AND class_date = @date;", connection);

                        query.Parameters.AddWithValue("@student", classControl.Student);
                        query.Parameters.AddWithValue("@date", classControl.Date);

                        connection.Open();

                        int quantity = Convert.ToInt32(query.ExecuteScalar());

                        if (quantity > 0)
                        {
                            MessageBox.Show("There is already a class control of this student in this date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            connection.Close();
                        }
                        else
                        {
                            SqlCommand insert = new SqlCommand("INSERT INTO tb_class_control VALUES (@student, @date, @planned, @done);", connection);

                            insert.Parameters.AddWithValue("@student", classControl.Student);
                            insert.Parameters.AddWithValue("@date", classControl.Date);
                            insert.Parameters.AddWithValue("@planned", classControl.Planned);
                            insert.Parameters.AddWithValue("@done", classControl.Done);

                            insert.ExecuteNonQuery();

                            connection.Close();

                            MessageBox.Show("New class control registered successfully", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cbClassControlStudent.SelectedIndex = -1;
                            txtClassControlPlanned.Clear();
                            txtClassControlDone.Clear();

                            TableClassControls();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void txtClassControlSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtClassControlSearch.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtClassControlSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT class_id, student_name, class_date, class_planned, class_done FROM tb_class_control INNER JOIN tb_students ON tb_class_control.class_student = tb_students.student_id WHERE student_name LIKE @student ORDER BY class_date, student_name;", connection);

                query.Parameters.AddWithValue("@student", '%' + txtClassControlSearch.Text + '%');

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvClassControl.DataSource = table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void dgvClassControl_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClassControl.SelectedRows.Count == 1)
            {
                frmClassControlUpdateDelete classControl = new frmClassControlUpdateDelete(dgvClassControl.SelectedRows[0].Cells[1].Value.ToString(), dgvClassControl.SelectedRows[0].Cells[2].Value.ToString(), dgvClassControl.SelectedRows[0].Cells[3].Value.ToString(), dgvClassControl.SelectedRows[0].Cells[4].Value.ToString(), dgvClassControl.SelectedRows[0].Cells[0].Value.ToString());

                classControl.Show();
                this.Hide();
            }
        }


        //Tab 'Payment control'


        private void tabPaymentControl_Enter(object sender, EventArgs e)
        {           
            TablePaymentControls();
          
            cbPaymentControlMonth.SelectedIndex = -1;
            txtPaymentControlYear.Clear();
            cbPaymentControlSearch.SelectedIndex = -1;
            cbPaymentControlSearchMonth.SelectedIndex = -1;
            cbPaymentControlSearchMonth.Visible = false;
            txtPaymentControlSearchYear.Clear();
            txtPaymentControlSearchYear.Visible = false;
            btnPaymentControlSearch.Visible = false;
            txtPaymentControlSearchStudent.Clear();
            txtPaymentControlSearchStudent.Visible = false;
        }

        private void txtPaymentControlYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 || txtPaymentControlYear.Text.Length == 4 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cbPaymentControlSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentControlSearch.Text == "Student")
            {
                cbPaymentControlSearchMonth.Visible = false;
                txtPaymentControlSearchYear.Visible = false;
                btnPaymentControlSearch.Visible = false;
                txtPaymentControlSearchStudent.Visible = true;
            }
            else if (cbPaymentControlSearch.Text == "Date")
            {
                cbPaymentControlSearchMonth.Visible = true;
                txtPaymentControlSearchYear.Visible = true;
                btnPaymentControlSearch.Visible = true;
                txtPaymentControlSearchStudent.Visible = false;
            }
        }

        private void btnPaymentControlSave_Click(object sender, EventArgs e)
        {
            if (cbPaymentControlMonth.Text == "" || txtPaymentControlYear.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(txtPaymentControlYear.Text) < 2000 || Convert.ToInt32(txtPaymentControlYear.Text) > 2099)
            {
                MessageBox.Show("Inform a valid year", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var button = MessageBox.Show("Confirm the insertion of payment registers of the informed date?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        connection = new SqlConnection(ConnectionString.connectionString);

                        SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_students WHERE student_status = 'Active';", connection);

                        connection.Open();

                        int quantity = Convert.ToInt32(query.ExecuteScalar());

                        if (quantity == 0)
                        {
                            MessageBox.Show("There are no active students registered", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            connection.Close();
                        }
                        else
                        {
                            SqlCommand query2 = new SqlCommand("SELECT COUNT(*) FROM tb_payment_control WHERE MONTH(payment_date) = @month AND YEAR(payment_date) = @year;", connection);

                            query2.Parameters.AddWithValue("@month", cbPaymentControlMonth.Text);
                            query2.Parameters.AddWithValue("@year", txtPaymentControlYear.Text);

                            int quantity2 = Convert.ToInt32(query2.ExecuteScalar());

                            if (quantity2 > 0)
                            {
                                MessageBox.Show("The payments of this month and year are already registered", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                connection.Close();
                            }
                            else
                            {
                                PaymentControl paymentControl = new PaymentControl();

                                paymentControl.Student = new int[quantity];
                                string[] paymentDay = new string[quantity];

                                int counter = 0;

                                SqlCommand query3 = new SqlCommand("SELECT student_id, student_payment_day FROM tb_students WHERE student_status = 'Active';", connection);

                                SqlDataReader data = query3.ExecuteReader();


                                while (data.Read())
                                {
                                    paymentControl.Student[counter] = Convert.ToInt32(data["student_id"]);

                                    if (cbPaymentControlMonth.Text == "02" && data["student_payment_day"].ToString() == "30" || cbPaymentControlMonth.Text == "02" && data["student_payment_day"].ToString() == "29")
                                    {
                                        if (DateTime.IsLeapYear(Convert.ToInt32(txtPaymentControlYear.Text)))
                                        {
                                            paymentDay[counter] = "29";
                                        }
                                        else
                                        {
                                            paymentDay[counter] = "28";
                                        }
                                    }
                                    else
                                    {
                                        paymentDay[counter] = data["student_payment_day"].ToString();
                                    }

                                    if (counter < quantity - 1)
                                    {
                                        counter++;
                                    }
                                }

                                data.Close();

                                counter = 0;

                                while (counter < quantity)
                                {
                                    paymentControl.Date = DateTime.Parse(txtPaymentControlYear.Text + '/' + cbPaymentControlMonth.Text + '/' + paymentDay[counter]);

                                    SqlCommand insert = new SqlCommand("INSERT INTO tb_payment_control VALUES (@student, @date, @status);", connection);

                                    insert.Parameters.AddWithValue("@student", paymentControl.Student[counter]);
                                    insert.Parameters.AddWithValue("@date", paymentControl.Date);
                                    insert.Parameters.AddWithValue("@status", "Not paid");

                                    insert.ExecuteNonQuery();

                                    counter++;
                                }

                                connection.Close();

                                MessageBox.Show("Payments of this month and year succesfully registered", "Succesful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cbPaymentControlMonth.SelectedIndex = -1;
                                txtPaymentControlYear.Clear();

                                TablePaymentControls();
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnPaymentControlDelete_Click(object sender, EventArgs e)
        {
            if (cbPaymentControlMonth.Text == "" || txtPaymentControlYear.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(txtPaymentControlYear.Text) < 2000 || Convert.ToInt32(txtPaymentControlYear.Text) > 2099)
            {
                MessageBox.Show("Inform a valid year", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var button = MessageBox.Show("Confirm the removal of payment registers of the informed date?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        connection = new SqlConnection(ConnectionString.connectionString);

                        SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_payment_control WHERE MONTH(payment_date) = @month AND YEAR(payment_date) = @year;", connection);

                        query.Parameters.AddWithValue("@month", cbPaymentControlMonth.Text);
                        query.Parameters.AddWithValue("@year", txtPaymentControlYear.Text);

                        connection.Open();

                        int quantity = Convert.ToInt32(query.ExecuteScalar());

                        if (quantity == 0)
                        {
                            MessageBox.Show("There are no payment registers from this month and year", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            connection.Close();
                        }
                        else
                        {
                            SqlCommand delete = new SqlCommand("DELETE FROM tb_payment_control WHERE MONTH(payment_date) = @month AND YEAR(payment_date) = @year;", connection);

                            delete.Parameters.AddWithValue("@month", cbPaymentControlMonth.Text);
                            delete.Parameters.AddWithValue("@year", txtPaymentControlYear.Text);

                            delete.ExecuteNonQuery();

                            connection.Close();

                            MessageBox.Show("Payment registers from the informed data removed succesfully", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TablePaymentControls();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void dgvPaymentControl_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPaymentControl.SelectedRows.Count == 1)
            {
                var button = MessageBox.Show("Update the payment status of the selected register?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        connection = new SqlConnection(ConnectionString.connectionString);

                        if (dgvPaymentControl.SelectedRows[0].Cells[3].Value.ToString() == "Not paid")
                        {
                            PaymentControl paymentControl = new PaymentControl(Convert.ToInt32(dgvPaymentControl.SelectedRows[0].Cells[0].Value), "Paid");

                            SqlCommand update = new SqlCommand("UPDATE tb_payment_control SET payment_status = @status WHERE payment_id = @id", connection);

                            update.Parameters.AddWithValue("@status", paymentControl.Status);
                            update.Parameters.AddWithValue("@id", paymentControl.Id);

                            connection.Open();

                            update.ExecuteNonQuery();

                            connection.Close();
                        }
                        else
                        {
                            PaymentControl paymentControl = new PaymentControl(Convert.ToInt32(dgvPaymentControl.SelectedRows[0].Cells[0].Value), "Not paid");

                            SqlCommand update = new SqlCommand("UPDATE tb_payment_control SET payment_status = @status WHERE payment_id = @id", connection);

                            update.Parameters.AddWithValue("@status", paymentControl.Status);
                            update.Parameters.AddWithValue("@id", paymentControl.Id);

                            connection.Open();

                            update.ExecuteNonQuery();

                            connection.Close();
                        }

                        MessageBox.Show("Payment status update successfully", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TablePaymentControls();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void txtPaymentControlSearchYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 || txtPaymentControlSearchYear.Text.Length == 4 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPaymentControlSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPaymentControlSearchStudent.Text == "")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPaymentControlSearchStudent_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ConnectionString.connectionString);

                SqlCommand query = new SqlCommand("SELECT payment_id, student_name, payment_date, payment_status FROM tb_payment_control INNER JOIN tb_students ON tb_payment_control.payment_student = tb_students.student_id WHERE student_name LIKE @student ORDER BY payment_date, student_name;", connection);

                query.Parameters.AddWithValue("@student", '%' + txtPaymentControlSearchStudent.Text + '%');

                connection.Open();

                SqlDataAdapter data = new SqlDataAdapter(query);

                connection.Close();

                DataTable table = new DataTable();

                data.Fill(table);

                dgvPaymentControl.DataSource = table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void btnPaymentControlSearch_Click(object sender, EventArgs e)
        {
            if (cbPaymentControlSearchMonth.Text == "" || txtPaymentControlSearchYear.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(txtPaymentControlSearchYear.Text) < 2000 || Convert.ToInt32(txtPaymentControlSearchYear.Text) > 2099)
            {
                MessageBox.Show("Inform a valid year", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = null;

                try
                {
                    connection = new SqlConnection(ConnectionString.connectionString);

                    SqlCommand query = new SqlCommand("SELECT payment_id, student_name, payment_date, payment_status FROM tb_payment_control INNER JOIN tb_students ON tb_payment_control.payment_student = tb_students.student_id WHERE Month(payment_date) = @month AND Year(payment_date) = @year ORDER BY payment_date, student_name;", connection);

                    query.Parameters.AddWithValue("@month", cbPaymentControlSearchMonth.Text);
                    query.Parameters.AddWithValue("@year", txtPaymentControlSearchYear.Text);

                    connection.Open();

                    SqlDataAdapter data = new SqlDataAdapter(query);

                    connection.Close();

                    DataTable table = new DataTable();

                    data.Fill(table);

                    dgvPaymentControl.DataSource = table;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection != null && connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }       
    }   
}
