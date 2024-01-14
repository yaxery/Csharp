//Первый семинар по теме Csharp
// Пишем программу, которая принимает на входе 2 целых числа, и проверяет, является ли первое квадратом второго.


//int first_number = 25;
//int second_number = 4;

//if(second_number*second_number == first_number){
  //  Console.Write("First num is a quater of second num");
//}
//else{
//    Console.Write("First num isnt a quater of second num");
//}


// Программа, принимающее целое N, на выходе выводит все целые числа в промежутке -N до N

// int num = 2;
// int num2 = num * (-1);

// while(num2 <= num){
//     Console.Write($"{num2} ");
//     num2++;
// }


// Программа, принимающая на входе трёхзначное число, на выходе показывает сумму первой и последней цифры этого числа

  int num = 199;
  if(num >= 100 && num <= 999){
      int num1 = num / 100;
      int num2 = num % 10;
      int sum = num1 + num2;
      Console.Write($"Sum of first and last digit in numb {num} is {sum}");
  }
  else{
      Console.Write($"Your numb isnt 3digit");
  }
