using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Projekt3_Talkiewicz_61184.FiguryGeometryczne;

namespace Projekt3_Talkiewicz_61184 
{
    public partial class PrezentacjaFigurGeometrycznych : Form 
    {

        Graphics rysownica; 

        Punkt[] TFG;
        int IndexTFG = 0;

        const int MarginesFormularza = 16;



        public PrezentacjaFigurGeometrycznych()
        {
            InitializeComponent();


            this.Left = MarginesFormularza;

            this.Width = (int) (Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);


            lbl_n.Location = new Point(this.Left + MarginesFormularza, this.Top + 2* MarginesFormularza);

            pb_rysownica.Location = new Point(lbl_n.Location.X + lbl_n.Width + MarginesFormularza, lbl_n.Location.Y);


            pb_rysownica.Image = new Bitmap(pb_rysownica.Width, pb_rysownica.Height);
            rysownica = Graphics.FromImage(pb_rysownica.Image);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            ushort N;

            const int margines = 20;

           errorProvider1.Dispose();

            //errors
            if (!ushort.TryParse(txt_N.Text, out N) || N <=0) {
                errorProvider1.SetError(txt_N, "ERROR: liczba wybranych figur musi być > 0");
                return;
            }
            //correct
            txt_N.Enabled= false;

            TFG = new Punkt[N];

            IndexTFG= 0;

            if(clb_figury.CheckedItems.Count<=0) {
                errorProvider1.SetError(clb_figury, "ERROR: liczba wybranych figur musi być > 0");
                return;
            } 
            clb_figury.Enabled = false;
            btn_start.Enabled = false;

            CheckedListBox.CheckedItemCollection zanaczoneFigury = clb_figury.CheckedItems;

            int xMax = pb_rysownica.Width;
            int yMax = pb_rysownica.Height;

            int Xp, Yp;
            Color KolorLinii, KolorWypelnienia;
            float gruboscLinii;
            DashStyle stylLinii;

            for (int i = 0; i < N; i++) { 
            
                Xp = rand.Next(margines, xMax- margines);
                Yp = rand.Next(margines, yMax - margines);

                KolorLinii = Color.FromArgb(rand.Next(0,255),
                    rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

                KolorWypelnienia = Color.FromArgb(rand.Next(0, 255),
                  rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));


                gruboscLinii = rand.Next(1, 10);
                //random line style
                switch (rand.Next(1, 6)) {
                    case 1: stylLinii = DashStyle.Dash;
                        break;
                    case 2:
                        stylLinii = DashStyle.Dot;
                        break;
                    case 3:
                        stylLinii = DashStyle.Solid;
                        break;
                    case 4:
                        stylLinii = DashStyle.DashDotDot;
                        break;
                    case 5:
                        stylLinii = DashStyle.DashDot;
                        break;
                    default:
                        stylLinii = DashStyle.Solid;
                        break;

                }
                //random shape
                int wylosowanaFigura = rand.Next(zanaczoneFigury.Count);
                switch (zanaczoneFigury[wylosowanaFigura].ToString())
                {
                    case "Punkt":
                        TFG[IndexTFG] = new Punkt(Xp, Yp);
                        TFG[IndexTFG].Wykresl(rysownica);
                        IndexTFG++;
                        break;
                    case "Linia":

                        int Xk = rand.Next(margines, xMax - margines);
                        int Yk = rand.Next(margines, yMax - margines);

                        TFG[IndexTFG] = new Linia(Xp, Yp, Xk, Yk);
                        TFG[IndexTFG].Wykresl(rysownica);
                        IndexTFG++;
                        break;
                    case "Elipsa":

                        int osDuza = rand.Next(margines, (xMax - margines) / 2);
                        int osMala = rand.Next(margines, (yMax - margines) / 2);


                        TFG[IndexTFG] = new Elipsa(Xp, Yp, osDuza, osMala);
                        TFG[IndexTFG].Wykresl(rysownica);
                        IndexTFG++;
                        break;
                    case "Okrąg":
                        int R = rand.Next(margines, (yMax - margines) / 2);
                        TFG[IndexTFG] = new Okrag(Xp, Yp, R);
                        TFG[IndexTFG].Wykresl(rysownica);
                        IndexTFG++;
                        break;

                    default:
                        MessageBox.Show("nad tą figurą teraz pracuję");
                        break;
                }
            }
            pb_rysownica.Refresh();
        }
    }
}
