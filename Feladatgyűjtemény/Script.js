"use strict!";

let megoldas = document.getElementsByClassName("megoldas");
let tartalom = document.getElementsByClassName("tartalom");
let szamlalo = 0;

for (let i = 0; i < megoldas.length; i++) {
  megoldas[i].addEventListener("click", () => {
    if (szamlalo % 2 == 0) {
      tartalom[i].style.display = "flex";
    } else {
      tartalom[i].style.display = "none";
    }
    szamlalo++;
  });
}
