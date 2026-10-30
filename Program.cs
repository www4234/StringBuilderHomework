using System;
using System.Globalization;
using System.Linq;

// Исходная "грязная" строка
string rawData = " иванов иван,петров петр, сидорова Анна, бобров БОРИС ";

Console.WriteLine("--- Форматирование списка пользователей ---");
Console.WriteLine($"Исходная строка: \"{rawData}\"");
Console.WriteLine("\nОтформатированный список:");

// Для приведения к правильному регистру (Имя Фамилия) используем TextInfo
TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

// Разделяем по запятым, убираем пробелы по краям и переводим в Title Case
var formattedUsers = rawData
    .Split(',')
    .Select(user => textInfo.ToTitleCase(user.Trim().ToLower()))
    .ToList();

// Выводим пронумерованный список в консоль
for (int i = 0; i < formattedUsers.Count; i++)
{
    Console.WriteLine($"{i + 1}. {formattedUsers[i]}");
}
