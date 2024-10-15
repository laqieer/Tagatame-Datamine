// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPresetPartyUnits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025CA")]
  public class GvGPresetPartyUnits
  {
    [Token(Token = "0x1700179E")]
    public int PartyNo
    {
      [Token(Token = "0x600A7DF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7E0"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x1700179F")]
    public long[] Units
    {
      [Token(Token = "0x600A7E1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600A7E2"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x170017A0")]
    public string Name
    {
      [Token(Token = "0x600A7E3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600A7E4"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x600A7E5")]
    [Address(RVA = "0x6C2270", Offset = "0x6C1070", VA = "0x106C2270")]
    public bool Deserialize(JSON_GvGPresetPartyUnits json) => new bool();

    [Token(Token = "0x600A7E6")]
    [Address(RVA = "0x6C22C0", Offset = "0x6C10C0", VA = "0x106C22C0")]
    public bool OverWriteUnits(long[] units) => new bool();

    [Token(Token = "0x600A7E7")]
    [Address(RVA = "0x6C2180", Offset = "0x6C0F80", VA = "0x106C2180")]
    public bool Deserialize(PartyEditData data, int no) => new bool();

    [Token(Token = "0x600A7E8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGPresetPartyUnits()
    {
    }
  }
}
