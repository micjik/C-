// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Compound assignment operator
//Operators like +=, -=, *=, ++, and -- are known as compound assignment operators
//because they compound some operation in addition to assigning the result to the variable.
//The += operator is specifically termed the addition assignment operator.
// if you use the operator before the value as in ++value,
// then the increment will happen before the value is retrieved. Likewise,
// value++ will increment the value after the value has been retrieved
int value = 1;
value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

++value;
Console.WriteLine("SecondFirst: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

int num = 1;
num++;
Console.WriteLine("First: " + num);
Console.WriteLine($"Second: {num++}");
Console.WriteLine("Third: " + num);
Console.WriteLine("Fourth: " + (++num));

int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);
//What will be the result of the following line of code? Console.WriteLine(5 / 10) = 0;
//Which of the following lines of code uses the addition assignment operator? =value+=5
//Which of the following lines of code will output the text Windows 11 Console.Write("Windows " + 1 + 1);


