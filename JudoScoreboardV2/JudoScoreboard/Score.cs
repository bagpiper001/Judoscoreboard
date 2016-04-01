using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* The class Score holds the score for both red and white. 
* It contains methods to get, set and calculate the score.
* Because it holds the scores, it can also calculate a winner.
*/

namespace JudoScoreboard
{
    class Score
    {
        int yukorood;
        int wazarirood;
        int ipponrood;
        int shidorood;
        public int holdingRood;

        int yukowit;
        int wazariwit;
        int ipponwit;
        int shidowit;
        public int holdingWit;

        public String winnaar;
        public String rood = "rood";
        public String wit = "wit";
        String gelijk = "gelijk";

        //to confirm scores
        public int confirmRood1;
        public int confirmRood2;
        public int confirmRood3;

        public int confirmWit1;
        public int confirmWit2;
        public int confirmWit3;

        public int houdgreepYuko = 10;
        public int houdgreepWazari = 15;
        public int houdgreepIppon = 20;

        //default values for the scores.
        public void setDefault()
        {
            yukorood = 0;
            wazarirood = 0;
            ipponrood = 0;
            shidorood = 0;
            holdingRood = 0;

            yukowit = 0;
            wazariwit = 0;
            ipponwit = 0;
            shidowit = 0;
            holdingWit = 0;

            confirmRood1 = 0;
            confirmWit1 = 0;
            confirmRood2 = 0;
            confirmWit2 = 0;
            confirmRood3 = 0;
            confirmWit3 = 0;
        }

        //Get all red values
        public int getRood(String score)
        {
            switch(score)
            {
                case "yuko":
                    return yukorood;
                case "wazari":
                    return wazarirood;
                case "ippon":
                    return ipponrood;
                case "shido":
                    return shidorood;
                default:
                    return 0;
            }
                
        }

        //get all white values
        public int getWit(String score)
        {
            switch (score)
            {
                case "yuko":
                    return yukowit;
                case "wazari":
                    return wazariwit;
                case "ippon":
                    return ipponwit;
                case "shido":
                    return shidowit;
                default:
                    return 0;
            }
        }
        /**
        *Setters for scores
        *@variable add => if true, score will be added, if not, score will be removed if above 0.
        *@variable color => String given with color, red will update red, white will update white.
        */
        public void setYuko(bool add, String color)
        {
            if(color == rood)
            {
                if (add)
                {
                    yukorood += 1;
                }
                else
                {
                    if (yukorood > 0)
                    {
                        yukorood -= 1;
                    }
                }
            }
            else
            {
                if(add)
                {
                    yukowit += 1;
                }
                else
                {
                    if(yukowit > 0)
                    {
                        yukowit -= 1;
                    }
                }
            }
        }

        public void setWazari(bool add, String color)
        {
            if (color == rood)
            {
                if (add)
                {
                    wazarirood += 1;
                }
                else
                {
                    if (wazarirood != 0)
                    {
                        wazarirood -= 1;
                    }

                }
            }
            else
            {
                if(add)
                {
                    wazariwit += 1;
                }
                else
                {
                    if(wazariwit != 0)
                    {
                        wazariwit -= 1;
                    }
                }
            }
        }

        public void setIppon(bool add, String color)
        {
            if(color == rood)
            {
                if(add)
                {
                    ipponrood += 1;
                }
                else
                {
                    if(ipponrood > 0)
                    {
                        ipponrood -= 1;
                    }
                }
            }
            else
            {
                if(add)
                {
                    ipponwit += 1;
                }
                else
                {
                    if(ipponwit > 0)
                    {
                        ipponwit -= 1;
                    }
                }
            }
        }

        public void setShido(bool add, String color)
        {
            if(color == rood)
            {
                if (add)
                {
                    shidorood += 1;
                }
                else
                {
                    if(shidorood > 0)
                    {
                        shidorood -= 1;
                    }
                }
            }
            else
            {
                if(add)
                {
                    shidowit += 1;
                }
                else
                {
                    if(shidowit > 0)
                    {
                        shidowit -= 1;
                    }
                }
            }
        }

        //During a match, there can be a winner at certain times, these methods will decide if so.
        public bool getWinnaarRood()
        {
            if(wazarirood >= 2)
            {
                return true;
            }
            if(ipponrood >= 1)
            {
                return true;
            }
            if(shidowit >= 4)
            {
                return true;
            }
            return false;
        }

        public bool getWinnaarWit()
        {
            if(wazariwit >= 2)
            {
                return true;
            }
            if(ipponwit >= 1)
            {
                return true;
            }
            if(shidorood >= 4)
            {
                return true;
            }
            return false;

        }

        //In the end there will always be a winner, or a draw.
        public String berekenWinnaar()
        {
            if(wazarirood > wazariwit)
            {
                //rood
                winnaar = rood;
                return rood + " wint met Wazari en krijgt 7 punten.";
            }
            else
            {
                if(wazariwit > wazarirood)
                {
                    //wit
                    winnaar = wit;
                    return wit + " wint met Wazari en krijgt 7 punten.";
                }
                else
                {
                    if(yukorood > yukowit)
                    {
                        //rood
                        winnaar = rood;
                        return rood + " wint met Yuko en krijgt 5 punten.";
                    }
                    else
                    {
                        if(yukowit > yukorood)
                        {
                            //wit
                            winnaar = wit;
                            return wit + " wint met Yuko en krijgt 5 punten.";
                        }
                        else
                        {
                            if(shidorood > shidowit)
                            {
                                //wit
                                winnaar = wit;
                                return wit + " wint op shido's en krijgt 1 punt.";
                            }
                            else
                            {
                                if(shidowit > shidorood)
                                {
                                    //rood
                                    winnaar = rood;
                                    return rood + " wint op shido's en krijgt 1 punt.";
                                }
                                else
                                {
                                    //gelijk
                                    winnaar = gelijk;
                                    return "De score is gelijk, de winnaar wordt aangewezen door de scheidsrechter en krijgt 1 punt, of er komt een Golden Score.";
                                }
                            }
                        }
                    }
                }
            }
        }

        /**
        *Method to confirm scores of holding, needs to be given by referee.
        *@variable nr => You can hold up to 3 holdings before confirming them, the nr will make sure you add them one by one.
        */
        public bool confirmScoreRood(int nr)
        {
            if(nr == 1)
            {
                if(confirmRood1 < houdgreepYuko)
                {
                    confirmRood1 = 0;
                    return false;
                }
                else
                {
                    if(confirmRood1 < houdgreepWazari)
                    {
                        setYuko(true, rood);
                        confirmRood1 = 0;
                        return false;
                    }
                    else
                    {
                        setWazari(true, rood);
                        confirmRood1 = 0;
                        if (getWinnaarRood())
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            else
            {
                if(nr == 2)
                {
                    if(confirmRood2 < houdgreepYuko)
                    {
                        confirmRood2 = 0;
                        return false;
                    }
                    else
                    {
                        if(confirmRood2 < houdgreepWazari)
                        {
                            setYuko(true, rood);
                            confirmRood2 = 0;
                            return false;
                        }
                        else
                        {
                            setWazari(true, rood);
                            confirmRood2 = 0;
                            if (getWinnaarRood())
                                return true;
                            else
                                return false;
                        }
                    }
                }
                else
                {
                    if(confirmRood3 < houdgreepYuko)
                    {
                        confirmRood3 = 0;
                        return false;
                    }
                    else
                    {
                        if(confirmRood3 < houdgreepWazari)
                        {
                            setYuko(true, rood);
                            confirmRood3 = 0;
                            return false;
                        }
                        else
                        {
                            setWazari(true, rood);
                            confirmRood3 = 0;
                            if (getWinnaarRood())
                                return true;
                            else
                                return false;

                        }
                    }
                }
            }
        }

        public bool confirmScoreWit(int nr)
        {
            if(nr == 1)
            {
                if(confirmWit1 < houdgreepYuko)
                {
                    confirmWit1 = 0;
                    return false;
                }
                else
                {
                    if(confirmWit1 < houdgreepWazari)
                    {
                        setYuko(true, wit);
                        confirmWit1 = 0;
                        return false;
                    }
                    else
                    {
                        setWazari(true, wit);
                        confirmWit1 = 0;
                        if (getWinnaarWit())
                            return true;
                        else
                            return false;

                    }
                }
            }
            else
            {
                if(nr == 2)
                {
                    if(confirmWit2 < houdgreepYuko)
                    {
                        confirmWit2 = 0;
                        return false;
                    }
                    else
                    {
                        if(confirmWit2 < houdgreepWazari)
                        {
                            setYuko(true, wit);
                            confirmWit2 = 0;
                            return false;
                        }
                        else
                        {
                            setWazari(true, wit);
                            confirmWit2 = 0;
                            if (getWinnaarWit())
                                return true;
                            else
                                return false;
                        }
                    }
                }
                else
                {
                    if(confirmWit3 < houdgreepYuko)
                    {
                        confirmWit3 = 0;
                        return false;
                    }
                    else
                    {
                        if(confirmWit3 < houdgreepWazari)
                        {
                            setYuko(true, wit);
                            confirmWit3 = 0;
                            return false;
                        }
                        else
                        {
                            setWazari(true, wit);
                            confirmWit3 = 0;
                            if (getWinnaarWit())
                                return true;
                            else
                                return false;
                        }
                    }
                }
            }
        }
    }
}
