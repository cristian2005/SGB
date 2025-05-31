namespace Presentacion
{
    partial class FrmInicio
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
            BtnNuevoU = new Button();
            BtnBuscarU = new Button();
            SuspendLayout();
            // 
            // BtnNuevoU
            // 
            BtnNuevoU.Location = new Point(63, 12);
            BtnNuevoU.Name = "BtnNuevoU";
            BtnNuevoU.Size = new Size(119, 32);
            BtnNuevoU.TabIndex = 0;
            BtnNuevoU.Text = "Nuevo usuario";
            BtnNuevoU.UseVisualStyleBackColor = true;
            BtnNuevoU.Click += BtnNuevoU_Click;
            // 
            // BtnBuscarU
            // 
            BtnBuscarU.Location = new Point(63, 54);
            BtnBuscarU.Name = "BtnBuscarU";
            BtnBuscarU.Size = new Size(119, 32);
            BtnBuscarU.TabIndex = 1;
            BtnBuscarU.Text = "Buscar usuario";
            BtnBuscarU.UseVisualStyleBackColor = true;
            BtnBuscarU.Click += BtnBuscarU_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBuscarU);
            Controls.Add(BtnNuevoU);
            Name = "FrmInicio";
            Text = "Gestion Biblioteca";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnNuevoU;
        private Button BtnBuscarU;
    }
}
