// Decompiled with JetBrains decompiler
// Type: SRPG.ReqQuestRankingPartyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200157E")]
  public class ReqQuestRankingPartyData
  {
    [Token(Token = "0x4004E46")]
    [FieldOffset(Offset = "0x8")]
    public int m_ScheduleID;
    [Token(Token = "0x4004E47")]
    [FieldOffset(Offset = "0xC")]
    public RankingQuestType m_RankingType;
    [Token(Token = "0x4004E48")]
    [FieldOffset(Offset = "0x10")]
    public string m_QuestID;
    [Token(Token = "0x4004E49")]
    [FieldOffset(Offset = "0x14")]
    public string m_TargetUID;

    [Token(Token = "0x60058B6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ReqQuestRankingPartyData()
    {
    }
  }
}
