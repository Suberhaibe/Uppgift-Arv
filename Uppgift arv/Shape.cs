namespace Uppgift_arv
{
    public class Shape
    {
        protected int height;
        protected int width;

        public Shape(int Height, int Width)
        {
            height = Height;
            width = Width;
        }

        public virtual int Area()
        {
            return 0;
        }
        public virtual int Circumferance()
        {
            return 0;
        }
    }
}