// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200332C")]
  public class CrystalWindowModel
  {
    [Token(Token = "0x17001DFF")]
    public bool IsSaleEnable
    {
      [Token(Token = "0x600E1E3"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1E4"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17001E00")]
    public int HaveCountMax
    {
      [Token(Token = "0x600E1E5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1E6"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17001E01")]
    public int SaleSelectCountMax
    {
      [Token(Token = "0x600E1E7"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1E8"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001E02")]
    public bool IsBulkGradeUpEnable
    {
      [Token(Token = "0x600E1E9"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1EA"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x17001E03")]
    public int HaveCount
    {
      [Token(Token = "0x600E1EB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1EC"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17001E04")]
    public int SaleSelectCount
    {
      [Token(Token = "0x600E1ED"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1EE"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x17001E05")]
    public int SaleGold
    {
      [Token(Token = "0x600E1EF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1F0"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
      {
      }
    }

    [Token(Token = "0x17001E06")]
    public int SaleCoin
    {
      [Token(Token = "0x600E1F1"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1F2"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17001E07")]
    public bool IsUnequipAllEnable
    {
      [Token(Token = "0x600E1F3"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E1F4"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
      {
      }
    }

    [Token(Token = "0x600E1F5")]
    [Address(RVA = "0xAB0FD0", Offset = "0xAAFDD0", VA = "0x10AB0FD0")]
    public void Initialize(
      bool is_sale_enable,
      bool is_bulkgradeup,
      int sale_cout_max,
      bool is_release_all)
    {
    }

    [Token(Token = "0x600E1F6")]
    [Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")]
    public void SetBulkGradeUpInfo(bool is_bulkgradeup)
    {
    }

    [Token(Token = "0x600E1F7")]
    [Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")]
    public void SetUnequipAllInfo(bool is_enable)
    {
    }

    [Token(Token = "0x600E1F8")]
    [Address(RVA = "0xAB10E0", Offset = "0xAAFEE0", VA = "0x10AB10E0")]
    public void SetHaveCountInfo(bool max_update = false)
    {
    }

    [Token(Token = "0x600E1F9")]
    [Address(RVA = "0xAB11D0", Offset = "0xAAFFD0", VA = "0x10AB11D0")]
    public void SetSaleInfo(int sale_count, int sale_gold, int sale_coin)
    {
    }

    [Token(Token = "0x600E1FA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalWindowModel()
    {
    }
  }
}
