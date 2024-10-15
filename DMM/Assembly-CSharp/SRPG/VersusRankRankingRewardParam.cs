// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankRankingRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED6")]
  public class VersusRankRankingRewardParam
  {
    [Token(Token = "0x40081AE")]
    [FieldOffset(Offset = "0x8")]
    private int mScheduleId;
    [Token(Token = "0x40081AF")]
    [FieldOffset(Offset = "0xC")]
    private int mRankBegin;
    [Token(Token = "0x40081B0")]
    [FieldOffset(Offset = "0x10")]
    private int mRankEnd;
    [Token(Token = "0x40081B1")]
    [FieldOffset(Offset = "0x14")]
    private string mRewardId;

    [Token(Token = "0x170011C8")]
    public int ScheduleId
    {
      [Token(Token = "0x6007E2E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011C9")]
    public int RankBegin
    {
      [Token(Token = "0x6007E2F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011CA")]
    public int RankEnd
    {
      [Token(Token = "0x6007E30"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011CB")]
    public string RewardId
    {
      [Token(Token = "0x6007E31"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007E32")]
    [Address(RVA = "0x3FB4E0", Offset = "0x3FA2E0", VA = "0x103FB4E0")]
    public bool Deserialize(JSON_VersusRankRankingRewardParam json) => new bool();

    [Token(Token = "0x6007E33")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankRankingRewardParam()
    {
    }
  }
}
