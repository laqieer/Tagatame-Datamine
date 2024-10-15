// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PlayerDataAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FEE")]
  [MessagePackObject(true)]
  public class Json_PlayerDataAll
  {
    [Token(Token = "0x4003854")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x4003855")]
    [FieldOffset(Offset = "0xC")]
    public Json_Unit[] units;
    [Token(Token = "0x4003856")]
    [FieldOffset(Offset = "0x10")]
    public Json_Item[] items;
    [Token(Token = "0x4003857")]
    [FieldOffset(Offset = "0x14")]
    public Json_Mail[] mails;
    [Token(Token = "0x4003858")]
    [FieldOffset(Offset = "0x18")]
    public Json_Party[] parties;
    [Token(Token = "0x4003859")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Friend[] friends;
    [Token(Token = "0x400385A")]
    [FieldOffset(Offset = "0x20")]
    public Json_Artifact[] artifacts;
    [Token(Token = "0x400385B")]
    [FieldOffset(Offset = "0x24")]
    public JSON_ConceptCard[] concept_cards;
    [Token(Token = "0x400385C")]
    [FieldOffset(Offset = "0x28")]
    public Json_Skin[] skins;
    [Token(Token = "0x400385D")]
    [FieldOffset(Offset = "0x2C")]
    public Json_Notify notify;
    [Token(Token = "0x400385E")]
    [FieldOffset(Offset = "0x30")]
    public Json_MultiFuids[] fuids;
    [Token(Token = "0x400385F")]
    [FieldOffset(Offset = "0x34")]
    public int status;
    [Token(Token = "0x4003860")]
    [FieldOffset(Offset = "0x38")]
    public string cuid;
    [Token(Token = "0x4003861")]
    [FieldOffset(Offset = "0x40")]
    public long tut;
    [Token(Token = "0x4003862")]
    [FieldOffset(Offset = "0x48")]
    public int first_contact;
    [Token(Token = "0x4003863")]
    [FieldOffset(Offset = "0x4C")]
    public Json_Versus vs;
    [Token(Token = "0x4003864")]
    [FieldOffset(Offset = "0x50")]
    public string[] tips;
    [Token(Token = "0x4003865")]
    [FieldOffset(Offset = "0x54")]
    public JSON_PlayerGuild player_guild;
    [Token(Token = "0x4003866")]
    [FieldOffset(Offset = "0x58")]
    public string fu_status;
    [Token(Token = "0x4003867")]
    [FieldOffset(Offset = "0x5C")]
    public Json_ExpireItem[] expire_items;
    [Token(Token = "0x4003868")]
    [FieldOffset(Offset = "0x60")]
    public JSON_TrophyProgress[] trophyprogs;
    [Token(Token = "0x4003869")]
    [FieldOffset(Offset = "0x64")]
    public JSON_TrophyProgress[] bingoprogs;
    [Token(Token = "0x400386A")]
    [FieldOffset(Offset = "0x68")]
    public JSON_TrophyProgress[] guild_trophies;
    [Token(Token = "0x400386B")]
    [FieldOffset(Offset = "0x6C")]
    public JSON_PartyOverWrite[] party_decks;
    [Token(Token = "0x400386C")]
    [FieldOffset(Offset = "0x70")]
    public string[] bgms;
    [Token(Token = "0x400386D")]
    [FieldOffset(Offset = "0x74")]
    public int rune_storage;
    [Token(Token = "0x400386E")]
    [FieldOffset(Offset = "0x78")]
    public int rune_storage_used;
    [Token(Token = "0x400386F")]
    [FieldOffset(Offset = "0x7C")]
    public JSON_StoryExChallengeCount story_ex_challenge;
    [Token(Token = "0x4003870")]
    [FieldOffset(Offset = "0x80")]
    public Json_HotDealInfo[] hot_deals;
    [Token(Token = "0x4003871")]
    [FieldOffset(Offset = "0x84")]
    public Json_InvalidSkill[] invalid_units;
    [Token(Token = "0x4003872")]
    [FieldOffset(Offset = "0x88")]
    public string[] mastery_reward_ids;
    [Token(Token = "0x4003873")]
    [FieldOffset(Offset = "0x8C")]
    public int door_master_unit_num;
    [Token(Token = "0x4003874")]
    [FieldOffset(Offset = "0x90")]
    public Json_BondData[] bonds;
    [Token(Token = "0x4003875")]
    [FieldOffset(Offset = "0x94")]
    public string[] trophy_daily_clear;
    [Token(Token = "0x4003876")]
    [FieldOffset(Offset = "0x98")]
    public JSON_Rune_Auto_Disassemble rune_auto_disassemble;
    [Token(Token = "0x4003877")]
    [FieldOffset(Offset = "0x9C")]
    public JSON_LeagueMatchOption leaguematch_option;
    [Token(Token = "0x4003878")]
    [FieldOffset(Offset = "0xA0")]
    public int is_tutorial_gacha;
    [Token(Token = "0x4003879")]
    [FieldOffset(Offset = "0xA4")]
    public int is_name_set;
    [Token(Token = "0x400387A")]
    [FieldOffset(Offset = "0xA8")]
    public int is_raidboss_invalid_rewarded;

    [Token(Token = "0x6004252")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PlayerDataAll()
    {
    }
  }
}
