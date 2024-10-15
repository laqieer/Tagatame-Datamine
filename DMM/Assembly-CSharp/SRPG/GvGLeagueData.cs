// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025C2")]
  public class GvGLeagueData
  {
    [Token(Token = "0x17001798")]
    public string Id
    {
      [Token(Token = "0x600A7BE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600A7BF"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x17001799")]
    public int Rate
    {
      [Token(Token = "0x600A7C0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7C1"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
      {
      }
    }

    [Token(Token = "0x1700179A")]
    public int Rank
    {
      [Token(Token = "0x600A7C2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7C3"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] set
      {
      }
    }

    [Token(Token = "0x600A7C4")]
    [Address(RVA = "0x6B5420", Offset = "0x6B4220", VA = "0x106B5420")]
    public bool Deserialize(JSON_GvGLeagueData json) => new bool();

    [Token(Token = "0x600A7C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGLeagueData()
    {
    }
  }
}
