// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalListItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200331D")]
  public class CrystalListItemModel
  {
    [Token(Token = "0x400F135")]
    [FieldOffset(Offset = "0x48")]
    private CrystalScrollList mScrollList;
    [Token(Token = "0x400F136")]
    [FieldOffset(Offset = "0x4C")]
    private CrystalListItemParam mListItemParam;
    [Token(Token = "0x400F137")]
    [FieldOffset(Offset = "0x50")]
    private CrystalData mData;
    [Token(Token = "0x400F138")]
    [FieldOffset(Offset = "0x54")]
    private CrystalParam mParam;
    [Token(Token = "0x400F139")]
    [FieldOffset(Offset = "0x58")]
    private CrystalListItemModel.DispFlag mDispObj;
    [Token(Token = "0x400F13A")]
    [FieldOffset(Offset = "0x5C")]
    private UnitData mUnitData;
    [Token(Token = "0x400F13B")]
    [FieldOffset(Offset = "0x60")]
    private int mNowDispObj;
    [Token(Token = "0x400F13C")]
    [FieldOffset(Offset = "0x64")]
    private int mMaxCount;
    [Token(Token = "0x400F13D")]
    [FieldOffset(Offset = "0x68")]
    private int mNowSupportDispCount;
    [Token(Token = "0x400F13E")]
    [FieldOffset(Offset = "0x6C")]
    private int mMaxSupportDispCount;
    [Token(Token = "0x400F13F")]
    [FieldOffset(Offset = "0x70")]
    private int mHaveAmount;

    [Token(Token = "0x17001DB6")]
    public Sprite EquipUnitSprite
    {
      [Token(Token = "0x600E13C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600E13D"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001DB7")]
    public Sprite ArenaEquipUnitSprite
    {
      [Token(Token = "0x600E13E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600E13F"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001DB8")]
    public Sprite SupportEquipUnitSprite
    {
      [Token(Token = "0x600E140"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600E141"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DB9")]
    public Sprite GvGEquipUnitSprite
    {
      [Token(Token = "0x600E142"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600E143"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17001DBA")]
    public Sprite LeaguematchEquipUnitSprite
    {
      [Token(Token = "0x600E144"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600E145"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001DBB")]
    public bool IsEquipIcon
    {
      [Token(Token = "0x600E146"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E147"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x17001DBC")]
    public bool IsListEquipIcon
    {
      [Token(Token = "0x600E148"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E149"), Address(RVA = "0x5EDEC0", Offset = "0x5ECCC0", VA = "0x105EDEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DBD")]
    public bool IsSupportIcon
    {
      [Token(Token = "0x600E14A"), Address(RVA = "0x2AA810", Offset = "0x2A9610", VA = "0x102AA810")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E14B"), Address(RVA = "0x2AA830", Offset = "0x2A9630", VA = "0x102AA830")] private set
      {
      }
    }

    [Token(Token = "0x17001DBE")]
    public bool IsArenaIcon
    {
      [Token(Token = "0x600E14C"), Address(RVA = "0xAAFAA0", Offset = "0xAAE8A0", VA = "0x10AAFAA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E14D"), Address(RVA = "0xAAFAE0", Offset = "0xAAE8E0", VA = "0x10AAFAE0")] private set
      {
      }
    }

    [Token(Token = "0x17001DBF")]
    public bool IsGvGEquipIcon
    {
      [Token(Token = "0x600E14E"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E14F"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] private set
      {
      }
    }

    [Token(Token = "0x17001DC0")]
    public bool IsLeaguematchEquipIcon
    {
      [Token(Token = "0x600E150"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E151"), Address(RVA = "0x305F40", Offset = "0x304D40", VA = "0x10305F40")] private set
      {
      }
    }

    [Token(Token = "0x17001DC1")]
    public int RankNum
    {
      [Token(Token = "0x600E152"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600E153"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17001DC2")]
    public bool IsSortRankObj
    {
      [Token(Token = "0x600E154"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E155"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
      {
      }
    }

    [Token(Token = "0x17001DC3")]
    public bool IsSortTextObj
    {
      [Token(Token = "0x600E156"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E157"), Address(RVA = "0xAAFB60", Offset = "0xAAE960", VA = "0x10AAFB60")] private set
      {
      }
    }

    [Token(Token = "0x17001DC4")]
    public string SortText
    {
      [Token(Token = "0x600E158"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E159"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] private set
      {
      }
    }

    [Token(Token = "0x17001DC5")]
    public bool IsMaskDisp
    {
      [Token(Token = "0x600E15A"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E15B"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] private set
      {
      }
    }

    [Token(Token = "0x17001DC6")]
    public bool IsSelect
    {
      [Token(Token = "0x600E15C"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E15D"), Address(RVA = "0x9728A0", Offset = "0x9716A0", VA = "0x109728A0")] private set
      {
      }
    }

    [Token(Token = "0x17001DC7")]
    public bool IsRecommend
    {
      [Token(Token = "0x600E15E"), Address(RVA = "0x972890", Offset = "0x971690", VA = "0x10972890")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E15F"), Address(RVA = "0x9728B0", Offset = "0x9716B0", VA = "0x109728B0")] private set
      {
      }
    }

    [Token(Token = "0x17001DC8")]
    public bool IsRemoveEquip
    {
      [Token(Token = "0x600E160"), Address(RVA = "0xAAD900", Offset = "0xAAC700", VA = "0x10AAD900")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E161"), Address(RVA = "0xAAFB40", Offset = "0xAAE940", VA = "0x10AAFB40")] private set
      {
      }
    }

    [Token(Token = "0x17001DC9")]
    public bool IsFavorite
    {
      [Token(Token = "0x600E162"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E163"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] private set
      {
      }
    }

    [Token(Token = "0x17001DCA")]
    public bool IsUsedMask
    {
      [Token(Token = "0x600E164"), Address(RVA = "0x8E4B70", Offset = "0x8E3970", VA = "0x108E4B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E165"), Address(RVA = "0xAAFB70", Offset = "0xAAE970", VA = "0x10AAFB70")] private set
      {
      }
    }

    [Token(Token = "0x17001DCB")]
    public bool IsLeagueMatchUsed
    {
      [Token(Token = "0x600E166"), Address(RVA = "0xAAD910", Offset = "0xAAC710", VA = "0x10AAD910")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E167"), Address(RVA = "0xAAFB20", Offset = "0xAAE920", VA = "0x10AAFB20")] private set
      {
      }
    }

    [Token(Token = "0x17001DCC")]
    public bool IsBattleUsedMask
    {
      [Token(Token = "0x600E168"), Address(RVA = "0x761750", Offset = "0x760550", VA = "0x10761750")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E169"), Address(RVA = "0xAAFAF0", Offset = "0xAAE8F0", VA = "0x10AAFAF0")] private set
      {
      }
    }

    [Token(Token = "0x17001DCD")]
    public bool IsSameInameMask
    {
      [Token(Token = "0x600E16A"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E16B"), Address(RVA = "0xAAFB50", Offset = "0xAAE950", VA = "0x10AAFB50")] private set
      {
      }
    }

    [Token(Token = "0x17001DCE")]
    public string CrystalName
    {
      [Token(Token = "0x600E16C"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E16D"), Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")] private set
      {
      }
    }

    [Token(Token = "0x17001DCF")]
    public bool IsFixedDispRank
    {
      [Token(Token = "0x600E16E"), Address(RVA = "0x288080", Offset = "0x286E80", VA = "0x10288080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E16F"), Address(RVA = "0x2883C0", Offset = "0x2871C0", VA = "0x102883C0")] private set
      {
      }
    }

    [Token(Token = "0x17001DD0")]
    public bool IsFiexdDispName
    {
      [Token(Token = "0x600E170"), Address(RVA = "0xAAFAC0", Offset = "0xAAE8C0", VA = "0x10AAFAC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E171"), Address(RVA = "0xAAFB10", Offset = "0xAAE910", VA = "0x10AAFB10")] private set
      {
      }
    }

    [Token(Token = "0x17001DD1")]
    public bool IsSaleSelect
    {
      [Token(Token = "0x600E172"), Address(RVA = "0x512B30", Offset = "0x511930", VA = "0x10512B30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E173"), Address(RVA = "0x512B40", Offset = "0x511940", VA = "0x10512B40")] private set
      {
      }
    }

    [Token(Token = "0x17001DD2")]
    public bool IsBeforeUsed
    {
      [Token(Token = "0x600E174"), Address(RVA = "0xAAFAB0", Offset = "0xAAE8B0", VA = "0x10AAFAB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E175"), Address(RVA = "0xAAFB00", Offset = "0xAAE900", VA = "0x10AAFB00")] private set
      {
      }
    }

    [Token(Token = "0x17001DD3")]
    public bool IsOrganization
    {
      [Token(Token = "0x600E176"), Address(RVA = "0xAAFAD0", Offset = "0xAAE8D0", VA = "0x10AAFAD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E177"), Address(RVA = "0xAAFB30", Offset = "0xAAE930", VA = "0x10AAFB30")] private set
      {
      }
    }

    [Token(Token = "0x600E178")]
    [Address(RVA = "0xAAEEF0", Offset = "0xAADCF0", VA = "0x10AAEEF0")]
    public void SetData(
      CrystalListItemParam _param,
      CrystalScrollList _scroll_list,
      UnitData _unit_data,
      bool _fixed_disp_rank,
      bool _fixed_disp_name)
    {
    }

    [Token(Token = "0x600E179")]
    [Address(RVA = "0xAAF5E0", Offset = "0xAAE3E0", VA = "0x10AAF5E0")]
    public void SetRemoveEquip(CrystalScrollList _scroll_list)
    {
    }

    [Token(Token = "0x600E17A")]
    [Address(RVA = "0xAAF620", Offset = "0xAAE420", VA = "0x10AAF620")]
    private void SetSortParamDisp()
    {
    }

    [Token(Token = "0x600E17B")]
    [Address(RVA = "0xAAEB60", Offset = "0xAAD960", VA = "0x10AAEB60")]
    private void ScrollDispParamSet()
    {
    }

    [Token(Token = "0x600E17C")]
    [Address(RVA = "0xAAF2E0", Offset = "0xAAE0E0", VA = "0x10AAF2E0")]
    private void SetEquipIcon()
    {
    }

    [Token(Token = "0x600E17D")]
    [Address(RVA = "0xAAE6B0", Offset = "0xAAD4B0", VA = "0x10AAE6B0")]
    public void ChangeEquipIcon(bool _is_first)
    {
    }

    [Token(Token = "0x600E17E")]
    [Address(RVA = "0xAAEA80", Offset = "0xAAD880", VA = "0x10AAEA80")]
    public bool IsEquipList() => new bool();

    [Token(Token = "0x600E17F")]
    [Address(RVA = "0xAAEA00", Offset = "0xAAD800", VA = "0x10AAEA00")]
    public bool IsAllList() => new bool();

    [Token(Token = "0x600E180")]
    [Address(RVA = "0xAAEAF0", Offset = "0xAAD8F0", VA = "0x10AAEAF0")]
    public bool IsGradeupList() => new bool();

    [Token(Token = "0x600E181")]
    [Address(RVA = "0xAAE9E0", Offset = "0xAAD7E0", VA = "0x10AAE9E0")]
    public CrystalListItemModel.EquipSlotImageIndex GetSlotImageIndex()
    {
      return new CrystalListItemModel.EquipSlotImageIndex();
    }

    [Token(Token = "0x600E182")]
    [Address(RVA = "0xAAE820", Offset = "0xAAD620", VA = "0x10AAE820")]
    public int GetHaveAmount() => new int();

    [Token(Token = "0x600E183")]
    [Address(RVA = "0xAAFA80", Offset = "0xAAE880", VA = "0x10AAFA80")]
    public CrystalListItemModel()
    {
    }

    [Token(Token = "0x200331E")]
    [Flags]
    private enum DispFlag
    {
      [Token(Token = "0x400F141")] None = 0,
      [Token(Token = "0x400F142")] Equip = 1,
      [Token(Token = "0x400F143")] Arena = 2,
      [Token(Token = "0x400F144")] Support = 4,
      [Token(Token = "0x400F145")] GvG = 8,
      [Token(Token = "0x400F146")] Leaguematch = 16, // 0x00000010
    }

    [Token(Token = "0x200331F")]
    public enum EquipSlotImageIndex
    {
      [Token(Token = "0x400F148")] Main,
      [Token(Token = "0x400F149")] Sub,
    }
  }
}
