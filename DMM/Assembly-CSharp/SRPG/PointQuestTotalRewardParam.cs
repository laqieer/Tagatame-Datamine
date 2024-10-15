// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestTotalRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C17")]
  public class PointQuestTotalRewardParam
  {
    [Token(Token = "0x4006CCE")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006CCF")]
    [FieldOffset(Offset = "0xC")]
    private List<PointQuestTotalRewardData> mRewards;

    [Token(Token = "0x17000E80")]
    public string Iname
    {
      [Token(Token = "0x60073B6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E81")]
    public List<PointQuestTotalRewardData> Rewards
    {
      [Token(Token = "0x60073B7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<PointQuestTotalRewardData>) null;
      }
    }

    [Token(Token = "0x60073B8")]
    [Address(RVA = "0x37F2B0", Offset = "0x37E0B0", VA = "0x1037F2B0")]
    public void Deserialize(JSON_PointQuestTotalRewardParam json)
    {
    }

    [Token(Token = "0x60073B9")]
    [Address(RVA = "0x37F400", Offset = "0x37E200", VA = "0x1037F400")]
    public static void Deserialize(
      ref ParamDictionary<string, PointQuestTotalRewardParam> ref_params,
      JSON_PointQuestTotalRewardParam[] jsons)
    {
    }

    [Token(Token = "0x60073BA")]
    [Address(RVA = "0x37F760", Offset = "0x37E560", VA = "0x1037F760")]
    public static PointQuestTotalRewardParam GetPointQuestTotalRewardParam(string id)
    {
      return (PointQuestTotalRewardParam) null;
    }

    [Token(Token = "0x60073BB")]
    [Address(RVA = "0x37F670", Offset = "0x37E470", VA = "0x1037F670")]
    public PointQuestEventRewardParam GetPointQuestRewardParam(int point)
    {
      return (PointQuestEventRewardParam) null;
    }

    [Token(Token = "0x60073BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestTotalRewardParam()
    {
    }
  }
}
