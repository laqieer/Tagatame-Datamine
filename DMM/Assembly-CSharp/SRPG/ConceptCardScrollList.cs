// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardScrollList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200223E")]
  [AddComponentMenu("UI/ConceptCardScrollList")]
  [FlowNode.Pin(6, "アイコン選択", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(51, "選択した", FlowNode.PinTypes.Output, 51)]
  [FlowNode.Pin(11, "一括選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(7, "複数選択を反映", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(10, "フィルタ適用", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(2, "アイコン更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(4, "複数選択を戻す", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "複数選択の登録", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(120, "検索：タイプ", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(1, "選択クリア", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(110, "検索：入力", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(5, "バックアップ作成", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(61, "複数選択を反映した", FlowNode.PinTypes.Output, 61)]
  public class ConceptCardScrollList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40097C8")]
    private const string SAVE_TOGGLE_SELECT_SAME_CARD_KEY = "TOGGLE_SAME_CARD";
    [Token(Token = "0x40097C9")]
    private const string SAVE_TOGGLE_SELECT_FAVARITE_CARD_KEY = "TOGGLE_FAVARITE_CARD";
    [Token(Token = "0x40097CA")]
    public const int PIN_CLEAR = 1;
    [Token(Token = "0x40097CB")]
    public const int PIN_REFRESH = 2;
    [Token(Token = "0x40097CC")]
    public const int PIN_REGIST_MAT = 3;
    [Token(Token = "0x40097CD")]
    public const int PIN_REVERT_MAT = 4;
    [Token(Token = "0x40097CE")]
    public const int PIN_BACKUP_MAT = 5;
    [Token(Token = "0x40097CF")]
    public const int PIN_SELECT_ICON = 6;
    [Token(Token = "0x40097D0")]
    public const int PIN_SELECT_APPLY = 7;
    [Token(Token = "0x40097D1")]
    public const int PIN_FILTER = 10;
    [Token(Token = "0x40097D2")]
    public const int PIN_SELECT_MAX = 11;
    [Token(Token = "0x40097D3")]
    public const int PIN_OUTPUT = 51;
    [Token(Token = "0x40097D4")]
    public const int PIN_OUTPUT_SELECT_APPLY = 61;
    [Token(Token = "0x40097D5")]
    public const int PIN_INPUT_NAME_SEARCH_INPUT = 110;
    [Token(Token = "0x40097D6")]
    public const int PIN_INPUT_NAME_SEARCH_TYPE = 120;
    [Token(Token = "0x40097D7")]
    private const string KEY_ZENNY_LIMIT_OVER = "sys.SELECT_ERROR_ZENNY_LIMIT_OVER";
    [Token(Token = "0x40097D8")]
    private const string KEY_OVER_EXTRARARITY_MATERIAL = "sys.CONCEPTCARD_EXTRA_RARITY_SELECT_WARNING";
    [Token(Token = "0x40097D9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int MAX_MULTI_SELECT;
    [Token(Token = "0x40097DA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject EmptyMessage;
    [Token(Token = "0x40097DB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text SortTypeText;
    [Token(Token = "0x40097DC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray FilterBgImages;
    [Token(Token = "0x40097DD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Outline FilterTextOutLine;
    [Token(Token = "0x40097DE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Color32 FilterTextOutColorOff;
    [Token(Token = "0x40097DF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Color32 FilterTextOutColorOn;
    [Token(Token = "0x40097E0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text CurrSelectedNum;
    [Token(Token = "0x40097E1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text MaxSelectedNum;
    [Token(Token = "0x40097E2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text TextSellZeny;
    [Token(Token = "0x40097E3")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TextSellCoin;
    [Token(Token = "0x40097E4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text TextMixCost;
    [Token(Token = "0x40097E5")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text TextExp;
    [Token(Token = "0x40097E6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text TextTrust;
    [Token(Token = "0x40097E7")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button[] SelectedInteractableButton;
    [Token(Token = "0x40097E8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button SelectMaxButton;
    [Token(Token = "0x40097E9")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text CurrentConceptCardNum;
    [Token(Token = "0x40097EA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text MaxConceptCardNum;
    [Token(Token = "0x40097EB")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Toggle mIgnoreSelectSameConceptCardToggle;
    [Token(Token = "0x40097EC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Toggle mIgnoreFavariteConceptCardToggle;
    [Token(Token = "0x40097ED")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x40097EE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private bool FavoriteCardSelectable;
    [Token(Token = "0x40097EF")]
    [FieldOffset(Offset = "0x61")]
    [SerializeField]
    private bool HasOwnerCardSelectable;
    [Token(Token = "0x40097F0")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject ExtraMixCostRoot;
    [Token(Token = "0x40097F1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text TextExtraMixCost;
    [Token(Token = "0x40097F2")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject SelectExtraPointRoot;
    [Token(Token = "0x40097F3")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text TextCurrentExtraPoint;
    [Token(Token = "0x40097F4")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Text TextMaxExtraPoint;
    [Token(Token = "0x40097F5")]
    [FieldOffset(Offset = "0x78")]
    private List<ConceptCardIconParam> mParams;
    [Token(Token = "0x40097F6")]
    [FieldOffset(Offset = "0x7C")]
    public ConceptCardIconParam mSelectedConceptCardIconParam;
    [Token(Token = "0x40097F7")]
    [FieldOffset(Offset = "0x80")]
    private MultiConceptCard mSelectedConceptCards;
    [Token(Token = "0x40097F8")]
    [FieldOffset(Offset = "0x84")]
    private MultiConceptCard mBackupSelectedMaterials;
    [Token(Token = "0x40097F9")]
    [FieldOffset(Offset = "0x88")]
    private Vector2 mAnchorPosition;
    [Token(Token = "0x40097FA")]
    [FieldOffset(Offset = "0x90")]
    private ConceptCardManager mCCManager;
    [Token(Token = "0x40097FB")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private ConceptCardScrollList.ListType mListType;
    [Token(Token = "0x40097FC")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string NAME_SEARCH_WINDOW_UI_PATH;
    [Token(Token = "0x40097FD")]
    [FieldOffset(Offset = "0x98")]
    private string mNameSearchInput;
    [Token(Token = "0x40097FE")]
    [FieldOffset(Offset = "0x9C")]
    private SearchUtility.CONDITIONS mNameSearchType;
    [Token(Token = "0x40097FF")]
    [FieldOffset(Offset = "0x4")]
    private static NameSearchBox mNameSearchBox;
    [Token(Token = "0x4009800")]
    [FieldOffset(Offset = "0xA0")]
    [HeaderBar("検索ボックス")]
    [SerializeField]
    private GameObject mNameBoxParent;

    [Token(Token = "0x17001485")]
    private ConceptCardManager CCManager
    {
      [Token(Token = "0x60091C8"), Address(RVA = "0x5559A0", Offset = "0x5547A0", VA = "0x105559A0")] get
      {
        return (ConceptCardManager) null;
      }
    }

    [Token(Token = "0x17001486")]
    public bool IsEnahnceList
    {
      [Token(Token = "0x60091C9"), Address(RVA = "0x555A90", Offset = "0x554890", VA = "0x10555A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001487")]
    public bool IsSellList
    {
      [Token(Token = "0x60091CA"), Address(RVA = "0x555AD0", Offset = "0x5548D0", VA = "0x10555AD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001488")]
    public bool IsExtraRarityList
    {
      [Token(Token = "0x60091CB"), Address(RVA = "0x555AB0", Offset = "0x5548B0", VA = "0x10555AB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001489")]
    public bool IsDefaultList
    {
      [Token(Token = "0x60091CC"), Address(RVA = "0x555A70", Offset = "0x554870", VA = "0x10555A70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60091CD")]
    [Address(RVA = "0x5517A0", Offset = "0x5505A0", VA = "0x105517A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60091CE")]
    [Address(RVA = "0x551B00", Offset = "0x550900", VA = "0x10551B00")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60091CF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x60091D0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x60091D1")]
    [Address(RVA = "0x551C30", Offset = "0x550A30", VA = "0x10551C30")]
    public List<ConceptCardData> Filter(List<ConceptCardData> card_list)
    {
      return (List<ConceptCardData>) null;
    }

    [Token(Token = "0x60091D2")]
    [Address(RVA = "0x5523E0", Offset = "0x5511E0", VA = "0x105523E0")]
    public void Init(List<ConceptCardData> card_datas)
    {
    }

    [Token(Token = "0x60091D3")]
    [Address(RVA = "0x553B30", Offset = "0x552930", VA = "0x10553B30")]
    private void RefreshSortFilterObjects(bool reset_position)
    {
    }

    [Token(Token = "0x60091D4")]
    [Address(RVA = "0x554590", Offset = "0x553390", VA = "0x10554590")]
    public void Refresh(List<ConceptCardData> card_datas, bool reset_position = false)
    {
    }

    [Token(Token = "0x60091D5")]
    [Address(RVA = "0x552D50", Offset = "0x551B50", VA = "0x10552D50")]
    private void RefreshConceptCardNum()
    {
    }

    [Token(Token = "0x60091D6")]
    [Address(RVA = "0x5538F0", Offset = "0x5526F0", VA = "0x105538F0")]
    private void RefreshSelectNum()
    {
    }

    [Token(Token = "0x60091D7")]
    [Address(RVA = "0x551100", Offset = "0x54FF00", VA = "0x10551100", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60091D8")]
    [Address(RVA = "0x5526B0", Offset = "0x5514B0", VA = "0x105526B0")]
    private bool IsOverExtraRarityMaterial() => new bool();

    [Token(Token = "0x60091D9")]
    [Address(RVA = "0x553380", Offset = "0x552180", VA = "0x10553380")]
    public void RefreshSelectList()
    {
    }

    [Token(Token = "0x60091DA")]
    [Address(RVA = "0x552350", Offset = "0x551150", VA = "0x10552350")]
    private void IncorporateMultiSelect()
    {
    }

    [Token(Token = "0x60091DB")]
    [Address(RVA = "0x5517B0", Offset = "0x5505B0", VA = "0x105517B0")]
    private void BackupMultiSelect()
    {
    }

    [Token(Token = "0x60091DC")]
    [Address(RVA = "0x553A10", Offset = "0x552810", VA = "0x10553A10")]
    private void RefreshSelected()
    {
    }

    [Token(Token = "0x60091DD")]
    [Address(RVA = "0x5544F0", Offset = "0x5532F0", VA = "0x105544F0")]
    private void RefreshTextSellZeny()
    {
    }

    [Token(Token = "0x60091DE")]
    [Address(RVA = "0x554450", Offset = "0x553250", VA = "0x10554450")]
    private void RefreshTextSellCoin()
    {
    }

    [Token(Token = "0x60091DF")]
    [Address(RVA = "0x5543B0", Offset = "0x5531B0", VA = "0x105543B0")]
    private void RefreshTextMixCost()
    {
    }

    [Token(Token = "0x60091E0")]
    [Address(RVA = "0x553ED0", Offset = "0x552CD0", VA = "0x10553ED0")]
    private void RefreshTextExtraPoint()
    {
    }

    [Token(Token = "0x60091E1")]
    [Address(RVA = "0x554210", Offset = "0x553010", VA = "0x10554210")]
    private void RefreshTextExtraRarityMixCost()
    {
    }

    [Token(Token = "0x60091E2")]
    [Address(RVA = "0x553D80", Offset = "0x552B80", VA = "0x10553D80")]
    private void RefreshTextExpAndTrust()
    {
    }

    [Token(Token = "0x60091E3")]
    [Address(RVA = "0x552E90", Offset = "0x551C90", VA = "0x10552E90")]
    private void RefreshParameter()
    {
    }

    [Token(Token = "0x60091E4")]
    [Address(RVA = "0x552C50", Offset = "0x551A50", VA = "0x10552C50")]
    private void RefreshActiveButtons()
    {
    }

    [Token(Token = "0x60091E5")]
    [Address(RVA = "0x552270", Offset = "0x551070", VA = "0x10552270")]
    private bool GetToggleSameSelect() => new bool();

    [Token(Token = "0x60091E6")]
    [Address(RVA = "0x552A30", Offset = "0x551830", VA = "0x10552A30")]
    public void OnChangeIgnoreSameCardToggle(bool isOn)
    {
    }

    [Token(Token = "0x60091E7")]
    [Address(RVA = "0x555050", Offset = "0x553E50", VA = "0x10555050")]
    private void SaveSameConceptCardToggle()
    {
    }

    [Token(Token = "0x60091E8")]
    [Address(RVA = "0x552190", Offset = "0x550F90", VA = "0x10552190")]
    private bool GetToggleFavarite() => new bool();

    [Token(Token = "0x60091E9")]
    [Address(RVA = "0x5528C0", Offset = "0x5516C0", VA = "0x105528C0")]
    public void OnChangeIgnoreFavariteCardToggle()
    {
    }

    [Token(Token = "0x60091EA")]
    [Address(RVA = "0x554F60", Offset = "0x553D60", VA = "0x10554F60")]
    private void SaveFavariteConceptCardToggle()
    {
    }

    [Token(Token = "0x60091EB")]
    [Address(RVA = "0x551840", Offset = "0x550640", VA = "0x10551840")]
    public void ButtonEventOnClickNode(ConceptCardIconNode node)
    {
    }

    [Token(Token = "0x60091EC")]
    [Address(RVA = "0x555140", Offset = "0x553F40", VA = "0x10555140")]
    private void SetAllSelect()
    {
    }

    [Token(Token = "0x60091ED")]
    [Address(RVA = "0x555460", Offset = "0x554260", VA = "0x10555460")]
    private void SetInteractableSelectMaxButton()
    {
    }

    [Token(Token = "0x1700148A")]
    public string NameSearchInput
    {
      [Token(Token = "0x60091EE"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700148B")]
    public SearchUtility.CONDITIONS NameSearchType
    {
      [Token(Token = "0x60091EF"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return new SearchUtility.CONDITIONS();
      }
    }

    [Token(Token = "0x60091F0")]
    [Address(RVA = "0x551940", Offset = "0x550740", VA = "0x10551940")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x60091F1")]
    [Address(RVA = "0x551B00", Offset = "0x550900", VA = "0x10551B00")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x60091F2")]
    [Address(RVA = "0x552020", Offset = "0x550E20", VA = "0x10552020")]
    public void GetNameSearchString()
    {
    }

    [Token(Token = "0x60091F3")]
    [Address(RVA = "0x5520E0", Offset = "0x550EE0", VA = "0x105520E0")]
    public void GetNameSearchType()
    {
    }

    [Token(Token = "0x60091F4")]
    [Address(RVA = "0x552BC0", Offset = "0x5519C0", VA = "0x10552BC0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60091F5")]
    [Address(RVA = "0x555830", Offset = "0x554630", VA = "0x10555830")]
    public ConceptCardScrollList()
    {
    }

    [Token(Token = "0x60091F6")]
    [Address(RVA = "0x5557C0", Offset = "0x5545C0", VA = "0x105557C0")]
    static ConceptCardScrollList()
    {
    }

    [Token(Token = "0x200223F")]
    public enum ListType : byte
    {
      [Token(Token = "0x4009802")] NONE,
      [Token(Token = "0x4009803")] DEFAULT,
      [Token(Token = "0x4009804")] ENHANCE,
      [Token(Token = "0x4009805")] SELL,
      [Token(Token = "0x4009806")] EXTRARARITY,
    }
  }
}
