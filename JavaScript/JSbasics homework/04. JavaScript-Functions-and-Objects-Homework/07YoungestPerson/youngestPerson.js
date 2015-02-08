// Write a JavaScript function findYoungestPerson(persons) that accepts as parameter an array of persons, finds the youngest person and returns his full name. Write a JS program youngestPerson.js to execute your function for the below examples and print the result at the console.
function findYoungestPerson(persons) {	
	var minage = Number.MAX_VALUE;
	var younges = {};
	
	for (var i = 0; i < persons.length; i++) {
		if (persons[i].age < minage) {
			minage = persons[i].age;
			younges.firstname = persons[i].firstname;
			younges.lastname = persons[i].lastname;
		}
	}
	console.log('The youngest person is ' + younges.firstname+' ' + younges.lastname);
}
var persons = [
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 40}]
findYoungestPerson(persons);
