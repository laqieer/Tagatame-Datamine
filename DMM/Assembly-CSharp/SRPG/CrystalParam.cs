// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A8C")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalParam
  {
    [Token(Token = "0x4006244")]
    private const string CRYSTAL_FLAVOR_PREFIX = "_FLAVOR";
    [Token(Token = "0x4006245")]
    private const string CRYSTAL_FILTER_KEYWORD_PREFIX = "_FILTER_KEYWORD";

    [Token(Token = "0x17000C08")]
    public string Iname
    {
      [Token(Token = "0x6006D22"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D23"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C09")]
    public string Name
    {
      [Token(Token = "0x6006D24"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D25"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C0A")]
    public string Expr
    {
      [Token(Token = "0x6006D26"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D27"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C0B")]
    public string Icon
    {
      [Token(Token = "0x6006D28"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D29"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000C0C")]
    public string[] EquipSkillInames
    {
      [Token(Token = "0x6006D2A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6006D2B"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17000C0D")]
    public string[] AddLimits
    {
      [Token(Token = "0x6006D2C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6006D2D"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17000C0E")]
    public string SaleIname
    {
      [Token(Token = "0x6006D2E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D2F"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x17000C0F")]
    public GalleryVisibilityType GalleryView
    {
      [Token(Token = "0x6006D30"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new GalleryVisibilityType();
      }
      [Token(Token = "0x6006D31"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17000C10")]
    [IgnoreMember]
    public string Flavor
    {
      [Token(Token = "0x6006D32"), Address(RVA = "0x3585D0", Offset = "0x3573D0", VA = "0x103585D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C11")]
    [IgnoreMember]
    public string FilterKeyword
    {
      [Token(Token = "0x6006D33"), Address(RVA = "0x358570", Offset = "0x357370", VA = "0x10358570")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006D34")]
    [Address(RVA = "0x358140", Offset = "0x356F40", VA = "0x10358140")]
    public bool Deserialize(JSON_CrystalParam json) => new bool();

    [Token(Token = "0x6006D35")]
    [Address(RVA = "0x357F90", Offset = "0x356D90", VA = "0x10357F90")]
    public static void Deserialize(
      ref List<CrystalParam> param,
      ref Dictionary<string, CrystalParam> dictionary,
      JSON_CrystalParam[] json)
    {
    }

    [Token(Token = "0x6006D36")]
    [Address(RVA = "0x3584D0", Offset = "0x3572D0", VA = "0x103584D0")]
    public string GetText(string table, string key) => (string) null;

    [Token(Token = "0x6006D37")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalParam()
    {
    }
  }
}
