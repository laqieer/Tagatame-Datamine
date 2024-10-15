// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ProductSaleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C23")]
  public class JSON_ProductSaleParam
  {
    [Token(Token = "0x4006D10")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x4006D11")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ProductSaleParam.Fields fields;

    [Token(Token = "0x60073E3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ProductSaleParam()
    {
    }

    [Token(Token = "0x2001C24")]
    public class Fields
    {
      [Token(Token = "0x4006D12")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x4006D13")]
      [FieldOffset(Offset = "0xC")]
      public string product_id;
      [Token(Token = "0x4006D14")]
      [FieldOffset(Offset = "0x10")]
      public string platform;
      [Token(Token = "0x4006D15")]
      [FieldOffset(Offset = "0x14")]
      public string name;
      [Token(Token = "0x4006D16")]
      [FieldOffset(Offset = "0x18")]
      public string description;
      [Token(Token = "0x4006D17")]
      [FieldOffset(Offset = "0x1C")]
      public int additional_free_coin;
      [Token(Token = "0x4006D18")]
      [FieldOffset(Offset = "0x20")]
      public int condition_type;
      [Token(Token = "0x4006D19")]
      [FieldOffset(Offset = "0x24")]
      public string condition_value;

      [Token(Token = "0x60073E4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
