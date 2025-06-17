function changeStyle(styleNumber) {
    const styleSheet = document.getElementById("styleSheet");

    if (styleNumber === 1) {
        styleSheet.href = "format1.css";
    } else if (styleNumber === 2) {
        styleSheet.href = "format2.css";
    } else if (styleNumber === 3) {
        styleSheet.href = "format3.css";
    }
}
function FormValidate() {
    const form = document.forms["contactusForm"];
    const id = form["idTxt"].value;
    const fname = form["fnameTxt"].value;
    const lname = form["lnameTxt"].value;
    const pwd = form["pwd"].value;
    const cpwd = form["cpwd"].value;
    if (id === "") {
        alert("Please enter Employee ID.");
        return false;
    }
    if (fname === "") {
        alert("Please enter First Name.");
        return false;
    }
    if (lname === "") {
        alert("Please enter Last Name.");
        return false;
    }
    if (pwd === "" || cpwd === "") {
        alert("Please enter both Password and Confirm Password.");
        return false;
    }
    if (pwd !== cpwd) {
        alert("Passwords do not match.");
        return false;
    }
    return true;
}

