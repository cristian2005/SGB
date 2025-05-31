namespace Presentacion
{
    partial class FrmActualizar
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
            txtDireccionAct = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnDescartarU = new Button();
            BtnGuardarAct = new Button();
            LblTitulo = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // txtDireccionAct
            // 
            txtDireccionAct.Location = new Point(12, 261);
            txtDireccionAct.Name = "txtDireccionAct";
            txtDireccionAct.Size = new Size(456, 23);
            txtDireccionAct.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 205);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(456, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 152);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(456, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(456, 23);
            txtNombre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 243);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirección :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 134);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo    :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 187);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Teléfono  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 74);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre :";
            // 
            // BtnDescartarU
            // 
            BtnDescartarU.Location = new Point(394, 326);
            BtnDescartarU.Name = "BtnDescartarU";
            BtnDescartarU.Size = new Size(75, 23);
            BtnDescartarU.TabIndex = 11;
            BtnDescartarU.Text = "Descartar";
            BtnDescartarU.UseVisualStyleBackColor = true;
            BtnDescartarU.Click += BtnDescartarU_Click;
            // 
            // BtnGuardarAct
            // 
            BtnGuardarAct.Location = new Point(298, 326);
            BtnGuardarAct.Name = "BtnGuardarAct";
            BtnGuardarAct.Size = new Size(75, 23);
            BtnGuardarAct.TabIndex = 12;
            BtnGuardarAct.Text = "Actualizar";
            BtnGuardarAct.UseVisualStyleBackColor = true;
            BtnGuardarAct.Click += BtnGuardarAct_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(158, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(232, 34);
            LblTitulo.TabIndex = 13;
            LblTitulo.Text = "Actualizar usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(18, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 14;
            txtId.Visible = false;
            // 
            // FrmActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 361);
            Controls.Add(txtId);
            Controls.Add(LblTitulo);
            Controls.Add(BtnDescartarU);
            Controls.Add(BtnGuardarAct);
            Controls.Add(txtDireccionAct);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmActualizar";
            Text = "FrmActualizar";
            Load += FrmActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDireccionAct;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnDescartarU;
        private Button BtnGuardarAct;
        private Label LblTitulo;
        private TextBox txtId;
    }
}