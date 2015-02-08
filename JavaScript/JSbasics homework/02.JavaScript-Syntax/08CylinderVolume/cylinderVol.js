function calcCylinderVol(radius, height){
 var result = Math.PI*Math.pow(radius, 2)*height;
 result = Math.round(result*1000) / 1000;
 console.log(result);
}
calcCylinderVol(2, 4);
calcCylinderVol(5, 8);
calcCylinderVol(12, 3);