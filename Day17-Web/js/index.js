document.querySelector("#password").oninput = (e) => {  //  function(e) {
    const regex = new RegExp('.*password.*');
    const password = document.getElementById("password").value;
    if (regex.test(password)) {
        document.querySelector("#passwordError").innerHTML = `"${password}" is not a very strong password!`;
    }
    else {
        document.querySelector("#passwordError").innerHTML = "";
    }
}

document.querySelector("#age").oninput = (e) => {
    const age = document.getElementById("age").value;
    if (age < 2) {
        document.querySelector("#ageError").innerHTML = "Age must be greater than 2";
    }
    else {
        document.querySelector("#ageError").innerHTML = "";
    }
}

let globalScopeBad = "hello world";

// Self invoking functions allow you to immediately execute javascript and 
// not put anything into global scope.
(function() {
    let date = new Date();
    console.log(date);

    // do {
    //   var userInput = prompt("What is your name?");
    //   if(userInput.length < 2){
    //     alert('Name must contain more than 2 characters!');
    //   }
    // } while(userInput.length <= 2);
    
})();


// JQuery
$('document').ready(() => {
    const age = $('#age');
    age.addClass('emphasize'); // age.attr('class', 'emphasize');
    age.css({
        'color': 'red'
    });
    
    $('#submit').click(() => {
        $('#submit').fadeOut(5000);
    });

    const inputs = $('input');
    inputs.mouseenter(() => {
        inputs.addClass('emphasize')
              .fadeIn(1000);
    });
    inputs.mouseleave(() => {
        inputs.removeClass('emphasize')
              .fadeOut(5000);
    });
});
