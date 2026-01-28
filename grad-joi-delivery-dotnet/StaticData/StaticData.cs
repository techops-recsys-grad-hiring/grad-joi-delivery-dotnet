using grad_joi_delivery_dotnet.Models;

public class StaticData {
  static string ZONEA = "ZoneA";
  static string ZONEB = "ZoneB";
  static string ZONEC = "ZoneC";

  static List<DistanceMap> distanceMap = [
    new DistanceMap(ZONEA, ZONEA, 0),
    new DistanceMap(ZONEA, ZONEB, 3),
    new DistanceMap(ZONEA, ZONEC, 6),
    new DistanceMap(ZONEB, ZONEC, 3),
    new DistanceMap(ZONEB, ZONEB, 0),
    new DistanceMap(ZONEB, ZONEC, 8),
    new DistanceMap(ZONEC, ZONEC, 0),
  ];

  static List<Store> stores = [
    new Store("1", ZONEA, ["Milk", "Eggs", "Bread"]),
    new Store("2", ZONEB, ["Bread", "Milks"]),
    new Store("3", ZONEC, ["Juice", "Bread"]),
  ];

  static List<Item> items = [
    new Item("1", "Notebook", "", 15),
    new Item("2", "Keyboard", "", 50),
    new Item("3", "Mouse", "", 25),
    new Item("4", "Monitor", "", 75),
  ];
}

