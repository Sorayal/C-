// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
const currentDate = new Date();
const currentYear = currentDate.getFullYear();
const currentMonth = currentDate.getMonth() + 1;
const currentDay = currentDate.getDate();


$("#buttonAlter").click(function () {

    let eingabeAlter = $("#datumsEingabe").val().split('-');
    let year = parseInt(eingabeAlter[0]);
    let month = parseInt(eingabeAlter[1]);
    let day = parseInt(eingabeAlter[2]);

    //Prüfung-----------------------------------------------------
    if (eingabeAlter == "") {
        $("#ergebnis").html("<p>Bitte Datum eingeben!</p>");
        return;
    }
    else if (day > currentDay && month == currentMonth && year == currentYear) {
        $("#ergebnis").html("<p>Bitte gültigen Tag eingeben!</p>");
        return;
    }
    else if (month > currentMonth && year == currentYear) {
        $("#ergebnis").html("<p>Bitte gültigen Monat eingeben!</p>");
        return;
    }
    else if (year > currentYear) {
        $("#ergebnis").html("<p>Bitte gültiges Jahr eingeben!</p>");
        return;
    }

    result = currentYear - year;
    if (month > currentMonth) {
        result--;
    }
    if (month == currentMonth && day > currentDay) {
        result--;
    }
   
    //Lokal berechnet
    $("#ergebnis").html("<p>Sie sind " + result + " Jahre alt.</p>");

});