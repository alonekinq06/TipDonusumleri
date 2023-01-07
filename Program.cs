// implicit Conversion (Bilinçsiz dönüşüm)
byte a = 5 ;
sbyte b =30;
short c =10;
int d = a+b+c ;
Console.WriteLine("d:"+ d );

long h = d;
Console.WriteLine("h: " + h );
float i = h;
Console.WriteLine("i: " + i );
string e = "furkan";
char f = 'k';
object g= e+f+d;
Console.WriteLine("g: "+ g);

// Explicit Conversion (Bilinçsiz )

Console.WriteLine("*****Explicit Conversiton****");
int x  = 3 ;
byte y = (byte)x;
Console.WriteLine("y;"+y);
int z = 100 ;
byte t = (byte)z;
Console.WriteLine("t:"+t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v:"+v);


// ****ToString Methodu *****
Console.WriteLine("****ToString Methodu *****");
int xx = 6 ;
string yy = xx.ToString();
Console.WriteLine(yy);

string zz = 12.5f.ToString();
Console.WriteLine("zz ;" + " " + zz);
//System.Convert
Console.WriteLine("****System.Convert Sinifi*****");
string s1 = "10" , s2 = "20";
int sayi1,sayi2;
int Toplam;
sayi1=Convert.ToInt32(s1);
sayi2=Convert.ToInt32(s2);




Toplam = sayi1+sayi2;
Console.WriteLine("toplam =" + Toplam);
//Parse 
Console.WriteLine("*****Parse Method****");
// ParseMethod();
string metin1 = "10";
string metin2 = "10.25";
int rakam1 ;
double double1 ;
rakam1 =Int32.Parse(metin1);
double1=Double.Parse(metin2);
Console.WriteLine(double1);
//Console.WriteLine("rakam1;"+rakam1);
//Console.WriteLine("double1"+"  "+double1)
   //odevler         ****GECTİ ***
byte buyt = 2 ;
byte buyt1 = 3 ; 
int Toplambuyt;
Toplambuyt = buyt + buyt1 ;
Console.WriteLine(Toplambuyt);
    //odev2
    Console.WriteLine("aradigimizsey bu ");
decimal bok1 = 12 ;
float bok2 ;
bok2 = Convert.ToInt64(bok1);
Console.WriteLine("simdi oldumu olmadımı    " + bok2);
    //odev3       *****GECTİ****
string bokac = "1";
byte bokacsayi;
bokacsayi = Convert.ToByte(bokac);
Console.WriteLine("////oldumu"+ "  " +bokacsayi);
    //odev4      *****GECTİ******
long logart1 = 123 ;
int logart2 ;
logart2 = Convert.ToInt32(logart1);
Console.WriteLine(logart2);




string abbbb = logart2.ToString();
Console.WriteLine("ilkbu  "+ abbbb);

string abbbbb = Convert.ToString(bokacsayi);
Console.WriteLine("ikincibu  "+abbbbb);

decimal asd = 1234 ;
float asda = (float)asd;
Console.WriteLine(asda);


