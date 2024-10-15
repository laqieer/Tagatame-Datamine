// Decompiled with JetBrains decompiler
// Type: Gsc.Purchase.ProductInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Purchase
{
  [Token(Token = "0x20035F6")]
  public class ProductInfo
  {
    [Token(Token = "0x400FE41")]
    [FieldOffset(Offset = "0x8")]
    public readonly string ID;
    [Token(Token = "0x400FE42")]
    [FieldOffset(Offset = "0xC")]
    public readonly string LocalizedTitle;
    [Token(Token = "0x400FE43")]
    [FieldOffset(Offset = "0x10")]
    public readonly string LocalizedDescription;
    [Token(Token = "0x400FE44")]
    [FieldOffset(Offset = "0x14")]
    public readonly string LocalizedPrice;
    [Token(Token = "0x400FE45")]
    [FieldOffset(Offset = "0x18")]
    public readonly string CurrencyCode;
    [Token(Token = "0x400FE46")]
    [FieldOffset(Offset = "0x1C")]
    public readonly float Price;

    [Token(Token = "0x1700226B")]
    public bool enabled
    {
      [Token(Token = "0x600F085"), Address(RVA = "0xB25040", Offset = "0xB23E40", VA = "0x10B25040")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F086")]
    [Address(RVA = "0xB24FD0", Offset = "0xB23DD0", VA = "0x10B24FD0")]
    public ProductInfo(
      string id,
      string title,
      string description,
      string price,
      string currencyCode,
      float priceValue)
    {
    }
  }
}
