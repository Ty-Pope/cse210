public class SmartLight : SmartDevice
{
 private int _brightness;
 public SmartLight(bool power, string name, int brightness) : base(power, name)
 {
  _brightness = brightness;
 }
 public override void TurnOn()
 {
  Console.WriteLine("Light is on");
  _brightness = 100;
  SetPower(true);
  SetTime(DateTime.Now);
 }
 public override void TurnOff()
 {
  _brightness = 0;
  Console.WriteLine("Light is off");
  SetPower(false);
 }
 public void SetBrightness(int brightness)
 {
  _brightness = brightness;
 }
}