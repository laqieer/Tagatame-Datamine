// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRankingGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025BD")]
  public class GvGRankingGuildData : ViewGuildData
  {
    [Token(Token = "0x400AF2C")]
    [FieldOffset(Offset = "0x30")]
    public int mRank;
    [Token(Token = "0x400AF2D")]
    [FieldOffset(Offset = "0x34")]
    public int mPoint;

    [Token(Token = "0x17001788")]
    public int Rank
    {
      [Token(Token = "0x600A797"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001789")]
    public int Point
    {
      [Token(Token = "0x600A798"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A799")]
    [Address(RVA = "0x6C2680", Offset = "0x6C1480", VA = "0x106C2680")]
    public void Deserialize(JSON_GvGRankingData json)
    {
    }

    [Token(Token = "0x600A79A")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public GvGRankingGuildData()
    {
    }
  }
}
