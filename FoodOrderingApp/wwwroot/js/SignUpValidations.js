function validateForm() {
    var isValid = true;
    var emailRegex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    var passwordRegex = /^[a-zA-Z0-9!"#\$%&'\(\)\*\+,-\.\/:;<=>\?@[\]\^_`\{\|}~]{8,10}$/;
    $("#Name_Validation").text("");
    $("#Email_Validation").text("");
    $("#Password_Validation").text("");
    $("#Role_Validation").text("");

    //validatiosn for signup
    if ($("#UserName").val().trim() == "") {
        $("#Name_Validation").text("User Name is Required");
        isValid = false;
    }
    if ($("#Password").val().trim() == "") {
        $("#Password_Validation").text("This Field is Required");
        isValid = false;
    }
    if ($("#Password").val().trim() != "" && !passwordRegex.test($("#Password").val().trim())) {
        $("#Password_Validation").text("Password should have 8 to 10 charcters with atleast one lower case,one upper case,one special and one number");
        isValid = false;
    }
    if ($("#RoleId").val().trim() == "") {
        $("#Role_Validation").text("This Field is Required");
        isValid = false;
    }
    if ($("#Email").val().trim() == "") {
        $("#Email_Validation").text("Email is Required");
        isValid = false;
    }
    if ($("#Email").val().trim() != "" && !emailRegex.test($("#Email").val().trim())) {
        $("#Email_Validation").text("Email is Invalid");
        isValid = false;
    }
    
    return isValid;
}
function submitForm() {
    $("#Name_Validation").text("");
    $("#Email_Validation").text("");
    $("#Password_Validation").text("");
    $("#Role_Validation").text("");
    if (validateForm()) {
        $("#SignUpValidation").submit();
    }
}