
namespace File_Monitor
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.eta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(358, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 28);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(8, 10);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(344, 21);
            this.txt_path.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(9, 51);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(425, 39);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Informar Calibração";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "File Monitor";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // eta
            // 
            this.eta.AutoSize = true;
            this.eta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eta.Location = new System.Drawing.Point(5, 111);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(398, 22);
            this.eta.TabIndex = 3;
            this.eta.Text = "E.T.A: 6 Dias, 23:49:33 para próxima calibração.";
            this.eta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 151);
            this.Controls.Add(this.eta);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label eta;
    }
}

