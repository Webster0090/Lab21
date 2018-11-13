var namePattern = /^[a-zA-Z]{2,}$/
var emailPattern = /^([A-z1-9]{2,})@([A-z1-9]{2,}).([A-z1-9]{2,})$/
var zipPattern = /^\d{5}$/
var phonePattern = /^([0-9]{3})( |-|())([0-9]{3})( |-|())([0-9]{4})$/
var passPattern = /^[A-Za-z0-9]{5,}$/



var ValidateFirstName = function () {
    if (namePattern.test(document.getElementById("firstName").value)) {
        document.getElementById("message").style.color = "green"
        document.getElementById("message").innerHTML = " Valid"
    }
    else {
        document.getElementById("message").innerHTML = " Invalid"
        document.getElementById("message").style.color = "red"
    }
}


var ValidateLastName = function () {
    if (namePattern.test(document.getElementById("lastName").value)) {
        document.getElementById("message2").style.color = "green"
        document.getElementById("message2").innerHTML = " Valid"
    }
    else {
        document.getElementById("message2").innerHTML = " Invalid"
        document.getElementById("message2").style.color = "red"
    }
}


var ValidatePhoneNumber = function () {
    if (phonePattern.test(document.getElementById("phoneNumber").value)) {
        document.getElementById("message5").style.color = "green"
        document.getElementById("message5").innerHTML = " Valid"
    }
    else {
        document.getElementById("message5").innerHTML = " Invalid"
        document.getElementById("message5").style.color = "red"
    }
}

var ValidateZipCode = function () {
    if (zipPattern.test(document.getElementById("zipCode").value)) {
        document.getElementById("message4").style.color = "green"
        document.getElementById("message4").innerHTML = "Valid"
    }
    else {
        document.getElementById("message4").innerHTML = "Invalid"
        document.getElementById("message4").style.color = "red"
    }
}

var ValidateEmail = function () {
    if (emailPattern.test(document.getElementById("email").value)) {
        document.getElementById("message3").style.color = "green"
        document.getElementById("message3").innerHTML = " Valid"
    }
    else {
        document.getElementById("message3").innerHTML = " Invalid"
        document.getElementById("message3").style.color = "red"
    }
}


var ValidatePassword = function () {
    if (passPattern.test(document.getElementById("password").value)) {
        document.getElementById("message6").style.color = "green"
        document.getElementById("message6").innerHTML = " Valid"
    }
    else {
        document.getElementById("message6").innerHTML = " Invalid"
        document.getElementById("message6").style.color = "red"
    }
}


var CheckPassword = function () {
    if (document.getElementById("password").value == document.getElementById("password2").value) {
        document.getElementById("matchMessage").style.color = "green"
        document.getElementById("matchMessage").innerHTML = " Passwords Match"
    }
    else {
        document.getElementById("matchMessage").innerHTML = " Passwords don't match"
        document.getElementById("matchMessage").style.color = "red"
    }
}
