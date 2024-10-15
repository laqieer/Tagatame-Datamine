// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Unit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001004")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_Unit
  {
    [Token(Token = "0x40038DA")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x40038DB")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x40038DC")]
    [FieldOffset(Offset = "0x14")]
    public int rare;
    [Token(Token = "0x40038DD")]
    [FieldOffset(Offset = "0x18")]
    public int plus;
    [Token(Token = "0x40038DE")]
    [FieldOffset(Offset = "0x1C")]
    public int lv;
    [Token(Token = "0x40038DF")]
    [FieldOffset(Offset = "0x20")]
    public int exp;
    [Token(Token = "0x40038E0")]
    [FieldOffset(Offset = "0x24")]
    public int fav;
    [Token(Token = "0x40038E1")]
    [FieldOffset(Offset = "0x28")]
    public Json_MasterAbility abil;
    [Token(Token = "0x40038E2")]
    [FieldOffset(Offset = "0x2C")]
    public Json_CollaboAbility c_abil;
    [Token(Token = "0x40038E3")]
    [FieldOffset(Offset = "0x30")]
    public Json_Job[] jobs;
    [Token(Token = "0x40038E4")]
    [FieldOffset(Offset = "0x34")]
    public Json_UnitSelectable select;
    [Token(Token = "0x40038E5")]
    [FieldOffset(Offset = "0x38")]
    public string[] quest_clear_unlocks;
    [Token(Token = "0x40038E6")]
    [FieldOffset(Offset = "0x3C")]
    public int elem;
    [Token(Token = "0x40038E7")]
    [FieldOffset(Offset = "0x40")]
    public JSON_ConceptCard[] concept_cards;
    [Token(Token = "0x40038E8")]
    [FieldOffset(Offset = "0x44")]
    public Json_Tobira[] doors;
    [Token(Token = "0x40038E9")]
    [FieldOffset(Offset = "0x48")]
    public Json_Ability[] door_abils;
    [Token(Token = "0x40038EA")]
    [FieldOffset(Offset = "0x4C")]
    public int rental;
    [Token(Token = "0x40038EB")]
    [FieldOffset(Offset = "0x50")]
    public int favpoint;
    [Token(Token = "0x40038EC")]
    [FieldOffset(Offset = "0x54")]
    public string rental_iname;
    [Token(Token = "0x40038ED")]
    [FieldOffset(Offset = "0x58")]
    public Json_RuneData[] runes;
    [Token(Token = "0x40038EE")]
    [FieldOffset(Offset = "0x5C")]
    public Json_InvalidSkillApplyType[] invalid_skills;
    [Token(Token = "0x40038EF")]
    [FieldOffset(Offset = "0x60")]
    public int truth_equip_lv;
    [Token(Token = "0x40038F0")]
    [FieldOffset(Offset = "0x64")]
    public Json_Resonance resonance;
    [Token(Token = "0x40038F1")]
    [FieldOffset(Offset = "0x68")]
    public JSON_CrystalData[] crystals;
    [Token(Token = "0x40038F2")]
    [FieldOffset(Offset = "0x6C")]
    public JSON_RunePride pride;
    [Token(Token = "0x40038F3")]
    [FieldOffset(Offset = "0x70")]
    public int pride_is_open;
    [Token(Token = "0x40038F4")]
    [FieldOffset(Offset = "0x74")]
    public int status_awake;

    [Token(Token = "0x6004268")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Unit()
    {
    }
  }
}
