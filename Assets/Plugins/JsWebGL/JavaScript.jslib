mergeInto(LibraryManager.library, {

  SayHello: function (str) {
    window.alert(Pointer_stringify(str));
  },
  GetURL: function(){

    var newURL = window.location.search
    console.log(newURL);
  }

  PutToken: function(){
    var newURL = urlsearchParams.append("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwidXNlcm5hbWUiOiJKdWFuIERpZWdvIFF1aW50ZXJvIiwiaWQiOjEyMzQ1Njc4OX0.1BYzVqcEYNnnI48aCX2q7CQM6ISxlGtBKBO0FUdVD50");
    console.log(newURL);
  }

  });