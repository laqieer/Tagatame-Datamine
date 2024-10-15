// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalSetBonusWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003335")]
  public class CrystalSetBonusWindowModel
  {
    [Token(Token = "0x400F1B4")]
    [FieldOffset(Offset = "0x8")]
    private CrystalSetBonusParam mCrystalSetBonusParam;
    [Token(Token = "0x400F1B5")]
    [FieldOffset(Offset = "0xC")]
    private HashSet<string> mNotHaveCrystalInames;

    [Token(Token = "0x17001E29")]
    public string SetBonusTitle
    {
      [Token(Token = "0x600E249"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E24A"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001E2A")]
    public string SetBonusExpr
    {
      [Token(Token = "0x600E24B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E24C"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17001E2B")]
    public UnitData TargetUnit
    {
      [Token(Token = "0x600E24D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x600E24E"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001E2C")]
    public CrystalParam MainCrystal
    {
      [Token(Token = "0x600E24F"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (CrystalParam) null;
      }
      [Token(Token = "0x600E250"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17001E2D")]
    public List<CrystalParam> SubCrystalList
    {
      [Token(Token = "0x600E251"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<CrystalParam>) null;
      }
      [Token(Token = "0x600E252"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x17001E2E")]
    public bool IsRateDisp
    {
      [Token(Token = "0x600E253"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E254"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] private set
      {
      }
    }

    [Token(Token = "0x17001E2F")]
    public string RateText
    {
      [Token(Token = "0x600E255"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E256"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x17001E30")]
    public bool IsGrayOut
    {
      [Token(Token = "0x600E257"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E258"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] private set
      {
      }
    }

    [Token(Token = "0x600E259")]
    [Address(RVA = "0xAB0560", Offset = "0xAAF360", VA = "0x10AB0560")]
    public void Initialize(CrystalSetBonusParam data, UnitData unit_data, bool is_gray_out = true)
    {
    }

    [Token(Token = "0x600E25A")]
    [Address(RVA = "0xAB0A00", Offset = "0xAAF800", VA = "0x10AB0A00")]
    public bool IsForceDispMask(string crystal_iname) => new bool();

    [Token(Token = "0x600E25B")]
    [Address(RVA = "0xAB0A50", Offset = "0xAAF850", VA = "0x10AB0A50")]
    private void SetForceDispMask(string crystal_iname, bool is_main_slot)
    {
    }

    [Token(Token = "0x600E25C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSetBonusWindowModel()
    {
    }
  }
}
