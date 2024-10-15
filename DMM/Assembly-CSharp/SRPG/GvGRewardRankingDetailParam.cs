// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRewardRankingDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B8E")]
  public class GvGRewardRankingDetailParam
  {
    [Token(Token = "0x17000DCD")]
    public int Ranking
    {
      [Token(Token = "0x60071F0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60071F1"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000DCE")]
    public string RewardId
    {
      [Token(Token = "0x60071F2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071F3"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60071F4")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_GvGRewardRankingDetailParam json) => new bool();

    [Token(Token = "0x60071F5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGRewardRankingDetailParam()
    {
    }
  }
}
