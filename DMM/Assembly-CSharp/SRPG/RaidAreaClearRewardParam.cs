// Decompiled with JetBrains decompiler
// Type: SRPG.RaidAreaClearRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C61")]
  public class RaidAreaClearRewardParam : RaidMasterParam<JSON_RaidAreaClearRewardParam>
  {
    [Token(Token = "0x4006F86")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006F87")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidAreaClearRewardDataParam> mRewards;

    [Token(Token = "0x17000EF2")]
    public int Id
    {
      [Token(Token = "0x6007525"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF3")]
    public List<RaidAreaClearRewardDataParam> Rewards
    {
      [Token(Token = "0x6007526"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidAreaClearRewardDataParam>) null;
      }
    }

    [Token(Token = "0x6007527")]
    [Address(RVA = "0x392820", Offset = "0x391620", VA = "0x10392820", Slot = "4")]
    public override bool Deserialize(JSON_RaidAreaClearRewardParam json) => new bool();

    [Token(Token = "0x6007528")]
    [Address(RVA = "0x392960", Offset = "0x391760", VA = "0x10392960")]
    public RaidAreaClearRewardParam()
    {
    }
  }
}
