// Decompiled with JetBrains decompiler
// Type: SRPG.RaidDamageAmountRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C75")]
  public class RaidDamageAmountRewardParam : RaidMasterParam<JSON_RaidDamageAmountRewardParam>
  {
    [Token(Token = "0x4006FD3")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006FD4")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidDamageAmountRewardWeightParam> mRewards;

    [Token(Token = "0x17000F19")]
    public int Id
    {
      [Token(Token = "0x600756B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F1A")]
    public List<RaidDamageAmountRewardWeightParam> Rewards
    {
      [Token(Token = "0x600756C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidDamageAmountRewardWeightParam>) null;
      }
    }

    [Token(Token = "0x600756D")]
    [Address(RVA = "0x393240", Offset = "0x392040", VA = "0x10393240", Slot = "4")]
    public override bool Deserialize(JSON_RaidDamageAmountRewardParam json) => new bool();

    [Token(Token = "0x600756E")]
    [Address(RVA = "0x393380", Offset = "0x392180", VA = "0x10393380")]
    public RaidDamageAmountRewardParam()
    {
    }
  }
}
