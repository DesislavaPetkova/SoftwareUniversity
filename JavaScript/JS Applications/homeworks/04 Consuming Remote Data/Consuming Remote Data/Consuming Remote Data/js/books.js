(function () {
    var url = "https://api.parse.com/1/classes/Book";
    var PARSE_APP_ID = "qtdMQxxbmaK2UPf4VUP2zEDBvy0FPtX81NC3pndu";
    var PARSE_REST_KEY = "7K4BSToDiehhIDzuoaynLXOPSG2zq24t2UzAQfcm";

    $('#editForm').hide();
    var currentId;
    
    (function loadBooks() {        
        $.ajax({
            type: "GET",
            url: url,
            contentType: "application/json",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_KEY
            },
            success: function (data) {
                $('<h2>').text("Problem 1 result as JSON object").appendTo('#allBooks');               
                for (var b in data.results) {
                    var book = data.results[b];
                    var bookItem = $('<li>');
                    var bookLink = $('<a>').attr('href', '#');
                    bookItem.appendTo('#allBooks');
                    bookLink.text("Name: "+book.title + " Author: " + book.author + " ISBN: "+book.isbn).appendTo(bookItem);
                    bookLink.attr('id', book.objectId);
                    $('<input>').attr('id', book.objectId).attr('type', 'button').attr('value', 'Delete').appendTo(bookItem);
                }
            },
            error: function(err) {               
                $('<h2>').text("Request failed" + err).appendTo('#allBooks');
                throw new Error("Request failed");
            }
        });
    })();

    function addBook() {
        var title = $("input[name ='title']").val();
        var author = $("input[name='author']").val();
        var isbn = $("input[name='isbn']").val();

        $.ajax({
            type: "POST",
            url: url,
            data: JSON.stringify({
                "title": title,
                "author": author,
                "isbn": isbn
            }),
            contentType: "application/json",
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_KEY
            },
            
            success: function(data) {
                location.reload();
            }
        });
    }

    $("input[name='addBook']").click(function(event) {
        addBook();
    });
    
    function editBook(bookId) {
    	
    	var title = $("input[name ='editTitle']").val();
    	
        var author = $("input[name='editAuthor']").val();
        var isbn = $("input[name='editIsbn']").val();

    	$.ajax({
    		type: "PUT",
    		url: url+"/"+bookId,
    		contentType: "application/json",
    		headers: {
    			"X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_KEY
    		},
    		data: JSON.stringify({
    			"title": title,
                "author": author,
                "isbn": isbn
    		}),
    		success: function(data) {
    			$('#editForm').hide();
                location.reload();
            }
    	});        
    }
    
    $("input[name='editBook']").click(function(event) {    		
    		editBook(currentId);
	}); 	
    
    $(document).on("click", "a", function(){    	
    	$('#editForm').show(),
		currentId = event.target.id	
		console.log(currentId);
    });

    $(document).on("click", 'input[name="hideEdit"]', function() {
    	$('#editForm').hide()
    });


    $(document).on("click", 'input[value="Delete"]', function () {
    	$.ajax({
    		type: "DELETE",
    		url: url+"/"+event.target.id,
    		headers: {
    			"X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_KEY
    		},
    		success: function () {
    			location.reload();
    		}
    	});
    })

}());