int lessonNumber = 1;
int totalLessons = 5;

while (lessonNumber <= totalLessons)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber++;
}

Console.WriteLine("Пары закончились");


Console.WriteLine("Вводите оценки по одной, для завершения введения -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");




int sum = 0;
int count = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());