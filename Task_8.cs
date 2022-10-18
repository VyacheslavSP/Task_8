Console.WriteLine("Введите целое положительное число");
String Temp_num = Console.ReadLine();
string char_minus=Temp_num.Substring(0, 1);
if (char_minus =="-")
{
  Console.WriteLine("Вы ввели отрицательное число");
}
else
{
long pozition =Temp_num.IndexOf(","); /// проверка на дробность через поиск запятой. при этом надежда что запятая будет раньше 9 223 372 036 854 775 807 знака
if(pozition!=-1)
{
    Console.WriteLine("Вы ввели дробное чило");
}
else{
ulong desired_Num=Convert.ToUInt64(Temp_num);

for (ulong i = 1; i < desired_Num; i++)
{
  if (i% 2 ==0)
  {
    if (i+2<desired_Num)
    {
    Console.Write(i+ ",");
    }
    else
    {
      Console.WriteLine(i);
    }
  }

}
}
}
