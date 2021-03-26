using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PhotoEditor
{
    class Layer : HDRPixel
    {
        public Layer(int width, int heigth)
        {
            hDRPixels = new List<HDRPixel>();
            for(int i=0; i<heigth; i++)
            {
                for(int q=0; q<width; q++)
                {
                    hDRPixels.Add(new HDRPixel());
                }
            }
        }
       
       public List<HDRPixel> hDRPixels; //PUBLIC FOR TEST!

       protected override byte To8Bit() //TO DO !!!
        {
            throw new NotImplementedException();
        }
    }
}
