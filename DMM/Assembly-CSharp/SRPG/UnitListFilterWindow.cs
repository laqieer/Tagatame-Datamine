// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListFilterWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C7B")]
  public class UnitListFilterWindow : FlowWindowBase
  {
    [Token(Token = "0x400DC34")]
    private const string SAVEKEY = "FilterUnit";
    [Token(Token = "0x400DC35")]
    private const string SAVEKEY_OLD = "UNITLIST";
    [Token(Token = "0x400DC36")]
    private const string SVB_KEY_SCROLL_RECT = "scroll_rect";
    [Token(Token = "0x400DC37")]
    private const string SVB_KEY_TAB_PARENT = "tab_btn_parent";
    [Token(Token = "0x400DC38")]
    private const string SVB_KEY_TAB_TEMPLATE = "tab_btn_template";
    [Token(Token = "0x400DC39")]
    private const string SVB_KEY_CATEGORY_RARITY = "category_rarity";
    [Token(Token = "0x400DC3A")]
    private const string SVB_KEY_CATEGORY_JOB = "category_job";
    [Token(Token = "0x400DC3B")]
    private const string SVB_KEY_CATEGORY_BIRTH = "category_birth";
    [Token(Token = "0x400DC3C")]
    private const string SVB_KEY_CATEGORY_SEX = "category_sex";
    [Token(Token = "0x400DC3D")]
    private const string SVB_KEY_CATEGORY_UNIT = "category_unit";
    [Token(Token = "0x400DC3E")]
    private const string SVB_KEY_CATEGORY_ARTIFACT = "category_artifact";
    [Token(Token = "0x400DC3F")]
    private const string SVB_KEY_CATEGORY_CHARASTORY = "category_chara_story";
    [Token(Token = "0x400DC40")]
    private const string SVB_KEY_CATEGORY_JOBMASTER = "category_job_master";
    [Token(Token = "0x400DC41")]
    private const string SVB_KEY_CATEGORY_RUNEPRIDE = "category_rune_pride";
    [Token(Token = "0x400DC42")]
    [FieldOffset(Offset = "0x30")]
    private UnitListFilterWindow.SerializeParam m_Param;
    [Token(Token = "0x400DC43")]
    [FieldOffset(Offset = "0x34")]
    private SerializeValueList m_ValueList;
    [Token(Token = "0x400DC44")]
    [FieldOffset(Offset = "0x38")]
    private UnitListWindow m_Root;
    [Token(Token = "0x400DC45")]
    [FieldOffset(Offset = "0x3C")]
    private SerializeValueBehaviour m_TargetPrefabSVB;
    [Token(Token = "0x400DC46")]
    [FieldOffset(Offset = "0x40")]
    private UnitListFilterWindow.Result m_Result;
    [Token(Token = "0x400DC47")]
    [FieldOffset(Offset = "0x44")]
    private Dictionary<string, UnitListFilterWindow.FilterValue> m_SelectType;
    [Token(Token = "0x400DC48")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<string, UnitListFilterWindow.FilterValue> m_SelectTypeReg;
    [Token(Token = "0x400DC49")]
    [FieldOffset(Offset = "0x4C")]
    private Dictionary<string, Toggle> m_Toggles;
    [Token(Token = "0x400DC4A")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, FilterUnitTab> m_Tabs;
    [Token(Token = "0x400DC4B")]
    [FieldOffset(Offset = "0x54")]
    private Dictionary<string, GameObject> m_ToggleCategory;
    [Token(Token = "0x400DC4C")]
    [FieldOffset(Offset = "0x58")]
    private string m_CurrentTab;
    [Token(Token = "0x400DC4D")]
    [FieldOffset(Offset = "0x5C")]
    private string m_FirstTab;
    [Token(Token = "0x400DC4E")]
    [FieldOffset(Offset = "0x60")]
    private IEnumerator m_ToggleFadeAnimation;
    [Token(Token = "0x400DC4F")]
    [FieldOffset(Offset = "0x64")]
    private ScrollRect m_ScrollRect;

    [Token(Token = "0x17001B2B")]
    public override string name
    {
      [Token(Token = "0x600CE29"), Address(RVA = "0x994A00", Offset = "0x993800", VA = "0x10994A00", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CE2A")]
    [Address(RVA = "0x992EC0", Offset = "0x991CC0", VA = "0x10992EC0", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x600CE2B")]
    [Address(RVA = "0x9926D0", Offset = "0x9914D0", VA = "0x109926D0")]
    private void CreateInstance()
    {
    }

    [Token(Token = "0x600CE2C")]
    [Address(RVA = "0x9916F0", Offset = "0x9904F0", VA = "0x109916F0")]
    private void CacheTabParam()
    {
    }

    [Token(Token = "0x600CE2D")]
    [Address(RVA = "0x991A40", Offset = "0x990840", VA = "0x10991A40")]
    private void CacheToggleParam(GameObject toggle_parent_obj)
    {
    }

    [Token(Token = "0x600CE2E")]
    [Address(RVA = "0x993820", Offset = "0x992620", VA = "0x10993820", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x600CE2F")]
    [Address(RVA = "0x994840", Offset = "0x993640", VA = "0x10994840", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x600CE30")]
    [Address(RVA = "0x992CE0", Offset = "0x991AE0", VA = "0x10992CE0")]
    private void InitializeToggleContent()
    {
    }

    [Token(Token = "0x600CE31")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void ReleaseToggleContent()
    {
    }

    [Token(Token = "0x600CE32")]
    [Address(RVA = "0x9940F0", Offset = "0x992EF0", VA = "0x109940F0")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600CE33")]
    [Address(RVA = "0x994060", Offset = "0x992E60", VA = "0x10994060")]
    private void StartSwitchVisibleAnimation(List<CanvasGroup> list_on, List<CanvasGroup> list_off)
    {
    }

    [Token(Token = "0x600CE34")]
    [Address(RVA = "0x9940B0", Offset = "0x992EB0", VA = "0x109940B0")]
    private void StopSwitchVisibleAnimation()
    {
    }

    [Token(Token = "0x600CE35")]
    [Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")]
    public void SetRoot(UnitListWindow root)
    {
    }

    [Token(Token = "0x600CE36")]
    [Address(RVA = "0x993FE0", Offset = "0x992DE0", VA = "0x10993FE0")]
    private void SetSelect(string selectType)
    {
    }

    [Token(Token = "0x600CE37")]
    [Address(RVA = "0x993930", Offset = "0x992730", VA = "0x10993930")]
    private void ResetSelect(string selectType)
    {
    }

    [Token(Token = "0x600CE38")]
    [Address(RVA = "0x992B30", Offset = "0x991930", VA = "0x10992B30")]
    public List<string> GetSelect() => (List<string>) null;

    [Token(Token = "0x600CE39")]
    [Address(RVA = "0x992980", Offset = "0x991780", VA = "0x10992980")]
    public List<string> GetSelectReg() => (List<string>) null;

    [Token(Token = "0x600CE3A")]
    [Address(RVA = "0x993C10", Offset = "0x992A10", VA = "0x10993C10")]
    private static void SelectCopyTo(
      Dictionary<string, UnitListFilterWindow.FilterValue> src,
      ref Dictionary<string, UnitListFilterWindow.FilterValue> dst)
    {
    }

    [Token(Token = "0x600CE3B")]
    [Address(RVA = "0x9922D0", Offset = "0x9910D0", VA = "0x109922D0")]
    public void CalcUnit(List<UnitListWindow.Data> list, FilterUtility.FilterPrefs filter)
    {
    }

    [Token(Token = "0x600CE3C")]
    [Address(RVA = "0x993E70", Offset = "0x992C70", VA = "0x10993E70")]
    private void SelectTab(string tabName)
    {
    }

    [Token(Token = "0x600CE3D")]
    [Address(RVA = "0x9946E0", Offset = "0x9934E0", VA = "0x109946E0")]
    private void UpdateTabState()
    {
    }

    [Token(Token = "0x600CE3E")]
    [Address(RVA = "0x992530", Offset = "0x991330", VA = "0x10992530")]
    private bool ContainsActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x600CE3F")]
    [Address(RVA = "0x993110", Offset = "0x991F10", VA = "0x10993110")]
    public void LoadSelectType()
    {
    }

    [Token(Token = "0x600CE40")]
    [Address(RVA = "0x9939B0", Offset = "0x9927B0", VA = "0x109939B0")]
    public void SaveSelectType()
    {
    }

    [Token(Token = "0x600CE41")]
    [Address(RVA = "0x9932F0", Offset = "0x9920F0", VA = "0x109932F0", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600CE42")]
    [Address(RVA = "0x993760", Offset = "0x992560", VA = "0x10993760")]
    private void OnFilterValueChanged(Toggle toggle, bool value)
    {
    }

    [Token(Token = "0x600CE43")]
    [Address(RVA = "0x993830", Offset = "0x992630", VA = "0x10993830")]
    private void ResetScrollPos()
    {
    }

    [Token(Token = "0x600CE44")]
    [Address(RVA = "0x994890", Offset = "0x993690", VA = "0x10994890")]
    public UnitListFilterWindow()
    {
    }

    [Token(Token = "0x2002C7C")]
    public enum Result
    {
      [Token(Token = "0x400DC51")] NONE,
      [Token(Token = "0x400DC52")] CONFIRM,
      [Token(Token = "0x400DC53")] CANCEL,
    }

    [Token(Token = "0x2002C7D")]
    private class FilterValue
    {
      [Token(Token = "0x400DC54")]
      [FieldOffset(Offset = "0x8")]
      private string m_Majorkey;
      [Token(Token = "0x400DC55")]
      [FieldOffset(Offset = "0xC")]
      private string m_Minorkey;
      [Token(Token = "0x400DC56")]
      [FieldOffset(Offset = "0x10")]
      private bool m_Value;

      [Token(Token = "0x17001B2C")]
      public string MajorKey
      {
        [Token(Token = "0x600CE45"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001B2D")]
      public string Minorkey
      {
        [Token(Token = "0x600CE46"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001B2E")]
      public bool Value
      {
        [Token(Token = "0x600CE47"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
        [Token(Token = "0x600CE48"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
        {
        }
      }

      [Token(Token = "0x600CE49")]
      [Address(RVA = "0x4ACEB0", Offset = "0x4ABCB0", VA = "0x104ACEB0")]
      public FilterValue(string majorKey, string minorKey, bool value)
      {
      }

      [Token(Token = "0x600CE4A")]
      [Address(RVA = "0x98E850", Offset = "0x98D650", VA = "0x1098E850")]
      public UnitListFilterWindow.FilterValue Clone() => (UnitListFilterWindow.FilterValue) null;
    }

    [Token(Token = "0x2002C7E")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x17001B2F")]
      public override System.Type type
      {
        [Token(Token = "0x600CE4B"), Address(RVA = "0x9912B0", Offset = "0x9900B0", VA = "0x109912B0", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x600CE4C")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
