// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankNPCPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C99")]
  [Serializable]
  public class VersusRankNPCPartyParam
  {
    [Token(Token = "0x400706A")]
    [FieldOffset(Offset = "0x38")]
    private Json_Unit mLeaderUnit;
    [Token(Token = "0x400706B")]
    [FieldOffset(Offset = "0x3C")]
    private UnitData[] mUnits;

    [Token(Token = "0x17000F39")]
    public int Id
    {
      [Token(Token = "0x60075C8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60075C9"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000F3A")]
    public string Name
    {
      [Token(Token = "0x60075CA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60075CB"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000F3B")]
    public int Lv
    {
      [Token(Token = "0x60075CC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60075CD"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17000F3C")]
    public RankMatchClass RankMatchClass
    {
      [Token(Token = "0x60075CE"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new RankMatchClass();
      }
      [Token(Token = "0x60075CF"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000F3D")]
    public int ViewPoint
    {
      [Token(Token = "0x60075D0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x60075D1"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17000F3E")]
    public int PointMin
    {
      [Token(Token = "0x60075D2"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60075D3"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x17000F3F")]
    public int PointMax
    {
      [Token(Token = "0x60075D4"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x60075D5"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
      {
      }
    }

    [Token(Token = "0x17000F40")]
    public int Unit1Id
    {
      [Token(Token = "0x60075D6"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x60075D7"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17000F41")]
    public int Unit2Id
    {
      [Token(Token = "0x60075D8"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x60075D9"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] private set
      {
      }
    }

    [Token(Token = "0x17000F42")]
    public int Unit3Id
    {
      [Token(Token = "0x60075DA"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x60075DB"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] private set
      {
      }
    }

    [Token(Token = "0x17000F43")]
    public bool IsConceptCardLS
    {
      [Token(Token = "0x60075DC"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
      [Token(Token = "0x60075DD"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] private set
      {
      }
    }

    [Token(Token = "0x17000F44")]
    public string AwardId
    {
      [Token(Token = "0x60075DE"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60075DF"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
      {
      }
    }

    [Token(Token = "0x17000F45")]
    public Json_Unit LeaderUnit
    {
      [Token(Token = "0x60075E0"), Address(RVA = "0x3A0E40", Offset = "0x39FC40", VA = "0x103A0E40")] get
      {
        return (Json_Unit) null;
      }
    }

    [Token(Token = "0x17000F46")]
    public UnitData[] Units
    {
      [Token(Token = "0x60075E1"), Address(RVA = "0x3A0F20", Offset = "0x39FD20", VA = "0x103A0F20")] get
      {
        return (UnitData[]) null;
      }
    }

    [Token(Token = "0x60075E2")]
    [Address(RVA = "0x3A0C20", Offset = "0x39FA20", VA = "0x103A0C20")]
    public bool Deserialize(JSON_VersusRankNPCPartyParam json) => new bool();

    [Token(Token = "0x60075E3")]
    [Address(RVA = "0x3A0CA0", Offset = "0x39FAA0", VA = "0x103A0CA0")]
    public static void Deserialize(
      ref List<VersusRankNPCPartyParam> param,
      JSON_VersusRankNPCPartyParam[] json)
    {
    }

    [Token(Token = "0x60075E4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusRankNPCPartyParam()
    {
    }
  }
}
