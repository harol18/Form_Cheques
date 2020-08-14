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
            this.Txtidentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtobservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbactividad
            // 
            this.cmbactividad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbactividad.FormattingEnabled = true;
            this.cmbactividad.Items.AddRange(new object[] {
            "Entrada",
            "Salida - Almuerzo",
            "Entrada - Almuerzo",
            "Salida"});
            this.cmbactividad.Location = new System.Drawing.Point(199, 244);
            this.cmbactividad.Name = "cmbactividad";
            this.cmbactividad.Size = new System.Drawing.Size(259, 25);
            this.cmbactividad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actividad:";
            // 
            // Btnguardar
            // 
            this.Btnguardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btnguardar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btnguardar.IconColor = System.Drawing.Color.Black;
            this.Btnguardar.IconSize = 16;
            this.Btnguardar.Location = new System.Drawing.Point(199, 355);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Rotation = 0D;
            this.Btnguardar.Size = new System.Drawing.Size(80, 30);
            this.Btnguardar.TabIndex = 4;
            this.Btnguardar.Text = "Registrar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSalir.IconColor = System.Drawing.Color.Black;
            this.BtnSalir.IconSize = 16;
            this.BtnSalir.Location = new System.Drawing.Point(378, 355);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Rotation = 0D;
            this.BtnSalir.Size = new System.Drawing.Size(80, 30);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Txtidentificacion
            // 
            this.Txtidentificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidentificacion.Location = new System.Drawing.Point(199, 125);
            this.Txtidentificacion.Multiline = true;
            this.Txtidentificacion.Name = "Txtidentificacion";
            this.Txtidentificacion.Size = new System.Drawing.Size(259, 27);
            this.Txtidentificacion.TabIndex = 1;
            this.Txtidentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtidentificacion.TextChanged += new System.EventHandler(this.Txtidentificacion_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(199, 163);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(259, 27);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // Txtobservaciones
            // 
            this.Txtobservaciones.Location = new System.Drawing.Point(199, 285);
            this.Txtobservaciones.Multiline = true;
            this.Txtobservaciones.Name = "Txtobservaciones";
            this.Txtobservaciones.Size = new System.Drawing.Size(259, 46);
            this.Txtobservaciones.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observaciones";
            // 
            // TxtArea
            // 
            this.TxtArea.Enabled = false;
            this.TxtArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.Location = new System.Drawing.Point(199, 204);
            this.TxtArea.Multiline = true;
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(259, 27);
            this.TxtArea.TabIndex = 11;
            this.TxtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Area";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Usuarios_planta.Properties.Resources.fondoM03;
            this.ClientSize = new System.Drawing.Size(583, 432);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtobservaciones);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Txtidentificacion);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.cmbactividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.TextBox Txtidentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtobservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label label5;
    }
}