// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FF0")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_PlayerData
  {
    [Token(Token = "0x4003880")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4003881")]
    [FieldOffset(Offset = "0xC")]
    public int exp;
    [Token(Token = "0x4003882")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x4003883")]
    [FieldOffset(Offset = "0x14")]
    public int gold;
    [Token(Token = "0x4003884")]
    [FieldOffset(Offset = "0x18")]
    public int abilpt;
    [Token(Token = "0x4003885")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Coin coin;
    [Token(Token = "0x4003886")]
    [FieldOffset(Offset = "0x20")]
    public int arenacoin;
    [Token(Token = "0x4003887")]
    [FieldOffset(Offset = "0x24")]
    public int multicoin;
    [Token(Token = "0x4003888")]
    [FieldOffset(Offset = "0x28")]
    public int enseicoin;
    [Token(Token = "0x4003889")]
    [FieldOffset(Offset = "0x2C")]
    public int kakeracoin;
    [Token(Token = "0x400388A")]
    [FieldOffset(Offset = "0x30")]
    public int cnt_multi;
    [Token(Token = "0x400388B")]
    [FieldOffset(Offset = "0x34")]
    public int cnt_stmrecover;
    [Token(Token = "0x400388C")]
    [FieldOffset(Offset = "0x38")]
    public int cnt_buygold;
    [Token(Token = "0x400388D")]
    [FieldOffset(Offset = "0x3C")]
    public string cuid;
    [Token(Token = "0x400388E")]
    [FieldOffset(Offset = "0x40")]
    public string fuid;
    [Token(Token = "0x400388F")]
    [FieldOffset(Offset = "0x44")]
    public int logincont;
    [Token(Token = "0x4003890")]
    [FieldOffset(Offset = "0x48")]
    public int mail_unread;
    [Token(Token = "0x4003891")]
    [FieldOffset(Offset = "0x4C")]
    public int mail_f_unread;
    [Token(Token = "0x4003892")]
    [FieldOffset(Offset = "0x50")]
    public long btlid;
    [Token(Token = "0x4003893")]
    [FieldOffset(Offset = "0x58")]
    public string btltype;
    [Token(Token = "0x4003894")]
    [FieldOffset(Offset = "0x5C")]
    public Json_Hikkoshi tuid;
    [Token(Token = "0x4003895")]
    [FieldOffset(Offset = "0x60")]
    public Json_Stamina stamina;
    [Token(Token = "0x4003896")]
    [FieldOffset(Offset = "0x64")]
    public Json_Cave cave;
    [Token(Token = "0x4003897")]
    [FieldOffset(Offset = "0x68")]
    public Json_AbilityUp abilup;
    [Token(Token = "0x4003898")]
    [FieldOffset(Offset = "0x6C")]
    public Json_Arena arena;
    [Token(Token = "0x4003899")]
    [FieldOffset(Offset = "0x70")]
    public Json_Tour tour;
    [Token(Token = "0x400389A")]
    [FieldOffset(Offset = "0x74")]
    public Json_Vip vip;
    [Token(Token = "0x400389B")]
    [FieldOffset(Offset = "0x78")]
    public Json_Premium[] premium;
    [Token(Token = "0x400389C")]
    [FieldOffset(Offset = "0x7C")]
    public int unitbox_max;
    [Token(Token = "0x400389D")]
    [FieldOffset(Offset = "0x80")]
    public int itembox_max;
    [Token(Token = "0x400389E")]
    [FieldOffset(Offset = "0x84")]
    public Json_FreeGacha gachag;
    [Token(Token = "0x400389F")]
    [FieldOffset(Offset = "0x88")]
    public Json_FreeGacha gachac;
    [Token(Token = "0x40038A0")]
    [FieldOffset(Offset = "0x8C")]
    public Json_PaidGacha gachap;
    [Token(Token = "0x40038A1")]
    [FieldOffset(Offset = "0x90")]
    public Json_Friends friends;
    [Token(Token = "0x40038A2")]
    [FieldOffset(Offset = "0x94")]
    public int newgame_at;
    [Token(Token = "0x40038A3")]
    [FieldOffset(Offset = "0x98")]
    public string selected_award;
    [Token(Token = "0x40038A4")]
    [FieldOffset(Offset = "0x9C")]
    public Json_MultiOption multi;
    [Token(Token = "0x40038A5")]
    [FieldOffset(Offset = "0xA0")]
    public Json_GuerrillaShopPeriod g_shop;
    [Token(Token = "0x40038A6")]
    [FieldOffset(Offset = "0xA4")]
    public JSON_AdventureData[] adventure_areas;
    [Token(Token = "0x40038A7")]
    [FieldOffset(Offset = "0xA8")]
    public Json_BondData[] bonds;

    [Token(Token = "0x6004254")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PlayerData()
    {
    }
  }
}
