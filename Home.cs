using System;
using System.Threading;
using System.Windows.Forms;

namespace Login
{
    public partial class Home : Form
    {
        private static readonly Mutex mutex = new Mutex();

        public Home()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenAddPlayerForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAddPlayerForm()
        {
            mutex.WaitOne();
            try
            {
                addPlayer addPlayerForm = new addPlayer();
                addPlayerForm.FormClosed += (s, args) => mutex.ReleaseMutex();
                addPlayerForm.ShowDialog();
            }
            catch
            {
                mutex.ReleaseMutex();
            }
        }

        private void OpenAddPlayerInformationForm()
        {
            mutex.WaitOne();
            try
            {
                playerInformation playerInformationForm = new playerInformation();
                playerInformationForm.FormClosed += (s, args) => mutex.ReleaseMutex();
                playerInformationForm.ShowDialog();
            }
            catch
            {
                mutex.ReleaseMutex();
            }
        }

        private void btnPlyerInformation_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenAddPlayerInformationForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
