// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptCardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A72")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ConceptCardParam
  {
    [Token(Token = "0x4006189")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400618A")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400618B")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x400618C")]
    [FieldOffset(Offset = "0x14")]
    public int type;
    [Token(Token = "0x400618D")]
    [FieldOffset(Offset = "0x18")]
    public string icon;
    [Token(Token = "0x400618E")]
    [FieldOffset(Offset = "0x1C")]
    public int rare;
    [Token(Token = "0x400618F")]
    [FieldOffset(Offset = "0x20")]
    public int lvcap;
    [Token(Token = "0x4006190")]
    [FieldOffset(Offset = "0x24")]
    public int sell;
    [Token(Token = "0x4006191")]
    [FieldOffset(Offset = "0x28")]
    public int coin_item;
    [Token(Token = "0x4006192")]
    [FieldOffset(Offset = "0x2C")]
    public int en_cost;
    [Token(Token = "0x4006193")]
    [FieldOffset(Offset = "0x30")]
    public int en_exp;
    [Token(Token = "0x4006194")]
    [FieldOffset(Offset = "0x34")]
    public int en_trust;
    [Token(Token = "0x4006195")]
    [FieldOffset(Offset = "0x38")]
    public string trust_reward;
    [Token(Token = "0x4006196")]
    [FieldOffset(Offset = "0x3C")]
    public string first_get_unit;
    [Token(Token = "0x4006197")]
    [FieldOffset(Offset = "0x40")]
    public JSON_ConceptCardEquipParam[] effects;
    [Token(Token = "0x4006198")]
    [FieldOffset(Offset = "0x44")]
    public int not_sale;
    [Token(Token = "0x4006199")]
    [FieldOffset(Offset = "0x48")]
    public int birth_id;
    [Token(Token = "0x400619A")]
    [FieldOffset(Offset = "0x4C")]
    public string[] concept_card_groups;
    [Token(Token = "0x400619B")]
    [FieldOffset(Offset = "0x50")]
    public string leader_skill;
    [Token(Token = "0x400619C")]
    [FieldOffset(Offset = "0x54")]
    public int gallery_view;
    [Token(Token = "0x400619D")]
    [FieldOffset(Offset = "0x58")]
    public int is_other;
    [Token(Token = "0x400619E")]
    [FieldOffset(Offset = "0x5C")]
    public string bg_image;
    [Token(Token = "0x400619F")]
    [FieldOffset(Offset = "0x60")]
    public string[] unit_images;
    [Token(Token = "0x40061A0")]
    [FieldOffset(Offset = "0x64")]
    public int extra_rarity_pt_rare1;
    [Token(Token = "0x40061A1")]
    [FieldOffset(Offset = "0x68")]
    public int extra_rarity_pt_rare2;
    [Token(Token = "0x40061A2")]
    [FieldOffset(Offset = "0x6C")]
    public int extra_rarity_pt_rare3;
    [Token(Token = "0x40061A3")]
    [FieldOffset(Offset = "0x70")]
    public int extra_rarity_pt_rare4;
    [Token(Token = "0x40061A4")]
    [FieldOffset(Offset = "0x74")]
    public int extra_rarity_pt_rare5;
    [Token(Token = "0x40061A5")]
    [FieldOffset(Offset = "0x78")]
    public string extra_rarity_iname;

    [Token(Token = "0x6006CA5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptCardParam()
    {
    }
  }
}
