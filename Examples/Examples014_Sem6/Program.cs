using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5) (6,7)" // возьмите текст
            .Replace("(", "") //замена скобок на пустоту
            .Replace(")", "")
            ;
Console.WriteLine(text);
var data = text.Split(" ") // возьми текст и разбей пробелом
                .Select(item => item.Split(",")) // сделай выборку item(элементов) и разбить запятой
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1]))) //выборка из текущю массива и взяты координаты и Parse(конвектиррованы) в числа 
                .Where(e => e.x % 2 == 0) // делаем проверку условия (тут четные)
                .Select(point => (point.x*10, point.y)) // из набора предыдущего этапа и делаем увеличение 1-ой координаты
                .ToArray(); // превращаем в массив

for (int i = 0; i < data.Length; i++) // цикл
{
    Console.WriteLine(data[i]); // data[i] кортеж чисел
}