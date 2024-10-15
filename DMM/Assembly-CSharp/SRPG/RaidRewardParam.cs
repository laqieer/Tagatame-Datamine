// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C87")]
  public class RaidRewardParam : RaidMasterParam<JSON_RaidRewardParam>
  {
    [Token(Token = "0x4007013")]
    [FieldOffset(Offset = "0x8")]
    private string mId;
    [Token(Token = "0x4007014")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidReward> mRewards;

    [Token(Token = "0x17000F34")]
    public string Id
    {
      [Token(Token = "0x60075A0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F35")]
    public List<RaidReward> Rewards
    {
      [Token(Token = "0x60075A1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidReward>) null;
      }
    }

    [Token(Token = "0x60075A2")]
    [Address(RVA = "0x393A10", Offset = "0x392810", VA = "0x10393A10", Slot = "4")]
    public override bool Deserialize(JSON_RaidRewardParam json) => new bool();

    [Token(Token = "0x60075A3")]
    [Address(RVA = "0x393B70", Offset = "0x392970", VA = "0x10393B70")]
    public RaidRewardParam()
    {
    }
  }
}
