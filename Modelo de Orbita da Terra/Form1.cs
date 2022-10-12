using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_de_Orbita_da_Terra
{
    public partial class Form1 : Form
    {
        // Váriaveis
        float angle = 0, earthVelocity = 1;
        int px = 210, py = 150, dst = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value; // Setando o valor do Timer para o valor do Track
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(); // Invalidar os gráficos se o timer for iniciado
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            StringFormat str = new StringFormat();
            Graphics g = e.Graphics;

            // Desenhar a Elipse da Terra
            g.SmoothingMode = SmoothingMode.AntiAlias; // Método para desenhar gráficos suaves..
            g.TranslateTransform(px,py,MatrixOrder.Append);
            g.DrawEllipse(Pens.White, -dst + 3,-dst + 3, 100,100); // Desenhando uma elipse
            g.ResetTransform();

            // Desenhando o SOL
            g.FillEllipse(Brushes.Yellow, px + 5, py - 10, 20, 20);

            // Desenhando o texto "SOL" 
            //g.DrawString("SOL",Font,new SolidBrush(Color.Yellow), (int)(px - dst + 50), (int)(py - dst + 25), str);

            // Fazendo a animação da circulação da Terra (funções de seno e cosseno) 
            int x = (int)(px + dst * Math.Sin(angle * Math.PI / 182.5f));
            int y = (int)(py + dst * Math.Cos(angle * Math.PI / 182.5f));
            g.FillEllipse(Brushes.DeepSkyBlue, (int)x, (int)y ,10 , 10);

            angle -= earthVelocity;

            // Desenhando a Elipse da Lua
            g.DrawEllipse(Pens.White,(int)x - 10, (int)y - 10, 30, 30);

            // Fazendo a animação da circulação da Lua (funções de seno e cosseno) 
            int x1 = (int)(x + 15 * Math.Sin(angle * Math.PI / 30f));
            int y1 = (int)(y + 15 * Math.Cos(angle * Math.PI / 30f));

            g.FillEllipse(Brushes.LightGray, (int)x1, (int)y1, 8, 8);

        }
    }
}
