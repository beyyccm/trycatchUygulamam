# 🧪 Try-Catch Uygulaması - Sayı Girişi Kontrolü

Bu basit C# uygulamasında `try-catch` yapısı kullanılarak kullanıcıdan alınan verinin doğru olup olmadığı kontrol edilir. Kullanıcı geçerli bir tamsayı girerse, bu sayının karesi ekrana yazdırılır. Geçersiz bir giriş yapılırsa hata yakalanır ve kullanıcı uyarılır.

## 🎯 Amaç

- Hata kontrolü yapmayı öğrenmek
- Programın beklenmeyen girişler karşısında çökmesini engellemek

## 🔧 Kullanılan Teknolojiler

- C# (Console App)
- .NET Framework veya .NET Core

## 📌 Uygulama Akışı

1. Kullanıcıdan sayı alınır (`Console.ReadLine`)
2. `try` bloğunda sayı `int`'e dönüştürülmeye çalışılır
3. Başarılıysa karesi hesaplanır ve yazdırılır
4. Hata varsa `catch` bloğunda kullanıcı uyarılır
