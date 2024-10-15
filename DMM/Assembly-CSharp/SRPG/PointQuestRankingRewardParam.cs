// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRankingRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C13")]
  public class PointQuestRankingRewardParam
  {
    [Token(Token = "0x4006CC6")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006CC7")]
    [FieldOffset(Offset = "0xC")]
    private List<PointQuestRankingRewardData> mRewards;

    [Token(Token = "0x17000E7C")]
    public string Iname
    {
      [Token(Token = "0x60073A9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E7D")]
    public List<PointQuestRankingRewardData> Rewards
    {
      [Token(Token = "0x60073AA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<PointQuestRankingRewardData>) null;
      }
    }

    [Token(Token = "0x60073AB")]
    [Address(RVA = "0x37EF70", Offset = "0x37DD70", VA = "0x1037EF70")]
    public void Deserialize(JSON_PointQuestRankingRewardParam json)
    {
    }

    [Token(Token = "0x60073AC")]
    [Address(RVA = "0x37ED00", Offset = "0x37DB00", VA = "0x1037ED00")]
    public static void Deserialize(
      ref ParamDictionary<string, PointQuestRankingRewardParam> ref_params,
      JSON_PointQuestRankingRewardParam[] jsons)
    {
    }

    [Token(Token = "0x60073AD")]
    [Address(RVA = "0x37F0C0", Offset = "0x37DEC0", VA = "0x1037F0C0")]
    public static PointQuestRankingRewardParam GetPointQuestRankingRewardParam(string id)
    {
      return (PointQuestRankingRewardParam) null;
    }

    [Token(Token = "0x60073AE")]
    [Address(RVA = "0x37F1C0", Offset = "0x37DFC0", VA = "0x1037F1C0")]
    public PointQuestEventRewardParam GetPointQuestRewardParam(int rank)
    {
      return (PointQuestEventRewardParam) null;
    }

    [Token(Token = "0x60073AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestRankingRewardParam()
    {
    }
  }
}
