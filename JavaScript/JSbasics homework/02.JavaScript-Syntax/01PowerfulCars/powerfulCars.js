var kw = prompt("Enter ur KW here:", "");
function convertKWtoHP(prompt){
phResult = kw/0.746;
phResult = Math.round(phResult * 100) / 100;
console.log(phResult);
document.write(phResult);
}

convertKWtoHP();
