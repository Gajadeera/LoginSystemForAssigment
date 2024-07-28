using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class playerInformation : Form
    {
        public playerInformation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fullName = txtinputName.Text;

            const string ConnectionString = "Server=GAJADEERA\\SQLEXPRESS;Database=LoginSystem;Integrated Security=True;";

            string searchQuery = "SELECT fullName, birthDay, battingStyle, bowlingStyle, playingRole, gender, runs, wickets, profilePicture FROM player WHERE fullName = @fullName";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@fullName", fullName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve the profile picture
                    if (reader["profilePicture"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["profilePicture"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            profilePicture.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Handle the case where no image is found
                        profilePicture.Image = null; // Clear the picture box
                    }

                    // Retrieve and display other columns
                    txtFullName.Text = reader["fullName"].ToString();
                    txtBirthDay.Text = reader["birthDay"].ToString();
                    txtBattingStyle.Text = reader["battingStyle"].ToString();
                    txtBowlingStyle.Text = reader["bowlingStyle"].ToString();
                    txtPlayingRole.Text = reader["playingRole"].ToString();
                    txtGender.Text = reader["gender"].ToString();
                    txtRuns.Text = reader["runs"].ToString();
                    txtWickets.Text = reader["wickets"].ToString();
                }
                else
                {
                    // Handle the case where no data is found
                    MessageBox.Show("No player found with the specified name.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    profilePicture.Image = null; // Clear the picture box
                    txtFullName.Clear();
                    txtBirthDay.Clear();
                    txtBattingStyle.Clear();
                    txtBowlingStyle.Clear();
                    txtPlayingRole.Clear();
                    txtGender.Clear();
                    txtRuns.Clear();
                    txtWickets.Clear();
                }
                reader.Close();
            }
        }
    }
}
