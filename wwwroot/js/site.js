// Write your JavaScript code.
public function addToCart() {
    var x = document.getElementById("shoppingCart");
    if (x.style.visibility === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}