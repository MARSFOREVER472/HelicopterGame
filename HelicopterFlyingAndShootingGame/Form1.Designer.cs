namespace HelicopterFlyingAndShootingGame
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
            this.components = new System.ComponentModel.Container();
            this.pilar1 = new System.Windows.Forms.PictureBox();
            this.pilar2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.TemporizadorJuego = new System.Windows.Forms.Timer(this.components);
            this.txtPje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pilar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // pilar1
            // 
            this.pilar1.Image = global::HelicopterFlyingAndShootingGame.Properties.Resources.pillar;
            this.pilar1.Location = new System.Drawing.Point(550, 0);
            this.pilar1.Name = "pilar1";
            this.pilar1.Size = new System.Drawing.Size(50, 150);
            this.pilar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilar1.TabIndex = 0;
            this.pilar1.TabStop = false;
            this.pilar1.Tag = "pilar";
            // 
            // pilar2
            // 
            this.pilar2.Image = global::HelicopterFlyingAndShootingGame.Properties.Resources.pillar;
            this.pilar2.Location = new System.Drawing.Point(250, 311);
            this.pilar2.Name = "pilar2";
            this.pilar2.Size = new System.Drawing.Size(50, 150);
            this.pilar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilar2.TabIndex = 1;
            this.pilar2.TabStop = false;
            this.pilar2.Tag = "pilar";
            // 
            // player
            // 
            this.player.Image = global::HelicopterFlyingAndShootingGame.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(100, 100);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::HelicopterFlyingAndShootingGame.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(700, 300);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // TemporizadorJuego
            // 
            this.TemporizadorJuego.Enabled = true;
            this.TemporizadorJuego.Interval = 20;
            this.TemporizadorJuego.Tick += new System.EventHandler(this.MenuEventoTemporizador);
            // 
            // txtPje
            // 
            this.txtPje.AutoSize = true;
            this.txtPje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPje.ForeColor = System.Drawing.Color.White;
            this.txtPje.Location = new System.Drawing.Point(10, 10);
            this.txtPje.Name = "txtPje";
            this.txtPje.Size = new System.Drawing.Size(158, 26);
            this.txtPje.TabIndex = 4;
            this.txtPje.Text = "Puntuación: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(878, 461);
            this.Controls.Add(this.txtPje);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pilar2);
            this.Controls.Add(this.pilar1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Juego Helicóptero";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pilar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pilar1;
        private System.Windows.Forms.PictureBox pilar2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer TemporizadorJuego;
        private System.Windows.Forms.Label txtPje;
    }
}

