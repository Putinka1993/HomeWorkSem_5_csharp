
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] res_arr = gen_random_array(size, -99, 100);

int res_sum = sum_arr(res_arr);

Console.WriteLine($"Массив [{String.Join(", ", res_arr)}]");
Console.WriteLine($"Сумма чисел по нечетным индексам равна {res_sum}");



int sum_arr(int[] res_arr){
    int sum = 0;
    for (int i = 0; i < size; i++){
        sum += i % 2 != 0 ? res_arr[i] : 0;
    }
    return sum;
}

int[] gen_random_array(int size, int minValue, int maxValue){
    int[] arr = new int[size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

