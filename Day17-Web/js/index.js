document.querySelector("#submit").onclick = function(e) {
    let regex = new RegExp('.*password.*');
    let password = document.getElementById("password").value;
    if (regex.test(password)) {
        alert('Thats not a very strong password!');
    }
}
