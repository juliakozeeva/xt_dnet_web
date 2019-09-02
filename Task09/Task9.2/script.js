function calculateExpression() {
    var mathExpression = document.getElementById('textArea').value;
    var digitArray = String(mathExpression).match(/[0-9]+(\.[0-9]+)*/g);
    var operArray = String(mathExpression).match(/[+-]|[*/]|=/g);
    var expressionResult = digitArray[0] *1;
console.log(expressionResult);
    for (var i = 0; i < digitArray.length; i++) {
        if (operArray[i] != '=') {
            expressionResult = operation(expressionResult, digitArray[i+1], operArray[i]);
        }
    }
    expressionResult = expressionResult.toFixed(2);

    document.getElementById('result').innerHTML = expressionResult;
}

function operation(value, result, operation) {
    switch (operation) {
        case '+':
        {
            value += result * 1;
            break;
        }

        case '-':
        {
            value -= result;
            break;
        }

        case '*':
        {
            value *= result;
            break;
        }

        case '/':
        {
            value /= result;
            break;
        }

        default:
        {
            break;
        }
    }
    return value;
}