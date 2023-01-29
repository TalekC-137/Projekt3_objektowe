namespace Projekt3_Talkiewicz_61184
{
    partial class PrezentacjaFigurGeometrycznych
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clb_figury = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_rysownica = new System.Windows.Forms.PictureBox();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clb_figury
            // 
            this.clb_figury.FormattingEnabled = true;
            this.clb_figury.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg"});
            this.clb_figury.Location = new System.Drawing.Point(1018, 87);
            this.clb_figury.Name = "clb_figury";
            this.clb_figury.Size = new System.Drawing.Size(173, 114);
            this.clb_figury.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(978, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "zaznacz figury geometryczne\r\nktóre mają być wykreślone\r\n";
            // 
            // pb_rysownica
            // 
            this.pb_rysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rysownica.Location = new System.Drawing.Point(187, 87);
            this.pb_rysownica.Name = "pb_rysownica";
            this.pb_rysownica.Size = new System.Drawing.Size(779, 447);
            this.pb_rysownica.TabIndex = 2;
            this.pb_rysownica.TabStop = false;
            // 
            // txt_N
            // 
            this.txt_N.Location = new System.Drawing.Point(27, 87);
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(125, 27);
            this.txt_N.TabIndex = 3;
            this.txt_N.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(27, 138);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(125, 40);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "podaj liczbę figur\r\n do wykreśłenia";
            // 
            // PrezentacjaFigurGeometrycznych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.pb_rysownica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clb_figury);
            this.Name = "PrezentacjaFigurGeometrycznych";
            this.Text = "PrezentacjaFigurGeometrycznych";
            ((System.ComponentModel.ISupportInitialize)(this.pb_rysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox clb_figury;
        private Label label1;
        private PictureBox pb_rysownica;
        private TextBox txt_N;
        private Button btn_start;
        private ErrorProvider errorProvider1;
        private Label label2;
    }
}