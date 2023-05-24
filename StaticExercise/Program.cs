namespace StaticExercise

    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = TempConverter.CelsiusToFahrenheit(28);
            Console.WriteLine($"Celsius converts to: {fahrenheit} fahrenheit");

            var celsius = TempConverter.FahrenheitToCelsius(70);
            Console.WriteLine($"Fahrenheit coverts to: {celsius} celsius");
        }
    }
}
