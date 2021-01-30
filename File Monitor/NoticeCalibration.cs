using System;
using System.Drawing;
using System.Windows.Forms;

namespace File_Monitor
{
    public partial class NoticeCalibration : Form
    {
        // Flag 
        private bool enableClose = false;

        public NoticeCalibration()
        {
            InitializeComponent();
        }

        // Load calibration alert
        private void NoticeCalibration_Load(object sender, EventArgs e)
        {   // Alert hours to calibration
            if (Dados.EtaHours > 0)
            {
                messageAlert(Dados.EtaHours, "hora(s)", Dados.Nick);
            }
            else
            {   // Alert minutes to calibration
                if (Dados.EtaMinutes > 0)
                {
                    messageAlert(Dados.EtaMinutes, "minuto(s)", Dados.Nick);
                }
                else
                {   // Alert seconds to calibration
                    if (Dados.EtaSeconds > 0)
                    {
                        messageAlert(Dados.EtaSeconds, "segundo(s)", Dados.Nick);
                    }
                    else
                    {   // Message from timout calibration
                        this.BackColor = Color.Red;
                        noticeLabel.Text = $"A calibração do {Dados.Nick} está atrasada!";
                        noticeLabel.TextAlign = ContentAlignment.MiddleCenter;
                        subNoticeLabel.Text = "";
                    }
                }
            }
        }

        // Display option to calibration
        private void btnInformar_Click(object sender, EventArgs e)
        {
            var choosedCalibration = new ChooseCalibration();
            choosedCalibration.ShowDialog();

            waitAlert(0);
        }

        // Delay alert
        private void btnAdiar_Click(object sender, EventArgs e)
        {
            waitAlert(30);
        }

        // Message function
        private void messageAlert(int time, string nickTime, string nick)
        {
            noticeLabel.Text = $"Faltam {time} {nickTime} para realizar calibração do {nick} nesta estação.";
            noticeLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        // Alert function
        private void waitAlert(int wait)
        {
            Dados.WaitNextNotice = DateTime.Now.ToString();
            DateTime plusDate = DateTime.Parse(Dados.WaitNextNotice);
            Dados.WaitNextNotice = plusDate.AddMinutes(wait).ToString();
            enableClose = true;
            Close();
        }

        // Close application
        private void NoticeCalibration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enableClose)
                e.Cancel = false;
            else
            {
                MessageBox.Show("Você não poderá fechar a aplicação sem antes escolher uma das opções apresentadas nela!", "Notice Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
