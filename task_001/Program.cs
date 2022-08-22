// Напишите программу, которая перевернет одномерный массив

const int ARRAY_SIZE =  5;
const int LEFT_RANGE =  0;
const int RIGHT_RANGE =  9;

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random random = new Random();
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = random.Next(leftRange, rightRange + 1);
    }
    return newArray;
}
 void ReverseArray(int[] newArray)
 {
    int temp = 0;
    for (int i = 0; i < newArray.Length/2; i++)
    {
        temp = newArray[i];
        newArray[i] = newArray[newArray.Length - 1 - i];
        newArray[newArray.Length - 1 - i] = temp; 
    }
 }

 int[] array = FillArray(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
 Console.WriteLine('[' + string.Join(", ", array) + ']');
 ReverseArray(array);
 Console.WriteLine('[' + string.Join(", ", array) + ']');