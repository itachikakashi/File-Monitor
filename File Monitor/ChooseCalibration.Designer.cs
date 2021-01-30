
namespace File_Monitor
{
    partial class ChooseCalibration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCalibration));
            this.bluetoothWifi = new System.Windows.Forms.Button();
            this.wifi = new System.Windows.Forms.Button();
            this.bluetooth = new System.Windows.Forms.Button();
            this.Aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bluetoothWifi
            // 
            this.bluetoothWifi.Location = new System.Drawing.Point(302, 85);
            this.bluetoothWifi.Name = "bluetoothWifi";
            this.bluetoothWifi.Size = new System.Drawing.Size(127, 33);
            this.bluetoothWifi.TabIndex = 0;
            this.bluetoothWifi.Text = "Bluetooth/Wifi";
            this.bluetoothWifi.UseVisualStyleBackColor = true;
            this.bluetoothWifi.Click += new System.EventHandler(this.bluetoothWifi_Click);
            // 
            // wifi
            // 
            this.wifi.Location = new System.Drawing.Point(161, 85);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(127, 33);
            this.wifi.TabIndex = 0;
            this.wifi.Text = "Wifi";
            this.wifi.UseVisualStyleBackColor = true;
            this.wifi.Click += new System.EventHandler(this.wifi_Click);
            // 
            // bluetooth
            // 
            this.bluetooth.Location = new System.Drawing.Point(20, 85);
            this.bluetooth.Name = "bluetooth";
            this.bluetooth.Size = new System.Drawing.Size(127, 33);
            this.bluetooth.TabIndex = 0;
            this.bluetooth.Text = "Bluetooth";
            this.bluetooth.UseVisualStyleBackColor = true;
            this.bluetooth.Click += new System.EventHandler(this.bluetooth_Click);
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.Location = new System.Drawing.Point(18, 18);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(420, 40);
            this.Aviso.TabIndex = 1;
            this.Aviso.Text = "O arquivo monitorado foi modificado, informe que tipo \r\nde calibração foi feita c" +
    "licando em um dos botões a seguir:";
            this.Aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 136);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.bluetooth);
            this.Controls.Add(this.wifi);
            this.Controls.Add(this.bluetoothWifi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseCalibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Calibration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseCalibration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bluetoothWifi;
        private System.Windows.Forms.Button wifi;
        private System.Windows.Forms.Button bluetooth;
        private System.Windows.Forms.Label Aviso;
    }
}