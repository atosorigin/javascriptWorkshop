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
    var config = {
        autoOpen: false,
        resizable: false,
        draggable: true,
        modal: true,
        height: 500,
        title: 'My dialog title',
        buttons: { Ok: function () { $(this).dialog("close"); } },
        open: function () { $('#dialogState').html('Dialog opened'); },
        close: function () { $('#dialogState').html('Dialog closed'); },
        dragStart: function () { $('#dialogState').html('Dialog drag started'); },
        dragStop: function () { $('#dialogState').html('Dialog drag stopped'); }
    };

    $('#myDialog').dialog(config);
    $('#openDialogButton').click(function () { $('#myDialog').dialog('open'); });

    $('#myDate').datepicker({ firstDay: 1, dateFormat: 'dd-mm-yy' });
}