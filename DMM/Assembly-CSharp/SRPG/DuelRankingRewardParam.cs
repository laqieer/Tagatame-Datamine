// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ABE")]
  public class DuelRankingRewardParam
  {
    [Token(Token = "0x4006321")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006322")]
    [FieldOffset(Offset = "0xC")]
    private List<DuelRankingReward> mRewards;

    [Token(Token = "0x17000C63")]
    public string Iname
    {
      [Token(Token = "0x6006E34"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C64")]
    public List<DuelRankingReward> Rewards
    {
      [Token(Token = "0x6006E35"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<DuelRankingReward>) null;
      }
    }

    [Token(Token = "0x6006E36")]
    [Address(RVA = "0x35F8C0", Offset = "0x35E6C0", VA = "0x1035F8C0")]
    public bool Deserialize(JSON_DuelRankingRewardParam json) => new bool();

    [Token(Token = "0x6006E37")]
    [Address(RVA = "0x35F720", Offset = "0x35E520", VA = "0x1035F720")]
    public static void Deserialize(
      ref DuelRankingRewardParam[] param,
      JSON_DuelRankingRewardParam[] json)
    {
    }

    [Token(Token = "0x6006E38")]
    [Address(RVA = "0x35FB20", Offset = "0x35E920", VA = "0x1035FB20")]
    public DuelRankingRewardParam()
    {
    }
  }
}
