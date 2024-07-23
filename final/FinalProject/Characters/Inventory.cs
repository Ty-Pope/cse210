public class Inventory
{
 private List<Item> _items;
 public Inventory()
 {
  _items = new List<Item>();
 }
 public void AddItem(Item item)
 {
  _items.Add(item);
  _items = _items.OrderBy(i => i.GetName()).ToList();
 }
 public void RemoveItem(Item item)
 {
  _items.Remove(item);
 }
 public void ShowItem(string itemName)
 {
  foreach (Item item in _items)
  {
   if (item.GetName() == itemName)
   {
    item.PrintItem();
   }
   break;
  }
 }
 public List<Item> GetItems()
 {
  return _items;
 }

 public Item GetItemByName(string itemName)
 {
  foreach (Item item in _items)
  {
   if (item.GetName() == itemName)
   {
    return item;
   }
  }
  return null;
 }
 public void PrintInventory()
 {
  int itemQuantity = 1;
  Item lastItem = new Weapon("", "", 0);
  for (int i = 0; i < _items.Count; i++)
  {
   if (i != 0)
   {
    if (_items[i].GetName() == lastItem.GetName())
    {
     itemQuantity++;
    }
    else
    {
     if (itemQuantity > 1)
     {
      lastItem.PrintItem();
      Console.WriteLine("Quantity: " + itemQuantity);
      Console.WriteLine("");
      itemQuantity = 1;
     }
     _items[i].PrintItem();
     Console.WriteLine("Quantity: " + itemQuantity);
     Console.WriteLine("");
    }
   }
   lastItem = _items[i];
  }
 }
}