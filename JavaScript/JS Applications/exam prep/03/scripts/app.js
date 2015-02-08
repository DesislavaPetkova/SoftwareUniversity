(function () {
	
	$(function() {
        eventHandlers();
        var currentUser = userSession.getCurrentUser();
	        if (currentUser) {
	            BookmarksView();
	        } else {
	            homeView();
	        }
	        
	    });

	function eventHandlers () {
		$('header > h1').click(homeView);
		$('#homeLogin').click(loginView);
		$('#homeRegister').click(registerView);
		$('#loginHere').click(loginView);
		$('#registerHere').click(registerView);
		$('#register').click(registerClicked);
		$('#login').click(loginClicked);
	}

	function homeView () {
		var currentUser = userSession.getCurrentUser();
	        if (currentUser) {
	            BookmarksView();
	        } else {
	            $('#wrapper > *').hide();
				$('#homeView').show();
	        }
		
	}

	function loginView () {
		$('#wrapper > *').hide();
		$('#loginView').show();
	}

	function registerView () {
		$('#wrapper > *').hide();
		$('#registerView').show();
	}

	function bookmarksView () {
		$('#wrapper > *').hide();
		$('#bookmarksView').show();
	}



	function registerClicked () {
		var username = $('#registerUsername').val();
		var password = $('#registerPassword').val();
		ajaxRequester.register(username, password,  function (data) {
			showInfoMessage("Register successful!");

		}, registerError);
	}


	function loginClicked () {
		var username = $('#loginUsername').val();
		var password = $('#loginPassword').val();
		ajaxRequester.login(username, password, function (data) {
			userSession.login(data);
			showBookmarks();
		}, loginError);
	}

	function showBookmarks () {
		$('#wrapper > *').hide();
		$('#bookmarksView').show();
		var currentUser = userSession.getCurrentUser();

		$('header h1').text("Bookmarks - "+ currentUser.username);
		var logout = $('<a id="logout">Logout</a>');
		logout.attr('href', "#");
		$('header').append(logout);
		ajaxRequester.getBookmarks(null, loadBookmarks, bookmarksError)
	}

	function loadBookmarks (data) {
		for(b in data.results){
			var bookmark = data.results[b];
			var bookmarkLi = $('<li>');
			var title = $('<div class="title">');
			title.text(bookmark.title);
			bookmarkLi.append(title);
			var url = $('<a class="url">');
			url.text(bookmark.url);
			url.attr('href', bookmark.url)
			bookmarkLi.append(url);

			var deleteButton = $('<a href="#">Delete</a>');
            // deleteButton.click(deleteBookmarkButtonClicked);
            bookmarkLi.append(deleteButton);

            $('#bookmarksList').append(bookmarkLi);
		}
	}


	function deleteBookmarkButtonClicked () {
		// body...
	}

	// Messages -----------**<<
	function registerError (error) {
		showAjaxError('Register failed', error);
	}


	function showInfoMessage(msg) {
        noty({
                text: msg,
                type: 'info',
                layout: 'topCenter',
                timeout: 5000}
        );
    }

    function showErrorMessage(msg) {
        noty({
                text: msg,
                type: 'error',
                layout: 'topCenter',
                timeout: 5000}
        );
    }

    function showAjaxError(msg, error) {
        var errMsg = error.responseJSON;
        if (errMsg && errMsg.error) {
            showErrorMessage(msg + ": " + errMsg.error);
        } else {
            showErrorMessage(msg + ".");
        }
    }

    function loginError(error) {
        showAjaxError("Login failed", error);
    }

    function bookmarksError (error) {
    	showErrorMessage("Bookmarks failed: " + error)
    }

}());