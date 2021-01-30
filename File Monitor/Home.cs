using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace File_Monitor
{
    public partial class Home : Form
    {
        // Global Variable                        
        DialogResult dialog = new DialogResult();
        
        public Home()
        {
            InitializeComponent();

            VariableInitial();

            if (FileExist(Properties.Settings.Default.FilePath))
            {
                txt_path.Text = Dados.PathFile = Properties.Settings.Default.FilePath;
                txt_path.Enabled = false;
                Dados.EnableMonitor = true;
                WindowState = FormWindowState.Minimized;
            }
            else
                txt_path.Enabled = false;
        }

        // Initial values
        private void VariableInitial()
        {
            if (Properties.Settings.Default.LastBluetooth.Length <= 0)
                Properties.Settings.Default.LastBluetooth = DateTime.Now.ToString();
            if (Properties.Settings.Default.LastWifi.Length <= 0)
                Properties.Settings.Default.LastWifi = DateTime.Now.ToString();
            if (Properties.Settings.Default.LastAccess.Length <= 0)
                Properties.Settings.Default.LastBluetooth = DateTime.Now.ToString();

            if (Properties.Settings.Default.LimitBluetooth.Length <= 0)
                Properties.Settings.Default.LimitBluetooth = DateTime.Now.ToString();
            if (Properties.Settings.Default.LimitWifi.Length <= 0)
                Properties.Settings.Default.LimitWifi = DateTime.Now.ToString();
            if (Properties.Settings.Default.LimitAccess.Length <= 0)
                Properties.Settings.Default.LimitBluetooth = DateTime.Now.ToString();

            Properties.Settings.Default.Save();

            Dados.WaitNextNotice = DateTime.Now.ToString();
            Dados.EnableSort = Properties.Settings.Default.LastFlag;
        }

        // Find model from line
        private int TakeLine(string path)
        {
            int flag = 0;
            string[] lines = path.Split(new char[] {':', '\\' });

            if (lines.Contains("F273"))
                flag = 1;

            if (lines.Contains("F277"))
                flag = 2;

            return flag;
        }

        // Function take information
        private void TakeInfo(string path, bool switched)
        {
            string pathAux = null;

            if (switched)
                pathAux = path;
            else
                pathAux = Properties.Settings.Default.FilePath;

            FileInfo info = new FileInfo(pathAux);

            Properties.Settings.Default.FilePath = Dados.PathFile = txt_path.Text = pathAux;
            Properties.Settings.Default.FileName = Dados.FileName = info.Name;
            Properties.Settings.Default.LastAccess = Dados.LastAccess = "" + info.LastAccessTime;
            Properties.Settings.Default.Save();
        }

        // Function check file exist
        private bool FileExist(string path)
        {
            if (File.Exists(path) == true)
            {
                TakeInfo(path, true);
                Dados.EnableMonitor = true;
                return true;
            }
            else
            {
                Dados.EnableMonitor = false;
                return false;
            }
        }

        // Save path 
        private bool SavePath()
        {
            txt_path.Clear();
            txt_path.Enabled = true;

            // Take the path from dialog 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecionar Arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dialog = MessageBox.Show("Você tem certeza do arquivo selecionado?", "Selecionar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    // Store data
                    Dados.PathFile = openFileDialog.FileName;
                    if (FileExist(Dados.PathFile))
                    {
                        TakeInfo(Dados.PathFile, true);
                        txt_path.Enabled = false;
                        WindowState = FormWindowState.Minimized;
                    }
                    else
                    {
                        Dados.EnableMonitor = false;
                        dialog = MessageBox.Show("O caminho selecionado não foi encontrado, certifique-se do caminho e tente novamente. ", "Selecionar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    }
                }
            }

            return Dados.EnableMonitor;
        }

        // Button to search path
        private void btn_search_Click(object sender, EventArgs e)
        {
            SavePath();
        }

        // Icon notify run in background
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        // Loop to monitor data
        private void timer_Tick(object sender, EventArgs e)
        {
            // Program Run...            
            if (FileExist(Dados.PathFile) && TakeLine(Dados.PathFile) > 0)
            {
                string dateCalibrationAux = "";

                switch (nextCalibrationId())
                {
                    case 1:
                        dateCalibrationAux = Properties.Settings.Default.LimitBluetooth;
                        Dados.Nick = "Bluetooth";
                        break;
                    case 2:
                        dateCalibrationAux = Properties.Settings.Default.LimitWifi;
                        Dados.Nick = "Wifi";
                        break;
                    case 3:
                        dateCalibrationAux = Properties.Settings.Default.LimitAccess;
                        Dados.Nick = "Bluetooth/Wifi";
                        break;
                }

                TimeSpan ts = dateResult(dateCalibrationAux, true);
                                
                // Display counterdown to calibration
                eta.Text = $"E.T.A: {ts.Days} Dia(s), {ts.Hours}:{ts.Minutes}:{ts.Seconds} para calibrar o {Dados.Nick}.";                

                // Open Alert to info calibration
                if (ts.Days <= 1 && Dados.EnableMonitor)
                {
                    if (dateResult(Dados.WaitNextNotice, true).Milliseconds <= 0)
                    {
                        AlertCalibration(dateCalibrationAux);
                    }
                }
                else
                {
                    ts = dateResult(Dados.LastAccess, false);

                    int segundos = (int)ts.TotalSeconds;

                    if (1 >= segundos)
                    {
                        if (Application.OpenForms.OfType<NoticeCalibration>().Count() <= 0)
                        {
                            var chooseForm = new ChooseCalibration();
                            chooseForm.ShowDialog();
                        }
                    }
                }

                // Save the last calibration time by id
                DateTime plusDate;

                switch (Dados.BtnId)
                {
                    case 1:
                        Dados.TimeNow = DateTime.Now.ToString();
                        Properties.Settings.Default.LastBluetooth = Dados.TimeNow;
                        plusDate = ParseDate(Dados.TimeNow);
                        Properties.Settings.Default.LimitBluetooth = plusDate.AddDays(7).ToString();
                        Properties.Settings.Default.Save();
                        Dados.BtnId = 0;
                        break;

                    case 2:
                        Dados.TimeNow = DateTime.Now.ToString();
                        Properties.Settings.Default.LastWifi = Dados.TimeNow;
                        plusDate = ParseDate(Dados.TimeNow);
                        Properties.Settings.Default.LimitWifi = plusDate.AddDays(7).ToString();
                        Properties.Settings.Default.Save();
                        Dados.BtnId = 0;
                        break;

                    case 3:
                        Dados.TimeNow = DateTime.Now.ToString();
                        Properties.Settings.Default.LastAccess = Dados.TimeNow;
                        plusDate = ParseDate(Dados.TimeNow);
                        Properties.Settings.Default.LimitAccess = plusDate.AddDays(7).ToString();
                        Properties.Settings.Default.Save();
                        Dados.BtnId = 0;
                        break;
                }
            }
            else
            {   // Alert application from lost file             
                if (Application.OpenForms.OfType<LostFile>().Count() <= 0)
                {
                    if (Dados.PathFile != " ")
                    {
                        txt_path.Clear();
                        eta.Text = "Não existe arquivo selecionado!";
                        var lostForm = new LostFile();
                        lostForm.ShowDialog();
                    }
                }
            }
        }

        // Converting string in DateTime
        private DateTime ParseDate(string dateString)
        {
            DateTime inicio = DateTime.Now;
            try
            {
                inicio = DateTime.Parse(dateString);
            }
            catch (FormatException)
            {

            }
            return inicio;
        }
        // Alert calibration
        private void AlertCalibration(string dateCalibrationAux)
        {
            if (Application.OpenForms.OfType<NoticeCalibration>().Count() <= 0)
            {
                TimeSpan ts = dateResult(dateCalibrationAux, true);

                Dados.EtaDays = ts.Days;
                Dados.EtaHours = ts.Hours;
                Dados.EtaMinutes = ts.Minutes;
                Dados.EtaSeconds = ts.Seconds;

                var noticeForm = new NoticeCalibration();
                noticeForm.ShowDialog();
            }
        }

        // Return the time in values
        private TimeSpan dateResult(string dateString, bool invert)
        {
            DateTime inicio = ParseDate(dateString);
           
            DateTime fim = DateTime.Now;
            TimeSpan ts;

            if (invert)
                ts = inicio.Subtract(fim);
            else
                ts = fim.Subtract(inicio);

            return ts;
        }

        // Send calibration from close time
        private int nextCalibrationId()
        {
            // Initializing
            int[] values = { 0, 0, 0 };
            string[] dates = { Properties.Settings.Default.LimitBluetooth, Properties.Settings.Default.LimitWifi, Properties.Settings.Default.LimitAccess };

            // Get values
            for (int i = 0; i < 3; i++)
            {
                TimeSpan ts = dateResult(dates[i], true);
                values[i] = (int)ts.TotalSeconds;
            }
            
            // Take Lines
            if (TakeLine(Dados.PathFile) == 1)
                // Return bluuetooth
                Dados.FlagCalibration = 1;

            else
            {   // Enable sort from calibration
                if (Dados.EnableSort)
                {
                    // Return bluetooth
                    if (values[0] < values[1])
                        Dados.FlagCalibration = 1;

                    // Return wifi
                    if (values[1] < values[0])
                        Dados.FlagCalibration = 2;
                }
                else
                    // Return wifi/calibration
                    Dados.FlagCalibration = 3;
            }

            Properties.Settings.Default.LastFlag = Dados.EnableSort;
            Properties.Settings.Default.Save();

            return Dados.FlagCalibration;
        }

        // Closing application
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileExist(Dados.PathFile))
            {
                dialog = MessageBox.Show("Você tem certeza que deseja fechar o programa? O monitoriamento ficará supenso!", "Parar Monitoriamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.No)                
                    e.Cancel = true;                
            }
        }

        // Start 
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (FileExist(Dados.PathFile))
            {
                var chooseForm = new ChooseCalibration();
                chooseForm.ShowDialog();
            }
            else
                messageInformation("Informar Calibração");
        }

        // Messages
        private void messageInformation(string title)
        {
            MessageBox.Show("Não foi selecioando nenhum arquivo, favor selecione um arquivo!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}