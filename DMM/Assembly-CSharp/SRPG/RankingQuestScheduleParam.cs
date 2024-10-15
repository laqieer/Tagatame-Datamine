// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C93")]
  public class RankingQuestScheduleParam
  {
    [Token(Token = "0x400703F")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4007040")]
    [FieldOffset(Offset = "0x10")]
    public DateTime beginAt;
    [Token(Token = "0x4007041")]
    [FieldOffset(Offset = "0x18")]
    public DateTime endAt;
    [Token(Token = "0x4007042")]
    [FieldOffset(Offset = "0x20")]
    public DateTime reward_begin_at;
    [Token(Token = "0x4007043")]
    [FieldOffset(Offset = "0x28")]
    public DateTime reward_end_at;
    [Token(Token = "0x4007044")]
    [FieldOffset(Offset = "0x30")]
    public DateTime visible_begin_at;
    [Token(Token = "0x4007045")]
    [FieldOffset(Offset = "0x38")]
    public DateTime visible_end_at;

    [Token(Token = "0x60075B7")]
    [Address(RVA = "0x394290", Offset = "0x393090", VA = "0x10394290")]
    public bool Deserialize(JSON_RankingQuestScheduleParam json) => new bool();

    [Token(Token = "0x60075B8")]
    [Address(RVA = "0x394C80", Offset = "0x393A80", VA = "0x10394C80")]
    public bool IsAvailablePeriod(DateTime now) => new bool();

    [Token(Token = "0x60075B9")]
    [Address(RVA = "0x394D20", Offset = "0x393B20", VA = "0x10394D20")]
    public bool IsAvailableRewardPeriod(DateTime now) => new bool();

    [Token(Token = "0x60075BA")]
    [Address(RVA = "0x394DC0", Offset = "0x393BC0", VA = "0x10394DC0")]
    public bool IsAvailableVisiblePeriod(DateTime now) => new bool();

    [Token(Token = "0x60075BB")]
    [Address(RVA = "0x394A40", Offset = "0x393840", VA = "0x10394A40")]
    public static List<RankingQuestScheduleParam> GetRankingQuestScheduleParam(
      RankingQuestScheduleParam.RakingQuestScheduleGetFlags flag)
    {
      return (List<RankingQuestScheduleParam>) null;
    }

    [Token(Token = "0x60075BC")]
    [Address(RVA = "0x394830", Offset = "0x393630", VA = "0x10394830")]
    public static List<RankingQuestParam> FindRankingQuestParamBySchedule(
      RankingQuestScheduleParam.RakingQuestScheduleGetFlags flag)
    {
      return (List<RankingQuestParam>) null;
    }

    [Token(Token = "0x60075BD")]
    [Address(RVA = "0x394700", Offset = "0x393500", VA = "0x10394700")]
    public static RankingQuestScheduleParam FindByID(int id) => (RankingQuestScheduleParam) null;

    [Token(Token = "0x60075BE")]
    [Address(RVA = "0x3940C0", Offset = "0x392EC0", VA = "0x103940C0")]
    public static RankingQuestParam CompareOpenOrLatest(
      ref DateTime now,
      RankingQuestParam param1,
      RankingQuestParam param2)
    {
      return (RankingQuestParam) null;
    }

    [Token(Token = "0x60075BF")]
    [Address(RVA = "0x3944E0", Offset = "0x3932E0", VA = "0x103944E0")]
    public static List<RankingQuestParam> FilterDuplicateRankingQuestIDs(
      List<RankingQuestParam> list)
    {
      return (List<RankingQuestParam>) null;
    }

    [Token(Token = "0x60075C0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingQuestScheduleParam()
    {
    }

    [Token(Token = "0x2001C94")]
    [Flags]
    public enum RakingQuestScheduleGetFlags
    {
      [Token(Token = "0x4007047")] All = 0,
      [Token(Token = "0x4007048")] Open = 1,
      [Token(Token = "0x4007049")] Reward = 2,
      [Token(Token = "0x400704A")] Visible = 4,
    }
  }
}
