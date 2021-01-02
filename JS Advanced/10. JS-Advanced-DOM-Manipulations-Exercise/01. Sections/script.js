function create(words) {
   console.log('TODO:...');

   words.forEach(element => {
      // For each section create a new div element
      let div = document.createElement("div");
      //Create a paragraph element and add a display none attribute to it
      let paragraph = createParagraph();
      //Append the parapgraph as a child element to the div
      div.appendChild(paragraph);
      //Add an event listener to the div that sets the paragraph display to visible
      div.addEventListener("click", () => div.firstElementChild.style.display = "initial");
      //Append the div to the content
      document.getElementById("content").appendChild(div);
   });

   function createParagraph() {
      let paragraph = document.createElement("p");
      paragraph.textContent = element;
      paragraph.style.display = "none";
      return paragraph;
   }
}