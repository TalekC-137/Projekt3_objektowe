using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt3_Talkiewicz_61184.pt_BrylyGeometryczne;

namespace Projekt3_Talkiewicz_61184
{
    public partial class PrezentacjaBrylGeometrycznych : Form
    {

        Graphics rysownica;

        int IndexTFG = 0;

        const int MarginesFormularza = 16;

        List<pt_BrylaAbstrakcyjna> LBG = new List<pt_BrylaAbstrakcyjna>();

        public PrezentacjaBrylGeometrycznych()
        {
            InitializeComponent();

            this.Left = MarginesFormularza;

            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);


            lbl_n.Location = new Point(this.Left + MarginesFormularza, this.Top + 2 * MarginesFormularza);

            pb_rysownica.Location = new Point(lbl_n.Location.X + lbl_n.Width + MarginesFormularza, lbl_n.Location.Y);


            pb_rysownica.Image = new Bitmap(pb_rysownica.Width, pb_rysownica.Height);
            rysownica = Graphics.FromImage(pb_rysownica.Image);

            timer1.Enabled = true;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrezentacjaBrylGeometrycznych_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //wymzanie, obócenie i wykreślenie wszystkich brył z listy LBG
            foreach (pt_BrylaAbstrakcyjna Bryła in LBG)
            {
            //    Bryła.Pt_obroc_i_wykresl(pb_rysownica, rysownica, 5f);
            }

        }
    }
}
