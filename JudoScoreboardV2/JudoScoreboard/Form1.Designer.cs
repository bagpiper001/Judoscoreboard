namespace JudoScoreboard
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.lblYukoRood = new System.Windows.Forms.Label();
            this.lblYukoWit = new System.Windows.Forms.Label();
            this.lblWazariRood = new System.Windows.Forms.Label();
            this.lblIpponRood = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblTimeSeperate = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblShidoRood = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbSec = new System.Windows.Forms.TextBox();
            this.btTime = new System.Windows.Forms.Button();
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.lblWazariWit = new System.Windows.Forms.Label();
            this.lblIpponWit = new System.Windows.Forms.Label();
            this.lblShidoWit = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.tmrHolding = new System.Windows.Forms.Timer(this.components);
            this.lblHoldingRood = new System.Windows.Forms.Label();
            this.lblHoldingWit = new System.Windows.Forms.Label();
            this.lblconfirmRood1 = new System.Windows.Forms.Label();
            this.lblConfirmRood2 = new System.Windows.Forms.Label();
            this.lblConfirmRood3 = new System.Windows.Forms.Label();
            this.lblConfirmWit1 = new System.Windows.Forms.Label();
            this.lblConfirmWit2 = new System.Windows.Forms.Label();
            this.lblConfirmWit3 = new System.Windows.Forms.Label();
            this.tbYuko = new System.Windows.Forms.TextBox();
            this.tbWazari = new System.Windows.Forms.TextBox();
            this.tbIppon = new System.Windows.Forms.TextBox();
            this.btYukoRood = new System.Windows.Forms.Button();
            this.btWazariRood = new System.Windows.Forms.Button();
            this.btIpponRood = new System.Windows.Forms.Button();
            this.btYukoWit = new System.Windows.Forms.Button();
            this.btWazariWit = new System.Windows.Forms.Button();
            this.btIpponWit = new System.Windows.Forms.Button();
            this.btShidoWit = new System.Windows.Forms.Button();
            this.btShidoRood = new System.Windows.Forms.Button();
            this.btChangeHolding = new System.Windows.Forms.Button();
            this.lblIpponTextRood = new System.Windows.Forms.Label();
            this.lblIpponTextWit = new System.Windows.Forms.Label();
            this.lblWazariTextWit = new System.Windows.Forms.Label();
            this.lblWazariTextRood = new System.Windows.Forms.Label();
            this.lblYukoTextWit = new System.Windows.Forms.Label();
            this.lblYukoTextRood = new System.Windows.Forms.Label();
            this.lblShidoTextRood = new System.Windows.Forms.Label();
            this.lblShidoTextWit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYukoRood
            // 
            this.lblYukoRood.AutoSize = true;
            this.lblYukoRood.BackColor = System.Drawing.Color.FloralWhite;
            this.lblYukoRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYukoRood.Location = new System.Drawing.Point(111, 52);
            this.lblYukoRood.Name = "lblYukoRood";
            this.lblYukoRood.Size = new System.Drawing.Size(13, 13);
            this.lblYukoRood.TabIndex = 0;
            this.lblYukoRood.Text = "0";
            this.lblYukoRood.Click += new System.EventHandler(this.lblYukoRood_Click);
            // 
            // lblYukoWit
            // 
            this.lblYukoWit.AutoSize = true;
            this.lblYukoWit.Location = new System.Drawing.Point(913, 52);
            this.lblYukoWit.Name = "lblYukoWit";
            this.lblYukoWit.Size = new System.Drawing.Size(13, 13);
            this.lblYukoWit.TabIndex = 1;
            this.lblYukoWit.Text = "0";
            this.lblYukoWit.Click += new System.EventHandler(this.lblYukoWit_Click);
            // 
            // lblWazariRood
            // 
            this.lblWazariRood.AutoSize = true;
            this.lblWazariRood.BackColor = System.Drawing.Color.FloralWhite;
            this.lblWazariRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWazariRood.Location = new System.Drawing.Point(278, 52);
            this.lblWazariRood.Name = "lblWazariRood";
            this.lblWazariRood.Size = new System.Drawing.Size(13, 13);
            this.lblWazariRood.TabIndex = 2;
            this.lblWazariRood.Text = "0";
            this.lblWazariRood.Click += new System.EventHandler(this.lblWazariRood_Click);
            // 
            // lblIpponRood
            // 
            this.lblIpponRood.AutoSize = true;
            this.lblIpponRood.BackColor = System.Drawing.Color.FloralWhite;
            this.lblIpponRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpponRood.Location = new System.Drawing.Point(457, 52);
            this.lblIpponRood.Name = "lblIpponRood";
            this.lblIpponRood.Size = new System.Drawing.Size(13, 13);
            this.lblIpponRood.TabIndex = 3;
            this.lblIpponRood.Text = "0";
            this.lblIpponRood.Click += new System.EventHandler(this.lblIpponRood_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(424, 536);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(19, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "00";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lblTimeSeperate
            // 
            this.lblTimeSeperate.AutoSize = true;
            this.lblTimeSeperate.Location = new System.Drawing.Point(605, 536);
            this.lblTimeSeperate.Name = "lblTimeSeperate";
            this.lblTimeSeperate.Size = new System.Drawing.Size(10, 13);
            this.lblTimeSeperate.TabIndex = 5;
            this.lblTimeSeperate.Text = ":";
            this.lblTimeSeperate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(679, 536);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(19, 13);
            this.lblSec.TabIndex = 6;
            this.lblSec.Text = "00";
            this.lblSec.Click += new System.EventHandler(this.lblSec_Click);
            // 
            // lblShidoRood
            // 
            this.lblShidoRood.AutoSize = true;
            this.lblShidoRood.BackColor = System.Drawing.Color.FloralWhite;
            this.lblShidoRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShidoRood.Location = new System.Drawing.Point(111, 337);
            this.lblShidoRood.Name = "lblShidoRood";
            this.lblShidoRood.Size = new System.Drawing.Size(13, 13);
            this.lblShidoRood.TabIndex = 7;
            this.lblShidoRood.Text = "0";
            this.lblShidoRood.Click += new System.EventHandler(this.lblShidoRood_Click);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(612, 180);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 8;
            this.tbMin.Text = "2";
            // 
            // tbSec
            // 
            this.tbSec.Location = new System.Drawing.Point(612, 244);
            this.tbSec.Name = "tbSec";
            this.tbSec.Size = new System.Drawing.Size(100, 20);
            this.tbSec.TabIndex = 9;
            this.tbSec.Text = "0";
            // 
            // btTime
            // 
            this.btTime.Location = new System.Drawing.Point(612, 463);
            this.btTime.Name = "btTime";
            this.btTime.Size = new System.Drawing.Size(75, 23);
            this.btTime.TabIndex = 10;
            this.btTime.Text = "Nieuwe tijd";
            this.btTime.UseVisualStyleBackColor = true;
            this.btTime.Click += new System.EventHandler(this.btTime_Click);
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Location = new System.Drawing.Point(612, 87);
            this.cbTijd.Name = "cbTijd";
            this.cbTijd.Size = new System.Drawing.Size(70, 17);
            this.cbTijd.TabIndex = 11;
            this.cbTijd.Text = "Wijzig tijd";
            this.cbTijd.UseVisualStyleBackColor = true;
            this.cbTijd.CheckedChanged += new System.EventHandler(this.cbTijd_CheckedChanged);
            // 
            // lblWazariWit
            // 
            this.lblWazariWit.AutoSize = true;
            this.lblWazariWit.Location = new System.Drawing.Point(1121, 52);
            this.lblWazariWit.Name = "lblWazariWit";
            this.lblWazariWit.Size = new System.Drawing.Size(13, 13);
            this.lblWazariWit.TabIndex = 12;
            this.lblWazariWit.Text = "0";
            this.lblWazariWit.Click += new System.EventHandler(this.lblWazariWit_Click);
            // 
            // lblIpponWit
            // 
            this.lblIpponWit.AutoSize = true;
            this.lblIpponWit.Location = new System.Drawing.Point(1304, 52);
            this.lblIpponWit.Name = "lblIpponWit";
            this.lblIpponWit.Size = new System.Drawing.Size(13, 13);
            this.lblIpponWit.TabIndex = 13;
            this.lblIpponWit.Text = "0";
            this.lblIpponWit.Click += new System.EventHandler(this.lblIpponWit_Click);
            // 
            // lblShidoWit
            // 
            this.lblShidoWit.AutoSize = true;
            this.lblShidoWit.Location = new System.Drawing.Point(1304, 337);
            this.lblShidoWit.Name = "lblShidoWit";
            this.lblShidoWit.Size = new System.Drawing.Size(13, 13);
            this.lblShidoWit.TabIndex = 14;
            this.lblShidoWit.Text = "0";
            this.lblShidoWit.Click += new System.EventHandler(this.lblShidoWit_Click);
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(612, 42);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(75, 23);
            this.btRestart.TabIndex = 15;
            this.btRestart.Text = "Herstart";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // tmrHolding
            // 
            this.tmrHolding.Interval = 1000;
            this.tmrHolding.Tick += new System.EventHandler(this.tmrHolding_Tick);
            // 
            // lblHoldingRood
            // 
            this.lblHoldingRood.AutoSize = true;
            this.lblHoldingRood.BackColor = System.Drawing.Color.FloralWhite;
            this.lblHoldingRood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoldingRood.Location = new System.Drawing.Point(424, 444);
            this.lblHoldingRood.Name = "lblHoldingRood";
            this.lblHoldingRood.Size = new System.Drawing.Size(13, 13);
            this.lblHoldingRood.TabIndex = 16;
            this.lblHoldingRood.Text = "0";
            this.lblHoldingRood.Click += new System.EventHandler(this.lblHoldingRood_Click);
            // 
            // lblHoldingWit
            // 
            this.lblHoldingWit.AutoSize = true;
            this.lblHoldingWit.BackColor = System.Drawing.Color.FloralWhite;
            this.lblHoldingWit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoldingWit.Location = new System.Drawing.Point(891, 444);
            this.lblHoldingWit.Name = "lblHoldingWit";
            this.lblHoldingWit.Size = new System.Drawing.Size(13, 13);
            this.lblHoldingWit.TabIndex = 17;
            this.lblHoldingWit.Text = "0";
            this.lblHoldingWit.Click += new System.EventHandler(this.lblHoldingWit_Click);
            // 
            // lblconfirmRood1
            // 
            this.lblconfirmRood1.AutoSize = true;
            this.lblconfirmRood1.BackColor = System.Drawing.Color.FloralWhite;
            this.lblconfirmRood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmRood1.Location = new System.Drawing.Point(111, 636);
            this.lblconfirmRood1.Name = "lblconfirmRood1";
            this.lblconfirmRood1.Size = new System.Drawing.Size(13, 13);
            this.lblconfirmRood1.TabIndex = 18;
            this.lblconfirmRood1.Text = "0";
            this.lblconfirmRood1.Click += new System.EventHandler(this.lblconfirmRood1_Click);
            // 
            // lblConfirmRood2
            // 
            this.lblConfirmRood2.AutoSize = true;
            this.lblConfirmRood2.BackColor = System.Drawing.Color.FloralWhite;
            this.lblConfirmRood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmRood2.Location = new System.Drawing.Point(209, 636);
            this.lblConfirmRood2.Name = "lblConfirmRood2";
            this.lblConfirmRood2.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmRood2.TabIndex = 19;
            this.lblConfirmRood2.Text = "0";
            this.lblConfirmRood2.Click += new System.EventHandler(this.lblConfirmRood2_Click);
            // 
            // lblConfirmRood3
            // 
            this.lblConfirmRood3.AutoSize = true;
            this.lblConfirmRood3.BackColor = System.Drawing.Color.FloralWhite;
            this.lblConfirmRood3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmRood3.Location = new System.Drawing.Point(302, 636);
            this.lblConfirmRood3.Name = "lblConfirmRood3";
            this.lblConfirmRood3.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmRood3.TabIndex = 20;
            this.lblConfirmRood3.Text = "0";
            this.lblConfirmRood3.Click += new System.EventHandler(this.lblConfirmRood3_Click);
            // 
            // lblConfirmWit1
            // 
            this.lblConfirmWit1.AutoSize = true;
            this.lblConfirmWit1.BackColor = System.Drawing.Color.FloralWhite;
            this.lblConfirmWit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmWit1.Location = new System.Drawing.Point(891, 636);
            this.lblConfirmWit1.Name = "lblConfirmWit1";
            this.lblConfirmWit1.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmWit1.TabIndex = 21;
            this.lblConfirmWit1.Text = "0";
            this.lblConfirmWit1.Click += new System.EventHandler(this.lblConfirmWit1_Click);
            // 
            // lblConfirmWit2
            // 
            this.lblConfirmWit2.AutoSize = true;
            this.lblConfirmWit2.BackColor = System.Drawing.Color.FloralWhite;
            this.lblConfirmWit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmWit2.Location = new System.Drawing.Point(986, 636);
            this.lblConfirmWit2.Name = "lblConfirmWit2";
            this.lblConfirmWit2.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmWit2.TabIndex = 22;
            this.lblConfirmWit2.Text = "0";
            this.lblConfirmWit2.Click += new System.EventHandler(this.lblConfirmWit2_Click);
            // 
            // lblConfirmWit3
            // 
            this.lblConfirmWit3.AutoSize = true;
            this.lblConfirmWit3.BackColor = System.Drawing.Color.FloralWhite;
            this.lblConfirmWit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmWit3.Location = new System.Drawing.Point(1079, 636);
            this.lblConfirmWit3.Name = "lblConfirmWit3";
            this.lblConfirmWit3.Size = new System.Drawing.Size(13, 13);
            this.lblConfirmWit3.TabIndex = 23;
            this.lblConfirmWit3.Text = "0";
            this.lblConfirmWit3.Click += new System.EventHandler(this.lblConfirmWit3_Click);
            // 
            // tbYuko
            // 
            this.tbYuko.Location = new System.Drawing.Point(460, 299);
            this.tbYuko.Name = "tbYuko";
            this.tbYuko.Size = new System.Drawing.Size(100, 20);
            this.tbYuko.TabIndex = 24;
            this.tbYuko.Text = "10";
            // 
            // tbWazari
            // 
            this.tbWazari.Location = new System.Drawing.Point(612, 299);
            this.tbWazari.Name = "tbWazari";
            this.tbWazari.Size = new System.Drawing.Size(100, 20);
            this.tbWazari.TabIndex = 25;
            this.tbWazari.Text = "15";
            // 
            // tbIppon
            // 
            this.tbIppon.Location = new System.Drawing.Point(769, 298);
            this.tbIppon.Name = "tbIppon";
            this.tbIppon.Size = new System.Drawing.Size(100, 20);
            this.tbIppon.TabIndex = 26;
            this.tbIppon.Text = "20";
            // 
            // btYukoRood
            // 
            this.btYukoRood.Location = new System.Drawing.Point(114, 140);
            this.btYukoRood.Name = "btYukoRood";
            this.btYukoRood.Size = new System.Drawing.Size(75, 23);
            this.btYukoRood.TabIndex = 27;
            this.btYukoRood.Text = "Yuko teveel";
            this.btYukoRood.UseVisualStyleBackColor = true;
            this.btYukoRood.Click += new System.EventHandler(this.btYukoRood_Click);
            // 
            // btWazariRood
            // 
            this.btWazariRood.Location = new System.Drawing.Point(281, 140);
            this.btWazariRood.Name = "btWazariRood";
            this.btWazariRood.Size = new System.Drawing.Size(84, 23);
            this.btWazariRood.TabIndex = 28;
            this.btWazariRood.Text = "Wazari teveel";
            this.btWazariRood.UseVisualStyleBackColor = true;
            this.btWazariRood.Click += new System.EventHandler(this.btWazariRood_Click);
            // 
            // btIpponRood
            // 
            this.btIpponRood.Location = new System.Drawing.Point(460, 140);
            this.btIpponRood.Name = "btIpponRood";
            this.btIpponRood.Size = new System.Drawing.Size(75, 23);
            this.btIpponRood.TabIndex = 29;
            this.btIpponRood.Text = "Ippon teveel";
            this.btIpponRood.UseVisualStyleBackColor = true;
            this.btIpponRood.Click += new System.EventHandler(this.btIpponRood_Click);
            // 
            // btYukoWit
            // 
            this.btYukoWit.Location = new System.Drawing.Point(916, 140);
            this.btYukoWit.Name = "btYukoWit";
            this.btYukoWit.Size = new System.Drawing.Size(75, 23);
            this.btYukoWit.TabIndex = 30;
            this.btYukoWit.Text = "Yuko teveel";
            this.btYukoWit.UseVisualStyleBackColor = true;
            this.btYukoWit.Click += new System.EventHandler(this.btYukoWit_Click);
            // 
            // btWazariWit
            // 
            this.btWazariWit.Location = new System.Drawing.Point(1124, 140);
            this.btWazariWit.Name = "btWazariWit";
            this.btWazariWit.Size = new System.Drawing.Size(83, 23);
            this.btWazariWit.TabIndex = 31;
            this.btWazariWit.Text = "Wazari teveel";
            this.btWazariWit.UseVisualStyleBackColor = true;
            this.btWazariWit.Click += new System.EventHandler(this.btWazariWit_Click);
            // 
            // btIpponWit
            // 
            this.btIpponWit.Location = new System.Drawing.Point(1307, 140);
            this.btIpponWit.Name = "btIpponWit";
            this.btIpponWit.Size = new System.Drawing.Size(75, 23);
            this.btIpponWit.TabIndex = 32;
            this.btIpponWit.Text = "Ippon teveel";
            this.btIpponWit.UseVisualStyleBackColor = true;
            this.btIpponWit.Click += new System.EventHandler(this.btIpponWit_Click);
            // 
            // btShidoWit
            // 
            this.btShidoWit.Location = new System.Drawing.Point(1307, 421);
            this.btShidoWit.Name = "btShidoWit";
            this.btShidoWit.Size = new System.Drawing.Size(75, 23);
            this.btShidoWit.TabIndex = 33;
            this.btShidoWit.Text = "Shido teveel";
            this.btShidoWit.UseVisualStyleBackColor = true;
            this.btShidoWit.Click += new System.EventHandler(this.btShidoWit_Click);
            // 
            // btShidoRood
            // 
            this.btShidoRood.Location = new System.Drawing.Point(114, 421);
            this.btShidoRood.Name = "btShidoRood";
            this.btShidoRood.Size = new System.Drawing.Size(75, 23);
            this.btShidoRood.TabIndex = 34;
            this.btShidoRood.Text = "Shido teveel";
            this.btShidoRood.UseVisualStyleBackColor = true;
            this.btShidoRood.Click += new System.EventHandler(this.btShidoRood_Click);
            // 
            // btChangeHolding
            // 
            this.btChangeHolding.Location = new System.Drawing.Point(563, 675);
            this.btChangeHolding.Name = "btChangeHolding";
            this.btChangeHolding.Size = new System.Drawing.Size(149, 23);
            this.btChangeHolding.TabIndex = 35;
            this.btChangeHolding.Text = "Wissel houdgreep";
            this.btChangeHolding.UseVisualStyleBackColor = true;
            this.btChangeHolding.Click += new System.EventHandler(this.btChangeHolding_Click);
            // 
            // lblIpponTextRood
            // 
            this.lblIpponTextRood.AutoSize = true;
            this.lblIpponTextRood.Location = new System.Drawing.Point(457, 9);
            this.lblIpponTextRood.Name = "lblIpponTextRood";
            this.lblIpponTextRood.Size = new System.Drawing.Size(34, 13);
            this.lblIpponTextRood.TabIndex = 36;
            this.lblIpponTextRood.Text = "Ippon";
            // 
            // lblIpponTextWit
            // 
            this.lblIpponTextWit.AutoSize = true;
            this.lblIpponTextWit.Location = new System.Drawing.Point(1304, 9);
            this.lblIpponTextWit.Name = "lblIpponTextWit";
            this.lblIpponTextWit.Size = new System.Drawing.Size(34, 13);
            this.lblIpponTextWit.TabIndex = 37;
            this.lblIpponTextWit.Text = "Ippon";
            // 
            // lblWazariTextWit
            // 
            this.lblWazariTextWit.AutoSize = true;
            this.lblWazariTextWit.Location = new System.Drawing.Point(1094, 9);
            this.lblWazariTextWit.Name = "lblWazariTextWit";
            this.lblWazariTextWit.Size = new System.Drawing.Size(40, 13);
            this.lblWazariTextWit.TabIndex = 38;
            this.lblWazariTextWit.Text = "Wazari";
            // 
            // lblWazariTextRood
            // 
            this.lblWazariTextRood.AutoSize = true;
            this.lblWazariTextRood.Location = new System.Drawing.Point(275, 9);
            this.lblWazariTextRood.Name = "lblWazariTextRood";
            this.lblWazariTextRood.Size = new System.Drawing.Size(40, 13);
            this.lblWazariTextRood.TabIndex = 39;
            this.lblWazariTextRood.Text = "Wazari";
            // 
            // lblYukoTextWit
            // 
            this.lblYukoTextWit.AutoSize = true;
            this.lblYukoTextWit.Location = new System.Drawing.Point(913, 9);
            this.lblYukoTextWit.Name = "lblYukoTextWit";
            this.lblYukoTextWit.Size = new System.Drawing.Size(32, 13);
            this.lblYukoTextWit.TabIndex = 40;
            this.lblYukoTextWit.Text = "Yuko";
            // 
            // lblYukoTextRood
            // 
            this.lblYukoTextRood.AutoSize = true;
            this.lblYukoTextRood.Location = new System.Drawing.Point(111, 9);
            this.lblYukoTextRood.Name = "lblYukoTextRood";
            this.lblYukoTextRood.Size = new System.Drawing.Size(32, 13);
            this.lblYukoTextRood.TabIndex = 41;
            this.lblYukoTextRood.Text = "Yuko";
            // 
            // lblShidoTextRood
            // 
            this.lblShidoTextRood.AutoSize = true;
            this.lblShidoTextRood.Location = new System.Drawing.Point(111, 270);
            this.lblShidoTextRood.Name = "lblShidoTextRood";
            this.lblShidoTextRood.Size = new System.Drawing.Size(34, 13);
            this.lblShidoTextRood.TabIndex = 42;
            this.lblShidoTextRood.Text = "Shido";
            // 
            // lblShidoTextWit
            // 
            this.lblShidoTextWit.AutoSize = true;
            this.lblShidoTextWit.Location = new System.Drawing.Point(1304, 270);
            this.lblShidoTextWit.Name = "lblShidoTextWit";
            this.lblShidoTextWit.Size = new System.Drawing.Size(34, 13);
            this.lblShidoTextWit.TabIndex = 43;
            this.lblShidoTextWit.Text = "Shido";
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 723);
            this.Controls.Add(this.lblShidoTextWit);
            this.Controls.Add(this.lblShidoTextRood);
            this.Controls.Add(this.lblYukoTextRood);
            this.Controls.Add(this.lblYukoTextWit);
            this.Controls.Add(this.lblWazariTextRood);
            this.Controls.Add(this.lblWazariTextWit);
            this.Controls.Add(this.lblIpponTextWit);
            this.Controls.Add(this.lblIpponTextRood);
            this.Controls.Add(this.btChangeHolding);
            this.Controls.Add(this.btShidoRood);
            this.Controls.Add(this.btShidoWit);
            this.Controls.Add(this.btIpponWit);
            this.Controls.Add(this.btWazariWit);
            this.Controls.Add(this.btYukoWit);
            this.Controls.Add(this.btIpponRood);
            this.Controls.Add(this.btWazariRood);
            this.Controls.Add(this.btYukoRood);
            this.Controls.Add(this.tbIppon);
            this.Controls.Add(this.tbWazari);
            this.Controls.Add(this.tbYuko);
            this.Controls.Add(this.lblConfirmWit3);
            this.Controls.Add(this.lblConfirmWit2);
            this.Controls.Add(this.lblConfirmWit1);
            this.Controls.Add(this.lblConfirmRood3);
            this.Controls.Add(this.lblConfirmRood2);
            this.Controls.Add(this.lblconfirmRood1);
            this.Controls.Add(this.lblHoldingWit);
            this.Controls.Add(this.lblHoldingRood);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.lblShidoWit);
            this.Controls.Add(this.lblIpponWit);
            this.Controls.Add(this.lblWazariWit);
            this.Controls.Add(this.cbTijd);
            this.Controls.Add(this.btTime);
            this.Controls.Add(this.tbSec);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.lblShidoRood);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblTimeSeperate);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblIpponRood);
            this.Controls.Add(this.lblWazariRood);
            this.Controls.Add(this.lblYukoWit);
            this.Controls.Add(this.lblYukoRood);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainScreen";
            this.Text = "JudoScoreboard";
            this.Resize += new System.EventHandler(this.mainScreen_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYukoRood;
        private System.Windows.Forms.Label lblYukoWit;
        private System.Windows.Forms.Label lblWazariRood;
        private System.Windows.Forms.Label lblIpponRood;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblTimeSeperate;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblShidoRood;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbSec;
        private System.Windows.Forms.Button btTime;
        private System.Windows.Forms.CheckBox cbTijd;
        private System.Windows.Forms.Label lblWazariWit;
        private System.Windows.Forms.Label lblIpponWit;
        private System.Windows.Forms.Label lblShidoWit;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Timer tmrHolding;
        private System.Windows.Forms.Label lblHoldingRood;
        private System.Windows.Forms.Label lblHoldingWit;
        private System.Windows.Forms.Label lblconfirmRood1;
        private System.Windows.Forms.Label lblConfirmRood2;
        private System.Windows.Forms.Label lblConfirmRood3;
        private System.Windows.Forms.Label lblConfirmWit1;
        private System.Windows.Forms.Label lblConfirmWit2;
        private System.Windows.Forms.Label lblConfirmWit3;
        private System.Windows.Forms.TextBox tbYuko;
        private System.Windows.Forms.TextBox tbWazari;
        private System.Windows.Forms.TextBox tbIppon;
        private System.Windows.Forms.Button btYukoRood;
        private System.Windows.Forms.Button btWazariRood;
        private System.Windows.Forms.Button btIpponRood;
        private System.Windows.Forms.Button btYukoWit;
        private System.Windows.Forms.Button btWazariWit;
        private System.Windows.Forms.Button btIpponWit;
        private System.Windows.Forms.Button btShidoWit;
        private System.Windows.Forms.Button btShidoRood;
        private System.Windows.Forms.Button btChangeHolding;
        private System.Windows.Forms.Label lblIpponTextRood;
        private System.Windows.Forms.Label lblIpponTextWit;
        private System.Windows.Forms.Label lblWazariTextWit;
        private System.Windows.Forms.Label lblWazariTextRood;
        private System.Windows.Forms.Label lblYukoTextWit;
        private System.Windows.Forms.Label lblYukoTextRood;
        private System.Windows.Forms.Label lblShidoTextRood;
        private System.Windows.Forms.Label lblShidoTextWit;
    }
}

