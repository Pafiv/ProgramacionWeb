using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Bresenham_Algoritmo
    {
        public class PuntoPaso
        {
            public int Paso { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static List<PuntoPaso> CalcularLineaBresenham(int x1, int y1, int x2, int y2, Bitmap bmp, float escala, Color color, int origenX, int origenY)
        {
            List<PuntoPaso> puntos = new List<PuntoPaso>();

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);

            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;

            int err = dx - dy;
            int x = x1, y = y1;
            int paso = 0;

            while (true)
            {
                int xPixel = (int)(x * escala) + origenX;
                int yPixel = origenY - (int)(y * escala); // Invertido en pantalla

                // Dibuja un cuadrado de 3x3 para mayor visibilidad
                for (int dxp = -1; dxp <= 1; dxp++)
                {
                    for (int dyp = -1; dyp <= 1; dyp++)
                    {
                        int px = xPixel + dxp;
                        int py = yPixel + dyp;
                        if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                        {
                            bmp.SetPixel(px, py, color);
                        }
                    }
                }

                puntos.Add(new PuntoPaso { Paso = paso++, X = x, Y = y });

                if (x == x2 && y == y2)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }

            return puntos;
        }
    }
}
