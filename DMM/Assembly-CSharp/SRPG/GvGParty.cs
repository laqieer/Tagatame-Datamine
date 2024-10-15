// Decompiled with JetBrains decompiler
// Type: SRPG.GvGParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025B9")]
  public class GvGParty
  {
    [Token(Token = "0x400AF23")]
    [FieldOffset(Offset = "0x20")]
    private List<AdventureDataBase> mAdvDataBaseList;
    [Token(Token = "0x400AF24")]
    [FieldOffset(Offset = "0x24")]
    private List<BondData> mBondDatas;

    [Token(Token = "0x17001779")]
    public int Id
    {
      [Token(Token = "0x600A775"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A776"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x1700177A")]
    public int WinNum
    {
      [Token(Token = "0x600A777"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A778"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700177B")]
    public int BeatNum
    {
      [Token(Token = "0x600A779"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A77A"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x1700177C")]
    public GuildMemberData.eRole RoleId
    {
      [Token(Token = "0x600A77B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new GuildMemberData.eRole();
      }
      [Token(Token = "0x600A77C"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x1700177D")]
    public string PlayerName
    {
      [Token(Token = "0x600A77D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600A77E"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x1700177E")]
    public List<GvGPartyUnit> Units
    {
      [Token(Token = "0x600A77F"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<GvGPartyUnit>) null;
      }
      [Token(Token = "0x600A780"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x1700177F")]
    public List<AdventureDataBase> AdvDataBaseList
    {
      [Token(Token = "0x600A781"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<AdventureDataBase>) null;
      }
    }

    [Token(Token = "0x17001780")]
    public List<BondData> BondDatas
    {
      [Token(Token = "0x600A782"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<BondData>) null;
      }
    }

    [Token(Token = "0x600A783")]
    [Address(RVA = "0x6C1C50", Offset = "0x6C0A50", VA = "0x106C1C50")]
    public bool Deserialize(JSON_GvGParty json) => new bool();

    [Token(Token = "0x600A784")]
    [Address(RVA = "0x6C20D0", Offset = "0x6C0ED0", VA = "0x106C20D0")]
    public GvGParty()
    {
    }
  }
}
