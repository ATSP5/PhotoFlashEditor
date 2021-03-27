using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PhotoEditor
{
    class Layer : HDRPixel
    {
        public Layer()
        {
            
        }
       
       private List<List<HDRPixel>> hDRPixels;

       public int AlocateLayer(int width, int heigth)
        {
            hDRPixels = new List<List<HDRPixel>>();
            for (int i = 0; i < heigth; i++)
            {
                hDRPixels.Add(new List<HDRPixel>());
                for (int q = 0; q < width; q++)
                {
                    hDRPixels[i].Add(new HDRPixel());
                }
            }
            return hDRPixels.Count() * hDRPixels[0].Count();
        }

       protected override byte To8Bit() //TO DO !!!
        {
            throw new NotImplementedException();
        }
    }
}
