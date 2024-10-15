// Decompiled with JetBrains decompiler
// Type: SRPG.MultiSupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001948")]
  public class MultiSupportData
  {
    [Token(Token = "0x4005BBC")]
    [FieldOffset(Offset = "0x28")]
    private List<AdventureDataBase> mAdvDataBaseList;
    [Token(Token = "0x4005BBD")]
    [FieldOffset(Offset = "0x2C")]
    private List<BondData> mBondDatas;

    [Token(Token = "0x17000A58")]
    public string UID
    {
      [Token(Token = "0x60066B5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60066B6"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000A59")]
    public string FUID
    {
      [Token(Token = "0x60066B7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60066B8"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000A5A")]
    public string Name
    {
      [Token(Token = "0x60066B9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60066BA"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000A5B")]
    public int Lv
    {
      [Token(Token = "0x60066BB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x60066BC"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000A5C")]
    public List<UnitData> Units
    {
      [Token(Token = "0x60066BD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x60066BE"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17000A5D")]
    public ViewGuildData Guild
    {
      [Token(Token = "0x60066BF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (ViewGuildData) null;
      }
      [Token(Token = "0x60066C0"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17000A5E")]
    public bool IsFriend
    {
      [Token(Token = "0x60066C1"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
      [Token(Token = "0x60066C2"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] private set
      {
      }
    }

    [Token(Token = "0x17000A5F")]
    public int Cost
    {
      [Token(Token = "0x60066C3"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x60066C4"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17000A60")]
    public List<AdventureDataBase> AdvDataBaseList
    {
      [Token(Token = "0x60066C5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<AdventureDataBase>) null;
      }
    }

    [Token(Token = "0x17000A61")]
    public List<BondData> BondDatas
    {
      [Token(Token = "0x60066C6"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<BondData>) null;
      }
    }

    [Token(Token = "0x60066C7")]
    [Address(RVA = "0x3219E0", Offset = "0x3207E0", VA = "0x103219E0")]
    public bool Deserialize(JSON_MultiSupport json) => new bool();

    [Token(Token = "0x60066C8")]
    [Address(RVA = "0x321C80", Offset = "0x320A80", VA = "0x10321C80")]
    public MultiSupportData()
    {
    }
  }
}
