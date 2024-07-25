using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login
{
    public partial class addAdmin : Form
    {
        private const string ConnectionString = "Server=GAJADEERA\\SQLEXPRESS;Database=LoginSystem;Integrated Security=True;";

        public addAdmin()
        {
            InitializeComponent();
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            string entredUserName = txtUsername.Text;
            string entredEmail = txtEmail.Text;
            string entredPassword = txtPassword.Text;
            string entredReTypePassword = txtReTypePassword.Text;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (isValidEmail(entredEmail, emailPattern))
            {
                if (entredPassword == entredReTypePassword)
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString)) ;

                    string hashedPassword = HashPassword(entredPassword);

                    const string insertQuery = "INSERT INTO Admin (userName, email, password) VALUES (@UserName, @Email, @Password)";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@UserName", entredUserName);
                        command.Parameters.AddWithValue("@Email", entredEmail);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                }
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }

        }

        static bool isValidEmail(string email, string pattern)
        {
            return Regex.IsMatch(email, pattern);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            addAdmin addAdmin = new addAdmin();
            addAdmin.Close();
        }
    }
}
