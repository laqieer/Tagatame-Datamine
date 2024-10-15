// Decompiled with JetBrains decompiler
// Type: SRPG.RaidDamageRatioRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C79")]
  public class RaidDamageRatioRewardParam : RaidMasterParam<JSON_RaidDamageRatioRewardParam>
  {
    [Token(Token = "0x4006FDB")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006FDC")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidDamageRatioRewardWeightParam> mRewards;

    [Token(Token = "0x17000F1D")]
    public int Id
    {
      [Token(Token = "0x6007575"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F1E")]
    public List<RaidDamageRatioRewardWeightParam> Rewards
    {
      [Token(Token = "0x6007576"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidDamageRatioRewardWeightParam>) null;
      }
    }

    [Token(Token = "0x6007577")]
    [Address(RVA = "0x3933C0", Offset = "0x3921C0", VA = "0x103933C0", Slot = "4")]
    public override bool Deserialize(JSON_RaidDamageRatioRewardParam json) => new bool();

    [Token(Token = "0x6007578")]
    [Address(RVA = "0x393500", Offset = "0x392300", VA = "0x10393500")]
    public RaidDamageRatioRewardParam()
    {
    }
  }
}
