namespace File_Monitor
{
    public class Dados
    {
        private static bool enableMonitor;
        private static bool enableSort;

        private static int btnId;
        private static int flagCalibration;
        private static int etaDays;
        private static int etaHours;
        private static int etaMinutes;
        private static int etaSeconds;

        private static string waitNextNotice;
        private static string pathFile;
        private static string fileName;
        private static string lastAccess;
        private static string timeNow;
        private static string nick;

        public static bool EnableMonitor
        {
            get { return enableMonitor; }
            set { enableMonitor = value; }
        }
        public static bool EnableSort
        {
            get { return enableSort; }
            set { enableSort = value; }
        }
        public static int BtnId
        {
            get { return btnId; }
            set { btnId = value; }
        }
        public static int FlagCalibration
        {
            get { return flagCalibration; }
            set { flagCalibration = value; }
        }
        public static int EtaDays
        {
            get { return etaDays; }
            set { etaDays = value; }
        }
        public static int EtaHours
        {
            get { return etaHours; }
            set { etaHours = value; }
        }
        public static int EtaMinutes
        {
            get { return etaMinutes; }
            set { etaMinutes = value; }
        }
        public static int EtaSeconds
        {
            get { return etaSeconds; }
            set { etaSeconds = value; }
        }
        public static string WaitNextNotice
        {
            get { return waitNextNotice; }
            set { waitNextNotice = value; }
        }
        public static string PathFile
        {
            get { return pathFile; }
            set { pathFile = value; }
        }
        public static string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public static string LastAccess
        {
            get { return lastAccess; }
            set { lastAccess = value; }
        }
        public static string TimeNow
        {
            get { return timeNow; }
            set { timeNow = value; }
        }
        public static string Nick
        {
            get { return nick; }
            set { nick = value; }
        }
    }
}
