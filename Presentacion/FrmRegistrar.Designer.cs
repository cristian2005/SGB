namespace Presentacion
{
    partial class FrmRegistrarUsuario
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
            LblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            BtnGuardarU = new Button();
            BtnDescartarU = new Button();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(145, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(232, 34);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Registrar nuevo lector";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 60);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 173);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Teléfono  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 1;
            label3.Text = "Correo    :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 229);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Dirección :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(456, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 138);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(456, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 191);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(456, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 247);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(456, 23);
            txtDireccion.TabIndex = 2;
            // 
            // BtnGuardarU
            // 
            BtnGuardarU.Location = new Point(302, 326);
            BtnGuardarU.Name = "BtnGuardarU";
            BtnGuardarU.Size = new Size(75, 23);
            BtnGuardarU.TabIndex = 3;
            BtnGuardarU.Text = "Guardar";
            BtnGuardarU.UseVisualStyleBackColor = true;
            BtnGuardarU.Click += BtnGuardarU_Click;
            // 
            // BtnDescartarU
            // 
            BtnDescartarU.Location = new Point(398, 326);
            BtnDescartarU.Name = "BtnDescartarU";
            BtnDescartarU.Size = new Size(75, 23);
            BtnDescartarU.TabIndex = 3;
            BtnDescartarU.Text = "Descartar";
            BtnDescartarU.UseVisualStyleBackColor = true;
            BtnDescartarU.Click += BtnDescartarU_Click;
            // 
            // FrmRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 361);
            Controls.Add(BtnDescartarU);
            Controls.Add(BtnGuardarU);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblTitulo);
            Name = "FrmRegistrarUsuario";
            Text = "Registrar Usuario";
            Load += FrmRegistrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button BtnGuardarU;
        private Button BtnDescartarU;
    }
}