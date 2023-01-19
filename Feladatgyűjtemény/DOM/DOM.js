"use strict!";

let button = document.getElementById("gomb");
let szinek = [
  "red",
  "blue",
  "green",
  "aqua",
  "gold",
  "gray",
  "silver",
  "tomato",
  "white",
];
let szin = document.getElementsByClassName("szin");
let tartalom = ["Home", "About", "Contact", "Help"];

button.addEventListener("click", () => {
  let nav = document.createElement("nav");
  nav.style.height = "50px";
  nav.style.width = "100%";
  nav.style.backgroundColor = "tomato";
  document.body.insertBefore(nav, gomb);
  gomb.style.display = "none";
  let li = document.createElement("li");
  let kikapcs = document.createTextNode("=");
  li.setAttribute("id", "kikapcs");
  li.appendChild(kikapcs);
  nav.appendChild(li);
  for (let i = 0; i < tartalom.length; i++) {
    let li = document.createElement("li");
    let link = document.createElement("a");
    if (i != 0) {
      link.setAttribute("href", `${tartalom[i]}.html`);
    } else {
      link.setAttribute("href", "#");
    }
    li.appendChild(link);
    let szoveg = document.createTextNode(tartalom[i]);
    link.appendChild(szoveg);
    nav.appendChild(li);
  }
});

/*
button.addEventListener("click", () => {
  for (let q = 0; szin.length; q++) {
    let szamlalo = veletlen();
    szin[q].innerHTML = szinek[szamlalo];
    szin[q].style.backgroundColor = szinek[szamlalo];
    szin[q].style.color = "white";
  }
});

function veletlen() {
  let szamlalo = Math.floor(Math.random() * szinek.length);
  return szamlalo;
}
*/
