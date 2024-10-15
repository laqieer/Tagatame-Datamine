// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBattleRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C67")]
  public class RaidBattleRewardParam : RaidMasterParam<JSON_RaidBattleRewardParam>
  {
    [Token(Token = "0x4006F9A")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006F9B")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidBattleRewardWeightParam> mRewards;

    [Token(Token = "0x17000EFC")]
    public int Id
    {
      [Token(Token = "0x6007538"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EFD")]
    public List<RaidBattleRewardWeightParam> Rewards
    {
      [Token(Token = "0x6007539"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidBattleRewardWeightParam>) null;
      }
    }

    [Token(Token = "0x600753A")]
    [Address(RVA = "0x392A20", Offset = "0x391820", VA = "0x10392A20", Slot = "4")]
    public override bool Deserialize(JSON_RaidBattleRewardParam json) => new bool();

    [Token(Token = "0x600753B")]
    [Address(RVA = "0x392B60", Offset = "0x391960", VA = "0x10392B60")]
    public RaidBattleRewardParam()
    {
    }
  }
}
