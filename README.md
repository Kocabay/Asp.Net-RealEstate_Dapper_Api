# Gayrimenkul Web Projesi
## Projenin Genel Amacı

###
 Bu sitede Admin, Emlakçı ve Ana Sayfa için ayrı paneller hazırlanmış olup Json Web Token ile oturum işlemleri gerçekleştirilmiştir. 
Kayıt Ol sayfası aracılığıyla kayıt olan kullanıcı varsayılan olarak Employee rolüne sahip olduğu için Emlakçı Paneli'ne yönlendirilmektedir. Kullanıcı bu panelde ilan yükleyebilir, yönetebilir, 
ilgili ilana ait birden fazla görsel yüklemesi yapabilmektedir. Kurulan mesajlaşma sistemi ile kendisine gelen mesajları görüntüleyebilir veya sistemde var olan kullanıcılara mesaj atabilmektedir.

ASP.NET Core 8.0 Web API ve MVC kullanarak geliştirdiğim projemde, tüm CRUD işlemleri için Back-End'de Web API kullanılmış olup Front-End'de ise bu API katmanı consume edilmiştir. Dinamik veritabanı işlemleri için ise Dapper ORM kullanılmıştır.
###

# Kullanılan Teknolojiler
- Asp.Net Core 8.0 MVC
- Asp.Net Core 8.0 Web API
- MSSQL Server
- Dapper ORM (DB First)
- Swagger
- JWT (Json Web Token)
- Trigger
- Html, Css
- JavaScript
- Bootstrap

# Front-End
- Asp.Net Core 8.0 MVC
- Html
- Css
- Bootstrap
- JavaScript

# Back-End
- Asp.Net Core 8.0 Web API
- MSSQL Server
- Dapper
- Swagger
  
# Projenin Öne Çıkan Özellikleri
- Veritabanı işlemleri için Dapper ORM kullanımı
- Admin Paneli, Emlakçı Paneli
- JWT ile Giriş ve Kayıt Olma işlemleri.
- Rolleme
- PagedList ile sayfalama yapısı
- Panellerde ilgili CRUD işlemleri & Profil ayarları sayfaları
- Bir ilana ait birden fazla görsel yükleyebilme
- Admin panelinde rolüyle birlikte kullanıcı oluşturma
- Mesajlaşma sistemi

# Admin Paneli Özellikleri
- İstatistikleri görme
- Profil bilgilerini güncelleyebilme işlemi
- Mesajlaşma sistemi
- Kullanıcılar & İlanlar & İlan Görselleri & Kategoriler gibi sayfalarda CRUD işlemleri
- Yapılacaklar Listesi oluşturabilme
- Ana sayfada gösterilmek üzere İletişim & Biz Kimiz & Hizmetler gibi bilgileri güncelleyebilme
- İletişim sayfasından gelen mesajları görebilme/yanıtlayabilme
- Sitede gösterilmek üzere ilanı günün fırsatı olarak seçme
- İlanı aktif/pasif yapabilme
- İlgili ilana detay ekleyebilme

# Emlakçı Paneli Özellikleri
- İstatistikleri görme
- Profil bilgilerini güncelleyebilme işlemi
- Mesajlaşma Sistemi
- Kendi yüklemiş olduğu aktif/pasif ilanları görüntüleyebilme
- İlanı aktif/pasif yapabilme
- İlgili ilana detay ekleyebilme

# Projenin Görselleri

### Veri Tabanı Diyagramı
![Ana ekran](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/DB_diagram.png)

### Ana Sayfa 
![Ana ekran](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home.png)

![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home1.png)

![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home3.png)

![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home4.png)

![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home5.png)

![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home6.png)

### İletişim Sayfası
![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/home7.png)

### Kayıt Ol Sayfası
![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/registerPage.png)

### Admin Paneli 
![Ana sayfa]([url=https://hizliresim.com/mp1ac1b][img]https://i.hizliresim.com/mp1ac1b.jpg[/img][/url])

### Emlakçı Paneli
![Ana sayfa](https://github.com/busraozdemir0/RealEstateSite/blob/master/RealEstate.UI/wwwroot/ProjectScreenShots/employeePanel1.png)

