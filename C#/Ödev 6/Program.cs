string[] dizi=new string[6];
string bos="";
char c='#';
string bs=" ";
byte uz=Convert.ToByte(dizi.Length);
for (int i=0;i<dizi.Length;i++)
{
    for (int w = 2; w < uz; w++)
    {
        bs=bs+" ";
    }

bos=bos+c;
if(i+1==dizi.Length)
{dizi[i]=bos;}
else
{
dizi[i]=bs+bos;
bs=" ";
uz-=1;
} 

Console.WriteLine(dizi[i]);

}



