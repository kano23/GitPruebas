using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;

namespace MeHasVisto.Models.Bussines
{
    public class PetManagement
    {
        public static void CreateThumbNail(
          string fileName, string filePath,
          int thumbWi, int thumbHi,
          bool maintainAspect)
        {
            //no hacer nada si el tamaño
            //original es mas pequeño que
            //el designado para la
            //vista previa (thumbnail)

            var originalFile = Path.Combine(filePath,
                fileName);
            var source = Image.FromFile(originalFile);
            if (source.Width <= thumbWi &&
                source.Height <= thumbHi)
                return;

            Bitmap thumbnail;
            try
            {
                int wi = thumbWi;
                int hi = thumbHi;
                if (maintainAspect)
                {
                    //Mantener el aspecto a pesar
                    //de los parametros de tamano
                    //de la vista previo
                    wi = thumbWi;
                    hi = (int)(source.Height * ((decimal)thumbWi / source.Width));
                }
                else
                {
                    hi = thumbHi;
                    wi = (int)(source.Width *
                        ((decimal)thumbHi / source.Height));
                }
                thumbnail = new Bitmap(wi, hi);
                using (Graphics g = Graphics.FromImage(thumbnail))
                {
                    g.InterpolationMode =
                        InterpolationMode.HighQualityBicubic;
                    g.FillRectangle(Brushes.Transparent,
                        0, 0,
                        wi, hi);
                    g.DrawImage(source, 0, 0, wi, hi);
                    var tumbnailName = Path.Combine(filePath,
                        "thumbanail_" + fileName);
                    thumbnail.Save(tumbnailName);
                }
            }
            catch
            {
            }
        }

     }
  }


