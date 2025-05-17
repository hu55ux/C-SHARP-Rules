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
// 1. Full property - getter və setteri özümüz yaza bildiyimiz propertydir.
// 1. Dependency property - 
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