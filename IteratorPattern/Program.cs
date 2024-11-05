// See https://aka.ms/new-console-template for more information
using IteratorPattern;

var pancakeHouseMenu = new PanCakeHouseMenu();

var dinerMenu = new DinerMenu();

var cafeMenu = new CafeMenu();

Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

waitress.PrintMenu();
