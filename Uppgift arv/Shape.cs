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
        public int Height
        {
            set{height=value;}
            get{return height;}
        }

        public int Width
        {
            set{width=value;}
            get{return width;}
        }
    }
}