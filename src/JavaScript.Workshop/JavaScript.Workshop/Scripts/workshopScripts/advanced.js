$(ExecuteOnStart);

function ExecuteOnStart() {
    $('#nupuntnl').onlyOne('on').text('Public link');
    //$('button').button();

    var person = new Person();
    var person2 = new Person();
    alert(person.MyName);
    person.ChangeLastName("Spencer");
    alert(person.MyName);
    var dog = new Dog();
    dog.Listen(person);
    $('#shoutQuiet').click(function () { person.Shout('Quiet'); });
    $('#shoutBark').click(function () { person.Shout('Bark'); });
}

function Person() {
    var self = this;
    var firstName = 'Bill';
    var lastName = last;
    this.MyName = firstName + ' ' + lastName;

    var fullName = function () {
        self.MyName = firstName + ' ' + lastName;
        return self.MyName;
    };

    var changeLastName = function (newLastName) {
        lastName = newLastName;
        self.MyName = fullName();
    };

    this.Shout = function (word) {
        $(self).trigger('shout', word);
    };

    return {
        ChangeLastName: changeLastName
    };
};

function Dog() {
    var self = this;
    var state = 'Barking';
    var timer = null;

    var loop = function () {
        if (state == 'Barking') {
            alert('Woof woof');
        }
        setTimeout(loop, 2500);
    };

    var listenToWord = function (speaker, word) {
        var previousState = state;
        switch (word) {
            case 'Quiet': state = 'Quiet'; break;
            case 'Bark': state = 'Barking'; break;
        }
        if(previousState != state) {
            $(self).trigger('stateChanged', state);
        }
    };

    this.Listen = function (boss) {
        $(boss).bind('shout', listenToWord);
    };

    //Start living
    loop();
};

(function ($) {
    $.fn.onlyOne = function (mode) {
        var mode = mode || 'off';
        if (mode != 'off') {
            if (this.length == 1) {
                if (mode != 'on') {
                    alert('Information: one object found.');
                }
            }
            else {
                alert('Warning: not one but '
               + this.length + ' objects expected.');
            }
        }
        // do not break the normal flow;
        return $(this);
    };
})(jQuery);


