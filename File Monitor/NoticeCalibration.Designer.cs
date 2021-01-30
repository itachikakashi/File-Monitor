
namespace File_Monitor
{
    partial class NoticeCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeCalibration));
            this.noticeLabel = new System.Windows.Forms.Label();
            this.btnAdiar = new System.Windows.Forms.Button();
            this.btnInformar = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.subNoticeLabel = new System.Windows.Forms.Label();
            this.thanksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noticeLabel
            // 
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(12, 92);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(955, 43);
            this.noticeLabel.TabIndex = 0;
            this.noticeLabel.Text = "Faltam 27 minutos para realizar a calibração do Bluetooth/Wifi nessa estação.";
            // 
            // btnAdiar
            // 
            this.btnAdiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiar.Location = new System.Drawing.Point(705, 273);
            this.btnAdiar.Name = "btnAdiar";
            this.btnAdiar.Size = new System.Drawing.Size(198, 67);
            this.btnAdiar.TabIndex = 1;
            this.btnAdiar.Text = "Fechar Notificação";
            this.btnAdiar.UseVisualStyleBackColor = false;
            this.btnAdiar.Click += new System.EventHandler(this.btnAdiar_Click);
            // 
            // btnInformar
            // 
            this.btnInformar.BackColor = System.Drawing.Color.Lime;
            this.btnInformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformar.Location = new System.Drawing.Point(70, 273);
            this.btnInformar.Name = "btnInformar";
            this.btnInformar.Size = new System.Drawing.Size(198, 67);
            this.btnInformar.TabIndex = 1;
            this.btnInformar.Text = "Informar Calibração";
            this.btnInformar.UseVisualStyleBackColor = false;
            this.btnInformar.Click += new System.EventHandler(this.btnInformar_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.Location = new System.Drawing.Point(414, 35);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(122, 31);
            this.warningLabel.TabIndex = 0;
            this.warningLabel.Text = "Atenção!";
            // 
            // subNoticeLabel
            // 
            this.subNoticeLabel.AutoSize = true;
            this.subNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNoticeLabel.Location = new System.Drawing.Point(160, 139);
            this.subNoticeLabel.Name = "subNoticeLabel";
            this.subNoticeLabel.Size = new System.Drawing.Size(679, 31);
            this.subNoticeLabel.TabIndex = 0;
            this.subNoticeLabel.Text = "Alerte para Engenharia de Teste o mais breve possível.";
            // 
            // thanksLabel
            // 
            this.thanksLabel.AutoSize = true;
            this.thanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksLabel.Location = new System.Drawing.Point(404, 195);
            this.thanksLabel.Name = "thanksLabel";
            this.thanksLabel.Size = new System.Drawing.Size(133, 31);
            this.thanksLabel.TabIndex = 0;
            this.thanksLabel.Text = "Obrigado!";
            // 
            // NoticeCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(976, 402);
            this.Controls.Add(this.btnInformar);
            this.Controls.Add(this.btnAdiar);
            this.Controls.Add(this.thanksLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.subNoticeLabel);
            this.Controls.Add(this.noticeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoticeCalibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoticeCalibration_FormClosing);
            this.Load += new System.EventHandler(this.NoticeCalibration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Button btnAdiar;
        private System.Windows.Forms.Button btnInformar;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label subNoticeLabel;
        private System.Windows.Forms.Label thanksLabel;
    }
}