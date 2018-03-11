'use strict'

function formatTemperature(temp) {
    return temp.toFixed(1).toString() + "º";
}

function temperatureIsWrong(beerContainer) {
    return beerContainer.currentTemp >= beerContainer.beer.maxTemp || beerContainer.currentTemp <= beerContainer.beer.minTemp;
}

function beerTempMarkup(beerContainer) {
    var temp = formatTemperature(beerContainer.currentTemp);
    return '<div class="beer-item"><strong>' + beerContainer.beer.Name + ':</strong><span id="' + beerContainer.beer.Name.replace(/\s/g, '') + '">' + temp + '</span></div>'
}

function toggleWarningClass(elem, beerContainer) {
    if (temperatureIsWrong(beerContainer)) {
        elem.addClass("warning");
    } else {
        elem.removeClass("warning");
    };
}

$(function () {
    var breweryHub = $.connection.breweryHub;
    var beers = [];

    breweryHub.client.beersTemps = function (temp) {
        if (beers.length == 0) {
            beers = temp;
            var tempsContainer = $('#container')
            for (var i = 0; i < temp.length; i++) {
                var beerContainer = temp[i];
                tempsContainer.append(beerTempMarkup(beerContainer));
            }
        } else {            
            for (i = 0; i < temp.length; i++) {
                var beerContainer = temp[i];
                var temperature = formatTemperature(beerContainer.currentTemp);
                var elem = $('#' + beerContainer.beer.Name.replace(/\s/g, ''));
                
                toggleWarningClass(elem, beerContainer);
                elem.text(temperature);
            }
        }
    }

    $.connection.hub.start().done(function () {
        breweryHub.server.initTimer();
    });
});