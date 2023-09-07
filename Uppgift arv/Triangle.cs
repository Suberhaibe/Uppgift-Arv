namespace Uppgift_arv
{
    public class Triangle : Shape
    {
        public Triangle(int höjd, int bredd) : base(höjd, bredd)
        {
        }

        public int Area()
        {
            int area = (width*height)/2;
            return area;
        }
        public int Circumferance()
        {
            int circumferance = (int)Math.Sqrt((width*width)+(height*height))+height+width;
            return circumferance;
        }
    }
}