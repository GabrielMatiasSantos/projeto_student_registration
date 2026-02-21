using System;
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
    public partial class frmClassSchedulesUpdateDelete : Form
    {
        public frmClassSchedulesUpdateDelete(string student, string weekDay, string time, string id)
        {
            InitializeComponent();

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

            cbScheludeStudent.Text = student;
            cbScheludeDay.Text = weekDay;
            mtxtScheludeTime.Text = time;
            txtId.Text = id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbScheludeDay.Text == "" || mtxtScheludeTime.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtxtScheludeTime.Text.Length < 5)
            {
                MessageBox.Show("Fill in the field 'Time' correctly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClassSchedule classSchedule = new ClassSchedule(Convert.ToInt32(txtId.Text), Convert.ToInt32(cbScheludeStudent.SelectedValue), cbScheludeDay.Text, mtxtScheludeTime.Text);

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
                    var button = MessageBox.Show("Confirm data insertion?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time AND NOT schedule_id = @id OR schedule_day = @day AND schedule_time = @time2 AND NOT schedule_id = @id;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time2);
                                    query.Parameters.AddWithValue("@id", classSchedule.Id);
                                }
                                else
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time AND NOT schedule_id = @id OR schedule_day = @day AND schedule_time = @time2 AND NOT schedule_id = @id OR schedule_day = @day2 AND schedule_time = @time3 AND NOT schedule_id = @id;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@day2", weekday);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time2);
                                    query.Parameters.AddWithValue("@time3", time);
                                    query.Parameters.AddWithValue("@id", classSchedule.Id);
                                }
                            }
                            else if (timeParts[1] == "30" && timeParts[0] == "23")
                            {
                                if (classSchedule.WeekDay == "5. Friday")
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time AND NOT schedule_id = @id OR schedule_day = @day AND schedule_time = @time2 AND NOT schedule_id = @id;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time);
                                    query.Parameters.AddWithValue("@id", classSchedule.Id);
                                }
                                else
                                {
                                    query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time AND NOT schedule_id = @id OR schedule_day = @day AND schedule_time = @time2 AND NOT schedule_id = @id OR schedule_day = @day2 AND schedule_time = @time3 AND NOT schedule_id = @id;";

                                    query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                    query.Parameters.AddWithValue("@day2", weekday);
                                    query.Parameters.AddWithValue("@time", classSchedule.Time);
                                    query.Parameters.AddWithValue("@time2", time);
                                    query.Parameters.AddWithValue("@time3", time2);
                                    query.Parameters.AddWithValue("@id", classSchedule.Id);
                                }
                            }
                            else
                            {
                                query.CommandText = "SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_day = @day AND schedule_time = @time AND NOT schedule_id = @id OR schedule_day = @day AND schedule_time = @time2 AND NOT schedule_id = @id OR schedule_day = @day AND schedule_time = @time3 AND NOT schedule_id = @id;";

                                query.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                query.Parameters.AddWithValue("@time", classSchedule.Time);
                                query.Parameters.AddWithValue("@time2", time);
                                query.Parameters.AddWithValue("@time3", time2);
                                query.Parameters.AddWithValue("@id", classSchedule.Id);
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
                                SqlCommand update = new SqlCommand("UPDATE tb_class_schedules SET schedule_student = @student, schedule_day = @day, schedule_time = @time WHERE schedule_id = @id;", connection);

                                update.Parameters.AddWithValue("@student", classSchedule.Student);
                                update.Parameters.AddWithValue("@day", classSchedule.WeekDay);
                                update.Parameters.AddWithValue("@time", classSchedule.Time);
                                update.Parameters.AddWithValue("@id", classSchedule.Id);

                                update.ExecuteNonQuery();

                                connection.Close();

                                MessageBox.Show("Data inserted successfully", "Succesful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var button = MessageBox.Show("Confirm the removal of a class schedule?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (button == DialogResult.Yes)
            {
                SqlConnection connection = null;

                try
                {
                    ClassSchedule classSchedule = new ClassSchedule(Convert.ToInt32(txtId.Text));

                    connection = new SqlConnection(ConnectionString.connectionString);

                    SqlCommand delete = new SqlCommand("DELETE FROM tb_class_schedules WHERE schedule_id = @id;", connection);

                    delete.Parameters.AddWithValue("@id", classSchedule.Id);

                    connection.Open();

                    delete.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Class schedule successfully removed", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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

        private void frmClassSchedulesUpdateDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentRegistration studentRegistration = new frmStudentRegistration();

            studentRegistration.OpenTab = 1;
            studentRegistration.Show();
        }
    }
}
