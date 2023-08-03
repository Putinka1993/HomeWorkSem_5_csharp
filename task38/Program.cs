Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = arr_random(size, 1, 100);
int result = num_diff(array, 1, 100);

Console.WriteLine($"Разница между максимальным и минимальным числом из массива [{String.Join(", ", array)}] равна {result}");


int[] arr_random(int size, int minValue, int maxValue){
    int[] arr = new int[size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int num_diff(int[] array, int minValue, int maxValue){
    int max = minValue;
    int min = maxValue;
    int diff = 0;
    foreach (int el in array){
        if (el > max){
            max = el;
        }
        if (el < min){
            min = el;
        }
    diff = max - min;
    }
    return diff;  
}  

