public abstract class SmartDevice
{
 private bool _power;
 private bool _name;
 private DateTime _startTime;

 SmartDevice(bool power, string name)
 {
  _power = power;
  _name = name;
  _startTime = DateTime.Now;
 }
 public void GetPower()
 {
  return _power;
 }
 public void SetPower(bool power)
 {
  _power = power;
 }
 public void GetOn()
 {
  return _power;
 }
 public void SetName(string name)
 {
  _name = name;
 }
 public string GetName()
 {
  return _name;
 }
 public DateTime GetStartTime()
 {
  return _startTime;
 }
 public DateTime GetUptime()
 {
  return DateTime.Now - _startTime;
 }
 public void SetTime(DateTime time)
 {
  _startTime = time;
 }
 public abstract void TurnOn();
 public abstract void TurnOff();
}