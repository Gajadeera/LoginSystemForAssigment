using System;
using System.Threading;
using System.Windows.Forms;

namespace Login
{
    public partial class Home : Form
    {
        private Mutex mutex = new Mutex();

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

            addPlayer addPlayer = new addPlayer();
            addPlayer.FormClosed += (s, args) => mutex.ReleaseMutex();
            addPlayer.ShowDialog();
        }
    }
}
