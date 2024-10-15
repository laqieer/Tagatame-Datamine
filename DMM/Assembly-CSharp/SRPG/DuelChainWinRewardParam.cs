// Decompiled with JetBrains decompiler
// Type: SRPG.DuelChainWinRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC2")]
  public class DuelChainWinRewardParam
  {
    [Token(Token = "0x400632D")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400632E")]
    [FieldOffset(Offset = "0xC")]
    private List<DuelChainWinReward> mRewards;

    [Token(Token = "0x17000C6B")]
    public string Iname
    {
      [Token(Token = "0x6006E4C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C6C")]
    public List<DuelChainWinReward> Rewards
    {
      [Token(Token = "0x6006E4D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<DuelChainWinReward>) null;
      }
    }

    [Token(Token = "0x6006E4E")]
    [Address(RVA = "0x35F520", Offset = "0x35E320", VA = "0x1035F520")]
    public bool Deserialize(JSON_DuelChainWinRewardParam json) => new bool();

    [Token(Token = "0x6006E4F")]
    [Address(RVA = "0x35F260", Offset = "0x35E060", VA = "0x1035F260")]
    public static void Deserialize(
      ref DuelChainWinRewardParam[] param,
      JSON_DuelChainWinRewardParam[] json)
    {
    }

    [Token(Token = "0x6006E50")]
    [Address(RVA = "0x35F680", Offset = "0x35E480", VA = "0x1035F680")]
    public DuelChainWinRewardParam()
    {
    }
  }
}
