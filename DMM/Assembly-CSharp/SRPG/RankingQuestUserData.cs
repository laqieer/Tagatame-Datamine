// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestUserData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001576")]
  public class RankingQuestUserData
  {
    [Token(Token = "0x4004E1F")]
    [FieldOffset(Offset = "0x8")]
    public string m_PlayerName;
    [Token(Token = "0x4004E20")]
    [FieldOffset(Offset = "0xC")]
    public int m_PlayerLevel;
    [Token(Token = "0x4004E21")]
    [FieldOffset(Offset = "0x10")]
    public int m_Rank;
    [Token(Token = "0x4004E22")]
    [FieldOffset(Offset = "0x14")]
    public UnitData m_UnitData;
    [Token(Token = "0x4004E23")]
    [FieldOffset(Offset = "0x18")]
    public int m_MainScore;
    [Token(Token = "0x4004E24")]
    [FieldOffset(Offset = "0x1C")]
    public int m_SubScore;
    [Token(Token = "0x4004E25")]
    [FieldOffset(Offset = "0x20")]
    public RankingQuestType m_RankingType;
    [Token(Token = "0x4004E26")]
    [FieldOffset(Offset = "0x24")]
    public ViewGuildData ViewGuild;
    [Token(Token = "0x4004E27")]
    [FieldOffset(Offset = "0x28")]
    public string m_UID;

    [Token(Token = "0x1700096B")]
    public bool IsActionCountRanking
    {
      [Token(Token = "0x600589B"), Address(RVA = "0x12DC250", Offset = "0x12DB050", VA = "0x112DC250")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600589C")]
    [Address(RVA = "0x12DC0C0", Offset = "0x12DAEC0", VA = "0x112DC0C0")]
    public void Deserialize(
      FlowNode_ReqQuestRanking.Json_OthersRankingData json)
    {
    }

    [Token(Token = "0x600589D")]
    [Address(RVA = "0x12DBF00", Offset = "0x12DAD00", VA = "0x112DBF00")]
    public void Deserialize(FlowNode_ReqQuestRanking.Json_OwnRankingData json)
    {
    }

    [Token(Token = "0x600589E")]
    [Address(RVA = "0x12DBD50", Offset = "0x12DAB50", VA = "0x112DBD50")]
    public static RankingQuestUserData CreateRankingUserDataFromJson(
      FlowNode_ReqQuestRanking.Json_OwnRankingData json,
      RankingQuestType type)
    {
      return (RankingQuestUserData) null;
    }

    [Token(Token = "0x600589F")]
    [Address(RVA = "0x12DBDC0", Offset = "0x12DABC0", VA = "0x112DBDC0")]
    public static RankingQuestUserData[] CreateRankingUserDataFromJson(
      FlowNode_ReqQuestRanking.Json_OthersRankingData[] json,
      RankingQuestType type)
    {
      return (RankingQuestUserData[]) null;
    }

    [Token(Token = "0x60058A0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingQuestUserData()
    {
    }
  }
}
