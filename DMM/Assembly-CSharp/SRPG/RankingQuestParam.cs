// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C8B")]
  public class RankingQuestParam
  {
    [Token(Token = "0x400701F")]
    [FieldOffset(Offset = "0x8")]
    public int schedule_id;
    [Token(Token = "0x4007020")]
    [FieldOffset(Offset = "0xC")]
    public RankingQuestType type;
    [Token(Token = "0x4007021")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4007022")]
    [FieldOffset(Offset = "0x14")]
    public int reward_id;
    [Token(Token = "0x4007023")]
    [FieldOffset(Offset = "0x18")]
    public RankingQuestRewardParam rewardParam;
    [Token(Token = "0x4007024")]
    [FieldOffset(Offset = "0x1C")]
    public RankingQuestScheduleParam scheduleParam;

    [Token(Token = "0x60075AA")]
    [Address(RVA = "0x393BB0", Offset = "0x3929B0", VA = "0x10393BB0")]
    public bool Deserialize(JSON_RankingQuestParam json) => new bool();

    [Token(Token = "0x60075AB")]
    [Address(RVA = "0x393CA0", Offset = "0x392AA0", VA = "0x10393CA0")]
    public static RankingQuestParam FindRankingQuestParam(
      string targetQuestID,
      int scheduleID,
      RankingQuestType type)
    {
      return (RankingQuestParam) null;
    }

    [Token(Token = "0x60075AC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingQuestParam()
    {
    }
  }
}
