var radius1 = 7;
var radius2 =1.5;
var radius3 = 20;
function calcCircleArea(){

var area = Math.PI*(Math.pow(radius1, 2));
console.log(area);
document.write("r = "+ radius1 +"; "+ "area ="+ area + "<br>");
area = Math.PI*(Math.pow(radius2, 2));
console.log(area);
document.write("r = "+ radius2 +"; "+ "area ="+ area + "<br>");
area = Math.PI*(Math.pow(radius3, 2));
console.log(area);
document.write("r = "+ radius3 +"; "+ "area ="+ area + "<br>");
}

calcCircleArea();


