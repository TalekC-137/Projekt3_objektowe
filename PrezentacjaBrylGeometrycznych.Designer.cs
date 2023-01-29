namespace Projekt3_Talkiewicz_61184
{
    partial class PrezentacjaBrylGeometrycznych
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
            this.btn_figury = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_figury
            // 
            this.btn_figury.Location = new System.Drawing.Point(72, 171);
            this.btn_figury.Name = "btn_figury";
            this.btn_figury.Size = new System.Drawing.Size(248, 82);
            this.btn_figury.TabIndex = 0;
            this.btn_figury.Text = "button1";
            this.btn_figury.UseVisualStyleBackColor = true;
            // 
            // PrezentacjaBrylGeometrycznych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_figury);
            this.Name = "PrezentacjaBrylGeometrycznych";
            this.Text = "PrezentacjaBrylGeometrycznych";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_figury;
    }
}