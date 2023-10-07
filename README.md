

# CSHARP_101
*using c# with .net 7.0 - Interface, Collections, Classes, Variables, OOP Examples etc.*


### Merhaba, hazırlamış olduğum bu dokümanda okuyucalara c# dilinin kullanımıyla ilgili bir çok temel bilgiyi ve ilerleyen süreçte projelerde kullanabilecek kod örneklerini türkçe olarak anlatmak istedim.


## C# Tanıtım
Orta seviyeli bir programlama dili olan C# Microsoft tarafından geliştirilmiştir. Günlük kullanım diline de makine diline aynı yakınlıktadır.
İlk Alfa versiyonu 2000'li yıllarda ortaya çıkmıştır. Java ve C++ ın güçlü yönlerinden esinlenmiştir. Tasarlanırken kullanım amacına uygun olması ve kolay adapte olunması göz önünde bulundurulmuştur. Nesne yönelimdir bir dildir.


### IDE Seçimi :
Genel olarak gelişitirimi Visual Studio ve Visual Studio Code ortamlarımda olmaktadır.
Visual Studio genellikle büyük ve karmaşık projeler için daha uygundur ve Microsoft ekosistemine derinlemesine entegre edilmiştir. Visual Studio Code ise daha hafif ve hızlı bir kod düzenleyici olarak kullanılır ve daha geniş bir platformda çalışabilir.
Projenizin boyutu, karmaşıklığı ve tercihlerinize bağlı olarak hangi aracı kullanacağınıza karar verebilirsiniz. Ayrıca, birçok geliştirici her iki aracı da paralel olarak kullanır ve projelerine uygun olanı seçer.

Yeni başlayanlar için vsc seçimi bence uygun olacaktır çünkü vs bir çok bağımlılığı hali hazırda kendisi ayarlıyor. Fakat vsc daha manuel bir şekilde ilerliyor ve bu proje kapsamında console üzerinden geliştirim yapacağımız için küçük çaplı projelerde
vsc kullanımı bizim için daha iyi olacaktır diye düşünüyorum.


### VSC Proje Oluşturma :
Bu işlemlere başlamadan önce bilgisayarımıza microsoftun kendi sitesi üzerinden .net in 5+ sdklarından birini indirmeniz yeterli olacaktır. [Microsoft Download](https://dotnet.microsoft.com/en-us/download)
1. Yeni bir klasör oluşturuyoruz.
2. Klasörümüzün path kısmına tıklayıp "cmd" yazıyoruz ve enter'a basıyoruz. Win11 kullananlar direkt olarak açmış oldukları klasörde sağ tık -> terminalde aç da diyebilir.
3. Açılan terminal üzerinde aşağıdaki kodu çalıştırdğımızda bizim için bir console uygulaması oluşturulacaktır.

   ```
     dotnet new console --use-program-main --framework ".net 7.0" -n "project name"
   ```
4. Oluşturulan dosyayı vsc ile açarak kodlamaya başlayabiliriz.

   
## C# Giriş
Console Application, konsol tabanlı bir uygulama türüdür. Bu tür uygulamalar, kullanıcıdan girdi alabilir ve sonuçları konsol penceresinde görüntüleyebilir.


### Console Application - Program.cs :
C# programlamaya yeni başladığınızda karşınıza çıkan temel kavramları açıklayalım:

   ```
    using System;
    
    namespace console_programming;
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,You are in the console programming.");
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
    
            Console.ReadLine();
        }
    }
   ```

1. Main Methodu:
- Main metod, C# programlarının başlangıç noktasıdır. Her C# programının en az bir Main metodu olmalıdır.
- Program çalıştırıldığında, ilk olarak Main metodu çağrılır ve buradan programın geri kalanı başlatılır.
- Main metodu genellikle şu şekilde tanımlanır: static void Main(string[] args). Bu, metodu statik bir metot (yani sınıf örneği oluşturmadan doğrudan çağrılabilir) ve geriye bir değer döndürmeyen (void) bir metot olarak tanımlar.

2. Namespace Kavramı:
- Bir "namespace" (isim alanı), C# programlarını düzenlemek ve kodunuzu farklı mantıksal gruplara bölmek için kullanılan bir yapıdır.
- Namespace'ler, kodunuzu organize etmenize ve aynı isimleri taşıyan sınıflar veya tipler arasındaki çakışmaları önlemenize yardımcı olur.
- Örneğin, System namespace'i, C# dilinin temel türlerini ve sınıflarını içerir.

3. System Using Direktifleri:
- using direktifleri, belirli namespace'lerin kullanıldığı yerleri bildirir ve bu namespace'lerdeki türleri ve sınıfları kullanmanıza olanak tanır.
- Özellikle System namespace'i sık kullanılır. Örneğin, using System; direktifi, System namespace'indeki türleri doğrudan kullanmanıza olanak tanır.
- using direktifleri, kodunuzu daha okunabilir hale getirir ve belirli türleri sürekli olarak uzun tam isimleriyle kullanmanızı engeller. (System.Console.Writeline() yerine Console.WriteLine() gibi.)

4. Run (Çalıştırma):
- "Run" (Çalıştırma) terimi, C# programınızın çalıştırılması anlamına gelir. Programınızı çalıştırdığınızda, Main metodu başlatılır ve programın geri kalanı çalışır.
- Programı çalıştırmak için genellikle bir IDE (Entegre Geliştirme Ortamı) veya komut satırı kullanılır.


### Değişkenler :
Değişkenler bizim uygulama geliştirirken kullandığımız veri tutucularımızdır. Kullandığımız verinin tipine ve büyüklüğüne bağlı olarak doğru veri tipini seçiyor olmak önemlidir.

1. Integer
  - Tam sayıları temsil etmek için kullanılır.
    
   ```
   int number = 16;
   ```
2. Double ve Float
  - Double ve Float kesirli sayıları temsil etmek için kullanılır. Double daha yüksek hassasiyete sahiptir.
    
   ```
   double doubleNumber = 3.141592653589793238;
   float floatNumber = 3.141592653589793238f;
   ```
3. String
  - Metinleri temsil etmek için kullanılır.
    
   ```
   string text = "Merhaba, ben Faruk Akyapak!";
   ```
4. Boolean
  - Mantıksal değerleri (true veya false) temsil etmek için kullanılır.
    
   ```
   bool isTrue = true;
   ```
5. Char
  - Tek bir karakteri temsil etmek için kullanılır.
    
   ```
   char letter = 'f';
   ```
6. DateTime
  - Tarih ve saat bilgisini temsil etmek için kullanılır.
    
   ```
   DateTime time = DateTime.Now;
   ```
7. Array
  - Aynı tipte ve belli sayıda değişkeni tutmak için kullanılır.
    
   ```
   int[] numbers = new int[3] {1,2,3} ;
   ```
8. List
  - Aynı tipte ve dinamik sayıda değikeni tutmak için kullanılır. Bir tip belirleriz ve istediğimiz kadar değişken verebiliriz.
    
   ```
   List<string> namesList = new List<string> { "Faruk", "Enes", "Ozi" };
   ```
9. ArrayList
  - Farklı tipte değişkenleri dinamik boyutta tutmak için kullanırız.
    
   ```
   ArrayList list = new ArrayList();
        list.Add(10);          // int
        list.Add("Hii");       // string
        list.Add(3.14);        // double
        list.Add(true);        // bool
   ```
10. Dictionary
  - Anahtar-değer çiftleri ile çalışan koleksiyonları temsil etmek için kullanılır.
    
   ```
   //Dictionary<TKey, TValue> bir jenerik sınıftır.
   Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Faruk");
        dictionary.Add(2, "Enes");
        dictionary.Add(3, "Ozi");
   ```
11. Variable
  - Veri türünü otomatik olarak saptayan bir değişken türüdür.
    
  ```
    var x = 10; // x otomatik olarak int olarak belirlenir
  ```


### Operatörler :
C# programlama dilinde çeşitli operatörler bulunur. Bu operatörler, farklı işlemleri gerçekleştirmek için kullanılırlar.

Aritmetik Operatörler:

" + (Toplama) "

" - (Çıkarma) "

" * (Çarpma) "

" / (Bölme) "

" % (Modülüs, kalanı alma) "

Atama Operatörleri:

" = (Atama) "

" += (Toplama ile atama) "

" -= (Çıkarma ile atama) "

" *= (Çarpma ile atama) "

" /= (Bölme ile atama) "

İlişkisel ve Karşılaştırma Operatörleri:

" == (Eşit mi?) "

" != (Eşit değil mi?) "

" > (Büyük mü?) "

" < (Küçük mü?) "

" >= (Büyük veya eşit mi?) "

" <= (Küçük veya eşit mi?) "

Mantıksal Operatörler:

" && (VE) "

" || (VEYA) "

" ! (DEĞİL) "


### Tip Dönüşümleri :
C# programlama dilinde tip dönüşümü (type conversion veya casting), bir veri türünü başka bir veri türüne dönüştürme işlemidir.

1. Implicit (Otomatik) Tip Dönüşümü
   - C# derleyicisi tarafından otomatik olarak gerçekleştirilen tip dönüşümüdür.
   - Bu dönüşüm, küçük bir veri türünden daha büyük bir veri türüne yapılıyorsa genellikle sorunsuz bir şekilde gerçekleşir. Örneğin, bir int değerini bir double değişkenine atarsanız otomatik bir tip dönüşümü gerçekleşir.
   - 
   ```
   int number = 5;
   double doubleNumber = number; // Otomatik bir şekilde dönüşüm yapılır.

   //Implicit Casting
        byte f = 10;
        sbyte g = 20;
        int h = f + g;
        Console.WriteLine("f + g is " + h);
   ```

2. Explicit (Bilinçli) Tip Dönüşümü
   - Programcının açıkça belirttiği ve bazen veri kaybına neden olabilecek bir tip dönüşümüdür.
   - Bu dönüşüm, explicit anahtar kelimesi veya çeşitli dönüşüm operatörleri ((tip) deger) kullanılarak gerçekleştirilir.
   - 
   ```
   //Explicit Casting
        string str = "1234";
        int i = Convert.ToInt32(str);
        Console.WriteLine("str is 1234 , str converted to i is " + i);
   ```


### Karar Yapılar ve Döngüler :
C# programlamada karar yapıları ve döngüler, programların akışını kontrol etmek ve farklı durumlara veya koşullara göre işlem yapmak için kullanılan temel yapı taşlarıdır.

1. Karar Yapıları
   - If Yapısı
     Belirli bir koşulun doğru (true) veya yanlış (false) olduğunu kontrol eder ve koşula bağlı olarak kod bloklarını çalıştırır veya çalıştırmaz.
     
     ```
      int sayi = 10;
      if (sayi > 5)
      {
          Console.WriteLine("Sayı 5'ten büyük.");
      }
     ```
   - If-Else Yapısı
     Bir koşul doğru ise belirli bir kod bloğunu çalıştırır, aksi takdirde başka bir kod bloğunu çalıştırır.
     
     ```
      int sayi = 3;
      if (sayi % 2 == 0)
      {
          Console.WriteLine("Sayı çift.");
      }
      else
      {
          Console.WriteLine("Sayı tek.");
      }
     ```
   - Switch Yapısı
     Birden çok koşulu değerlendirir ve koşula uyan ilk kod bloğunu çalıştırır. Daha sonra break ifadesi veya case etiketi bulunmadığı sürece diğer kod bloklarını da çalıştırır.
     Default, case durumlarına girmediği durumda çalışır.
     
     ```
      int gun = 2;
      switch (gun)
      {
          case 1:
              Console.WriteLine("Pazartesi");
              break;
          case 2:
              Console.WriteLine("Salı");
              break;
          default:
              Console.WriteLine("Bilinmeyen gün");
              break;
      }
     ```
    
2. Döngüler
   - For Döngüsü
     Belirli bir koşulu kontrol eder ve koşul doğru olduğu sürece bir kod bloğunu tekrar tekrar çalıştırır.
     
     ```
      for (int i = 1; i <= 5; i++)
      {
          Console.WriteLine("Sayı: " + i);
      }
     ```
   - While Döngüsü
     Bir koşulu kontrol eder ve koşul doğru olduğu sürece bir kod bloğunu tekrar tekrar çalıştırır.
     
     ```
      int sayi = 1;
      while (sayi <= 5)
      {
          Console.WriteLine("Sayı: " + sayi);
          sayi++;
      }
     ```
   - Do-While Dögüsü
     Bir kod bloğunu en az bir kez çalıştırır, ardından bir koşulu kontrol eder ve koşul doğru olduğu sürece kod bloğunu tekrar tekrar çalıştırır.
     
     ```
      int sayi = 1;
      do
      {
          Console.WriteLine("Sayı: " + sayi);
          sayi++;
      } while (sayi <= 5);
     ```
   - Foreach Dögüsü
     Bir koleksiyon veya dizi içindeki her öğeyi tek tek döngüde kullanmanıza olanak tanır.
     
     ```
      int[] sayilar = { 1, 2, 3, 4, 5 };
      foreach (int sayi in sayilar)
      {
          Console.WriteLine("Sayı: " + sayi);
      }
     ```


### Hata Yönetimi :
C# programlamada hata yönetimi, bir programın çalışması sırasında meydana gelen hataları tanımlama, ele alma ve uygun bir şekilde işleme yeteneğini ifade eder. 
Hatalar programların kaçınılmaz bir parçasıdır ve hata yönetimi, bir programın sağlam ve güvenilir olmasını sağlamak için önemlidir.

- **try**, **catch**, ve **finally** anahtar kelimeleri kullanılarak hata yönetimi sağlanır.
- **try** bloğu içinde potansiyel hata riski taşıyan kodlar yazılır.
- **catch** bloğu, try bloğunda bir hata meydana geldiğinde çalışır ve hatayı yakalar.
- **finally** bloğu ise hata oluşsa da oluşmasa da her zaman çalışır ve kaynakları temizleme veya sonlandırma gibi işlemler için kullanılır.

 ```
try
{
    int a = 10;
    int b = 0;
    int sonuc = a / b; // Bölme sıfıra bölünemez
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Sıfıra bölme hatası: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally bloğu her zaman çalışır.");
}
 ```


### Diziler :
C# dilinde diziler (arrays), aynı veri türünden birden fazla öğeyi saklamak için kullanılan veri yapılarıdır. Diziler, bir koleksiyon veya liste gibi düşünülebilir, ancak elemanları sıralı bir şekilde ve belirli bir sıra içinde saklarlar.
Diziler, sabit bir boyuta sahiptir, yani oluşturulduktan sonra boyutları değiştirilemez

- Dizi Oluşturma
  
  ```
    int[] numbers = new int[5]; // 5 elemanlı bir tam sayı dizisi oluşturur
    numbers[0] = 16; // Dizinin ilk elemanına 10 değeri atandı.
    numbers[1] = 12;
    numbers[2] = 18;
    numbers[3] = 10;
    numbers[4] = 14; // Dizi -> 16,12,18,10,14 şeklinde oluştu.

    Array.Sort(numbers);    // Diziyi sıralar. 10 12 14 16 18
    Array.Reverse(numbers); // Diziyi sırasını tersten sıralar. 18 16 14 12 10
    Array.Clear(numbers);   // Diziyi temizler. numbers[]= {}
  ```


### Koleksiyonlar :
C# programlama dilinde koleksiyonlar, birden çok öğeyi saklamak, erişmek ve yönetmek için kullanılan veri yapılarıdır. Koleksiyonlar, farklı veri tiplerini veya nesneleri içerebilir ve bu nesneleri düzenli bir şekilde depolamanıza ve işlemenize olanak tanır. 

1. List<T>
  - Belirli bir türde (generic) öğeleri saklamak için kullanılır.
  - Öğeler, indekslerle erişilebilir ve sıralı bir şekilde depolanır.
    
    ```
    // List<T> is a generic class
        // T is the type of the elements in the list
        List<string> namesList = new List<string> { "Faruk", "Enes", "Ozi" };
        namesList.Add("Mete");
        namesList.Add("Ali");

        List<int> numbersList = new List<int>();
        numbersList.Add(1);
        numbersList.Add(2);
        numbersList.Add(3);

        List<User> usersList = new List<User>();
        usersList.Add(new User
        {
            Name = "Faruk",
            Surname = "Akyapak",
            Age = 22
        });
    ```

2. ArrayList
  - Farklı türlerde öğeleri saklamak için kullanılır.
  - Öğeler, indekslerle erişilebilir ve her türü "object" olarak saklar.
    
    ```
        //ArrayList is a non-generic class
        //It can store any type of data
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Faruk");
        arrayList.Add(true);
    ```

3. Dictionary<TKey,TValue>
   - Bir anahtar-değer çiftlerini eşleştirmek için kullanılır.
   - Her anahtarın benzersiz olması gerekir ve bu anahtarlarla ilgili değerlere erişim hızlıdır.

     ```
        //Dictionary<TKey, TValue> is a generic class
        //TKey is the type of the keys in the dictionary
        //TValue is the type of the values in the dictionary
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Faruk");
        dictionary.Add(2, "Enes");
        dictionary.Add(3, "Ozi");
    ```


### Sınıf Kavramı :
C# programlama dilinde sınıflar, nesne yönelimli programlamanın temel yapı taşlarından biridir.
Sınıflar, nesneleri tanımlamanıza ve bu nesnelerin veri üyelerini (alanlar/fields) ve bu verilere erişmek için metotları (method) veya özellikleri (property) içerebilir.
Sınıf, birçok nesne (instance) oluşturmak için kullanılır ve bu nesneler belirli bir sınıfın özelliklerini ve davranışlarını paylaşır.
C# sınıfları, gerçek dünyadaki nesneleri modellemek ve programlarınızın daha düzenli ve anlaşılır olmasını sağlamak için kullanılır.

Sınıf Sözdizimi

```
[erişim_belirleyici] class SınıfAdı
{
    // Sınıfın alanları (property) ve metodları burada tanımlanır
    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
    [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
    {
        //Metot Gövdesi
    }
}
```

Erişim Belirleyiciler
  - public: Sınıfa her yerden erişilebilir.
  - private: Sınıfa sadece aynı sınıf içinden erişilebilir.
  - protected: Sınıfa sadece aynı sınıf veya miras alan alt sınıflardan erişilebilir.
  - internal: Sınıfa yalnızca aynı projeden erişilebilir (varsayılan erişim belirleyici).

Field(Alan)
  - Bir sınıfın içindeki verileri saklamak için kullanılan değişkenlerdir.
  - Alanlar, sınıfın durumunu temsil eder ve genellikle özgün verileri saklarlar.
  - Alanlar, sınıf içinde tanımlanır ve sınıfın örneği (nesnesi) oluşturulduğunda bu nesnenin bir parçası haline gelirler.

Property(Özellik)
  - Bir sınıfın verilerine erişmek ve bu verileri güvenli bir şekilde kontrol etmek için kullanılan özel metotlar gibi davranan sınıf üyeleridir.
  - Property'ler, sınıfın dışından alanlara erişimi kontrol etmek ve gerekirse özel işlemler gerçekleştirmek için kullanılır.
  - Genellikle alanları (fields) get ve set yöntemleriyle sarmalarlar.

    ```
        public class Ogrenci
        {
            private string ad; // Özel bir alan -> field
      
            // Diğer sınıflardan rişimini kısıtlayarak kapsüllemiş olduk. {get; set;}
            public string Ad { get; set; } // Bu alandaki veriyi kontrol etmek için getter ve setter özellikleri verilmiş -> property
            public int Yas { get; set; }
        
            public void BilgiGoster() // bu sınıfın bir methodu
            {
                Console.WriteLine("Öğrenci Adı: " + Ad);
                Console.WriteLine("Yaşı: " + Yas);
            }
        }

    ```

Instance(Nesne)
  - Bir sınıfın örneği veya bir nesnesi olarak adlandırılır.
  - Sınıftan oluşturulan her nesne, sınıfın özelliklerini (alanlar/fields) ve davranışlarını (metotlar/methods) paylaşır, ancak kendi özgün verilerine de sahip olabilirler.
  - Nesneler, sınıfın "new" anahtar kelimesiyle oluşturulurlar.
    
    ```
    Ogrenci ogrenci1 = new Ogrenci();
    ogrenci1.Ad = "Faruk";
    ogrenci1.Yas = 23; 
    ```

Constructor(Kurucu)
  - Sınıflardan nesnelerin oluşturulması sırasında çağrılan özel metodlardır.
  - Yeni bir nesne örneği oluşturulduğunda çalışır ve genellikle nesnenin başlangıç durumunu ayarlamak veya başlatmak için kullanılırlar.
  - Adları sınıfın adı ile aynıdır.
  - Geri dönüş türü yoktur (void bile dönüş türü olarak kullanılmaz).
  - Overloading yapılabilir, yani bir sınıf birden fazla kurucu fonksiyon içerebilir.

Encapsulation(Kapsülleme)
  - OOP da kullanılan bir prensiptir ve programlamada veri ve işlevselliği bir arada gruplamayı amaçlar.
  - Bir sınıfın verilerini (alanlar/fields) ve bu verilere erişen işlevselliği (metodlar/methods) bir "kapsül" içine alarak dış dünyadan gelen müdahalelere karşı korur.
  - Bu prensip, sınıfların iç yapısını gizli tutmayı ve sadece belirli yöntemlerle erişilebilmesini sağlamayı hedefler.

  - Gizlilik (Privacy): Sınıfın içindeki veriler (alanlar) sınıfın dışından doğrudan erişilemez hale getirilir. Bu, verilerin kontrolsüz değişimlerden korunmasını sağlar.
  - Saklama (Hiding): Sınıfın iç yapısı, dış dünyadan gizlenir ve yalnızca sınıfın kendisi tarafından bilinir. Bu, sınıfın iç yapısının değiştirilmesi gerektiğinde dış dünyayı etkilemez.
  - Kontrol (Control): Verilere ve işlevselliğe erişim, sınıf tarafından tanımlanan metodlar aracılığıyla gerçekleştirilir. Bu, verilerin doğru ve güvenli bir şekilde değiştirilmesini sağlar.
    ```
    public class Ogrenci
    {
        private string ad; // Özel bir alan (field)
    
        public string Ad  // Alan erişimi (property)
        {
            get { return ad; } // Okuma işlemi
            set { ad = value; } // Yazma işlemi
        }
    }
    ```

Static Class & Member(Statik Sınıf ve Üye)
  - Static sınıflar ve üyeler, sınıfın bir örneği (nesnesi) oluşturulmasını gerektirmeyen ve verilere veya işlevselliğe kolayca erişmek istediğiniz durumlarda kullanışlıdır.
  - Static Class
    - "static" olarak işaretlenmiş bir sınıf, nesnesi (instance) oluşturulamayan ve yalnızca statik üyelere (static members) ev sahipliği yapabilen bir sınıftır.
    - Static sınıflar, genellikle yardımcı işlevler (utility functions) veya sabit değerler (constants) içeren yardımcı sınıflar olarak kullanılır.
    - Static sınıflar, bir uygulama boyunca aynı işlevselliği paylaşan metotları ve verileri gruplamak için kullanışlıdır.
  - Static Member
    - "static" anahtar kelimesi, sınıf içindeki metotları, alanları veya özellikleri statik üye olarak işaretlemek için kullanılır.
    - Static üyeler, sınıfın herhangi bir nesnesi oluşturulmadan sınıf adı üzerinden doğrudan erişilebilirler.
    

Sınıf Örneği
      
          // Class
          class Employee
          {
              //Constructor : Special method that is called when an object of a class is created
              public Employee()
              {
                  Console.WriteLine("Main Constructor Called");
                  _employeeCount++;
              }
              static Employee()
              {
                  Console.WriteLine("Static Constructor Called");
                  _employeeCount = 0;
              }
              // Overloading Constructor
              public Employee(int id, string name, string department)
              {
                  Console.WriteLine("Overloading Constructor Called");
                  Id = id;
                  Name = name;
                  Department = department;
                  _employeeCount++;
              }
            // Properties (getters and setters), Encapsulation : Binding data with methods
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            private static int _employeeCount;
            public static int EmployeeCount
            {
                get
                {
                    return _employeeCount;
                }
            }
       
            // Methods (functions)
            public void EmployeeDetails()
            {
                Console.WriteLine("Employee Details");
                Console.WriteLine("Id : {0}", Id);
                Console.WriteLine("Name : {0}", Name);
                Console.WriteLine("Department : {0}", Department + "\n");
            }
            public void EmployeeCountDetails()
            {
                Console.WriteLine("Employee Count : {0}", _employeeCount + "\n");
            }
        }
        

Struct(Yapı)
  - C# programlama dilinde "struct" (structure), değer türünde bir veri yapısıdır.
  - "class" ile tanımlanan nesnelerden farklı olarak, değer kopyalama (value copying) üzerine çalışır ve heap bellek yerine stack bellekte saklanır.
  - Kalıtım gerektirmeyen ve basit bir sınıf tanımlamak istediğimizde bu yaoıyı kullanabiliriz. Çünkü küçük verilerin hızlıca saklanması ve erişimi için kullanışlıdır.
  ```
       struct Ogrenci
      {
      public string Isim;
      public string Soyisim {get;set;}
      public static int OgrenciSayısı=0;
      }
  ```

Enum
  - Sabit değer kümesini temsil etmek için kullanılır. 
  - Enumerations, kodu daha okunabilir ve anlaşılır hale getirmek, sabit değerlerin belirli bir sıraya veya kategoriye ait olduğunu vurgulamak ve hataları azaltmak için kullanışlıdır.

  ```
    // Renklerin enum tanımı
    public enum Renkler
    {
        Kirmizi,
        Yesil,
        Mavi,
        Sarı,
        Beyaz
    }
    
    // Enum kullanımı
    Renkler secilenRenk = Renkler.Mavi;
    
    if (secilenRenk == Renkler.Kirmizi)
    {
        Console.WriteLine("Seçilen renk kırmızıdır.");
    }
    else if (secilenRenk == Renkler.Mavi)
    {
        Console.WriteLine("Seçilen renk mavidir.");
    }
    else
    {
        Console.WriteLine("Diğer bir renk seçilmiştir.");
    }
  ```

## Nesne Yönelimli Programlama
Gerçek dünya nesnelerini ve kavramlarını yazılım geliştirmekte kullanmayı amaçlar. OOP, kodun daha organizeli, yeniden kullanılabilir ve sürdürülebilir olmasını sağlayan bir dizi prensibi ve kavramı içerir.


### Classes and Objects :
  - OOP'de programlar, "sınıf" ve "nesne" kavramları etrafında şekillenir.
  - Bir "sınıf", bir nesnenin (obje) taslağını tanımlar ve bu nesnenin özelliklerini (alanlar/fields) ve davranışlarını (metotlar/methods) içerir.
  - Bir "nesne", bir sınıfın örneğidir ve sınıf tarafından tanımlanan özelliklere ve davranışlara sahiptir.

### Encapsulation :
  - Sınıflar, verileri ve işlevselliği bir arada gruplamak ve dış dünyadan gelen müdahalelere karşı korumak için kullanılır.
  -  Bu, verilere erişimi ve değişimini kontrol etmeyi sağlar. (properties)

### Inheritance :
  - Kalıtım, bir sınıfın başka bir sınıftan özelliklerini ve davranışlarını devralmasını sağlar.
  - Bu, kodun yeniden kullanılabilirliğini artırır ve sınıflar arasında hiyerarşik ilişkiler kurulmasına olanak tanır.
    
### Polymophisim :
  - Çok biçimlilik, aynı isimle farklı davranışlara sahip olabilen metotların veya sınıfların kullanılabilmesini ifade eder.
  - Bu, kodun daha esnek ve genel kullanıma uygun hale gelmesini sağlar.
### Interface :
### Abstract :













