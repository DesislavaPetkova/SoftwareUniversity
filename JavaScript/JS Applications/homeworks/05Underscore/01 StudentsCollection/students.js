(function () {
	if (typeof require !== 'undefined') {
		//load underscore if on Node.js
		_ = require('../node_modules/underscore/underscore.js');
	}


	var students  = [{"gender":"Male","firstName":"Joe","lastName":"Riley","age":22,"country":"Russia"},
	{"gender":"Female","firstName":"Lois","lastName":"Morgan","age":41,"country":"Bulgaria"},
	{"gender":"Male","firstName":"Roy","lastName":"Wood","age":33,"country":"Russia"},
	{"gender":"Female","firstName":"Diana","lastName":"Freeman","age":40,"country":"Argentina"},
	{"gender":"Female","firstName":"Bonnie","lastName":"Hunter","age":23,"country":"Bulgaria"},
	{"gender":"Male","firstName":"Joe","lastName":"Young","age":16,"country":"Bulgaria"},
	{"gender":"Female","firstName":"Kathryn","lastName":"Murray","age":22,"country":"Indonesia"},
	{"gender":"Male","firstName":"Dennis","lastName":"Woods","age":37,"country":"Bulgaria"},
	{"gender":"Male","firstName":"Billy","lastName":"Patterson","age":24,"country":"Bulgaria"},
	{"gender":"Male","firstName":"Willie","lastName":"Gray","age":42,"country":"China"},
	{"gender":"Male","firstName":"Justin","lastName":"Lawson","age":38,"country":"Bulgaria"},
	{"gender":"Male","firstName":"Ryan","lastName":"Foster","age":24,"country":"Indonesia"},
	{"gender":"Male","firstName":"Eugene","lastName":"Morris","age":37,"country":"Bulgaria"},
	{"gender":"Male","firstName":"Eugene","lastName":"Rivera","age":45,"country":"Philippines"},
	{"gender":"Female","firstName":"Kathleen","lastName":"Hunter","age":28,"country":"Bulgaria"}];

	
	var ageBetween = _.filter(students, function(students) {
		return (students.age >=18 && students.age <=24);
	})
	// console.log(ageBetween);

	var alphabeticNames = _.sortBy (students, (students.firstName - students.lastName));
	// console.log(alphabeticNames);

	var peopleFromBg = _.filter(students, function (students) {
		if (students.country == "Bulgaria") {
			return students.firstName
		}else{
			return;
		}		
	})
	// console.log(peopleFromBg);

	var lastFive = _.last(students, 5);
	// console.log(lastFive);

	var firstThree = _.filter(students, function (students) {
		return students.country != "Bulgaria" && students.gender == "Male";
	});
	// console.log(_.first(firstThree, 3));

}());
