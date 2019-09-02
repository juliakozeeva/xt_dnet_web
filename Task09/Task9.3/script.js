var leftSelect  = document.getElementById("left-select");
var rightSelect = document.getElementById("right-select");

function OneItemToRight() {
    var selectedItem = leftSelect[leftSelect.selectedIndex];
    try{
        rightSelect.appendChild(selectedItem);
        rightSelect[rightSelect.selectedIndex].selected = false;
    }
    catch {
        alert("Select something.");
    }
}

function AllItemsToRight() {
    while(leftSelect[0] !== undefined)
    {
        rightSelect.appendChild(leftSelect[0]);
    }
}

function OneItemToLeft() {
    var selectedItem = rightSelect[rightSelect.selectedIndex];
    try {
        leftSelect.appendChild(selectedItem);
        leftSelect[leftSelect.selectedIndex].selected = false;
    }
    catch {
        alert("Select something.");
    }
}
function AllItemsToLeft() {
    while(rightSelect[0] !== undefined)
    {
        leftSelect.appendChild(rightSelect[0]);
    }
}