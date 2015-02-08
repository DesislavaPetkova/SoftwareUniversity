(function () {
	
	$(function() {
        eventHandlers();

        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            userView()
        } else {
            homeView();
        }
    });


	function eventHandlers () {
		$('#homeView').click(homeView);
		$('#useHome').click(userView);
		$('#homeLogin').click(loginView);
		$('#guestLogin').click(loginView);
		$('#homeRegister').click(registerView);
		$('#orLogin').click(loginView);
		$('#orRegister').click(registerView);
		$('#register-button').click(registerClicked);
		$('#loginView #login-button').click(loginClicked);
		$('#logout').click(logoutEvent);
		$('#addProduct').click(addProductView);
		$('#add-product-button').click(addProduct);
		$('#products').click(productsView);				
		$(document).on('click', 'button.delete-button', deleteProduct);
		$(document).on('click', 'button.edit-button', function  () {
			currentId = event.target.id;			
			editView();
		});
		$('#cancelAdd').click(productsView);
		$('#editCancel').click(productsView);
		$('#edit-product-button').click(editProduct);
	}

	function homeView () {		
        $('#main > *').hide();
        $('#menuUser').hide();
		$('#welcomeGuest').show();
	        
	}

	function loginView () {
		$('#main > *').hide();
		$('#loginView').show();
	}

	function registerView () {
		$('#main > *').hide();
		$('#menuUser').hide();
		$('#registerForm').show();
	}	

	function userView () {
		var currentUser = userSession.getCurrentUser();		
		$('#main > *').hide();
		$('#menuUser').show();
		$('#menuGuest').hide();
		$('#welcomeUser').show();
		$('#loginHeader').text("Welcome, " + currentUser.username+"!");
	}

	function editView () {
		$('#main > *').hide();
		$('#editForm').show();	

	}


	function registerClicked () {		
		var username = $('.register-form #username').val();		
		var password = $('.register-form #password').val();
		var passcheck = $('.register-form #confirm-password').val();
		if(password != passcheck){
			showErrorMessage("Passwords doesnt match!");
		}else{
			ajaxRequester.register(username, password,  function (data) {
			showInfoMessage("Register successful!");
			}, registerError);
		}
		
	}


	function loginClicked () {
		var username = $('#loginView #username').val();
		var password = $('#loginView #password').val();
		ajaxRequester.login(username, password, function (data) {
			userSession.login(data);

			userView();
		}, loginError);
	}

	function logoutEvent () {
		homeView();		
		userSession.logout();
		showInfoMessage('Successfuly loged out!');
	}

	function addProductView () {
		$('#main > *').hide();
		$('#addProductForm').show();
	}

	function addProduct () {
		var currentUser = userSession.getCurrentUser();
		var name = $('#name').val();
		var category = $('#category').val();
		var price = $('#price').val();

		ajaxRequester.addProduct(name, category, price, currentUser.objectId, showInfoMessage('Product created'), showErrorMessage());
		productsView();

	}

	function productsView () {
		var currentUser = userSession.getCurrentUser();	
		if (currentUser) {            
            $('#main > *').hide();
			$('#productsView').show();				
			var sessionToken = currentUser.sessionToken;
			ajaxRequester.getProducts(sessionToken, loadProducts, loadProductsError)
        } else {
            userView();
        }
		
	}

	function loadProducts (data) {
		for(p in data.results){
			var product = data.results[p];
			var productLi = $('<li>');
			productLi.attr('class', 'product');			

			var div = $('<div>');
			div.attr('class', 'product-info');
			

			var name = $('<p>');
			name.attr('class', 'item-name');
			name.text(product.Name);
			name.appendTo(div);

			var category = $('<p>');
			category.attr("class", "category");
			category.text(product.Category);			
			var catSpan = $('<span>');
			catSpan.attr('class', 'pre');
			catSpan.text('Category: ');
			category.prepend(catSpan);			
			category.appendTo(div);

			var price = $('<p>');
			price.attr('class', 'price');
			price.text("$"+product.Price);			
			var priceSpan = $('<span>');
			priceSpan.attr('class', 'pre');
			priceSpan.text("Price: ")
			price.prepend(priceSpan);	
					
			price.appendTo(div);

			div.appendTo(productLi);

			var footer = $('<footer>');
			footer.attr('class', 'product-footer');
			footer.appendTo(productLi);

			var anchor = $('<a>');
			anchor.attr('href', "#");
			anchor.appendTo(footer);

			var buttonEdit = $('<button>');
			buttonEdit.attr('class', 'edit-button');
			buttonEdit.attr('id', product.objectId);
			buttonEdit.text('Edit');
			buttonEdit.appendTo(anchor);

			var anchorB = $('<a>');
			anchorB.attr('href', '#');			
			anchorB.appendTo(footer);

			var buttonDelete = $('<button>');
			buttonDelete.attr('class', 'delete-button');
			buttonDelete.attr('id', product.objectId);
			buttonDelete.text('Delete');
			buttonDelete.appendTo(anchorB);


			productLi.appendTo('#productsList');
		}
	}

	function deleteProduct () {		
		currentId = event.target.id;
		var currentUser = userSession.getCurrentUser();
        var sessionToken = currentUser.sessionToken;

        noty(
            {
                text: "Delete this product?",
                type: 'confirm',
                layout: 'topCenter',
                buttons: [
                    {
                        text : "Yes",
                        onClick : function($noty) {                        	
                            ajaxRequester.deleteProduct(sessionToken, currentId, function (data) {
                            	showInfoMessage('Product deleted!');                            	
                            	productsView();
                            }, deleteError);
                            $noty.close();
                        }
                    },
                    {
                        text : "Cancel",
                        onClick : function($noty) {
                            $noty.close();
                        }
                    }
                ]}
        );

		
	}
	

	function editProduct () {		
		var currentUser = userSession.getCurrentUser();
        var sessionToken = currentUser.sessionToken;       
        var name = $('#editName').val();
		var category = $('#editCategory').val();
		var price = $('#editPrice').val();
        ajaxRequester.editProduct(sessionToken, name, category, price, currentId, function() {
        	showInfoMessage('Product edited!')        	
        	
        	location.reload();
        	productsView();
        }, editError);
		
		


	}

	// Messages functions bellow

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

    function loadProductsError(error) {
        showErrorMessage("Products load failed.");
    }

    function deleteError (error) {
    	showErrorMessage("Products removing failed.");
    }
    function editError (error) {
    	showAjaxError("Edit Failed!", error)
    }

}());	