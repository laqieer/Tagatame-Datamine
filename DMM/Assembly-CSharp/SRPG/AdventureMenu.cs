// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FA4")]
  [FlowNode.Pin(122, "派遣開始", FlowNode.PinTypes.Output, 122)]
  [FlowNode.Pin(123, "お任せ派遣開始確認", FlowNode.PinTypes.Output, 123)]
  [FlowNode.Pin(124, "お任せ編成で開始不可", FlowNode.PinTypes.Output, 124)]
  [FlowNode.Pin(125, "お任せ編成開始", FlowNode.PinTypes.Output, 125)]
  [FlowNode.Pin(131, "派遣完了通信へ", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(133, "出撃できるエリアが増えたとき", FlowNode.PinTypes.Output, 133)]
  [FlowNode.Pin(134, "出撃できるパーティが増えたとき", FlowNode.PinTypes.Output, 134)]
  [FlowNode.Pin(141, "パーティ設定を保存して閉じる", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(142, "メニューポップアップを閉じる", FlowNode.PinTypes.Output, 142)]
  [AddComponentMenu("UI/Adventure/AdventureMenu")]
  [FlowNode.Pin(121, "AP不足", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(112, "ユニットリスト閉じる", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(135, "派遣完了時の演出終了", FlowNode.PinTypes.Output, 135)]
  [FlowNode.Pin(101, "操作可能", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "初回表示処理", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "ユニットリスト開く", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "状態更新", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(11, "ユニット選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "ユニットを外す", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(21, "派遣開始", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(132, "図鑑表示演出へ", FlowNode.PinTypes.Output, 132)]
  [FlowNode.Pin(23, "お任せ派遣開始", FlowNode.PinTypes.Input, 23)]
  [FlowNode.Pin(41, "閉じるボタンクリック", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(51, "演出スキップボタンクリック", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(22, "お任せ派遣ボタンクリック", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(31, "派遣完了通信前処理", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(32, "派遣完了演出前処理", FlowNode.PinTypes.Input, 32)]
  [FlowNode.Pin(33, "派遣完了演出中", FlowNode.PinTypes.Input, 33)]
  public class AdventureMenu : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x40085AD")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x40085AE")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x40085AF")]
    private const int PIN_INPUT_CHANGE_STATE = 3;
    [Token(Token = "0x40085B0")]
    private const int PIN_INPUT_UNIT_SELECT = 11;
    [Token(Token = "0x40085B1")]
    private const int PIN_INPUT_UNIT_REMOVE = 12;
    [Token(Token = "0x40085B2")]
    private const int PIN_INPUT_ADVENTURE_START = 21;
    [Token(Token = "0x40085B3")]
    private const int PIN_INPUT_RECOMMEND_BUTTON = 22;
    [Token(Token = "0x40085B4")]
    private const int PIN_INPUT_RECOMMEND_START = 23;
    [Token(Token = "0x40085B5")]
    private const int PIN_INPUT_ADVENTURE_END = 31;
    [Token(Token = "0x40085B6")]
    private const int PIN_INPUT_ADVENTURE_END_EFFECT = 32;
    [Token(Token = "0x40085B7")]
    private const int PIN_INPUT_ADVENTURE_END_EFFECT_NEXT = 33;
    [Token(Token = "0x40085B8")]
    private const int PIN_INPUT_MENU_CLOSE = 41;
    [Token(Token = "0x40085B9")]
    private const int PIN_INPUT_ADVENTURE_SKIPMOVIE_BUTTON = 51;
    [Token(Token = "0x40085BA")]
    private const int PIN_OUTPUT_RAYCAST_ON = 101;
    [Token(Token = "0x40085BB")]
    private const int PIN_OUTPUT_UNIT_LIST_OPEN = 111;
    [Token(Token = "0x40085BC")]
    private const int PIN_OUTPUT_UNIT_LIST_CLOSE = 112;
    [Token(Token = "0x40085BD")]
    private const int PIN_OUTPUT_AP_NOT_ENOUGH = 121;
    [Token(Token = "0x40085BE")]
    private const int PIN_OUTPUT_START = 122;
    [Token(Token = "0x40085BF")]
    private const int PIN_OUTPUT_RECOMMEND_PARTY_START_CHECK = 123;
    [Token(Token = "0x40085C0")]
    private const int PIN_OUTPUT_RECOMMEND_PARTY_NOT_START = 124;
    [Token(Token = "0x40085C1")]
    private const int PIN_OUTPUT_RECOMMENC_PARTY_START = 125;
    [Token(Token = "0x40085C2")]
    private const int PIN_OUTPUT_END_CONNECT = 131;
    [Token(Token = "0x40085C3")]
    private const int PIN_OUTPUT_OPEN_PICTURE = 132;
    [Token(Token = "0x40085C4")]
    private const int PIN_OUTPUT_ADD_AREA = 133;
    [Token(Token = "0x40085C5")]
    private const int PIN_OUTPUT_ADD_PARTY = 134;
    [Token(Token = "0x40085C6")]
    private const int PIN_OUTPUT_END_EFFECT_END = 135;
    [Token(Token = "0x40085C7")]
    private const int PIN_OUTPUT_SAVE_PARTY = 141;
    [Token(Token = "0x40085C8")]
    private const int PIN_OUTPUT_MENU_CLOSE = 142;
    [Token(Token = "0x40085C9")]
    private const string ADVENTURE_SVB_KEY_SAME_UNIT = "same_unit";
    [Token(Token = "0x40085CA")]
    private const string ADVENTURE_SVB_KEY_UNIT_EMPTY = "empty";
    [Token(Token = "0x40085CB")]
    private const string ADVENTURE_SVB_KEY_UNIT_INFO_ROOT = "unit_info_root";
    [Token(Token = "0x40085CC")]
    private const string ADVENTURE_SVB_KEY_UNIT_COMBAT_POWER = "combat_power";
    [Token(Token = "0x40085CD")]
    private const string ADVENTURE_SVB_KEY_DISPATCHED = "dispatched";
    [Token(Token = "0x40085CE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text AdventureAreaNameText;
    [Token(Token = "0x40085CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AdventureLevelText;
    [Token(Token = "0x40085D0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image AdventureAreaIcon;
    [Token(Token = "0x40085D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject AdventureStartObj;
    [Token(Token = "0x40085D2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject AdventureNowObj;
    [Token(Token = "0x40085D3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject AdventureEndObj;
    [Token(Token = "0x40085D4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private AdventureSlot UnitTempleateObj;
    [Token(Token = "0x40085D5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SerializeValueBehaviour SVBParty;
    [Token(Token = "0x40085D6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text PartyCombatPowerText;
    [Token(Token = "0x40085D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AdventureCond CondTempleateObj;
    [Token(Token = "0x40085D8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private AdventureCost CostItemTempleateObj;
    [Token(Token = "0x40085D9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AdventureCost CostApTempleateObj;
    [Token(Token = "0x40085DA")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button StartButton;
    [Token(Token = "0x40085DB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button RecommendButton;
    [Token(Token = "0x40085DC")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text AdventureTimeText;
    [Token(Token = "0x40085DD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text AdventureEndTimeText;
    [Token(Token = "0x40085DE")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject CostDisplayObj;
    [Token(Token = "0x40085DF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private SerializeValueBehaviour SVBOther;
    [Token(Token = "0x40085E0")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private bool IsUnitEquipChange;
    [Token(Token = "0x40085E1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject HelpButtonObj;
    [Token(Token = "0x40085E2")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject PartyCombatPowerObj;
    [Token(Token = "0x40085E3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private float UnitChangeAnimDelay;
    [Token(Token = "0x40085E4")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Animator DispatchedAnim;
    [Token(Token = "0x40085E5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private string DispatchedAnimTriggerName;
    [Token(Token = "0x40085E6")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Toggle ToggleSkipMovie;
    [Token(Token = "0x40085E7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text Text_ToggleSkipMovie;
    [Token(Token = "0x40085E8")]
    [FieldOffset(Offset = "0x74")]
    private AdventureCondParam mCondParam;
    [Token(Token = "0x40085E9")]
    [FieldOffset(Offset = "0x78")]
    private List<UnitData> mDispatchedUnitList;
    [Token(Token = "0x40085EA")]
    [FieldOffset(Offset = "0x7C")]
    private UnitListRootWindow.ListData mListData;
    [Token(Token = "0x40085EB")]
    [FieldOffset(Offset = "0x80")]
    private UnitListRootWindow.TabRegister mRegister;
    [Token(Token = "0x40085EC")]
    [FieldOffset(Offset = "0x84")]
    private AdventureCostParam mCostParam;
    [Token(Token = "0x40085ED")]
    [FieldOffset(Offset = "0x88")]
    private AdventureAreaManager mAreaManager;
    [Token(Token = "0x40085EE")]
    [FieldOffset(Offset = "0x8C")]
    private AdventureData mData;
    [Token(Token = "0x40085EF")]
    [FieldOffset(Offset = "0x90")]
    private PartyData mPartyData;
    [Token(Token = "0x40085F0")]
    [FieldOffset(Offset = "0x94")]
    private PartyEditData mPartyEditData;
    [Token(Token = "0x40085F1")]
    [FieldOffset(Offset = "0x98")]
    private eAdventureStatus mAdventureStatus;
    [Token(Token = "0x40085F2")]
    [FieldOffset(Offset = "0x9C")]
    private List<PartyEditData> mPartyEditDataList;
    [Token(Token = "0x40085F3")]
    [FieldOffset(Offset = "0xA0")]
    private List<AdventureSlot> mCurrentUnitObjList;
    [Token(Token = "0x40085F4")]
    [FieldOffset(Offset = "0xA4")]
    private int mAllCombatPower;
    [Token(Token = "0x40085F5")]
    [FieldOffset(Offset = "0xA8")]
    private List<AdventureCond> mCondObjList;
    [Token(Token = "0x40085F6")]
    [FieldOffset(Offset = "0xAC")]
    private List<AdventureCost> mCostObjList;
    [Token(Token = "0x40085F7")]
    [FieldOffset(Offset = "0xB0")]
    private AdventureRecommend mRecommend;
    [Token(Token = "0x40085F8")]
    [FieldOffset(Offset = "0xB4")]
    private List<UnitData> mRecommendUnitList;
    [Token(Token = "0x40085F9")]
    [FieldOffset(Offset = "0xB8")]
    private Coroutine mTimeUpdate;
    [Token(Token = "0x40085FA")]
    [FieldOffset(Offset = "0xBC")]
    private int mCurrentSlotNum;
    [Token(Token = "0x40085FB")]
    [FieldOffset(Offset = "0xC0")]
    private bool mIsItemClear;
    [Token(Token = "0x40085FC")]
    [FieldOffset(Offset = "0xC1")]
    private bool mIsApClear;
    [Token(Token = "0x40085FD")]
    [FieldOffset(Offset = "0xC4")]
    private List<AdventureData> mPrevAreaList;
    [Token(Token = "0x40085FE")]
    [FieldOffset(Offset = "0xC8")]
    private int mPrevPartyCount;
    [Token(Token = "0x40085FF")]
    [FieldOffset(Offset = "0xCC")]
    private bool mIsOpenBookWindow;
    [Token(Token = "0x4008600")]
    [FieldOffset(Offset = "0xCD")]
    private bool mIsAddArea;
    [Token(Token = "0x4008601")]
    [FieldOffset(Offset = "0xCE")]
    private bool mIsAddParty;

    [Token(Token = "0x170012B9")]
    public AdventureCondParam CondParam
    {
      [Token(Token = "0x600822B"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return (AdventureCondParam) null;
      }
    }

    [Token(Token = "0x170012BA")]
    public List<UnitData> DispatchedUnitList
    {
      [Token(Token = "0x600822C"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x600822D")]
    [Address(RVA = "0x4283A0", Offset = "0x4271A0", VA = "0x104283A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600822E")]
    [Address(RVA = "0x42A8D0", Offset = "0x4296D0", VA = "0x1042A8D0")]
    private void Init()
    {
    }

    [Token(Token = "0x600822F")]
    [Address(RVA = "0x42BB00", Offset = "0x42A900", VA = "0x1042BB00")]
    private void Refresh(bool _start_anim = false)
    {
    }

    [Token(Token = "0x6008230")]
    [Address(RVA = "0x42BA00", Offset = "0x42A800", VA = "0x1042BA00")]
    private void RefreshUI(bool _is_laycast_on = true, bool _is_unit_change_anim = false)
    {
    }

    [Token(Token = "0x6008231")]
    [Address(RVA = "0x42A3C0", Offset = "0x4291C0", VA = "0x1042A3C0")]
    private void CreateUnitListObj()
    {
    }

    [Token(Token = "0x6008232")]
    [Address(RVA = "0x42C720", Offset = "0x42B520", VA = "0x1042C720")]
    private void SetPartyData()
    {
    }

    [Token(Token = "0x6008233")]
    [Address(RVA = "0x42B150", Offset = "0x429F50", VA = "0x1042B150")]
    private void RefreshParty(bool _is_unit_change_anim = false)
    {
    }

    [Token(Token = "0x6008234")]
    [Address(RVA = "0x42C590", Offset = "0x42B390", VA = "0x1042C590")]
    public void SetCurrentSlotNum(int _slot_num)
    {
    }

    [Token(Token = "0x6008235")]
    [Address(RVA = "0x42C190", Offset = "0x42AF90", VA = "0x1042C190")]
    private void SelectUnit()
    {
    }

    [Token(Token = "0x6008236")]
    [Address(RVA = "0x42C120", Offset = "0x42AF20", VA = "0x1042C120")]
    private void RemoveUnit()
    {
    }

    [Token(Token = "0x6008237")]
    [Address(RVA = "0x42C970", Offset = "0x42B770", VA = "0x1042C970")]
    public void SetUnitListData(UnitListRootWindow.ListData _list_data)
    {
    }

    [Token(Token = "0x6008238")]
    [Address(RVA = "0x4299F0", Offset = "0x4287F0", VA = "0x104299F0")]
    private void CreateCondListObj()
    {
    }

    [Token(Token = "0x6008239")]
    [Address(RVA = "0x42AE10", Offset = "0x429C10", VA = "0x1042AE10")]
    private void RefreshCondList()
    {
    }

    [Token(Token = "0x600823A")]
    [Address(RVA = "0x429DD0", Offset = "0x428BD0", VA = "0x10429DD0")]
    private void CreateCostListObj()
    {
    }

    [Token(Token = "0x600823B")]
    [Address(RVA = "0x42AF40", Offset = "0x429D40", VA = "0x1042AF40")]
    private void RefreshCostList()
    {
    }

    [Token(Token = "0x600823C")]
    [Address(RVA = "0x42C420", Offset = "0x42B220", VA = "0x1042C420")]
    private void SetAdventureCostFlag()
    {
    }

    [Token(Token = "0x600823D")]
    [Address(RVA = "0x4291D0", Offset = "0x427FD0", VA = "0x104291D0")]
    private void ChangeInteractableStartButton()
    {
    }

    [Token(Token = "0x600823E")]
    [Address(RVA = "0x429100", Offset = "0x427F00", VA = "0x10429100")]
    private void ChangeInteractableRecommendButton(bool _is_recommend_check = false)
    {
    }

    [Token(Token = "0x600823F")]
    [Address(RVA = "0x4290C0", Offset = "0x427EC0", VA = "0x104290C0")]
    private void AdventureStart()
    {
    }

    [Token(Token = "0x6008240")]
    [Address(RVA = "0x429890", Offset = "0x428690", VA = "0x10429890")]
    private void CreateAdventureRecommendParty()
    {
    }

    [Token(Token = "0x6008241")]
    [Address(RVA = "0x429000", Offset = "0x427E00", VA = "0x10429000")]
    private void AdventureRecommendPartyStart()
    {
    }

    [Token(Token = "0x6008242")]
    [Address(RVA = "0x42C0C0", Offset = "0x42AEC0", VA = "0x1042C0C0")]
    private IEnumerator RemainTimeUpdate() => (IEnumerator) null;

    [Token(Token = "0x6008243")]
    [Address(RVA = "0x42ADF0", Offset = "0x429BF0", VA = "0x1042ADF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008244")]
    [Address(RVA = "0x428F10", Offset = "0x427D10", VA = "0x10428F10")]
    private void AdventureEnd()
    {
    }

    [Token(Token = "0x6008245")]
    [Address(RVA = "0x428B40", Offset = "0x427940", VA = "0x10428B40")]
    private void AdventureEndEffect()
    {
    }

    [Token(Token = "0x6008246")]
    [Address(RVA = "0x428AC0", Offset = "0x4278C0", VA = "0x10428AC0")]
    private void AdventureEndEffectPlay()
    {
    }

    [Token(Token = "0x6008247")]
    [Address(RVA = "0x4296A0", Offset = "0x4284A0", VA = "0x104296A0")]
    private void CloseMenu()
    {
    }

    [Token(Token = "0x6008248")]
    [Address(RVA = "0x42ACC0", Offset = "0x429AC0", VA = "0x1042ACC0")]
    private void OnAdventureSkipMovieButton()
    {
    }

    [Token(Token = "0x6008249")]
    [Address(RVA = "0x42A770", Offset = "0x429570", VA = "0x1042A770", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600824A")]
    [Address(RVA = "0x42CA30", Offset = "0x42B830", VA = "0x1042CA30")]
    public AdventureMenu()
    {
    }
  }
}
