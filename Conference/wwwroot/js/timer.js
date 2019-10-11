function getTimeRemaining(endtime) {
    var t = Date.parse(endtime) - Date.parse(new Date());
    var days = Math.floor(t / (1000 * 60 * 60 * 24));
    return {
        'total': t,
        'days': days
    };
}

function initializeClock(id, endtime) {
    // debugger;
    var clock = document.getElementById(id);
    // var daysSpan = clock.querySelector('days');
    function updateClock() {
        var t = getTimeRemaining(endtime);

        clock.innerHTML = t.days;

        if (t.total <= 0) {
            clearInterval(timeinterval);
        }
    }

    updateClock();
    var timeinterval = setInterval(updateClock, 1000);
}

var deadline = new Date(2020, 1, 29, 0, 0, 0, 0);
