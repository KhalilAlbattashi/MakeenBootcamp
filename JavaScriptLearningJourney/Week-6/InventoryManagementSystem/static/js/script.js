document.addEventListener('DOMContentLoaded', function() {
    const addToCartButtons = document.getElementsByClassName('add-to-cart');
    const cartItems = document.getElementById('cart-items');
    const checkoutButton = document.getElementById('checkout');
    const totalElement = document.getElementById('total');
  
    let total = 0;
  
    // Add item to cart
    function addItemToCart(itemName, itemPrice) {
      const cartItem = document.createElement('li');
  
      const itemNameSpan = document.createElement('span');
      itemNameSpan.innerText = itemName;
  
      const itemPriceSpan = document.createElement('span');
      itemPriceSpan.innerText = itemPrice;
  
      const increaseQuantityButton = document.createElement('button');
      increaseQuantityButton.innerText = '+';
      increaseQuantityButton.classList.add('increase-quantity');
  
      const quantitySpan = document.createElement('span');
      quantitySpan.innerText = '1';
      quantitySpan.classList.add('quantity');
  
      const decreaseQuantityButton = document.createElement('button');
      decreaseQuantityButton.innerText = '-';
      decreaseQuantityButton.classList.add('decrease-quantity');
  
      increaseQuantityButton.addEventListener('click', function() {
        increaseQuantity(itemPrice);
      });
  
      decreaseQuantityButton.addEventListener('click', function() {
        decreaseQuantity(itemPrice);
      });
  
      cartItem.appendChild(itemNameSpan);
      cartItem.appendChild(itemPriceSpan);
      cartItem.appendChild(decreaseQuantityButton);
      cartItem.appendChild(quantitySpan);
      cartItem.appendChild(increaseQuantityButton);
  
      cartItems.appendChild(cartItem);
    }
  
    // Update total amount
    function updateTotal() {
      totalElement.innerText = 'Total: $' + total.toFixed(2);
    }
  
    // Increase quantity of an item
    function increaseQuantity(itemPrice) {
      const quantitySpan = event.target.parentNode.getElementsByClassName('quantity')[0];
      const quantity = parseInt(quantitySpan.innerText);
  
      quantitySpan.innerText = quantity + 1;
      total += parseFloat(itemPrice);
      updateTotal();
    }
  
    // Decrease quantity of an item
    function decreaseQuantity(itemPrice) {
      const quantitySpan = event.target.parentNode.getElementsByClassName('quantity')[0];
      const quantity = parseInt(quantitySpan.innerText);
  
      if (quantity > 1) {
        quantitySpan.innerText = quantity - 1;
        total -= parseFloat(itemPrice);
        updateTotal();
      }
    }
  
    // Add event listeners
    for (let i = 0; i < addToCartButtons.length; i++) {
      addToCartButtons[i].addEventListener('click', function() {
        const itemName = this.parentNode.getElementsByClassName('item-name')[0].innerText;
        const itemPrice = this.parentNode.getElementsByClassName('item-price')[0].innerText.substring(1);
        addItemToCart(itemName, itemPrice);
        total += parseFloat(itemPrice);
        updateTotal();
      });
    }
  
    // Checkout
    checkoutButton.addEventListener('click', function() {
      alert('Total amount: $' + total.toFixed(2));
      total = 0;
      cartItems.innerHTML = '';
      updateTotal();
    });
  });
  