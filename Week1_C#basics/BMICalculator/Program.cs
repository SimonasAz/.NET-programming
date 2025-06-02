Console.WriteLine("Enter Weight in kilograms: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your height in cm");
double height = Convert.ToDouble(Console.ReadLine());
height = height / 100;
double BMI = weight / (height * height);

BMI = Math.Round(BMI, 2);

Console.WriteLine($"Your BMI is {BMI}");

if (BMI < 18.5 ) Console.WriteLine("Youre BMI shows youre UnderWeight");
else if (BMI >= 18.5 && BMI < 25) Console.WriteLine("Your BMI is normal");
else if (BMI >= 25 && BMI <30) Console.WriteLine("Bmi shows youre overweight");
else Console.WriteLine("Youre BMI shows you are obese");


