# BabyClass Projesi

Bu proje, bir bebeğin temel bilgilerini tutan ve bu bilgileri ekrana yazdırmak için bir sınıf oluşturmayı içermektedir.
Projede hem parametresiz hem de parametreli constructor (özel metot) kullanılmış, bu sayede farklı şekillerde nesne oluşturma örneklenmiştir.

## Proje Yapısı

### 1. `BabyClass`
- **Alanlar:**
  - `Name`: Bebeğin adı
  - `Surname`: Bebeğin soyadı
  - `DateBirth`: Bebeğin doğum tarihi

- **Constructorlar:**
  - **Parametresiz Constructor:**
    - Sınıf içindeki alanlar varsayılan değerlerle başlatılır.
    - Daha sonra alanlara değer atanabilir.
  - **Parametreli Constructor:**
    - `Name` ve `Surname` alanlarını doğrudan başlatır.

- **Metotlar:**
  - `PrintScreen()`: Bebeğin tüm bilgilerini ekrana yazdırır.
  - `PrintScreen2()`: Parametreli constructor ile oluşturulan nesnelerin bilgilerini yazdırmak için kullanılır.

### 2. `Program` Sınıfı
- **İşlev:**
  - Projenin ana çalışma noktalarını barındırır.
  - İki farklı nesne oluşturularak constructor kullanımı gösterilmiştir.

### Koddan İşleyiş Örneği
#### Parametresiz Constructor Kullanımı
```csharp
BabyClass newbornBaby = new BabyClass
{
    Name = "Adem",
    Surname = "Demir",
    DateBirth = new DateTime(2025, 01, 01)
};
newbornBaby.PrintScreen();
```
#### Parametreli Constructor Kullanımı
```csharp
BabyClass newbornBaby2 = new BabyClass("Arif", "Çiçek");
newbornBaby2.PrintScreen2();
```

## Kurulum ve Çalıştırma
1. Projeyi bir C# IDE'sine (Visual Studio veya Rider gibi) klonlayın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsolda çıktıları gözlemleyin.

## Beklenen Konsol Çıktısı
```
----------------Parametresiz Constructor------------------
Adem Demir 01.01.2025
------------------Parametreli Constructor---------------------
Arif Çiçek
```

## Katkıda Bulunma
Bu proje geliştirilmeye açıktır. Katkıda bulunmak için pull request oluşturabilirsiniz.

## Lisans
Bu proje MIT lisansı altında sunulmaktadır. Daha fazla bilgi için `LICENSE` dosyasını kontrol edebilirsiniz.

