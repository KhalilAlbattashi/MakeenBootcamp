let title = document.querySelector(".title");
let message = "Hello My name is Khalil I'm a full stack developer";
let arr = message.split(" ")
let index = 0;

let interval = setInterval(function(){
    title.textContent += arr[index] + " ";
    index++;
    // for(let i = 0; i < arr.length; i++){
    //     title.textContent += arr[i] + " ";
    // }

    if(index == arr.length){
        clearInterval(interval);
    }
},500)