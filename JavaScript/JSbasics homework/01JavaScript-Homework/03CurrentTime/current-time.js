var currentTime = new Date();
var hours = currentTime.getHours();
var minutes = currentTime.getMinutes();
if (minutes < 10) {
	console.log(hours + ":" + "0"+ minutes);
}
else {
	console.log(hours + ":"+ minutes);
}
