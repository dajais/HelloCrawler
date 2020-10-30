var equip = document.querySelector(".inventory")
  
var buttonEquip = document.querySelector("#buttonInventory")
buttonEquip.addEventListener("click", function(){
  if(equip.classList.length === 1){
        equip.classList.add("hidden")
      }else{
        equip.classList.remove("hidden")
      }
})

