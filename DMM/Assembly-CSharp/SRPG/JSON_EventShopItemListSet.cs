// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_EventShopItemListSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EB1")]
  public class JSON_EventShopItemListSet
  {
    [Token(Token = "0x4002D20")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4002D21")]
    [FieldOffset(Offset = "0xC")]
    public int sold;
    [Token(Token = "0x4002D22")]
    [FieldOffset(Offset = "0x10")]
    public Json_ShopItemDesc item;
    [Token(Token = "0x4002D23")]
    [FieldOffset(Offset = "0x14")]
    public JSON_EventShopItemListSet.Cost cost;
    [Token(Token = "0x4002D24")]
    [FieldOffset(Offset = "0x18")]
    public Json_ShopItemDesc[] children;
    [Token(Token = "0x4002D25")]
    [FieldOffset(Offset = "0x1C")]
    public int isreset;
    [Token(Token = "0x4002D26")]
    [FieldOffset(Offset = "0x20")]
    public long start;
    [Token(Token = "0x4002D27")]
    [FieldOffset(Offset = "0x28")]
    public long end;
    [Token(Token = "0x4002D28")]
    [FieldOffset(Offset = "0x30")]
    public int flg_unit_check;

    [Token(Token = "0x6003D24")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_EventShopItemListSet()
    {
    }

    [Token(Token = "0x2000EB2")]
    public class Cost : Json_ShopItemCost
    {
      [Token(Token = "0x4002D29")]
      [FieldOffset(Offset = "0x10")]
      public string iname;

      [Token(Token = "0x6003D25")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Cost()
      {
      }
    }
  }
}
