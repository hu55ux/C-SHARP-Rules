//                                                  c# Qaydalar

// C# C++-ın yeni versiyasıdır. 
// .NET Framework-in bir hissəsidir. əvvəlki versiyalarda sadəcə windows üçün idi. Amma daha sonra çıxan yeni versiyalar artıq bütün platformalarda işləyə bilir.
// .NET nə üçündür.
// .NET bizə bir çox kitabxanalar təqdim edir. Bu kitabxanalar bizə bir çox işləri asanlaşdırır. Və biz bu kitabxanalardan istifadə edərək daha sürətli proqram yaza bilirik.
// .NET-in .cs kodunun onun təyin etdiyi prinsiplərə uyğunlaşmasını istəyir və yanlışlıqların qarşısını özü alır. 



//                                                                          C#


// İndi yazdığımız kodlar compile olunduqdan sonra birbaşa maşın koduna çevrilməyəcək. İlk öncə IL koduna çevriləcək. IL kodu isə .NET-in öz virtual maşınında işləyir.
// Bu virtual maşın isə .NET-in özüdür. Yəni .NET-in öz virtual maşını var. Bu virtual maşın IL kodunu alır və onu maşın koduna çevirir. Və bu maşın kodunu icra edir.
// Yəni ilk öncə Roslyn compiler IL kodunu yaradır. Sonra isə .NET-in virtual maşını bu IL kodunu alır və onu maşın koduna çevirir. Və bu maşın kodunu icra edir.
// CLR-in öz Garbage Collector-u var. Yəni .NET-in öz Garbage Collector-u var. Bu Garbage Collector kodu alır və onu maşın koduna çevirir. Və bu maşın kodunu icra edir.
// CLR-ın içərisində JIT compiler(Just In Time) memory control, exception handling, thread control, CLS, CTS, BCL, FCL var.
// Daha sonra JIT compiler IL kodunu alır və hansı əməliyyat sistemində işləyirsə, o əməliyyat sisteminin maşın koduna çevirir. Və bu maşın kodunu icra edir.
// CTS- Common Type System. Kodumuzda olan datatypeları IL kodundakı uyğun datatypeları ilə uyğunlaşdırır.
// CLS - Common Language Specification. Hərbir proqramlaşdırma dilinin .NET ilə işləyə bilməsi üçün olan qanunauyğunluqları yerinə yetirən sisemdir.
// BCL - Basic Class Library. Proqramlaşdırma dilinin özündə olan kitabxanalardır.
// FCL - Framework Class Library. .NET-in özündə olan kitabxanalardır.
// DLL - Dynamic Link Library. Müstəqil şəkildə işləyə bilməyən və koddan asılı olan kitabxanalardır.

// Value typelar structdan istifadə edərək yaradılır. Bunlar stackda saxlanılır.
// Structlar, int, float, double, char, bool, decimal, byte, short, long, sbyte, ushort, uint, ulong, enum datatypelarıdır.

// Reference typelar isə classdan istifadə edərək yaradılır. Bunlar heapda saxlanılır.
// Classlar, string, object, array, delegate, interface datatypelarıdır.



// Consola yazmaq üçün Console.WriteLine() metodundan istifadə edirik. Bu metodda default olaraq sonra '\n' gəlir. Yəni yeni sətirə keçir.
// Console.Write() metodunda isə '\n' gəlmir. Yəni yeni sətirə keçmir.
// Console.ReadLine() metodu isə istifadəçidən məlumat alır. Bu metodda '\n' gəlir. Yəni yeni sətirə keçir.
// Consolun rəngini də dəyişmək olur. Bunun üçün Console.ForegroundColor və Console.BackgroundColor metodlarından istifadə edirik.
// Console.ForegroundColor metodu yazdığımız mətni rəngləyir. Console.BackgroundColor metodu isə arxa fonu rəngləyir.
// Console.Clear() metodu isə konsolu təmizləyir.
// C++da olduğu kimi C#-da if else, switch case, for, while, do while döngüləri var. Və hər biri eyni iş prinsipinə əsaslanır.
// Pythonda fString var idi. C#-da isə string interpolation var. Yəni $ işarəsindən sonra {} işarələri içərisindəki dəyişəni alır.
// Escape sequencelarda eyni qaydada işləyir. Yəni \n, \t, \\, \", \', \r, \b, \a, \f, \v, \0 işarələri var.
// Consolda yazılan textin UTF-8 dilində işləməsi üçün Console.OutputEncoding = System.Text.Encoding.UTF8; yazmalıyıq.
// C#-da 2 anonim tip var. var və dynamic. var tipində olan dəyişənlər compile time-da müəyyən edilir. dynamic tipində olan dəyişənlər isə runtime-da müəyyən edilir.
// safe və unsafe sahələri var. unsafe sahədə yazılan kodun düzgünlüyünü developerin məsuliyyətinə buraxır.
// checked sahə - Arximetik riyazi əməliyyatlar zamanı dəyişən overаlow baş verir.
// Bu overflow zamanı dəyər itkisi olmaması üçün checked istifadə edirik.
// 
//
//
//                                                              Default datatypes
// Hər hansı bir tipin default dəyərini tapmaq üçün default keywordu istifadə olunur. Məsələn:
//int a = default;


//                                                             Type casting
// C#-da type castingin 5 növü var:
// 1. İmplicit typecasting - qeyri aşkar tip çevrilməsi. Yalnız ölçü olaraq kiçik tiplər ölçü olaraq böyük tipə çevrilə bilər(data itkisinin qarşısını alır)
// 2. Explicit typecasting - aşkar tip çevrilməsi. Sadəcə formatların düzgün olmasını yoxlayır və data itkisinə fikir verilmir.
// 3. Convert typecasting - birbaşa .NET üzərindən çevrilmə baş verir və təhlükəsiz typecasting-dir. Data itkisinə fikir verilmir.
// 4. Parse typecasting - sadəcə stringdən bir dəyər cast edə bilir. Təhlükəlidir.
// 5. TryParse typecasting - ilk öncə çevrilmə olub olmadığını yoxlayır əgər baş verərsə çevirir baş verməzsə false geri qaytarır.
// 
//
//
//                                                                      Operators
//
// 1. Arximetik operators - ( + - * / % )
// 2. Assignment operators - ( += -= *= /= %= )
// 3. Logical operators - ( && || ! )
// 4. Relational operators - ( > < >= <= == != )
// 5. Other operators - sizeof(), typeof() , nameof().
// 
// is operatoru - dəyərin həmin tipdə olub olmamasını yoxlayır.
// as operatoru - dəyərin həmin tipə çeverilə bilərsə çevirir amma çevrilə bilməzsə null qaytarır.
// ref keywordu - dəyişənin reference-ni göndərmək üçün istifadə olunur.
// out keywordu - dəyişənin bir dəyəri yoxdursa əgər bu zaman onun özünü göndərmək üçün istifadə olunur.
// in keywordu - dəyişənin dəyişilməsinə icazə vermir sadəcə ekrana çıxarılması mümkün olur.
// 
// 
// params - əgər biz bir funksiya içərisində neçə parametr qəbul ediləcəyini bilməsək bu zaman istifadə olunur.
// məsələn:
// static void foo(params int[] numbers){
// int sum = 0;
// 
// foreach(var item in numbers)
//      {
//          sum+=item;
//      }
//      Console.WriteLine(sum);
// }
// 
//
//                                                                      Nullable
//
// Value type heç bir zaman null olmur çünki hər bir zaman default dəyəri olur. Amma əgər null etmək məcburiyyətində qaldıqda sonuna ? işarəsi qoyuruq və nullable etmiş oluru 
//
//
//
//
//
//
//                                                          OOP 
//
// classlarda olan field və metodların acces modifierləri hər biri üçün qarşısında yazılır. Və default olaraq hər biri private olur.
// Acces specifierlər:
// 1.Public - codun hər bir hissəsində görünən
// 2.Protected - yaranan classda görünür törənmiş classda görünmür
// 3.Private - heç bir yerdə görünmür
// 4.İnternal - sadəcə həmin solution üçün görünür digər solutionlarda görünmür
//
//  Properties - özündə getter və setter saxlayan və arxa planda private field olan elemnetlərdir.
// 3 növü var - 
// 1. Auto property - Automatic getter və setteri olan property
// 2. Full property - getter və setteri özümüz yaza bildiyimiz propertydir.
// 3. Dependency property - dependency propertydir. Yəni bir propertynin dəyəri dəyişəndə digər propertynin dəyəri də dəyişir. Bu propertylər WPF-də istifadə olunur.
//
//
// Yaratdığımız classın 3 ədəd varis metodu olur. Bunlar :
// 1. ToString() - classın özünü string tipində qaytarır.
// 2. GetHashCode() - classın hash kodunu qaytarır. Yəni classın özünə aid olan hash kodunu qaytarır.
// 3. Equals() - obyektin bərabər olub olmadığını yoxlayır.
//
//
//
// null coalesce - iki dəyər arasında null olmayan dəyəri qaytarır. Amma iki dəyərdə null olarsa heçnə qaytarmır
// null forgiving - null olan dəyəri null olmayan dəyərə çevirmək üçündür. ! işarəsi ilə yazılır.
// 
// Random rand = new Random();
// rand.next(1, 100); - 1-100 arasında random dəyər alır
// rand.Shared().Next() - ümumi bir dəyər qaytarır int32 tipində.static metoddur.
// 
//
//                                                              String 
//
// 
// String reference type-dır.
// iki bərabər string müqayisə olunan zaman string heapda saxlanmasına baxmayaraq string özünü value type kimi aparır və true qaytarır.
// 
//  Methodlar:
// 
// string a="Hala Madrid";
// a.Length - stringin uzunluğunu qaytarır
// a.ToUpper() - stringi böyük hərflə qaytarır
// a.ToLower() - stringi kiçik hərflə qaytarır
// a.Trim() - stringin başındakı və sonundakı boşluqları silir
// a.TrimStart() - stringin başındakı boşluqları silir
// a.TrimEnd() - stringin sonundakı boşluqları silir
// a[0] - stringin 0-cı indexini qaytarır
// ToCharArray () => Char array return edir
// Substring(0,3)    => icinden bir nece symbol ala bilirik
// CompareTo("Hello");  => muqayise edir  True veya False return edir
// Contains('a')        => icinde varsa true yoxdursa false
// EndsWith("end")      => Sonu end ile bitirse true eks halda false gelir
// StartsWith("Hell")   => Hell ile bashlasa True yoxsa False verir
// IndexOf()   => Tapdiqinin index-ini verir
// LastIndexOf() => Axtartmaqa saagdan bashlayir
// IndexOfAny(new char[] { 'C', 'a', 'd' }); hecbiri yoxdursa -1 verir tapdiqda  index verir
// LastIndexOfAny(new char[] { 'C', 'a', 'd' }); hecbiri yoxdursa -1 verir tapdiqda  index verir
// Insert(0, "Hello") => verilmish indexse verilen deyer elave edilir
// PadLeft(10)  => sonuna bosluq elave edir verilen qeder
// PadRight(10) => Sag terefe verilen qeder boshluq qoyur
// Remove(1)     => verilen indexden sonrakilarin hamisini silir
// Remove(3, 9)  => verilen index araliqindakilari silir
// Split(' ')    => Bosluqa gore parcalayir ve string array qaytarir
// 
//                                                  Arrays
// 
// Array - arraylar eyni tipli elementlərin toplusudur. Arraylar heapda saxlanılır. Arraylar reference type-dır. Arraylar 0-dan başlayır.
// 
// int[] arr = new int[] { 1, 2, 3, 4, 5 };
// int[] arr = new[] { 1, 2, 3, 4, 5 };
// int[] arr = { 1, 2, 3, 4, 5 };
// 
// int[] arr2.CopyTo(arr, 0); - arr2-nin elementlərini arr-ə kopyalayır. 0-dan başlayır.
// arr.Length - arrayin uzunluğunu qaytarır.
// Array özü bir class olduğu üçün onun özündə olan metodlardan istifadə edə bilərik. Məsələn:
// Array.Sort(arr); - arrayi sıralayır.
// Array.Reverse(arr); - arrayi tərsinə çevirir.
// Array.Clear(arr, 0, arr.Length); - arrayi təmizləyir. 0-dan başlayır və arrın uzunluğuna qədər olan elementləri silir. 
// Array.BinarySearch(arr, 0, arr.Length, 5); - arraydə 5-i axtarır. Əgər varsa indexini qaytarır. Yoxdursa -1 qaytarır. Amma mütləq sıralı bir array olmalıdır.
// Array.Find(arr, x => x == 5); - arraydə 5-i axtarır. Əgər varsa onu qaytarır. Yoxdursa null qaytarır.
// Array.FindAll(arr, x => x > 5); - arraydə 5-dən böyük olan elementləri axtarır. Əgər varsa onları qaytarır. Yoxdursa null qaytarır.
// Array.ForEach(arr, x => Console.WriteLine(x)); - arraydəki elementləri dövr edir və onları ekrana çıxarır.
// 
// 
// 
// 
// Çoxölçülü arraylar 2 və daha artıq ölçülü arraylardır.Bunların iki növü var:
// 1. Rectangle array - ölçüsü stabil olan arraylardır.
// 2. Jagger array - ölçüsü dinamik olan arraydır.
// 
//                                                                  Struct vs Class
//
// 1. Struct value typedır. Class isə reference typedır.
// 2. Struct stackda saxlanılır. Class isə heapda saxlanılır.
// 3. Struct struct keywordu ilə yaradılır. Class isə class keywordu ilə yaradılır
// 4. Struct instance yaranarkən new keywordu vacib deyil. Classda isə new keywordu vacibdir.
// 5. Structda bir dəyişəndə edilən dəyişiklik digərinə təsir etmir. Classda isə dəyişənlər bir-birindən asılı olduqda dəyişikliklər təsir edir.
// 6. Structda parametrsiz constructor olmur. Classda isə parametrsiz constructor olur.
// 7. Structda destructor olmur. Classda isə destructor olur.
// 8. Struct inheritance əlaqədə iştirak etmir. Class isə inheritance əlaqədə iştirak edir.
// 
// 
//                                                                      OOP keywordlar
// 
// 1. Multiple inheritance yoxdur (diamond problemə görə). Onun yerinə interface istifadə olunur.
// 2. GUID - global unique ID yaradarkən istifadə olunur.
// 3. inheritance zamanı paramtrized constrictor yaradılarkən base classın adı yerinə sadəcə base keywordu yazılır.
// Məsələn: 
// public Student(Guid id,string? name,DateTime birthdate,float score)
// :base(id,name,birthdate)
// 
// 4. sealed - final keywordu əvəzinə istifadə olunur və metodun növbəti override olmasının qarşısını alır.
// 5. new keywordu metodların qarşısında yazıldıqda override etmədən base classda olan metodun əzib keçmək üçün istifadə olunur.
// 
// 
// 
// 
// OOP prinsipləri:
// 1. Encapsulation - İstifadəçiyə sadəcə ona lazım olan məlumatları və metodları göstərmək üçün istifadə olunur. 
// Access modifierlər vasitəsilə tətbiq olunur:
// 1. Public - hər yerdə görünür.
// 2. Private - sadəcə həmin class daxilində görünür.
// 3. Protected - sadəcə həmin class və o classdan miras alan classlarda görünür.
// 4. İnternal - sadəcə o assemblynin daxilində görünür.
// 5. Protexted İnternal - sadəcə həmin assemblynin və o classdan miras alan classlarda görünür.
// Getter setter metodlarıda property məntiqi daxilində istifadə olunur.
// 
// 
// 2. Polymorphysm - metod və funksiyaların olduğu mühitə uyğun olaraq fərqli şəkildə işləməsidir.
// 2 cür olur. 
// 1. Static polymorphysm (compile time) - method overloading zamanı baş verən polymorphysmdir.  
// 2. Dynamic polymorphysm (run time) - method overriding zamanı baş verən polymorphysmdir.
// 
// 
// 3. İnheritance - miras əlaqəsi. Bir class bir və ya bir neçə classa varislik verə bilər.
// Lakin hər bir class sadəcə bir classdan varislik qəbul edə bilir. Buda diamond problemin C#-da olmamasının səbəbidir..
// Base classın contructorunu base keywordu ilə çağıra bilirik yəni base classın adını yazmağa ehtiyyac qalmır
// 
// 4. Abstraction - Varislik əlaqəsi zamanı bəzi classlar olur ki bu classlar heç bir obyekt yaratmır. Methodlar olur amma içləri doldurulmur.
// Sadəcə base olaraq istifadə olunur. Belə classlar abstract class adlanır.
// Və abstract classda virtual yaratdığımız hər bir metod ilə biz varis olan classları bu metodları istifadəyə məcbur edirik.
// 
// Static class - Static class o classlara deyilir ki biz həmin classdan bir obyekt yaratmadan belə onun metod və ya memberlarınıı istifadə edə bilirik.
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 
// 