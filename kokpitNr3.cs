namespace Projekt3_Talkiewicz_61184
{
    public partial class kokpitNr3 : Form
    {
        public kokpitNr3()
        {
            InitializeComponent();
        }

        private void btn_figury_Click(object sender, EventArgs e)
        {

            foreach (Form Formularz in Application.OpenForms) {

                if (Formularz.Name == "PrezentacjaFigurGeometrycznych") {

                    this.Hide();

                    Formularz.Show();

                    return;
                }

        
            }

            PrezentacjaFigurGeometrycznych FormularzPrezentacj = new PrezentacjaFigurGeometrycznych();
            Hide();
            FormularzPrezentacj.Show();


        }
    }
}