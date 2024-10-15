// Decompiled with JetBrains decompiler
// Type: SRPG.Json_LimitedShopUpdateResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001118")]
  public class Json_LimitedShopUpdateResponse
  {
    [Token(Token = "0x4003DDF")]
    [FieldOffset(Offset = "0x8")]
    public Json_Currencies currencies;
    [Token(Token = "0x4003DE0")]
    [FieldOffset(Offset = "0xC")]
    public JSON_LimitedShopItemListSet[] shopitems;
    [Token(Token = "0x4003DE1")]
    [FieldOffset(Offset = "0x10")]
    public int relcnt;
    [Token(Token = "0x4003DE2")]
    [FieldOffset(Offset = "0x14")]
    public int concept_count;
    [Token(Token = "0x4003DE3")]
    [FieldOffset(Offset = "0x18")]
    public int crystal_count;
    [Token(Token = "0x4003DE4")]
    [FieldOffset(Offset = "0x1C")]
    public int crystal_num;
    [Token(Token = "0x4003DE5")]
    [FieldOffset(Offset = "0x20")]
    public Json_Item[] items;

    [Token(Token = "0x6004868")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_LimitedShopUpdateResponse()
    {
    }
  }
}
