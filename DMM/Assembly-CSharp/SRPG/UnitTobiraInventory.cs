// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D0F")]
  [FlowNode.Pin(2, "扉の開放ボタンクリック", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(201, "共鳴解除通信", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "共鳴ユニット選択画面", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "共鳴アイコンクリック", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1, "扉選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(12, "扉の強化リクエスト", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(102, "共鳴条件表示", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(191, "キャンバスブロック解除", FlowNode.PinTypes.Input, 191)]
  [FlowNode.Pin(190, "キャンバスブロック", FlowNode.PinTypes.Input, 190)]
  [AddComponentMenu("UI/UnitTobiraInventory")]
  [FlowNode.Pin(3, "扉の強化ボタンクリック", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(202, "共鳴Tips表示", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(5, "扉の強化成功", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(0, "表示更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(104, "共鳴解除演出再生", FlowNode.PinTypes.Input, 104)]
  [FlowNode.Pin(100, "扉の一括強化", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(7, "扉の強化画面を閉じる", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(6, "扉の解放成功", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(4, "扉の開放条件詳細クリック", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(11, "扉の開放リクエスト", FlowNode.PinTypes.Output, 21)]
  public class UnitTobiraInventory : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E050")]
    private const int INPUT_TOBIRA_REFRESH = 0;
    [Token(Token = "0x400E051")]
    private const int INPUT_TOBIRA_SELECT = 1;
    [Token(Token = "0x400E052")]
    private const int INPUT_TOBIRA_OPEN = 2;
    [Token(Token = "0x400E053")]
    private const int INPUT_TOBIRA_ENHANCE = 3;
    [Token(Token = "0x400E054")]
    private const int INPUT_TOBIRA_OPEN_DETAIL = 4;
    [Token(Token = "0x400E055")]
    private const int INPUT_TOBIRA_SUCCESS_ENHANCE = 5;
    [Token(Token = "0x400E056")]
    private const int INPUT_TOBIRA_SUCCESS_OPEN = 6;
    [Token(Token = "0x400E057")]
    private const int INPUT_TOBIRA_CLOSE = 7;
    [Token(Token = "0x400E058")]
    private const int INPUT_TOBIRA_MAX_ENHANCE = 100;
    [Token(Token = "0x400E059")]
    private const int INPUT_RESONANCE_ICON = 101;
    [Token(Token = "0x400E05A")]
    private const int INPUT_RESONANCE_LOCK_MASSAGE = 102;
    [Token(Token = "0x400E05B")]
    private const int INPUT_RESONANCE_RESET_EFFECT = 104;
    [Token(Token = "0x400E05C")]
    private const int INPUT_CANVAS_BLOCK = 190;
    [Token(Token = "0x400E05D")]
    private const int INPUT_CANVAS_BLOCK_RELEASE = 191;
    [Token(Token = "0x400E05E")]
    private const int OUTPUT_TOBIRA_OPEN = 11;
    [Token(Token = "0x400E05F")]
    private const int OUTPUT_TOBIRA_ENHANCE = 12;
    [Token(Token = "0x400E060")]
    private const int OUTPUT_RESONANCE_UNIT_SELECT_WINDOW = 200;
    [Token(Token = "0x400E061")]
    private const int OUTPUT_RESONANCE_RELEASE = 201;
    [Token(Token = "0x400E062")]
    private const int OUTPUT_RESONANCE_TIPS = 202;
    [Token(Token = "0x400E063")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string PREFAB_PATH_TOBIRA_ENHANCE_WINDOW;
    [Token(Token = "0x400E064")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject UnitAttachTarget;
    [Token(Token = "0x400E065")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject TobiraTemplate;
    [Token(Token = "0x400E066")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitTobiraParamWindow TobiraParamWindow;
    [Token(Token = "0x400E067")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private CanvasGroup MyCanvas;
    [Token(Token = "0x400E068")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject TobiraEnhMaxBtn;
    [Token(Token = "0x400E069")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ExhibitList TobiraInventoryExhibitList;
    [Token(Token = "0x400E06A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private float resonanceResetDelay;
    [Token(Token = "0x400E06B")]
    [FieldOffset(Offset = "0x2C")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400E06C")]
    [FieldOffset(Offset = "0x30")]
    private UnitTobiraInventoryModel unitTobiraInventoryModel;
    [Token(Token = "0x400E06D")]
    [FieldOffset(Offset = "0x34")]
    private TobiraData mCurrentTobira;
    [Token(Token = "0x400E06E")]
    [FieldOffset(Offset = "0x38")]
    private List<UnitTobiraItem> mTobiraList;
    [Token(Token = "0x400E06F")]
    [FieldOffset(Offset = "0x3C")]
    private List<TobiraEnhanceMaxItemParam> mTobiraMaxItemParams;
    [Token(Token = "0x400E070")]
    [FieldOffset(Offset = "0x40")]
    private List<ItemData> mItemDataList;
    [Token(Token = "0x400E071")]
    [FieldOffset(Offset = "0x44")]
    private SerializeValueList valueList;
    [Token(Token = "0x400E072")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsDispEnhItemListBtn;
    [Token(Token = "0x400E073")]
    [FieldOffset(Offset = "0x4C")]
    private UnitTobiraEnhanceWindow2 mTobiraEnhanceWindow;
    [Token(Token = "0x400E074")]
    [FieldOffset(Offset = "0x50")]
    private TobiraParam.Category mSelectedTobiraCategory;
    [Token(Token = "0x400E075")]
    [FieldOffset(Offset = "0x0")]
    private static long mInitTimeUniqueID;
    [Token(Token = "0x400E076")]
    [FieldOffset(Offset = "0x8")]
    private static UnitTobiraInventory mInstance;

    [Token(Token = "0x17001B85")]
    public static long InitTimeUniqueID
    {
      [Token(Token = "0x600D1C5"), Address(RVA = "0x9D1030", Offset = "0x9CFE30", VA = "0x109D1030")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001B86")]
    public static UnitTobiraInventory Instance
    {
      [Token(Token = "0x600D1C6"), Address(RVA = "0x9D1060", Offset = "0x9CFE60", VA = "0x109D1060")] get
      {
        return (UnitTobiraInventory) null;
      }
    }

    [Token(Token = "0x17001B87")]
    public UnitData CurrentUnit
    {
      [Token(Token = "0x600D1C7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001B88")]
    public List<ItemData> UsableItemList
    {
      [Token(Token = "0x600D1C8"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (List<ItemData>) null;
      }
    }

    [Token(Token = "0x600D1C9")]
    [Address(RVA = "0x9CEDF0", Offset = "0x9CDBF0", VA = "0x109CEDF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D1CA")]
    [Address(RVA = "0x9CF330", Offset = "0x9CE130", VA = "0x109CF330")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D1CB")]
    [Address(RVA = "0x9D0CE0", Offset = "0x9CFAE0", VA = "0x109D0CE0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D1CC")]
    [Address(RVA = "0x9CEEB0", Offset = "0x9CDCB0", VA = "0x109CEEB0")]
    public void Init(bool is_restore)
    {
    }

    [Token(Token = "0x600D1CD")]
    [Address(RVA = "0x9CF8F0", Offset = "0x9CE6F0", VA = "0x109CF8F0")]
    private bool RefreshCurrentUnit() => new bool();

    [Token(Token = "0x600D1CE")]
    [Address(RVA = "0x9CF860", Offset = "0x9CE660", VA = "0x109CF860")]
    private void RefreshAll()
    {
    }

    [Token(Token = "0x600D1CF")]
    [Address(RVA = "0x9CFDC0", Offset = "0x9CEBC0", VA = "0x109CFDC0")]
    private void RefreshStatus()
    {
    }

    [Token(Token = "0x600D1D0")]
    [Address(RVA = "0x9D0730", Offset = "0x9CF530", VA = "0x109D0730")]
    private void ResetSelectedUnitUniqueID()
    {
    }

    [Token(Token = "0x600D1D1")]
    [Address(RVA = "0x9CFAA0", Offset = "0x9CE8A0", VA = "0x109CFAA0")]
    private void RefreshSelected()
    {
    }

    [Token(Token = "0x600D1D2")]
    [Address(RVA = "0x9CFA40", Offset = "0x9CE840", VA = "0x109CFA40")]
    private void RefreshInventoryExhibit()
    {
    }

    [Token(Token = "0x600D1D3")]
    [Address(RVA = "0x9D00A0", Offset = "0x9CEEA0", VA = "0x109D00A0")]
    private void RefreshTobiraMaxItemState()
    {
    }

    [Token(Token = "0x600D1D4")]
    [Address(RVA = "0x9CF5E0", Offset = "0x9CE3E0", VA = "0x109CF5E0")]
    private void OnTobiraOpenBtn()
    {
    }

    [Token(Token = "0x600D1D5")]
    [Address(RVA = "0x9CF400", Offset = "0x9CE200", VA = "0x109CF400")]
    private void OnTobiraEnhanceBtn()
    {
    }

    [Token(Token = "0x600D1D6")]
    [Address(RVA = "0x9D05F0", Offset = "0x9CF3F0", VA = "0x109D05F0")]
    private void RequestTobiraEnhance()
    {
    }

    [Token(Token = "0x600D1D7")]
    [Address(RVA = "0x9D0E40", Offset = "0x9CFC40", VA = "0x109D0E40")]
    private void SuccessTobiraEnhance()
    {
    }

    [Token(Token = "0x600D1D8")]
    [Address(RVA = "0x9D0E60", Offset = "0x9CFC60", VA = "0x109D0E60")]
    private void SuccessTobiraMaxEnhance()
    {
    }

    [Token(Token = "0x600D1D9")]
    [Address(RVA = "0x9D0E80", Offset = "0x9CFC80", VA = "0x109D0E80")]
    private void SuccessTobiraOpen()
    {
    }

    [Token(Token = "0x600D1DA")]
    [Address(RVA = "0x9CF2B0", Offset = "0x9CE0B0", VA = "0x109CF2B0")]
    private void OnClickResonanceIcon()
    {
    }

    [Token(Token = "0x600D1DB")]
    [Address(RVA = "0x9D07C0", Offset = "0x9CF5C0", VA = "0x109D07C0")]
    private void ResonanceLockMassage()
    {
    }

    [Token(Token = "0x600D1DC")]
    [Address(RVA = "0x9D0850", Offset = "0x9CF650", VA = "0x109D0850")]
    private void ResonanceReleaseWindow()
    {
    }

    [Token(Token = "0x600D1DD")]
    [Address(RVA = "0x9CE670", Offset = "0x9CD470", VA = "0x109CE670", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D1DE")]
    [Address(RVA = "0x9CF780", Offset = "0x9CE580", VA = "0x109CF780")]
    private IEnumerator PlayOpenEffect() => (IEnumerator) null;

    [Token(Token = "0x600D1DF")]
    [Address(RVA = "0x9CF710", Offset = "0x9CE510", VA = "0x109CF710")]
    private IEnumerator PlayLevelupEffect(bool isMaxEnhance = false) => (IEnumerator) null;

    [Token(Token = "0x600D1E0")]
    [Address(RVA = "0x9D0D30", Offset = "0x9CFB30", VA = "0x109D0D30")]
    private void SuccessResonanceReset()
    {
    }

    [Token(Token = "0x600D1E1")]
    [Address(RVA = "0x9CF7F0", Offset = "0x9CE5F0", VA = "0x109CF7F0")]
    private IEnumerator PlayResonanceResetEffect() => (IEnumerator) null;

    [Token(Token = "0x600D1E2")]
    [Address(RVA = "0x9CEE40", Offset = "0x9CDC40", VA = "0x109CEE40")]
    private void CanvasBlock(bool isValue)
    {
    }

    [Token(Token = "0x600D1E3")]
    [Address(RVA = "0x9D0F30", Offset = "0x9CFD30", VA = "0x109D0F30")]
    public UnitTobiraInventory()
    {
    }
  }
}
