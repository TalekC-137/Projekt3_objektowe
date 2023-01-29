using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Talkiewicz_61184
{
    internal class pt_BrylyGeometryczne
    {

        public abstract class pt_BrylaAbstrakcyjna
        {
            public enum pt_TypBryly
            { 
                BG_Walec,
                BG_Stożek,
                BG_Kula,
                BG_ostrosłup,
                BG_Graniastosłup,
                BG_Kryształ,
                BG_Prostopadłościan
            }

            protected int pt_XsP, pt_YsP;
            protected int pt_GruboscLinii;
            protected Color pt_kolorLiniii;
            protected DashStyle pt_StylLinii;
            protected pt_TypBryly RodzajBryly;
            protected bool pt_KierunekObrotu;


            public int pt_WysokoscBryly
            {
                get;
                protected set;
            }

            public pt_BrylaAbstrakcyjna(int pt_GruboscLinii, Color pt_kolorLiniii, DashStyle pt_StylLinii)
            {
                this.pt_GruboscLinii = pt_GruboscLinii;
                this.pt_kolorLiniii = pt_kolorLiniii;
                this.pt_StylLinii = pt_StylLinii;
            }

            public abstract void Pt_wykresl(Graphics pt_Rysownica);
            public abstract void Pt_wymaż(Graphics pt_Rysownica, Control pt_kontrolka);

            public abstract void Pt_obroc_i_wykresl(Graphics pt_Rysownica, Control pt_kontrolka, float pt_katObrotu);

            public abstract void Pt_przesunDoNowegoXY(Graphics pt_Rysownica, Control pt_kontrolka, int pt_X, int pt_Y);

            public void Pt_UstawienieAtrybutowGraficznych(Color pt_kolorLiniii, DashStyle pt_StylLinii, int pt_GruboscLinii) 
            {
                this.pt_kolorLiniii = pt_kolorLiniii;
                this.pt_StylLinii = pt_StylLinii;
                this.pt_GruboscLinii = pt_GruboscLinii;


            }


        }// end of abstract

        public class Pt_BrylyObrotowe : pt_BrylaAbstrakcyjna
        {

            protected int pt_PromienBryly;


            public Pt_BrylyObrotowe(int pt_R, int pt_GruboscLinii, Color pt_kolorLiniii, DashStyle pt_StylLinii)
                : base(pt_GruboscLinii, pt_kolorLiniii, pt_StylLinii)
            {
                pt_PromienBryly = pt_R;
            }


            public override void Pt_obroc_i_wykresl(Graphics pt_Rysownica, Control pt_kontrolka, float pt_katObrotu)
            {
                
            }

            public override void Pt_przesunDoNowegoXY(Graphics pt_Rysownica, Control pt_kontrolka, int pt_X, int pt_Y)
            {
                
            }

            public override void Pt_wykresl(Graphics pt_Rysownica)
            {
                
            }

            public override void Pt_wymaż(Graphics pt_Rysownica, Control pt_kontrolka)
            {
                
            }
        }//rotating 

        public class Pt_Stożek : Pt_BrylyObrotowe
        {
            int pt_XsS, pt_YsS;
            int pt_stopienWielokątaPodstawy;
            float pt_OsDuza, pt_OsMala;

            double pt_katMiedzyWierzcholkami;
            double pt_katPolozenia;

            Point[] pt_WielokątPodstawy;

            public Pt_Stożek(int pt_R, int pt_GruboscLinii, int pt_wysykośćStożka, int pt_Xsp, int pt_YsP, int pt_stopienWielokątaPodstawy,
                 Color pt_kolorLiniii, DashStyle pt_StylLinii)
                : base(pt_R, pt_GruboscLinii, pt_kolorLiniii, pt_StylLinii)
            {
                RodzajBryly = pt_TypBryly.BG_Stożek;
                pt_WysokoscBryly = pt_wysykośćStożka;
                this.pt_stopienWielokątaPodstawy = pt_stopienWielokątaPodstawy;
                pt_OsDuza = pt_R * 2;
                pt_OsMala = pt_R / 2;

                pt_XsS = pt_XsP;
                pt_YsS = pt_YsP - pt_wysykośćStożka;
                pt_katMiedzyWierzcholkami = 360.0 / pt_stopienWielokątaPodstawy;

                pt_katPolozenia = 0.0;

                pt_WielokątPodstawy = new Point[pt_stopienWielokątaPodstawy + 1];

                for (int i = 0; i <= pt_stopienWielokątaPodstawy; i++)
                {
                    pt_WielokątPodstawy[i] = new Point();
                    pt_WielokątPodstawy[i].X = (int) (this.pt_XsP + pt_OsDuza / 2 *
                        Math.Cos(Math.PI * (pt_katPolozenia + i * pt_katMiedzyWierzcholkami)));

                    pt_WielokątPodstawy[i].Y = (int) (this.pt_YsP + pt_OsMala / 2 *
                        Math.Sin(Math.PI * (pt_katPolozenia + i * pt_katMiedzyWierzcholkami)));

                }
            }

            public override void Pt_wykresl(Graphics pt_Rysownica)
            {
                Pen pt_Pióro = new Pen(this.pt_kolorLiniii, this.pt_GruboscLinii); // might need to delete the "this"
                pt_Pióro.DashStyle = DashStyle.Solid;
                //wykreślenie podstawy
                pt_Rysownica.DrawEllipse(pt_Pióro, pt_XsP - pt_OsDuza / 2, pt_YsP - pt_OsMala / 2, pt_OsDuza, pt_OsMala);

                //more side lines

                using (Pen pióro = new Pen(Color.Blue, 1))
                {
                    for (int i = 0; i <= pt_stopienWielokątaPodstawy; i++)
                    {
                        pt_Rysownica.DrawLine(pióro, pt_WielokątPodstawy[i].X, pt_WielokątPodstawy[i].Y, pt_XsS, pt_YsS);

                    }

                }


                //wykreślenie krawędzi
                pt_Rysownica.DrawLine(pt_Pióro, pt_XsP - pt_OsDuza / 2, pt_YsP, pt_XsS, pt_YsS);
                pt_Rysownica.DrawLine(pt_Pióro, pt_XsP + pt_OsDuza / 2, pt_YsP, pt_XsS, pt_YsS);

                pt_Pióro.Dispose();

            }



            public override void Pt_wymaż(Graphics pt_Rysownica, Control pt_kontrolka)
            {

                Pen pt_Pióro = new Pen(pt_kontrolka.BackColor, this.pt_GruboscLinii);
                pt_Pióro.DashStyle = pt_StylLinii;
                //wykreślenie podstawy
                pt_Rysownica.DrawEllipse(pt_Pióro, pt_XsP - pt_OsDuza / 2, pt_YsP - pt_OsMala / 2, pt_OsDuza, pt_OsMala);

                //more side lines

                for (int i = 0; i <= pt_stopienWielokątaPodstawy; i++)
                {
                    pt_Rysownica.DrawLine(pt_Pióro, pt_WielokątPodstawy[i].X, pt_WielokątPodstawy[i].Y, pt_XsS, pt_YsS);

                }

                
                pt_Pióro.Dispose();

            }



        }





    }
}
