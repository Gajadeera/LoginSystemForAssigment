using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class addPlayer : Form
    {
        private const string ConnectionString = "Server=GAJADEERA\\SQLEXPRESS;Database=LoginSystem;Integrated Security=True;";
        byte[] imageData = null;

        public addPlayer()
        {
            InitializeComponent();
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO player (fullName, birthDay, battingStyle, bowlingStyle, playingRole, gender, runs, wickets,profilePicture) " +
                             "VALUES (@fullName, @birthDay, @battingStyle, @bowlingStyle, @playingRole, @gender, @runs, @wickets,@imageData);";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
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

                    MessageBox.Show("player added Sucessfully");
                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"; 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = new Bitmap(openFileDialog.FileName);
                    imageData = ImageToByteArray(img); 
                }
            }

        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat); 
                return ms.ToArray();
            }
        }

    }
}
