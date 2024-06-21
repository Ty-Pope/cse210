public class SmartTv : SmartDevice
{
 private int _volume;
 private int _channel;
 public SmartTv(bool power, string name, int volume, int channel) : base(power, name)
 {
  _volume = volume;
  _channel = channel;
 }
 public override void TurnOn()
 {
  Console.WriteLine("TV is on");
  SetPower(true);
  SetTime(DateTime.Now);
 }
 public override void TurnOff()
 {
  Console.WriteLine("TV is off");
  SetPower(false);
 }
 public void SetVolume(int volume)
 {
  _volume = volume;
 }
 public void SetChannel(int channel)
 {
  _channel = channel;
 }
}