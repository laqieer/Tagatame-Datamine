// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusLobby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003148")]
  public class ReqVersusLobby : WebAPI
  {
    [Token(Token = "0x600DDDD")]
    [Address(RVA = "0xA8EEB0", Offset = "0xA8DCB0", VA = "0x10A8EEB0")]
    public ReqVersusLobby(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003149")]
    public class Response
    {
      [Token(Token = "0x400ECFE")]
      [FieldOffset(Offset = "0x8")]
      public int rankmatch_schedule_id;
      [Token(Token = "0x400ECFF")]
      [FieldOffset(Offset = "0xC")]
      public int rankmatch_ranking_status;
      [Token(Token = "0x400ED00")]
      [FieldOffset(Offset = "0x10")]
      public ReqRankMatchStatus.EnableTimeSchedule rankmatch_enabletime;
      [Token(Token = "0x400ED01")]
      [FieldOffset(Offset = "0x14")]
      public int draft_schedule_id;
      [Token(Token = "0x400ED02")]
      [FieldOffset(Offset = "0x18")]
      public int draft_type;
      [Token(Token = "0x400ED03")]
      [FieldOffset(Offset = "0x1C")]
      public int leaguematch_season_id;
      [Token(Token = "0x400ED04")]
      [FieldOffset(Offset = "0x20")]
      public int leaguematch_matching_period;

      [Token(Token = "0x17001D06")]
      public ReqRankMatchStatus.RankingStatus RankMatchRankingStatus
      {
        [Token(Token = "0x600DDDE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new ReqRankMatchStatus.RankingStatus();
        }
      }

      [Token(Token = "0x600DDDF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
