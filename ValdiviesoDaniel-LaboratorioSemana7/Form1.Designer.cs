
namespace ValdiviesoDaniel_LaboratorioSemana7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.Label();
            this.txtNDoc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtBoxDoc = new System.Windows.Forms.TextBox();
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.radiobtnMasculino = new System.Windows.Forms.RadioButton();
            this.radioBtnFemenino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(263, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(194, 24);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Registro de Usuario";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTitulo.Click += new System.EventHandler(this.TxtTitulo_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.AutoSize = true;
            this.txtDocumento.Location = new System.Drawing.Point(145, 74);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(86, 13);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.Text = "Tipo Documento";
            this.txtDocumento.Click += new System.EventHandler(this.TxtDocumento_Click);
            // 
            // txtNDoc
            // 
            this.txtNDoc.AutoSize = true;
            this.txtNDoc.Location = new System.Drawing.Point(169, 116);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(62, 13);
            this.txtNDoc.TabIndex = 2;
            this.txtNDoc.Text = "Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(187, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "Nombre";
            // 
            // txtGenero
            // 
            this.txtGenero.AutoSize = true;
            this.txtGenero.Location = new System.Drawing.Point(189, 191);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(42, 13);
            this.txtGenero.TabIndex = 4;
            this.txtGenero.Text = "Genero";
            // 
            // txtEdad
            // 
            this.txtEdad.AutoSize = true;
            this.txtEdad.Location = new System.Drawing.Point(199, 228);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(32, 13);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.Text = "Edad";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(332, 286);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(307, 71);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDoc.TabIndex = 7;
            this.comboBoxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipoDoc_SelectedIndexChanged);
            // 
            // txtBoxDoc
            // 
            this.txtBoxDoc.Location = new System.Drawing.Point(307, 116);
            this.txtBoxDoc.Name = "txtBoxDoc";
            this.txtBoxDoc.Size = new System.Drawing.Size(121, 20);
            this.txtBoxDoc.TabIndex = 8;
            this.txtBoxDoc.TextChanged += new System.EventHandler(this.TxtBoxDoc_TextChanged);
            this.txtBoxDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxDoc_KeyPress);
            // 
            // txtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(307, 153);
            this.TxtBoxNombre.Name = "txtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxNombre.TabIndex = 9;
            this.TxtBoxNombre.TextChanged += new System.EventHandler(this.TxtBoxNombre_TextChanged);
            this.TxtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxNombre_KeyPress);
            // 
            // txtBoxEdad
            // 
            this.txtBoxEdad.Location = new System.Drawing.Point(307, 225);
            this.txtBoxEdad.Name = "txtBoxEdad";
            this.txtBoxEdad.Size = new System.Drawing.Size(121, 20);
            this.txtBoxEdad.TabIndex = 11;
            this.txtBoxEdad.TextChanged += new System.EventHandler(this.TxtBoxEdad_TextChanged);
            this.txtBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxEdad_KeyPress);
            // 
            // radiobtnMasculino
            // 
            this.radiobtnMasculino.AutoSize = true;
            this.radiobtnMasculino.Location = new System.Drawing.Point(307, 191);
            this.radiobtnMasculino.Name = "radiobtnMasculino";
            this.radiobtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.radiobtnMasculino.TabIndex = 12;
            this.radiobtnMasculino.TabStop = true;
            this.radiobtnMasculino.Text = "Masculino";
            this.radiobtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemenino
            // 
            this.radioBtnFemenino.AutoSize = true;
            this.radioBtnFemenino.Location = new System.Drawing.Point(386, 191);
            this.radioBtnFemenino.Name = "radioBtnFemenino";
            this.radioBtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioBtnFemenino.TabIndex = 13;
            this.radioBtnFemenino.TabStop = true;
            this.radioBtnFemenino.Text = "Femenino";
            this.radioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBtnFemenino);
            this.Controls.Add(this.radiobtnMasculino);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.TxtBoxNombre);
            this.Controls.Add(this.txtBoxDoc);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label txtDocumento;
        private System.Windows.Forms.Label txtNDoc;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtGenero;
        private System.Windows.Forms.Label txtEdad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.TextBox txtBoxDoc;
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.RadioButton radiobtnMasculino;
        private System.Windows.Forms.RadioButton radioBtnFemenino;
    }
}

