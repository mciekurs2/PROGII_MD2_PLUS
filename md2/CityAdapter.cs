using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2
{
    class CityAdapter
    {
        public Image IconImage;
        public string CityName;
        public double Temp;

        public CityAdapter(Image picture, string name, double temp )
        {
            IconImage = picture;
            CityName = name;
            Temp = temp;
        }

        //atgriez costume text
        public string TextData()
        {
            return CityName + '\n' + "Temp: " + Temp.ToString("0.00");
        }

        //draw city information into the rectangle
        public void DrawItem(Graphics gr, Rectangle bounds, Font font, bool showNameOnly)
        {
            //setup margin
            var margin = (int)(bounds.Height * 0.05);
            var height = bounds.Height - 2 * margin;

            //draw icon
            var srcRect = new Rectangle(0, 0, IconImage.Width, IconImage.Height);
            var destRect = new Rectangle(bounds.Left + margin, bounds.Top + margin, height, height);
            gr.DrawImage(IconImage, destRect, srcRect, GraphicsUnit.Pixel);

            //draw other items
            var textLeft = destRect.Right + margin;
            var width = bounds.Width - textLeft;
            var layoutRect = new Rectangle(textLeft, bounds.Top, width, bounds.Height);

            using (var stringFormat = new StringFormat())
            {
                stringFormat.LineAlignment = StringAlignment.Center;
                gr.DrawString(showNameOnly ? ToString() : TextData(), font, Brushes.Black,
                    layoutRect, stringFormat);
            }


        }

    }
}
