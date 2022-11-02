/*Задача1
int CutNumber (int num)
{
    int result = num /10 % 10 ;
     return result ;
    
}
int RandomNumber = new Random().Next(100,1000);
int result = CutNumber(RandomNumber);
Console.WriteLine($"Second Digit Number of {RandomNumber} is {result}");*/

 //Задача 2
/*Console.WriteLine("Введите число");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}*/
//Задача 3
/*Console.WriteLine(" введи цифру обозначающиую день недели от 1 до 7");
int dayNumber=Convert.ToInt32(Console.ReadLine());
void checkTheDayOfTheWeek(int num)
{   
    if (dayNumber >=6 )
    
    Console.WriteLine($"{num} выходной ? -> да ");
    else 
    Console.WriteLine($"{num} выходной ? ->  нет");
} 
checkTheDayOfTheWeek(dayNumber);
*/
