// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BtlComEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DAA")]
  public class Json_BtlComEnd : Json_PlayerDataAll
  {
    [Token(Token = "0x4002776")]
    [FieldOffset(Offset = "0xB0")]
    public JSON_QuestProgress[] quests;
    [Token(Token = "0x4002777")]
    [FieldOffset(Offset = "0xB4")]
    public Json_BtlQuestRanking quest_ranking;
    [Token(Token = "0x4002778")]
    [FieldOffset(Offset = "0xB8")]
    public Json_FirstClearItem[] fclr_items;
    [Token(Token = "0x4002779")]
    [FieldOffset(Offset = "0xBC")]
    public Json_BtlRewardConceptCard[] cards;
    [Token(Token = "0x400277A")]
    [FieldOffset(Offset = "0xC0")]
    public int is_mail_cards;
    [Token(Token = "0x400277B")]
    [FieldOffset(Offset = "0xC4")]
    public int is_quest_out_of_period;
    [Token(Token = "0x400277C")]
    [FieldOffset(Offset = "0xC8")]
    public BattleCore.Json_BtlInspSlot[] sins;
    [Token(Token = "0x400277D")]
    [FieldOffset(Offset = "0xCC")]
    public BattleCore.Json_BtlInsp[] levelup_sins;
    [Token(Token = "0x400277E")]
    [FieldOffset(Offset = "0xD0")]
    public int guildraid_bp_charge;
    [Token(Token = "0x400277F")]
    [FieldOffset(Offset = "0xD4")]
    public Json_RuneData[] runes_detail;
    [Token(Token = "0x4002780")]
    [FieldOffset(Offset = "0xD8")]
    public Json_PointQuestResult point_quest;
    [Token(Token = "0x4002781")]
    [FieldOffset(Offset = "0xDC")]
    public Json_Disassemble[] disassemble_rewards;

    [Token(Token = "0x600375C")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public Json_BtlComEnd()
    {
    }
  }
}
