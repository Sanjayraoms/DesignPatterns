// See https://aka.ms/new-console-template for more information
using IteratorPattern;

var pancakeHouseMenu = new PanCakeHouseMenu();

var dinerMenu = new DinerMenu();

var cafeMenu = new CafeMenu();

List<IMenu> menus = new List<IMenu>();
menus.Add(pancakeHouseMenu);
menus.Add(dinerMenu);
menus.Add(cafeMenu);

Waitress waitress = new Waitress(menus);

waitress.PrintMenu();
