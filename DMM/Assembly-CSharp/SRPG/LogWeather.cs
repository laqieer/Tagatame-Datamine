// Decompiled with JetBrains decompiler
// Type: SRPG.LogWeather
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BDD")]
  public class LogWeather : BattleLog
  {
    [Token(Token = "0x4001E15")]
    [FieldOffset(Offset = "0x8")]
    public WeatherData WeatherData;
    [Token(Token = "0x4001E16")]
    [FieldOffset(Offset = "0xC")]
    public SkillData SkillData;
    [Token(Token = "0x4001E17")]
    [FieldOffset(Offset = "0x10")]
    public bool IsStopWeather;

    [Token(Token = "0x6002FAA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LogWeather()
    {
    }
  }
}
