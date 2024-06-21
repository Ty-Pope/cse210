public class House
{
 public List<Room> _rooms;
 public House(List<Room> rooms)
 {
  _rooms = rooms;
 }
 public void TurnOnAllDevices()
 {
  foreach (Room room in _rooms)
  {
   room.TurnOnAllTvs();
   room.TurnOnAllLights();
   room.TurnOnAllHeaters();
  }
 }
 public void TurnOffAllDevices()
 {
  foreach (Room room in _rooms)
  {
   room.TurnOffAllTvs();
   room.TurnOffAllLights();
   room.TurnOffAllHeaters();
  }
 }
 public void AddRoom(Room room)
 {
  _rooms.Add(room);
 }
 public void RemoveRoom(Room room)
 {
  _rooms.Remove(room);
 }
}