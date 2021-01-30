
namespace File_Monitor
{
    partial class LostFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LostFile));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Lost_Comfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "O arquivo monitorado não foi encontrado,\r\nselecione um aquivo para monitoriamento" +
    ".";
            // 
            // btn_Lost_Comfirm
            // 
            this.btn_Lost_Comfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lost_Comfirm.Location = new System.Drawing.Point(92, 60);
            this.btn_Lost_Comfirm.Name = "btn_Lost_Comfirm";
            this.btn_Lost_Comfirm.Size = new System.Drawing.Size(109, 33);
            this.btn_Lost_Comfirm.TabIndex = 1;
            this.btn_Lost_Comfirm.Text = "Confirmar";
            this.btn_Lost_Comfirm.UseVisualStyleBackColor = true;
            this.btn_Lost_Comfirm.Click += new System.EventHandler(this.btn_Lost_Comfirm_Click);
            // 
            // LostFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 105);
            this.Controls.Add(this.btn_Lost_Comfirm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LostFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Lost File";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lost_Comfirm;
    }
}