function removeDoubleChars() {
    var stringInput = document.getElementById('textArea').value;
    var uniqueString = stringInput.split(' ');
    var newString = '';
    var repeatingChar = '';
    var uniqueWords = '';
    var word = '';
    for (var i = 0; i < uniqueString.length; i++) {
        word = uniqueString[i];
        for (var j = 0; j < word.length; j++) {
            if (word.lastIndexOf(word[j]) != word.indexOf(word[j])) {
                repeatingChar += word[j];
            }
        }
    }
    for (var i = 0; i < uniqueString.length; i++) {
        word = uniqueString[i];
        console.log(word);
        for (var j = 0; j < word.length; j++) {
            if (!(repeatingChar.indexOf(word[j]) > -1)) {
                uniqueWords += word[j];
            }
        }
        newString += ' ' + uniqueWords;
        uniqueWords = '';
    }
    document.getElementById('result').innerHTML = newString;
}