// Decompiled with JetBrains decompiler
// Type: SRPG.ProductSaleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C25")]
  public class ProductSaleParam
  {
    [Token(Token = "0x4006D1A")]
    [FieldOffset(Offset = "0x8")]
    public string ProductId;
    [Token(Token = "0x4006D1B")]
    [FieldOffset(Offset = "0xC")]
    public string Platform;
    [Token(Token = "0x4006D1C")]
    [FieldOffset(Offset = "0x10")]
    public string Name;
    [Token(Token = "0x4006D1D")]
    [FieldOffset(Offset = "0x14")]
    public string Description;
    [Token(Token = "0x4006D1E")]
    [FieldOffset(Offset = "0x18")]
    public int AdditionalFreeCoin;
    [Token(Token = "0x4006D1F")]
    [FieldOffset(Offset = "0x1C")]
    public ProductSaleParam.Constrict Condition;

    [Token(Token = "0x60073E5")]
    [Address(RVA = "0x3800D0", Offset = "0x37EED0", VA = "0x103800D0")]
    public bool Deserialize(JSON_ProductSaleParam json) => new bool();

    [Token(Token = "0x60073E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ProductSaleParam()
    {
    }

    [Token(Token = "0x2001C26")]
    public struct Constrict
    {
      [Token(Token = "0x4006D20")]
      [FieldOffset(Offset = "0x0")]
      public ProductSaleParam.Constrict.Type type;
      [Token(Token = "0x4006D21")]
      [FieldOffset(Offset = "0x4")]
      public string value;

      [Token(Token = "0x17000E94")]
      public int valueInt
      {
        [Token(Token = "0x60073E7"), Address(RVA = "0x37DBF0", Offset = "0x37C9F0", VA = "0x1037DBF0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x2001C27")]
      public enum Type
      {
        [Token(Token = "0x4006D23")] None,
        [Token(Token = "0x4006D24")] TimesAMonth,
      }
    }
  }
}
