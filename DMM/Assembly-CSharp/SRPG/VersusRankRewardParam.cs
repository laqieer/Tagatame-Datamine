// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EDA")]
  public class VersusRankRewardParam
  {
    [Token(Token = "0x40081BA")]
    [FieldOffset(Offset = "0x8")]
    private string mRewardId;
    [Token(Token = "0x40081BB")]
    [FieldOffset(Offset = "0xC")]
    private List<VersusRankReward> mRewardList;

    [Token(Token = "0x170011CF")]
    public string RewardId
    {
      [Token(Token = "0x6007E3B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011D0")]
    public List<VersusRankReward> RewardList
    {
      [Token(Token = "0x6007E3C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<VersusRankReward>) null;
      }
    }

    [Token(Token = "0x6007E3D")]
    [Address(RVA = "0x3FB520", Offset = "0x3FA320", VA = "0x103FB520")]
    public bool Deserialize(JSON_VersusRankRewardParam json) => new bool();

    [Token(Token = "0x6007E3E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankRewardParam()
    {
    }
  }
}
