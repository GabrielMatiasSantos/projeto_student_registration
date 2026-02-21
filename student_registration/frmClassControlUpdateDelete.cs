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
    public partial class frmClassControlUpdateDelete : Form
    {
        public frmClassControlUpdateDelete(string student, string date, string planned, string done, string id)
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

            cbClassControlStudent.Text = student;
            dtpClassControlDate.Value = DateTime.Parse(date);
            txtClassControlPlanned.Text = planned;
            txtClassControlDone.Text = done;
            txtId.Text = id;
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

        private void frmClassControlUpdateDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentRegistration studentRegistration = new frmStudentRegistration();

            studentRegistration.OpenTab = 2;
            studentRegistration.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbClassControlStudent.Text == "" || txtClassControlPlanned.Text == "" || txtClassControlDone.Text == "")
            {
                MessageBox.Show("Fill in all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var button = MessageBox.Show("Confirm data insertion?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        ClassControl classControl = new ClassControl(Convert.ToInt32(txtId.Text), Convert.ToInt32(cbClassControlStudent.SelectedValue), dtpClassControlDate.Value, txtClassControlPlanned.Text, txtClassControlDone.Text);

                        connection = new SqlConnection(ConnectionString.connectionString);

                        SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_class_control WHERE class_student = @student AND class_date = @date AND NOT class_id = @id;", connection);

                        query.Parameters.AddWithValue("@student", classControl.Student);
                        query.Parameters.AddWithValue("@date", classControl.Date);
                        query.Parameters.AddWithValue("@id", classControl.Id);

                        connection.Open();

                        int quantity = Convert.ToInt32(query.ExecuteScalar());

                        if (quantity > 0)
                        {
                            MessageBox.Show("There is already a class control of this student in this date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            connection.Close();
                        }
                        else
                        {
                            SqlCommand update = new SqlCommand("UPDATE tb_class_control SET class_student = @student, class_date = @date, class_planned = @planned, class_done = @done WHERE class_id = @id;", connection);

                            update.Parameters.AddWithValue("@student", classControl.Student);
                            update.Parameters.AddWithValue("@date", classControl.Date);
                            update.Parameters.AddWithValue("@planned", classControl.Planned);
                            update.Parameters.AddWithValue("@done", classControl.Done);
                            update.Parameters.AddWithValue("@id", classControl.Id);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var button = MessageBox.Show("Confirm the removal of a class control?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (button == DialogResult.Yes)
            {
                SqlConnection connection = null;

                try
                {
                    ClassControl classControl = new ClassControl(Convert.ToInt32(txtId.Text));

                    connection = new SqlConnection(ConnectionString.connectionString);

                    SqlCommand delete = new SqlCommand("DELETE FROM tb_class_control WHERE class_id = @id;", connection);

                    delete.Parameters.AddWithValue("@id", classControl.Id);

                    connection.Open();

                    delete.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Class control successfully removed", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
