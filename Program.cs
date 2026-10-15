int lessonNumber = 5;
int totalLessons = 1; 

while (lessonNumber >= totalLessons) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("Пары закончились");

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int .Parse(Console.ReadLine());
int count = 0;
while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    count++;
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Ввод завершён. Всего введено оценок: {count}");

int sum = 0;
int count1 = 0;
int maxGrade = int.MinValue;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade1 = int.Parse(Console.ReadLine());
while (grade1 != -1) {
    sum += grade1;
    count1++;
    if (grade1 > maxGrade){
        maxGrade = grade1;
    }
    grade1 = int.Parse(Console.ReadLine());
}
if (count1 > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count1}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}");
} else {
    Console.WriteLine("Оценок не было введено");
}

string correctPassword = "qwerty123";
int count3 = 0;

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
    count3++;
}
Console.WriteLine($"Неудачных попыток введено: {count3}");