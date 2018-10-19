var action = document.getElementById("action");
var checkBut = document.getElementById("check");
document.onkeypress = function (e) {
    var event = e || window.event;
    var key = event.which || event.keyCode || event.charCode;
    if (key == 13) {
        var pwd = document.getElementById("upwd").value;
        if (pwd.toLowerCase() == "jash") {
            /*action.style.visibility = "visible";*/
            window.location.href = "Home/Homepage";
        } else {
            alert("Password Incorrect - Please Re-enter the password again");
        }
    }
}
checkBut.onclick = function () {
    var pwd = document.getElementById("upwd").value;
    if (pwd.toLowerCase() == "jash") {
        /*action.style.visibility = "visible";*/
        window.location.href = "Home/Homepage"
    } else {
        alert("Password Incorrect - Please Re-enter the password again");
    }
}

   