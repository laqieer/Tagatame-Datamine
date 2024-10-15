// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalEquipSelectWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200332E")]
  public class CrystalEquipSelectWindowModel
  {
    [Token(Token = "0x17001E0B")]
    public bool IsSelect
    {
      [Token(Token = "0x600E202"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E203"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17001E0C")]
    public string CrystalName
    {
      [Token(Token = "0x600E204"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E205"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001E0D")]
    public string ParamText
    {
      [Token(Token = "0x600E206"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E207"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001E0E")]
    public bool IsSub
    {
      [Token(Token = "0x600E208"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E209"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x17001E0F")]
    public string SubText
    {
      [Token(Token = "0x600E20A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E20B"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x600E20C")]
    [Address(RVA = "0xAADB60", Offset = "0xAAC960", VA = "0x10AADB60")]
    public void SetData(CrystalData _crystal_data, UnitData _unit_data, bool _is_sub)
    {
    }

    [Token(Token = "0x600E20D")]
    [Address(RVA = "0xAADCB0", Offset = "0xAACAB0", VA = "0x10AADCB0")]
    private void SetSubText(CrystalData _data, UnitData _unit_data)
    {
    }

    [Token(Token = "0x600E20E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalEquipSelectWindowModel()
    {
    }
  }
}
