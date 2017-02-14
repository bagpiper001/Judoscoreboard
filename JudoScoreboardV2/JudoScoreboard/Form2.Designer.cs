namespace JudoScoreboard
{
    partial class publicScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(publicScreen));
            this.lblWazariRood = new System.Windows.Forms.Label();
            this.lblIpponRood = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblTimeSeperate = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblShidoRood = new System.Windows.Forms.Label();
            this.lblWazariWit = new System.Windows.Forms.Label();
            this.lblIpponWit = new System.Windows.Forms.Label();
            this.lblShidoWit = new System.Windows.Forms.Label();
            this.lblHoldingWit = new System.Windows.Forms.Label();
            this.lblHoldingRood = new System.Windows.Forms.Label();
            this.lblConfirmRood1 = new System.Windows.Forms.Label();
            this.lblConfirmRood2 = new System.Windows.Forms.Label();
            this.lblConfirmRood3 = new System.Windows.Forms.Label();
            this.lblConfirmWit1 = new System.Windows.Forms.Label();
            this.lblConfirmWit2 = new System.Windows.Forms.Label();
            this.lblConfirmWit3 = new System.Windows.Forms.Label();
            this.lblShidoTextWit = new System.Windows.Forms.Label();
            this.lblShidoTextRood = new System.Windows.Forms.Label();
            this.lblWazariTextWit = new System.Windows.Forms.Label();
            this.lblIpponTextWit = new System.Windows.Forms.Label();
            this.lblWazariTextRood = new System.Windows.Forms.Label();
            this.lblIpponTextRood = new System.Windows.Forms.Label();
            this.boxReclameImage = new System.Windows.Forms.PictureBox();
            this.reclameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boxReclameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWazariRood
            // 
            this.lblWazariRood.AutoSize = true;
            this.lblWazariRood.Location = new System.Drawing.Point(1173, 414);
            this.lblWazariRood.Name = "lblWazariRood";
            this.lblWazariRood.Size = new System.Drawing.Size(13, 13);
            this.lblWazariRood.TabIndex = 2;
            this.lblWazariRood.Text = "0";
            // 
            // lblIpponRood
            // 
            this.lblIpponRood.AutoSize = true;
            this.lblIpponRood.Location = new System.Drawing.Point(1363, 414);
            this.lblIpponRood.Name = "lblIpponRood";
            this.lblIpponRood.Size = new System.Drawing.Size(13, 13);
            this.lblIpponRood.TabIndex = 3;
            this.lblIpponRood.Text = "0";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(879, 826);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(19, 13);
            this.lblSec.TabIndex = 9;
            this.lblSec.Text = "00";
            // 
            // lblTimeSeperate
            // 
            this.lblTimeSeperate.AutoSize = true;
            this.lblTimeSeperate.Location = new System.Drawing.Point(825, 826);
            this.lblTimeSeperate.Name = "lblTimeSeperate";
            this.lblTimeSeperate.Size = new System.Drawing.Size(10, 13);
            this.lblTimeSeperate.TabIndex = 8;
            this.lblTimeSeperate.Text = ":";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(679, 826);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(19, 13);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "00";
            // 
            // lblShidoRood
            // 
            this.lblShidoRood.AutoSize = true;
            this.lblShidoRood.Location = new System.Drawing.Point(1363, 663);
            this.lblShidoRood.Name = "lblShidoRood";
            this.lblShidoRood.Size = new System.Drawing.Size(13, 13);
            this.lblShidoRood.TabIndex = 10;
            this.lblShidoRood.Text = "0";
            // 
            // lblWazariWit
            // 
            this.lblWazariWit.AutoSize = true;
            this.lblWazariWit.Location = new System.Drawing.Point(430, 414);
            this.lblWazariWit.Name = "lblWazariWit";
            this.lblWazariWit.Size = new System.Drawing.Size(13, 13);
            this.lblWazariWit.TabIndex = 11;
            this.lblWazariWit.Text = "0";
            // 
            // lblIpponWit
            // 
            this.lblIpponWit.AutoSize = true;
            this.lblIpponWit.Location = new System.Drawing.Point(631, 414);
            this.lblIpponWit.Name = "lblIpponWit";
            this.lblIpponWit.Size = new System.Drawing.Size(13, 13);
            this.lblIpponWit.TabIndex = 12;
            this.lblIpponWit.Text = "0";
            this.lblIpponWit.Click += new System.EventHandler(this.lblIpponWit_Click);
            // 
            // lblShidoWit
            // 
            this.lblShidoWit.AutoSize = true;
            this.lblShidoWit.Location = new System.Drawing.Point(226, 663);
            this.lblShidoWit.Name = "lblShidoWit";
            this.lblShidoWit.Size = new System.Drawing.Size(13, 13);
            this.lblShidoWit.TabIndex = 13;
            this.lblShidoWit.Text = "0";
            // 
            // lblHoldingWit
            // 
            this.lblHoldingWit.AutoSize = true;
            this.lblHoldingWit.Location = new System.Drawing.Point(644, 663);
            this.lblHoldingWit.Name = "lblHoldingWit";
            this.lblHoldingWit.Size = new System.Drawing.Size(13, 13);
            this.lblHoldingWit.TabIndex = 14;
            this.lblHoldingWit.Text = "0";
            // 
            // lblHoldingRood
            // 
            this.lblHoldingRood.AutoSize = true;
            this.lblHoldingRood.Location = new System.Drawing.Point(987, 663);
            this.lblHoldingRood.Name = "lblHoldingRood";
            this.lblHoldingRood.Size = new System.Drawing.Size(13, 13);
            this.lblHoldingRood.TabIndex = 15;
            this.lblHoldingRood.Text = "0";
            // 
            // lblConfirmRood1
            // 
            this.lblConfirmRood1.AutoSize = true;
            this.lblConfirmRood1.Location = new System.Drawing.Point(1063, 917);
            this.lblConfirmRood1.Name = "lblConfirmRood1";
            this.lblConfirmRood1.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmRood1.TabIndex = 16;
            this.lblConfirmRood1.Text = "0";
            // 
            // lblConfirmRood2
            // 
            this.lblConfirmRood2.AutoSize = true;
            this.lblConfirmRood2.Location = new System.Drawing.Point(1219, 917);
            this.lblConfirmRood2.Name = "lblConfirmRood2";
            this.lblConfirmRood2.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmRood2.TabIndex = 17;
            this.lblConfirmRood2.Text = "0";
            // 
            // lblConfirmRood3
            // 
            this.lblConfirmRood3.AutoSize = true;
            this.lblConfirmRood3.Location = new System.Drawing.Point(1363, 917);
            this.lblConfirmRood3.Name = "lblConfirmRood3";
            this.lblConfirmRood3.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmRood3.TabIndex = 18;
            this.lblConfirmRood3.Text = "0";
            // 
            // lblConfirmWit1
            // 
            this.lblConfirmWit1.AutoSize = true;
            this.lblConfirmWit1.Location = new System.Drawing.Point(228, 917);
            this.lblConfirmWit1.Name = "lblConfirmWit1";
            this.lblConfirmWit1.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmWit1.TabIndex = 19;
            this.lblConfirmWit1.Text = "0";
            // 
            // lblConfirmWit2
            // 
            this.lblConfirmWit2.AutoSize = true;
            this.lblConfirmWit2.Location = new System.Drawing.Point(344, 917);
            this.lblConfirmWit2.Name = "lblConfirmWit2";
            this.lblConfirmWit2.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmWit2.TabIndex = 20;
            this.lblConfirmWit2.Text = "0";
            // 
            // lblConfirmWit3
            // 
            this.lblConfirmWit3.AutoSize = true;
            this.lblConfirmWit3.Location = new System.Drawing.Point(490, 917);
            this.lblConfirmWit3.Name = "lblConfirmWit3";
            this.lblConfirmWit3.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmWit3.TabIndex = 21;
            this.lblConfirmWit3.Text = "0";
            // 
            // lblShidoTextWit
            // 
            this.lblShidoTextWit.AutoSize = true;
            this.lblShidoTextWit.Location = new System.Drawing.Point(226, 587);
            this.lblShidoTextWit.Name = "lblShidoTextWit";
            this.lblShidoTextWit.Size = new System.Drawing.Size(34, 13);
            this.lblShidoTextWit.TabIndex = 44;
            this.lblShidoTextWit.Text = "Shido";
            // 
            // lblShidoTextRood
            // 
            this.lblShidoTextRood.AutoSize = true;
            this.lblShidoTextRood.Location = new System.Drawing.Point(1363, 587);
            this.lblShidoTextRood.Name = "lblShidoTextRood";
            this.lblShidoTextRood.Size = new System.Drawing.Size(34, 13);
            this.lblShidoTextRood.TabIndex = 45;
            this.lblShidoTextRood.Text = "Shido";
            // 
            // lblWazariTextWit
            // 
            this.lblWazariTextWit.AutoSize = true;
            this.lblWazariTextWit.Location = new System.Drawing.Point(421, 332);
            this.lblWazariTextWit.Name = "lblWazariTextWit";
            this.lblWazariTextWit.Size = new System.Drawing.Size(40, 13);
            this.lblWazariTextWit.TabIndex = 47;
            this.lblWazariTextWit.Text = "Wazari";
            // 
            // lblIpponTextWit
            // 
            this.lblIpponTextWit.AutoSize = true;
            this.lblIpponTextWit.Location = new System.Drawing.Point(631, 332);
            this.lblIpponTextWit.Name = "lblIpponTextWit";
            this.lblIpponTextWit.Size = new System.Drawing.Size(34, 13);
            this.lblIpponTextWit.TabIndex = 48;
            this.lblIpponTextWit.Text = "Ippon";
            // 
            // lblWazariTextRood
            // 
            this.lblWazariTextRood.AutoSize = true;
            this.lblWazariTextRood.Location = new System.Drawing.Point(1164, 332);
            this.lblWazariTextRood.Name = "lblWazariTextRood";
            this.lblWazariTextRood.Size = new System.Drawing.Size(40, 13);
            this.lblWazariTextRood.TabIndex = 50;
            this.lblWazariTextRood.Text = "Wazari";
            // 
            // lblIpponTextRood
            // 
            this.lblIpponTextRood.AutoSize = true;
            this.lblIpponTextRood.Location = new System.Drawing.Point(1363, 332);
            this.lblIpponTextRood.Name = "lblIpponTextRood";
            this.lblIpponTextRood.Size = new System.Drawing.Size(34, 13);
            this.lblIpponTextRood.TabIndex = 51;
            this.lblIpponTextRood.Text = "Ippon";
            // 
            // boxReclameImage
            // 
            this.boxReclameImage.Location = new System.Drawing.Point(613, 12);
            this.boxReclameImage.Name = "boxReclameImage";
            this.boxReclameImage.Size = new System.Drawing.Size(503, 303);
            this.boxReclameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxReclameImage.TabIndex = 52;
            this.boxReclameImage.TabStop = false;
            // 
            // reclameTimer
            // 
            this.reclameTimer.Enabled = true;
            this.reclameTimer.Interval = 5000;
            this.reclameTimer.Tick += new System.EventHandler(this.reclameTimer_Tick);
            // 
            // publicScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 874);
            this.Controls.Add(this.boxReclameImage);
            this.Controls.Add(this.lblIpponTextRood);
            this.Controls.Add(this.lblWazariTextRood);
            this.Controls.Add(this.lblIpponTextWit);
            this.Controls.Add(this.lblWazariTextWit);
            this.Controls.Add(this.lblShidoTextRood);
            this.Controls.Add(this.lblShidoTextWit);
            this.Controls.Add(this.lblConfirmWit3);
            this.Controls.Add(this.lblConfirmWit2);
            this.Controls.Add(this.lblConfirmWit1);
            this.Controls.Add(this.lblConfirmRood3);
            this.Controls.Add(this.lblConfirmRood2);
            this.Controls.Add(this.lblConfirmRood1);
            this.Controls.Add(this.lblHoldingRood);
            this.Controls.Add(this.lblHoldingWit);
            this.Controls.Add(this.lblShidoWit);
            this.Controls.Add(this.lblIpponWit);
            this.Controls.Add(this.lblWazariWit);
            this.Controls.Add(this.lblShidoRood);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblTimeSeperate);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblIpponRood);
            this.Controls.Add(this.lblWazariRood);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "publicScreen";
            this.Text = "Judoscoreboard";
            this.Load += new System.EventHandler(this.publicScreen_Load);
            this.Resize += new System.EventHandler(this.publicScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.boxReclameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblWazariRood;
        public System.Windows.Forms.Label lblIpponRood;
        public System.Windows.Forms.Label lblSec;
        public System.Windows.Forms.Label lblTimeSeperate;
        public System.Windows.Forms.Label lblMin;
        public System.Windows.Forms.Label lblShidoRood;
        public System.Windows.Forms.Label lblWazariWit;
        public System.Windows.Forms.Label lblIpponWit;
        public System.Windows.Forms.Label lblShidoWit;
        public System.Windows.Forms.Label lblHoldingWit;
        public System.Windows.Forms.Label lblHoldingRood;
        public System.Windows.Forms.Label lblConfirmRood1;
        public System.Windows.Forms.Label lblConfirmRood2;
        public System.Windows.Forms.Label lblConfirmRood3;
        public System.Windows.Forms.Label lblConfirmWit1;
        public System.Windows.Forms.Label lblConfirmWit2;
        public System.Windows.Forms.Label lblConfirmWit3;
        public System.Windows.Forms.Label lblShidoTextWit;
        public System.Windows.Forms.Label lblShidoTextRood;
        public System.Windows.Forms.Label lblWazariTextWit;
        public System.Windows.Forms.Label lblIpponTextWit;
        public System.Windows.Forms.Label lblWazariTextRood;
        public System.Windows.Forms.Label lblIpponTextRood;
        private System.Windows.Forms.PictureBox boxReclameImage;
        private System.Windows.Forms.Timer reclameTimer;
    }
}