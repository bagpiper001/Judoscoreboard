using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudoScoreboard
{
    
    public partial class mainScreen : Form
    {
        publicScreen voorkant = new publicScreen();
        Score score = new Score();

        //Font initiation
        Font standardFont = new Font("Microsoft Sans Serif", 100);
        Font kleinFont = new Font("Microsoft Sans Serif", 40);
        Color rood = Color.Red;
        Color wit = Color.White;
        Color grijs = Color.Gray;
        Color blauw = Color.Blue;

        Font mainScreenStandardFont = new Font("Microsoft Sans Serif", 50);
        Font mainScreenKleinFont = new Font("Microsoft Sans Serif", 20);

        //Strings used for getting and setting scores.
        String yuko = "yuko";
        String wazari = "wazari";
        String ippon = "ippon";
        String shido = "shido";
        String sRood = "rood";
        String sWit = "wit";

        //timer initiation
        public int seconds;
        public int minutes;
        public bool paused;

        //for dynamic scaling
        public string[] witLabels = {"lblYukoWit", "lblWazariWit", "lblIpponWit",  "lblShidoWit" };
        public string[] witTextLabels = { "lblYukoTextWit", "lblWazariTextWit", "lblIpponTextWit", "lblShidoTextWit" };
        public string[] witConfirmLabels = { "lblConfirmWit1", "lblConfirmWit2", "lblConfirmWit3" };
        public string[] roodLabels = { "lblYukoRood", "lblWazariRood", "lblIpponRood",  "lblShidoRood" };
        public string[] roodTextLabels = {"lblYukoTextRood", "lblWazariTextRood", "lblIpponTextRood", "lblShidoTextRood" };
        public string[] roodConfirmLabels = { "lblConfirmRood1", "lblConfirmRood2", "lblConfirmRood3" };
        public string[] timerLabels = { "lblMin", "lblTimeSeperate", "lblSec" };

        public List<Control> buttonList = new List<Control>();
        public List<Control> witLabelList = new List<Control>();
        public List<Control> witTextLabelList = new List<Control>();
        public List<Control> witConfirmLabelList = new List<Control>();
        public List<Control> roodLabelList = new List<Control>();
        public List<Control> roodTextLabelList = new List<Control>();
        public List<Control> roodConfirmLabelList = new List<Control>();
        public List<Control> timerLabelList = new List<Control>();

        //front lists
        public List<Control> witVoorkantLabelList = new List<Control>();
        public List<Control> witVoorkantTextLabelList = new List<Control>();
        public List<Control> witVoorkantConfirmLabelList = new List<Control>();
        public List<Control> roodVoorkantLabelList = new List<Control>();
        public List<Control> roodVoorkantTextLabelList = new List<Control>();
        public List<Control> roodVoorkantConfirmLabelList = new List<Control>();

        public int width;
        public int height;
        
        //holding timer
        public bool isRood = false;

        public mainScreen()
        {
            
            Screen[] screens = Screen.AllScreens;
            //Make sure there is a second monitor attached.
            if (screens.Length > 1)
            {
                //Get the screen boundaries and put the front screen on the second monitor.
                Rectangle boundVoorkant = screens[1].WorkingArea;
                voorkant.SetBounds(boundVoorkant.X, boundVoorkant.Y, boundVoorkant.Width, boundVoorkant.Height);
                voorkant.StartPosition = FormStartPosition.Manual;
                voorkant.WindowState = FormWindowState.Maximized;
            }
            //Get the normal screen boundaries and make sure the mainscreen is maximized.
            Rectangle boundMain = screens[0].Bounds;
            this.SetBounds(boundMain.X, boundMain.Y, boundMain.Width, boundMain.Height);
            this.WindowState = FormWindowState.Maximized;
            width = this.Size.Width;
            height = this.Size.Height;
            voorkant.Show();
            InitializeComponent();
            initiateScreen();

            //fill lists for dynamic scale
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                    buttonList.Add((Button)control);
                if(control.GetType() == typeof(Label))
                {
                    if(witLabels.Contains(control.Name.ToString()))
                        witLabelList.Add((Label)control);
                    if (witConfirmLabels.Contains(control.Name.ToString()))
                        witConfirmLabelList.Add((Label)control);
                    if (witTextLabels.Contains(control.Name.ToString()))
                        witTextLabelList.Add((Label)control);
                    if (roodLabels.Contains(control.Name.ToString()))
                        roodLabelList.Add((Label)control);
                    if (roodTextLabels.Contains(control.Name.ToString()))
                        roodTextLabelList.Add((Label)control);
                    if (roodConfirmLabels.Contains(control.Name.ToString()))
                        roodConfirmLabelList.Add((Label)control);
                    if (timerLabels.Contains(control.Name.ToString()))
                        timerLabelList.Add((Label)control);
                }
            }
            foreach(Control control in voorkant.Controls)
            {
                if(control.GetType() == typeof(Label))
                {
                    if (timerLabels.Contains(control.Name.ToString()))
                        timerLabelList.Add((Label)control);
                    if (witLabels.Contains(control.Name.ToString()))
                        witVoorkantLabelList.Add((Label)control);
                    if (witConfirmLabels.Contains(control.Name.ToString()))
                        witVoorkantConfirmLabelList.Add((Label)control);
                    if (witTextLabels.Contains(control.Name.ToString()))
                        witVoorkantTextLabelList.Add((Label)control);
                    if (roodLabels.Contains(control.Name.ToString()))
                        roodVoorkantLabelList.Add((Label)control);
                    if (roodConfirmLabels.Contains(control.Name.ToString()))
                        roodVoorkantConfirmLabelList.Add((Label)control);
                    if (roodTextLabels.Contains(control.Name.ToString()))
                        roodVoorkantTextLabelList.Add((Label)control);
                }
            }
            setButtonSize();
            setLabelSize(false);
        }

        private void setButtonSize()
        {
            //define height and width for buttons
            if (this.Size.Width/6-5 > 90)
                width = 90;
            else
                width = this.Size.Width/6-5;
            if (this.Size.Height/6-12 > 25)
                height = 25;
            else
                height = this.Size.Height/6-12;

            foreach(Button button in buttonList)
            {
                button.Size = new Size(width, height);
                button.Font = new Font("Microsoft Sans Serif", width/10);
            }

            
        }

        private void setLabelSize(Boolean resize)
        {
            if (!resize)
            {
                for (int i = 0; i < witLabelList.Count; i++)
                {
                    witLabelList[i].Font = mainScreenStandardFont;
                    witLabelList[i].BackColor = wit;
                    witTextLabelList[i].Font = mainScreenKleinFont;
                    witTextLabelList[i].BackColor = grijs;
                }
                for(int i= 0; i< roodLabelList.Count; i++)
                {
                    roodLabelList[i].Font = mainScreenStandardFont;
                    roodLabelList[i].BackColor = rood;
                    roodTextLabelList[i].Font = mainScreenKleinFont;
                    roodTextLabelList[i].BackColor = grijs;
                }
                foreach(Label label in witConfirmLabelList)
                {
                    label.Font = mainScreenKleinFont;
                    label.BackColor = grijs;
                    label.Visible = false;
                }
                foreach(Label label in roodConfirmLabelList)
                {
                    label.Font = mainScreenKleinFont;
                    label.BackColor = grijs;
                    label.Visible = false;
                }
                foreach(Label label in witVoorkantConfirmLabelList)
                {
                    label.Font = kleinFont;
                    label.BackColor = grijs;
                    label.Visible = false;
                }
                foreach(Label label in witVoorkantLabelList)
                {
                    label.Font = standardFont;
                    label.BackColor = wit;
                }
                foreach (Label label in witVoorkantTextLabelList)
                {
                    label.Font = kleinFont;
                    label.BackColor = grijs;
                }
                foreach(Label label in roodVoorkantConfirmLabelList)
                {
                    label.Font = kleinFont;
                    label.BackColor = grijs;
                    label.Visible = false;
                }
                foreach(Label label in roodVoorkantLabelList)
                {
                    label.Font = standardFont;
                    label.BackColor = rood;
                }
                foreach(Label label in roodVoorkantTextLabelList)
                {
                    label.Font = kleinFont;
                    label.BackColor = grijs;
                }

                foreach (Label label in timerLabelList)
                    label.Font = mainScreenStandardFont;
            }
        }
        /**
        *This will be the method for dynamic scaling based on size of the form. (note that frontScreen will have its own method)
        *It's called when this screen is resized.
        */
        private void mainScreen_Resize(object sender, System.EventArgs e)
        {
            setButtonSize();
            setLabelSize(true);
        }
        /**
        *On initiation of the program this method will be run, it creates the form to their default size, color and value. 
        *Values will be gained from the Score Class.
        *Colors are default: Red for the red side, White for the white side and Gray as background color.
        *Font will be default as well, as initiated in the variables stated above.
        */
        public void initiateScreen()
        {
            //test with anchors
            lblYukoRood.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            //invisible timer set & holding times.
            tbSec.Visible = false;
            tbMin.Visible = false;
            btTime.Visible = false;
            lblHoldingRood.Visible = false;
            lblHoldingWit.Visible = false;
            voorkant.lblHoldingWit.Visible = false;
            voorkant.lblHoldingRood.Visible = false;

            tbYuko.Visible = false;
            tbWazari.Visible = false;
            tbIppon.Visible = false;

            btChangeHolding.Visible = false;


            //initiate timer
            minutes = System.Convert.ToInt32(tbMin.Text);
            seconds = System.Convert.ToInt32(tbSec.Text);
            paused = true;
            lblMin.Text = "0"+ minutes.ToString();

            lblSec.Text = "0" + seconds.ToString();


            //initiate holding times
            score.houdgreepIppon = System.Convert.ToInt32(tbIppon.Text);
            score.houdgreepWazari = System.Convert.ToInt32(tbWazari.Text);
            score.houdgreepYuko = System.Convert.ToInt32(tbYuko.Text);

            //changing function
            btChangeColor.Visible = false;

            //timer frontScreen
            voorkant.lblMin.Text = "0" + minutes.ToString();
            voorkant.lblSec.Text = "0" + seconds.ToString();

            //background
            this.BackColor = grijs;
            voorkant.BackColor = grijs;

            //publicScreen
            voorkant.lblHoldingWit.Text = score.holdingWit.ToString();
            voorkant.lblHoldingWit.Font = standardFont;
            voorkant.lblHoldingWit.BackColor = grijs;
            voorkant.lblHoldingWit.Visible = false;
            voorkant.lblYukoWit.Text = score.getWit(yuko).ToString();
            voorkant.lblWazariWit.Text = score.getWit(wazari).ToString();
            voorkant.lblIpponWit.Text = score.getWit(ippon).ToString();
            voorkant.lblShidoWit.Text = score.getWit(shido).ToString();
            voorkant.lblConfirmWit1.Text = score.confirmWit1.ToString();
            voorkant.lblConfirmWit2.Text = score.confirmWit2.ToString();
            voorkant.lblConfirmWit3.Text = score.confirmWit3.ToString();

            //rood
            voorkant.lblHoldingRood.Text = score.holdingRood.ToString();
            voorkant.lblHoldingRood.Font = standardFont;
            voorkant.lblHoldingRood.BackColor = grijs;
            voorkant.lblHoldingRood.Visible = false;
            voorkant.lblYukoRood.Text = score.getRood(yuko).ToString();
            voorkant.lblWazariRood.Text = score.getRood(wazari).ToString();
            voorkant.lblIpponRood.Text = score.getRood(ippon).ToString();
            voorkant.lblShidoRood.Text = score.getRood(shido).ToString();
            voorkant.lblConfirmRood1.Text = score.confirmRood1.ToString();
            voorkant.lblConfirmRood2.Text = score.confirmRood2.ToString();
            voorkant.lblConfirmRood3.Text = score.confirmRood3.ToString();

            //mainScreen
            lblHoldingRood.Text = score.holdingRood.ToString();
            lblHoldingRood.Font = mainScreenStandardFont;
            lblHoldingRood.BackColor = grijs;

            lblYukoRood.Text = score.getRood(yuko).ToString();
            lblWazariRood.Text = score.getRood(wazari).ToString();
            lblIpponRood.Text = score.getRood(ippon).ToString();
            lblShidoRood.Text = score.getRood(shido).ToString();
            lblConfirmRood1.Text = score.confirmRood1.ToString();
            lblConfirmRood2.Text = score.confirmRood2.ToString();
            lblConfirmRood3.Text = score.confirmRood3.ToString();


            //wit
            lblHoldingWit.Text = score.holdingWit.ToString();
            lblHoldingWit.Font = mainScreenStandardFont;
            lblHoldingWit.BackColor = grijs;

            lblYukoWit.Text = score.getWit(yuko).ToString();
            lblWazariWit.Text = score.getWit(wazari).ToString();
            lblIpponWit.Text = score.getWit(ippon).ToString();
            lblShidoWit.Text = score.getWit(shido).ToString();
            lblConfirmWit1.Text = score.confirmWit1.ToString();
            lblConfirmWit2.Text = score.confirmWit2.ToString();
            lblConfirmWit3.Text = score.confirmWit3.ToString();
        }

        public void updateScreen()
        {
            lblYukoRood.Text = score.getRood(yuko).ToString();
            voorkant.lblYukoRood.Text = score.getRood(yuko).ToString();

            lblWazariRood.Text = score.getRood(wazari).ToString();
            voorkant.lblWazariRood.Text = score.getRood(wazari).ToString();

            lblIpponRood.Text = score.getRood(ippon).ToString();
            voorkant.lblIpponRood.Text = score.getRood(ippon).ToString();

            lblShidoRood.Text = score.getRood(shido).ToString();
            voorkant.lblShidoRood.Text = score.getRood(shido).ToString();

            lblHoldingRood.Text = score.holdingRood.ToString();
            voorkant.lblHoldingRood.Text = score.holdingRood.ToString();

            if (score.confirmRood1 > 0)
            {
                lblConfirmRood1.Visible = true;
                voorkant.lblConfirmRood1.Visible = true;
            }
            else
            {
                lblConfirmRood1.Visible = false;
                voorkant.lblConfirmRood1.Visible = false;
            }
            if (score.confirmRood2 > 0)
            {
                lblConfirmRood2.Visible = true;
                voorkant.lblConfirmRood2.Visible = true;
            }
            else
            {
                lblConfirmRood2.Visible = false;
                voorkant.lblConfirmRood2.Visible = false;
            }
            if (score.confirmRood3 > 0)
            {
                lblConfirmRood3.Visible = true;
                voorkant.lblConfirmRood3.Visible = true;
            }
            else
            {
                lblConfirmRood3.Visible = false;
                voorkant.lblConfirmRood3.Visible = false;
            }

            lblConfirmRood1.Text = score.confirmRood1.ToString();
            voorkant.lblConfirmRood1.Text = score.confirmRood1.ToString();
            lblConfirmRood2.Text = score.confirmRood2.ToString();
            voorkant.lblConfirmRood2.Text = score.confirmRood2.ToString();
            lblConfirmRood3.Text = score.confirmRood3.ToString();
            voorkant.lblConfirmRood3.Text = score.confirmRood3.ToString();

            if(score.confirmWit1 > 0)
            {
                lblConfirmWit1.Visible = true;
                voorkant.lblConfirmWit1.Visible = true;
            }
            else
            {
                lblConfirmWit1.Visible = false;
                voorkant.lblConfirmWit1.Visible = false;
            }
            if(score.confirmWit2 > 0)
            {
                lblConfirmWit2.Visible = true;
                voorkant.lblConfirmWit2.Visible = true;
            }
            else
            {
                lblConfirmWit2.Visible = false;
                voorkant.lblConfirmWit2.Visible = false;
            }
            if(score.confirmWit3 > 0)
            {
                lblConfirmWit3.Visible = true;
                voorkant.lblConfirmWit3.Visible = true;
            }
            else
            {
                lblConfirmWit3.Visible = false;
                voorkant.lblConfirmWit3.Visible = false;
            }

            lblConfirmWit1.Text = score.confirmWit1.ToString();
            voorkant.lblConfirmWit1.Text = score.confirmWit1.ToString();
            lblConfirmWit2.Text = score.confirmWit2.ToString();
            voorkant.lblConfirmWit2.Text = score.confirmWit2.ToString();
            lblConfirmWit3.Text = score.confirmWit3.ToString();
            voorkant.lblConfirmWit3.Text = score.confirmWit3.ToString();

            lblYukoWit.Text = score.getWit(yuko).ToString();
            voorkant.lblYukoWit.Text = score.getWit(yuko).ToString();

            lblWazariWit.Text = score.getWit(wazari).ToString();
            voorkant.lblWazariWit.Text = score.getWit(wazari).ToString();

            lblIpponWit.Text = score.getWit(ippon).ToString();
            voorkant.lblIpponWit.Text = score.getWit(ippon).ToString();

            lblShidoWit.Text = score.getWit(shido).ToString();
            voorkant.lblShidoWit.Text = score.getWit(shido).ToString();

            lblHoldingWit.Text = score.holdingWit.ToString();
            voorkant.lblHoldingWit.Text = score.holdingWit.ToString();

            if(minutes < 10)
            {
                lblMin.Text = "0" + minutes.ToString();
                voorkant.lblMin.Text = "0" + minutes.ToString();
            }
            else
            {
                lblMin.Text = minutes.ToString();
                voorkant.lblMin.Text = minutes.ToString();
            }
            if(seconds < 10)
            {
                lblSec.Text = "0" + seconds.ToString();
                voorkant.lblSec.Text = "0" + seconds.ToString();
            }
            else
            {
                lblSec.Text = seconds.ToString();
                voorkant.lblSec.Text = seconds.ToString();
            }
        }

        /**
        *When you want to change the time, certain actions are not permitted, those will be disabled.
        */
        public void timeChanging()
        {
            btTime.Visible = true;
            tbMin.Visible = true;
            tbSec.Visible = true;

            tbYuko.Visible = true;
            tbWazari.Visible = true;
            tbIppon.Visible = true;

            lblTimeSeperate.Enabled = false;
            lblMin.Enabled = false;
            lblSec.Enabled = false;
            btRestart.Enabled = false;

            foreach (Label label in witLabelList)
                label.Enabled = false;
            foreach (Label label in roodLabelList)
                label.Enabled = false;

            btChangeHolding.Visible = false;

            lblHoldingWit.Visible = false;
            lblHoldingRood.Visible = false;
            voorkant.lblHoldingRood.Visible = false;
            voorkant.lblHoldingWit.Visible = false;

            btChangeColor.Visible = true;
        }
        /**
        *After changes are made you're reade for a match, you can go ahead again.
        */
        public void readyForMatch()
        {
            btTime.Visible = false;
            tbSec.Visible = false;
            tbMin.Visible = false;

            tbYuko.Visible = false;
            tbWazari.Visible = false;
            tbIppon.Visible = false;

            lblTimeSeperate.Enabled = true;
            lblMin.Enabled = true;
            lblSec.Enabled = true;
            btRestart.Enabled = true;

            lblShidoRood.Enabled = true;
            lblShidoWit.Enabled = true;
            lblYukoWit.Enabled = true;
            lblYukoRood.Enabled = true;
            lblWazariWit.Enabled = true;
            lblWazariRood.Enabled = true;
            lblIpponWit.Enabled = true;
            lblIpponRood.Enabled = true;

            btChangeHolding.Visible = false;

            lblHoldingRood.Visible = false;
            lblHoldingWit.Visible = false;
            voorkant.lblHoldingWit.Visible = false;
            voorkant.lblHoldingRood.Visible = false;

            btChangeColor.Visible = false;
        }

        /**
        *This changes the visual while the time is ticking (you can't change time then, but you can start other timers)/When timer is on pause.
        */
        public void timeIsTicking()
        {
            cbSettings.Enabled = false;
            btRestart.Enabled = false;

            lblHoldingWit.Visible = true;
            lblHoldingRood.Visible = true;
           

        }

        public void timeIsPause()
        {
            cbSettings.Enabled = true;
            btRestart.Enabled = true;

            lblHoldingRood.Visible = false;
            lblHoldingWit.Visible = false;
            voorkant.lblHoldingWit.Visible = false;
            voorkant.lblHoldingRood.Visible = false;
        }

        /**
        *This resets the colors to the default colors.
        */
        public void resetColors()
        {
            this.BackColor = grijs;
            voorkant.BackColor = grijs;

            foreach (Label label in roodLabelList)
                label.BackColor = rood;
            foreach (Label label in roodTextLabelList)
                label.BackColor = grijs;
            foreach (Label label in roodConfirmLabelList)
                label.BackColor = grijs;
            foreach (Label label in roodVoorkantLabelList)
                label.BackColor = rood;
            foreach (Label label in roodVoorkantConfirmLabelList)
                label.BackColor = grijs;
            foreach (Label label in roodVoorkantTextLabelList)
                label.BackColor = grijs;

            lblHoldingRood.BackColor = grijs;
            lblHoldingWit.BackColor = grijs;
            voorkant.lblHoldingWit.BackColor = grijs;
            voorkant.lblHoldingRood.BackColor = grijs;

            foreach (Label label in witLabelList)
                label.BackColor = wit;
            foreach (Label label in witTextLabelList)
                label.BackColor = grijs;
            foreach (Label label in witConfirmLabelList)
                label.BackColor = grijs;
            foreach (Label label in witVoorkantLabelList)
                label.BackColor = wit;
            foreach (Label label in witVoorkantTextLabelList)
                label.BackColor = grijs;
            foreach (Label label in witVoorkantConfirmLabelList)
                label.BackColor = grijs;
        }
        /**
        *The resetToDefault method is the method to reset the scoreboard to it's original form, ready for a new match.
        */
        public void resetToDefault()
        {
            //reset scores.
            score.setDefault();
            minutes = System.Convert.ToInt32(tbMin.Text);
            seconds = System.Convert.ToInt32(tbSec.Text);
            paused = true;
            cbSettings.Enabled = true;
            tmrHolding.Enabled = false;
            score.holdingRood = 0;
            score.holdingWit = 0;
            lblHoldingRood.Visible = false;
            lblHoldingWit.Visible = false;
            voorkant.lblHoldingWit.Visible = false;
            voorkant.lblHoldingRood.Visible = false;
            foreach (Label label in roodConfirmLabelList)
                label.Visible = false;
            foreach (Label label in witConfirmLabelList)
                label.Visible = false;
            foreach (Label label in roodVoorkantConfirmLabelList)
                label.Visible = false;
            foreach(Label label in witVoorkantConfirmLabelList)
                label.Visible = false;
            btChangeHolding.Visible = false;
            lblHoldingRood.Enabled = true;
            lblHoldingWit.Enabled = true;
            foreach (Label label in timerLabelList)
                label.Enabled = true;
            resetColors();
            updateScreen();
        }


        /**
        *checkWinnaar returns if there is a winner.
        */
        public void eindeWedstrijd()
        {
            tmrClock.Enabled = false;
            tmrHolding.Enabled = false;
            lblHoldingWit.Enabled = false;
            lblHoldingRood.Enabled = false;
            btChangeHolding.Visible = false;
            btRestart.Enabled = true;
            if (score.getWinnaarRood())
            {
                colorRed();
                MessageBox.Show(sRood + " wint met 10 punten.");
            }
            else
            {
                if (score.getWinnaarWit())
                {
                    colorWhite();
                    MessageBox.Show(sWit + " wint met 10 punten.");
                }

                else
                {
                    if (score.confirmRood1 == 0 && score.confirmRood2 == 0 && score.confirmRood3 == 0)
                    {
                        if (score.confirmWit1 == 0 && score.confirmWit2 == 0 && score.confirmWit3 == 0)
                        {
                            score.berekenWinnaar();
                            if (score.winnaar == sRood)
                            {
                                colorRed();
                                MessageBox.Show(score.berekenWinnaar());
                            }
                            if (score.winnaar == sWit)
                            {
                                colorWhite();
                                MessageBox.Show(score.berekenWinnaar());
                            }
                            if (score.winnaar == "gelijk")
                            {
                                MessageBox.Show(score.berekenWinnaar());
                            }
                        }
                        
                    }
                }
            }
        }

        //color methods are used to color the screen for a winner.
        public void colorRed()
        {
            foreach (Label label in witTextLabelList)
                label.BackColor = rood;
            foreach (Label label in witLabelList)
                label.BackColor = rood;
            foreach (Label label in roodTextLabelList)
                label.BackColor = rood;
            foreach (Label label in witConfirmLabelList)
                label.BackColor = rood;
            foreach (Label label in roodConfirmLabelList)
                label.BackColor = rood;
            lblHoldingWit.BackColor = rood;
            lblHoldingRood.BackColor = rood;
            this.BackColor = rood;
            voorkant.BackColor = rood;

            foreach (Label label in roodVoorkantConfirmLabelList)
                label.BackColor = rood;
            foreach (Label label in roodVoorkantTextLabelList)
                label.BackColor = rood;
            foreach (Label label in roodVoorkantLabelList)
                label.BackColor = rood;
            foreach (Label label in witVoorkantConfirmLabelList)
                label.BackColor = rood;
            foreach (Label label in witVoorkantLabelList)
                label.BackColor = rood;
            foreach (Label label in witVoorkantTextLabelList)
                label.BackColor = rood;
        }

        public void colorWhite()
        {
            foreach (Label label in roodLabelList)
                label.BackColor = wit;
            foreach (Label label in roodTextLabelList)
                label.BackColor = wit;
            foreach (Label label in witTextLabelList)
                label.BackColor = wit;
            foreach (Label label in witConfirmLabelList)
                label.BackColor = wit;
            foreach (Label label in roodConfirmLabelList)
                label.BackColor = wit;
            lblHoldingRood.BackColor = wit;
            lblHoldingWit.BackColor = wit;
            this.BackColor = wit;
            voorkant.BackColor = wit;

            foreach (Label label in roodVoorkantConfirmLabelList)
                label.BackColor = wit;
            foreach (Label label in roodVoorkantTextLabelList)
                label.BackColor = wit;
            foreach (Label label in roodVoorkantLabelList)
                label.BackColor = wit;
            foreach (Label label in witVoorkantConfirmLabelList)
                label.BackColor = wit;
            foreach (Label label in witVoorkantLabelList)
                label.BackColor = wit;
            foreach (Label label in witVoorkantTextLabelList)
                label.BackColor = wit;
        }
        //event handlers
        private void lblYukoRood_Click(object sender, EventArgs e)
        {
            score.setYuko(true, sRood);
            updateScreen();
        }

        private void lblWazariRood_Click(object sender, EventArgs e)
        {
            score.setWazari(true, sRood);
            if(score.getWinnaarRood())
            {
                eindeWedstrijd();
            }
            updateScreen();
        }

        private void lblIpponRood_Click(object sender, EventArgs e)
        {
            score.setIppon(true, sRood);
            if(score.getWinnaarRood())
            {
                eindeWedstrijd();
            }
            updateScreen();
        }

        private void lblShidoRood_Click(object sender, EventArgs e)
        {
            score.setShido(true, sRood);
            if(score.getWinnaarWit())
            {
                eindeWedstrijd();
            }
            updateScreen();
        }

        private void lblYukoWit_Click(object sender, EventArgs e)
        {
            score.setYuko(true, sWit);
            updateScreen();
        }

        private void lblWazariWit_Click(object sender, EventArgs e)
        {
            score.setWazari(true, sWit);
            if(score.getWinnaarWit())
            {
                eindeWedstrijd();
            }
            updateScreen();
        }

        private void lblIpponWit_Click(object sender, EventArgs e)
        {
            score.setIppon(true, sWit);
            if(score.getWinnaarWit())
            {
                eindeWedstrijd();
            }
            updateScreen();
        }

        private void lblShidoWit_Click(object sender, EventArgs e)
        {
            score.setShido(true, sWit);
            if(score.getWinnaarRood())
            {
                eindeWedstrijd();
            }
            updateScreen();
        }
        /**
        *On click on one of the labels, you enable the timer/disable it when activated.
        */
        private void lblMin_Click(object sender, EventArgs e)
        {
            if(paused)
            {
                paused = false;
                timeIsTicking();
                tmrClock.Enabled = true;

            }
            else
            {
                paused = true;
                timeIsPause();
                tmrClock.Enabled = false;
            }
        }

        private void lblSec_Click(object sender, EventArgs e)
        {
            if(paused)
            {
                paused = false;
                timeIsTicking();
                tmrClock.Enabled = true;
            }
            else
            {
                paused = true;
                timeIsPause();
                tmrClock.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(paused)
            {
                paused = false;
                timeIsTicking();
                tmrClock.Enabled = true;
            }
            else
            {
                paused = true;
                timeIsPause();
                tmrClock.Enabled = false;
            }
        }
        /**
        *Clock countdown timer.
        */
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            if((minutes == 0) && (seconds ==0))
            {
                tmrClock.Enabled = false;
                paused = true;
                if(!tmrHolding.Enabled)
                {
                    eindeWedstrijd();
                }
            }
            else
            {
                if(seconds < 1)
                {
                    seconds = 59;
                    minutes -= 1;
                }
                else
                {
                    seconds -= 1;
                }
            }
            updateScreen();
        }

        //if you change the time, a check is being done to make sure it's a number, if not an error is returned.
        private void btTime_Click(object sender, EventArgs e)
        {
            try
            {
                minutes = System.Convert.ToInt32(tbMin.Text);
                seconds = System.Convert.ToInt32(tbSec.Text);
                score.houdgreepIppon = System.Convert.ToInt32(tbIppon.Text);
                score.houdgreepWazari = System.Convert.ToInt32(tbWazari.Text);
                score.houdgreepYuko = System.Convert.ToInt32(tbYuko.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("U moet een getal opgeven.");
            }
            updateScreen();
        }

        //the checkbox holds knowledge of the time can be changed or not (during a match or not)
        private void cbTijd_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSettings.Checked)
            {
                timeChanging();
            }
            else
            {
                readyForMatch();
            }
        }

        //reset match button.
        private void btRestart_Click(object sender, EventArgs e)
        {
            resetToDefault();
        }

        //holding timer updates the holding timer.
        private void tmrHolding_Tick(object sender, EventArgs e)
        {
            if(isRood)
            {
                //update rood
                score.holdingRood += 1;
                if (score.getRood(wazari) > 0 && score.holdingRood >= score.houdgreepWazari)
                {
                    score.setWazari(true, sRood);
                    eindeWedstrijd();
                }
                else
                {
                    if (score.holdingRood >= score.houdgreepIppon)
                    {
                        score.setIppon(true, sRood);
                        eindeWedstrijd();
                    }
                }
               
            }
            else
            {
                //update wit
                score.holdingWit += 1;
                if (score.getWit(wazari) > 0 && score.holdingWit >= score.houdgreepWazari)
                {
                    score.setWazari(true, sWit);
                    eindeWedstrijd();
                }
                else
                {
                    if (score.holdingWit >= score.houdgreepIppon)
                    {
                        score.setIppon(true, sWit);
                        eindeWedstrijd();
                    }
                }
               
            }
            updateScreen();
        }

        //enable or disable the holding timer, on click again, it's send to confirm.
        private void lblHoldingRood_Click(object sender, EventArgs e)
        {
            if(!tmrHolding.Enabled)
            {
                isRood = true;
                tmrHolding.Enabled = true;
                foreach (Label label in timerLabelList)
                    label.Enabled = false;
                lblHoldingWit.Visible = false;
                btChangeHolding.Visible = true;
                voorkant.lblHoldingRood.Visible = true;
            }
            else
            {
                tmrHolding.Enabled = false;
                lblHoldingWit.Visible = true;
                foreach (Label label in timerLabelList)
                    label.Enabled = true;
                btChangeHolding.Visible = false;
                voorkant.lblHoldingRood.Visible = false;
                if(score.confirmRood1 == 0)
                {
                    score.confirmRood1 = score.holdingRood;
                    lblConfirmRood1.Visible = true;
                    voorkant.lblConfirmRood1.Visible = true;
                }
                else
                {
                    if(score.confirmRood2 == 0)
                    {
                        score.confirmRood2 = score.holdingRood;
                        lblConfirmRood2.Visible = true;
                        voorkant.lblConfirmRood2.Visible = true;
                    }
                    else
                    {
                        score.confirmRood3 = score.holdingRood;
                        lblConfirmRood3.Visible = true;
                        voorkant.lblConfirmRood3.Visible = true;
                    }
                }
                score.holdingRood = 0;
                
            }
            updateScreen();

        }

        
        private void lblHoldingWit_Click(object sender, EventArgs e)
        {
            if(!tmrHolding.Enabled)
            {
                isRood = false;
                tmrHolding.Enabled = true;
                lblHoldingRood.Visible = false;
                foreach (Label label in timerLabelList)
                    label.Enabled = false;
                btChangeHolding.Visible = true;
                voorkant.lblHoldingWit.Visible = true;
            }
            else
            {
                tmrHolding.Enabled = false;
                lblHoldingRood.Visible = true;
                foreach (Label label in timerLabelList)
                    label.Enabled = true;
                btChangeHolding.Visible = false;
                voorkant.lblHoldingWit.Visible = false;
                if (score.confirmWit1 == 0)
                {
                    score.confirmWit1 = score.holdingWit;
                    lblConfirmWit1.Visible = true;
                    voorkant.lblConfirmWit1.Visible = true;
                }
                else
                {
                    if(score.confirmWit2 == 0)
                    {
                        score.confirmWit2 = score.holdingWit;
                        lblConfirmWit2.Visible = true;
                        voorkant.lblConfirmWit2.Visible = true;
                    }
                    else
                    {
                        score.confirmWit3 = score.holdingWit;
                        lblConfirmWit3.Visible = true;
                        voorkant.lblConfirmWit3.Visible = true;
                    }
                }
                score.holdingWit = 0;
                
            }
            updateScreen();

        }

        //to confirm holdings, if there is a score, it will be updated in the score method.
        private void lblconfirmRood1_Click(object sender, EventArgs e)
        {
            if(score.confirmScoreRood(1))
            {
                eindeWedstrijd();
            }
            else
            {
                if(minutes == 0 && seconds == 0)
                {
                    eindeWedstrijd();
                }
            }
            updateScreen();
        }

        private void lblConfirmRood2_Click(object sender, EventArgs e)
        {
            if (score.confirmScoreRood(2))
            {
                eindeWedstrijd();
            }
            else
            {
                if (minutes == 0 && seconds == 0)
                {
                    eindeWedstrijd();
                }
            }
            updateScreen();
        }

        private void lblConfirmRood3_Click(object sender, EventArgs e)
        {
            if (score.confirmScoreRood(3))
            {
                eindeWedstrijd();
            }
            else
            {
                if (minutes == 0 && seconds == 0)
                {
                    eindeWedstrijd();
                }
            }
            updateScreen();
        }

        private void lblConfirmWit1_Click(object sender, EventArgs e)
        {
            if(score.confirmScoreWit(1))
            {
                eindeWedstrijd();
            }
            else
            {
                if (minutes == 0 && seconds == 0)
                {
                    eindeWedstrijd();
                }
            }
            updateScreen();
        }

        private void lblConfirmWit2_Click(object sender, EventArgs e)
        {
            if(score.confirmScoreWit(2))
            {
                eindeWedstrijd();
            }
            else
            {
                if (minutes == 0 && seconds == 0)
                {
                    eindeWedstrijd();
                }
            }
            updateScreen();
        }

        private void lblConfirmWit3_Click(object sender, EventArgs e)
        {
            if(score.confirmScoreWit(3))
            {
                eindeWedstrijd();
            }
            else
            {
                if (minutes == 0 && seconds == 0)
                {
                    eindeWedstrijd();
                }
            }
            updateScreen();
        }

        private void btYukoRood_Click(object sender, EventArgs e)
        {
            score.setYuko(false, sRood);
            updateScreen();
        }

        private void btWazariRood_Click(object sender, EventArgs e)
        {
            score.setWazari(false, sRood);
            resetColors();
            updateScreen();
        }

        private void btIpponRood_Click(object sender, EventArgs e)
        {
            score.setIppon(false, sRood);
            resetColors();
            updateScreen();
        }

        private void btYukoWit_Click(object sender, EventArgs e)
        {
            score.setYuko(false, sWit);
            updateScreen();
        }

        private void btWazariWit_Click(object sender, EventArgs e)
        {
            score.setWazari(false, sWit);
            resetColors();
            updateScreen();
        }

        private void btIpponWit_Click(object sender, EventArgs e)
        {
            score.setIppon(false, sWit);
            resetColors();
            updateScreen();
        }

        private void btShidoWit_Click(object sender, EventArgs e)
        {
            score.setShido(false, sWit);
            resetColors();
            updateScreen();
        }

        private void btShidoRood_Click(object sender, EventArgs e)
        {
            score.setShido(false, sRood);
            resetColors();
            updateScreen();
        }

        private void btChangeHolding_Click(object sender, EventArgs e)
        {
            if(isRood)
            {
                score.holdingWit = score.holdingRood;
                score.holdingRood = 0;
                isRood = false;

                //change the visuals
                lblHoldingWit.Visible = true;
                voorkant.lblHoldingWit.Visible = true;
                lblHoldingRood.Visible = false;
                voorkant.lblHoldingRood.Visible = false;
            }
            else
            {
                score.holdingRood = score.holdingWit;
                score.holdingWit = 0;
                isRood = true;

                //change the visuals
                lblHoldingRood.Visible = true;
                voorkant.lblHoldingRood.Visible = true;
                lblHoldingWit.Visible = false;
                voorkant.lblHoldingWit.Visible = false;
            }
        }

        private void btChangeColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deze functionaliteit is momenteel nog niet beschikbaar.");
        }

        private void lblWazariTextRood_Click(object sender, EventArgs e)
        {

        }

        private void lblIpponTextRood_Click(object sender, EventArgs e)
        {

        }
    }
}