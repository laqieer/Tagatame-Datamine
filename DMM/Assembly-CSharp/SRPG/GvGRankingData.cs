// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025BC")]
  public class GvGRankingData
  {
    [Token(Token = "0x400AF28")]
    [FieldOffset(Offset = "0x8")]
    private GvGRankingGuildData mSelf;
    [Token(Token = "0x400AF29")]
    [FieldOffset(Offset = "0xC")]
    private List<GvGRankingGuildData> mGuilds;
    [Token(Token = "0x400AF2A")]
    [FieldOffset(Offset = "0x10")]
    private List<GvGScoreRankingData> mBeats;
    [Token(Token = "0x400AF2B")]
    [FieldOffset(Offset = "0x14")]
    private List<GvGScoreRankingData> mDefenses;

    [Token(Token = "0x17001784")]
    public GvGRankingGuildData Self
    {
      [Token(Token = "0x600A790"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (GvGRankingGuildData) null;
      }
    }

    [Token(Token = "0x17001785")]
    public List<GvGRankingGuildData> Guilds
    {
      [Token(Token = "0x600A791"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GvGRankingGuildData>) null;
      }
    }

    [Token(Token = "0x17001786")]
    public List<GvGScoreRankingData> Beats
    {
      [Token(Token = "0x600A792"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<GvGScoreRankingData>) null;
      }
    }

    [Token(Token = "0x17001787")]
    public List<GvGScoreRankingData> Defenses
    {
      [Token(Token = "0x600A793"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<GvGScoreRankingData>) null;
      }
    }

    [Token(Token = "0x600A794")]
    [Address(RVA = "0x6C2360", Offset = "0x6C1160", VA = "0x106C2360")]
    public void Deserialize(JSON_GvGRankingData[] guilds)
    {
    }

    [Token(Token = "0x600A795")]
    [Address(RVA = "0x6C2470", Offset = "0x6C1270", VA = "0x106C2470")]
    public void Deserialize(JSON_GvGScoreRanking[] data, bool IsBeat)
    {
    }

    [Token(Token = "0x600A796")]
    [Address(RVA = "0x6C25A0", Offset = "0x6C13A0", VA = "0x106C25A0")]
    public GvGRankingData()
    {
    }
  }
}
