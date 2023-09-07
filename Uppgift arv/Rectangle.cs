namespace Uppgift_arv
{
    public class Rectangle : Shape
    {
        public Rectangle(int höjd, int bredd) : base(höjd, bredd)
        {
        }

        public int Area()
        {
            int area = width*height;
            return area;
        }
        public int Circumferance()
        {
            int circumferance = (width*2)+(height*2);
            return circumferance;
        }
    }
}