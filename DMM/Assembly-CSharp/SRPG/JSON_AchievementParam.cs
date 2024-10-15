// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AchievementParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F2C")]
  public class JSON_AchievementParam
  {
    [Token(Token = "0x4002F4E")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x4002F4F")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AchievementParam.Fields fields;

    [Token(Token = "0x6003F57")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AchievementParam()
    {
    }

    [Token(Token = "0x2000F2D")]
    public class Fields
    {
      [Token(Token = "0x4002F50")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x4002F51")]
      [FieldOffset(Offset = "0xC")]
      public string iname;
      [Token(Token = "0x4002F52")]
      [FieldOffset(Offset = "0x10")]
      public string ios;
      [Token(Token = "0x4002F53")]
      [FieldOffset(Offset = "0x14")]
      public string googleplay;

      [Token(Token = "0x6003F58")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
