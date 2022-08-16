//Задача №10
Console.WriteLine("Введите трёхзначное число");
int A = Convert.ToInt32(Console.ReadLine());
string numberTwo = Convert.ToString(A);
Console.WriteLine("вторая цифра "+numberTwo[1]);
//Задача №13
Console.WriteLine("Введите число");
int numbers = Convert.ToInt32(Console.ReadLine());
string numberTree = Convert.ToString(numbers);
if (numberTree.Length > 2) {
    Console.WriteLine("третья цифра "+numberTree[2]);
} else {
    Console.WriteLine("третьей цифры нет");
}
