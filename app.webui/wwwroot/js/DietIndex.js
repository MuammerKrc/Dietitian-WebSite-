
var item1 = document.getElementById("item1");
var item2 = document.getElementById("item2");
var item3 = document.getElementById("item3");
var r1=document.getElementById("r1");
var r2=document.getElementById("r2");
var r3=document.getElementById("r3");

item1.addEventListener("click", selectedItem1);
item2.addEventListener("click", selectedItem2);
item3.addEventListener("click", selectedItem3);

function selectedItem1(e) {
    var temp = false;
    console.log("asfaa")

    for (var x of item1.classList) {
        if (x == "active") {
            temp = true;
        }
    }
    if (temp == false) {
        item2.style.background = "none";
        item3.style.background = "none";
        r2.style.display="none";
        r3.style.display="none";
        
        
        r1.style.display="inline";
        item1.style.background = "#fff";
    }
}
function selectedItem2(e) {
    var temp = false;
    console.log("asd");

    for (var x of item2.classList) {
        console.log("asd");
        if (x == "active") {
            temp = true;
        }
    }
    console.log(temp);
    if (temp == false) {
        item1.style.background = "none";
        item3.style.background = "none";
        r1.style.display="none";
        r3.style.display="none";

        r2.style.display="inline";
        item2.style.background = "#fff";
    }
}


function selectedItem3(e) {
    var temp = false;

    for (var x of item2.classList) {
        if (x == "active") {
            temp = true;
        }
    }
    if (temp == false) {
        item1.style.background = "none";
        item2.style.background = "none";
        r2.style.display="none";
        r1.style.display="none";

        r3.style.display="inline";
        item3.style.background = "#fff";
    }
}
