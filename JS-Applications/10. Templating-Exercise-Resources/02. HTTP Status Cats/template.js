(() => {
     renderCatTemplate();
     function renderCatTemplate() {
         // TODO: Render cat template and attach events
          const template = Handlebars.compile(document.querySelector('#cat-template').textContent);
          const ul = document.querySelector('#allCats > ul');

          ul.innerHTML = cats.map(cat => template(cat)).join('');

          document.querySelectorAll('.showBtn').forEach(button => {
               button.addEventListener('click', toggleStatus);
          })
     }
     function toggleStatus(e) {
          let infoDiv = e.target.nextElementSibling;
          if(infoDiv.style.display !== 'block') {
               infoDiv.style.display = 'block';
               e.target.textContent = 'Hide status code';
          }
          else {
               infoDiv.style.display = 'none';
               e.target.textContent = 'Show status code';
          }
     }
})()

