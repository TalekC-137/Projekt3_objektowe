namespace Projekt3_Talkiewicz_61184
{
    partial class kokpitNr3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_figury = new System.Windows.Forms.Button();
            this.btn_bryły = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_figury
            // 
            this.btn_figury.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_figury.Location = new System.Drawing.Point(66, 161);
            this.btn_figury.Name = "btn_figury";
            this.btn_figury.Size = new System.Drawing.Size(322, 120);
            this.btn_figury.TabIndex = 0;
            this.btn_figury.Text = "Prezentacja Figur Geometrycznych";
            this.btn_figury.UseVisualStyleBackColor = true;
            this.btn_figury.Click += new System.EventHandler(this.btn_figury_Click);
            // 
            // btn_bryły
            // 
            this.btn_bryły.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bryły.Location = new System.Drawing.Point(453, 161);
            this.btn_bryły.Name = "btn_bryły";
            this.btn_bryły.Size = new System.Drawing.Size(322, 120);
            this.btn_bryły.TabIndex = 1;
            this.btn_bryły.Text = "Prezentacja Brył";
            this.btn_bryły.UseVisualStyleBackColor = true;
            this.btn_bryły.Click += new System.EventHandler(this.btn_bryły_Click);
            // 
            // kokpitNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 486);
            this.Controls.Add(this.btn_bryły);
            this.Controls.Add(this.btn_figury);
            this.Name = "kokpitNr3";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_figury;
        private Button btn_bryły;
    }
}