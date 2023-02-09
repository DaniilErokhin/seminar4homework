// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
int result = 1;
    for(int i=1; i <= num2; i++)
    {
    result = result * num1;
    }
    return result;
}
int exponentiation = Exponentiation(num1, num2);
Console.WriteLine("Answer: " + exponentiation);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Input a number: ");
int Num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
int counter = Convert.ToString(number).Length;
int advance = 0;
int result = 0;
    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
}
int sumNumber = SumNumber(Num);
Console.WriteLine("numbers sum = " + sumNumber);
*/

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
Console.Write("Input a series of numbers separated by a comma: ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";
string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
  if (series[i] != ' ') 
  {
  seriesNew += series[i];
  }
  }
  return seriesNew;
}
void СheckNumber2 (int  series)
{
  if (series == '0'||series == '1'||series == '2'||series == '3'||series == '4'||series == '5'||series == '6'||series == '7'||series == '8'||series == '9'||series == ','||series == '-')
  {
  }
  else
  {
  Console.WriteLine($"Symbol Error.Input a number");
  }
}
int[] ArrayOfNumbers(string seriesNew){ 

int[] arrayOfNumbers = new int[1];    
int j =0;

  for (int i = 0; i < seriesNew.Length; i++)
  {
  string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length)
    {
    seriesNew1 += seriesNew[i];
    СheckNumber2(seriesNew[i]);
    i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
    if (i < seriesNew.Length-1)
    {
    arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayOfNumbers;
}
void PrintArry(int[] coll)
{
int count = coll.Length;
int index = 0;
Console.Write("[");
  while(index < count)
  {
  Console.Write(coll[index]);
  index++;
    if (index < count)
    {
    Console.Write(", ");
    }
  }
  Console.Write("]");
}
string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);