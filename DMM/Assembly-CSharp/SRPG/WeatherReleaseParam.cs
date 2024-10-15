// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherReleaseParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF6")]
  public class WeatherReleaseParam
  {
    [Token(Token = "0x4008258")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4008259")]
    [FieldOffset(Offset = "0xC")]
    private string[] mSkillInames;
    [Token(Token = "0x400825A")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsMapWeatherDel;
    [Token(Token = "0x400825B")]
    [FieldOffset(Offset = "0x14")]
    private string[] mDelWeatherInames;

    [Token(Token = "0x170011F4")]
    public string Iname
    {
      [Token(Token = "0x6007E8D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011F5")]
    public string[] SkillInames
    {
      [Token(Token = "0x6007E8E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x170011F6")]
    public bool IsMapWeatherDel
    {
      [Token(Token = "0x6007E8F"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011F7")]
    public string[] DelWeatherInames
    {
      [Token(Token = "0x6007E90"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x6007E91")]
    [Address(RVA = "0x3FE420", Offset = "0x3FD220", VA = "0x103FE420")]
    public void Deserialize(JSON_WeatherReleaseParam json)
    {
    }

    [Token(Token = "0x6007E92")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WeatherReleaseParam()
    {
    }
  }
}
