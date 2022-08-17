// void Method1()
// {
//     Console.WriteLine("Author...");
// }

// Method1();


// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2(msg: "text message...");

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);


// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);

// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method41(5, "qwerty ");
// Console.WriteLine(res);

//string text = "-Я просто пишу какой-то текст, чтобы проверить работу программы";
//string s = "qwerty"
//            01234
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 7 };

void PrintArr(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Selection(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }

        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}


PrintArr(arr);
Selection(arr);
PrintArr(arr);