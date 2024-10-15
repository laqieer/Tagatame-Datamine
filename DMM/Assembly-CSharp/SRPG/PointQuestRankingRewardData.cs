// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRankingRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C12")]
  public class PointQuestRankingRewardData
  {
    [Token(Token = "0x4006CC4")]
    [FieldOffset(Offset = "0x8")]
    private int mRanking;
    [Token(Token = "0x4006CC5")]
    [FieldOffset(Offset = "0xC")]
    private string mReward;

    [Token(Token = "0x17000E7A")]
    public int Ranking
    {
      [Token(Token = "0x60073A5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E7B")]
    public string Reward
    {
      [Token(Token = "0x60073A6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60073A7")]
    [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
    public void Deserialize(JSON_PointQuestRankingRewardData json)
    {
    }

    [Token(Token = "0x60073A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestRankingRewardData()
    {
    }
  }
}
