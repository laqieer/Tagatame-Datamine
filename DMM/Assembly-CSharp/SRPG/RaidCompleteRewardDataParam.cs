﻿// Decompiled with JetBrains decompiler
// Type: SRPG.RaidCompleteRewardDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C72")]
  public class RaidCompleteRewardDataParam
  {
    [Token(Token = "0x4006FCD")]
    [FieldOffset(Offset = "0x8")]
    private int mRound;
    [Token(Token = "0x4006FCE")]
    [FieldOffset(Offset = "0xC")]
    private string mRewardId;

    [Token(Token = "0x17000F17")]
    public int Round
    {
      [Token(Token = "0x6007565"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F18")]
    public string RewardId
    {
      [Token(Token = "0x6007566"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007567")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_RaidCompleteRewardDataParam json) => new bool();

    [Token(Token = "0x6007568")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidCompleteRewardDataParam()
    {
    }
  }
}