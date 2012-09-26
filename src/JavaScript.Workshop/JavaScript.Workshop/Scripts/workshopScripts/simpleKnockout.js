/// <reference path="jquery-1.6.4-vsdoc.js" />
/// <reference path="knockout-1.3.0beta.debug.js" />
/// <reference path="knockout.mapping-latest.debug.js" />

$(function () {
    var clientViewModel = ko.mapping.fromJS(serverViewModel);

    clientViewModel.FullAddress = ko.dependentObservable(function () {
        return this.Address.Number() + ' ' + this.Address.Street();
    }, clientViewModel);

    clientViewModel.FamilyInfo = ko.dependentObservable(function () {
        return this.Id() + ' ' + this.FamilyName();
    }, clientViewModel);

    clientViewModel.doSomethingNifty = function () {
        if (this.IsScary()) {
            alert("Booh!");
        }
        else {
            alert("I could do some Ajax stuff here with Id "
                  + this.Id() + ' and family ' + this.FamilyName());
        }
    };

    ko.applyBindings(clientViewModel);
});


$(function () {
    var clientViewModel = ko.mapping.fromJS(serverViewModel);

    //de overige ViewModel code staat hier
    var isScarySubscription =
        clientViewModel.IsScary.subscribe(OnIsScareChanged);

    ko.applyBindings(clientViewModel);
});

function OnIsScareChanged(isScary) {
    if (isScary) {
        $('#didYouKnow').show(500);
    }
    else {
        $('#didYouKnow').hide(250);
    }
}
