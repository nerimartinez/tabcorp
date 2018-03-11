tests({
    'formatTemperature': function () {
        eq("9.1º", formatTemperature(9.12));
    },

    'temperatureIsWrongShouldBeFalse': function () {
        var objForTest = { beer: { Name: "Beer 1", maxTemp: 6, minTemp: 4 }, currentTemp: 5 };

        eq(false, temperatureIsWrong(objForTest));
    },

    'temperatureIsWrongShouldBeTrue': function () {
        var objForTest = { beer: { Name: "Beer 1", maxTemp: 6, minTemp: 24 }, currentTemp: 5 };

        eq(true, temperatureIsWrong(objForTest));
    },

    'beerTempMarkup': function () {
        var objForTest = { beer: { Name: "Beer 1", maxTemp: 6, minTemp: 24 }, currentTemp: 5 };

        eq('<div class="beer-item"><strong>Beer 1:</strong><span id="Beer1">5.0º</span></div>',
            beerTempMarkup(objForTest));
    },

    'beerTempMarkup': function () {
        var objForTest = { beer: { Name: "Beer 1", maxTemp: 6, minTemp: 24 }, currentTemp: 5 };

        eq('<div class="beer-item"><strong>Beer 1:</strong><span id="Beer1">5.0º</span></div>',
            beerTempMarkup(objForTest));
    },
});