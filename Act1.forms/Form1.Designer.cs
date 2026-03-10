namespace Act1.forms
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
            components = new System.ComponentModel.Container();
            txt1 = new TextBox();
            txt2 = new TextBox();
            validar = new Button();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(262, 68);
            txt1.Name = "txt1";
            txt1.Size = new Size(180, 23);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Location = new Point(262, 148);
            txt2.Name = "txt2";
            txt2.Size = new Size(180, 23);
            txt2.TabIndex = 1;
            // 
            // validar
            // 
            validar.Location = new Point(287, 222);
            validar.Name = "validar";
            validar.Size = new Size(111, 31);
            validar.TabIndex = 2;
            validar.Text = "VALIDAR";
            validar.UseVisualStyleBackColor = true;
            validar.Click += validar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 71);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresa la contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 151);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingresa nuevamente la contraseña:";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 50;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
            toolTip1.Tag = "";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 285);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(validar);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "VALIDADOR DE CONTRASEÑAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private Button validar;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
    }
}
