function validateForm() {
    var isValid = true;
    var emailRegex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    $("#Address_Validation").text("");
    $("#Mode_Validation").text("");
    $("#Email_ErrorMessage").text("");

    //Validations for payment
    if ($("#Email").val().trim() == "") {
        $("#Email_Validation").text("Email is Required");
        isValid = false;
    }
    if ($("#Email").val().trim() != "" && !emailRegex.test($("#Email").val().trim())) {
        $("#Email_Validation").text("Email is Invalid");
        isValid = false;
    }

    if ($("#Address").val().trim() == "") {
        $("#Address_Validation").text("Address is Required");
        isValid = false;
    }
    if ($("#ModeId").val().trim() == "") {
        $("#Mode_Validation").text("Mode of payment is Required");
        isValid = false;
    }
    return isValid;
}
function submitForm() {
    if (validateForm()) {
        $("#PaymentValidation").submit();
    }
}