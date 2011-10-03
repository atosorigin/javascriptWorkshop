//In de hoofdstukken 1 en 2 schreven we het starten van het script als volgt:
//$(document).ready(function(){ 
//  ExecuteOnStartup();
//});

//Zodra je op internet gaat zoeken kom je al vaker de volgende nieuwe korte notatie tegen
//Deze notatie wordt op dit moment het meeste gebruikt.
$(function () {
    ExecuteOnStartup();
});

//Onder het motto: Kort-korter-korst kun je ook nog het volgende gebruiken:
//$(ExecuteOnStartup);

function ExecuteOnStartup() {

}

function animateDiv() {
    var selectedEffect = '';
    var config = { };
    var checkedButton = $(':checked', '#radio');

    switch (checkedButton[0].id) {
        case 'radio1': selectedEffect = 'fade'; break;
        case 'radio2': selectedEffect = 'bounce'; break;
        case 'radio3': selectedEffect = 'explode'; break;
    }


    $("#animationDiv").effect(selectedEffect, config, 500);
}
