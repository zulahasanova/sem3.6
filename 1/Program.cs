/* задача 42. напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 - 101101
3 - 11
2 - 10 

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
string DecimaltoBinary(int num)
{
    string binar ="";
   while( num > 0)
   {
    binar = Convert.ToString(num % 2) + binar;
    num = num / 2;
   }
return binar;
}
Console.Write(DecimaltoBinary(num));*/

//решение учителя
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

string DecimaltoBinary(int decNum, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF"; //res = "" //res"1" //res"1" //res"0" //res"1"
    while(decNum > 0) //пока не будет равно нулю //decNum = 11 // decNum = 5 // decNum = 2
    {
        //a = a + b;
        //a = b + a; (так работает)
        //                "1"            + "011"
        res = nums[decNum % otherSystem] + res; //число % 2 
                                                    // 1круг - 11 % 2, 
                                                    //возвращаемся в string nums и добавляем 1
                                                    //2круг - 5 % 2, //возвращаемся в string nums и добавляем 1
                                                    //3круг - 2 % 2, //res 0
        //квадратные скобки изза обращения к строке, к числу круглые

        decNum /= otherSystem; // число = число / 2  //1круг - 11 / 2 = 5
                                                    //возвращаемся в while(decNum > 0) // decNum = 5
                                                    //2круг - 5 / 2 = 2
                                                    //возвращаемся в while(decNum > 0) // decNum = 2
                                                    //3круг - 2 / 2 = 1
                                                    //возвращаемся в while(decNum > 0) // decNum = 1
    }
    return res;
}

string binar = DecimaltoBinary(num, 2);
Console.Write($"{num} -> {binar}");