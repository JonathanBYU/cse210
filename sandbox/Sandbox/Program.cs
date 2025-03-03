using System;

class Circle {
    private double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    public double GetArea() {
        double area = Math.PI * radius * radius;
        return area;
    }

    public void DisplayCircleArea() {
        Console.WriteLine($"The area of the circle is: {GetArea()}");
    }

    public void SetRadius(double r) {
        radius = r;
    }
}

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Today - March 3, 2025");
        Circle myCircle = new Circle(10);

        myCircle.DisplayCircleArea();

        for (int i = 0; i < 10; i++) {
            myCircle.SetRadius(i);
            double circleArea = myCircle.GetArea();
            Console.WriteLine($"{i}: Circle area is: {circleArea}");
            // myCircle.DisplayCircleArea();
        }
    }
}
