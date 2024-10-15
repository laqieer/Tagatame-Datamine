// Decompiled with JetBrains decompiler
// Type: SRPG.FilterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EBF")]
  public class FilterUtility
  {
    [Token(Token = "0x4002D7C")]
    private const char PREFS_KEY_SEPARATOR = ':';
    [Token(Token = "0x4002D7D")]
    private const string RUNE_FILTER_ACTIVATE_TEXT = "Activate";
    [Token(Token = "0x4002D7E")]
    private const string RUNE_FILTER_ACTIVATE_SYS_TEXT = "sys.RUNE_FILTER_ACTIVATE_SYS_TEXT";

    [Token(Token = "0x6003D4A")]
    [Address(RVA = "0x10FE660", Offset = "0x10FD460", VA = "0x110FE660")]
    public static FilterUtility.FilterPrefs Load_UnitFilter() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x6003D4B")]
    [Address(RVA = "0x10FE940", Offset = "0x10FD740", VA = "0x110FE940")]
    public static bool MatchCondition(UnitParam unitParam, FilterUtility.FilterPrefs filter)
    {
      return new bool();
    }

    [Token(Token = "0x6003D4C")]
    [Address(RVA = "0x10FCC20", Offset = "0x10FBA20", VA = "0x110FCC20")]
    public static void FilterUnit(ref List<UnitParam> units, FilterUtility.FilterPrefs filter)
    {
    }

    [Token(Token = "0x6003D4D")]
    [Address(RVA = "0x10FD5B0", Offset = "0x10FC3B0", VA = "0x110FD5B0")]
    public static FilterUtility.FilterPrefs Load_ConceptCardFilter(string prefs_key)
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x6003D4E")]
    [Address(RVA = "0x10FD560", Offset = "0x10FC360", VA = "0x110FD560")]
    public static FilterUtility.FilterPrefs Load_ConceptCardFilter()
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x6003D4F")]
    [Address(RVA = "0x10FD510", Offset = "0x10FC310", VA = "0x110FD510")]
    public static FilterUtility.FilterPrefs Load_ConceptCardFilterExtraRarity()
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x6003D50")]
    [Address(RVA = "0x10FE120", Offset = "0x10FCF20", VA = "0x110FE120")]
    public static FilterUtility.FilterPrefs Load_RuneFilter() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x6003D51")]
    [Address(RVA = "0x10FEE70", Offset = "0x10FDC70", VA = "0x110FEE70")]
    public static bool RuneMatchCondition(BindRuneData runeData, FilterUtility.FilterPrefs filter)
    {
      return new bool();
    }

    [Token(Token = "0x6003D52")]
    [Address(RVA = "0x10FCB70", Offset = "0x10FB970", VA = "0x110FCB70")]
    public static void FilterRune(ref List<BindRuneData> runes, FilterUtility.FilterPrefs filter)
    {
    }

    [Token(Token = "0x6003D53")]
    [Address(RVA = "0x10FD880", Offset = "0x10FC680", VA = "0x110FD880")]
    public static FilterUtility.FilterPrefs Load_CrystalFilter()
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x6003D54")]
    [Address(RVA = "0x10FC360", Offset = "0x10FB160", VA = "0x110FC360")]
    public static bool CrystalMatchCondition(CrystalData crystal, FilterUtility.FilterPrefs filter)
    {
      return new bool();
    }

    [Token(Token = "0x6003D55")]
    [Address(RVA = "0x10FBF50", Offset = "0x10FAD50", VA = "0x110FBF50")]
    private static bool CheckCrystalStatus(
      CrystalData crystal,
      ParamTypes param_type,
      bool is_limit_add = false)
    {
      return new bool();
    }

    [Token(Token = "0x6003D56")]
    [Address(RVA = "0x10FCAA0", Offset = "0x10FB8A0", VA = "0x110FCAA0")]
    public static void FilterCrystal(
      ref List<CrystalData> crystals,
      FilterUtility.FilterPrefs filter)
    {
    }

    [Token(Token = "0x6003D57")]
    [Address(RVA = "0x10FDCD0", Offset = "0x10FCAD0", VA = "0x110FDCD0")]
    public static FilterUtility.FilterPrefs Load_CrystalReplaceFilter()
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x6003D58")]
    [Address(RVA = "0x10FC530", Offset = "0x10FB330", VA = "0x110FC530")]
    public static bool CrystalReplaceMatchCondition(
      List<CrystalData> crystals,
      FilterUtility.FilterPrefs filter,
      List<CrystalSetBonusParam> enable_set_bounus,
      List<CrystalSetBonusParam> all_set_bonus)
    {
      return new bool();
    }

    [Token(Token = "0x6003D59")]
    [Address(RVA = "0x10FD240", Offset = "0x10FC040", VA = "0x110FD240")]
    public static bool IsFilterCrystalReplace(
      List<CrystalData> crystals,
      FilterUtility.FilterPrefs filter)
    {
      return new bool();
    }

    [Token(Token = "0x6003D5A")]
    [Address(RVA = "0x10FCCF0", Offset = "0x10FBAF0", VA = "0x110FCCF0")]
    private static bool IsCrystalMatchConditon(
      CrystalData crystal,
      CrystalFilterCondParam condition = null,
      CrystalReplaceFilterCondParam replace_condition = null)
    {
      return new bool();
    }

    [Token(Token = "0x6003D5B")]
    [Address(RVA = "0x10FCEE0", Offset = "0x10FBCE0", VA = "0x110FCEE0")]
    public static bool IsCrystalSetBonusMatchCondition(
      CrystalSetBonusParam target,
      CrystalSetBonusFilterCondParam condition = null,
      CrystalReplaceFilterCondParam replace_condition = null)
    {
      return new bool();
    }

    [Token(Token = "0x6003D5C")]
    [Address(RVA = "0x10FE420", Offset = "0x10FD220", VA = "0x110FE420")]
    public static FilterUtility.FilterPrefs Load_RuneReplaceFilter()
    {
      return (FilterUtility.FilterPrefs) null;
    }

    [Token(Token = "0x6003D5D")]
    [Address(RVA = "0x10FBC00", Offset = "0x10FAA00", VA = "0x110FBC00")]
    public static FilterRuneParam[] AddFilterRuneParams(FilterRuneParam[] filter_params)
    {
      return (FilterRuneParam[]) null;
    }

    [Token(Token = "0x6003D5E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterUtility()
    {
    }

    [Token(Token = "0x2000EC0")]
    [Serializable]
    public class JSON_FilterDataList
    {
      [Token(Token = "0x4002D7F")]
      [FieldOffset(Offset = "0x8")]
      public FilterUtility.JSON_FilterData[] list;

      [Token(Token = "0x6003D5F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_FilterDataList()
      {
      }
    }

    [Token(Token = "0x2000EC1")]
    [Serializable]
    public class JSON_FilterData
    {
      [Token(Token = "0x4002D80")]
      [FieldOffset(Offset = "0x8")]
      public string key;
      [Token(Token = "0x4002D81")]
      [FieldOffset(Offset = "0xC")]
      public int value;

      [Token(Token = "0x170004E7")]
      public bool Value
      {
        [Token(Token = "0x6003D60"), Address(RVA = "0x7C1EC0", Offset = "0x7C0CC0", VA = "0x107C1EC0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003D61"), Address(RVA = "0x2B00A0", Offset = "0x2AEEA0", VA = "0x102B00A0")] set
        {
        }
      }

      [Token(Token = "0x6003D62")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_FilterData()
      {
      }
    }

    [Token(Token = "0x2000EC2")]
    public class FilterPrefsData
    {
      [Token(Token = "0x4002D82")]
      [FieldOffset(Offset = "0x8")]
      private bool m_Value;
      [Token(Token = "0x4002D83")]
      [FieldOffset(Offset = "0xC")]
      private string m_MajorKey;
      [Token(Token = "0x4002D84")]
      [FieldOffset(Offset = "0x10")]
      private string m_MinorKey;

      [Token(Token = "0x170004E8")]
      public string Key
      {
        [Token(Token = "0x6003D63"), Address(RVA = "0x10FA9D0", Offset = "0x10F97D0", VA = "0x110FA9D0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170004E9")]
      public bool Value
      {
        [Token(Token = "0x6003D64"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003D65"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] set
        {
        }
      }

      [Token(Token = "0x170004EA")]
      public string MajorKey
      {
        [Token(Token = "0x6003D66"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6003D67"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
        {
        }
      }

      [Token(Token = "0x170004EB")]
      public string MinorKey
      {
        [Token(Token = "0x6003D68"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6003D69"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x6003D6A")]
      [Address(RVA = "0x10FA810", Offset = "0x10F9610", VA = "0x110FA810")]
      public bool Deserialize(FilterUtility.JSON_FilterData json) => new bool();

      [Token(Token = "0x6003D6B")]
      [Address(RVA = "0x10FA900", Offset = "0x10F9700", VA = "0x110FA900")]
      public void Serialize(ref FilterUtility.JSON_FilterData json)
      {
      }

      [Token(Token = "0x6003D6C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public FilterPrefsData()
      {
      }
    }

    [Token(Token = "0x2000EC3")]
    public class FilterPrefs
    {
      [Token(Token = "0x4002D85")]
      [FieldOffset(Offset = "0x8")]
      private string m_PrefsKey;
      [Token(Token = "0x4002D86")]
      [FieldOffset(Offset = "0xC")]
      private List<FilterUtility.FilterPrefsData> m_FilterPrefsDataList;

      [Token(Token = "0x170004EC")]
      public List<FilterUtility.FilterPrefsData> FilterPrefsDataList
      {
        [Token(Token = "0x6003D6D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (List<FilterUtility.FilterPrefsData>) null;
        }
      }

      [Token(Token = "0x6003D6E")]
      [Address(RVA = "0x10FB400", Offset = "0x10FA200", VA = "0x110FB400")]
      public static string MakeKey(string majorKey, string minorKey) => (string) null;

      [Token(Token = "0x6003D6F")]
      [Address(RVA = "0x10FBAC0", Offset = "0x10FA8C0", VA = "0x110FBAC0")]
      public void SetValue(string majorKey, string minorKey, bool value)
      {
      }

      [Token(Token = "0x6003D70")]
      [Address(RVA = "0x10FB960", Offset = "0x10FA760", VA = "0x110FB960")]
      public void SetValueAll(string majorKey, bool value)
      {
      }

      [Token(Token = "0x6003D71")]
      [Address(RVA = "0x10FBA10", Offset = "0x10FA810", VA = "0x110FBA10")]
      public void SetValueAll(bool value)
      {
      }

      [Token(Token = "0x6003D72")]
      [Address(RVA = "0x10FAC30", Offset = "0x10F9A30", VA = "0x110FAC30")]
      public bool GetValue(string majorKey, string minorKey, bool defaultValue = false)
      {
        return new bool();
      }

      [Token(Token = "0x6003D73")]
      [Address(RVA = "0x10FAF50", Offset = "0x10F9D50", VA = "0x110FAF50")]
      public bool IsEnableFilterAll(string majorKey) => new bool();

      [Token(Token = "0x6003D74")]
      [Address(RVA = "0x10FB010", Offset = "0x10F9E10", VA = "0x110FB010")]
      public bool IsEnableFilterAll() => new bool();

      [Token(Token = "0x6003D75")]
      [Address(RVA = "0x10FAE90", Offset = "0x10F9C90", VA = "0x110FAE90")]
      public bool IsDisableFilterAll(string majorKey) => new bool();

      [Token(Token = "0x6003D76")]
      [Address(RVA = "0x10FADA0", Offset = "0x10F9BA0", VA = "0x110FADA0")]
      public bool IsDisableFilterAll() => new bool();

      [Token(Token = "0x6003D77")]
      [Address(RVA = "0x10FB440", Offset = "0x10FA240", VA = "0x110FB440")]
      public void RemoveKeys(Predicate<FilterUtility.FilterPrefsData> predicate)
      {
      }

      [Token(Token = "0x6003D78")]
      [Address(RVA = "0x10FB100", Offset = "0x10F9F00", VA = "0x110FB100")]
      public bool IsEnableOverWritePartyByRuneFilter() => new bool();

      [Token(Token = "0x6003D79")]
      [Address(RVA = "0x10FAA20", Offset = "0x10F9820", VA = "0x110FAA20")]
      public void Deserialize(FilterUtility.JSON_FilterDataList json)
      {
      }

      [Token(Token = "0x6003D7A")]
      [Address(RVA = "0x10FB6E0", Offset = "0x10FA4E0", VA = "0x110FB6E0")]
      public void Serialize(ref FilterUtility.JSON_FilterDataList json)
      {
      }

      [Token(Token = "0x6003D7B")]
      [Address(RVA = "0x10FB510", Offset = "0x10FA310", VA = "0x110FB510")]
      public static void Save(FilterUtility.FilterPrefs filterPrefs, bool allOnIsAllOff)
      {
      }

      [Token(Token = "0x6003D7C")]
      [Address(RVA = "0x10FB490", Offset = "0x10FA290", VA = "0x110FB490")]
      public static void Save(FilterUtility.FilterPrefs filterPrefs)
      {
      }

      [Token(Token = "0x6003D7D")]
      [Address(RVA = "0x10FB2C0", Offset = "0x10FA0C0", VA = "0x110FB2C0")]
      public static FilterUtility.FilterPrefs Load(string prefsKey)
      {
        return (FilterUtility.FilterPrefs) null;
      }

      [Token(Token = "0x6003D7E")]
      [Address(RVA = "0x10FBB90", Offset = "0x10FA990", VA = "0x110FBB90")]
      public FilterPrefs()
      {
      }
    }

    [Token(Token = "0x2000ECB")]
    public class FilterBindData
    {
      [Token(Token = "0x4002D92")]
      [FieldOffset(Offset = "0x8")]
      public int Rarity;
      [Token(Token = "0x4002D93")]
      [FieldOffset(Offset = "0xC")]
      public string Name;
      [Token(Token = "0x4002D94")]
      [FieldOffset(Offset = "0x10")]
      public ArtifactTypes EquipType;
      [Token(Token = "0x4002D95")]
      [FieldOffset(Offset = "0x14")]
      public byte RuneSetEffectType;

      [Token(Token = "0x170004ED")]
      public int RuneSetEffectIconIndex
      {
        [Token(Token = "0x6003D8F"), Address(RVA = "0x10FA800", Offset = "0x10F9600", VA = "0x110FA800")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6003D90")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public FilterBindData()
      {
      }

      [Token(Token = "0x6003D91")]
      [Address(RVA = "0x10FA7C0", Offset = "0x10F95C0", VA = "0x110FA7C0")]
      public FilterBindData(
        int rarity,
        string name,
        ArtifactTypes equip_type = ArtifactTypes.None,
        byte runeSetEffectType = 0)
      {
      }
    }
  }
}
