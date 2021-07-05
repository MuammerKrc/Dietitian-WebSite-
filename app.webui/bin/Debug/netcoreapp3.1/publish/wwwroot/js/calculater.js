var y = document.querySelector("#asd");
var other = document.querySelector("#dsa")
console.log(other);
console.log(y);
y.addEventListener("click", () => {
    other.style.display = "flex";
})


var k = document.querySelector(".pointer");
k.addEventListener("mouseover", () => {
    k.style.cursor = "pointer";
})