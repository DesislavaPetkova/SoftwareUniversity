

VideoSys.controller('VideoData', ['$scope', function($scope){
	var videos = {
		title: 'Course introduction',
		pictureUrl: 'http://softuni.bg/picture.png',
		length: '3:32',
		category: 'IT',
		subscribers: 3,
		date: new Date(2014, 12, 15),
		haveSubtitles: false,
		comments: [
			{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			}
		]
	};
	$scope.videos = videos;
}])