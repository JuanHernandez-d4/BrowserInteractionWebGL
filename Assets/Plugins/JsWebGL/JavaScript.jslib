mergeInto(LibraryManager.library, {

  SayHello: function (str) {
    window.alert(Pointer_stringify(str));
  },
  GetURL: function(){

    var newURL = window.location.search
    console.log(newURL);
  }

  });