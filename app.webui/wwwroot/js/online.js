var e = document.querySelector("#needDiet");
if (e != null) {
    e.addEventListener("click", NeedPackage)

}
function NeedPackage() {
    var result = confirm("Dİet Paketini Almanız Gerekmektedir");
    if (result) {
        window.location = "https://www.google.com/";
    }
}
var y = document.querySelector("#AnamnezForm");
console.log(y)
if (y != null) {
    y.addEventListener("click", Anamnez)

}
function Anamnez() {
    var result = confirm("Anamnez Formunu Doldurmanız Gerekmektedir")
    if (result) {
        window.location = "https://www.google.com/";
    }
}