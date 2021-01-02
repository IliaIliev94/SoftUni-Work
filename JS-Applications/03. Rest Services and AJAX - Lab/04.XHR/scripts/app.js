function loadRepos() {
   const url = 'https://api.github.com/users/testnakov/repos'
   const httpRequest = new XMLHttpRequest();
   httpRequest.addEventListener('readystatechange', function() {
      if(httpRequest.readyState === 4 && httpRequest.status === 200) {
         console.log(httpRequest)
         document.querySelector('#res').innerHTML = httpRequest.responseText;
      }
   });
   httpRequest.open('GET', url);
   httpRequest.send();
}