// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestEventRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C07")]
  public class PointQuestEventRewardParam
  {
    [Token(Token = "0x4006C9C")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006C9D")]
    [FieldOffset(Offset = "0xC")]
    private List<PointQuestEventRewardsData> mRewards;

    [Token(Token = "0x17000E68")]
    public string Iname
    {
      [Token(Token = "0x6007379"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E69")]
    public List<PointQuestEventRewardsData> Rewards
    {
      [Token(Token = "0x600737A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<PointQuestEventRewardsData>) null;
      }
    }

    [Token(Token = "0x600737B")]
    [Address(RVA = "0x37DC10", Offset = "0x37CA10", VA = "0x1037DC10")]
    public void Deserialize(JSON_PointQuestEventRewardParam json)
    {
    }

    [Token(Token = "0x600737C")]
    [Address(RVA = "0x37DD60", Offset = "0x37CB60", VA = "0x1037DD60")]
    public static void Deserialize(
      ref ParamDictionary<string, PointQuestEventRewardParam> ref_params,
      JSON_PointQuestEventRewardParam[] jsons)
    {
    }

    [Token(Token = "0x600737D")]
    [Address(RVA = "0x37DFE0", Offset = "0x37CDE0", VA = "0x1037DFE0")]
    public static PointQuestEventRewardParam GetPointQuestEventRewardParam(string id)
    {
      return (PointQuestEventRewardParam) null;
    }

    [Token(Token = "0x600737E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestEventRewardParam()
    {
    }
  }
}
