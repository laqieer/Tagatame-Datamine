// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ABF")]
  public class DuelRankingReward
  {
    [Token(Token = "0x4006323")]
    [FieldOffset(Offset = "0x8")]
    private int mRanking;
    [Token(Token = "0x4006324")]
    [FieldOffset(Offset = "0xC")]
    private string mReward;
    [Token(Token = "0x4006325")]
    [FieldOffset(Offset = "0x10")]
    private int mMin;
    [Token(Token = "0x4006326")]
    [FieldOffset(Offset = "0x14")]
    private int mMax;

    [Token(Token = "0x17000C65")]
    public int Ranking
    {
      [Token(Token = "0x6006E39"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C66")]
    public string Reward
    {
      [Token(Token = "0x6006E3A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C67")]
    public int Min
    {
      [Token(Token = "0x6006E3B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C68")]
    public int Max
    {
      [Token(Token = "0x6006E3C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E3D")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_DuelRankingReward json) => new bool();

    [Token(Token = "0x6006E3E")]
    [Address(RVA = "0x35FB90", Offset = "0x35E990", VA = "0x1035FB90")]
    public void SetRank(int min, int max)
    {
    }

    [Token(Token = "0x6006E3F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelRankingReward()
    {
    }
  }
}
