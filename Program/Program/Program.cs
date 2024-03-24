public class Program { 
    public static void Main(string[] args) {
        Console.WriteLine("Modyfikacja 3");
        int[] tab1 = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(showAverage(tab1));
    }

    public static float showAverage(int[] a) {
        float value = 0;
        float count = 0;
        float average = 0;

        foreach (int x in a) { 
            count ++;
            value += x;
        }
        return average = value/count;
    }
}