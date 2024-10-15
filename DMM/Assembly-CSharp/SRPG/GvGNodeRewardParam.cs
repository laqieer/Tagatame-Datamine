// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNodeRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B79")]
  public class GvGNodeRewardParam : GvGMasterParam<JSON_GvGNodeRewardParam>
  {
    [Token(Token = "0x17000DA7")]
    public string Id
    {
      [Token(Token = "0x6007177"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007178"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000DA8")]
    public List<GvGNodeReward> Rewards
    {
      [Token(Token = "0x6007179"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GvGNodeReward>) null;
      }
      [Token(Token = "0x600717A"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600717B")]
    [Address(RVA = "0x373940", Offset = "0x372740", VA = "0x10373940", Slot = "4")]
    public override bool Deserialize(JSON_GvGNodeRewardParam json) => new bool();

    [Token(Token = "0x600717C")]
    [Address(RVA = "0x373AC0", Offset = "0x3728C0", VA = "0x10373AC0")]
    public static GvGRewardParam GetGvGRewardParam(string id, string league)
    {
      return (GvGRewardParam) null;
    }

    [Token(Token = "0x600717D")]
    [Address(RVA = "0x373D80", Offset = "0x372B80", VA = "0x10373D80")]
    public GvGNodeRewardParam()
    {
    }
  }
}
