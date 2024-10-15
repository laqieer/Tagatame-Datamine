// Decompiled with JetBrains decompiler
// Type: SRPG.SortUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BAB")]
  public static class SortUtility
  {
    [Token(Token = "0x4001D85")]
    private const char PREFS_KEY_SEPARATOR = ':';
    [Token(Token = "0x4001D86")]
    [FieldOffset(Offset = "0x0")]
    private static SortUtility.SortRunePrefs s_RunePrefsCache;
    [Token(Token = "0x4001D87")]
    [FieldOffset(Offset = "0x4")]
    private static bool s_IsCacheReady;
    [Token(Token = "0x4001D88")]
    [FieldOffset(Offset = "0x8")]
    private static SortUtility.SortPrefs s_CrystalPrefsCache;
    [Token(Token = "0x4001D89")]
    [FieldOffset(Offset = "0xC")]
    private static bool s_IsCrystalCacheReady;
    [Token(Token = "0x4001D8A")]
    [FieldOffset(Offset = "0x10")]
    private static SortUtility.SortPrefs s_ArtifactPrefsCache;
    [Token(Token = "0x4001D8B")]
    [FieldOffset(Offset = "0x14")]
    private static bool s_IsArtifactCacheReady;

    [Token(Token = "0x6002EBC")]
    public static void StableSort<T>(List<T> list, Comparison<T> comparison)
    {
    }

    [Token(Token = "0x6002EBD")]
    [Address(RVA = "0xFD1E40", Offset = "0xFD0C40", VA = "0x10FD1E40")]
    public static void Save_RuneSortForCache(SortUtility.SortRunePrefs prefs)
    {
    }

    [Token(Token = "0x6002EBE")]
    [Address(RVA = "0xFD1940", Offset = "0xFD0740", VA = "0x10FD1940")]
    public static SortUtility.SortRunePrefs Load_RuneSortFromCache()
    {
      return (SortUtility.SortRunePrefs) null;
    }

    [Token(Token = "0x6002EBF")]
    [Address(RVA = "0xFD19B0", Offset = "0xFD07B0", VA = "0x10FD19B0")]
    private static SortUtility.SortRunePrefs Load_RuneSort() => (SortUtility.SortRunePrefs) null;

    [Token(Token = "0x6002EC0")]
    [Address(RVA = "0xFD25C0", Offset = "0xFD13C0", VA = "0x10FD25C0")]
    public static void SortRune(
      eRuneSortType type,
      bool isAscending,
      bool isBaseParamSort,
      bool isEvoParamSort,
      bool isSetParamSort,
      List<BindRuneData> rune_list)
    {
    }

    [Token(Token = "0x6002EC1")]
    [Address(RVA = "0xFD2850", Offset = "0xFD1650", VA = "0x10FD2850")]
    public static void SortRune(
      eRuneSortType type,
      bool isAscending,
      bool isBaseParamSort,
      bool isEvoParamSort,
      bool isSetParamSort,
      List<BindRuneData> rune_list,
      UnitData select_unit)
    {
    }

    [Token(Token = "0x6002EC2")]
    [Address(RVA = "0xFD1E00", Offset = "0xFD0C00", VA = "0x10FD1E00")]
    public static void Save_CrystalSortForCache(SortUtility.SortPrefs prefs)
    {
    }

    [Token(Token = "0x6002EC3")]
    [Address(RVA = "0xFD1430", Offset = "0xFD0230", VA = "0x10FD1430")]
    public static SortUtility.SortPrefs Load_CrystalSortFromCache() => (SortUtility.SortPrefs) null;

    [Token(Token = "0x6002EC4")]
    [Address(RVA = "0xFD14A0", Offset = "0xFD02A0", VA = "0x10FD14A0")]
    private static SortUtility.SortPrefs Load_CrystalSort() => (SortUtility.SortPrefs) null;

    [Token(Token = "0x6002EC5")]
    [Address(RVA = "0xFD22C0", Offset = "0xFD10C0", VA = "0x10FD22C0")]
    public static void SortCrystal(
      CrystalSortCondParam _param,
      bool _is_ascending,
      ref List<CrystalData> _crystal_list)
    {
    }

    [Token(Token = "0x6002EC6")]
    [Address(RVA = "0xFD1DC0", Offset = "0xFD0BC0", VA = "0x10FD1DC0")]
    public static void Save_ArtifactSortForCache(SortUtility.SortPrefs prefs)
    {
    }

    [Token(Token = "0x6002EC7")]
    [Address(RVA = "0xFD0CE0", Offset = "0xFCFAE0", VA = "0x10FD0CE0")]
    public static SortUtility.SortPrefs Load_ArtifactSortFromCache(
      string prefs_key,
      string prefs_key2)
    {
      return (SortUtility.SortPrefs) null;
    }

    [Token(Token = "0x6002EC8")]
    [Address(RVA = "0xFD0D90", Offset = "0xFCFB90", VA = "0x10FD0D90")]
    private static SortUtility.SortPrefs Load_ArtifactSort(string prefs_key, string prefs_key2)
    {
      return (SortUtility.SortPrefs) null;
    }

    [Token(Token = "0x6002EC9")]
    [Address(RVA = "0xFD1EB0", Offset = "0xFD0CB0", VA = "0x10FD1EB0")]
    public static void SortArtifact(
      SortArtifactCondParam _param,
      bool _is_ascending,
      bool is_artifact_stone,
      ref object[] _artifact_list)
    {
    }

    [Token(Token = "0x6002ECA")]
    [Address(RVA = "0xFD0750", Offset = "0xFCF550", VA = "0x10FD0750")]
    private static void GetSortData(
      object artifact,
      SortArtifactCondParam _param,
      bool _is_ascending,
      out List<long> _sort_value_list,
      out List<long> _sort_value_list2,
      out string _sort_name,
      bool is_artifact_stone)
    {
    }

    [Token(Token = "0x6002ECB")]
    [Address(RVA = "0xFCF240", Offset = "0xFCE040", VA = "0x10FCF240")]
    private static bool GetOldArtifactSortSetting(
      string filterKey,
      List<SortArtifactParam> sort_params,
      ref SortUtility.SortPrefs prefs)
    {
      return new bool();
    }

    [Token(Token = "0x2000BAC")]
    [Serializable]
    public class JSON_SortDataList
    {
      [Token(Token = "0x4001D8C")]
      [FieldOffset(Offset = "0x8")]
      public SortUtility.JSON_SortData[] list;
      [Token(Token = "0x4001D8D")]
      [FieldOffset(Offset = "0xC")]
      public bool is_ascending;

      [Token(Token = "0x6002ECC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_SortDataList()
      {
      }
    }

    [Token(Token = "0x2000BAD")]
    [Serializable]
    public class JSON_SortDataListRune : SortUtility.JSON_SortDataList
    {
      [Token(Token = "0x4001D8E")]
      [FieldOffset(Offset = "0x10")]
      public bool is_base_param;
      [Token(Token = "0x4001D8F")]
      [FieldOffset(Offset = "0x11")]
      public bool is_evo_param;
      [Token(Token = "0x4001D90")]
      [FieldOffset(Offset = "0x12")]
      public bool is_set_param;

      [Token(Token = "0x6002ECD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_SortDataListRune()
      {
      }
    }

    [Token(Token = "0x2000BAE")]
    [Serializable]
    public class JSON_SortData
    {
      [Token(Token = "0x4001D91")]
      [FieldOffset(Offset = "0x8")]
      public string key;
      [Token(Token = "0x4001D92")]
      [FieldOffset(Offset = "0xC")]
      public int value;

      [Token(Token = "0x170002A6")]
      public bool Value
      {
        [Token(Token = "0x6002ECE"), Address(RVA = "0x7C1EC0", Offset = "0x7C0CC0", VA = "0x107C1EC0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002ECF"), Address(RVA = "0x2B00A0", Offset = "0x2AEEA0", VA = "0x102B00A0")] set
        {
        }
      }

      [Token(Token = "0x6002ED0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_SortData()
      {
      }
    }

    [Token(Token = "0x2000BAF")]
    public class SortTempDiff
    {
      [Token(Token = "0x4001D93")]
      [FieldOffset(Offset = "0x8")]
      public List<bool> m_ToggleValues;
      [Token(Token = "0x4001D94")]
      [FieldOffset(Offset = "0xC")]
      public bool m_IsAscending;

      [Token(Token = "0x6002ED1")]
      [Address(RVA = "0xFCF1D0", Offset = "0xFCDFD0", VA = "0x10FCF1D0")]
      public SortTempDiff()
      {
      }
    }

    [Token(Token = "0x2000BB0")]
    public class SortTempDiffRune : SortUtility.SortTempDiff
    {
      [Token(Token = "0x4001D95")]
      [FieldOffset(Offset = "0x10")]
      public bool m_IsBaseParam;
      [Token(Token = "0x4001D96")]
      [FieldOffset(Offset = "0x11")]
      public bool m_IsEvoParam;
      [Token(Token = "0x4001D97")]
      [FieldOffset(Offset = "0x12")]
      public bool m_IsSetParam;

      [Token(Token = "0x6002ED2")]
      [Address(RVA = "0xFCF1C0", Offset = "0xFCDFC0", VA = "0x10FCF1C0")]
      public SortTempDiffRune()
      {
      }
    }

    [Token(Token = "0x2000BB1")]
    public class SortPrefsData
    {
      [Token(Token = "0x4001D98")]
      [FieldOffset(Offset = "0x8")]
      private bool m_Value;
      [Token(Token = "0x4001D99")]
      [FieldOffset(Offset = "0xC")]
      private string m_MajorKey;
      [Token(Token = "0x4001D9A")]
      [FieldOffset(Offset = "0x10")]
      private string m_MinorKey;

      [Token(Token = "0x170002A7")]
      public string Key
      {
        [Token(Token = "0x6002ED3"), Address(RVA = "0xFCDE20", Offset = "0xFCCC20", VA = "0x10FCDE20")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170002A8")]
      public bool Value
      {
        [Token(Token = "0x6002ED4"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002ED5"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] set
        {
        }
      }

      [Token(Token = "0x170002A9")]
      public string MajorKey
      {
        [Token(Token = "0x6002ED6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6002ED7"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
        {
        }
      }

      [Token(Token = "0x170002AA")]
      public string MinorKey
      {
        [Token(Token = "0x6002ED8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6002ED9"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
        {
        }
      }

      [Token(Token = "0x6002EDA")]
      [Address(RVA = "0xFCDC60", Offset = "0xFCCA60", VA = "0x10FCDC60")]
      public bool Deserialize(SortUtility.JSON_SortData json) => new bool();

      [Token(Token = "0x6002EDB")]
      [Address(RVA = "0xFCDD50", Offset = "0xFCCB50", VA = "0x10FCDD50")]
      public void Serialize(ref SortUtility.JSON_SortData json)
      {
      }

      [Token(Token = "0x6002EDC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SortPrefsData()
      {
      }
    }

    [Token(Token = "0x2000BB2")]
    public class SortPrefs
    {
      [Token(Token = "0x4001D9B")]
      [FieldOffset(Offset = "0x8")]
      private string m_PrefsKey;
      [Token(Token = "0x4001D9C")]
      [FieldOffset(Offset = "0xC")]
      private List<SortUtility.SortPrefsData> m_SortPrefsDataList;
      [Token(Token = "0x4001D9D")]
      [FieldOffset(Offset = "0x10")]
      private bool m_IsAscending;
      [Token(Token = "0x4001D9E")]
      [FieldOffset(Offset = "0x11")]
      protected bool m_PrefsKeyWasNotFound;

      [Token(Token = "0x170002AB")]
      public List<SortUtility.SortPrefsData> SortPrefsDataList
      {
        [Token(Token = "0x6002EDD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (List<SortUtility.SortPrefsData>) null;
        }
      }

      [Token(Token = "0x170002AC")]
      public bool IsAscending
      {
        [Token(Token = "0x6002EDE"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002AD")]
      public bool IsPrefabKeyNotFound
      {
        [Token(Token = "0x6002EDF"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002AE")]
      public string PrefsKey
      {
        [Token(Token = "0x6002EE0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6002EE1")]
      [Address(RVA = "0xFCED10", Offset = "0xFCDB10", VA = "0x10FCED10")]
      public SortPrefs(string prefsKey)
      {
      }

      [Token(Token = "0x6002EE2")]
      [Address(RVA = "0xFCE6D0", Offset = "0xFCD4D0", VA = "0x10FCE6D0")]
      public static string MakeKey(string majorKey, string minorKey) => (string) null;

      [Token(Token = "0x6002EE3")]
      [Address(RVA = "0xFCEBE0", Offset = "0xFCD9E0", VA = "0x10FCEBE0")]
      public void SetValue(int index, bool value)
      {
      }

      [Token(Token = "0x6002EE4")]
      [Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")]
      public void SetAscending(bool value)
      {
      }

      [Token(Token = "0x6002EE5")]
      [Address(RVA = "0xFCEC40", Offset = "0xFCDA40", VA = "0x10FCEC40")]
      public void SetValue(string majorKey, string minorKey, bool value)
      {
      }

      [Token(Token = "0x6002EE6")]
      [Address(RVA = "0xFCEA80", Offset = "0xFCD880", VA = "0x10FCEA80")]
      public void SetValueAll(string majorKey, bool value)
      {
      }

      [Token(Token = "0x6002EE7")]
      [Address(RVA = "0xFCEB30", Offset = "0xFCD930", VA = "0x10FCEB30")]
      public void SetValueAll(bool value)
      {
      }

      [Token(Token = "0x6002EE8")]
      [Address(RVA = "0xFCE2A0", Offset = "0xFCD0A0", VA = "0x10FCE2A0")]
      public bool GetValue(string majorKey, string minorKey, bool defaultValue = false)
      {
        return new bool();
      }

      [Token(Token = "0x6002EE9")]
      [Address(RVA = "0xFCE4F0", Offset = "0xFCD2F0", VA = "0x10FCE4F0")]
      public bool IsDisableSortAll() => new bool();

      [Token(Token = "0x6002EEA")]
      [Address(RVA = "0xFCE710", Offset = "0xFCD510", VA = "0x10FCE710")]
      public void RemoveKeys(Predicate<SortUtility.SortPrefsData> predicate)
      {
      }

      [Token(Token = "0x6002EEB")]
      [Address(RVA = "0xFCE200", Offset = "0xFCD000", VA = "0x10FCE200")]
      public SortUtility.SortPrefsData FindFirstOn() => (SortUtility.SortPrefsData) null;

      [Token(Token = "0x6002EEC")]
      [Address(RVA = "0xFCDFE0", Offset = "0xFCCDE0", VA = "0x10FCDFE0", Slot = "4")]
      public virtual void Deserialize(SortUtility.JSON_SortDataList json)
      {
      }

      [Token(Token = "0x6002EED")]
      [Address(RVA = "0xFCE7F0", Offset = "0xFCD5F0", VA = "0x10FCE7F0", Slot = "5")]
      public virtual void Serialize(ref SortUtility.JSON_SortDataList json)
      {
      }

      [Token(Token = "0x6002EEE")]
      [Address(RVA = "0xFCE760", Offset = "0xFCD560", VA = "0x10FCE760")]
      public static void Save(SortUtility.SortPrefs sortPrefs)
      {
      }

      [Token(Token = "0x6002EEF")]
      [Address(RVA = "0xFCE5E0", Offset = "0xFCD3E0", VA = "0x10FCE5E0")]
      public static SortUtility.SortPrefs Load(string prefsKey) => (SortUtility.SortPrefs) null;

      [Token(Token = "0x6002EF0")]
      [Address(RVA = "0xFCDF70", Offset = "0xFCCD70", VA = "0x10FCDF70", Slot = "6")]
      public virtual SortUtility.SortTempDiff CreateTempDiffData()
      {
        return (SortUtility.SortTempDiff) null;
      }

      [Token(Token = "0x6002EF1")]
      [Address(RVA = "0xFCDE70", Offset = "0xFCCC70", VA = "0x10FCDE70")]
      public void CopyTo(SortUtility.SortTempDiff tempDiffData)
      {
      }

      [Token(Token = "0x6002EF2")]
      [Address(RVA = "0xFCE410", Offset = "0xFCD210", VA = "0x10FCE410", Slot = "7")]
      public virtual bool IsDiff(SortUtility.SortTempDiff tempDiffData) => new bool();
    }

    [Token(Token = "0x2000BB7")]
    public class SortRunePrefs : SortUtility.SortPrefs
    {
      [Token(Token = "0x4001DA6")]
      [FieldOffset(Offset = "0x14")]
      private bool m_IsBaseParam;
      [Token(Token = "0x4001DA7")]
      [FieldOffset(Offset = "0x15")]
      private bool m_IsEvoParam;
      [Token(Token = "0x4001DA8")]
      [FieldOffset(Offset = "0x16")]
      private bool m_IsSetParam;

      [Token(Token = "0x170002AF")]
      public bool IsBaseParamSort
      {
        [Token(Token = "0x6002EFC"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002B0")]
      public bool IsEvoParamSort
      {
        [Token(Token = "0x6002EFD"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002B1")]
      public bool IsSetParamSort
      {
        [Token(Token = "0x6002EFE"), Address(RVA = "0x7B1D20", Offset = "0x7B0B20", VA = "0x107B1D20")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002B2")]
      public bool IsParamSortAllOff
      {
        [Token(Token = "0x6002EFF"), Address(RVA = "0xFCF1A0", Offset = "0xFCDFA0", VA = "0x10FCF1A0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6002F00")]
      [Address(RVA = "0xFCF190", Offset = "0xFCDF90", VA = "0x10FCF190")]
      public SortRunePrefs(string prefsKey)
      {
      }

      [Token(Token = "0x6002F01")]
      [Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")]
      public void SetIsBaseParam(bool value)
      {
      }

      [Token(Token = "0x6002F02")]
      [Address(RVA = "0x7B1CA0", Offset = "0x7B0AA0", VA = "0x107B1CA0")]
      public void SetIsEvoParam(bool value)
      {
      }

      [Token(Token = "0x6002F03")]
      [Address(RVA = "0x7B1C90", Offset = "0x7B0A90", VA = "0x107B1C90")]
      public void SetIsSetParam(bool value)
      {
      }

      [Token(Token = "0x6002F04")]
      [Address(RVA = "0xFCEE00", Offset = "0xFCDC00", VA = "0x10FCEE00", Slot = "4")]
      public override void Deserialize(SortUtility.JSON_SortDataList json)
      {
      }

      [Token(Token = "0x6002F05")]
      [Address(RVA = "0xFCF0F0", Offset = "0xFCDEF0", VA = "0x10FCF0F0", Slot = "5")]
      public override void Serialize(ref SortUtility.JSON_SortDataList json)
      {
      }

      [Token(Token = "0x6002F06")]
      [Address(RVA = "0xFCF000", Offset = "0xFCDE00", VA = "0x10FCF000")]
      public new static SortUtility.SortPrefs Load(string prefsKey) => (SortUtility.SortPrefs) null;

      [Token(Token = "0x6002F07")]
      [Address(RVA = "0xFCED90", Offset = "0xFCDB90", VA = "0x10FCED90", Slot = "6")]
      public override SortUtility.SortTempDiff CreateTempDiffData()
      {
        return (SortUtility.SortTempDiff) null;
      }

      [Token(Token = "0x6002F08")]
      [Address(RVA = "0xFCEEA0", Offset = "0xFCDCA0", VA = "0x10FCEEA0", Slot = "7")]
      public override bool IsDiff(SortUtility.SortTempDiff tempDiffData) => new bool();
    }

    [Token(Token = "0x2000BB8")]
    public class SortTempData<T> where T : class
    {
      [Token(Token = "0x4001DA9")]
      [FieldOffset(Offset = "0x0")]
      public T data;
      [Token(Token = "0x4001DAA")]
      [FieldOffset(Offset = "0x0")]
      public long sort_val;

      [Token(Token = "0x6002F09")]
      public SortTempData(T _data, long _sort_val)
      {
      }

      [Token(Token = "0x6002F0A")]
      public override string ToString() => (string) null;
    }

    [Token(Token = "0x2000BB9")]
    public class MultipleSortTempData<T> where T : class
    {
      [Token(Token = "0x4001DAB")]
      [FieldOffset(Offset = "0x0")]
      public T data;
      [Token(Token = "0x4001DAC")]
      [FieldOffset(Offset = "0x0")]
      public int sort_count;
      [Token(Token = "0x4001DAD")]
      [FieldOffset(Offset = "0x0")]
      public List<long> sort_val_list;
      [Token(Token = "0x4001DAE")]
      [FieldOffset(Offset = "0x0")]
      public int sort_count2;
      [Token(Token = "0x4001DAF")]
      [FieldOffset(Offset = "0x0")]
      public List<long> sort_val_list2;
      [Token(Token = "0x4001DB0")]
      [FieldOffset(Offset = "0x0")]
      public string sort_name;

      [Token(Token = "0x6002F0B")]
      public MultipleSortTempData(T _data, List<long> _sort_val_list, string _sort_name = null)
      {
      }

      [Token(Token = "0x6002F0C")]
      public MultipleSortTempData(
        T _data,
        List<long> _sort_val_list,
        List<long> _sort_val_list2,
        string _sort_name = null)
      {
      }
    }
  }
}
