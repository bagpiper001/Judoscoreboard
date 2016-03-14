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

        //holding timer
        public bool isRood = false;

        public mainScreen()
        {
            
            Screen[] screens = Screen.AllScreens;
            //Make sure there is a second monitor attached.
            if (screens.Length > 1)
            {
                //Get the screen boundaries and put the front screen on the second monitor.
                //Rectangle boundVoorkant = screens[1].Bounds;
                Rectangle boundVoorkant = screens[1].WorkingArea;
                voorkant.SetBounds(boundVoorkant.X, boundVoorkant.Y, boundVoorkant.Width, boundVoorkant.Height);
                voorkant.StartPosition = FormStartPosition.Manual;
            }
            //Get the normal screen boundaries and make sure the mainscreen is maximized.
            Rectangle boundMain = screens[0].Bounds;
            this.SetBounds(boundMain.X, boundMain.Y, boundMain.Width, boundMain.Height);
            voorkant.Show();
            InitializeComponent();
            initiateScreen();
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
            lblMin.Font = mainScreenStandardFont;
            lblSec.Text = "0" + seconds.ToString();
            lblSec.Font = mainScreenStandardFont;
            lblTimeSeperate.Font = mainScreenStandardFont;

            //initiate holding times
            score.houdgreepIppon = System.Convert.ToInt32(tbIppon.Text);
            score.houdgreepWazari = System.Convert.ToInt32(tbWazari.Text);
            score.houdgreepYuko = System.Convert.ToInt32(tbYuko.Text);

            //timer frontScreen
            voorkant.lblMin.Text = "0" + minutes.ToString();
            voorkant.lblMin.Font = mainScreenStandardFont;
            voorkant.lblSec.Text = "0" + seconds.ToString();
            voorkant.lblSec.Font = mainScreenStandardFont;
            voorkant.label1.Font = mainScreenStandardFont;

            //background
            this.BackColor = grijs;
            voorkant.BackColor = grijs;

            //publicScreen
            voorkant.lblYukoWit.Text = score.getWit(yuko).ToString();
            voorkant.lblYukoWit.Font = standardFont;
            voorkant.lblYukoWit.BackColor = wit;

            voorkant.lblWazariWit.Text = score.getWit(wazari).ToString();
            voorkant.lblWazariWit.Font = standardFont;
            voorkant.lblWazariWit.BackColor = wit;

            voorkant.lblIpponWit.Text = score.getWit(ippon).ToString();
            voorkant.lblIpponWit.Font = standardFont;
            voorkant.lblIpponWit.BackColor = wit;

            voorkant.lblShidoWit.Text = score.getWit(shido).ToString();
            voorkant.lblShidoWit.Font = standardFont;
            voorkant.lblShidoWit.BackColor = wit;

            voorkant.lblHoldingWit.Text = score.holdingRood.ToString();
            voorkant.lblHoldingWit.Font = standardFont;
            voorkant.lblHoldingWit.BackColor = grijs;
            voorkant.lblHoldingWit.Visible = false;

            voorkant.lblConfirmWit1.Text = score.confirmWit1.ToString();
            voorkant.lblConfirmWit1.Font = kleinFont;
            voorkant.lblConfirmWit1.BackColor = grijs;
            voorkant.lblConfirmWit1.Visible = false;

            voorkant.lblConfirmWit2.Text = score.confirmWit2.ToString();
            voorkant.lblConfirmWit2.Font = kleinFont;
            voorkant.lblConfirmWit2.BackColor = grijs;
            voorkant.lblConfirmWit2.Visible = false;

            voorkant.lblConfirmWit3.Text = score.confirmWit3.ToString();
            voorkant.lblConfirmWit3.Font = kleinFont;
            voorkant.lblConfirmWit3.BackColor = grijs;
            voorkant.lblConfirmWit3.Visible = false;

            voorkant.lblShidoTextWit.Font = kleinFont;
            


            //rood
            voorkant.lblYukoRood.Text = score.getRood(yuko).ToString();
            voorkant.lblYukoRood.Font = standardFont;
            voorkant.lblYukoRood.BackColor = rood;

            voorkant.lblWazariRood.Text = score.getRood(wazari).ToString();
            voorkant.lblWazariRood.Font = standardFont;
            voorkant.lblWazariRood.BackColor = rood;

            voorkant.lblIpponRood.Text = score.getRood(ippon).ToString();
            voorkant.lblIpponRood.Font = standardFont;
            voorkant.lblIpponRood.BackColor = rood;

            voorkant.lblShidoRood.Text = score.getRood(shido).ToString();
            voorkant.lblShidoRood.Font = standardFont;
            voorkant.lblShidoRood.BackColor = rood;

            voorkant.lblHoldingRood.Text = score.holdingRood.ToString();
            voorkant.lblHoldingRood.Font = standardFont;
            voorkant.lblHoldingRood.BackColor = grijs;
            voorkant.lblHoldingRood.Visible = false;

            voorkant.lblConfirmRood1.Text = score.confirmRood1.ToString();
            voorkant.lblConfirmRood1.Font = kleinFont;
            voorkant.lblConfirmRood1.BackColor = grijs;
            voorkant.lblConfirmRood1.Visible = false;

            voorkant.lblConfirmRood2.Text = score.confirmRood2.ToString();
            voorkant.lblConfirmRood2.Font = kleinFont;
            voorkant.lblConfirmRood2.BackColor = grijs;
            voorkant.lblConfirmRood2.Visible = false;

            voorkant.lblConfirmRood3.Text = score.confirmRood3.ToString();
            voorkant.lblConfirmRood3.Font = kleinFont;
            voorkant.lblConfirmRood3.BackColor = grijs;
            voorkant.lblConfirmRood3.Visible = false;

            voorkant.lblShidoTextRood.Font = kleinFont;
            voorkant.lblShidoTextWit.Font = kleinFont;
            voorkant.lblYukoTextRood.Font = kleinFont;
            voorkant.lblYukoTextWit.Font = kleinFont;
            voorkant.lblWazariTextRood.Font = kleinFont;
            voorkant.lblWazariTextWit.Font = kleinFont;
            voorkant.lblIpponTextRood.Font = kleinFont;
            voorkant.lblIpponTextWit.Font = kleinFont;

            
                        
            //mainScreen
            lblYukoRood.Text = score.getRood(yuko).ToString();
            lblYukoRood.Font = mainScreenStandardFont;
            lblYukoRood.BackColor = rood;

            lblWazariRood.Text = score.getRood(wazari).ToString();
            lblWazariRood.Font = mainScreenStandardFont;
            lblWazariRood.BackColor = rood;

            lblIpponRood.Text = score.getRood(ippon).ToString();
            lblIpponRood.Font = mainScreenStandardFont;
            lblIpponRood.BackColor = rood;

            lblShidoRood.Text = score.getRood(shido).ToString();
            lblShidoRood.Font = mainScreenStandardFont;
            lblShidoRood.BackColor = rood;

            lblHoldingRood.Text = score.holdingRood.ToString();
            lblHoldingRood.Font = mainScreenStandardFont;
            lblHoldingRood.BackColor = grijs;

            lblconfirmRood1.Text = score.confirmRood1.ToString();
            lblconfirmRood1.Font = mainScreenKleinFont;
            lblconfirmRood1.BackColor = grijs;
            lblconfirmRood1.Visible = false;

            lblConfirmRood2.Text = score.confirmRood2.ToString();
            lblConfirmRood2.Font = mainScreenKleinFont;
            lblConfirmRood2.BackColor = grijs;
            lblConfirmRood2.Visible = false;

            lblConfirmRood3.Text = score.confirmRood3.ToString();
            lblConfirmRood3.Font = mainScreenKleinFont;
            lblConfirmRood3.BackColor = grijs;
            lblConfirmRood3.Visible = false;

            lblIpponTextRood.Font = mainScreenKleinFont;
            lblIpponTextRood.BackColor = grijs;
            lblWazariTextRood.Font = mainScreenKleinFont;
            lblWazariTextRood.BackColor = grijs;
            lblYukoTextRood.Font = mainScreenKleinFont;
            lblYukoTextRood.BackColor = grijs;
            lblShidoTextRood.Font = mainScreenKleinFont;
            lblShidoTextRood.BackColor = grijs;

            //wit
            lblYukoWit.Text = score.getWit(yuko).ToString();
            lblYukoWit.Font = mainScreenStandardFont;
            lblYukoWit.BackColor = wit;

            lblWazariWit.Text = score.getWit(wazari).ToString();
            lblWazariWit.Font = mainScreenStandardFont;
            lblWazariWit.BackColor = wit;

            lblIpponWit.Text = score.getWit(ippon).ToString();
            lblIpponWit.Font = mainScreenStandardFont;
            lblIpponWit.BackColor = wit;

            lblShidoWit.Text = score.getWit(shido).ToString();
            lblShidoWit.Font = mainScreenStandardFont;
            lblShidoWit.BackColor = wit;

            lblHoldingWit.Text = score.holdingWit.ToString();
            lblHoldingWit.Font = mainScreenStandardFont;
            lblHoldingWit.BackColor = grijs;

            lblConfirmWit1.Text = score.confirmWit1.ToString();
            lblConfirmWit1.Font = mainScreenKleinFont;
            lblConfirmWit1.BackColor = grijs;
            lblConfirmWit1.Visible = false;

            lblConfirmWit2.Text = score.confirmWit2.ToString();
            lblConfirmWit2.Font = mainScreenKleinFont;
            lblConfirmWit2.BackColor = grijs;
            lblConfirmWit2.Visible = false;

            lblConfirmWit3.Text = score.confirmWit3.ToString();
            lblConfirmWit3.Font = mainScreenKleinFont;
            lblConfirmWit3.BackColor = grijs;
            lblConfirmWit3.Visible = false;

            lblIpponTextWit.Font = mainScreenKleinFont;
            lblIpponTextWit.BackColor = grijs;
            lblWazariTextWit.Font = mainScreenKleinFont;
            lblWazariTextWit.BackColor = grijs;
            lblYukoTextWit.Font = mainScreenKleinFont;
            lblYukoTextWit.BackColor = grijs;
            lblShidoTextWit.Font = mainScreenKleinFont;
            lblShidoTextWit.BackColor = grijs;



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
                lblconfirmRood1.Visible = true;
                voorkant.lblConfirmRood1.Visible = true;
            }
            else
            {
                lblconfirmRood1.Visible = false;
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

            lblconfirmRood1.Text = score.confirmRood1.ToString();
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

            lblShidoWit.Enabled = false;
            lblShidoRood.Enabled = false;
            lblIpponRood.Enabled = false;
            lblIpponWit.Enabled = false;
            lblWazariRood.Enabled = false;
            lblWazariWit.Enabled = false;
            lblYukoRood.Enabled = false;
            lblYukoWit.Enabled = false;
            btChangeHolding.Visible = false;

            lblHoldingWit.Visible = false;
            lblHoldingRood.Visible = false;
            voorkant.lblHoldingRood.Visible = false;
            voorkant.lblHoldingWit.Visible = false;
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
        }

        /**
        *This changes the visual while the time is ticking (you can't change time then, but you can start other timers)/When timer is on pause.
        */
        public void timeIsTicking()
        {
            cbTijd.Enabled = false;
            btRestart.Enabled = false;

            lblHoldingWit.Visible = true;
            lblHoldingRood.Visible = true;
           

        }

        public void timeIsPause()
        {
            cbTijd.Enabled = true;
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

            lblWazariRood.BackColor = rood;
            lblShidoRood.BackColor = rood;
            lblIpponRood.BackColor = rood;
            lblYukoRood.BackColor = rood;
            voorkant.lblYukoRood.BackColor = rood;
            voorkant.lblWazariRood.BackColor = rood;
            voorkant.lblIpponRood.BackColor = rood;
            voorkant.lblShidoRood.BackColor = rood;

            lblHoldingRood.BackColor = grijs;
            lblHoldingWit.BackColor = grijs;
            voorkant.lblHoldingWit.BackColor = grijs;
            voorkant.lblHoldingRood.BackColor = grijs;

            lblYukoWit.BackColor = wit;
            lblWazariWit.BackColor = wit;
            lblIpponWit.BackColor = wit;
            lblShidoWit.BackColor = wit;
            voorkant.lblYukoWit.BackColor = wit;
            voorkant.lblWazariWit.BackColor = wit;
            voorkant.lblIpponWit.BackColor = wit;
            voorkant.lblShidoWit.BackColor = wit;
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
            cbTijd.Enabled = true;            

            lblHoldingRood.Visible = false;
            lblHoldingWit.Visible = false;
            voorkant.lblHoldingWit.Visible = false;
            voorkant.lblHoldingRood.Visible = false;
            lblconfirmRood1.Visible = false;
            lblConfirmRood2.Visible = false;
            lblConfirmRood3.Visible = false;
            btChangeHolding.Visible = false;
            lblHoldingRood.Enabled = true;
            lblHoldingWit.Enabled = true;
            lblTimeSeperate.Enabled = true;
            lblMin.Enabled = true;
            lblSec.Enabled = true;
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
            lblShidoWit.BackColor = rood;
            lblYukoWit.BackColor = rood;
            lblIpponWit.BackColor = rood;
            lblWazariWit.BackColor = rood;
            lblHoldingWit.BackColor = rood;
            lblHoldingRood.BackColor = rood;

            this.BackColor = rood;
            voorkant.BackColor = rood;

            voorkant.lblWazariWit.BackColor = rood;
            voorkant.lblYukoWit.BackColor = rood;
            voorkant.lblIpponWit.BackColor = rood;
            voorkant.lblShidoWit.BackColor = rood;
            voorkant.lblHoldingRood.BackColor = rood;
            voorkant.lblHoldingWit.BackColor = rood;
        }

        public void colorWhite()
        {
            lblShidoRood.BackColor = wit;
            lblYukoRood.BackColor = wit;
            lblWazariRood.BackColor = wit;
            lblIpponRood.BackColor = wit;
            lblHoldingWit.BackColor = wit;
            lblHoldingRood.BackColor = wit;

            this.BackColor = wit;
            voorkant.BackColor = wit;

            voorkant.lblIpponRood.BackColor = wit;
            voorkant.lblWazariRood.BackColor = wit;
            voorkant.lblYukoRood.BackColor = wit;
            voorkant.lblShidoRood.BackColor = wit;
            voorkant.lblHoldingRood.BackColor = wit;
            voorkant.lblHoldingWit.BackColor = wit;
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
            if(cbTijd.Checked)
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
                lblHoldingWit.Visible = false;
                lblSec.Enabled = false;
                lblMin.Enabled = false;
                lblTimeSeperate.Enabled = false;
                btChangeHolding.Visible = true;
                voorkant.lblHoldingRood.Visible = true;
            }
            else
            {
                tmrHolding.Enabled = false;
                lblHoldingWit.Visible = true;
                lblSec.Enabled = true;
                lblMin.Enabled = true;
                lblTimeSeperate.Enabled = true;
                btChangeHolding.Visible = false;
                voorkant.lblHoldingRood.Visible = false;
                if(score.confirmRood1 == 0)
                {
                    score.confirmRood1 = score.holdingRood;
                    lblconfirmRood1.Visible = true;
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
                lblSec.Enabled = false;
                lblMin.Enabled = false;
                lblTimeSeperate.Enabled = false;
                btChangeHolding.Visible = true;
                voorkant.lblHoldingWit.Visible = true;
            }
            else
            {
                tmrHolding.Enabled = false;
                lblHoldingRood.Visible = true;
                lblSec.Enabled = true;
                lblMin.Enabled = true;
                lblTimeSeperate.Enabled = true;
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
    }
}
