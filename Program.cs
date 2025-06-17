//                                                                          C# Qaydalar

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
//                                                                          Interface
// Interface obyekti yaradıla bilinmeyen içində sadəcə methodlar olan və bu methodları implementasiya edə bilən bir kod blokudur.
// Hər bir class istənilən sayda interface-dən implementasiya qəbul edir. Interface-lər default olaraq internal olur.
// Interface daxilində bodysi olan methodlarda ola bilər amma bunlar mütləq implementasiya zamanı override olunmalıdır.
// 
// SOLID prinsipləri - 
// 1. Single responsibility - Hər bir code blokunun sadəcə bir məsuliyyət daşıması məcburiyyətidir.
// 2. Open / Closed Prinsipi - Hər bir code dəyişikliklərə qapalı amma inkişafa açıq olmalıdır.
// 3. Liskov Substitution - Əgər bir class digər classdan miras alırsa, o zaman miras alan classın bütün metodlarını və xüsusiyyətlərini istifadə edə bilməlidir. Yəni miras alan classın hər bir metodu base classın metodunu əvəz edə bilməlidir.
// 4. Interface Segregation - Hər bir interface öz məsuliyyətini daşımalıdır və interface-lər çox böyük olmamalıdır.
// 5. Dependency Inversion - Yüksək səviyyəli modullar aşağı səviyyəli modullardan asılı olmamalıdır. Hər ikisi abstraksiyadan asılı olmalıdır. Abstraksiyalar konkret implementasiyalardan asılı olmamalıdır.
// 
// 
// 
//                                                                      Exception Handling
// 
// Kod səhv yazılan zaman və ya error baş verən zaman kodun çökmə hadisəsinə exception deyilir. C#-da exception system tərəfindən verilən zaman kodumuz çökür.
// Amma biz kodumuzun çöküşünü istəmiriksə bu zaman exception handling istifadə edirik. Exception handling 3 əsas blokdan ibarətdir:
// try - code blokunda error təhlükəsi olan kodlar yazılır.
// catch - try blokunda error baş verərsə bu blok işə düşür və erroru tutaraq kodun çökməsinin qarşısını alır.
// finally - try və catch blokları işləndikdən sonra həmişə işə düşən blokdur. Bu blokda resursların sərbəst buraxılması və ya digər təmizləmə əməliyyatları aparılır.
// Serializable atributunu istifadə edərək classın serializable olduğunu bildiririk. Bu atribut classın serializable olduğunu bildirir və bu classın obyektləri yaddaşa və ya fayla yazıla bilər.
// Bu atribut Bizim yaratdığımız Exception classımızın ideal olmasını təmin edir.
// 
// 
//                                                          Serialization və Deserialization
// 
// Json faylları bir-biri ilə əlaqəli olmayan dillər arasında əlaqə yaratmaq üçün istifadə olunur. Json faylları sadə və oxunaqlı bir formatdır. Json faylları obyektlərin yaddaşa və ya fayla yazılması və oxunması üçün istifadə olunur.
// Serialization və Deserialization obyektlərin yaddaşa və ya fayla yazılması və oxunması prosesləridir.
// Serialization - obyektin yaddaşa yazılması və ya fayla yazılması prosesidir. Bu prosesdə obyektin bütün məlumatları yaddaşa və ya fayla yazılır.
// Deserialization - obyektin yaddaşdan və ya fayldan oxunması prosesidir. Bu prosesdə yaddaşa və ya fayla yazılan obyektin bütün məlumatları oxunur və obyektə çevrilir.
// methodların serialize və deserialize olunması üçün System.Text.Json və ya Newtonsoft.Json kitabxanalarından istifadə edə bilərik.
// Məsələn: 
// string name1 = "Hala Madrid";
// string name2 = "Hola Madridistas";
// var names = new List<string> { name1, name2 };
// string json = JsonSerializer.Serialize(names); // Serialization
// File.WriteAllText("names.json", json); // Json faylına yazır
// Bu şəkildə yazılan zaman bir sətir şəklində yazılır. Yazılan dataların daha səliqəli şəkildə yazılması üçün 
// var options = new JsonSerializerOptions{WriteIndented = true}
// string jsonString=JsonSerializer.Serialize(names,options); istifadə olunur və səliqəli şəkildə faylda qeydiyyat aparılır. 
// 
// 
// 
//                                                                                          Delegate
// 
// Delegates - C#-da funksiyaları və metodları bir dəyişən kimi saxlamaq üçün istifadə olunan bir növ referans tipidir.
// Syntax : public delegate returnType DelegateName(parameterType parameterName);
// Multicast delegates - birdən çox metodun eyni anda çağırılmasını təmin edən delegate-lərdir. Bu delegate-lər += və -= operatorları ilə birləşdirilir və ayrılır.
// Generic delegates - C#-da delegate-lərin generic versiyasıdır. Bu delegate-lər System.Func, System.Action və System.Predicate kimi hazırda mövcud olan delegate-lərdir.
// Standart delegates - 4 növ standart delegate var: 
// 1. Action - 16 - ya qədər parametr qəbul edə bilən və void returntypeda olan methodlar üçün nəzərdə tutulmuş generic delegate-dir.
// 2. Func - 16 - ya qədər parametr qəbul edə bilən və return type-ı olan methodlar üçün nəzərdə tutulmuş generic delegate-dir.
// 3. Predicate - 1 parametr qəbul edən və bool return type-ı olan methodlar üçün nəzərdə tutulmuş generic delegate-dir.
// 4. Comparison - 2 parametr qəbul edən və int return type-ı olan methodlar üçün nəzərdə tutulmuş generic delegate-dir. Bu delegate-lər sortlama əməliyyatlarında istifadə olunur.o.sefc
// 
// 
// Indexator - C#-da class və ya struct daxilində array və ya kolleksiya kimi verilənlərə indekslə daxil olmaq üçün istifadə olunan bir xüsusiyyətdir.
// Indexatorlar class və ya struct daxilində bir property kimi təyin olunur və [] operatoru ilə çağırılır.
// 
// 
//                                                                      Standart Interfaces
// 
// Bildiyimiz kimi classlardan törəmə zamanı class yeni classın kim olduğunu və ya nə olduğunu bildirir. 
// Amma Interface-lər isə classımızın nə edə bildiyini idarə edir.
// Standart Interfacelər C#-ın özü ilə gələn interfacelərdir.Məsələn:
// Biz bu metodları əsas classımızda implement edərək metodun necə işləyəcəyini təyin edirik.
// IEnumerable - Classın elementlərini dövr etməyə imkan verən interface-dir. Bu interface-in içərisində GetEnumerator() metodu var.
//
// IComperable - Classın elementlərini müqayisə etməyə imkan verən interface-dir. Bu interface-in içərisində CompareTo() metodu var.
//
// IComparer - Classın elementlərini müqayisə etməyə imkan verən interface-dir. Bu interface-in içərisində Compare() metodu var.
// IComparer istifadəsi zamanı classın obyektlərinin müqayisə üçün lazım olan fieldlarına uyğun Comparer classları yaradılır və IComparer interfacei implementasiya edilir.
// Daha sonra müqayisə məntiqi tətbiq edilən bir Compare metodu yazılır və artıq biz bu Comparer classını Sort metoduna parametr olaraq verərək elementləri müqayisə edə bilirik.
// 
// ICloneable - Classın obyektini klonlamağa imkan verən interface-dir. Bu interface-in içərisində Clone() metodu var.
// Clone metodu implementasiya edildikdə deep copy olur və dəyişikliklər digər obyektə təsir etmir.
// 
// 
// 
//                                                          String Builder
// 
// String builder - C#-da string-ləri daha səmərəli şəkildə manipulyasiya etmək üçün istifadə olunan bir classdır. String builder, string-lərin dəyişdirilməsini və əlavə edilməsini daha sürətli və effektiv edir.
// String builderin öz capacitysi olduğuna görə string builder ilə işləyərkən string-lərin uzunluğu artdıqca yeni string yaradılmır, sadəcə string builderin capacity-si artırılır.
// Buda garbage collectorun işini azaldır və performansı artırır. String builder ilə işləmək üçün System.Text namespace-i daxil edilməlidir.
// String builderin capacitysi 16-dır və simvolların sayı artdıqca capacity hər dəfə 2 qat artırılır.
// String builderin öz xüsusi metodları var ki, bu metodlar string-lərlə işləmək üçün istifadə olunur. Məsələn:
// Append() - string builderə yeni string əlavə edir.
// Replace() - string builderdəki stringi dəyişdirir.
// String builderi daha çox döngülərdə və ya çoxlu sayda string manipulyasiyaları zamanı istifadə etmək daha səmərəlidir. Və sonda isə ToString() metodunu istifadə edərək string builderi string-ə çevirə bilərik. Məsələn:
// string name = "Hala Madrid";
// StringBuilder sb = new StringBuilder(name);
// sb.Append(" Hola Madridistas");
// sb.Replace("Madrid", "Madridistas");
// sb.ToString(); // String builderi string-ə çevirir və nəticəni alır
// sb.Clear(); // String builderi təmizləyir və bütün məlumatları silir
// 
// 
//                                                      Non generic Collections
// 
// Non-generic collections - C#-da eyni tipli olmayan elementləri saxlamaq üçün istifadə olunan kolleksiyalardır. Bu kolleksiyalar System.Collections namespace-i daxil edilməlidir.
// Bu collectionslar data təhlükəsizliyi təmin etmir və performans baxımından generic collectionslardan daha az səmərəlidir.
//
// ArrayList - C#-da non-generic kolleksiyalardan biridir. ArrayList, eyni tipli olmayan elementləri saxlaya bilən bir kolleksiyadır.
// ArrayList, dinamik ölçülü bir array kimi işləyir və elementləri əlavə etmək və silmək üçün istifadə olunur. ArrayList, System.Collections namespace-i daxil edilməlidir.
// 
// 
// Stack - C#-da non-generic kolleksiyalardan biridir. Stack, LIFO (Last In First Out) prinsipi ilə işləyən bir kolleksiyadır. Yəni sonuncu əlavə edilən element ilk olaraq çıxarılır.
// Stack, System.Collections namespace-i daxil edilməlidir.
// 
// Queue - C#-da non-generic kolleksiyalardan biridir. Queue, FIFO (First In First Out) prinsipi ilə işləyən bir kolleksiyadır.
// Yəni ilk əlavə edilən element ilk olaraq çıxarılır.
// 
// Hashtable - C#-da non-generic kolleksiyalardan biridir. Hashtable, açar-dəyər cütlərini saxlamaq üçün istifadə olunan bir kolleksiyadır.
// Hashtable, System.Collections namespace-i daxil edilməlidir.
// 
// 
//                                                              Generic Collections
// 
// Generic collections - C#-da eyni tipli elementləri saxlamaq üçün istifadə olunan kolleksiyalardır. Generic collections
// C#-ın II versiyası ilə gəlmiş və non generic collectionslarda olan data təhlükəsizliyi problemlərinin qarşısını almaq üçün təkmilləşdirilmişdir.
// Bu kolleksiyalar System.Collections.Generic namespace-i daxil edilməlidir.
// 
// List<T> - C#-da generic kolleksiyalardan biridir. List<T>, eyni tipli elementləri saxlamaq üçün istifadə olunan bir kolleksiyadır.
// List<T>, dinamik ölçülü bir array kimi işləyir və elementləri əlavə etmək və silmək üçün istifadə olunur. List<T>, System.Collections.Generic namespace-i daxil edilməlidir.
// 
// 
// Stack<T> - C#-da generic kolleksiyalardan biridir. Stack<T>, LIFO (Last In First Out) prinsipi ilə işləyən bir kolleksiyadır. Yəni sonuncu əlavə edilən element ilk olaraq çıxarılır.
// 
// 
// Queue<T> - C#-da generic kolleksiyalardan biridir. Queue<T>, FIFO (First In First Out) prinsipi ilə işləyən bir kolleksiyadır. Yəni ilk əlavə edilən element ilk olaraq çıxarılır.
// 
// 
// Dictionary<TKey, TValue> - C#-da generic kolleksiyalardan biridir. Dictionary<TKey, TValue>, açar-dəyər cütlərini saxlamaq üçün istifadə olunan bir kolleksiyadır.
// Bu kolleksiya, açarların unikal olmasını təmin edir və dəyərlərə açarlar vasitəsilə daxil olmaq mümkündür.
// 
// 
// SortedList<TKey, TValue> - C#-da generic kolleksiyalardan biridir. SortedList<TKey, TValue>, açar-dəyər cütlərini saxlamaq üçün istifadə olunan bir kolleksiyadır.
// Bu kolleksiya, açarların sıralı olmasını təmin edir və dəyərlərə açarlar vasitəsilə daxil olmaq mümkündür.
// 
// LinkedList<T> - C#-da generic kolleksiyalardan biridir. LinkedList<T>, elementləri düyünlər şəklində saxlamaq üçün istifadə olunan bir kolleksiyadır.
// 
// 
// 
//                                                              Boxing and Unboxing
// 
// Boxing - Value type dəyərləri reference (object) type dəyişənlərə yazmaq üçün istifadə olunan bir prosesdir.
// Bu prosesdə value type dəyəri heap yaddaşında saxlanılır və reference type dəyişənə təyin edilir.
// Bu proses C#-da bahalı proses adlanır və data təhlükəsizliyinə səbəb ola bilər.
// 
// Unboxing - Reference type dəyişənlərdən value type dəyərləri çıxarmaq üçün istifadə olunan bir prosesdir.
// 
// 
// 
//                                                                  Events
// 
// Event - C#-da obyektlərin bir-biri ilə əlaqə qurmasını təmin edən bir mexanizmdir. Events, bir obyektin baş verən hadisələrə reaksiya verməsini təmin edir.
// Event-lər delegate-lərlə işləyir.
// Məsələn, bir düyməyə basıldığında və ya bir obyektin vəziyyəti dəyişdiyində baş verən hadisələri izləmək üçün istifadə olunur. Məsələn:
// public class Button{
//     public event EventHandler Clicked; // Event declaration
// }
// public class Program{
//     public static void Main(string[] args){
//          Button button = new Button();
//          button.Clicked += Button_Clicked; // Event subscription
//          button.OnClicked(); // Event invocation
// }
// 
//  
//                                                          Event Arguments
// 
// Event handlers - C#-da event-lərin işlənməsi üçün istifadə olunan delegate-lərdir. Event handler-lər, event baş verdikdə çağırılan metodlardır.
// Event args - C#-da event-lərin işlənməsi üçün istifadə olunan məlumatları saxlayan bir classdır. Event args, event baş verdikdə əlavə məlumatları təmin edir.
// 
// 
// 
//                                                          Generic
// 
// C#-da genericlik - metodlarımızın funskiyalarımızın və s. daha sürətli və bütün tiplərlə işləmə bacarığıdır.
// C#-da generic edə bilirik : 
// Class
// Struct
// Methods
// İnterface
// Delegate
// Collections.
// 
// Syntax: class Some<T>
// {
//      public T value{get;set;}
// }
// 
// Biz bu template-ə filterdə əlavə edə bilərik buda <T> yazıldıqdan sonra qeyd olunmalıdır. Məsələn:
// Some<T> where T: class, IEnumerable<int> - burda biz template hissədə yalnız sayıla bilən class yerləşdirməli olduğunu bildiririk.
// 
// 
// 
//                                                              LINQ
// 
// LINQ - Language Inteqrated Query - Dilə inteqrasiya olunmuş(declarative) sorğu dilidir. Bu dil bizə collections ilə işləməyə onları müəyyən 
// bir filterlər tətbiq etməyə imkan verir. Bu zaman biz sadəcə şərtləri və ya lazım olan hissələri veririk və arxa fonda görülən işi görmürük LINQ bu işləri özü həll edir.
// LINQ-un bir neçə növü var
// LINQ to Object - C#-da obyektlər ilə işləmək üçün istifadə olunan LINQ növüdür. Bu LINQ növü, C#-ın özündə olan kolleksiyalarla işləmək üçün istifadə olunur. Məsələn, List, Array, Dictionary və s. ilə işləmək üçün istifadə olunur.
// LINQ to Dataset - C#-da DataSet ilə işləmək üçün istifadə olunan LINQ növüdür. Bu LINQ növü, DataSet və DataTable ilə işləmək üçün istifadə olunur. Məsələn, DataSet-dəki cədvəllərlə işləmək üçün istifadə olunur.
// LINQ to Entities - C#-da Entity Framework ilə işləmək üçün istifadə olunan LINQ növüdür. Bu LINQ növü, Entity Framework ilə işləmək üçün istifadə olunur. Məsələn, Entity Framework ilə verilənlər bazası ilə işləmək üçün istifadə olunur.
// LINQ to SQL - C#-da SQL ilə işləmək üçün istifadə olunan LINQ növüdür. Bu LINQ növü, SQL sorğularını C#-da yazmağa imkan verir. Məsələn, Entity Framework ilə işləmək üçün istifadə olunur.
// LINQ to XML - C#-da XML ilə işləmək üçün istifadə olunan LINQ növüdür. Bu LINQ növü, XML sənədləri ilə işləmək üçün istifadə olunur. Məsələn, XML sənədlərini oxumaq və yazmaq üçün istifadə olunur.
// PLINQ - Parallel LINQ - C#-da paralel işləmək üçün istifadə olunan LINQ növüdür. Bu LINQ növü, paralel işləmə imkanları təqdim edir və performansı artırır. Məsələn, çox nüvəli prosessorlarda daha sürətli işləmək üçün istifadə olunur.
// 
// LINQ-un əsas metodları:
// 1. Select - kolleksiyadan elementləri seçmək üçün istifadə olunur. Məsələn, bir kolleksiyadan müəyyən bir property-ni seçmək üçün istifadə olunur.
// 2. Where - kolleksiyadan elementləri filterləmək üçün istifadə olunur. Məsələn, bir kolleksiyadan müəyyən bir şərtə uyğun olan elementləri seçmək üçün istifadə olunur.
// 3. OrderBy - kolleksiyanı müəyyən bir property-yə görə sıralamaq üçün istifadə olunur. Məsələn, bir kolleksiyanı müəyyən bir property-yə görə artan və ya azalan sıraya salmaq üçün istifadə olunur.
// 4. GroupBy - kolleksiyanı müəyyən bir property-yə görə qruplaşdırmaq üçün istifadə olunur.
// 5. Join - iki kolleksiyanı müəyyən bir property-yə görə birləşdirmək üçün istifadə olunur.
// 6. From - LINQ sorğularını başlatmaq üçün istifadə olunur. Bu metod, LINQ sorğularını yazmağa imkan verir və kolleksiyalardan məlumatları seçmək üçün istifadə olunur.
// 7. ToList - LINQ sorğusunun nəticələrini List tipinə çevirmək üçün istifadə olunur. Bu metod, LINQ sorğusunun nəticələrini List tipinə çevirir və nəticələri List şəklində qaytarır.
// 8. into - LINQ sorğularında intermediate nəticələri saxlamaq üçün istifadə olunur. Bu metod, LINQ sorğularında intermediate nəticələri saxlamaq və daha sonra istifadə etmək üçün istifadə olunur.
// Məsələn :
// var result = from item in collection
//              where item.Property == value
//              select item;
// 
// 
// 
// 
//                                                          Anonymous Methods
// 
// Anonim methods -  yəni adlandırılmamış metodlardır. Bu metodlar, adlandırılmış metodlardan fərqli olaraq, birbaşa kod blokunda yazılır və adlandırılmır. 
// Anonim metodlar, delegate-lərlə işləmək üçün istifadə olunur və adətən event-lərdə və ya callback funksiyalarında istifadə olunur.
// Anonim methodlar yaddaşda yer tutmaması və performans baxımından daha səmərəli olması üçün istifadə olunur.
// Anonim methodların syntax:
// delegate(parameters) { code block; }
// Məsələn:
// var Numbers = new List<int> { 1, 2, 3, 4, 5 };
// var evenNumbers = Numbers.Where(delegate(int x) {return x % 2 != 0;}).ToList(); // Anonim method ilə filterləmə
// Bu cür yazılan anonim methodlar sadəcə yarandığı anda yaddaşda kiçik bir yer tutur və daha sonra istifadə olunmadığı zaman garbage collector tərəfindən təmizlənir.
// Bu yazılış forması daha çox LINQ ilə işləyərkən istifadə olunur. Amma anonim methodların istifadəsi biraz uzun olduğu üçün daha çox lambda ifadələri istifadə olunur.
// 
// 
// 
//                                                                  Lambda Expressions
// 
// Lambda expression - C#-da anonim methodların daha qısa və oxunaqlı bir versiyasıdır. Lambda ifadələri, delegate-lərlə işləmək üçün istifadə olunur və adətən LINQ sorğularında və ya event-lərdə istifadə olunur.
// Syntax:
// (parameters) => expression;
// var Numbers = new List<int> { 1, 2, 3, 4, 5 };
// var evenNumbers= Numbers.Where(x => x % 2 != 0).ToList(); // Lambda ifadəsi ilə filterləmə
// 
// 
// 
// Lambda ifadələr Pure methodlar olmalıdır. Yəni Təmiz method deyərkən biz qlobal dəyişən istifadə etməməliyik, sadəcə metod daxilindəki parametrlərdən istifadə etməliyik.
// Və içəridəki kodda datalar dəyişilməməlidir sadəcə oxunmalı yoxlanılmalıdır.
// 
// 
//                                                          
//  
//                                                                   Extension Methods
// 
// Extension methods - C#-da mövcud olan classlara yeni metodlar əlavə etmək üçün istifadə olunan bir xüsusiyyətdir.
// Bu metodlar, mövcud classların funksionallığını genişləndirmək üçün istifadə olunur və mövcud classların kodunu dəyişdirmədən yeni metodlar əlavə etməyə imkan verir.
// Belə methodlar static class daxilində static metodlar kimi təyin olunur və this keywordu ilə istifadə olunan classın tipini göstərir.
// Syntax:
//  static class ExtensionMethods
//  {
//      public static void NewMethod(this ExistingClass obj, parameters){
//          // method body
//      }
//  }
// 
// Məsələn, String classına yeni bir metod əlavə etmək üçün aşağıdakı kimi bir extension method yarada bilərik:
// 
// static class StringExtensions{
//     public static string ToUpperFirstLetter(this string str){
//         if(string.IsNullOrEmpty(str)) return str;
//         return char.ToUpper(str[0]) + str.Substring(1);
//     }
// 
// string name = "hala madrid";
// Console.WriteLine(name.ToUpperFirstLetter()); // Hala madrid
// 
// Extension methods, mövcud classların funksionallığını genişləndirmək üçün istifadə olunur və mövcud classların kodunu dəyişdirmədən yeni metodlar əlavə etməyə imkan verir.
// Daha çox Linq sorğularında istifadə olunur və kodun uzanmasının qarşısını alır. 
// 
// Bəzi ən çox istifadə olunan methodlar:
// First - verilənlər kolleksiyasının ilk elementini qaytarır. Əgər kolleksiya boşdursa və ya verilən parametrə uyğun element tapılmazsa exception atır.
//
// FirstOrdefault - verilənlər kolleksiyasının ilk elementini qaytarır. Əgər kolleksiya boşdursa və ya verilən parametrə uyğun element tapılmazsa null və ya həmin tipin default qiymətini qaytarır.
// 
// Single - verilənlər kolleksiyasının tək bir elementini qaytarır. Əgər kolleksiya boşdursa və ya bir neçə element varsa exception atır.
// 
// SingleOrDefault - verilənlər kolleksiyasının tək bir elementini qaytarır. Əgər element olmazsa və ya kolleksiya boş olarsa null qaytaracaq. Elementdən bir neçə ədəd olarsa exception atır.
// 
// Contains - verilənlər kolleksiyasının içərisində müəyyən bir elementin olub olmadığını yoxlayır. Əgər element varsa true, yoxdursa false qaytarır.
// 
// Where - verilənlər kolleksiyasını filterləmək üçün istifadə olunur. Bu metod, müəyyən bir şərtə uyğun olan elementləri seçmək üçün istifadə olunur. Məsələn, bir kolleksiyadan müəyyən bir property-yə görə elementləri seçmək üçün istifadə olunur.
// 
// Min - verilənlər kolleksiyasının ən kiçik elementini qaytarır. Əgər kolleksiya boşdursa exception atır.
// 
// Max - verilənlər kolleksiyasının ən böyük elementini qaytarır. Əgər kolleksiya boşdursa exception atır.
// 
// Average - verilənlər kolleksiyasının orta qiymətini qaytarır. Əgər kolleksiya boşdursa exception atır.
// 
// Sum - verilənlər kolleksiyasının cəmini qaytarır. Əgər kolleksiya boşdursa exception atır.
// 
// OrderBy - verilənlər kolleksiyasını müəyyən bir property-yə görə sıralamaq üçün istifadə olunur. Bu metod, kolleksiyanı artan və ya azalan sıraya salmaq üçün istifadə olunur. Məsələn, bir kolleksiyanı müəyyən bir property-yə görə artan və ya azalan sıraya salmaq üçün istifadə olunur.
// 
// OrderByDescending - verilənlər kolleksiyasını müəyyən bir property-yə görə azalan sıraya salmaq üçün istifadə olunur. Bu metod, kolleksiyanı azalan sıraya salmaq üçün istifadə olunur. Məsələn, bir kolleksiyanı müəyyən bir property-yə görə azalan sıraya salmaq üçün istifadə olunur.
// 
// ThenBy - verilənlər kolleksiyasını müəyyən bir property-yə görə ikinci dəfə sıralamaq üçün istifadə olunur. Bu metod, OrderBy metodundan sonra istifadə olunur və kolleksiyanı ikinci bir property-yə görə sıralamaq üçün istifadə olunur. Məsələn, bir kolleksiyanı əvvəlcə bir property-yə görə artan sıraya salmaq və sonra ikinci bir property-yə görə azalan sıraya salmaq üçün istifadə olunur.
// 
// ThenByDescending - verilənlər kolleksiyasını müəyyən bir property-yə görə ikinci dəfə azalan sıraya salmaq üçün istifadə olunur. Bu metod, OrderByDescending metodundan sonra istifadə olunur və kolleksiyanı ikinci bir property-yə görə azalan sıraya salmaq üçün istifadə olunur. Məsələn, bir kolleksiyanı əvvəlcə bir property-yə görə azalan sıraya salmaq və sonra ikinci bir property-yə görə artan sıraya salmaq üçün istifadə olunur.
// 
// Count - verilənlər kolleksiyasının element sayını qaytarır. Əgər kolleksiya boşdursa 0 qaytarır.
// 
// Take - verilənlər kolleksiyasının ilk n elementini qaytarır.S
// 
// Skip - verilənlər kolleksiyasının ilk n elementini atlayır və qalan elementləri qaytarır. 
// 
// TakeLast - verilənlər kolleksiyasının son n elementini qaytarır. Bu metod, kolleksiyanın son n elementini seçmək üçün istifadə olunur. 
// 
// SkipLast - verilənlər kolleksiyasının son n elementini atlayır və qalan elementləri qaytarır.
// 
// SkipWhile - verilənlər kolleksiyasında şərtə uuyğun olan ilk elementdən etibarən bütün elementləri qaytarır.
// 
// TakeWhile - verilənlər kolleksiyasında şərtə uyğun olan ilk elementə qədər bütün elementləri qaytarır.
// 
// Any - verilənlər kolleksiyasının içərisində müəyyən bir şərtə uyğun elementin olub olmadığını yoxlayır. Əgər element varsa true, yoxdursa false qaytarır.
// 
// All - verilənlər kolleksiyasının içərisində bütün elementlərin müəyyən bir şərtə uyğun olub olmadığını yoxlayır. Əgər bütün elementlər şərtə uyğundursa true, yoxdursa false qaytarır.
// 
// Join - iki verilənlər kolleksiyasını müəyyən bir property-yə görə birləşdirmək üçün istifadə olunur.
// 
// GroupJoin -ə verilənlər kolleksiyasını müəyyən bir property-yə görə qruplaşdırmaq üçün istifadə olunur.
// 
// 
// 
//                                                                          Garbage Collector
// 
// Stack - idarə olunan yaddaşın bir hissəsidir və metodlar çağırıldıqda və ya dəyişənlər yaradıldıqda istifadə olunur. Stack, LIFO (Last In First Out) prinsipi ilə işləyir. Yəni sonuncu əlavə edilən element ilk olaraq çıxarılır. Stack, metodların və dəyişənlərin yaddaşda saxlanılması üçün istifadə olunur və metodlar bitdikdə avtomatik olaraq təmizlənir.
// Heap - C#-da idarə olunan yaddaşın digər bir hissəsidir və obyektlərin yaradılması üçün istifadə olunur. Heap, dinamik yaddaşın idarə olunması üçün istifadə olunur və obyektlər yaradıldıqda və ya dəyişənlər təyin edildikdə istifadə olunur. Heap, Garbage Collector tərəfindən idarə olunur və istifadə olunmayan obyektlər avtomatik olaraq təmizlənir.
// 
// C#-da Heap idarə olunan yaddaş səhəsidir. Bu sahə 3 əsas hissədən ibarətdir:
// 1. Generation 0 - Yeni yaradılan obyektlərin saxlandığı sahədir. Bu sahədəki obyektlər tez-tez Garbage Collector tərəfindən təmizlənir və bu səbəbdən bu sahə ən sürətli sahədir.
// 2. Generation 1 - Generation 0 sahəsi dolduqdan sonra obyekt yaradılarsa ilk öncə Garbage Collector işləyir və Generation 0 sahəsində olan reeferenci olmayan yəni istifadə olunmayan
// obyektləri təmizləyir və bundan sonra istifadə olunan obyektləri Generation 1 sahəsinə ötürülür. Yeni obyektlər isə Generation 0- sahəsinə yazılır.
// 3. Generation 2 - Generation 1 sahəsi dolduqdan sonra obyekt yaradılarsa Garbage Collector işləyir və Generation 1 sahəsində olan istifadə olunmayan
// obyektləri təmizləyir və istifadə olunan obyektləri Generation 2 sahəsinə ötürür.
// 
// LOH - Large Object Heap - C#-da 85,000 byte-dan böyük ölçülü obyektlərin saxlandığı sahədir.
// Pinned Heap - Garbage collector tərəfindən yerdəyişməsinə icazə verilməyən obyektlərin saxlandığı sahədir. Bu sahədəki obyektlər Garbage Collector tərəfindən təmizlənmir və bu səbəbdən bu sahə ən yavaş sahədir.
// 
//                                                                          
// 
// 
// 
//                                                                                    File Handling
// 
// File handling - C#-da fayllarla işləmək üçün istifadə olunan bir xüsusiyyətdir. Bu xüsusiyyət, faylları oxumaq, yazmaq, silmək və redaktə etmək üçün istifadə olunur. C#-da fayllarla işləmək üçün System.IO namespace-i daxil edilməlidir.
// 
// FileStream - C#-da fayllarla işləmək üçün istifadə olunan bir classdır. Bu class, faylları oxumaq və yazmaq üçün istifadə olunur. FileStream, System.IO namespace-i daxil edilməlidir. Məsələn:
// Absolute path - C#-da faylın tam yolunu göstərmək üçün istifadə olunan bir xüsusiyyətdir. Bu xüsusiyyət, faylın yerləşdiyi yeri tam olaraq göstərir. Məsələn, "C:\Users\UserName\Documents\File.txt" kimi bir yol ola bilər.
// Relative path - C#-da faylın nisbətən yolunu göstərmək üçün istifadə olunan bir xüsusiyyətdir. Bu xüsusiyyət, faylın yerləşdiyi yeri cari iş qovluğuna nisbətən göstərir. Məsələn, "Documents\File.txt" kimi bir yol ola bilər.  
// 
// FileStrean fileStream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); - bu kod parçası, "file.txt" adlı faylı açır və ya yaradır, fayla oxumaq və yazmaq üçün icazə verir.
// Encoding - C#-da fayllarla işləyərkən istifadə olunan bir xüsusiyyətdir. Bu xüsusiyyət, faylın kodlaşdırma formatını göstərir. Məsələn, UTF-8, ASCII və s. kimi kodlaşdırma formatları mövcuddur. Encoding, System.Text namespace-i daxil edilməlidir. Məsələn:
// fileStream.Write(Encoding.UTF8.GetBytes("Hello, World!"), 0, 13); - bu kod parçası, "Hello, World!" mətnini UTF-8 kodlaşdırma formatında "file.txt" faylına yazır.
// Ən sonda faylı bağlamaq üçün fileStream.Close(); və ya using statement istifadə edə bilərik. Məsələn:
// using (FileStream fileStream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
// // {
// do something with the file
//  fileStream.Close(); // faylı bağlamaq üçün
// 
// 
//                                          
// 
//                                                                      StreamWriter və StreamReader
// 
// StreamWriter - C#-da fayllara yazmaq üçün istifadə olunan bir classdır. Bu class, fayllara mətn yazmaq üçün istifadə olunur və System.IO namespace-i daxil edilməlidir. Bu class istənilən stream ilə işləyə bilər və fayllara mətn yazmaq üçün istifadə olunur. Məsələn:
// string txt = "Hello, World!";
// FileStream fileStream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.Write);
// StreamWriter writer = new StreamWriter(fileStream);
// 
// foreach (char c in txt){
//     writer.Write(c); // fayla hər bir simvolu yazır
// }
// writer.Close(); // faylı bağlayır
// fileStream.Close(); // fayl streamini bağlayır
// 
// StreanReader - C#-da fayllardan mətn oxumaq üçün istifadə olunan bir classdır. Bu class, fayllardan mətn oxumaq üçün istifadə olunur və System.IO namespace-i daxil edilməlidir. Bu class istənilən stream ilə işləyə bilər və fayllardan mətn oxumaq üçün istifadə olunur. Məsələn:
// 
// FileStream fileStream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
// StreamReader reader = new StreamReader(fileStream);                                
// string content = reader.ReadToEnd(); // fayldan bütün məzmunu oxuyur
// Console.WriteLine(content); // oxunan məzmunu konsola yazır
// 
// StreamReader.Close(); // faylı bağlayır
// FileStream.Close(); // fayl streamini bağlayır
// 
// Biz bu fayllarla və streamlərlə işləyən zaman bəzən faylları açıq qalma ehtimalı olur. Bunun qarşısını almaq üçün try-finaly bloklarından istifadə edə bilərik.
// 
// 
// 
// Əlavə olaraq biz Using code blockundan istifadə  edə bilərik. Bu code bloku sadəcə IDisposable interface-i implement edən classlarla işləyir. Bu code bloku, istifadə olunan resursların avtomatik olaraq sərbəst buraxılmasını təmin edir.
// Məsələn :
// using (FileStream fileStream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite));
// using (StreamWriter writer = new StreamWriter(fileStream));
// FileStream fileStream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
// StreamReader reader = new StreamReader(fileStream);
// 
// 
// 
// 
// 
//                                                                  IDisposable Interface
// 
// Bu interface, C#-da resursların düzgün şəkildə sərbəst buraxılmasını təmin etmək üçün istifadə olunur. IDisposable interface-i, obyektlərin sərbəst buraxılması üçün Dispose metodunu təyin edir. Bu metod, obyektin istifadə edildikdən sonra sərbəst buraxılması üçün çağırılır. Məsələn:
// Amma bu kod zamanı exception ola bilər və bu zaman Dispose metodu çağırılmaya bilər. Bu səbəbdən try-finaly bloklarından istifadə edirik.
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