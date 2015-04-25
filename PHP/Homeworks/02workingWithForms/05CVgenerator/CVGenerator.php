<?php
if(isset($_POST['submit'])){
$check = false;
$checkArr=array(false, false, false, true,);
    if (mb_strlen($_POST['fName']) > 2 && mb_strlen($_POST['fName']) < 20){
        $checkArr[0] = true;
    }
    if (mb_strlen($_POST['lName']) > 2 && mb_strlen($_POST['lName']) < 20){
        $checkArr[1] = true;
    }
    if (mb_strlen($_POST['company']) > 2 && mb_strlen($_POST['company']) < 20){
        $checkArr[2] = true;
    }
//    if (mb_strlen($_POST['language']) > 2 && mb_strlen($_POST['language']) < 20){
//        $checkArr[3] = true;
//    }
    if (in_array($check, $checkArr)){
        echo 'Fields First Name, Last Name, Company Name and Language requires only letters between 2 and 20
        symbols!';
        die;
    }

    if (!preg_match('/[^0-9\+\-\s]/', $_POST['phone']) != 1) {

        echo "Invalid Phone Number";
        die;

    }
echo('
    <style>
    table {
    border: 1px solid black;
    }
     table td {
            border:1px solid black;
            border-collapse: collapse;}
    table th {
            border:1px solid black;
            border-collapse: collapse;}
    </style>
    <table>
    <tr><th colspan="2">Personal Information</th></tr>
    <tr>
        <td>First Name</td>
        <td>'.htmlspecialchars($_POST['fName']).'</td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td>'.htmlspecialchars($_POST['lName']).'</td>
    </tr>
    <tr>
        <td>Email</td>
        <td>'.htmlspecialchars($_POST['email']).'</td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td>'.$_POST['phone'].'</td>
    </tr>
    <tr>
        <td>Gender</td>
        <td>'.$_POST['sex'].'</td>
    </tr>
    <tr>
        <td>Birth Date</td>
        <td>'.$_POST['date'].'</td>
    </tr>
    <tr>
        <td>Nationality</td>
        <td>'.$_POST['nationality'].'</td>
    </tr>

</table>');
echo('<br>
    <table>
    <tr><th colspan="2">Last Work Position</th></tr>
    <tr>
        <td>Company Name</td>
        <td>'.$_POST['company'].'</td>
    </tr>
    <tr>
        <td>From</td>
        <td>'.$_POST['fromDate'].'</td>
    </tr>
    <tr>
        <td>To</td>
        <td>'.$_POST['toDate'].'</td>
    </tr>
</table>');



echo('<br>
<table>
	<tr><th colspan="2">Computer Skills</th></tr>
	<tr><td>Programming Languages</td><td>
		<table>
			<tr>
				<th>Language</th><th>Skill Level</th>
			</tr>
            ');
    $languages = $_POST['language'];
    $level = $_POST['languageLevel'];
    for ($i = 0; $i < count($_POST['languageLevel']); $i++) {
      echo'<tr><td>'.$languages[$i].'</td><td>'.$level[$i].'</td></tr>';
    }

echo('</table>
</table>');
echo('<br>
<table>
	<tr><th colspan="5">Other Skills</th></tr>
	<tr><td> Languages</td><td>
		<table>
			<tr>
				<th>Language</th><th>Comprehension</th><th>Reading</th><th>Writing</th>
			</tr>
            ');
    $language = $_POST['languages'];
    $comprehension = $_POST['comprehension'];
    $reading = $_POST['reading'];
    $writing = $_POST['writing'];

    for ($i = 0; $i < count($_POST['comprehension']); $i++) {
        echo'<tr><td>'.$language[$i].'</td><td>'.$comprehension[$i].'</td><td>'.$reading[$i].'</td><td>'.$writing[$i]
            .'</td></tr>';
    }
    $driver = $_POST['driver'];
    echo '<tr><td colspan="4">'.implode(", ", $driver).'</td></tr>';
    echo('</table>');
    die;
}
?>

<!DOCTYPE html>
<html>
<head>
    <style>
        table tr td {
            border: 1px double black;
            border-collapse: collapse;}
        input {
            display: block;
        }
        input[type="radio"] {
            display: inline-block;
        }
        input[type="button"] {
            display: inline-block;
        }
        input[type="checkbox"]{
            display: inline-block;
        }
    </style>
    <meta charset="UTF-8"/>
    <title>CV Generator</title>
</head>
<body>
<script>
    var nextId = 0;
    var nextLang = 0;
    function addInput(){
        nextId++;
    var newInput = document.createElement('div');
    newInput.setAttribute('id', nextId);
    newInput.innerHTML= "<input type=\"text\"  name=\"language[]\" style=\"display: inline-block\"/>"+
        "<select name=\"languageLevel[]\" style=\"display: inline-block\">"+
        "<option value=\"Beginner\">Beginner</option>"+
        "<option value=\"Programmer\">Programmer</option>"+
        "<option value=\"Ninja\">Ninja</option>"+
        "</select><br>";
    document.getElementById('parent').appendChild(newInput);
    }
    function removeInput(id){
        var newInput = document.getElementById(nextId);
        document.getElementById('parent').removeChild(newInput);
        nextId-=1;
    }
    function addLanguages(){
        nextLang++;
        var newInput = document.createElement('div');
        newInput.setAttribute('id', nextLang);
        newInput.innerHTML= "<input type=\"text\" id=\"languages\" name=\"languages[]\" style=\"display: " +
            "inline-block\"/>"+
        "<select name=\"comprehension[]\" id=\"comprehension\">"+
            "<option value=\"default\">-Comprehension-</option>"+
        "<option value=\"beginner\">beginner</option>"+
        "<option value=\"intermediate\">intermediate</option>"+
        "<option value=\"advanced\">advanced</option>"+
        "</select>"+
        "<select name=\"reading[]\" id=\"reading\">"+
            "<option value=\"default\">-Reading-</option>"+
        "<option value=\"beginner\">beginner</option>"+
        "<option value=\"intermediate\">intermediate</option>"+
        "<option value=\"advanced\">advanced</option>"+
        "</select>"+
        "<select name=\"writing[]\" id=\"writing\">"+
            "<option value=\"default\">-Writing-</option>"+
        "<option value=\"beginner\">beginner</option>"+
        "<option value=\"intermediate\">intermediate</option>"+
        "<option value=\"advanced\">advanced</option>"+
        "</select><br>";
        document.getElementById('parents').appendChild(newInput );
    }
    function removeLanguages(id){
        var newInput = document.getElementById(nextLang);
        document.getElementById('parents').removeChild(newInput);
        nextLang-=1;
    }
</script>
<form action="<?php $_PHP_SELF?>" method="POST">
    <fieldset>
        <legend>Personal Information</legend>
        <input type="text" name="fName" placeholder="FirstName"/>
        <input type="text" name="lName" placeholder="LastName"/>
        <input type="email" name="email" placeholder="Email"/>
        <input type="text" name="phone" placeholder="PhoneNumber"/>
        <input type="radio" name="sex" value="Female"/>Female
        <input type="radio" name="sex" value="Male"/>Male<br>
        <label for="birthDate">Birth Date</label>
        <input type="date" name="date"/>
        <select name="nationality" id="nationality">
            <option value="Bulgarian">Bulgarian</option>
            <option value="Spanish">Spanish</option>
        </select>

    </fieldset>
    <fieldset>
        <legend>Last Work Position</legend>
        <label for="company">Company Name</label>
        <input type="text" name="company" id="company"/>
        <label for="from">From</label>
        <input type="date" id="from" name="fromDate"/>
        <label for="to">To</label>
        <input type="date" name="toDate" id="to"/>
    </fieldset>
    <fieldset >
        <legend>Computer Skills</legend>
        <div id="parent">
            <label for="language" style="display: block">Programming Languages</label>
            <input type="text"  name="language[]" style="display: inline-block;margin-right: 0px;"/>
            <select name="languageLevel[]" id="languageLevel" style="display: inline-block; border-left-width: 1px;margin-left: 0px;">
                <option value="Beginner">Beginner</option>
                <option value="Programmer">Programmer</option>
                <option value="Ninja">Ninja</option>
            </select><br>
        </div>
        <a href="javascript:removeInput(nextId)"><input type="button" name="remove" value="Remove Language"/></a>
        <a href="javascript:addInput()"><input type="button" name="add" value="Add Language"/></a>
    </fieldset>
    <fieldset>
        <legend>Other Skills</legend>
        <div id="parents">
        <label for="languages" style="display: block">Languages</label>
        <input type="text" id="languages" name="languages[]" style="display: inline-block"/>
        <select name="comprehension[]" id="comprehension">
            <option value="default">-Comprehension-</option>
            <option value="beginner">beginner</option>
            <option value="intermediate">intermediate</option>
            <option value="advanced">advanced</option>
        </select>
        <select name="reading[]" id="reading">
            <option value="default">-Reading-</option>
            <option value="beginner">beginner</option>
            <option value="intermediate">intermediate</option>
            <option value="advanced">advanced</option>
        </select>
        <select name="writing[]" id="writing">
            <option value="default">-Writing-</option>
            <option value="beginner">beginner</option>
            <option value="intermediate">intermediate</option>
            <option value="advanced">advanced</option>
        </select><br>
        </div>
        <a href="javascript:removeLanguages(nextLang)"><input type="button" name="remove" value="Remove Language"/></a>
        <a href="javascript:addLanguages()"><input type="button" name="add" value="Add Language"/></a><br>
        <label for="driver">Driver's License</label>
        <input type="checkbox" name="driver[]" value="B"/>B
        <input type="checkbox" name="driver[]" value="A"/>A
        <input type="checkbox" name="driver[]" value="C"/>C
    </fieldset>
    <input type="submit" value="Generate CV" name="submit"/>
</form>
</body>
</html>

