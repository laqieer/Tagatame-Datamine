// Decompiled with JetBrains decompiler
// Type: SRPG.GvGScoreRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025BF")]
  public class GvGScoreRankingData
  {
    [Token(Token = "0x1700178D")]
    public int Rank
    {
      [Token(Token = "0x600A7A3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7A4"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x1700178E")]
    public int Score
    {
      [Token(Token = "0x600A7A5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7A6"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700178F")]
    public string Name
    {
      [Token(Token = "0x600A7A7"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600A7A8"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001790")]
    public int Level
    {
      [Token(Token = "0x600A7A9"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7AA"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17001791")]
    public UnitData Unit
    {
      [Token(Token = "0x600A7AB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x600A7AC"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001792")]
    public int Role
    {
      [Token(Token = "0x600A7AD"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7AE"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x17001793")]
    public ViewGuildData Guild
    {
      [Token(Token = "0x600A7AF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ViewGuildData) null;
      }
      [Token(Token = "0x600A7B0"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x600A7B1")]
    [Address(RVA = "0x6C2760", Offset = "0x6C1560", VA = "0x106C2760")]
    public bool Deserialize(JSON_GvGScoreRanking json) => new bool();

    [Token(Token = "0x600A7B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGScoreRankingData()
    {
    }
  }
}
