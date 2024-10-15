// Decompiled with JetBrains decompiler
// Type: SRPG.Models.GalleryCrystalListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003329")]
  public class GalleryCrystalListModel
  {
    [Token(Token = "0x17001DE4")]
    public List<GalleryCrystalListItem> ListItems
    {
      [Token(Token = "0x600E1B0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<GalleryCrystalListItem>) null;
      }
      [Token(Token = "0x600E1B1"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001DE5")]
    public List<CrystalParam> CrystalParams
    {
      [Token(Token = "0x600E1B2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<CrystalParam>) null;
      }
      [Token(Token = "0x600E1B3"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001DE6")]
    public int CurrentPage
    {
      [Token(Token = "0x600E1B4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1B5"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DE7")]
    public int MaxPage
    {
      [Token(Token = "0x600E1B6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600E1B7"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17001DE8")]
    public string[] GalleyItems
    {
      [Token(Token = "0x600E1B8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x600E1B9"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x600E1BA")]
    [Address(RVA = "0xAB1860", Offset = "0xAB0660", VA = "0x10AB1860")]
    public bool IsGalleyItemEnable(string crystal_iname) => new bool();

    [Token(Token = "0x600E1BB")]
    [Address(RVA = "0xAB1810", Offset = "0xAB0610", VA = "0x10AB1810")]
    public void Initialize(
      List<GalleryCrystalListItem> list_items,
      List<CrystalParam> crystals,
      string[] galley_items,
      int current_page,
      int max_page)
    {
    }

    [Token(Token = "0x600E1BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GalleryCrystalListModel()
    {
    }
  }
}
