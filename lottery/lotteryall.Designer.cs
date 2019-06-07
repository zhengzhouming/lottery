namespace lottery
{
    partial class lotteryall
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
            this.labuID = new System.Windows.Forms.Label();
            this.labuname = new System.Windows.Forms.Label();
            this.labuno = new System.Windows.Forms.Label();
            this.labudept = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labuID
            // 
            this.labuID.BackColor = System.Drawing.Color.Black;
            this.labuID.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labuID.ForeColor = System.Drawing.Color.Yellow;
            this.labuID.Location = new System.Drawing.Point(0, 0);
            this.labuID.Name = "labuID";
            this.labuID.Size = new System.Drawing.Size(725, 446);
            this.labuID.TabIndex = 0;
            this.labuID.Text = "uID";
            this.labuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labuname
            // 
            this.labuname.BackColor = System.Drawing.Color.Black;
            this.labuname.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labuname.ForeColor = System.Drawing.Color.Yellow;
            this.labuname.Location = new System.Drawing.Point(0, 446);
            this.labuname.Name = "labuname";
            this.labuname.Size = new System.Drawing.Size(225, 92);
            this.labuname.TabIndex = 1;
            this.labuname.Text = "uname";
            this.labuname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labuno
            // 
            this.labuno.BackColor = System.Drawing.Color.Black;
            this.labuno.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold);
            this.labuno.ForeColor = System.Drawing.Color.Yellow;
            this.labuno.Location = new System.Drawing.Point(221, 446);
            this.labuno.Name = "labuno";
            this.labuno.Size = new System.Drawing.Size(273, 92);
            this.labuno.TabIndex = 2;
            this.labuno.Text = "uno";
            this.labuno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labudept
            // 
            this.labudept.BackColor = System.Drawing.Color.Black;
            this.labudept.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold);
            this.labudept.ForeColor = System.Drawing.Color.Yellow;
            this.labudept.Location = new System.Drawing.Point(500, 446);
            this.labudept.Name = "labudept";
            this.labudept.Size = new System.Drawing.Size(225, 92);
            this.labudept.TabIndex = 3;
            this.labudept.Text = "udept";
            this.labudept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lotteryall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(726, 537);
            this.Controls.Add(this.labudept);
            this.Controls.Add(this.labuno);
            this.Controls.Add(this.labuname);
            this.Controls.Add(this.labuID);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lotteryall";
            this.Text = "lotteryall";
            this.Load += new System.EventHandler(this.lotteryall_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labuID;
        private System.Windows.Forms.Label labuname;
        private System.Windows.Forms.Label labuno;
        private System.Windows.Forms.Label labudept;
    }
}