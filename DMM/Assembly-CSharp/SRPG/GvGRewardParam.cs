// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B87")]
  public class GvGRewardParam : GvGMasterParam<JSON_GvGRewardParam>
  {
    [Token(Token = "0x17000DC6")]
    public string Id
    {
      [Token(Token = "0x60071D4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071D5"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000DC7")]
    public List<GvGRewardDetailParam> Rewards
    {
      [Token(Token = "0x60071D6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GvGRewardDetailParam>) null;
      }
      [Token(Token = "0x60071D7"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60071D8")]
    [Address(RVA = "0x374AD0", Offset = "0x3738D0", VA = "0x10374AD0", Slot = "4")]
    public override bool Deserialize(JSON_GvGRewardParam json) => new bool();

    [Token(Token = "0x60071D9")]
    [Address(RVA = "0x374C30", Offset = "0x373A30", VA = "0x10374C30")]
    public static GvGRewardParam GetReward(string id) => (GvGRewardParam) null;

    [Token(Token = "0x60071DA")]
    [Address(RVA = "0x374D70", Offset = "0x373B70", VA = "0x10374D70")]
    public GvGRewardParam()
    {
    }
  }
}
