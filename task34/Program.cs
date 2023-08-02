// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] res = gen_array(size, 100, 1000);

int[] gen_array(int size, int minValue, int maxValue){
    int[] gen_result = new int[size];
    for (int i = 0; i < size; i++){
        gen_result[i] = new Random().Next(minValue, maxValue);
    }
    return gen_result;
}

int main_result = count_even_numer(res);

int count_even_numer(int[] res){
    int count = 0;
    for (int i = 0; i < size; i++){
        if (res[i] % 2 == 0){
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Массив с заданной длинной [{String.Join(", ", res)}]");
Console.WriteLine($"Количество четных чисел в массиве {main_result}");
