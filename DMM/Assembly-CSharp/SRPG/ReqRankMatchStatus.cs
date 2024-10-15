// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200312B")]
  public class ReqRankMatchStatus : WebAPI
  {
    [Token(Token = "0x600DDC0")]
    [Address(RVA = "0xA8AE20", Offset = "0xA89C20", VA = "0x10A8AE20")]
    public ReqRankMatchStatus(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200312C")]
    public enum RankingStatus
    {
      [Token(Token = "0x400ECC4")] Normal,
      [Token(Token = "0x400ECC5")] Aggregating,
      [Token(Token = "0x400ECC6")] Rewarding,
    }

    [Token(Token = "0x200312D")]
    public class EnableTimeSchedule
    {
      [Token(Token = "0x400ECC7")]
      [FieldOffset(Offset = "0x8")]
      public long expired;
      [Token(Token = "0x400ECC8")]
      [FieldOffset(Offset = "0x10")]
      public long next;
      [Token(Token = "0x400ECC9")]
      [FieldOffset(Offset = "0x18")]
      public string iname;

      [Token(Token = "0x600DDC1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EnableTimeSchedule()
      {
      }
    }

    [Token(Token = "0x200312E")]
    public class Response
    {
      [Token(Token = "0x400ECCA")]
      [FieldOffset(Offset = "0x8")]
      public int schedule_id;
      [Token(Token = "0x400ECCB")]
      [FieldOffset(Offset = "0xC")]
      public int ranking_status;
      [Token(Token = "0x400ECCC")]
      [FieldOffset(Offset = "0x10")]
      public ReqRankMatchStatus.EnableTimeSchedule enabletime;

      [Token(Token = "0x17001D05")]
      public ReqRankMatchStatus.RankingStatus RankingStatus
      {
        [Token(Token = "0x600DDC2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new ReqRankMatchStatus.RankingStatus();
        }
      }

      [Token(Token = "0x600DDC3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
