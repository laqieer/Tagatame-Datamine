// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchSeasonResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001057")]
  public class RankMatchSeasonResult
  {
    [Token(Token = "0x4003A72")]
    [FieldOffset(Offset = "0x8")]
    private int mScheduleId;
    [Token(Token = "0x4003A73")]
    [FieldOffset(Offset = "0xC")]
    private int mScore;
    [Token(Token = "0x4003A74")]
    [FieldOffset(Offset = "0x10")]
    private int mRank;
    [Token(Token = "0x4003A75")]
    [FieldOffset(Offset = "0x14")]
    private RankMatchClass mClass;

    [Token(Token = "0x17000635")]
    public int ScheduleId
    {
      [Token(Token = "0x6004311"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000636")]
    public int Score
    {
      [Token(Token = "0x6004312"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000637")]
    public int Rank
    {
      [Token(Token = "0x6004313"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000638")]
    public RankMatchClass Class
    {
      [Token(Token = "0x6004314"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new RankMatchClass();
      }
    }

    [Token(Token = "0x6004315")]
    [Address(RVA = "0x11E92D0", Offset = "0x11E80D0", VA = "0x111E92D0")]
    public void Deserialize(ReqRankMatchReward.Response res)
    {
    }

    [Token(Token = "0x6004316")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankMatchSeasonResult()
    {
    }
  }
}
