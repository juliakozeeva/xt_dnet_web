var page;
var timer;
var start = false;
var setInterval = 5;
var endPage = 3;
var startPage = 1;

function setPage(num) {
    page = num;
}

function countDown() {
    document.getElementById('time').innerHTML = setInterval;
    if (setInterval < 1) {
        if (page !== endPage){
            clearTimeout(timer);
            page++;
            window.location.href = 'page' + page + '.html';
        }else{
            clearTimeout(timer);
            if (confirm("Начать отсчет заново?"))
                window.open("page1.html", '_self');
            else{
                var watchOver = document.getElementById("watch-over");
                watchOver.setAttribute("style", "display:block;");
                document.body.innerHTML = watchOver.outerHTML;
            }
        }

        }
    setInterval--;
    timer = setTimeout('countDown()', 1000);
    start = true;
}
function Pause() {
    if (start === false) {
        timer = setTimeout('countDown()', 1000);
        start = true;
    }
    else {
        clearTimeout(timer);
        start = false;
    }
}
function toNextPage() {
    if (page === 3) {
        alert("Can't go any further.");
    }
    else {
        page++;
        window.location.href = 'page' + page + '.html';
    }
}
function toPreviousPage() {
    if (page === 1) {
        alert("Can't go any further.");
    }
    else {
        page--;
        window.location.href = 'page' + page + '.html';
    }
}
