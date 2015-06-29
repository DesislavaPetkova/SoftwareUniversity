<aside id="right">
    <div class="panel panel-info">
            <div class="panel-heading">
                <h3 class="panel-title">States of Issues</h3>
            </div>
            <div  class="panel-body">
                    <ul style="list-style-type: none;">
                        <div id="new_state" >
                            <li><button type="button" class="btn btn-info">New State</button></li>
                        </div>
                        <div id="open_state">
                        <li><button type="button" class="btn btn-info">Open State</button></li>
                        </div>
                        <div id="fixed_state">
                        <li><button type="button" class="btn btn-info">Fixed State</button></li>
                        </div>
                        <div id="closed_state">
                        <li><button type="button" class="btn btn-info">Closed State</button></li>
                        </div>
                    </ul>

                    <div class="form-group">
                        <input id="searchVal" type="text" class="form-control" placeholder="Search">
                    </div>
                    <button id="searchBtn" type="button" class="btn btn-default">Search</button>

            </div>
    </div>

    <script src="//code.jquery.com/jquery-1.11.3.min.js"></script>
    <script>
        var domain = window.location.pathname;
        if(domain.toLowerCase().indexOf('account') >= 0) {
            $("#right").hide();
        }
        //alert($.session.getItem("username"));

        $('#new_state').on("click", function() {
            //window.location = '/issues/getIssuesbyState/New';
            $.ajax({
                url: '/issues/getIssuesbyState/New',
                method: 'GET'
            }).success (function(data){
                $('#issuesIndex').replaceWith($('#issuesIndex').html(data));
            })
        })
        $( '#open_state' ).on("click", function() {
            $.ajax({
                url: '/issues/getIssuesbyState/Open',
                method: 'GET'
            }).success (function(data){
                $('#issuesIndex').replaceWith($('#issuesIndex').html(data));
            })
        })
        $( '#fixed_state' ).on("click", function() {
            $.ajax({
                url: '/issues/getIssuesbyState/Fixed',
                method: 'GET'
            }).success (function(data){
                $('#issuesIndex').replaceWith($('#issuesIndex').html(data));
            })
        })
        $( '#closed_state' ).on("click", function() {
            $.ajax({
                url: '/issues/getIssuesbyState/Closed',
                method: 'GET'
            }).success (function(data){
                $('#issuesIndex').replaceWith($('#issuesIndex').html(data));
            })
        })

        $( '#searchBtn' ).on("click", function() {
            var searchVal = $('#searchVal').val();
            console.log(searchVal);
            $.ajax({
                url: '/issues/searchIssues/'+searchVal,
                method: 'GET'
            }).success (function(data){
                $('#issuesIndex').replaceWith($('#issuesIndex').html(data));
            })
        })
    </script>
</aside>