function solve() {
   //TODO...
    let products = [];
    let totalPrice = 0;
    const addButtons = Array.from(document.getElementsByClassName("add-product"));
    //Get all the add buttons and add an event listener to them
    addButtons.forEach(button => button.addEventListener("click", function () {
        //When an add button is clicked add the product's info to the textarea
        let productName = button.parentElement.previousElementSibling.firstElementChild.textContent;
        let productPrice = Number(button.parentElement.nextElementSibling.textContent);
        document.getElementsByTagName("textarea")[0].textContent += `Added ${productName} for ${productPrice.toFixed(2)} to the cart.\n`
        // Add variables to keep track of the total price and the product names
        if(!products.includes(productName)) {
            products.push(productName);
        }

        totalPrice += productPrice;
    }));
    const checkoutButton = document.getElementsByClassName("checkout")[0];
    checkoutButton.addEventListener("click", function () {
        //Add an event listener to the checkout button
        //When the checkout button is clicked join all the product names and the price
        let product = `You bought ${products.join(', ')} for ${totalPrice.toFixed(2)}.`;
        document.getElementsByTagName("textarea")[0].textContent += product;
        addButtons.forEach(button => button.disabled = true);
        checkoutButton.disabled = true;
    })
}