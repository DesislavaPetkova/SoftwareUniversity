<!DOCTYPE html>
<html>

<head>
    <link rel="stylesheet" href="/content/styles.css" />
    <link rel="stylesheet" href="/content/bootstrap.min.css" />

    <title>
        <?php if (isset($this->title)) echo htmlspecialchars($this->title) ?>
    </title>
    <script src="//code.jquery.com/jquery-1.11.3.min.js"></script>
</head>

<body>
<header>
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="/posts/index">Blog</a>
            </div>

            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                <ul class="nav navbar-nav">
                    <li><a href="/posts/index">Posts</a></li>
                    <li><a href="/account/register">Register</a></li>
                    <li><a href="/account/login">Login</a></li>

                </ul>
                <?php if($this->isLoggedIn) : ?>
                <ul class="nav navbar-nav navbar-left">

                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li class="active"><a href="#" >Hello, <?php echo $_SESSION["username"];?></a></li>
                    <li><a href="/account/logout">Logout</a></li>
                </ul>

                <?php endif;?>
            </div>
        </div>
    </nav>
</header>
<aside id="right">
    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">List of Posts</h3>
        </div>
        <div class="panel-body">
            <ul>

            </ul>
        </div>
    </div>
</aside>
<main>


<?php include('messages.php'); ?>
