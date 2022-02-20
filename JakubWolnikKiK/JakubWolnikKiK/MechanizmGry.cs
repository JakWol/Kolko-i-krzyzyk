using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubWolnikKiK
{
    class MechanizmGry
    {
        Form1 accesForm;
        public MechanizmGry(Form1 form)
        {
            accesForm = form;
        }
        

        public string KoloLubKrzyzyk(bool koLuKrz)
        {
            if (koLuKrz == true)
            {
                return "x";
                
            }
            else
                return "o";

        }
        public bool CzyWygrana()
        {
            
            if (accesForm.A1_Text == accesForm.A2_Text && accesForm.A2_Text == accesForm.A3_Text && accesForm.A1_Text !="" && accesForm.A2_Text !="" && accesForm.A3_Text!= "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.A3_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            }else
            if  (accesForm.B1_Text == accesForm.B2_Text && accesForm.B2_Text == accesForm.B3_Text && accesForm.B1_Text != "" && accesForm.B2_Text != "" && accesForm.B3_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.B3_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            }else
            if  (accesForm.C1_Text == accesForm.C2_Text && accesForm.C2_Text == accesForm.C3_Text && accesForm.C1_Text != "" && accesForm.C2_Text != "" && accesForm.C3_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C3_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            }else
            if  (accesForm.A1_Text == accesForm.B1_Text && accesForm.B1_Text == accesForm.C1_Text && accesForm.C1_Text != "" && accesForm.B1_Text != "" && accesForm.A1_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C1_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            }else
            if  (accesForm.A2_Text == accesForm.B2_Text && accesForm.B2_Text == accesForm.C2_Text && accesForm.C2_Text != "" && accesForm.B2_Text != "" && accesForm.A2_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C2_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            }else
            if  (accesForm.A3_Text == accesForm.B3_Text && accesForm.B3_Text == accesForm.C3_Text && accesForm.C3_Text != "" && accesForm.B3_Text != "" && accesForm.A3_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C3_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            } else
            if (accesForm.A3_Text == accesForm.B3_Text && accesForm.B3_Text == accesForm.C3_Text && accesForm.C3_Text != "" && accesForm.B3_Text != "" && accesForm.A3_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C3_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            } else
            if (accesForm.A1_Text == accesForm.B2_Text && accesForm.B2_Text == accesForm.C3_Text && accesForm.C3_Text != "" && accesForm.B2_Text != "" && accesForm.A1_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C3_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            }else 
            if (accesForm.C1_Text == accesForm.B2_Text && accesForm.B2_Text == accesForm.A3_Text && accesForm.C1_Text != "" && accesForm.B2_Text != "" && accesForm.A3_Text != "")
            {
                MessageBox.Show("Gracz grajacy: " + accesForm.C1_Text + " wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            } else if (accesForm.A1_Text != "" && accesForm.A2_Text != "" && accesForm.A3_Text != ""&&accesForm.B1_Text != ""&&accesForm.B2_Text != ""&&accesForm.B3_Text != ""&&accesForm.C1_Text != ""&&accesForm.C2_Text != ""&&accesForm.C3_Text != "")
            {
                MessageBox.Show("Nikt nie wygral");

                accesForm.A1_Text = "";
                accesForm.A2_Text = "";
                accesForm.A3_Text = "";
                accesForm.B1_Text = "";
                accesForm.B2_Text = "";
                accesForm.B3_Text = "";
                accesForm.C1_Text = "";
                accesForm.C2_Text = "";
                accesForm.C3_Text = "";
                return true;
            } else


            return false;
            
        }

        public void PcOpponentScript(bool enablePvPC, bool currentKolkoLubKrzyzyk)
        {
            if (enablePvPC == true)
            {
                string[,] tablicaPol = new string[,] { { accesForm.A1_Text, accesForm.A2_Text, accesForm.A3_Text }, { accesForm.B1_Text, accesForm.B2_Text, accesForm.B3_Text }, { accesForm.C1_Text, accesForm.C2_Text, accesForm.C3_Text } };
                
                

                var random = new Random();
                int randomRow = random.Next(0, 3);
                int randomColumn = random.Next(0, 3);



                while (tablicaPol[randomRow, randomColumn] != "")
                {
                    randomRow = random.Next(0, 3);
                    randomColumn = random.Next(0, 3);
                }

                if (accesForm.B2_Text == "")
                {
                    accesForm.B2_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                }



               
                  else if ((randomRow == 0 & randomColumn == 0) && tablicaPol[0, 0] != "x" && tablicaPol[0, 0] != "o")
                    {
                        accesForm.A1_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    } else if ((randomRow == 0 & randomColumn == 1) && tablicaPol[0, 1] != "x" && tablicaPol[0, 1] != "o")
                    {
                        accesForm.A2_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    }
                    else if ((randomRow == 0 & randomColumn == 2) && tablicaPol[0, 2] != "x" && tablicaPol[0, 2] != "o")
                    {
                        accesForm.A3_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    }
                    else if ((randomRow == 1 & randomColumn == 0) && tablicaPol[1, 0] != "x" && tablicaPol[1, 0] != "o")
                    {
                        accesForm.B1_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    }
                    else if ((randomRow == 1 & randomColumn == 1) && tablicaPol[1, 1] != "x" && tablicaPol[1, 1] != "o")
                    {
                        accesForm.B2_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);

                    }
                    else if ((randomRow == 1 & randomColumn == 2) && tablicaPol[1, 2] != "x" && tablicaPol[1, 2] != "o")
                    {
                        accesForm.B3_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    }
                    else if ((randomRow == 2 & randomColumn == 0) && tablicaPol[2, 0] != "x" && tablicaPol[2, 0] != "o")
                    {
                        accesForm.C1_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                       
                    }
                    else if ((randomRow == 2 & randomColumn == 1) && tablicaPol[2, 1] != "x" && tablicaPol[2, 1] != "o")
                    {
                        accesForm.C2_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    }
                    else if ((randomRow == 2 & randomColumn == 2) && tablicaPol[2, 2] != "x" && tablicaPol[2, 2] != "o")
                    {
                        accesForm.C3_Text = (string)KoloLubKrzyzyk(currentKolkoLubKrzyzyk);
                        
                    }

                

                MessageBox.Show("row " + randomRow + " col " + randomColumn);


            }

        }

        

        

        

    }
}
