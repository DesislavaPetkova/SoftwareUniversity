var app = app || {};

app.dataPersister = function  () {
	function Persister (rootUrl) {
		this.rootUrl = rootUrl;
	}

	Persister.prototype.getAll = function  () {
		return ajaxRequester.get()
	}
	return {
		get: function  (rootUrl) {
			return new Persister(rootUrl);
		},
	}
}