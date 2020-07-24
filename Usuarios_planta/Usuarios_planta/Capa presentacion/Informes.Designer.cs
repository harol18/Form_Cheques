namespace Usuarios_planta.Formularios
{
    partial class Informes
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
            this.cmbactividad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnguardar = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.Txtcedula = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtcomentarios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbactividad
            // 
            this.cmbactividad.FormattingEnabled = true;
            this.cmbactividad.Items.AddRange(new object[] {
            "Entrada",
            "Salida - Almuerzo",
            "Entrada - Almuerzo",
            "Salida"});
            this.cmbactividad.Location = new System.Drawing.Point(225, 221);
            this.cmbactividad.Name = "cmbactividad";
            this.cmbactividad.Size = new System.Drawing.Size(204, 21);
            this.cmbactividad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actividad:";
            // 
            // Btnguardar
            // 
            this.Btnguardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btnguardar.IconColor = System.Drawing.Color.Black;
            this.Btnguardar.IconSize = 16;
            this.Btnguardar.Location = new System.Drawing.Point(225, 331);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Rotation = 0D;
            this.Btnguardar.Size = new System.Drawing.Size(75, 23);
            this.Btnguardar.TabIndex = 3;
            this.Btnguardar.Text = "Registrar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSalir.IconColor = System.Drawing.Color.Black;
            this.BtnSalir.IconSize = 16;
            this.BtnSalir.Location = new System.Drawing.Point(354, 331);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Rotation = 0D;
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // Txtcedula
            // 
            this.Txtcedula.Location = new System.Drawing.Point(225, 133);
            this.Txtcedula.Multiline = true;
            this.Txtcedula.Name = "Txtcedula";
            this.Txtcedula.Size = new System.Drawing.Size(204, 27);
            this.Txtcedula.TabIndex = 5;
            this.Txtcedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(225, 175);
            this.Txtnombre.Multiline = true;
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(204, 27);
            this.Txtnombre.TabIndex = 6;
            this.Txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // Txtcomentarios
            // 
            this.Txtcomentarios.Location = new System.Drawing.Point(225, 262);
            this.Txtcomentarios.Multiline = true;
            this.Txtcomentarios.Name = "Txtcomentarios";
            this.Txtcomentarios.Size = new System.Drawing.Size(204, 46);
            this.Txtcomentarios.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observaciones";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Usuarios_planta.Properties.Resources.fondoM03;
            this.ClientSize = new System.Drawing.Size(583, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtcomentarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Txtcedula);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbactividad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes";
            this.Text = "Informes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbactividad;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btnguardar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private System.Windows.Forms.TextBox Txtcedula;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtcomentarios;
        private System.Windows.Forms.Label label4;
    }
}