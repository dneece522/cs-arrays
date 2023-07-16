// string[] fraudOrderIDs = { "A123", "B456", "C789" };

// fraudOrderIDs[0] = "A123";
// fraudOrderIDs[1] = "B456";
// fraudOrderIDs[2] = "C789";

// Console.WriteLine($"First: {fraudOrderIDs[0]}\nSecond: {fraudOrderIDs[1]}\nThird: {fraudOrderIDs[2]}");

// string[] names = { "Rowena", "Robin", "Bao" };

// foreach (string name in names)
// {
//   Console.WriteLine(name);
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;

// foreach (int item in inventory) {
// sum += item;
// bin++;
// Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string id in orderIDs) {
  if (id.StartsWith("B")) {
    Console.WriteLine(id);
  }
}