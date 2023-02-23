//  15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите цифру, обозначающую день недели");
int numDay=Convert.ToInt32(Console.ReadLine());

if (numDay==1||numDay==2||numDay==3||numDay==4||numDay==5)
{
    Console.WriteLine ("нет");
} 
else 
if (numDay==6||numDay==7)
{
    Console.WriteLine ("да");
}