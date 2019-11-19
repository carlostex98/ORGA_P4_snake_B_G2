namespace Snake
{
    partial class Informacion
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnDocu = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(51, 18);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(94, 44);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Juego";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(271, 18);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(78, 44);
            this.btnFin.TabIndex = 1;
            this.btnFin.Text = "Fin del Juego";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puntos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(233, 108);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(151, 22);
            this.txtTiempo.TabIndex = 6;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(233, 164);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(151, 22);
            this.txtPuntos.TabIndex = 7;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(233, 217);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(151, 22);
            this.txtNivel.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(233, 273);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 22);
            this.txtUsuario.TabIndex = 9;
            // 
            // btnAcerca
            // 
            this.btnAcerca.Location = new System.Drawing.Point(51, 366);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(94, 26);
            this.btnAcerca.TabIndex = 10;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.BtnAcerca_Click);
            // 
            // btnDocu
            // 
            this.btnDocu.Location = new System.Drawing.Point(233, 366);
            this.btnDocu.Name = "btnDocu";
            this.btnDocu.Size = new System.Drawing.Size(160, 23);
            this.btnDocu.TabIndex = 11;
            this.btnDocu.Text = "Ver documentacion";
            this.btnDocu.UseVisualStyleBackColor = true;
            this.btnDocu.Click += new System.EventHandler(this.BtnDocu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(153, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDocu);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Informacion";
            this.Text = "Informacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Informacion_FormClosed);
            this.Load += new System.EventHandler(this.Informacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnDocu;
        private System.Windows.Forms.Button btnLogout;
    }
}