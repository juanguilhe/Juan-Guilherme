'use strict';

console.log('Hello world');


var mat1 = 23;
var mat2 = 26;

console.log(mat1 + mat2);

// primeiro teste em JavaScript com somas

let sorvete = "Baunilha";

if (sorvete === "Baunilha") {
    console.log("Sim, o que quero e o de Baunilha");
} else {
    console.warn("Não, eu quero o de Baunilha...")
}

// condição onde qual é o meu sorvete

function multiply(num1, num2) {
    var result = num1 * num2;
    console.log(result);

    multiply(4, 7);
    multiply(20, 20);
    multiply(0.5, 3);
    

    return result;
}