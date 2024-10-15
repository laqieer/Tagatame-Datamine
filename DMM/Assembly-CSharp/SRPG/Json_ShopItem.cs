// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001115")]
  public class Json_ShopItem
  {
    [Token(Token = "0x4003DCB")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4003DCC")]
    [FieldOffset(Offset = "0xC")]
    public int sold;
    [Token(Token = "0x4003DCD")]
    [FieldOffset(Offset = "0x10")]
    public Json_ShopItemDesc item;
    [Token(Token = "0x4003DCE")]
    [FieldOffset(Offset = "0x14")]
    public Json_ShopItemCost cost;
    [Token(Token = "0x4003DCF")]
    [FieldOffset(Offset = "0x18")]
    public Json_ShopItemDesc[] children;
    [Token(Token = "0x4003DD0")]
    [FieldOffset(Offset = "0x1C")]
    public int isreset;
    [Token(Token = "0x4003DD1")]
    [FieldOffset(Offset = "0x20")]
    public long start;
    [Token(Token = "0x4003DD2")]
    [FieldOffset(Offset = "0x28")]
    public long end;
    [Token(Token = "0x4003DD3")]
    [FieldOffset(Offset = "0x30")]
    public int discount;
    [Token(Token = "0x4003DD4")]
    [FieldOffset(Offset = "0x34")]
    public int flg_unit_check;

    [Token(Token = "0x6004865")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopItem()
    {
    }
  }
}
