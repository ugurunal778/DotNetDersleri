

function SetInnerHTML() {
    document.getElementById('demo').innerHTML =
        'JQuery Dersleri'
}

function Message() {
    document.getElementById('demo').innerHTML =
        document.getElementById("inputParameter").value;
}
var sehirler = ['ankara', 'edirne', 'istanbul', 'muş', 'düzce', 'maraş', 'van'];

document.getElementById("btn1").onclick = function () {
    alert(sehirler.length); // .length => dizinin uzunluğunu teslim eder
}

document.getElementById("btn2").onclick = function () {

    // includes = contains // dizi içerisinde eleman yer almaktamıdır true false döner
    if (sehirler.includes("Eskişehir")) {
        alert("dizi içerisinde yer almaktadır");
    }
    else {
        alert("dizi içerisinde yer almamaktadır");
    }
}
