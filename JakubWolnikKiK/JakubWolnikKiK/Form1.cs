using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubWolnikKiK
{
    public partial class Form1 : Form
    {
        bool enablePvPC = false;

        bool isGameEnded = true;

        int gameModeValue = 0;

        bool kolkoLubKrzy = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (A1.Text != "x" && A1.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                A1.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }
                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }

        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (A2.Text != "x" && A2.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                A2.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }

        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3.Text != "x" && A3.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                A3.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.Text != "x" && B1.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                B1.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        private void B2_Click(object sender, EventArgs e )
        {
            if (B2.Text != "x" && B2.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                B2.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (B3.Text != "x" && B3.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                B3.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (C1.Text != "x" && C1.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                C1.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (C2.Text != "x" && C2.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                C2.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (C3.Text != "x" && C3.Text != "o" && isGameEnded == false)
            {
                var instancja = new MechanizmGry(this);
                C3.Text = instancja.KoloLubKrzyzyk(kolkoLubKrzy);
                kolkoLubKrzy = !kolkoLubKrzy;
                instancja.PcOpponentScript(enablePvPC, kolkoLubKrzy);
                if (enablePvPC == true)
                {
                    kolkoLubKrzy = !kolkoLubKrzy;
                }

                if (instancja.CzyWygrana() != false)
                {
                    
                    isGameEnded = true;
                    gameModeValue = 0;
                    enablePvPC = false;
                }
                instancja.CzyWygrana();
            }
        }

        public string A1_Text
        {
            get { return A1.Text; }
            set { A1.Text = value;  }
        }
        public string A2_Text
        {
            get { return A2.Text; }
            set { A2.Text = value; }
        }
        public string A3_Text
        {
            get { return A3.Text; }
            set { A3.Text = value; }
        }
        public string B1_Text
        {
            get { return B1.Text; }
            set { B1.Text = value; }
        }
        public string B2_Text
        {
            get { return B2.Text; }
            set { B2.Text = value; }
        }
        public string B3_Text
        {
            get { return B3.Text; }
            set { B3.Text = value; }
        }
        public string C1_Text
        {
            get { return C1.Text; }
            set { C1.Text = value; }
        }
        public string C2_Text
        {
            get { return C2.Text; }
            set { C2.Text = value; }
        }
        public string C3_Text
        {
            get { return C3.Text; }
            set { C3.Text = value; }
        }

        private void pvp_Click(object sender, EventArgs e)
        {
            gameModeValue = 1;
        }

        private void pvpc_Click(object sender, EventArgs e)
        {
            gameModeValue = 2;
            //MessageBox.Show("W trakcie tworzenia");
        }

        private void strart_Click(object sender, EventArgs e)
        {
            if (gameModeValue == 1)
            {
                isGameEnded = false;
                enablePvPC = false;
                A1_Text = "";
                A2_Text = "";
                A3_Text = "";
                B1_Text = "";
                B2_Text = "";
                B3_Text = "";
                C1_Text = "";
                C2_Text = "";
                C3_Text = "";
                MessageBox.Show("Wybrano PvP");
            } else if (gameModeValue == 0)
            {
                MessageBox.Show("Wybierz tryb gry");
            } else if (gameModeValue == 2)
            {
                isGameEnded = false;
                enablePvPC = true;
                A1_Text = "";
                A2_Text = "";
                A3_Text = "";
                B1_Text = "";
                B2_Text = "";
                B3_Text = "";
                C1_Text = "";
                C2_Text = "";
                C3_Text = "";
                MessageBox.Show("Wybrano PvPC");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            A1_Text = "";
            A2_Text = "";
            A3_Text = "";
            B1_Text = "";
            B2_Text = "";
            B3_Text = "";
            C1_Text = "";
            C2_Text = "";
            C3_Text = "";
            isGameEnded = true;
            gameModeValue = 0;

        }

       
    }
}
