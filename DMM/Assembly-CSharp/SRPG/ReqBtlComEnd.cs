// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlComEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030AF")]
  public class ReqBtlComEnd : WebAPI
  {
    [Token(Token = "0x600DD2C")]
    [Address(RVA = "0xA80E20", Offset = "0xA7FC20", VA = "0x10A80E20")]
    public ReqBtlComEnd(
      string req_fuid,
      int opp_rank,
      int my_rank,
      BtlResultTypes result,
      int[] beats,
      int[] itemSteals,
      int[] goldSteals,
      int[] missions,
      int[] missions_log,
      string[] fuid,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response,
      BtlEndTypes apiType,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x600DD2D")]
    [Address(RVA = "0xA80CC0", Offset = "0xA7FAC0", VA = "0x10A80CC0")]
    public ReqBtlComEnd(
      long btlid,
      int time,
      BtlResultTypes result,
      int[] beats,
      int[] itemSteals,
      int[] goldSteals,
      int[] missions,
      int[] missions_log,
      string[] fuid,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response,
      BtlEndTypes apiType,
      string trophyprog = null,
      string bingoprog = null,
      int elem = 0,
      string rankingQuestEndParam = null,
      bool is_rehash = false,
      bool? is_skip = null,
      BattleCore.Record record = null,
      int time_per_lap = 0,
      string point_quest_request = null)
    {
    }

    [Token(Token = "0x600DD2E")]
    [Address(RVA = "0xA80FD0", Offset = "0xA7FDD0", VA = "0x10A80FD0")]
    private string makeBody(
      bool is_arena,
      long btlid,
      int time,
      BtlResultTypes result,
      int[] beats,
      int[] itemSteals,
      int[] goldSteals,
      int[] missions,
      int[] missions_log,
      string[] fuid,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response,
      BtlEndTypes apiType,
      string trophyprog,
      string bingoprog,
      int elem = 0,
      string rankingQuestEndParam = null,
      bool is_rehash = false,
      bool? is_skip = null,
      BattleCore.Record record = null,
      int time_per_lap = 0,
      string point_quest_request = null)
    {
      return (string) null;
    }

    [Token(Token = "0x600DD2F")]
    [Address(RVA = "0xA80BC0", Offset = "0xA7F9C0", VA = "0x10A80BC0")]
    public static string CreateRankingQuestEndParam(int main_score, int sub_score) => (string) null;
  }
}
