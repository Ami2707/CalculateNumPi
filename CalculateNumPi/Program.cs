//You have a function called random that generates a number
//from zero to one randomly and it's uniformly distributed.
//Calculate the number pi.

for (; ; )
{
    Console.WriteLine("Write the number of wanted points.");
    Console.WriteLine("Bigger the number of points more accurate the number pi.");

    int totalPoints = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    int pointsInCircle = 0;
    float pi = 0;

    for (int i = 0; i <= totalPoints; i++)
    {
        double x = new Random().NextDouble();
        double y = new Random().NextDouble();

        if (Math.Sqrt(x * x + y * y) < 1)
        {
            pointsInCircle++;
        }

    }

    pi = 4f * pointsInCircle / totalPoints;

    Console.WriteLine(pi);

}