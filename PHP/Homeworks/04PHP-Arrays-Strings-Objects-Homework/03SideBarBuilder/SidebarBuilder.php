<?php
/**
 * Created by PhpStorm.
 * User: *******
 * Date: 21/08/14
 * Time: 19:23
 * Write a PHP program SidebarBuilder.php that takes data from several input fields and builds 3 sidebars. The input fields are categories, tags and months. The first sidebar should contain a list of the categories, the second sidebar – a list of the tags and the third should contain the months. The entries in the input strings will be separated by a comma and space ", ". Styling the page is optional. Semantic HTML is required.
 */

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
	<title>SidebarBuilder</title>
    <style>
        aside {
            width: 150px;
            border: 1px solid black;
            border-radius: 15px;
            margin: 10px 0;
            background-color: lightslategray;
        }
        h2 {
            text-align: center;
        }
        ul li {
            list-style-type: circle;

        }
    </style>
</head>
<body>
<form action="<?php $_PHP_SELF ?>" method="post" style="display: inline-block;">
    <label for="categories">Categores: </label>
    <input type="text" name="categories" id="categories"/><br>
    <label for="tags">Tags: </label>
    <input type="text" name="tags" id="tags"/><br>
    <label for="months">Months: </label>
    <input type="text" id="months" name="months"/><br>
    <input type="submit" name="submit" value="Generate"/>
</form>
<aside>
    <h2>Categories</h2>
    <hr style="width: 95%"/>
    <ul>
<?php
    if (isset($_POST['submit'])){
        $arrCat = explode(', ', $_POST['categories']);
        $arrTags = explode(', ', $_POST['tags']);
        $arrMonths = explode(', ', $_POST['months']);
        for ($i = 0; $i < count($arrCat); $i++) {
            echo('<li><a href="#">'.$arrCat[$i].'</a></li>');
        }

?>
    </ul>
</aside>
<aside>
    <h2>Tags</h2>
    <hr style="width: 95%"/>
    <ul>
<?php
    for ($i = 0; $i < count($arrTags); $i++) {
        echo('<li><a href="#">'.$arrTags[$i].'</a></li>');
    }
?>
    </ul>
</aside>
<aside>
    <h2>Months</h2>
    <hr style="width: 95%"/>
    <ul>
    <?php
        for ($i = 0; $i < count($arrMonths); $i++) {
            echo('<li><a href="#">'.$arrMonths[$i].'</a></li>');
        }
}
    ?>
    </ul>
</aside>

</body>
</html>
