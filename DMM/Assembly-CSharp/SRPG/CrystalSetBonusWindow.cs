// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022E6")]
  [FlowNode.Pin(201, "データエラー", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(10, "絞り込み展開", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class CrystalSetBonusWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009B77")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009B78")]
    private const int PIN_INPUT_FILTER = 10;
    [Token(Token = "0x4009B79")]
    private const int PIN_OUTPUT_ERROR = 201;
    [Token(Token = "0x4009B7A")]
    public const string KEY_SET_BONUS_TYPE = "KEY_SET_BONUS_TYPE";
    [Token(Token = "0x4009B7B")]
    public const string KEY_CRYSTAL_INAME = "KEY_CRYSTAL_INAME";
    [Token(Token = "0x4009B7C")]
    public const string KEY_UNIT_DATA = "KEY_UNIT_DATA";
    [Token(Token = "0x4009B7D")]
    public const string KEY_SLOT_NO = "KEY_SLOT_NO";
    [Token(Token = "0x4009B7E")]
    public const string KEY_IS_FILTER_SHOW = "KEY_IS_FILTER_SHOW";
    [Token(Token = "0x4009B7F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int mWindowCorrectionHight;
    [Token(Token = "0x4009B80")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mWindowsTransform;
    [Token(Token = "0x4009B81")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x4009B82")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mSearchFilterBtns;
    [Token(Token = "0x4009B83")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray mFilterBtn;
    [Token(Token = "0x4009B84")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageArray mSearchBtn;
    [Token(Token = "0x4009B85")]
    [FieldOffset(Offset = "0x24")]
    private List<CrystalSetBonusWindowModel> mModels;
    [Token(Token = "0x4009B86")]
    [FieldOffset(Offset = "0x0")]
    public static CrystalSetBonusWindow.ESetBonusType SetBonusType;
    [Token(Token = "0x4009B87")]
    [FieldOffset(Offset = "0x4")]
    public static CrystalParam SelectCrystal;
    [Token(Token = "0x4009B88")]
    [FieldOffset(Offset = "0x8")]
    public static UnitData TargetUnit;
    [Token(Token = "0x4009B89")]
    [FieldOffset(Offset = "0xC")]
    public static CrystalData.ESlotIndex SelectSlot;
    [Token(Token = "0x4009B8A")]
    [FieldOffset(Offset = "0x10")]
    public static bool IsFilterBtnView;
    [Token(Token = "0x4009B8B")]
    [FieldOffset(Offset = "0x11")]
    public static bool IsIconGrayOut;
    [Token(Token = "0x4009B8C")]
    [FieldOffset(Offset = "0x28")]
    private List<CrystalSetBonusParam> mFilterCrystalSetBonusList;
    [Token(Token = "0x4009B90")]
    [FieldOffset(Offset = "0x14")]
    private static CrystalSetBonusWindow mInstance;

    [Token(Token = "0x170014EF")]
    public bool IsFilterAll
    {
      [Token(Token = "0x60095EC"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095ED"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] private set
      {
      }
    }

    [Token(Token = "0x170014F0")]
    public List<CrystalSetBonusFilterCondParam> FilterSelectParams
    {
      [Token(Token = "0x60095EE"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (List<CrystalSetBonusFilterCondParam>) null;
      }
      [Token(Token = "0x60095EF"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
      {
      }
    }

    [Token(Token = "0x170014F1")]
    public List<string> ScerchCrystalInameList
    {
      [Token(Token = "0x60095F0"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60095F1"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
      {
      }
    }

    [Token(Token = "0x170014F2")]
    public static CrystalSetBonusWindow Instance
    {
      [Token(Token = "0x60095F2"), Address(RVA = "0x58D220", Offset = "0x58C020", VA = "0x1058D220")] get
      {
        return (CrystalSetBonusWindow) null;
      }
    }

    [Token(Token = "0x60095F3")]
    [Address(RVA = "0x58D060", Offset = "0x58BE60", VA = "0x1058D060")]
    private void Start()
    {
    }

    [Token(Token = "0x60095F4")]
    [Address(RVA = "0x58C800", Offset = "0x58B600", VA = "0x1058C800")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60095F5")]
    [Address(RVA = "0x58B730", Offset = "0x58A530", VA = "0x1058B730", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60095F6")]
    [Address(RVA = "0x58C750", Offset = "0x58B550", VA = "0x1058C750")]
    public bool IsTargetUnitCrystalSet() => new bool();

    [Token(Token = "0x60095F7")]
    [Address(RVA = "0x58C560", Offset = "0x58B360", VA = "0x1058C560")]
    private void Init()
    {
    }

    [Token(Token = "0x60095F8")]
    [Address(RVA = "0x58BEC0", Offset = "0x58ACC0", VA = "0x1058BEC0")]
    private List<CrystalSetBonusParam> GetTargetSetBonusList() => (List<CrystalSetBonusParam>) null;

    [Token(Token = "0x60095F9")]
    [Address(RVA = "0x58CCB0", Offset = "0x58BAB0", VA = "0x1058CCB0")]
    private List<CrystalSetBonusParam> SortSetBonusList(List<CrystalSetBonusParam> set_bonus_list)
    {
      return (List<CrystalSetBonusParam>) null;
    }

    [Token(Token = "0x60095FA")]
    [Address(RVA = "0x58C9B0", Offset = "0x58B7B0", VA = "0x1058C9B0")]
    private void SetData(List<CrystalSetBonusParam> set_bonus_list)
    {
    }

    [Token(Token = "0x60095FB")]
    [Address(RVA = "0x58C870", Offset = "0x58B670", VA = "0x1058C870")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60095FC")]
    [Address(RVA = "0x58CC10", Offset = "0x58BA10", VA = "0x1058CC10")]
    private void SetFilter()
    {
    }

    [Token(Token = "0x60095FD")]
    [Address(RVA = "0x58CBB0", Offset = "0x58B9B0", VA = "0x1058CBB0")]
    public void SetFilterParamTypes(
      List<CrystalSetBonusFilterCondParam> cond_params,
      bool is_all_filter = false)
    {
    }

    [Token(Token = "0x60095FE")]
    [Address(RVA = "0x58CC50", Offset = "0x58BA50", VA = "0x1058CC50")]
    public void SetSearchCrystalInames(List<string> crystal_inames)
    {
    }

    [Token(Token = "0x60095FF")]
    [Address(RVA = "0x58BA50", Offset = "0x58A850", VA = "0x1058BA50")]
    public void CreateTargetSetbonusList()
    {
    }

    [Token(Token = "0x6009600")]
    [Address(RVA = "0x58B790", Offset = "0x58A590", VA = "0x1058B790")]
    private bool CheckFilter(CrystalSetBonusParam set_bonus) => new bool();

    [Token(Token = "0x6009601")]
    [Address(RVA = "0x58D1A0", Offset = "0x58BFA0", VA = "0x1058D1A0")]
    public CrystalSetBonusWindow()
    {
    }

    [Token(Token = "0x6009602")]
    [Address(RVA = "0x58D0F0", Offset = "0x58BEF0", VA = "0x1058D0F0")]
    static CrystalSetBonusWindow()
    {
    }

    [Token(Token = "0x20022E7")]
    public enum ESetBonusType
    {
      [Token(Token = "0x4009B92")] None,
      [Token(Token = "0x4009B93")] MainSubAll,
      [Token(Token = "0x4009B94")] CheckEquipment,
      [Token(Token = "0x4009B95")] CheckSlot,
    }
  }
}
