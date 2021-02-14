using System.Drawing;

namespace MyBack
{
    internal class ResizeImage
    {
        private Image image;
        private int v1;
        private int v2;

        public ResizeImage(Image image, int v1, int v2)
        {
            this.image = image;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}