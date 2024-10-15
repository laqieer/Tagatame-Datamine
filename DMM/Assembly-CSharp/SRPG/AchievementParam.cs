// Decompiled with JetBrains decompiler
// Type: SRPG.AchievementParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F2E")]
  public class AchievementParam
  {
    [Token(Token = "0x4002F54")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4002F55")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4002F56")]
    [FieldOffset(Offset = "0x10")]
    public string ios;
    [Token(Token = "0x4002F57")]
    [FieldOffset(Offset = "0x14")]
    public string googleplay;

    [Token(Token = "0x6003F59")]
    [Address(RVA = "0x1174820", Offset = "0x1173620", VA = "0x11174820")]
    public bool Deserialize(JSON_AchievementParam json) => new bool();

    [Token(Token = "0x17000554")]
    public string AchievementID
    {
      [Token(Token = "0x6003F5A"), Address(RVA = "0x11748A0", Offset = "0x11736A0", VA = "0x111748A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003F5B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AchievementParam()
    {
    }
  }
}
