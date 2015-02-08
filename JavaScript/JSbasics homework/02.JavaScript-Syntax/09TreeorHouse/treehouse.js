function treeHouseCompare(value, value1) {
 var a = value;
 var b = value1;
 var houseArea = Math.pow(a, 2)+ ((a* 2/3*a)/2);
 var treeArea= b*(b/3)+Math.PI*(Math.pow((b*2/3),2));
 if (houseArea>treeArea) {
 	console.log("house/"+houseArea.toFixed(2));
 } else {
 	console.log('tree/'+ treeArea.toFixed(2));
 }
}
treeHouseCompare(4, 5);