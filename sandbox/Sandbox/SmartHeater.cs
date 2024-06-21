public class SmartHeater : SmartDevice
{
 private int _temperature;
 private bool _isHeater;
 public SmartHeater(bool power, string name, int temperature, bool isHeater) : base(power, name)
 {
  _temperature = temperature;
  _isHeater = isHeater;
 }
 public override void TurnOn()
 {
  Console.WriteLine("Heater is on");
  _temperature = 100;
  SetPower(true);
  SetTime(DateTime.Now);
 }
 public override void TurnOff()
 {
  _temperature = 0;
  Console.WriteLine("Heater is off");
  SetPower(false);
 }
 public void SetTemperature(int temperature)
 {
  _temperature = temperature;
 }
 public void SetIsHeater(bool isHeater)
 {
  if (isHeater)
  {
   Console.WriteLine("Heater is on");
  }
  else
  {
   Console.WriteLine("Air conditioner is on");
  }
  _isHeater = isHeater;
 }
}