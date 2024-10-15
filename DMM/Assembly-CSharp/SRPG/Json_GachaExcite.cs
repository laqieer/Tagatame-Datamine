// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaExcite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F20")]
  public class Json_GachaExcite
  {
    [Token(Token = "0x4002F1E")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x4002F1F")]
    [FieldOffset(Offset = "0xC")]
    public Json_GachaExcite.Fields fields;

    [Token(Token = "0x6003F27")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GachaExcite()
    {
    }

    [Token(Token = "0x2000F21")]
    public class Fields
    {
      [Token(Token = "0x4002F20")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x4002F21")]
      [FieldOffset(Offset = "0xC")]
      public int rarity;
      [Token(Token = "0x4002F22")]
      [FieldOffset(Offset = "0x10")]
      public int weight;
      [Token(Token = "0x4002F23")]
      [FieldOffset(Offset = "0x14")]
      public string color1;
      [Token(Token = "0x4002F24")]
      [FieldOffset(Offset = "0x18")]
      public string color2;
      [Token(Token = "0x4002F25")]
      [FieldOffset(Offset = "0x1C")]
      public string color3;
      [Token(Token = "0x4002F26")]
      [FieldOffset(Offset = "0x20")]
      public string color4;
      [Token(Token = "0x4002F27")]
      [FieldOffset(Offset = "0x24")]
      public string color5;

      [Token(Token = "0x6003F28")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
