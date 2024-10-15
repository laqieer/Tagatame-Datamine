// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBeatRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C6B")]
  public class RaidBeatRewardParam : RaidMasterParam<JSON_RaidBeatRewardParam>
  {
    [Token(Token = "0x4006FA2")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006FA3")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidBeatRewardDataParam> mRewards;

    [Token(Token = "0x17000F00")]
    public int Id
    {
      [Token(Token = "0x6007542"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F01")]
    public List<RaidBeatRewardDataParam> Rewards
    {
      [Token(Token = "0x6007543"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidBeatRewardDataParam>) null;
      }
    }

    [Token(Token = "0x6007544")]
    [Address(RVA = "0x392BA0", Offset = "0x3919A0", VA = "0x10392BA0", Slot = "4")]
    public override bool Deserialize(JSON_RaidBeatRewardParam json) => new bool();

    [Token(Token = "0x6007545")]
    [Address(RVA = "0x392CE0", Offset = "0x391AE0", VA = "0x10392CE0")]
    public RaidBeatRewardParam()
    {
    }
  }
}
