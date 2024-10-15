// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRewardRankingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B8C")]
  public class GvGRewardRankingParam : GvGMasterParam<JSON_GvGRewardRankingParam>
  {
    [Token(Token = "0x17000DCB")]
    public string Id
    {
      [Token(Token = "0x60071E7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071E8"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000DCC")]
    public List<GvGRewardRankingDetailParam> RewardDetail
    {
      [Token(Token = "0x60071E9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GvGRewardRankingDetailParam>) null;
      }
      [Token(Token = "0x60071EA"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60071EB")]
    [Address(RVA = "0x374DB0", Offset = "0x373BB0", VA = "0x10374DB0", Slot = "4")]
    public override bool Deserialize(JSON_GvGRewardRankingParam json) => new bool();

    [Token(Token = "0x60071EC")]
    [Address(RVA = "0x374F00", Offset = "0x373D00", VA = "0x10374F00")]
    public static GvGRewardRankingParam GetRewardRanking(string id) => (GvGRewardRankingParam) null;

    [Token(Token = "0x60071ED")]
    [Address(RVA = "0x375050", Offset = "0x373E50", VA = "0x10375050")]
    public GvGRewardRankingParam()
    {
    }
  }
}
