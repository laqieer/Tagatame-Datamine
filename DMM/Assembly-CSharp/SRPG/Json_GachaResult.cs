// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018C7")]
  public class Json_GachaResult
  {
    [Token(Token = "0x400594F")]
    [FieldOffset(Offset = "0x8")]
    public Json_DropInfo[] add;
    [Token(Token = "0x4005950")]
    [FieldOffset(Offset = "0xC")]
    public Json_DropInfo[] add_mail;
    [Token(Token = "0x4005951")]
    [FieldOffset(Offset = "0x10")]
    public Json_GachaReceipt receipt;
    [Token(Token = "0x4005952")]
    [FieldOffset(Offset = "0x14")]
    public Json_PlayerData player;
    [Token(Token = "0x4005953")]
    [FieldOffset(Offset = "0x18")]
    public Json_Item[] items;
    [Token(Token = "0x4005954")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Unit[] units;
    [Token(Token = "0x4005955")]
    [FieldOffset(Offset = "0x20")]
    public Json_Mail[] mails;
    [Token(Token = "0x4005956")]
    [FieldOffset(Offset = "0x24")]
    public Json_Artifact[] artifacts;
    [Token(Token = "0x4005957")]
    [FieldOffset(Offset = "0x28")]
    public int is_pending;
    [Token(Token = "0x4005958")]
    [FieldOffset(Offset = "0x2C")]
    public int rest;
    [Token(Token = "0x4005959")]
    [FieldOffset(Offset = "0x30")]
    public JSON_TrophyProgress[] trophyprogs;
    [Token(Token = "0x400595A")]
    [FieldOffset(Offset = "0x34")]
    public JSON_TrophyProgress[] bingoprogs;
    [Token(Token = "0x400595B")]
    [FieldOffset(Offset = "0x38")]
    public Json_Item[] runes;
    [Token(Token = "0x400595C")]
    [FieldOffset(Offset = "0x3C")]
    public int rune_storage_used;
    [Token(Token = "0x400595D")]
    [FieldOffset(Offset = "0x40")]
    public Json_HotDealInfo[] hot_deals;
    [Token(Token = "0x400595E")]
    [FieldOffset(Offset = "0x44")]
    public Json_DropDisassembly disassembly;

    [Token(Token = "0x6006377")]
    [Address(RVA = "0x316930", Offset = "0x315730", VA = "0x10316930")]
    public Json_GachaResult()
    {
    }
  }
}
