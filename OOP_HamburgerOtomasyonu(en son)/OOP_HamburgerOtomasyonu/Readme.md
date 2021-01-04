### OOP Hamburger Sipariş Otomasyonu

## Yapılacaklar

uygulama açıldığında menülerin ait olduğu combobox içerisinde varsayılan menüler listelenmeli. Bu menüler örneği;
	- Whooper 20 TL
	- BigKing 18 TL
	- Chicken 15 TL

Menülerin altında bulunan ebatlardan herhangi bir ebat seçilmeli. Eğer Küçük boy seçilmişse, seçili olan menü fiyatına herhangi bir fiyat farkı eklenmeyecek. Orta boy seçilmişse seçili olan menü fiyatına 2TL, Büyük boy seçilmişse yine seçili olan menü fiyatına 5TL fiyat farkı eklenmeli.

Ekstralar isimli alan FlowLayoutPanel olarak tanımlanmdı. Bu yüzden uygulama çalıştırıldığında ve Form yüklendiğinde varsayılan ekstralar ilgili panel içerisinde listelenmeli. Listeleme işlemi için CheckBox oluşturulmalı ve bu checkbox'ın text özelliğine ekstranın adı yazılmalı. (Örn. Ketçap, Mayonez vs...) Checkboxlardan herhangi bir seçildiği takdirde yine seçili menüye 1TL eklenmeli.

Adet seçimi yapıldıktan sonra yukarıda oluşturulan sipariş fiyatını adet ile çarpılması gerekmektedir. Çıkan toplam tutar, "Toplam Tutar" isimli label'da  gösterilmeli.

Oluşturulan sipariş bilgisi aynı zamanda listbox içerisinde tek bir satır içerisinde gösterilmeli.

Mdi form içerisinde tanımlanan menülerden "Menu Oluştur" isimli menuden kullanıcı dilerse yeni bir menuyü ekleyebilmeli. Eklenen menü ComboBox içerisinde gösterilmeli.

"Ekstra Oluştur" isimli menüden kullanıcı dilerse yeni bir ekstra oluşturabilmeli ve oluşturulan ekstralar flowlayout panel içerisine Checkbox olarak eklenmeli.

Sipariş bilgisi isimli menüye giriş yapıldığında o ana kadar tamamlanan siparişlerin listesi ilgili listbox içerisinde listelenmeli. 

Sağ tarafta bulunan GroupBox'larda sırasıyla;
- "Ciro" içerisinde toplam ciro,
- "Toplam Sipariş Sayısı" içerisinde alınan siparişlerin sayısı,
- "Ekstra Malzeme Geliri" içerisinde toplam ekstra geliri,
- "Satılan Ürün Adedi" içerisinde toplam ürün adet bilgisi gösterilmeli.



