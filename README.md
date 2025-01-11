# Encapsulation

- Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.  

- Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

- Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.  

- Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.  

### Yukarıda İstenilenler için Car adında bir Class oluşturuyoruz ve Field kısmında Marka, Model ve Renk bilgilerini string olarak tanımlayıp public erişim belirleyicisi ile herkesin erişimine açıyoruz.  
### Aracın kapı sayısını int değişken türünde tanılıyoruz ve private erişim belirleyicisi ile sadece içerisinde bulunduğu class'a izin vermiş oluyoruz.  
### Araç Kapısımı tuttuğumuz değişken ile aynı isimde ve türde Pascal Casing isimlendirmeyle bir Property tanımlıyoruz. Get metodunda kapı sayısını dönüyoruz. Set metodunda ise bir koşul belirliyoruz.  
### Kapı sayısı 2 veya 4 ise hangisi girildiyse o değeri set ediyoruz. Ama 2 veya 4 değilse -1 değerini set ediyoruz.  
### Aracın Marka, Model, Renk ve Kapı Sayısı girilmeden nesnenin oluşmasını istemediğimiz için parametreli bir Constructor kullanıyoruz.  
### Oluşturduğumuz bu class'ın içerisine oluşan araçları göstermesi için bir metot tanımlıyoruz.  
### Son olarak programımızı ana class içerisinde new komutu ile oluşturuyoruz ve metodumuzu çağırıyoruz.  

## Programımızın Ekran Çıktısı Aşağıdaki gibidir.  
![DisplayCar](https://github.com/ugurarican/Encapsulation/blob/master/Encapsulation.png)
