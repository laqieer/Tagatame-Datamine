// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalRecommendWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022D2")]
  [FlowNode.Pin(101, "装備確認へ", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "お任せ装備開始", FlowNode.PinTypes.Input, 1)]
  public class CrystalRecommendWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009B15")]
    private const int PIN_INPUT_DECISION = 1;
    [Token(Token = "0x4009B16")]
    private const int PIN_OUTPUT_CHECK_EQUIP = 101;
    [Token(Token = "0x4009B17")]
    public const string EQUIP_DATA_KEY = "EquipData";
    [Token(Token = "0x4009B18")]
    private const string NONE_TITLE_INAME = "NoTitle";
    [Token(Token = "0x4009B19")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private CrystalCategoryRecommendItem ItemTempleate;
    [Token(Token = "0x4009B1A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x4009B1B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalCategoryRecommendTab TabTempleate;
    [Token(Token = "0x4009B1C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform TabParent;
    [Token(Token = "0x4009B1D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour EquipData;
    [Token(Token = "0x4009B21")]
    [FieldOffset(Offset = "0x2C")]
    private List<CrystalCategoryRecommendToggle> mToggleList;
    [Token(Token = "0x4009B22")]
    [FieldOffset(Offset = "0x30")]
    private List<CrystalCategoryRecommendItem> mItemList;
    [Token(Token = "0x4009B23")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<string, List<CrystalRecommendParam>> mTabDic;
    [Token(Token = "0x4009B24")]
    [FieldOffset(Offset = "0x38")]
    private UnitData mUnitData;
    [Token(Token = "0x4009B25")]
    [FieldOffset(Offset = "0x3C")]
    private CrystalRecommendWindow.ListSort mNowListSort;

    [Token(Token = "0x170014E8")]
    public ParamTypes SelectParam
    {
      [Token(Token = "0x6009593"), Address(RVA = "0x35B820", Offset = "0x35A620", VA = "0x1035B820")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6009594"), Address(RVA = "0x35B860", Offset = "0x35A660", VA = "0x1035B860")] private set
      {
      }
    }

    [Token(Token = "0x170014E9")]
    public string SelectTagName
    {
      [Token(Token = "0x6009595"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009596"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
      {
      }
    }

    [Token(Token = "0x170014EA")]
    public string SelectTabName
    {
      [Token(Token = "0x6009597"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009598"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x6009599")]
    [Address(RVA = "0x584BF0", Offset = "0x5839F0", VA = "0x10584BF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600959A")]
    [Address(RVA = "0x587340", Offset = "0x586140", VA = "0x10587340")]
    private void Start()
    {
    }

    [Token(Token = "0x600959B")]
    [Address(RVA = "0x5869A0", Offset = "0x5857A0", VA = "0x105869A0")]
    private void Init()
    {
    }

    [Token(Token = "0x600959C")]
    [Address(RVA = "0x585750", Offset = "0x584550", VA = "0x10585750")]
    private void DisplayList()
    {
    }

    [Token(Token = "0x600959D")]
    [Address(RVA = "0x584C10", Offset = "0x583A10", VA = "0x10584C10")]
    private void ChangeTabActive()
    {
    }

    [Token(Token = "0x600959E")]
    [Address(RVA = "0x587300", Offset = "0x586100", VA = "0x10587300")]
    public void SetToggleButton(CrystalCategoryRecommendToggle _toggle)
    {
    }

    [Token(Token = "0x600959F")]
    [Address(RVA = "0x587110", Offset = "0x585F10", VA = "0x10587110")]
    public void SelectRecommendToggle(CrystalCategoryRecommendToggle _toggle, bool _is_on)
    {
    }

    [Token(Token = "0x60095A0")]
    [Address(RVA = "0x5872B0", Offset = "0x5860B0", VA = "0x105872B0")]
    public void SelectTabToggle(CrystalCategoryRecommendTab _tab, bool _is_on)
    {
    }

    [Token(Token = "0x60095A1")]
    [Address(RVA = "0x5855D0", Offset = "0x5843D0", VA = "0x105855D0")]
    private void DecisionEquip()
    {
    }

    [Token(Token = "0x60095A2")]
    [Address(RVA = "0x584D80", Offset = "0x583B80", VA = "0x10584D80")]
    private List<CrystalRecommendWindow.RecommendCrystalData> CreateSearchCrystalList()
    {
      return (List<CrystalRecommendWindow.RecommendCrystalData>) null;
    }

    [Token(Token = "0x60095A3")]
    [Address(RVA = "0x5865A0", Offset = "0x5853A0", VA = "0x105865A0")]
    private CrystalRecommendWindow.RecommendComparisonData GetRecommendList(
      List<CrystalRecommendWindow.RecommendCrystalData> _data_list,
      int _slot_num)
    {
      return (CrystalRecommendWindow.RecommendComparisonData) null;
    }

    [Token(Token = "0x60095A4")]
    [Address(RVA = "0x585D90", Offset = "0x584B90", VA = "0x10585D90")]
    private CrystalRecommendWindow.RecommendCrystalData GetNextEquipCrystalData(
      CrystalRecommendWindow.RecommendComparisonData _data,
      List<CrystalRecommendWindow.RecommendCrystalData> _data_list,
      bool _is_add_all_status)
    {
      return new CrystalRecommendWindow.RecommendCrystalData();
    }

    [Token(Token = "0x60095A5")]
    [Address(RVA = "0x587350", Offset = "0x586150", VA = "0x10587350")]
    public CrystalRecommendWindow()
    {
    }

    [Token(Token = "0x20022D3")]
    public struct RecommendCrystalData
    {
      [Token(Token = "0x4009B26")]
      [FieldOffset(Offset = "0x0")]
      public CrystalData Data;
      [Token(Token = "0x4009B27")]
      [FieldOffset(Offset = "0x4")]
      public int TargetValue;
      [Token(Token = "0x4009B28")]
      [FieldOffset(Offset = "0x8")]
      public int TargetLimitAddValue;
      [Token(Token = "0x4009B29")]
      [FieldOffset(Offset = "0xC")]
      public int AllValue;
    }

    [Token(Token = "0x20022D4")]
    public struct RecommendSetBonusParam
    {
      [Token(Token = "0x4009B2A")]
      [FieldOffset(Offset = "0x0")]
      public CrystalSetBonusParam Param;
      [Token(Token = "0x4009B2B")]
      [FieldOffset(Offset = "0x4")]
      public CrystalRecommendWindow.RecommendCrystalData MainCrystal;
      [Token(Token = "0x4009B2C")]
      [FieldOffset(Offset = "0x14")]
      public List<CrystalRecommendWindow.RecommendCrystalData> SubCrystalList;
      [Token(Token = "0x4009B2D")]
      [FieldOffset(Offset = "0x18")]
      public int TargetValue;
      [Token(Token = "0x4009B2E")]
      [FieldOffset(Offset = "0x1C")]
      public int TargetLimitAddValue;
      [Token(Token = "0x4009B2F")]
      [FieldOffset(Offset = "0x20")]
      public int TargetValueIncludeCrystal;
      [Token(Token = "0x4009B30")]
      [FieldOffset(Offset = "0x24")]
      public int TargetLimitAddIncludeCrystal;
      [Token(Token = "0x4009B31")]
      [FieldOffset(Offset = "0x28")]
      public int SubCount;
    }

    [Token(Token = "0x20022D5")]
    public class RecommendComparisonData
    {
      [Token(Token = "0x4009B32")]
      [FieldOffset(Offset = "0x8")]
      public List<CrystalData> CrystalList;
      [Token(Token = "0x4009B33")]
      [FieldOffset(Offset = "0xC")]
      public List<CrystalRecommendWindow.RecommendSetBonusParam> SetBonusList;
      [Token(Token = "0x4009B34")]
      [FieldOffset(Offset = "0x10")]
      public int SumTargetValue;
      [Token(Token = "0x4009B35")]
      [FieldOffset(Offset = "0x14")]
      public int SumTargetLimitAddValue;
      [Token(Token = "0x4009B36")]
      [FieldOffset(Offset = "0x18")]
      public int SlotCount;
      [Token(Token = "0x4009B37")]
      [FieldOffset(Offset = "0x1C")]
      public int SetBonusSubCount;
      [Token(Token = "0x4009B38")]
      [FieldOffset(Offset = "0x20")]
      private UnitData mUnitData;
      [Token(Token = "0x4009B39")]
      [FieldOffset(Offset = "0x24")]
      private int mDefalutLimitValue;
      [Token(Token = "0x4009B3A")]
      [FieldOffset(Offset = "0x28")]
      private ParamTypes mBuffType;
      [Token(Token = "0x4009B3B")]
      [FieldOffset(Offset = "0x2C")]
      private int mSlotLimitNum;

      [Token(Token = "0x60095A6")]
      [Address(RVA = "0x591E90", Offset = "0x590C90", VA = "0x10591E90")]
      public RecommendComparisonData(ParamTypes _buff_type, UnitData _unit_data, int _slot_num)
      {
      }

      [Token(Token = "0x60095A7")]
      [Address(RVA = "0x591AE0", Offset = "0x5908E0", VA = "0x10591AE0")]
      public void ToCopy(
        CrystalRecommendWindow.RecommendComparisonData _data)
      {
      }

      [Token(Token = "0x60095A8")]
      [Address(RVA = "0x591530", Offset = "0x590330", VA = "0x10591530")]
      public void AddCrystalData(CrystalRecommendWindow.RecommendCrystalData _data, bool _is_main = false)
      {
      }

      [Token(Token = "0x60095A9")]
      [Address(RVA = "0x5916C0", Offset = "0x5904C0", VA = "0x105916C0")]
      public void AddSetBonusParam(
        CrystalRecommendWindow.RecommendSetBonusParam _param)
      {
      }

      [Token(Token = "0x60095AA")]
      [Address(RVA = "0x591AA0", Offset = "0x5908A0", VA = "0x10591AA0")]
      public bool IsLimitOver() => new bool();
    }

    [Token(Token = "0x20022D7")]
    private enum ListSort
    {
      [Token(Token = "0x4009B3E")] TargetValueSort,
      [Token(Token = "0x4009B3F")] LimitAddSort,
      [Token(Token = "0x4009B40")] AllStatusSort,
    }
  }
}
