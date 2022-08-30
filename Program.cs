using WorkshopReview;

namespace WorkshoReview
{
    public class program
    {
        public static void Main()
        {
            int[] arr = { 0, -1, 2, -3, 1 };
            int n = arr.Length;
            Number myobj = new Number();
            myobj.FindTriplets(arr, n);
        }
    }
}