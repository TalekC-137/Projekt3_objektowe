using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Talkiewicz_61184
{
    internal class FiguryGeometryczne
    {

        public class Punkt
        {
            protected const int RozmiarPunktu = 20;
            protected int x, y;
            protected float GruboscLinii;
            protected Color KolorLinii;
            protected Color KolorWypelnienia;
            protected DashStyle StylLinii;
            protected bool Widocznosc;

            public Punkt(int x, int y)
            {
                this.x = x;
                this.y = y;

                GruboscLinii = 1f;
                KolorLinii = Color.Black;
                KolorWypelnienia = Color.Yellow;
                StylLinii = DashStyle.Solid;
                Widocznosc = false;
            }

            public Punkt(int x, int y, Color KolorLinii)
            {
                this.x = x;
                this.y = y;
                this.KolorLinii = KolorLinii;

                GruboscLinii = 1f;
                KolorLinii = Color.Black;
                KolorWypelnienia = Color.Yellow;
                StylLinii = DashStyle.Solid;
                Widocznosc = false;

            }

            private void UaktualnijXY(int x, int y) {
                this.x = x;
                this.y = y;

            }

            public void PrzesunDoNowegoXY(Control Kotrolka, Graphics Rysownica, int x, int y)
            {
                UaktualnijXY(x, y);
                //redrawing  with updated params
                Wykresl(Rysownica);

            }

            public virtual void Wykresl(Graphics rysownica)
            {
                /*
                SolidBrush brush= new SolidBrush(KolorLinii);

                rysownica.FillEllipse(brush, x-RozmiarPunktu/2,
                    y-RozmiarPunktu/2, RozmiarPunktu,RozmiarPunktu);

                Widocznosc = true;

                //bursh memory release
                
                brush.Dispose();
                */

                // same but better: using instruction "using"

                using (SolidBrush brush = new SolidBrush(KolorLinii))
                {
                    rysownica.FillEllipse(brush, x - RozmiarPunktu / 2,
                       y - RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);

                    Widocznosc = true;
                }

            }

            public virtual void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widocznosc) {
                    using (SolidBrush brush = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(brush, x - RozmiarPunktu / 2,
                           y - RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);

                        Widocznosc = false;
                    }

                }

            }


        }//koniec klasy punkt


        public class Linia : Punkt
        {
            int xk, yk;

            public Linia(int xp, int yp, int xk, int yk) : base(xp, yp)
            {
                this.xk = xk;
                this.yk = yk;

            }
            public Linia(int xp, int yp, int xk, int yk, Color kolorLinii,
                float gruboscLinii, DashStyle StylLinii) : base(xp, yp, kolorLinii)
            {
                this.xk = xk;
                this.yk = yk;
                this.GruboscLinii= gruboscLinii;
                this.StylLinii = StylLinii;
            }

            //overriting virtul methids from class punkt

            public override void Wykresl(Graphics rysownica)
            {
                using(Pen pen = new Pen(KolorLinii, GruboscLinii)) 
                {
                    pen.DashStyle = StylLinii;

                    rysownica.DrawLine(pen, x, y, xk, yk);

                    Widocznosc = true;
                
                }


            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawLine(pen, x, y, xk, yk);

                    Widocznosc = false;

                }


            }
                
        }// koniec linii

        public class Elipsa : Punkt
        {

            protected int OsDuza, OsMala;


            public Elipsa(int x, int y, int OsDuza, int OsMala) : base(x, y)
            {
                this.OsDuza = OsDuza;
                this.OsMala = OsMala;

            }

            public override void Wykresl(Graphics rysownica)
            {

            
                using (Pen pen = new Pen(KolorLinii, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    rysownica.DrawEllipse(pen, x - OsDuza / 2, y - OsMala / 2, OsDuza, OsMala);

                    Widocznosc = true;

                }


 
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using (Pen pen = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    pen.DashStyle = StylLinii;

                    Rysownica.DrawEllipse(pen, x - OsDuza / 2, y - OsMala / 2, OsDuza, OsMala);

                    Widocznosc = false;

                }


            }


        }// koniec elipsy

        public class Okrag : Elipsa
        {

            protected int promienokregu;

            public Okrag(int x, int y, int r): base(x, y, 2*r, 2*r)
            {
                promienokregu = r;

            }



        }// koniec okręgu
    }
}
