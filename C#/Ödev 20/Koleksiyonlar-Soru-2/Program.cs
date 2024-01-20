int[] say=new int[20];
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("{0}. sayıyı giriniz.",i+1);
    say[i]=int.Parse(Console.ReadLine());
  
}
Array.Sort(say); 
float sayKucTop=(float)(say[0]+say[1]+say[2])/3f;
float saybuyTop=(float)(say[17]+say[18]+say[19])/3f;

Console.WriteLine("En küçük 3 sayı:{0}, {1}, {2} Ortalaması: {3}",say[0].ToString(),say[1].ToString(), say[2].ToString(),sayKucTop.ToString());
Console.WriteLine("En büyük 3 sayı:{0}, {1}, {2} Ortalaması: {3} ",say[17].ToString(),say[18].ToString(), say[19].ToString(),saybuyTop.ToString());
Console.WriteLine("Ortalama toplamları: {0} ",(float)(saybuyTop+sayKucTop));
