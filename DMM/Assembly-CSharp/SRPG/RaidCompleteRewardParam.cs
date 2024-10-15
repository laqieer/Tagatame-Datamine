// Decompiled with JetBrains decompiler
// Type: SRPG.RaidCompleteRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C71")]
  public class RaidCompleteRewardParam : RaidMasterParam<JSON_RaidCompleteRewardParam>
  {
    [Token(Token = "0x4006FCB")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006FCC")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidCompleteRewardDataParam> mRewards;

    [Token(Token = "0x17000F15")]
    public int Id
    {
      [Token(Token = "0x6007561"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F16")]
    public List<RaidCompleteRewardDataParam> Rewards
    {
      [Token(Token = "0x6007562"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidCompleteRewardDataParam>) null;
      }
    }

    [Token(Token = "0x6007563")]
    [Address(RVA = "0x3930C0", Offset = "0x391EC0", VA = "0x103930C0", Slot = "4")]
    public override bool Deserialize(JSON_RaidCompleteRewardParam json) => new bool();

    [Token(Token = "0x6007564")]
    [Address(RVA = "0x393200", Offset = "0x392000", VA = "0x10393200")]
    public RaidCompleteRewardParam()
    {
    }
  }
}
