function validateForm() {
    var isValid = true;
    $("#Menuname_Validation").text("");
    $("#Price_Validation").text("");
    $("#Des_Validation").text("");
    $("#Image_Validation").text("");
    $("#Cat_Validation").text("");

    //Validatiosn for menu list
    if ($("#MenuName").val().trim() == "") {
        $("#Menuname_Validation").text("This Field is Required");
        isValid = false;
    } if ($("#MenuPrice").val().trim() == "") {
        $("#Price_Validation").text("This Field is Required");
        isValid = false;
    } if ($("#MenuDescription").val().trim() == "") {
        $("#Des_Validation").text("This Field is Required");
        isValid = false;
    } if ($("#ImageUploader").val().trim() == "") {
        $("#Image_Validation").text("This Field is Required");
        isValid = false;
    } if ($("#CategoryId").val().trim() == "") {
        $("#Cat_Validation").text("This Field is Required");
        isValid = false;
    }
    if ($("#MenuPrice").val().trim() != "" && !numberRegex.test($("#MenuPrice").val().trim())) {
        $("#Price_Validation").text("Field is Invalid");
        isValid = false;
    }
    return isValid;
}
function submitForm() {
    if (validateForm()) {
        $("#Validations").submit();
    }
}