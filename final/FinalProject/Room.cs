public class Room
{
 private List<Character> npcs;
 private Inventory items;
 public Room(List<Character> npcs, Inventory items)
 {
  this.npcs = npcs;
  this.items = items;
 }
 public void PrintNpcs()
 {
  foreach (Character npc in npcs)
  {
   npc.PrintCharacter();
  }
 }
 public void PrintItems()
 {
  items.PrintInventory();
 }
 public void PickUpItem(Character character, Item item)
 {
  character.GetInventory().AddItem(item);
  items.RemoveItem(item);
 }
 public void DropItem(Character character, Item item)
 {
  character.GetInventory().RemoveItem(item);
  items.AddItem(item);
 }
}