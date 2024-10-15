// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LimitedShopItemListSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FD5")]
  public class JSON_LimitedShopItemListSet
  {
    [Token(Token = "0x40037EE")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40037EF")]
    [FieldOffset(Offset = "0xC")]
    public int sold;
    [Token(Token = "0x40037F0")]
    [FieldOffset(Offset = "0x10")]
    public Json_ShopItemDesc item;
    [Token(Token = "0x40037F1")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LimitedShopItemListSet.LimitedCost cost;
    [Token(Token = "0x40037F2")]
    [FieldOffset(Offset = "0x18")]
    public Json_ShopItemDesc[] children;
    [Token(Token = "0x40037F3")]
    [FieldOffset(Offset = "0x1C")]
    public int isreset;
    [Token(Token = "0x40037F4")]
    [FieldOffset(Offset = "0x20")]
    public long start;
    [Token(Token = "0x40037F5")]
    [FieldOffset(Offset = "0x28")]
    public long end;
    [Token(Token = "0x40037F6")]
    [FieldOffset(Offset = "0x30")]
    public int flg_unit_check;

    [Token(Token = "0x60041E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LimitedShopItemListSet()
    {
    }

    [Token(Token = "0x2000FD6")]
    public class LimitedCost : Json_ShopItemCost
    {
      [Token(Token = "0x40037F7")]
      [FieldOffset(Offset = "0x10")]
      public string iname;

      [Token(Token = "0x60041E7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public LimitedCost()
      {
      }
    }
  }
}
