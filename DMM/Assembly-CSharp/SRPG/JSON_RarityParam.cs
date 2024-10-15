// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RarityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E16")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RarityParam
  {
    [Token(Token = "0x4007A4A")]
    [FieldOffset(Offset = "0x8")]
    public int unitcap;
    [Token(Token = "0x4007A4B")]
    [FieldOffset(Offset = "0xC")]
    public int jobcap;
    [Token(Token = "0x4007A4C")]
    [FieldOffset(Offset = "0x10")]
    public int awakecap;
    [Token(Token = "0x4007A4D")]
    [FieldOffset(Offset = "0x14")]
    public int piece;
    [Token(Token = "0x4007A4E")]
    [FieldOffset(Offset = "0x18")]
    public int ch_piece;
    [Token(Token = "0x4007A4F")]
    [FieldOffset(Offset = "0x1C")]
    public int ch_piece_select;
    [Token(Token = "0x4007A50")]
    [FieldOffset(Offset = "0x20")]
    public int rareup_cost;
    [Token(Token = "0x4007A51")]
    [FieldOffset(Offset = "0x24")]
    public int gain_pp;
    [Token(Token = "0x4007A52")]
    [FieldOffset(Offset = "0x28")]
    public int eq_enhcap;
    [Token(Token = "0x4007A53")]
    [FieldOffset(Offset = "0x2C")]
    public int eq_costscale;
    [Token(Token = "0x4007A54")]
    [FieldOffset(Offset = "0x30")]
    public int[] eq_points;
    [Token(Token = "0x4007A55")]
    [FieldOffset(Offset = "0x34")]
    public string eq_item1;
    [Token(Token = "0x4007A56")]
    [FieldOffset(Offset = "0x38")]
    public string eq_item2;
    [Token(Token = "0x4007A57")]
    [FieldOffset(Offset = "0x3C")]
    public string eq_item3;
    [Token(Token = "0x4007A58")]
    [FieldOffset(Offset = "0x40")]
    public int[] eq_num1;
    [Token(Token = "0x4007A59")]
    [FieldOffset(Offset = "0x44")]
    public int[] eq_num2;
    [Token(Token = "0x4007A5A")]
    [FieldOffset(Offset = "0x48")]
    public int[] eq_num3;
    [Token(Token = "0x4007A5B")]
    [FieldOffset(Offset = "0x4C")]
    public int hp;
    [Token(Token = "0x4007A5C")]
    [FieldOffset(Offset = "0x50")]
    public int mp;
    [Token(Token = "0x4007A5D")]
    [FieldOffset(Offset = "0x54")]
    public int atk;
    [Token(Token = "0x4007A5E")]
    [FieldOffset(Offset = "0x58")]
    public int def;
    [Token(Token = "0x4007A5F")]
    [FieldOffset(Offset = "0x5C")]
    public int mag;
    [Token(Token = "0x4007A60")]
    [FieldOffset(Offset = "0x60")]
    public int mnd;
    [Token(Token = "0x4007A61")]
    [FieldOffset(Offset = "0x64")]
    public int dex;
    [Token(Token = "0x4007A62")]
    [FieldOffset(Offset = "0x68")]
    public int spd;
    [Token(Token = "0x4007A63")]
    [FieldOffset(Offset = "0x6C")]
    public int cri;
    [Token(Token = "0x4007A64")]
    [FieldOffset(Offset = "0x70")]
    public int luk;
    [Token(Token = "0x4007A65")]
    [FieldOffset(Offset = "0x74")]
    public string drop;
    [Token(Token = "0x4007A66")]
    [FieldOffset(Offset = "0x78")]
    public int af_lvcap;
    [Token(Token = "0x4007A67")]
    [FieldOffset(Offset = "0x7C")]
    public int af_unlock;
    [Token(Token = "0x4007A68")]
    [FieldOffset(Offset = "0x80")]
    public int af_gousei;
    [Token(Token = "0x4007A69")]
    [FieldOffset(Offset = "0x84")]
    public int af_change;
    [Token(Token = "0x4007A6A")]
    [FieldOffset(Offset = "0x88")]
    public int af_unlock_cost;
    [Token(Token = "0x4007A6B")]
    [FieldOffset(Offset = "0x8C")]
    public int af_gousei_cost;
    [Token(Token = "0x4007A6C")]
    [FieldOffset(Offset = "0x90")]
    public int af_change_cost;
    [Token(Token = "0x4007A6D")]
    [FieldOffset(Offset = "0x94")]
    public int af_upcost;
    [Token(Token = "0x4007A6E")]
    [FieldOffset(Offset = "0x98")]
    public int card_lvcap;
    [Token(Token = "0x4007A6F")]
    [FieldOffset(Offset = "0x9C")]
    public int card_awake_count;
    [Token(Token = "0x4007A70")]
    [FieldOffset(Offset = "0xA0")]
    public int ch_piece_coin_num;
    [Token(Token = "0x4007A71")]
    [FieldOffset(Offset = "0xA4")]
    public int crystal_cap;
    [Token(Token = "0x4007A72")]
    [FieldOffset(Offset = "0xA8")]
    public string crystal_rank;
    [Token(Token = "0x4007A73")]
    [FieldOffset(Offset = "0xAC")]
    public int card_extra_rarity_lvcap;

    [Token(Token = "0x6007B86")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RarityParam()
    {
    }
  }
}
