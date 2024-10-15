// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC4")]
  public class DuelRewardParam
  {
    [Token(Token = "0x4006331")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006332")]
    [FieldOffset(Offset = "0xC")]
    private List<DuelReward> mRewards;

    [Token(Token = "0x17000C6F")]
    public string Iname
    {
      [Token(Token = "0x6006E55"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C70")]
    public List<DuelReward> Rewards
    {
      [Token(Token = "0x6006E56"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<DuelReward>) null;
      }
    }

    [Token(Token = "0x6006E57")]
    [Address(RVA = "0x35FBB0", Offset = "0x35E9B0", VA = "0x1035FBB0")]
    public bool Deserialize(JSON_DuelRewardParam json) => new bool();

    [Token(Token = "0x6006E58")]
    [Address(RVA = "0x35FD30", Offset = "0x35EB30", VA = "0x1035FD30")]
    public static void Deserialize(ref DuelRewardParam[] param, JSON_DuelRewardParam[] json)
    {
    }

    [Token(Token = "0x6006E59")]
    [Address(RVA = "0x360010", Offset = "0x35EE10", VA = "0x10360010")]
    public DuelRewardParam()
    {
    }
  }
}
