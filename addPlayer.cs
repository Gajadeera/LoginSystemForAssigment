using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login
{
    public partial class addPlayer : Form
    {
        private const string ConnectionString = "Server=GAJADEERA\\SQLEXPRESS;Database=LoginSystem;Integrated Security=True;";

        public addPlayer()
        {
            InitializeComponent();
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            string entredUserName = txtUsername.Text;
            string entredEmail = txtEmail.Text;
            string entredPassword = txtPassword.Text;
            string entredReTypePassword = txtReTypePassword.Text;
            string entredGender = txtGender.Text;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (isValidEmail(entredEmail, emailPattern))
            {
                if (entredPassword == entredReTypePassword)
                {
<<<<<<< Updated upstream
                    using (SqlConnection connection = new SqlConnection(ConnectionString)) ;

                    string hashedPassword = HashPassword(entredPassword);

                    const string insertQuery = "INSERT INTO Players (userName, email, password,gender) VALUES (@UserName, @Email, @Password,@Gender)";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@UserName", entredUserName);
                        command.Parameters.AddWithValue("@Email", entredEmail);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@ReTypePassword", entredReTypePassword);
                        command.Parameters.AddWithValue("@Gender", entredGender);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
=======
                    command.Parameters.AddWithValue("@fullName", txtFullName.Text);
                    command.Parameters.AddWithValue("@birthDay", DateTime.Parse(txtBirthDay.Text));
                    command.Parameters.AddWithValue("@battingStyle", txtBattingStyle.Text);
                    command.Parameters.AddWithValue("@bowlingStyle", txtBowlingStyle.Text);
                    command.Parameters.AddWithValue("@playingRole", txtPlayingRole.Text);
                    command.Parameters.AddWithValue("@gender", txtGender.Text);
                    command.Parameters.AddWithValue("@runs", int.Parse(txtRuns.Text));
                    command.Parameters.AddWithValue("@wickets", int.Parse(txtWickets.Text));
                    command.Parameters.AddWithValue("@imageData", imageData);
                    command.ExecuteNonQuery();
>>>>>>> Stashed changes

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

    }
}
