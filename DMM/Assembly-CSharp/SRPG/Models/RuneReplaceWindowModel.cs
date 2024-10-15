// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneReplaceWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200339F")]
  public class RuneReplaceWindowModel
  {
    [Token(Token = "0x400F453")]
    [FieldOffset(Offset = "0x8")]
    private string mTargetUnit;
    [Token(Token = "0x400F454")]
    [FieldOffset(Offset = "0xC")]
    private string mSelectUnit;
    [Token(Token = "0x400F455")]
    [FieldOffset(Offset = "0x10")]
    private List<string> mSubjectUnitList;
    [Token(Token = "0x400F456")]
    [FieldOffset(Offset = "0x14")]
    private List<string> mDisplayUnitList;
    [Token(Token = "0x400F457")]
    [FieldOffset(Offset = "0x18")]
    private List<string> mUnitList;
    [Token(Token = "0x400F458")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, RuneReplaceContentParam> mUnitDataDic;
    [Token(Token = "0x400F459")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsFilter;
    [Token(Token = "0x400F45A")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsNoEquipFilter;
    [Token(Token = "0x400F45B")]
    [FieldOffset(Offset = "0x24")]
    private RuneReplaceWindowElementTabModel mCurrentTabModel;
    [Token(Token = "0x400F45C")]
    [FieldOffset(Offset = "0x28")]
    private RuneReplaceModelSort sort;

    [Token(Token = "0x1700202B")]
    public string TargetUnit
    {
      [Token(Token = "0x600E638"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700202C")]
    public string SelectUnit
    {
      [Token(Token = "0x600E639"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700202D")]
    public bool IsSelectUnit
    {
      [Token(Token = "0x600E63A"), Address(RVA = "0xACC630", Offset = "0xACB430", VA = "0x10ACC630")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700202E")]
    public List<string> DisplayUnitList
    {
      [Token(Token = "0x600E63B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700202F")]
    public Dictionary<string, RuneReplaceContentParam> UnitDataDic
    {
      [Token(Token = "0x600E63C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (Dictionary<string, RuneReplaceContentParam>) null;
      }
    }

    [Token(Token = "0x17002030")]
    public int IsFilterButtonImageIndex
    {
      [Token(Token = "0x600E63D"), Address(RVA = "0xACC620", Offset = "0xACB420", VA = "0x10ACC620")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002031")]
    public bool IsNoEquipFilter
    {
      [Token(Token = "0x600E63E"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E63F")]
    [Address(RVA = "0xACB3F0", Offset = "0xACA1F0", VA = "0x10ACB3F0")]
    public UnitData GetUnitData(string unit) => (UnitData) null;

    [Token(Token = "0x600E640")]
    [Address(RVA = "0xACB320", Offset = "0xACA120", VA = "0x10ACB320")]
    public UnitData GetTargetUnitData() => (UnitData) null;

    [Token(Token = "0x600E641")]
    [Address(RVA = "0xACB370", Offset = "0xACA170", VA = "0x10ACB370")]
    public string GetTargetUnitName() => (string) null;

    [Token(Token = "0x600E642")]
    [Address(RVA = "0xACB340", Offset = "0xACA140", VA = "0x10ACB340")]
    public long GetTargetUnitID() => new long();

    [Token(Token = "0x600E643")]
    [Address(RVA = "0xACB250", Offset = "0xACA050", VA = "0x10ACB250")]
    public UnitData GetSelectUnitData() => (UnitData) null;

    [Token(Token = "0x600E644")]
    [Address(RVA = "0xACB2A0", Offset = "0xACA0A0", VA = "0x10ACB2A0")]
    public string GetSelectUnitName() => (string) null;

    [Token(Token = "0x600E645")]
    [Address(RVA = "0xACB270", Offset = "0xACA070", VA = "0x10ACB270")]
    public long GetSelectUnitID() => new long();

    [Token(Token = "0x600E646")]
    [Address(RVA = "0xACB470", Offset = "0xACA270", VA = "0x10ACB470")]
    public RuneReplaceContentParam GetUnitRuneReplaceContentParam(string unit)
    {
      return (RuneReplaceContentParam) null;
    }

    [Token(Token = "0x600E647")]
    [Address(RVA = "0xACB3D0", Offset = "0xACA1D0", VA = "0x10ACB3D0")]
    public RuneReplaceContentParam GetTargetUnitRuneReplaceContentParam()
    {
      return (RuneReplaceContentParam) null;
    }

    [Token(Token = "0x600E648")]
    [Address(RVA = "0xACB300", Offset = "0xACA100", VA = "0x10ACB300")]
    public RuneReplaceContentParam GetSelectUnitRuneReplaceContentParam()
    {
      return (RuneReplaceContentParam) null;
    }

    [Token(Token = "0x600E649")]
    [Address(RVA = "0xACAEC0", Offset = "0xAC9CC0", VA = "0x10ACAEC0")]
    public List<RuneReplaceContentParam> GetSelectRuneReplaceContentParamList()
    {
      return (List<RuneReplaceContentParam>) null;
    }

    [Token(Token = "0x600E64A")]
    [Address(RVA = "0xACB080", Offset = "0xAC9E80", VA = "0x10ACB080")]
    public List<UnitData> GetSelectUnitDataList() => (List<UnitData>) null;

    [Token(Token = "0x600E64B")]
    [Address(RVA = "0xACB4D0", Offset = "0xACA2D0", VA = "0x10ACB4D0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E64C")]
    [Address(RVA = "0xACAA00", Offset = "0xAC9800", VA = "0x10ACAA00")]
    public void ClearUnitList()
    {
    }

    [Token(Token = "0x600E64D")]
    [Address(RVA = "0xACC030", Offset = "0xACAE30", VA = "0x10ACC030")]
    public void SetUnitList()
    {
    }

    [Token(Token = "0x600E64E")]
    [Address(RVA = "0xACB960", Offset = "0xACA760", VA = "0x10ACB960")]
    public void OverlapUnitList(string iname)
    {
    }

    [Token(Token = "0x600E64F")]
    [Address(RVA = "0xACA580", Offset = "0xAC9380", VA = "0x10ACA580")]
    public void BeforeDataBackup()
    {
    }

    [Token(Token = "0x600E650")]
    [Address(RVA = "0xACA530", Offset = "0xAC9330", VA = "0x10ACA530")]
    public void ApplyReplaceRune()
    {
    }

    [Token(Token = "0x600E651")]
    [Address(RVA = "0xACBEC0", Offset = "0xACACC0", VA = "0x10ACBEC0")]
    public bool SetSelectUnit(string iname) => new bool();

    [Token(Token = "0x600E652")]
    [Address(RVA = "0xACBD00", Offset = "0xACAB00", VA = "0x10ACBD00")]
    public void ReplaceRuneCancel()
    {
    }

    [Token(Token = "0x600E653")]
    [Address(RVA = "0xACBF40", Offset = "0xACAD40", VA = "0x10ACBF40")]
    public void SetTargetUnit(string select_id)
    {
    }

    [Token(Token = "0x600E654")]
    [Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")]
    public void SetCurrentCategoryTab(RuneReplaceWindowElementTabModel model)
    {
    }

    [Token(Token = "0x600E655")]
    [Address(RVA = "0x305F40", Offset = "0x304D40", VA = "0x10305F40")]
    public void SetNoEquipFilter(bool isOn)
    {
    }

    [Token(Token = "0x600E656")]
    [Address(RVA = "0xACBCB0", Offset = "0xACAAB0", VA = "0x10ACBCB0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600E657")]
    [Address(RVA = "0xACAE50", Offset = "0xAC9C50", VA = "0x10ACAE50")]
    public void FilterReset()
    {
    }

    [Token(Token = "0x600E658")]
    [Address(RVA = "0xACACD0", Offset = "0xAC9AD0", VA = "0x10ACACD0")]
    public void FilterRefresh()
    {
    }

    [Token(Token = "0x600E659")]
    [Address(RVA = "0xACB740", Offset = "0xACA540", VA = "0x10ACB740")]
    public void IsEquipRuneFilter()
    {
    }

    [Token(Token = "0x600E65A")]
    [Address(RVA = "0xACBBA0", Offset = "0xACA9A0", VA = "0x10ACBBA0")]
    private static bool RarityFilter(RuneData[] equipRunes, FilterRuneConditionParam[] filterList)
    {
      return new bool();
    }

    [Token(Token = "0x600E65B")]
    [Address(RVA = "0xACBDB0", Offset = "0xACABB0", VA = "0x10ACBDB0")]
    private static bool SetEffFilter(RuneData[] equipRunes, FilterRuneConditionParam[] filterList)
    {
      return new bool();
    }

    [Token(Token = "0x600E65C")]
    [Address(RVA = "0xACA310", Offset = "0xAC9110", VA = "0x10ACA310")]
    private static bool ActivateSetEffFilter(
      RuneData[] equipRunes,
      FilterRuneConditionParam[] filterList)
    {
      return new bool();
    }

    [Token(Token = "0x600E65D")]
    [Address(RVA = "0xACAA80", Offset = "0xAC9880", VA = "0x10ACAA80")]
    private static bool EvoStatueFilter(
      RuneData[] equipRunes,
      FilterRuneConditionParam[] filterList)
    {
      return new bool();
    }

    [Token(Token = "0x600E65E")]
    [Address(RVA = "0xACC350", Offset = "0xACB150", VA = "0x10ACC350")]
    private List<string> UnitCheckFilter(
      RuneReplaceWindowModel.FilterFunc func,
      List<FilterRuneConditionParam> filters,
      List<string> unitList)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600E65F")]
    [Address(RVA = "0xACA5D0", Offset = "0xAC93D0", VA = "0x10ACA5D0")]
    public void CheckFilter(FilterUtility.FilterPrefs mFilterPrefs, FilterRuneParam filterRuneParam)
    {
    }

    [Token(Token = "0x600E660")]
    [Address(RVA = "0xACC310", Offset = "0xACB110", VA = "0x10ACC310")]
    public void SortRefresh()
    {
    }

    [Token(Token = "0x600E661")]
    [Address(RVA = "0xACBD40", Offset = "0xACAB40", VA = "0x10ACBD40")]
    public void SaveNoEquipFilter()
    {
    }

    [Token(Token = "0x600E662")]
    [Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x10ACC5C0")]
    public RuneReplaceWindowModel()
    {
    }

    [Token(Token = "0x20033A0")]
    public delegate bool FilterFunc(RuneData[] equipRunes, FilterRuneConditionParam[] filterList);
  }
}
