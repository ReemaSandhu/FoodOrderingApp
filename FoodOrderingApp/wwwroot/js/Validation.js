function validateForm() {
    var isValid = true;
    var numberRegex = /^[0-9]*$/;
    $("#NoOfPeople_Validation").text("");
    $("#Name_Validation").text("");
    $("#Date_Validation").text("");

    //Validations for table Reservation
    if ($("#NoOfPeople").val().trim() == "") {
        $("#NoOfPeople_Validation").text("This field is Required");
        isValid = false;
    }
    
    if ($("#NoOfPeople").val().trim() != "" && !numberRegex.test($("#NoOfPeople").val().trim())) {
        $("#NoOfPeople_Validation").text("Field is Invalid");
        isValid = false;
    }
    if ($("#Name").val().trim() == "") {
        $("#Name_Validation").text("Name is Required");
        isValid = false;
    }
    if ($("#DateOfReservation").val().trim() == "") {
        $("#Date_Validation").text("This Field is Required");
        isValid = false;
    }
    return isValid;
}
function submitForm() {
    if (validateForm()) {
        $("#Validations").submit();
    }
}