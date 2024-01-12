using System.Numerics;

Console.WriteLine("");

byte b= 5;           //1 byte  
byte c= 5;           //1 byte

short s= 5;          //2 byte 
ushort us= 5;        //2 byte

Int16 i16 = 2 ;      //2 byte
int i = 2;           //4 byte
Int32 i32= 2;        //4 byte

char ch= '2';        //2 byte
string str= "metin"; //sınırsız  

bool b1= true;
bool b2= false;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 ="x";
object o2 ="y";
object o3 =4;
object o4 =4.3;

//string ifadeler

string str1= string.Empty;
str1="ad soyad";
string ad="ad";
string soyad="soyad";
string tamIsim=ad + soyad;

// integer tanımlama şekilleri

int integer1 = 5;
int integer2 = 2;
int integer3 = integer1+integer2;

// boolean
bool bool1 =10>2;

// Değişken Dönüşümleri

string str20="20";
int int20=20;
string yeniDeger=str20+Convert.ToInt32(int20); 
Console.WriteLine(yeniDeger); // Çıktısı 2020

int int21=int20+Convert.ToInt32(str20); 
Console.WriteLine(int21); // Çıktısı 40

int int22 = int20 + int.Parse(str20); // Çıktısı 2020

// datetime

string datetime=DateTime.Now.ToString("dd.MM.yy");
Console.WriteLine(datetime); 

string datetime2=DateTime.Now.ToString("dd/MM/yy");
Console.WriteLine(datetime2); 

string hour= DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour);
