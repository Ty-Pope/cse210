public class Room
{
 private List<SmartTv> _tvs;
 private List<SmartLight> _lights;
 private List<SmartHeater> _heaters;
 public Room(List<SmartTv> tvs, List<SmartLight> lights, List<SmartHeater> heaters)
 {
  _tvs = tvs;
  _lights = lights;
  _heaters = heater;
 }
 public void TurnOnAllTvs()
 {
  foreach (SmartTv tv in _tvs)
  {
   tv.TurnOn();
  }
 }
 public void TurnOffAllTvs()
 {
  foreach (SmartTv tv in _tvs)
  {
   tv.TurnOff();
  }
 }
 public void TurnOnAllLights()
 {
  foreach (SmartLight light in _lights)
  {
   light.TurnOn();
  }
 }
 public void TurnOffAllLights()
 {
  foreach (SmartLight light in _lights)
  {
   light.TurnOff();
  }
 }
 public void TurnOnAllHeaters()
 {
  foreach (SmartHeater heater in _heaters)
  {
   heater.TurnOn();
  }
 }
 public void TurnOffAllHeaters()
 {
  foreach (SmartHeater heater in _heaters)
  {
   heater.TurnOff();
  }
 }
 public void SetAllTvVolumes(int volume)
 {
  foreach (SmartTv tv in _tvs)
  {
   tv.SetVolume(volume);
  }
 }
 public void SetAllTvChannels(int channel)
 {
  foreach (SmartTv tv in _tvs)
  {
   tv.SetChannel(channel);
  }
 }
 public void SetAllLightBrightness(int brightness)
 {
  foreach (SmartLight light in _lights)
  {
   light.SetBrightness(brightness);
  }
 }
 public void SetAllHeaterTemperatures(int temperature)
 {
  foreach (SmartHeater heater in _heaters)
  {
   heater.SetTemperature(temperature);
  }
 }
 public void SetAllHeaterType(bool isHeater)
 {
  foreach (SmartHeater heater in _heaters)
  {
   heater.SetIsHeater(isHeater);
  }
 }
 public void TurnOffRoom()
 {
  TurnOffAllTvs();
  TurnOffAllLights();
  TurnOffAllHeaters();
 }
 public void TurnOnRoom()
 {
  TurnOnAllTvs();
  TurnOnAllLights();
  TurnOnAllHeaters();
 }
 public List<string> GetRoomStatus()
 {
  List<string> status = new List<string>();
  foreach (SmartTv tv in _tvs)
  {
   status.Add(tv.GetName() + " is " + (tv.GetPower() ? "on" : "off") + " at volume " + tv.GetVolume() + " on channel " + tv.GetChannel());
  }
  foreach (SmartLight light in _lights)
  {
   status.Add(light.GetName() + " is " + (light.GetPower() ? "on" : "off") + " at brightness " + light.GetBrightness());
  }
  foreach (SmartHeater heater in _heaters)
  {
   status.Add(heater.GetName() + " is " + (heater.GetPower() ? "on" : "off") + " at temperature " + heater.GetTemperature() + " as a " + (heater.GetIsHeater() ? "heater" : "air conditioner"));
  }
  return status;
 }
 public List<string> GetAllOnDevices()
 {
  List<string> onDevices = new List<string>();
  foreach (SmartTv tv in _tvs)
  {
   if (tv.GetPower())
   {
    onDevices.Add(tv.GetName());
   }
  }
  foreach (SmartLight light in _lights)
  {
   if (light.GetPower())
   {
    onDevices.Add(light.GetName());
   }
  }
  foreach (SmartHeater heater in _heaters)
  {
   if (heater.GetPower())
   {
    onDevices.Add(heater.GetName());
   }
  }
  return onDevices;
 }
 public string GetLongestOn()
 {
  string longestOn = "";
  TimeSpan longestTime = new TimeSpan(0);
  foreach (SmartTv tv in _tvs)
  {
   if (tv.GetPower())
   {
    TimeSpan uptime = tv.GetUptime();
    if (uptime > longestTime)
    {
     longestTime = uptime;
     longestOn = tv.GetName();
    }
   }
  }
  foreach (SmartLight light in _lights)
  {
   if (light.GetPower())
   {
    TimeSpan uptime = light.GetUptime();
    if (uptime > longestTime)
    {
     longestTime = uptime;
     longestOn = light.GetName();
    }
   }
  }
  foreach (SmartHeater heater in _heaters)
  {
   if (heater.GetPower())
   {
    TimeSpan uptime = heater.GetUptime();
    if (uptime > longestTime)
    {
     longestTime = uptime;
     longestOn = heater.GetName();
    }
   }
  }
  return longestOn;
 }
}