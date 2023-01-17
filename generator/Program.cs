using System;
using System.Text;

Console.WriteLine("Вас приветствует генератор паролей!\n");

Console.Write("Введите длину пароля: ");
int length = int.Parse(Console.ReadLine());

const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; 
StringBuilder password = new StringBuilder();
Random rnd = new Random();

for (int i = 0; i < length; i++)
{
    password.Append(valid[rnd.Next(valid.Length)]);
}
password.ToString();
Console.WriteLine(password);
