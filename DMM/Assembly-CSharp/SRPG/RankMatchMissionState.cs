// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchMissionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001056")]
  public class RankMatchMissionState
  {
    [Token(Token = "0x4003A6E")]
    [FieldOffset(Offset = "0x8")]
    private string mIName;
    [Token(Token = "0x4003A6F")]
    [FieldOffset(Offset = "0xC")]
    private int mProgress;
    [Token(Token = "0x4003A70")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mRewardedAt;
    [Token(Token = "0x4003A71")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsRewarded;

    [Token(Token = "0x17000631")]
    public string IName
    {
      [Token(Token = "0x6004308"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000632")]
    public int Progress
    {
      [Token(Token = "0x6004309"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000633")]
    public DateTime RewardedAt
    {
      [Token(Token = "0x600430A"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000634")]
    public bool IsRewarded
    {
      [Token(Token = "0x600430B"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600430C")]
    [Address(RVA = "0x11E91F0", Offset = "0x11E7FF0", VA = "0x111E91F0")]
    public void Deserialize(string iname, int prog, string rewarded_at)
    {
    }

    [Token(Token = "0x600430D")]
    [Address(RVA = "0x11E9270", Offset = "0x11E8070", VA = "0x111E9270")]
    public void Increment()
    {
    }

    [Token(Token = "0x600430E")]
    [Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")]
    public void SetProgress(int prog)
    {
    }

    [Token(Token = "0x600430F")]
    [Address(RVA = "0x11E9280", Offset = "0x11E8080", VA = "0x111E9280")]
    public void Rewarded()
    {
    }

    [Token(Token = "0x6004310")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankMatchMissionState()
    {
    }
  }
}
