const DistanceMap = require("../model/DistanceMap");
const Item = require("../model/Item");
const Store = require("../model/Store");

class StaticData {
  static ZONEA = "ZoneA";
  static ZONEB = "ZoneB";
  static ZONEC = "ZoneC";

  static distanceMap = [
    new DistanceMap(SeedData.ZONEA, SeedData.ZONEA, 0),
    new DistanceMap(SeedData.ZONEA, SeedData.ZONEB, 3),
    new DistanceMap(SeedData.ZONEA, SeedData.ZONEC, 6),
    new DistanceMap(SeedData.ZONEB, SeedData.ZONEC, 3),
    new DistanceMap(SeedData.ZONEB, SeedData.ZONEB, 0),
    new DistanceMap(SeedData.ZONEB, SeedData.ZONEC, 8),
    new DistanceMap(SeedData.ZONEC, SeedData.ZONEC, 0),
  ];

  static stores = [
    new Store("1", SeedData.ZONEA, ["Milk", "Eggs", "Bread"]),
    new Store("2", SeedData.ZONEB, ["Bread", "Milks"]),
    new Store("3", SeedData.ZONEC, ["Juice", "Bread"]),
  ];

  static items = [
    new Item("1", "Notebook", "", 15),
    new Item("2", "Keyboard", "", 50),
    new Item("3", "Mouse", "", 25),
    new Item("4", "Monitor", "", 75),
  ];
}

module.exports = StaticData;
