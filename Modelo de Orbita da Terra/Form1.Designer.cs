namespace Modelo_de_Orbita_da_Terra
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_orbit = new System.Windows.Forms.Label();
            this.lbl_earth_day = new System.Windows.Forms.Label();
            this.lbl_seasons = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pausar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(119, 278);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(190, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidade da Terra";
            // 
            // lbl_orbit
            // 
            this.lbl_orbit.AutoSize = true;
            this.lbl_orbit.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orbit.ForeColor = System.Drawing.Color.White;
            this.lbl_orbit.Location = new System.Drawing.Point(12, 56);
            this.lbl_orbit.Name = "lbl_orbit";
            this.lbl_orbit.Size = new System.Drawing.Size(97, 19);
            this.lbl_orbit.TabIndex = 4;
            this.lbl_orbit.Text = "Período de Orbita";
            // 
            // lbl_earth_day
            // 
            this.lbl_earth_day.AutoSize = true;
            this.lbl_earth_day.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_earth_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_earth_day.Location = new System.Drawing.Point(12, 89);
            this.lbl_earth_day.Name = "lbl_earth_day";
            this.lbl_earth_day.Size = new System.Drawing.Size(80, 19);
            this.lbl_earth_day.TabIndex = 5;
            this.lbl_earth_day.Text = "Dias na Terra";
            this.lbl_earth_day.Click += new System.EventHandler(this.lbl_earth_day_Click);
            // 
            // lbl_seasons
            // 
            this.lbl_seasons.AutoSize = true;
            this.lbl_seasons.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seasons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_seasons.Location = new System.Drawing.Point(12, 120);
            this.lbl_seasons.Name = "lbl_seasons";
            this.lbl_seasons.Size = new System.Drawing.Size(51, 19);
            this.lbl_seasons.TabIndex = 7;
            this.lbl_seasons.Text = "Estação";
            this.lbl_seasons.Click += new System.EventHandler(this.lbl_seasons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.lbl_seasons);
            this.Controls.Add(this.lbl_earth_day);
            this.Controls.Add(this.lbl_orbit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_orbit;
        private System.Windows.Forms.Label lbl_earth_day;
        private System.Windows.Forms.Label lbl_seasons;
    }
}

