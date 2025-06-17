using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class DDA_Algoritmo
    {
        public class PuntoPaso
        {
            public int Paso { get; set; }
            public float X { get; set; }
            public float Y { get; set; }
        }
        public static List<PuntoPaso> CalcularLineaDDA(int x1, int y1, int x2, int y2, Bitmap bmp, float escala, Color color, int origenX = 0, int origenY = 0)
        {
            List<PuntoPaso> puntos = new List<PuntoPaso>();

            int dx = x2 - x1;
            int dy = y2 - y1;

            int pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xInc = dx / (float)pasos;
            float yInc = dy / (float)pasos;

            float x = x1;
            float y = y1;

            for (int i = 0; i <= pasos; i++)
            {
                int xEscalado = (int)Math.Round(x * escala + origenX);
                int yEscalado = (int)Math.Round(-y * escala + origenY); // Y invertido

                if (xEscalado >= 0 && xEscalado < bmp.Width && yEscalado >= 0 && yEscalado < bmp.Height)
                {
                    // Dibujar punto como un pequeño cuadrado
                    for (int dxp = -1; dxp <= 1; dxp++)
                        for (int dyp = -1; dyp <= 1; dyp++)
                        {
                            int px = xEscalado + dxp;
                            int py = yEscalado + dyp;
                            if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                                bmp.SetPixel(px, py, color);
                        }
                }

                puntos.Add(new PuntoPaso
                {
                    Paso = i,
                    X = (float)Math.Round(x, 2),
                    Y = (float)Math.Round(y, 2)
                });

                x += xInc;
                y += yInc;
            }

            return puntos;
        }
        public static void DibujarEjesYCuadricula(Bitmap bmp, float escala, Color colorEjes, Color colorCuadricula)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                int ancho = bmp.Width;
                int alto = bmp.Height;
                int origenX = ancho / 2;
                int origenY = alto / 2;

                Pen lapizEjes = new Pen(colorEjes, 2);
                Pen lapizCuadricula = new Pen(colorCuadricula, 1);

                // Cuadrícula vertical
                for (float x = origenX; x < ancho; x += escala)
                    g.DrawLine(lapizCuadricula, x, 0, x, alto);
                for (float x = origenX; x >= 0; x -= escala)
                    g.DrawLine(lapizCuadricula, x, 0, x, alto);

                // Cuadrícula horizontal
                for (float y = origenY; y < alto; y += escala)
                    g.DrawLine(lapizCuadricula, 0, y, ancho, y);
                for (float y = origenY; y >= 0; y -= escala)
                    g.DrawLine(lapizCuadricula, 0, y, ancho, y);

                // Ejes principales
                g.DrawLine(lapizEjes, 0, origenY, ancho, origenY); // Eje X
                g.DrawLine(lapizEjes, origenX, 0, origenX, alto);  // Eje Y
            }
        }
    }
}
