using System.ComponentModel;

int lessonNumber =5;
int totalLessons = 1;

while (lessonNumber >= 1)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}

Console.WriteLine("Пары закончились");


Console.WriteLine("Вводите оценки по одной, для завершения введения -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;
while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    count++;
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён. Всего введено оценок: {count}");


int sum = 0;
int count1 = 0;
int maxGrade = 0;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
if (grade != -1) {
    maxGrade = grade;
}
while (grade != -1){
    sum +=grade;
    count1++;
    if (grade > maxGrade) {
        maxGrade = grade;
    }
    grade = int.Parse(Console.ReadLine());
}
if (count1 > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count1}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}");
} else {
    Console.WriteLine("Оценок не было введено");
}
string correctPassword = "qwerty123";
int count2 = 0;
while (true)
{
    Console.WriteLine("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    count2++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}
Console.WriteLine($"Количество неудачных попыток: {count2}");

string answer;
do
{
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить ущу одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранен");

Console.WriteLine();
Console.WriteLine("Задача А");
int N = 6;
int i = 1;
Console.WriteLine($"Таблица умножения на {N}");
while ( i <= 10)
{
    Console.WriteLine($"{N} * {i} = {N * i}");
    i++;
}
Console.WriteLine();
Console.WriteLine("Задача В");
int Pages = 0;
Console.WriteLine("Введите количество прочитанных страниц (для завершения введите -1): ");
int pages = int.Parse(Console.ReadLine());
while (pages != -1)
{
    Pages += pages;
    pages = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Всего прочитано страниц: {Pages}");