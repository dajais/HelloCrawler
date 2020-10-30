var character = {
  position: 9,
  
  hp: 100,
  mana: 100, 
};

var tile1 = document.querySelector(".tile1")
tile1.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile2 = document.querySelector(".tile2")
tile2.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile3 = document.querySelector(".tile3")
tile3.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile4 = document.querySelector(".tile4")
tile4.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile5 = document.querySelector(".tile5")
tile5.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile6 = document.querySelector(".tile6")
tile6.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile7 = document.querySelector(".tile7")
tile7.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile8 = document.querySelector(".tile8")
tile8.addEventListener("click", function(event){
  moveCharacter(event.target)
})

var tile9 = document.querySelector(".tile9")
tile9.addEventListener("click", function(event){
  moveCharacter(event.target)
})

function moveCharacter(tile){
  switch(tile.classList[0]) {
    case "tile1":
      if(character.position === 2 || character.position === 4){
        tile2.innerHTML = ""
        tile4.innerHTML = ""
        tile1.classList.add("beenHere")
        tile1.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 1;
      }
    break;
    case "tile2":
      if(character.position === 1 || character.position === 3 || character.position === 5){
          tile1.innerHTML = ""
          tile3.innerHTML = ""
          tile5.innerHTML = ""
          tile2.classList.add("beenHere")
          tile2.innerHTML = "<img src='assets/img/tipito.png'>"
          character.position = 2;
      }
      break;
    case "tile3":
      if(character.position === 2 || character.position === 6){
        tile2.innerHTML = ""
        tile6.innerHTML = ""
        tile3.classList.add("beenHere")
        tile3.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 3;
      }
    break;
    case "tile4":
      if(character.position === 1 || character.position === 5 || character.position === 7){
        tile1.innerHTML = ""
        tile5.innerHTML = ""
        tile7.innerHTML = ""
        tile4.classList.add("beenHere")
        tile4.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 4;
      }
    break;
    case "tile5":
      if(character.position === 2 || character.position === 4 || character.position === 6 || character.position === 8){
        tile2.innerHTML = ""
        tile4.innerHTML = ""
        tile6.innerHTML = ""
        tile8.innerHTML = ""
        tile5.classList.add("beenHere")
        tile5.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 5;
      }
    break;
    case "tile6":
      if(character.position === 3 || character.position === 5 || character.position === 9){
        tile3.innerHTML = ""
        tile5.innerHTML = ""
        tile9.innerHTML = ""
        tile6.classList.add("beenHere")
        tile6.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 6;
      }
    break;
    case "tile7":
      if(character.position === 4 || character.position === 8){
        tile4.innerHTML = ""
        tile8.innerHTML = ""
        tile7.classList.add("beenHere")
        tile7.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 7;
      }
    break;
    case "tile8":
      if(character.position === 7 || character.position === 5 || character.position === 9){
        tile7.innerHTML = ""
        tile5.innerHTML = ""
        tile9.innerHTML = ""
        tile8.classList.add("beenHere")
        tile8.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 8;
      }
    break;
    case "tile9":
      if(character.position === 8 || character.position === 6){
        tile8.innerHTML = ""
        tile6.innerHTML = ""
        tile9.classList.add("beenHere")
        tile9.innerHTML = "<img src='assets/img/tipito.png'>"
        character.position = 9;
      }
    break;
    }

}


