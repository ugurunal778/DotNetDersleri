// Personel Class'ı oluşturduk
var Personel = (function () {

    // Personel Class'ının Constructor'ını oluşturduk
    function Personel(name, surname) {
        this.name = name;
        this.surname = surname;

        this.ToSurName = function () {
            alert(this.surname)
        }
    }

    // Personel Class'ına ToName Adından personelin adını mesaj olarak gösteren bir metot ekledik 
    Personel.prototype.ToName = function () {
        alert(this.name);
    }

    // Property ve metotlarını eklediğimiz nesneyi en dışta yer alan Personel değişkenine aktardık
    return Personel;
    // (); kısmı kodun otomatik olarak çalışmasını ve class'ın oluşmasını sağlamaktadır :)
})();

function SetInnerHTML() {
    document.getElementById('demo').innerHTML = 'JQuery Dersleri';
    alert("Javascript Çalıştı");
}


