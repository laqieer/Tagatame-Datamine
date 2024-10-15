// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultThumbnailWindow
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
  [Token(Token = "0x2002446")]
  [FlowNode.Pin(200, "BackGachaTop", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "ItemDetail", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "PieceDetail", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "ArtifactDetail", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "ConceptCardDetail", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(105, "RuneDetail", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(106, "CrystalDetail", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(400, "ExtraPopupConfirm", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(300, "ユニット詳細から復帰(簡易演出時)", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(111, "UnitDetailSingle", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(210, "Redraw Confirm", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(51, "Click Card Unit Icon", FlowNode.PinTypes.Input, 211)]
  [FlowNode.Pin(60, "アイコン表示初期化完了", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(59, "アイコン表示初期化完了(ユニット単発の場合))", FlowNode.PinTypes.Output, 59)]
  [FlowNode.Pin(61, "オマケ表示スタート", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(70, "オマケ表示終了", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(71, "Click Bonus(おまけ表示)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(80, "引き直し確定確認", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(81, "引き直し終了", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(82, "引き直し終了", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(50, "Click Icon(アイコン選択)", FlowNode.PinTypes.Input, 210)]
  [FlowNode.Pin(100, "UnitDetail", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(21, "OneMore Exec", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(20, "OneMore Exec", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(90, "Interactable更新(True)", FlowNode.PinTypes.Input, 90)]
  [AddComponentMenu("UI/GachaResultThumbnailWindow")]
  [FlowNode.Pin(551, "引き直し終了(念装分解済)", FlowNode.PinTypes.Output, 551)]
  [FlowNode.Pin(550, "真理念装自動分解表示", FlowNode.PinTypes.Output, 550)]
  [FlowNode.Pin(91, "Interactable更新(False", FlowNode.PinTypes.Input, 91)]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "BackToUnitDetail", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Back Top", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "Back Top", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(500, "おまけ表示アニメーションスキップ", FlowNode.PinTypes.Input, 500)]
  public class GachaResultThumbnailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A462")]
    private const int IN_REFRESH = 0;
    [Token(Token = "0x400A463")]
    private const int IN_BACKTO_UNITDETAIL = 1;
    [Token(Token = "0x400A464")]
    private const int IN_BACK_TOP = 10;
    [Token(Token = "0x400A465")]
    private const int OUT_BACK_TOP = 11;
    [Token(Token = "0x400A466")]
    private const int IN_ONEMORE_GACHA = 20;
    [Token(Token = "0x400A467")]
    private const int OUT_ONEMORE_GACHA = 21;
    [Token(Token = "0x400A468")]
    private const int OUT_UNITDETAIL = 100;
    [Token(Token = "0x400A469")]
    private const int OUT_UNITDETAIL_SINGLE = 111;
    [Token(Token = "0x400A46A")]
    private const int OUT_ITEM_DETAIL = 101;
    [Token(Token = "0x400A46B")]
    private const int OUT_ARTIFACT_DETAIL = 103;
    [Token(Token = "0x400A46C")]
    private const int OUT_CONCEPTCARD_DETAIL = 104;
    [Token(Token = "0x400A46D")]
    private const int OUT_RUNE_DETAIL = 105;
    [Token(Token = "0x400A46E")]
    private const int OUT_CRYSTAL_DETAIL = 106;
    [Token(Token = "0x400A46F")]
    private const int PIN_OT_GACHA_CONFIRM = 210;
    [Token(Token = "0x400A470")]
    private const int PIN_IN_CLICK_ICON = 50;
    [Token(Token = "0x400A471")]
    private const int PIN_IN_CLICK_CARDUNIT_ICON = 51;
    [Token(Token = "0x400A472")]
    private const int PIN_OT_ICON_INITALIZED_UNIT = 59;
    [Token(Token = "0x400A473")]
    private const int PIN_OT_ICON_INITALIZED = 60;
    [Token(Token = "0x400A474")]
    private const int PIN_IN_START_BONUS = 61;
    [Token(Token = "0x400A475")]
    private const int PIN_OT_FINISHED_BONUS = 70;
    [Token(Token = "0x400A476")]
    private const int PIN_IN_CLICK_BONUS = 71;
    [Token(Token = "0x400A477")]
    private const int PIN_OT_CONFIRM_REDRAW = 80;
    [Token(Token = "0x400A478")]
    private const int PIN_IN_CLOSE_REDRAW = 81;
    [Token(Token = "0x400A479")]
    private const int PIN_OT_CLOSE_REDRAW = 82;
    [Token(Token = "0x400A47A")]
    private const int PIN_IN_BTN_INTERACTABLE_TRUE = 90;
    [Token(Token = "0x400A47B")]
    private const int PIN_IN_BTN_INTERACTABLE_FALSE = 91;
    [Token(Token = "0x400A47C")]
    private const int PIN_OT_GACHAWINDOW_ON = 300;
    [Token(Token = "0x400A47D")]
    private const int PIN_IN_EXTRA_POPUPCONFIRM = 400;
    [Token(Token = "0x400A47E")]
    private const int PIN_IN_BONUS_ANIM_SKIP = 500;
    [Token(Token = "0x400A47F")]
    private const int PIN_OT_SHOW_AUTODISASSEMBLY = 550;
    [Token(Token = "0x400A480")]
    private const int PIN_OT_CLOSE_REDRAW_DISASSEMBLY = 551;
    [Token(Token = "0x400A481")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int CONTENT_VIEW_MAX;
    [Token(Token = "0x400A482")]
    private const int BONUS_SCROLL_LIST_NUM = 11;
    [Token(Token = "0x400A483")]
    private const string BONUS_WINDOW_ROOT = "root";
    [Token(Token = "0x400A484")]
    private const string BONUS_WINDOW_ICON = "icon";
    [Token(Token = "0x400A485")]
    private const string BONUS_WINDOW_LIST_ROOT = "list_root";
    [Token(Token = "0x400A486")]
    private const string BONUS_WINDOW_LIST_PARENT = "list_parent";
    [Token(Token = "0x400A487")]
    private const string BONUS_WINDOW_LIST_ICON = "list_icon";
    [Token(Token = "0x400A488")]
    private const string BONUS_WINDOW_SINGLE_MSG = "single_msg";
    [Token(Token = "0x400A489")]
    private const string BONUS_WINDOW_MULTI_MSG = "multi_msg";
    [Token(Token = "0x400A48A")]
    private const string BONUS_WINDOW_ANIM_SKIP_BUTTON = "list_anim_skip_button";
    [Token(Token = "0x400A48B")]
    private const string BONUS_ICON_UNIT = "unit";
    [Token(Token = "0x400A48C")]
    private const string BONUS_ICON_ITEM = "item";
    [Token(Token = "0x400A48D")]
    private const string BONUS_ICON_ARTIFACT = "artifact";
    [Token(Token = "0x400A48E")]
    private const string BONUS_ICON_CONCEPTCARD = "conceptcard";
    [Token(Token = "0x400A48F")]
    private const string BONUS_ICON_CRYSTAL = "crystal";
    [Token(Token = "0x400A490")]
    private const string BONUS_ICON_NEW = "new";
    [Token(Token = "0x400A491")]
    private const string BONUS_MSG_NAME = "name";
    [Token(Token = "0x400A492")]
    private const string BONUS_MSG_VALUE = "value";
    [Token(Token = "0x400A493")]
    [FieldOffset(Offset = "0xC")]
    public GameObject CautionText;
    [Token(Token = "0x400A494")]
    [FieldOffset(Offset = "0x10")]
    private bool is_gift;
    [Token(Token = "0x400A495")]
    [FieldOffset(Offset = "0x11")]
    private bool m_inialize;
    [Token(Token = "0x400A496")]
    [FieldOffset(Offset = "0x12")]
    private bool m_FinishedBonusEffect;
    [Token(Token = "0x400A497")]
    [FieldOffset(Offset = "0x14")]
    private GameObject m_Thumbnail;
    [Token(Token = "0x400A498")]
    [FieldOffset(Offset = "0x18")]
    private GameObject m_UnitDetail;
    [Token(Token = "0x400A499")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject BlockTemplate;
    [Token(Token = "0x400A49A")]
    [FieldOffset(Offset = "0x20")]
    private GameObject m_ResultBlock;
    [Token(Token = "0x400A49B")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> m_ResultIconRootList;
    [Token(Token = "0x400A49C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject DetailRoot;
    [Token(Token = "0x400A49D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private string BonusWindowPrefab;
    [Token(Token = "0x400A49E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float WaitBonusWindow;
    [Token(Token = "0x400A49F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Transform BonusRoot;
    [Token(Token = "0x400A4A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SerializeValueBehaviour ButtonList;
    [Token(Token = "0x400A4A1")]
    [FieldOffset(Offset = "0x3C")]
    private Button m_OnemoreBtn;
    [Token(Token = "0x400A4A2")]
    [FieldOffset(Offset = "0x40")]
    private Button m_DefaultBtn;
    [Token(Token = "0x400A4A3")]
    [FieldOffset(Offset = "0x44")]
    private Button m_BonusBtn;
    [Token(Token = "0x400A4A4")]
    [FieldOffset(Offset = "0x48")]
    private Button m_RedrawBtn;
    [Token(Token = "0x400A4A5")]
    [FieldOffset(Offset = "0x4C")]
    private GachaRequestParam mRequest;
    [Token(Token = "0x400A4A6")]
    [FieldOffset(Offset = "0x50")]
    private bool m_simple;
    [Token(Token = "0x400A4A7")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private string AnimTriggerNameStart;
    [Token(Token = "0x400A4A8")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string AnimStateName_End;
    [Token(Token = "0x400A4A9")]
    [FieldOffset(Offset = "0x5C")]
    private List<UnitParam> mPopupExtraUnitList;
    [Token(Token = "0x400A4AA")]
    [FieldOffset(Offset = "0x60")]
    private List<GachaResultBonusIconParam> mBonusListParam;
    [Token(Token = "0x400A4AB")]
    [FieldOffset(Offset = "0x64")]
    private GameObject mBonusSkipButton;
    [Token(Token = "0x400A4AC")]
    [FieldOffset(Offset = "0x68")]
    private ScrollRectSound mBonusScrollSound;
    [Token(Token = "0x400A4AD")]
    [FieldOffset(Offset = "0x6C")]
    private bool mIsAnimSkipFlag;
    [Token(Token = "0x400A4AE")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int VIEW_COUNT;

    [Token(Token = "0x17001620")]
    public bool IsInialize
    {
      [Token(Token = "0x6009E41"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001621")]
    public bool IsFinishedBonus
    {
      [Token(Token = "0x6009E42"), Address(RVA = "0x610BF0", Offset = "0x60F9F0", VA = "0x10610BF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001622")]
    public bool IsSimple
    {
      [Token(Token = "0x6009E43"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009E44")]
    [Address(RVA = "0x60C900", Offset = "0x60B700", VA = "0x1060C900", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009E45")]
    [Address(RVA = "0x60D0D0", Offset = "0x60BED0", VA = "0x1060D0D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009E46")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009E47")]
    [Address(RVA = "0x60E510", Offset = "0x60D310", VA = "0x1060E510")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009E48")]
    [Address(RVA = "0x60F4E0", Offset = "0x60E2E0", VA = "0x1060F4E0")]
    private void Reset()
    {
    }

    [Token(Token = "0x6009E49")]
    [Address(RVA = "0x60E500", Offset = "0x60D300", VA = "0x1060E500")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009E4A")]
    [Address(RVA = "0x60F370", Offset = "0x60E170", VA = "0x1060F370")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009E4B")]
    [Address(RVA = "0x60DA70", Offset = "0x60C870", VA = "0x1060DA70")]
    private void Initalize()
    {
    }

    [Token(Token = "0x6009E4C")]
    [Address(RVA = "0x610770", Offset = "0x60F570", VA = "0x10610770")]
    public void SetDetailActiveStatus(bool _active)
    {
    }

    [Token(Token = "0x6009E4D")]
    [Address(RVA = "0x60D2E0", Offset = "0x60C0E0", VA = "0x1060D2E0")]
    private void CreateContentList()
    {
    }

    [Token(Token = "0x6009E4E")]
    [Address(RVA = "0x60EE40", Offset = "0x60DC40", VA = "0x1060EE40")]
    private void RefreshResult(
      GachaDropData[] _drops,
      GameObject _block,
      int _block_type,
      bool _is_anim = false)
    {
    }

    [Token(Token = "0x6009E4F")]
    [Address(RVA = "0x60EDB0", Offset = "0x60DBB0", VA = "0x1060EDB0")]
    private void RefreshIcons(bool _active)
    {
    }

    [Token(Token = "0x6009E50")]
    [Address(RVA = "0x610960", Offset = "0x60F760", VA = "0x10610960")]
    private IEnumerator ShowBonus(bool _is_anim = true) => (IEnumerator) null;

    [Token(Token = "0x6009E51")]
    [Address(RVA = "0x60FFB0", Offset = "0x60EDB0", VA = "0x1060FFB0")]
    public void SetBonusIcon(GameObject _object, GachaDropData _data, int _index)
    {
    }

    [Token(Token = "0x6009E52")]
    [Address(RVA = "0x60D0E0", Offset = "0x60BEE0", VA = "0x1060D0E0")]
    private void BonusSkipAnim()
    {
    }

    [Token(Token = "0x6009E53")]
    [Address(RVA = "0x60E630", Offset = "0x60D430", VA = "0x1060E630")]
    private void OnSelectCardUnitIcon()
    {
    }

    [Token(Token = "0x6009E54")]
    [Address(RVA = "0x60E7D0", Offset = "0x60D5D0", VA = "0x1060E7D0")]
    private void OnSelectIcon()
    {
    }

    [Token(Token = "0x6009E55")]
    [Address(RVA = "0x60F7A0", Offset = "0x60E5A0", VA = "0x1060F7A0")]
    private void Select(int index, GachaResultThumbnailWindow.GachaResultType type, bool bonus = false)
    {
    }

    [Token(Token = "0x6009E56")]
    [Address(RVA = "0x60F6A0", Offset = "0x60E4A0", VA = "0x1060F6A0")]
    private bool SelectItem(ItemParam _param) => new bool();

    [Token(Token = "0x6009E57")]
    [Address(RVA = "0x60F570", Offset = "0x60E370", VA = "0x1060F570")]
    private bool SelectArtifact(ArtifactData _data) => new bool();

    [Token(Token = "0x6009E58")]
    [Address(RVA = "0x60F600", Offset = "0x60E400", VA = "0x1060F600")]
    private bool SelectConceptCard(string _iname) => new bool();

    [Token(Token = "0x6009E59")]
    [Address(RVA = "0x60D450", Offset = "0x60C250", VA = "0x1060D450")]
    private ItemData CreateItemData(ItemParam iparam, int num) => (ItemData) null;

    [Token(Token = "0x6009E5A")]
    [Address(RVA = "0x60D1E0", Offset = "0x60BFE0", VA = "0x1060D1E0")]
    private ArtifactData CreateArtifactData(ArtifactParam param, int rarity) => (ArtifactData) null;

    [Token(Token = "0x6009E5B")]
    [Address(RVA = "0x60D4B0", Offset = "0x60C2B0", VA = "0x1060D4B0")]
    private UnitData CreateUnitData(UnitParam uparam) => (UnitData) null;

    [Token(Token = "0x6009E5C")]
    [Address(RVA = "0x60E440", Offset = "0x60D240", VA = "0x1060E440")]
    private bool IsTutorial() => new bool();

    [Token(Token = "0x6009E5D")]
    [Address(RVA = "0x60E310", Offset = "0x60D110", VA = "0x1060E310")]
    private bool IsSingleDropForUnit() => new bool();

    [Token(Token = "0x6009E5E")]
    [Address(RVA = "0x60E2C0", Offset = "0x60D0C0", VA = "0x1060E2C0")]
    private bool IsExistGiftData(GachaDropData[] _data) => new bool();

    [Token(Token = "0x6009E5F")]
    [Address(RVA = "0x60EAF0", Offset = "0x60D8F0", VA = "0x1060EAF0")]
    private void RefreshGachaCostObject(GameObject button)
    {
    }

    [Token(Token = "0x6009E60")]
    [Address(RVA = "0x60D7C0", Offset = "0x60C5C0", VA = "0x1060D7C0")]
    private void InitButton()
    {
    }

    [Token(Token = "0x6009E61")]
    [Address(RVA = "0x60E3C0", Offset = "0x60D1C0", VA = "0x1060E3C0")]
    private bool IsThumbnailActive() => new bool();

    [Token(Token = "0x6009E62")]
    [Address(RVA = "0x60E8A0", Offset = "0x60D6A0", VA = "0x1060E8A0")]
    private void RefreshButtonInteractable(bool _active)
    {
    }

    [Token(Token = "0x6009E63")]
    [Address(RVA = "0x6109D0", Offset = "0x60F7D0", VA = "0x106109D0")]
    private IEnumerator ShowIcons(int pinID, string trigger = "") => (IEnumerator) null;

    [Token(Token = "0x6009E64")]
    [Address(RVA = "0x610950", Offset = "0x60F750", VA = "0x10610950")]
    public void SetSimpleAnimFlag(bool flag = false)
    {
    }

    [Token(Token = "0x6009E65")]
    [Address(RVA = "0x60FF80", Offset = "0x60ED80", VA = "0x1060FF80")]
    private void SendOutputPin(bool is_disassembly)
    {
    }

    [Token(Token = "0x6009E66")]
    [Address(RVA = "0x610A90", Offset = "0x60F890", VA = "0x10610A90")]
    public GachaResultThumbnailWindow()
    {
    }

    [Token(Token = "0x6009E67")]
    [Address(RVA = "0x610A50", Offset = "0x60F850", VA = "0x10610A50")]
    static GachaResultThumbnailWindow()
    {
    }

    [Token(Token = "0x2002447")]
    public enum GachaResultType
    {
      [Token(Token = "0x400A4B0")] None,
      [Token(Token = "0x400A4B1")] Unit,
      [Token(Token = "0x400A4B2")] Item,
      [Token(Token = "0x400A4B3")] Piece,
      [Token(Token = "0x400A4B4")] Artifact,
      [Token(Token = "0x400A4B5")] ConceptCard,
      [Token(Token = "0x400A4B6")] Crystal,
      [Token(Token = "0x400A4B7")] End,
    }
  }
}
