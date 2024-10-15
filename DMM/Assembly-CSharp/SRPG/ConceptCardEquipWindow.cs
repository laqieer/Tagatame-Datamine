// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEquipWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200220B")]
  [FlowNode.Pin(1010, "真理念装データ取得開始", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(1030, "念装詳細設定完了", FlowNode.PinTypes.Output, 1030)]
  [FlowNode.Pin(1110, "検索：入力", FlowNode.PinTypes.Input, 1110)]
  [FlowNode.Pin(1020, "ウィンドウ閉じる", FlowNode.PinTypes.Output, 1020)]
  [AddComponentMenu("UI/ConceptCardEquipWindow")]
  [FlowNode.Pin(1000, "装備変更", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1120, "検索：タイプ", FlowNode.PinTypes.Input, 1120)]
  [FlowNode.Pin(80, "念装詳細設定", FlowNode.PinTypes.Input, 80)]
  [FlowNode.Pin(40, "OKボタン", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(70, "ソート", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(60, "真理念装データ取得完了", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(50, "外すボタン", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(75, "フィルター", FlowNode.PinTypes.Input, 75)]
  [FlowNode.Pin(30, "念装アイコン選択", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(20, "前のページ", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "次のページ", FlowNode.PinTypes.Input, 10)]
  public class ConceptCardEquipWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400961F")]
    public const int PIN_PAGE_NEXT = 10;
    [Token(Token = "0x4009620")]
    public const int PIN_PAGE_BACK = 20;
    [Token(Token = "0x4009621")]
    public const int PIN_CARD_SELECT_ICON = 30;
    [Token(Token = "0x4009622")]
    public const int PIN_CLICK_OK = 40;
    [Token(Token = "0x4009623")]
    public const int PIN_CLICK_RELEASE = 50;
    [Token(Token = "0x4009624")]
    public const int PIN_END_REQUEST_CARD_DATAS = 60;
    [Token(Token = "0x4009625")]
    public const int PIN_SORT_DATAS = 70;
    [Token(Token = "0x4009626")]
    public const int PIN_FILTER_DATAS = 75;
    [Token(Token = "0x4009627")]
    public const int PIN_SET_DETAIL_DATA = 80;
    [Token(Token = "0x4009628")]
    public const int PIN_CHANGE_EQUIP = 1000;
    [Token(Token = "0x4009629")]
    public const int PIN_START_REQUEST_CARD_DATAS = 1010;
    [Token(Token = "0x400962A")]
    public const int PIN_CLOSE_WINDOW = 1020;
    [Token(Token = "0x400962B")]
    public const int PIN_SET_DETAIL_DATA_END = 1030;
    [Token(Token = "0x400962C")]
    private const int PIN_INPUT_NAME_SEARCH_INPUT = 1110;
    [Token(Token = "0x400962D")]
    private const int PIN_INPUT_NAME_SEARCH_TYPE = 1120;
    [Token(Token = "0x400962E")]
    [FieldOffset(Offset = "0x0")]
    private static ConceptCardEquipWindow _instance;
    [Token(Token = "0x400962F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mIgnoreEquipedConceptCardToggle;
    [Token(Token = "0x4009630")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardIcon mIcon;
    [Token(Token = "0x4009631")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mName;
    [Token(Token = "0x4009632")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mLvText;
    [Token(Token = "0x4009633")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mLvMaxText;
    [Token(Token = "0x4009634")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mExpText;
    [Token(Token = "0x4009635")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Slider mExpSlider;
    [Token(Token = "0x4009636")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StatusList mStatus;
    [Token(Token = "0x4009637")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text SortText;
    [Token(Token = "0x4009638")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mParamViewObject;
    [Token(Token = "0x4009639")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mEmptyParamViewObject;
    [Token(Token = "0x400963A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mTrustObject;
    [Token(Token = "0x400963B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mTrustText;
    [Token(Token = "0x400963C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ImageArray FilterBgImages;
    [Token(Token = "0x400963D")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Outline FilterTextOutLine;
    [Token(Token = "0x400963E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Color32 FilterTextOutColorOff;
    [Token(Token = "0x400963F")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Color32 FilterTextOutColorOn;
    [Token(Token = "0x4009640")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ConceptCardEquipScrollList mConceptCardEquipScrollList;
    [Token(Token = "0x4009641")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button ButtonAutoEquip;
    [Token(Token = "0x4009642")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button SelectButton;
    [Token(Token = "0x4009643")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject DecreaseEffectObject;
    [Token(Token = "0x4009644")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text DecreaseEffectText;
    [Token(Token = "0x4009645")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject SubslotBadge;
    [Token(Token = "0x4009646")]
    [FieldOffset(Offset = "0x68")]
    private BaseStatus mBaseAdd;
    [Token(Token = "0x4009647")]
    [FieldOffset(Offset = "0x6C")]
    private BaseStatus mBaseMul;
    [Token(Token = "0x4009648")]
    [FieldOffset(Offset = "0x70")]
    private BaseStatus mUnitAdd;
    [Token(Token = "0x4009649")]
    [FieldOffset(Offset = "0x74")]
    private BaseStatus mUnitMul;
    [Token(Token = "0x400964A")]
    [FieldOffset(Offset = "0x78")]
    private bool IsInitalized;
    [Token(Token = "0x400964B")]
    [FieldOffset(Offset = "0x7C")]
    private FlowNode_ReqConceptCardSet mFlownodeReqConceptCardSet;
    [Token(Token = "0x400964C")]
    [FieldOffset(Offset = "0x80")]
    private ConceptCardData mSelectedCardData;
    [Token(Token = "0x400964D")]
    [FieldOffset(Offset = "0x84")]
    private UnitData mSelectedUnit;
    [Token(Token = "0x400964E")]
    [FieldOffset(Offset = "0x88")]
    private int mSelectedCardIndex;
    [Token(Token = "0x400964F")]
    [FieldOffset(Offset = "0x8C")]
    private List<ConceptCardData> mOtherSlotCards;
    [Token(Token = "0x4009650")]
    [FieldOffset(Offset = "0x90")]
    public ConceptCardListSortWindow.Type SortType;
    [Token(Token = "0x4009651")]
    [FieldOffset(Offset = "0x94")]
    public ConceptCardListSortWindow.Type SortOrderType;
    [Token(Token = "0x4009652")]
    [FieldOffset(Offset = "0x98")]
    public Action OnCancelAction;
    [Token(Token = "0x4009653")]
    [FieldOffset(Offset = "0x9C")]
    public Action OnChangeAction;
    [Token(Token = "0x4009654")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string NAME_SEARCH_SELECT_UI_PATH;
    [Token(Token = "0x4009655")]
    [FieldOffset(Offset = "0xA0")]
    private string mNameSearchInput;
    [Token(Token = "0x4009656")]
    [FieldOffset(Offset = "0xA4")]
    private SearchUtility.CONDITIONS mNameSearchType;
    [Token(Token = "0x4009657")]
    [FieldOffset(Offset = "0x8")]
    private static NameSearchBox mNameSearchBox;
    [Token(Token = "0x4009658")]
    [FieldOffset(Offset = "0xA8")]
    [HeaderBar("検索ボックス")]
    [SerializeField]
    private GameObject mNameBoxParent;

    [Token(Token = "0x17001461")]
    public static ConceptCardEquipWindow Instance
    {
      [Token(Token = "0x600902B"), Address(RVA = "0x538B40", Offset = "0x537940", VA = "0x10538B40")] get
      {
        return (ConceptCardEquipWindow) null;
      }
    }

    [Token(Token = "0x17001462")]
    public UnitData SelectedUnit
    {
      [Token(Token = "0x600902C"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001463")]
    public int SelectedCardIndex
    {
      [Token(Token = "0x600902D"), Address(RVA = "0x2B6030", Offset = "0x2B4E30", VA = "0x102B6030")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600902E")]
    [Address(RVA = "0x536660", Offset = "0x535460", VA = "0x10536660")]
    private void Awake()
    {
    }

    [Token(Token = "0x600902F")]
    [Address(RVA = "0x538940", Offset = "0x537740", VA = "0x10538940")]
    private void Start()
    {
    }

    [Token(Token = "0x6009030")]
    [Address(RVA = "0x537B20", Offset = "0x536920", VA = "0x10537B20")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009031")]
    [Address(RVA = "0x536220", Offset = "0x535020", VA = "0x10536220", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009032")]
    [Address(RVA = "0x538970", Offset = "0x537770", VA = "0x10538970")]
    private void Update()
    {
    }

    [Token(Token = "0x6009033")]
    [Address(RVA = "0x537840", Offset = "0x536640", VA = "0x10537840")]
    public void Init(UnitData unit, int selectedCardIndex)
    {
    }

    [Token(Token = "0x6009034")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void PageNext()
    {
    }

    [Token(Token = "0x6009035")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void PageBack()
    {
    }

    [Token(Token = "0x6009036")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void RefreshPageText()
    {
    }

    [Token(Token = "0x6009037")]
    [Address(RVA = "0x537F50", Offset = "0x536D50", VA = "0x10537F50")]
    private void RefreshSortFilterObjects()
    {
    }

    [Token(Token = "0x6009038")]
    [Address(RVA = "0x537CA0", Offset = "0x536AA0", VA = "0x10537CA0")]
    public void RefreshSelectedCard(ConceptCardIcon selecIcon)
    {
    }

    [Token(Token = "0x6009039")]
    [Address(RVA = "0x5380C0", Offset = "0x536EC0", VA = "0x105380C0")]
    private void SelectCardIcon()
    {
    }

    [Token(Token = "0x600903A")]
    [Address(RVA = "0x5381A0", Offset = "0x536FA0", VA = "0x105381A0")]
    private void SetParam(ConceptCardData card_data, UnitData unit, int job_index)
    {
    }

    [Token(Token = "0x600903B")]
    [Address(RVA = "0x538160", Offset = "0x536F60", VA = "0x10538160")]
    private void SetActiveParamViewObject(bool is_empty)
    {
    }

    [Token(Token = "0x600903C")]
    [Address(RVA = "0x536860", Offset = "0x535660", VA = "0x10536860")]
    private void ClickOKButton()
    {
    }

    [Token(Token = "0x600903D")]
    [Address(RVA = "0x5360B0", Offset = "0x534EB0", VA = "0x105360B0")]
    private void AcceptEquipConceptCard(GameObject obj)
    {
    }

    [Token(Token = "0x600903E")]
    [Address(RVA = "0x536840", Offset = "0x535640", VA = "0x10536840")]
    private void CancelEquipConceptCard(GameObject obj)
    {
    }

    [Token(Token = "0x600903F")]
    [Address(RVA = "0x536D70", Offset = "0x535B70", VA = "0x10536D70")]
    private void ClickReleaseButton()
    {
    }

    [Token(Token = "0x6009040")]
    [Address(RVA = "0x538920", Offset = "0x537720", VA = "0x10538920")]
    private void StartRequestConceptCardDatas()
    {
    }

    [Token(Token = "0x6009041")]
    [Address(RVA = "0x537210", Offset = "0x536010", VA = "0x10537210")]
    private void EndRequestConceptCardDatas()
    {
    }

    [Token(Token = "0x6009042")]
    [Address(RVA = "0x538860", Offset = "0x537660", VA = "0x10538860")]
    public void SetSortName()
    {
    }

    [Token(Token = "0x6009043")]
    [Address(RVA = "0x5387D0", Offset = "0x5375D0", VA = "0x105387D0")]
    public void SetSelectedCardIcon(ConceptCardIcon card_icon)
    {
    }

    [Token(Token = "0x6009044")]
    [Address(RVA = "0x537A40", Offset = "0x536840", VA = "0x10537A40")]
    public void OnChangeIgnoreEquipedCardToggle(bool isOn)
    {
    }

    [Token(Token = "0x17001464")]
    public string NameSearchInput
    {
      [Token(Token = "0x6009045"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001465")]
    public SearchUtility.CONDITIONS NameSearchType
    {
      [Token(Token = "0x6009046"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return new SearchUtility.CONDITIONS();
      }
    }

    [Token(Token = "0x6009047")]
    [Address(RVA = "0x536F50", Offset = "0x535D50", VA = "0x10536F50")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x6009048")]
    [Address(RVA = "0x5370E0", Offset = "0x535EE0", VA = "0x105370E0")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x6009049")]
    [Address(RVA = "0x5376D0", Offset = "0x5364D0", VA = "0x105376D0")]
    public void GetNameSearchString()
    {
    }

    [Token(Token = "0x600904A")]
    [Address(RVA = "0x537790", Offset = "0x536590", VA = "0x10537790")]
    public void GetNameSearchType()
    {
    }

    [Token(Token = "0x600904B")]
    [Address(RVA = "0x538A10", Offset = "0x537810", VA = "0x10538A10")]
    public ConceptCardEquipWindow()
    {
    }

    [Token(Token = "0x600904C")]
    [Address(RVA = "0x538990", Offset = "0x537790", VA = "0x10538990")]
    static ConceptCardEquipWindow()
    {
    }
  }
}
