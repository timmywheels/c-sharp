using System;

namespace Enums
{

    public enum ShippingMethod
    {
        // Make sure to declare values for enums as
        // default value is set to zero otherwise
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            // Convert or parse string to an enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);

        }
    }
}
