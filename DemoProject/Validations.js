//form 1

//function vfun() {
//    var uname = document.forms["myform"]["uname"].value;
//    var upswd = document.forms["myform"]["upswd"].value;

//    if (uname == null || uname == "") {
//        document.getElementById("errorBox").innerHTML =
//            "enter the user name";
//        return false;
//    }

//    if (upswd == null || upswd == "") {
//        document.getElementById("errorBox").innerHTML =
//            "enter the password";
//        return false;
//    }

//    if (uname != '' && upswd != '') {
//        alert("Login successfully");
//    }

//}

//Registration Form

function vfun1() {
    var uname1 = document.forms["RegisterForm"]["uname"].value;
    var email1 = document.forms["RegisterForm"]["email"].value;
    var upswd1 = document.forms["RegisterForm"]["password"].value;
    var upswd2 = document.forms["RegisterForm"]["confirmpassword"].value;


    //if (uname1 == null || uname1 == "") {
    //    document.getElementById("errorBox").innerHTML =
    //        "enter the user name";
    //    return false;
    //}

    //if (email1 == null || email1 == "") {
    //    document.getElementById("errorBox").innerHTML =
    //        "enter the email";
    //    return false;
    //}

    if (password == null || password == "") {
        document.getElementById("errorBox").innerHTML =
            "enter the password";
        return false;
    }

    if (confirmpassword == null || confirmpassword == "") {
        document.getElementById("errorBox").innerHTML =
            "enter the password";
        return false;
    }

    if (password != confirmpassword) {
        document.getElementById("errorBox").innerHTML =
            "password dont match";
        return false;
    }

}