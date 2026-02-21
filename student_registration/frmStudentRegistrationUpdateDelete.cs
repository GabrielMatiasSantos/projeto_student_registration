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
    public partial class frmStudentRegistrationUpdateDelete : Form
    {
        public frmStudentRegistrationUpdateDelete(string name, string cpf, string telephone, string day, string valor, string status, string state, string city, string street, string neighborhood, string number, string zip, string id)
        {
            InitializeComponent();

            txtName.Text = name;
            mtxtCpf.Text = cpf;
            mtxtTelephone.Text = telephone;
            txtPaymentDay.Text = day;
            txtPaymentValor.Text = valor;
            cbStatus.Text = status;
            txtState.Text = state;
            txtCity.Text = city;
            txtStreet.Text = street;
            txtNeighborhood.Text = neighborhood;
            txtNumber.Text = number;
            mtxtZipCode.Text = zip;
            txtId.Text = id;
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


        private void btnUpdate_Click(object sender, EventArgs e)
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
                var button = MessageBox.Show("Confirm data insertion?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    SqlConnection connection = null;

                    try
                    {
                        Student student = new Student(Convert.ToInt32(txtId.Text), txtName.Text, mtxtCpf.Text, mtxtTelephone.Text, Convert.ToInt32(txtPaymentDay.Text), Convert.ToDecimal(txtPaymentValor.Text), txtState.Text.ToUpper(), txtCity.Text, txtStreet.Text, txtNeighborhood.Text, Convert.ToInt32(txtNumber.Text), mtxtZipCode.Text, cbStatus.Text);

                        connection = new SqlConnection(ConnectionString.connectionString);

                        SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_students WHERE student_cpf = @cpf AND NOT student_id = @id", connection);

                        query.Parameters.AddWithValue("@cpf", student.Cpf);
                        query.Parameters.AddWithValue("@id", student.Id);

                        connection.Open();

                        int quantity = Convert.ToInt32(query.ExecuteScalar());

                        if (quantity > 0)
                        {
                            MessageBox.Show("There is already a student with this CPF", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            connection.Close();
                        }
                        else
                        {
                            SqlCommand query2 = new SqlCommand("SELECT COUNT(*) FROM tb_students WHERE student_telephone = @telephone AND NOT student_id = @id", connection);

                            query2.Parameters.AddWithValue("@telephone", student.Telephone);
                            query2.Parameters.AddWithValue("@id", student.Id);

                            int quantity2 = Convert.ToInt32(query2.ExecuteScalar());

                            if (quantity2 > 0)
                            {
                                MessageBox.Show("There is already a student with this telephone number", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                connection.Close();
                            }
                            else
                            {
                                SqlCommand update = new SqlCommand("UPDATE tb_students SET student_name = @name, student_cpf = @cpf, student_telephone = @telephone, student_payment_day = @paymentDay, student_payment_value = @paymentValue, student_status = @status, student_state = @state, student_city = @city, student_street = @street, student_neighborhood = @neighborhood, student_number = @number, student_zip_code = @zipCode WHERE student_id = @id;", connection);

                                update.Parameters.AddWithValue("@name", student.Name);
                                update.Parameters.AddWithValue("@cpf", student.Cpf);
                                update.Parameters.AddWithValue("@telephone", student.Telephone);
                                update.Parameters.AddWithValue("@paymentDay", student.Day);
                                update.Parameters.AddWithValue("@paymentValue", student.Value);
                                update.Parameters.AddWithValue("@status", student.Status);
                                update.Parameters.AddWithValue("@state", student.State);
                                update.Parameters.AddWithValue("@city", student.City);
                                update.Parameters.AddWithValue("@street", student.Street);
                                update.Parameters.AddWithValue("@neighborhood", student.Neighborhood);
                                update.Parameters.AddWithValue("@number", student.Number);
                                update.Parameters.AddWithValue("@zipCode", student.Zip);
                                update.Parameters.AddWithValue("@id", student.Id);

                                update.ExecuteNonQuery();

                                connection.Close();

                                MessageBox.Show("Data inserted successfully", "Succesful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var button = MessageBox.Show("Confirm the removal of a student's data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            SqlConnection connection = null;

            if (button == DialogResult.Yes)
            {
                try
                {
                    Student student = new Student(Convert.ToInt32(txtId.Text));

                    connection = new SqlConnection(ConnectionString.connectionString);

                    SqlCommand query = new SqlCommand("SELECT COUNT(*) FROM tb_class_schedules WHERE schedule_student = @id;", connection);

                    query.Parameters.AddWithValue("@id", student.Id);

                    SqlCommand query2 = new SqlCommand("SELECT COUNT(*) FROM tb_class_control WHERE class_student = @id;", connection);

                    query2.Parameters.AddWithValue("@id", student.Id);

                    SqlCommand query3 = new SqlCommand("SELECT COUNT(*) FROM tb_payment_control WHERE payment_student = @id;", connection);

                    query3.Parameters.AddWithValue("@id", student.Id);

                    connection.Open();

                    int quantity = Convert.ToInt32(query.ExecuteScalar());
                    int quantity2 = Convert.ToInt32(query2.ExecuteScalar());
                    int quantity3 = Convert.ToInt32(query3.ExecuteScalar());

                    if (quantity > 0 || quantity2 > 0 || quantity3 > 0)
                    {
                        MessageBox.Show("This information is being used in registers of another tables. Remove them to remove this register", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        connection.Close();
                    }
                    else
                    {
                        SqlCommand delete = new SqlCommand("DELETE FROM tb_students WHERE student_id = @id", connection);

                        delete.Parameters.AddWithValue("@id", student.Id);

                        delete.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Student's data successfully removed", "Successful action", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void frmStudentRegistrationUpdateDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentRegistration studentRegistration = new frmStudentRegistration();

            studentRegistration.Show();
        }       
    }
}
