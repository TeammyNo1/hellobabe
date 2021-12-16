namespace TemperatureCalulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConvert = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.Label();
            this.button1Convert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            resources.ApplyResources(this.buttonConvert, "buttonConvert");
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // C
            // 
            resources.ApplyResources(this.C, "C");
            this.C.Name = "C";
            this.C.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxC
            // 
            resources.ApplyResources(this.textBoxC, "textBoxC");
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxF
            // 
            resources.ApplyResources(this.textBoxF, "textBoxF");
            this.textBoxF.Name = "textBoxF";
            // 
            // F
            // 
            resources.ApplyResources(this.F, "F");
            this.F.Name = "F";
            // 
            // button1Convert
            // 
            resources.ApplyResources(this.button1Convert, "button1Convert");
            this.button1Convert.Name = "button1Convert";
            this.button1Convert.UseVisualStyleBackColor = true;
            this.button1Convert.Click += new System.EventHandler(this.button1Convert_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1Convert);
            this.Controls.Add(this.F);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.C);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConvert;
        private Label C;
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Label F;
        private Button button1Convert;
        private Button button1;
    }
}