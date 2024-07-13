public class Inventory
{
 private List<Item> items;
 public Inventory()
 {
  items = new List<Item>();
 }
 public void AddItem(Item item)
 {
  items.Add(item);
  items.Sort();
 }
 public void RemoveItem(Item item)
 {
  items.Remove(item);
  items.Sort(); //Probably don't need this due to add items already sorting the array.
 }
 public void ShowItems()
 {
  foreach (Item item in items)
  {
   item.PrintItem();
   Console.WriteLine("Quantity: " + GetItemAmount(item));
  }
 }
 public void ShowItem(string itemName)
 {
  foreach (Item item in items)
  {
   if (item.GetName() == itemName)
   {
    item.PrintItem();
    Console.WriteLine("Quantity: " + GetItemAmount(item));
   }
   break;
  }
 }
 public int GetItemAmount(Item item)
 {
  int count = 0;
  foreach (Item i in items)
  {
   if (i == item)
   {
    count++;
   }
   if (i != item && count > 0)
   {
    //Array should be sorted so once there is no more of the items next to each other it's done.
    return count;
   }
  }
  return count;
 }
 public List<Item> GetItems()
 {
  return items;
 }
}