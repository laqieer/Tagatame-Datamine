// Decompiled with JetBrains decompiler
// Type: SRPG.Json_EventShopUpdateResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001119")]
  public class Json_EventShopUpdateResponse
  {
    [Token(Token = "0x4003DE6")]
    [FieldOffset(Offset = "0x8")]
    public Json_Currencies currencies;
    [Token(Token = "0x4003DE7")]
    [FieldOffset(Offset = "0xC")]
    public Json_Item[] items;
    [Token(Token = "0x4003DE8")]
    [FieldOffset(Offset = "0x10")]
    public JSON_EventShopItemListSet[] shopitems;
    [Token(Token = "0x4003DE9")]
    [FieldOffset(Offset = "0x14")]
    public int relcnt;
    [Token(Token = "0x4003DEA")]
    [FieldOffset(Offset = "0x18")]
    public int concept_count;
    [Token(Token = "0x4003DEB")]
    [FieldOffset(Offset = "0x1C")]
    public int crystal_count;

    [Token(Token = "0x6004869")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_EventShopUpdateResponse()
    {
    }
  }
}
