// Decompiled with JetBrains decompiler
// Type: SRPG.GachaWindow
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
  [Token(Token = "0x2002470")]
  [FlowNode.Pin(102, "Closed", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(210, "ピックアップ選択へ誘導", FlowNode.PinTypes.Output, 210)]
  [AddComponentMenu("UI/GachaWindow")]
  [FlowNode.Pin(200, "召喚結果へ強制遷移", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(180, "3Dモデル表示部分を非表示", FlowNode.PinTypes.Input, 180)]
  [FlowNode.Pin(170, "Tap Event Description", FlowNode.PinTypes.Input, 170)]
  [FlowNode.Pin(160, "Tap Event Detail", FlowNode.PinTypes.Input, 160)]
  [FlowNode.Pin(150, "召喚トップ背景をタップ", FlowNode.PinTypes.Input, 150)]
  [FlowNode.Pin(113, "リフレッシュ完了", FlowNode.PinTypes.Output, 113)]
  [FlowNode.Pin(20, "Refresh(背景更新しない)", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(112, "チケット召喚をキャンセル", FlowNode.PinTypes.Input, 112)]
  [FlowNode.Pin(110, "チケット召喚(単発)を選択", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(999, "WebView起動", FlowNode.PinTypes.Output, 999)]
  [FlowNode.Pin(114, "アイテム召喚(単発)を選択", FlowNode.PinTypes.Output, 114)]
  [FlowNode.Pin(115, "アイテム召喚(単発)を行う", FlowNode.PinTypes.Input, 115)]
  [FlowNode.Pin(116, "アイテム召喚(単発)をキャンセル", FlowNode.PinTypes.Input, 116)]
  [FlowNode.Pin(101, "Opened", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(21, "ピックアップ選択後の召喚実行誘導をリセット", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(100, "ガチャ実行", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(111, "チケット召喚を行う", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(3, "DecisionRedraw", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "ExecFailed", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "GachaConfirm", FlowNode.PinTypes.Input, 0)]
  public class GachaWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A5B2")]
    private const int IN_GACHA_CONFIRM = 10;
    [Token(Token = "0x400A5B3")]
    private const int PIN_OT_TO_RESULT = 200;
    [Token(Token = "0x400A5B4")]
    private const int PIN_IN_DECISION_REDRAW_GACHA = 3;
    [Token(Token = "0x400A5B5")]
    private const int PIN_IN_TAP_GACHA_TOP_BACKGROUND = 150;
    [Token(Token = "0x400A5B6")]
    private const int PIN_IN_TAP_GACHA_DETAIL = 160;
    [Token(Token = "0x400A5B7")]
    private const int PIN_IN_TAP_GACHA_DESCRIPTION = 170;
    [Token(Token = "0x400A5B8")]
    private const int PIN_IN_VISIBLE_PREVIEWS = 180;
    [Token(Token = "0x400A5B9")]
    private const int PIN_OT_MOVE_GACHA_PICKUP_SELECT = 210;
    [Token(Token = "0x400A5BA")]
    private const int PIN_IN_REFRESH_NOT_REFRESH_BG = 20;
    [Token(Token = "0x400A5BB")]
    private const int PIN_IN_RESET_MOVE_GACHAEXEC = 21;
    [Token(Token = "0x400A5BC")]
    private const int PIN_OUTPUT_SINGLE_ITEM = 114;
    [Token(Token = "0x400A5BD")]
    private const int PIN_INPUT_SINGLE_ITEM_EXEC = 115;
    [Token(Token = "0x400A5BE")]
    private const int PIN_INPUT_SINGLE_ITEM_CANCEL = 116;
    [Token(Token = "0x400A5BF")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string GACHA_URL_PREFIX;
    [Token(Token = "0x400A5C0")]
    [FieldOffset(Offset = "0x4")]
    private static readonly float WAIT_SWAP_BG;
    [Token(Token = "0x400A5C1")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string TAB_SPRITES_PATH;
    [Token(Token = "0x400A5C2")]
    [FieldOffset(Offset = "0xC")]
    private static readonly string TEXT_CONFIRM_GACHA_COIN;
    [Token(Token = "0x400A5C3")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string TEXT_COST_GACHA_COIN;
    [Token(Token = "0x400A5C4")]
    [FieldOffset(Offset = "0x14")]
    private static readonly string TEXT_COST_GACHA_PAIDCOIN;
    [Token(Token = "0x400A5C5")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string TEXT_CONFIRM_GACHA_COST_ZERO;
    [Token(Token = "0x400A5C6")]
    [FieldOffset(Offset = "0xC")]
    public GameObject SelectJobIcon;
    [Token(Token = "0x400A5C7")]
    [FieldOffset(Offset = "0x10")]
    public float mWaitSecondsChangeUnitJob;
    [Token(Token = "0x400A5C8")]
    [FieldOffset(Offset = "0x14")]
    public string PickupPreviewParentID;
    [Token(Token = "0x400A5C9")]
    [FieldOffset(Offset = "0x18")]
    public string PickUpPreviewBaseID;
    [Token(Token = "0x400A5CA")]
    [FieldOffset(Offset = "0x1C")]
    public string PickUpCameraID;
    [Token(Token = "0x400A5CB")]
    [FieldOffset(Offset = "0x20")]
    public string BGUnitImageID;
    [Token(Token = "0x400A5CC")]
    private const int SUMMON_COST_COIN = 1;
    [Token(Token = "0x400A5CD")]
    private const int SUMMON_COST_ITEM = 2;
    [Token(Token = "0x400A5CE")]
    private const int DISCOUNT_IMAGE_DEFAULT = 0;
    [Token(Token = "0x400A5CF")]
    private const int DISCOUNT_IMAGE_APPLY = 1;
    [Token(Token = "0x400A5D0")]
    [FieldOffset(Offset = "0x24")]
    private Transform mPreviewParent;
    [Token(Token = "0x400A5D1")]
    [FieldOffset(Offset = "0x28")]
    private GameObject mPreviewBase;
    [Token(Token = "0x400A5D2")]
    [FieldOffset(Offset = "0x2C")]
    private UnityEngine.Camera mPreviewCamera;
    [Token(Token = "0x400A5D3")]
    [FieldOffset(Offset = "0x30")]
    private GachaUnitPreview mCurrentPreview;
    [Token(Token = "0x400A5D4")]
    [FieldOffset(Offset = "0x34")]
    private List<GachaUnitPreview> mPreviewControllers;
    [Token(Token = "0x400A5D5")]
    [FieldOffset(Offset = "0x38")]
    private RawImage mBGUnitImage;
    [Token(Token = "0x400A5D6")]
    [FieldOffset(Offset = "0x3C")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400A5D7")]
    [FieldOffset(Offset = "0x40")]
    private List<UnitData> mPickupUnits;
    [Token(Token = "0x400A5D8")]
    [FieldOffset(Offset = "0x44")]
    private int mCurrentIndex;
    [Token(Token = "0x400A5D9")]
    [FieldOffset(Offset = "0x48")]
    private int mCurrentJobIndex;
    [Token(Token = "0x400A5DA")]
    [FieldOffset(Offset = "0x4C")]
    private StateMachine<GachaWindow> mState;
    [Token(Token = "0x400A5DB")]
    [FieldOffset(Offset = "0x50")]
    private bool mInitialized;
    [Token(Token = "0x400A5DC")]
    [FieldOffset(Offset = "0x51")]
    private bool mChangeUnit;
    [Token(Token = "0x400A5DD")]
    [FieldOffset(Offset = "0x52")]
    private bool mChangeJob;
    [Token(Token = "0x400A5DE")]
    [FieldOffset(Offset = "0x53")]
    private bool mClicked;
    [Token(Token = "0x400A5DF")]
    [FieldOffset(Offset = "0x54")]
    public GameObject ChangeUnitEffectObj;
    [Token(Token = "0x400A5E0")]
    [FieldOffset(Offset = "0x58")]
    public GameObject ChangeArtifactEffectObj;
    [Token(Token = "0x400A5E1")]
    [FieldOffset(Offset = "0x5C")]
    public float ChangeEffectWaitTime;
    [Token(Token = "0x400A5E2")]
    [FieldOffset(Offset = "0x60")]
    public float ChangeUnitWaitEffectTime;
    [Token(Token = "0x400A5E3")]
    [FieldOffset(Offset = "0x64")]
    public float ChangeJobWaitEffectTime;
    [Token(Token = "0x400A5E4")]
    [FieldOffset(Offset = "0x68")]
    public float WaitTimeNextAction;
    [Token(Token = "0x400A5E5")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject UnitEffectObj;
    [Token(Token = "0x400A5E6")]
    [FieldOffset(Offset = "0x70")]
    public GameObject JobEffectObj;
    [Token(Token = "0x400A5E7")]
    [FieldOffset(Offset = "0x74")]
    public GameObject ArtifactEffectObj;
    [Token(Token = "0x400A5E8")]
    [FieldOffset(Offset = "0x78")]
    private RenderTexture mPreviewUnitRT;
    [Token(Token = "0x400A5E9")]
    [FieldOffset(Offset = "0x7C")]
    public RawImage PreviewImage;
    [Token(Token = "0x400A5EA")]
    [FieldOffset(Offset = "0x80")]
    private bool mDesiredPreviewVisibility;
    [Token(Token = "0x400A5EB")]
    [FieldOffset(Offset = "0x81")]
    private bool mUpdatePreviewVisibility;
    [Token(Token = "0x400A5EC")]
    [FieldOffset(Offset = "0x1C")]
    private static GachaWindow mInstance;
    [Token(Token = "0x400A5ED")]
    [FieldOffset(Offset = "0x84")]
    public string PickupPreviewArtifact;
    [Token(Token = "0x400A5EE")]
    [FieldOffset(Offset = "0x88")]
    public GameObject DefaultPanel;
    [Token(Token = "0x400A5EF")]
    [FieldOffset(Offset = "0x8C")]
    public GachaTicketListController TicketPanel;
    [Token(Token = "0x400A5F0")]
    [FieldOffset(Offset = "0x90")]
    public GameObject ButtonPanel;
    [Token(Token = "0x400A5F1")]
    [FieldOffset(Offset = "0x94")]
    public GameObject TabPanel;
    [Token(Token = "0x400A5F2")]
    [FieldOffset(Offset = "0x98")]
    public GameObject OptionPanel;
    [Token(Token = "0x400A5F3")]
    [FieldOffset(Offset = "0x9C")]
    private List<GachaTopParamNew> mGachaListRare;
    [Token(Token = "0x400A5F4")]
    [FieldOffset(Offset = "0xA0")]
    private List<GachaTopParamNew> mGachaListNormal;
    [Token(Token = "0x400A5F5")]
    [FieldOffset(Offset = "0xA4")]
    private List<GachaTopParamNew> mGachaListTicket;
    [Token(Token = "0x400A5F6")]
    [FieldOffset(Offset = "0xA8")]
    private List<GachaTopParamNew> mGachaListArtifact;
    [Token(Token = "0x400A5F7")]
    [FieldOffset(Offset = "0xAC")]
    private List<GachaWindow.GachaTopParamNewGroups> mGachaListSpecials;
    [Token(Token = "0x400A5F8")]
    [FieldOffset(Offset = "0xB0")]
    private List<GachaTopParamNew> mGachaListAll;
    [Token(Token = "0x400A5F9")]
    [FieldOffset(Offset = "0xB4")]
    public GachaTabListItemBase RareTab;
    [Token(Token = "0x400A5FA")]
    [FieldOffset(Offset = "0xB8")]
    public GachaTabListItemBase NormalTab;
    [Token(Token = "0x400A5FB")]
    [FieldOffset(Offset = "0xBC")]
    public GachaTabListItemBase TicketTab;
    [Token(Token = "0x400A5FC")]
    [FieldOffset(Offset = "0xC0")]
    public GachaTabListItemBase ArtifactTab;
    [Token(Token = "0x400A5FD")]
    [FieldOffset(Offset = "0xC4")]
    public GachaTabListItem TabTemplate;
    [Token(Token = "0x400A5FE")]
    [FieldOffset(Offset = "0xC8")]
    private List<GachaTabListItemBase> mTabList;
    [Token(Token = "0x400A5FF")]
    [FieldOffset(Offset = "0xCC")]
    private GachaWindow.GachaTabCategory mSelectTab;
    [Token(Token = "0x400A600")]
    [FieldOffset(Offset = "0xD0")]
    public GameObject UnitInfoPanel;
    [Token(Token = "0x400A601")]
    [FieldOffset(Offset = "0xD4")]
    public GameObject ArtifactInfoPanel;
    [Token(Token = "0x400A602")]
    [FieldOffset(Offset = "0xD8")]
    public GameObject PaidCoinPanel;
    [Token(Token = "0x400A603")]
    [FieldOffset(Offset = "0xDC")]
    public GameObject ItemPanel;
    [Token(Token = "0x400A604")]
    [FieldOffset(Offset = "0xE0")]
    public GameObject BonusPanel;
    [Token(Token = "0x400A605")]
    [FieldOffset(Offset = "0xE4")]
    public Text BonusItemName;
    [Token(Token = "0x400A606")]
    [FieldOffset(Offset = "0xE8")]
    public GameObject BonusPanelItem;
    [Token(Token = "0x400A607")]
    [FieldOffset(Offset = "0xEC")]
    public GameObject BonusPanelUnit;
    [Token(Token = "0x400A608")]
    [FieldOffset(Offset = "0xF0")]
    public GameObject BonusPanelArtifact;
    [Token(Token = "0x400A609")]
    [FieldOffset(Offset = "0xF4")]
    public GameObject BonusPanelConceptCard;
    [Token(Token = "0x400A60A")]
    [FieldOffset(Offset = "0xF8")]
    public StatusList Status;
    [Token(Token = "0x400A60B")]
    [FieldOffset(Offset = "0xFC")]
    public GameObject WeaponAbilityInfo;
    [Token(Token = "0x400A60C")]
    [FieldOffset(Offset = "0x100")]
    public GameObject ArtifactRarityPanel;
    [Token(Token = "0x400A60D")]
    [FieldOffset(Offset = "0x104")]
    public Text ArtifactType;
    [Token(Token = "0x400A60E")]
    [FieldOffset(Offset = "0x108")]
    private List<ArtifactData> mPickupArtifacts;
    [Token(Token = "0x400A60F")]
    [FieldOffset(Offset = "0x10C")]
    private ArtifactData mCurrentArtifact;
    [Token(Token = "0x400A610")]
    [FieldOffset(Offset = "0x110")]
    public RawImage PreviewArtifactImage;
    [Token(Token = "0x400A611")]
    [FieldOffset(Offset = "0x114")]
    private Transform mCurrentArtifactPreview;
    [Token(Token = "0x400A612")]
    [FieldOffset(Offset = "0x118")]
    private Transform mPreviewArtifact;
    [Token(Token = "0x400A613")]
    [FieldOffset(Offset = "0x11C")]
    private List<Transform> mPreviewArtifactControllers;
    [Token(Token = "0x400A614")]
    [FieldOffset(Offset = "0x120")]
    public Transform BGRoot;
    [Token(Token = "0x400A615")]
    [FieldOffset(Offset = "0x124")]
    public GameObject BonusMsgPanel;
    [Token(Token = "0x400A616")]
    [FieldOffset(Offset = "0x128")]
    public Text BonusMsgText;
    [Token(Token = "0x400A617")]
    [FieldOffset(Offset = "0x12C")]
    private int mCurrentTabSPIndex;
    [Token(Token = "0x400A618")]
    [FieldOffset(Offset = "0x130")]
    private int mCurrentPickupArtIndex;
    [Token(Token = "0x400A619")]
    [FieldOffset(Offset = "0x134")]
    private bool mLoadGachaTabSprites;
    [Token(Token = "0x400A61A")]
    [FieldOffset(Offset = "0x138")]
    private Dictionary<string, Sprite> mCacheTabImages;
    [Token(Token = "0x400A61B")]
    [FieldOffset(Offset = "0x13C")]
    private List<Transform> mBGObjects;
    [Token(Token = "0x400A61C")]
    [FieldOffset(Offset = "0x140")]
    private bool mLoadBackGroundTexture;
    [Token(Token = "0x400A61D")]
    [FieldOffset(Offset = "0x144")]
    private Dictionary<string, Texture2D> mCacheBGImages;
    [Token(Token = "0x400A61E")]
    [FieldOffset(Offset = "0x148")]
    private Texture2D mDefaultBG;
    [Token(Token = "0x400A61F")]
    [FieldOffset(Offset = "0x14C")]
    private bool IsTabChanging;
    [Token(Token = "0x400A620")]
    [FieldOffset(Offset = "0x150")]
    private int mCurrentTabIndex;
    [Token(Token = "0x400A621")]
    [FieldOffset(Offset = "0x154")]
    private float mWaitSwapBGTime;
    [Token(Token = "0x400A622")]
    [FieldOffset(Offset = "0x158")]
    private bool mExistSwapBG;
    [Token(Token = "0x400A623")]
    [FieldOffset(Offset = "0x15C")]
    private int mEnableBGIndex;
    [Token(Token = "0x400A624")]
    [FieldOffset(Offset = "0x160")]
    private List<GachaWindow.GachaTabCategory> mTabCategoryList;
    [Token(Token = "0x400A625")]
    [FieldOffset(Offset = "0x20")]
    private static string mDetailURL;
    [Token(Token = "0x400A626")]
    [FieldOffset(Offset = "0x164")]
    public string DESCRIPTION_URL;
    [Token(Token = "0x400A627")]
    [FieldOffset(Offset = "0x168")]
    private string mDescriptionURL;
    [Token(Token = "0x400A628")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    private ButtonEvent DetailButtonEvent;
    [Token(Token = "0x400A629")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Button DetailButton;
    [Token(Token = "0x400A62A")]
    [FieldOffset(Offset = "0x174")]
    [SerializeField]
    private Button DescriptionButton;
    [Token(Token = "0x400A62B")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private Transform RootObject;
    [Token(Token = "0x400A62C")]
    [FieldOffset(Offset = "0x17C")]
    private float mBGUnitImgAlphaStart;
    [Token(Token = "0x400A62D")]
    [FieldOffset(Offset = "0x180")]
    private float mBGUnitImgAlphaEnd;
    [Token(Token = "0x400A62E")]
    [FieldOffset(Offset = "0x184")]
    private float mBGUnitImgFadeTime;
    [Token(Token = "0x400A62F")]
    [FieldOffset(Offset = "0x188")]
    private float mBGUnitImgFadeTimeMax;
    [Token(Token = "0x400A630")]
    [FieldOffset(Offset = "0x18C")]
    private bool IsRefreshingGachaBG;
    [Token(Token = "0x400A631")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private GameObject GachaButtonTemplate;
    [Token(Token = "0x400A632")]
    [FieldOffset(Offset = "0x194")]
    private List<GachaButton> m_GachaButtons;
    [Token(Token = "0x400A633")]
    [FieldOffset(Offset = "0x198")]
    private List<GachaTopParamNew> m_CacheList_Gold;
    [Token(Token = "0x400A634")]
    [FieldOffset(Offset = "0x19C")]
    private List<GachaTopParamNew> m_CacheList_Coin;
    [Token(Token = "0x400A635")]
    [FieldOffset(Offset = "0x1A0")]
    private List<GachaTopParamNew> m_CacheList_CoinPaid;
    [Token(Token = "0x400A636")]
    [FieldOffset(Offset = "0x1A4")]
    private List<GachaTopParamNew> m_CacheList_Item;
    [Token(Token = "0x400A637")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private GameObject SummonCoin;
    [Token(Token = "0x400A638")]
    [FieldOffset(Offset = "0x1AC")]
    [SerializeField]
    private Button DiscountButton;
    [Token(Token = "0x400A639")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private ImageArray DiscountImageArray;
    [Token(Token = "0x400A63A")]
    [FieldOffset(Offset = "0x1B4")]
    [SerializeField]
    private GameObject DiscountedImage;
    [Token(Token = "0x400A63B")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private Text DiscountImageText;
    [Token(Token = "0x400A63C")]
    [FieldOffset(Offset = "0x1BC")]
    [SerializeField]
    private Text DiscountedImageText;
    [Token(Token = "0x400A63D")]
    [FieldOffset(Offset = "0x24")]
    private static string m_SelectDiscountGachaID;
    [Token(Token = "0x400A63E")]
    [FieldOffset(Offset = "0x28")]
    private static string m_SelectDiscountGroupID;
    [Token(Token = "0x400A63F")]
    [FieldOffset(Offset = "0x1C0")]
    private bool IsItemCostMultiGacha;
    [Token(Token = "0x400A640")]
    [FieldOffset(Offset = "0x1C4")]
    public GachaWindow.BackGround BG01;
    [Token(Token = "0x400A641")]
    [FieldOffset(Offset = "0x1C8")]
    public GachaWindow.BackGround BG02;
    [Token(Token = "0x400A642")]
    [FieldOffset(Offset = "0x1CC")]
    private Dictionary<string, GachaWindow.BackGroundTextureGroup> mCacheBackGroundImages;
    [Token(Token = "0x400A643")]
    [FieldOffset(Offset = "0x1D0")]
    [Header("召喚トップの背景画像の参照を管理するScriptableObjectのパス")]
    [SerializeField]
    private string BGTABLE_PATH;
    [Token(Token = "0x400A644")]
    [FieldOffset(Offset = "0x1D4")]
    [SerializeField]
    private string BGTEXTURE_SUFFIX_LEFT;
    [Token(Token = "0x400A645")]
    [FieldOffset(Offset = "0x1D8")]
    [SerializeField]
    private string BGTEXTURE_SUFFIX_RIGHT;
    [Token(Token = "0x400A646")]
    [FieldOffset(Offset = "0x1DC")]
    [SerializeField]
    private int MAX_BGTEXTURE_CACHE;
    [Token(Token = "0x400A647")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    [Header("召喚トップで使用する背景画像を格納するフォルダのパス")]
    private string GACHABG_FOLDER_PATH;
    [Token(Token = "0x400A648")]
    [FieldOffset(Offset = "0x1E4")]
    [SerializeField]
    [Header("BGTablesを使用して背景画像を表示する機能を利用する")]
    private bool IsUseBGTables;
    [Token(Token = "0x400A649")]
    public const int MAX_GACHATEXTURE_COUNT = 2;
    [Token(Token = "0x400A64A")]
    [FieldOffset(Offset = "0x1E8")]
    private GachaTopBGAnimationSettings mGachaTopBGAnimationSettings;
    [Token(Token = "0x400A64B")]
    [FieldOffset(Offset = "0x1EC")]
    [Space(10f)]
    [Header("オプションパーツ")]
    [SerializeField]
    private GameObject BonusParts;
    [Token(Token = "0x400A64C")]
    [FieldOffset(Offset = "0x1F0")]
    public GachaWindow.OptionParts OptionPartsObject;
    [Token(Token = "0x400A64D")]
    [FieldOffset(Offset = "0x1F4")]
    [SerializeField]
    private Text BonusText;
    [Token(Token = "0x400A64E")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private GachaWindow.BonusIcon[] BonusIcons;
    [Token(Token = "0x400A64F")]
    [FieldOffset(Offset = "0x1FC")]
    [SerializeField]
    private Text AppealText;
    [Token(Token = "0x400A650")]
    private const string GACHA_BONUS_PREFIX_UNIT = "UN";
    [Token(Token = "0x400A651")]
    private const string GACHA_BONUS_PREFIX_ITEM = "IT";
    [Token(Token = "0x400A652")]
    private const string GACHA_BONUS_PREFIX_ARTIFACT = "AF";
    [Token(Token = "0x400A653")]
    private const string GACHA_BONUS_PREFIX_CONCEPTCARD = "TS";
    [Token(Token = "0x400A654")]
    [FieldOffset(Offset = "0x200")]
    private string CONFIRM_WINDOW_PATH;
    [Token(Token = "0x400A655")]
    [FieldOffset(Offset = "0x204")]
    private GachaRequestParam m_CurrentGachaRequestParam;
    [Token(Token = "0x400A656")]
    [FieldOffset(Offset = "0x208")]
    private GachaButton PrevGachaButton;
    [Token(Token = "0x400A657")]
    [FieldOffset(Offset = "0x20C")]
    [SerializeField]
    private Button PickupSelectButton;
    [Token(Token = "0x400A658")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    private GameObject PickupSelectAnimationObject;
    [Token(Token = "0x400A659")]
    [FieldOffset(Offset = "0x214")]
    private Dictionary<string, GachaPickupSelectParam> mGachaPickupSelectLists;
    [Token(Token = "0x400A65A")]
    [FieldOffset(Offset = "0x218")]
    private List<GachaDropData> mRequestPickupSelectDatas;
    [Token(Token = "0x400A65B")]
    [FieldOffset(Offset = "0x21C")]
    [Header("期間表示用")]
    [Space(10f)]
    [SerializeField]
    private GameObject mPeriodGo;
    [Token(Token = "0x400A65C")]
    [FieldOffset(Offset = "0x220")]
    [SerializeField]
    private GachaWindow.PeriodType mPeriodType;
    [Token(Token = "0x400A65D")]
    [FieldOffset(Offset = "0x224")]
    [SerializeField]
    private Text mPeriodText;
    [Token(Token = "0x400A65E")]
    [FieldOffset(Offset = "0x228")]
    [SerializeField]
    private List<GachaWindow.GachaTabCategory> IsPeriodList;
    [Token(Token = "0x400A65F")]
    [FieldOffset(Offset = "0x22C")]
    private readonly string PERIOD_END_TEXT;
    [Token(Token = "0x400A660")]
    [FieldOffset(Offset = "0x230")]
    private readonly string PERIOD_TEMP_TEXT;
    [Token(Token = "0x400A661")]
    [FieldOffset(Offset = "0x234")]
    private readonly string PERIOD_START_END_TEXT;

    [Token(Token = "0x17001640")]
    public static GachaWindow Instance
    {
      [Token(Token = "0x6009F44"), Address(RVA = "0x628760", Offset = "0x627560", VA = "0x10628760")] get
      {
        return (GachaWindow) null;
      }
    }

    [Token(Token = "0x17001641")]
    public ArtifactData CurrentArtifact
    {
      [Token(Token = "0x6009F45"), Address(RVA = "0x628750", Offset = "0x627550", VA = "0x10628750")] get
      {
        return (ArtifactData) null;
      }
    }

    [Token(Token = "0x17001642")]
    public static string BaseDetailUrl
    {
      [Token(Token = "0x6009F46"), Address(RVA = "0x628710", Offset = "0x627510", VA = "0x10628710")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001643")]
    public static string SelectDiscountGachaID
    {
      [Token(Token = "0x6009F47"), Address(RVA = "0x6287B0", Offset = "0x6275B0", VA = "0x106287B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001644")]
    public static string SelectDiscountGroupID
    {
      [Token(Token = "0x6009F48"), Address(RVA = "0x6287F0", Offset = "0x6275F0", VA = "0x106287F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001645")]
    public bool ChangeUnit
    {
      [Token(Token = "0x6009F49"), Address(RVA = "0x2AAB90", Offset = "0x2A9990", VA = "0x102AAB90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009F4A"), Address(RVA = "0x628840", Offset = "0x627640", VA = "0x10628840")] set
      {
      }
    }

    [Token(Token = "0x17001646")]
    public bool ChangeJob
    {
      [Token(Token = "0x6009F4B"), Address(RVA = "0x2AABA0", Offset = "0x2A99A0", VA = "0x102AABA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009F4C"), Address(RVA = "0x628830", Offset = "0x627630", VA = "0x10628830")] set
      {
      }
    }

    [Token(Token = "0x17001647")]
    public bool Initialized
    {
      [Token(Token = "0x6009F4D"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001648")]
    public UnitData CurrentUnit
    {
      [Token(Token = "0x6009F4E"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001649")]
    public bool Clicked
    {
      [Token(Token = "0x6009F4F"), Address(RVA = "0x2AABB0", Offset = "0x2A99B0", VA = "0x102AABB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009F50")]
    [Address(RVA = "0x61CEC0", Offset = "0x61BCC0", VA = "0x1061CEC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009F51")]
    [Address(RVA = "0x626D30", Offset = "0x625B30", VA = "0x10626D30")]
    private void Start()
    {
    }

    [Token(Token = "0x6009F52")]
    [Address(RVA = "0x61FCA0", Offset = "0x61EAA0", VA = "0x1061FCA0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009F53")]
    [Address(RVA = "0x627AE0", Offset = "0x6268E0", VA = "0x10627AE0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009F54")]
    [Address(RVA = "0x61FA30", Offset = "0x61E830", VA = "0x1061FA30")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009F55")]
    [Address(RVA = "0x61CB30", Offset = "0x61B930", VA = "0x1061CB30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009F56")]
    [Address(RVA = "0x61F380", Offset = "0x61E180", VA = "0x1061F380")]
    private bool IsGachaPending() => new bool();

    [Token(Token = "0x6009F57")]
    [Address(RVA = "0x61ED90", Offset = "0x61DB90", VA = "0x1061ED90")]
    public GachaTopParamNew[] GetCurrentGachaLists(GachaWindow.GachaTabCategory category)
    {
      return (GachaTopParamNew[]) null;
    }

    [Token(Token = "0x6009F58")]
    [Address(RVA = "0x61F310", Offset = "0x61E110", VA = "0x1061F310")]
    public bool IsFreePause(GachaTopParamNew[] _list) => new bool();

    [Token(Token = "0x6009F59")]
    [Address(RVA = "0x623CB0", Offset = "0x622AB0", VA = "0x10623CB0")]
    private void Refresh(bool is_refresh_bg = true)
    {
    }

    [Token(Token = "0x6009F5A")]
    [Address(RVA = "0x622FD0", Offset = "0x621DD0", VA = "0x10622FD0")]
    private void RefreshSummonCoin()
    {
    }

    [Token(Token = "0x6009F5B")]
    [Address(RVA = "0x622D90", Offset = "0x621B90", VA = "0x10622D90")]
    private void RefreshPeriod()
    {
    }

    [Token(Token = "0x6009F5C")]
    [Address(RVA = "0x623800", Offset = "0x622600", VA = "0x10623800")]
    private void RefreshTicketButtonList()
    {
    }

    [Token(Token = "0x6009F5D")]
    [Address(RVA = "0x6252A0", Offset = "0x6240A0", VA = "0x106252A0")]
    public void SetupGachaList(GachaParam[] gparms)
    {
    }

    [Token(Token = "0x6009F5E")]
    [Address(RVA = "0x6266D0", Offset = "0x6254D0", VA = "0x106266D0")]
    public GachaTopParamNew[] SortGachaList(List<GachaTopParamNew> _list)
    {
      return (GachaTopParamNew[]) null;
    }

    [Token(Token = "0x6009F5F")]
    [Address(RVA = "0x61F520", Offset = "0x61E320", VA = "0x1061F520")]
    private IEnumerator LoadGachaTabSprites() => (IEnumerator) null;

    [Token(Token = "0x6009F60")]
    [Address(RVA = "0x61DB20", Offset = "0x61C920", VA = "0x1061DB20")]
    private void ClearTabSprites()
    {
    }

    [Token(Token = "0x6009F61")]
    [Address(RVA = "0x61DA40", Offset = "0x61C840", VA = "0x1061DA40")]
    private void ClearBGSprites()
    {
    }

    [Token(Token = "0x6009F62")]
    [Address(RVA = "0x625D10", Offset = "0x624B10", VA = "0x10625D10")]
    private void SetupTabList()
    {
    }

    [Token(Token = "0x6009F63")]
    [Address(RVA = "0x6232D0", Offset = "0x6220D0", VA = "0x106232D0")]
    private void RefreshTabList()
    {
    }

    [Token(Token = "0x6009F64")]
    [Address(RVA = "0x6200C0", Offset = "0x61EEC0", VA = "0x106200C0")]
    private void OnTabChange(
      GachaTabListItemBase tab,
      GachaWindow.GachaTabCategory category,
      int index = -1)
    {
    }

    [Token(Token = "0x6009F65")]
    [Address(RVA = "0x623540", Offset = "0x622340", VA = "0x10623540")]
    private void RefreshTabState(int index, int sp_index)
    {
    }

    [Token(Token = "0x6009F66")]
    [Address(RVA = "0x6270A0", Offset = "0x625EA0", VA = "0x106270A0")]
    private bool TabChange(
      GachaTabListItemBase tab,
      GachaWindow.GachaTabCategory category,
      int index = -1)
    {
      return new bool();
    }

    [Token(Token = "0x6009F67")]
    [Address(RVA = "0x623240", Offset = "0x622040", VA = "0x10623240")]
    private void RefreshTabEnable(bool state)
    {
    }

    [Token(Token = "0x6009F68")]
    [Address(RVA = "0x6231A0", Offset = "0x621FA0", VA = "0x106231A0")]
    private void RefreshTabActive(bool value)
    {
    }

    [Token(Token = "0x6009F69")]
    [Address(RVA = "0x624F50", Offset = "0x623D50", VA = "0x10624F50")]
    private void SetTicketButtonList()
    {
    }

    [Token(Token = "0x6009F6A")]
    [Address(RVA = "0x622740", Offset = "0x621540", VA = "0x10622740")]
    private void RefreshDefaultPanel(bool is_refresh_bg = true)
    {
    }

    [Token(Token = "0x6009F6B")]
    [Address(RVA = "0x6238A0", Offset = "0x6226A0", VA = "0x106238A0")]
    private void RefreshUnitInfoPanel()
    {
    }

    [Token(Token = "0x6009F6C")]
    [Address(RVA = "0x623A90", Offset = "0x622890", VA = "0x10623A90")]
    private void RefreshUnitInfo()
    {
    }

    [Token(Token = "0x6009F6D")]
    [Address(RVA = "0x620230", Offset = "0x61F030", VA = "0x10620230")]
    private void RefreshArtifactInfoPanel()
    {
    }

    [Token(Token = "0x6009F6E")]
    [Address(RVA = "0x6202F0", Offset = "0x61F0F0", VA = "0x106202F0")]
    private void RefreshArtifactInfo()
    {
    }

    [Token(Token = "0x6009F6F")]
    [Address(RVA = "0x621640", Offset = "0x620440", VA = "0x10621640")]
    private void RefreshButtonPanel()
    {
    }

    [Token(Token = "0x6009F70")]
    [Address(RVA = "0x622A20", Offset = "0x621820", VA = "0x10622A20")]
    private void RefreshGachaDetailSelectID(GachaWindow.GachaTabCategory category)
    {
    }

    [Token(Token = "0x6009F71")]
    [Address(RVA = "0x61F610", Offset = "0x61E410", VA = "0x1061F610")]
    private void OnClickDetail()
    {
    }

    [Token(Token = "0x6009F72")]
    [Address(RVA = "0x61F5A0", Offset = "0x61E3A0", VA = "0x1061F5A0")]
    private void OnClickDescription()
    {
    }

    [Token(Token = "0x6009F73")]
    [Address(RVA = "0x61E430", Offset = "0x61D230", VA = "0x1061E430")]
    private void CreatePickupUnitsList(UnitParam[] units)
    {
    }

    [Token(Token = "0x6009F74")]
    [Address(RVA = "0x61E210", Offset = "0x61D010", VA = "0x1061E210")]
    private void CreatePickupArtifactlist(ArtifactParam[] artifacts)
    {
    }

    [Token(Token = "0x6009F75")]
    [Address(RVA = "0x620140", Offset = "0x61EF40", VA = "0x10620140")]
    private void PlayChangeEffect()
    {
    }

    [Token(Token = "0x6009F76")]
    [Address(RVA = "0x624450", Offset = "0x623250", VA = "0x10624450")]
    private void ResetChangeEffect()
    {
    }

    [Token(Token = "0x6009F77")]
    [Address(RVA = "0x622C80", Offset = "0x621A80", VA = "0x10622C80")]
    private void RefreshGachaState()
    {
    }

    [Token(Token = "0x6009F78")]
    [Address(RVA = "0x6229B0", Offset = "0x6217B0", VA = "0x106229B0")]
    private void RefreshGachaBackGround()
    {
    }

    [Token(Token = "0x6009F79")]
    [Address(RVA = "0x627660", Offset = "0x626460", VA = "0x10627660")]
    private void UpdateBGForce()
    {
    }

    [Token(Token = "0x6009F7A")]
    [Address(RVA = "0x6208B0", Offset = "0x61F6B0", VA = "0x106208B0")]
    private void RefreshBackGround()
    {
    }

    [Token(Token = "0x6009F7B")]
    [Address(RVA = "0x6247C0", Offset = "0x6235C0", VA = "0x106247C0")]
    private void SetBackGroundImage(GachaWindow.BackGroundTextureGroup bg_group)
    {
    }

    [Token(Token = "0x6009F7C")]
    [Address(RVA = "0x624750", Offset = "0x623550", VA = "0x10624750")]
    private IEnumerator SetBackGroundImageAsync(string iname) => (IEnumerator) null;

    [Token(Token = "0x6009F7D")]
    [Address(RVA = "0x61F440", Offset = "0x61E240", VA = "0x1061F440")]
    private IEnumerator LoadBackGroundTextureForBGTables(string[] inames) => (IEnumerator) null;

    [Token(Token = "0x6009F7E")]
    [Address(RVA = "0x61E8F0", Offset = "0x61D6F0", VA = "0x1061E8F0")]
    private GachaWindow.BackGroundTexture GetBackGroundTexture(Texture2D[] textures, string iname)
    {
      return (GachaWindow.BackGroundTexture) null;
    }

    [Token(Token = "0x6009F7F")]
    [Address(RVA = "0x627680", Offset = "0x626480", VA = "0x10627680")]
    private void UpdateBackGround()
    {
    }

    [Token(Token = "0x6009F80")]
    [Address(RVA = "0x61F4B0", Offset = "0x61E2B0", VA = "0x1061F4B0")]
    private IEnumerator LoadBackGroundTextures(string[] inames) => (IEnumerator) null;

    [Token(Token = "0x6009F81")]
    [Address(RVA = "0x61F250", Offset = "0x61E050", VA = "0x1061F250")]
    private bool IsExistSwapBG(string iname) => new bool();

    [Token(Token = "0x6009F82")]
    [Address(RVA = "0x6212B0", Offset = "0x6200B0", VA = "0x106212B0")]
    private void RefreshBonusParts()
    {
    }

    [Token(Token = "0x6009F83")]
    [Address(RVA = "0x624370", Offset = "0x623170", VA = "0x10624370")]
    private void ResetBonusObject()
    {
    }

    [Token(Token = "0x6009F84")]
    [Address(RVA = "0x620A40", Offset = "0x61F840", VA = "0x10620A40")]
    private void RefreshBonusObject(GachaBonusParam[] bonus)
    {
    }

    [Token(Token = "0x6009F85")]
    [Address(RVA = "0x61F0A0", Offset = "0x61DEA0", VA = "0x1061F0A0")]
    private void InitGachaUnitPreview(bool reload = true)
    {
    }

    [Token(Token = "0x6009F86")]
    [Address(RVA = "0x61EF70", Offset = "0x61DD70", VA = "0x1061EF70")]
    private void InitGachaArtifactPreview(bool reload = true)
    {
    }

    [Token(Token = "0x6009F87")]
    [Address(RVA = "0x624300", Offset = "0x623100", VA = "0x10624300")]
    private IEnumerator ReloadPickupArtifactPreview(bool reload = true) => (IEnumerator) null;

    [Token(Token = "0x6009F88")]
    [Address(RVA = "0x623DF0", Offset = "0x622BF0", VA = "0x10623DF0")]
    private void ReloadPickUpUnitView()
    {
    }

    [Token(Token = "0x6009F89")]
    [Address(RVA = "0x627A20", Offset = "0x626820", VA = "0x10627A20")]
    private void UpdateCurrentUnitInfo()
    {
    }

    [Token(Token = "0x6009F8A")]
    [Address(RVA = "0x6279A0", Offset = "0x6267A0", VA = "0x106279A0")]
    private void UpdateCurrentArtifactInfo()
    {
    }

    [Token(Token = "0x6009F8B")]
    [Address(RVA = "0x61D510", Offset = "0x61C310", VA = "0x1061D510")]
    private void ChangePreviewUnit()
    {
    }

    [Token(Token = "0x6009F8C")]
    [Address(RVA = "0x61D4C0", Offset = "0x61C2C0", VA = "0x1061D4C0")]
    private void ChangePreviewArtifact()
    {
    }

    [Token(Token = "0x6009F8D")]
    [Address(RVA = "0x622F00", Offset = "0x621D00", VA = "0x10622F00")]
    private void RefreshPreviews()
    {
    }

    [Token(Token = "0x6009F8E")]
    [Address(RVA = "0x624670", Offset = "0x623470", VA = "0x10624670")]
    private void SetActivePreview(int index)
    {
    }

    [Token(Token = "0x6009F8F")]
    [Address(RVA = "0x6250C0", Offset = "0x623EC0", VA = "0x106250C0")]
    private void SetVisiblaePreviews(bool visible = true)
    {
    }

    [Token(Token = "0x6009F90")]
    [Address(RVA = "0x624580", Offset = "0x623380", VA = "0x10624580")]
    private void SetActivePreviewArtifact(int index)
    {
    }

    [Token(Token = "0x6009F91")]
    [Address(RVA = "0x624540", Offset = "0x623340", VA = "0x10624540")]
    private bool SelectJob() => new bool();

    [Token(Token = "0x6009F92")]
    [Address(RVA = "0x622D00", Offset = "0x621B00", VA = "0x10622D00")]
    private void RefreshJobs()
    {
    }

    [Token(Token = "0x6009F93")]
    [Address(RVA = "0x61DCE0", Offset = "0x61CAE0", VA = "0x1061DCE0")]
    private IEnumerator CreateConfirm(GachaRequestParam _param, bool _is_coin_status = true)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x1700164A")]
    public GachaRequestParam CurrentGachaRequestParam
    {
      [Token(Token = "0x6009F94"), Address(RVA = "0x4782E0", Offset = "0x4770E0", VA = "0x104782E0")] get
      {
        return (GachaRequestParam) null;
      }
    }

    [Token(Token = "0x6009F95")]
    [Address(RVA = "0x620000", Offset = "0x61EE00", VA = "0x10620000")]
    private void OnExecGachaNotSelectPickup(GachaButton btn, GachaTopParamNew param)
    {
    }

    [Token(Token = "0x6009F96")]
    [Address(RVA = "0x61FD50", Offset = "0x61EB50", VA = "0x1061FD50")]
    private void OnExecGacha2(GachaTopParamNew param)
    {
    }

    [Token(Token = "0x6009F97")]
    [Address(RVA = "0x61F710", Offset = "0x61E510", VA = "0x1061F710")]
    private void OnDecideForTicketSelect()
    {
    }

    [Token(Token = "0x6009F98")]
    [Address(RVA = "0x61F6A0", Offset = "0x61E4A0", VA = "0x1061F6A0")]
    private void OnDecideForSingleItemSelect()
    {
    }

    [Token(Token = "0x6009F99")]
    [Address(RVA = "0x61F890", Offset = "0x61E690", VA = "0x1061F890")]
    private void OnDecisionRedrawGacha()
    {
    }

    [Token(Token = "0x6009F9A")]
    [Address(RVA = "0x61F770", Offset = "0x61E570", VA = "0x1061F770")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x6009F9B")]
    [Address(RVA = "0x61F590", Offset = "0x61E390", VA = "0x1061F590")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x6009F9C")]
    [Address(RVA = "0x61DD50", Offset = "0x61CB50", VA = "0x1061DD50")]
    private GachaRequestParam CreateGachaRequest(string _iname) => (GachaRequestParam) null;

    [Token(Token = "0x6009F9D")]
    [Address(RVA = "0x61D560", Offset = "0x61C360", VA = "0x1061D560")]
    private void CheckPrevGachaRequest()
    {
    }

    [Token(Token = "0x6009F9E")]
    [Address(RVA = "0x61EB00", Offset = "0x61D900", VA = "0x1061EB00")]
    private string GetConfirmText(
      int _cost,
      bool _ispaid,
      string _confirm,
      bool _is_discount,
      int _count = 1)
    {
      return (string) null;
    }

    [Token(Token = "0x6009F9F")]
    [Address(RVA = "0x61DE80", Offset = "0x61CC80", VA = "0x1061DE80")]
    private GachaRequestParam CreateGachaRequest(GachaTopParamNew param)
    {
      return (GachaRequestParam) null;
    }

    [Token(Token = "0x6009FA0")]
    [Address(RVA = "0x61E500", Offset = "0x61D300", VA = "0x1061E500")]
    private RenderTexture CreateRenderTexture() => (RenderTexture) null;

    [Token(Token = "0x6009FA1")]
    [Address(RVA = "0x624B20", Offset = "0x623920", VA = "0x10624B20")]
    public void SetGachaPreviewCamera()
    {
    }

    [Token(Token = "0x6009FA2")]
    [Address(RVA = "0x624A70", Offset = "0x623870", VA = "0x10624A70")]
    public void SetGachaPreviewArtifactCamera()
    {
    }

    [Token(Token = "0x6009FA3")]
    [Address(RVA = "0x61E890", Offset = "0x61D690", VA = "0x1061E890")]
    private void FadeUnitImage(float alphastart, float alphaend, float duration)
    {
    }

    [Token(Token = "0x6009FA4")]
    [Address(RVA = "0x624FF0", Offset = "0x623DF0", VA = "0x10624FF0")]
    private void SetUnitImageAlpha(float alpha)
    {
    }

    [Token(Token = "0x6009FA5")]
    [Address(RVA = "0x623830", Offset = "0x622630", VA = "0x10623830")]
    private IEnumerator RefreshUnitImage() => (IEnumerator) null;

    [Token(Token = "0x1700164B")]
    public List<GachaDropData> RequestPickupSelectDatas
    {
      [Token(Token = "0x6009FA6"), Address(RVA = "0x6287A0", Offset = "0x6275A0", VA = "0x106287A0")] get
      {
        return (List<GachaDropData>) null;
      }
    }

    [Token(Token = "0x6009FA7")]
    [Address(RVA = "0x625C40", Offset = "0x624A40", VA = "0x10625C40")]
    public void SetupGachaSelectList(string key, Json_GachaPickups[] jsons, int num)
    {
    }

    [Token(Token = "0x6009FA8")]
    [Address(RVA = "0x61F200", Offset = "0x61E000", VA = "0x1061F200")]
    public bool IsAlreadyPickupSelectList(string gname) => new bool();

    [Token(Token = "0x6009FA9")]
    [Address(RVA = "0x61EF50", Offset = "0x61DD50", VA = "0x1061EF50")]
    public GachaTopParamNew[] GetCurrentGacha() => (GachaTopParamNew[]) null;

    [Token(Token = "0x6009FAA")]
    [Address(RVA = "0x61ED30", Offset = "0x61DB30", VA = "0x1061ED30")]
    public string GetCurrentGachaId() => (string) null;

    [Token(Token = "0x6009FAB")]
    [Address(RVA = "0x61EE70", Offset = "0x61DC70", VA = "0x1061EE70")]
    public GachaPickupSelectParam GetCurrentGachaPickupSelectParam()
    {
      return (GachaPickupSelectParam) null;
    }

    [Token(Token = "0x6009FAC")]
    [Address(RVA = "0x624E40", Offset = "0x623C40", VA = "0x10624E40")]
    public void SetRequestPickupSelectData(List<GachaDropData> lists)
    {
    }

    [Token(Token = "0x6009FAD")]
    [Address(RVA = "0x624BD0", Offset = "0x6239D0", VA = "0x10624BD0")]
    public void SetPeriodText(long _start_at, long _end_at)
    {
    }

    [Token(Token = "0x6009FAE")]
    [Address(RVA = "0x61E570", Offset = "0x61D370", VA = "0x1061E570")]
    private UnitData CreateUnitData(UnitParam param) => (UnitData) null;

    [Token(Token = "0x6009FAF")]
    [Address(RVA = "0x61DBA0", Offset = "0x61C9A0", VA = "0x1061DBA0")]
    private ArtifactData CreateArtifactData(ArtifactParam param) => (ArtifactData) null;

    [Token(Token = "0x6009FB0")]
    [Address(RVA = "0x627F90", Offset = "0x626D90", VA = "0x10627F90")]
    public GachaWindow()
    {
    }

    [Token(Token = "0x6009FB1")]
    [Address(RVA = "0x627DB0", Offset = "0x626BB0", VA = "0x10627DB0")]
    static GachaWindow()
    {
    }

    [Token(Token = "0x2002471")]
    public enum PeriodType
    {
      [Token(Token = "0x400A663")] NONE,
      [Token(Token = "0x400A664")] END,
      [Token(Token = "0x400A665")] START_END,
    }

    [Token(Token = "0x2002472")]
    public class GachaTopParamNewGroups
    {
      [Token(Token = "0x400A666")]
      [FieldOffset(Offset = "0x8")]
      public List<GachaTopParamNew> lists;
      [Token(Token = "0x400A667")]
      [FieldOffset(Offset = "0xC")]
      public string group;
      [Token(Token = "0x400A668")]
      [FieldOffset(Offset = "0x10")]
      public string tab_image;
      [Token(Token = "0x400A669")]
      [FieldOffset(Offset = "0x14")]
      public string bg_image;

      [Token(Token = "0x6009FB9")]
      [Address(RVA = "0x61CAC0", Offset = "0x61B8C0", VA = "0x1061CAC0")]
      public GachaTopParamNewGroups()
      {
      }
    }

    [Token(Token = "0x2002473")]
    public enum GachaTabCategory : byte
    {
      [Token(Token = "0x400A66B")] NONE,
      [Token(Token = "0x400A66C")] RARE,
      [Token(Token = "0x400A66D")] ARTIFACT,
      [Token(Token = "0x400A66E")] TICKET,
      [Token(Token = "0x400A66F")] NORMAL,
      [Token(Token = "0x400A670")] SPECIAL,
    }

    [Token(Token = "0x2002474")]
    private class State_Init : State<GachaWindow>
    {
      [Token(Token = "0x6009FBA")]
      [Address(RVA = "0x62AE70", Offset = "0x629C70", VA = "0x1062AE70", Slot = "5")]
      public override void Update(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FBB")]
      [Address(RVA = "0x62AF80", Offset = "0x629D80", VA = "0x1062AF80")]
      public State_Init()
      {
      }
    }

    [Token(Token = "0x2002475")]
    private class State_CheckInitState : State<GachaWindow>
    {
      [Token(Token = "0x6009FBC")]
      [Address(RVA = "0x62A420", Offset = "0x629220", VA = "0x1062A420", Slot = "5")]
      public override void Update(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FBD")]
      [Address(RVA = "0x62A5A0", Offset = "0x6293A0", VA = "0x1062A5A0")]
      public State_CheckInitState()
      {
      }
    }

    [Token(Token = "0x2002476")]
    private class State_RefreshPreview : State<GachaWindow>
    {
      [Token(Token = "0x400A671")]
      [FieldOffset(Offset = "0xC")]
      private WaitForSeconds wait;

      [Token(Token = "0x6009FBE")]
      [Address(RVA = "0x62B000", Offset = "0x629E00", VA = "0x1062B000", Slot = "4")]
      public override void Begin(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FBF")]
      [Address(RVA = "0x62B230", Offset = "0x62A030", VA = "0x1062B230")]
      private IEnumerator RebuildPreviewController(GachaWindow self) => (IEnumerator) null;

      [Token(Token = "0x6009FC0")]
      [Address(RVA = "0x62B2A0", Offset = "0x62A0A0", VA = "0x1062B2A0")]
      private void RebuildUnitPreview()
      {
      }

      [Token(Token = "0x6009FC1")]
      [Address(RVA = "0x62B100", Offset = "0x629F00", VA = "0x1062B100")]
      private void RebuildArtifactPreview()
      {
      }

      [Token(Token = "0x6009FC2")]
      [Address(RVA = "0x62B440", Offset = "0x62A240", VA = "0x1062B440")]
      public State_RefreshPreview()
      {
      }
    }

    [Token(Token = "0x2002478")]
    private class State_WaitActionAnimation : State<GachaWindow>
    {
      [Token(Token = "0x400A676")]
      [FieldOffset(Offset = "0xC")]
      private float mTimer;

      [Token(Token = "0x6009FC9")]
      [Address(RVA = "0x62B920", Offset = "0x62A720", VA = "0x1062B920", Slot = "4")]
      public override void Begin(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FCA")]
      [Address(RVA = "0x62B9D0", Offset = "0x62A7D0", VA = "0x1062B9D0", Slot = "5")]
      public override void Update(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FCB")]
      [Address(RVA = "0x62BA90", Offset = "0x62A890", VA = "0x1062BA90")]
      public State_WaitActionAnimation()
      {
      }
    }

    [Token(Token = "0x2002479")]
    private class State_WaitPreviewUnit : State<GachaWindow>
    {
      [Token(Token = "0x400A677")]
      [FieldOffset(Offset = "0xC")]
      private float mTimer;

      [Token(Token = "0x6009FCC")]
      [Address(RVA = "0x62BF00", Offset = "0x62AD00", VA = "0x1062BF00", Slot = "4")]
      public override void Begin(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FCD")]
      [Address(RVA = "0x62BF20", Offset = "0x62AD20", VA = "0x1062BF20", Slot = "5")]
      public override void Update(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FCE")]
      [Address(RVA = "0x62BFA0", Offset = "0x62ADA0", VA = "0x1062BFA0")]
      public State_WaitPreviewUnit()
      {
      }
    }

    [Token(Token = "0x200247A")]
    private class State_CheckPreviewState : State<GachaWindow>
    {
      [Token(Token = "0x6009FCF")]
      [Address(RVA = "0x62A740", Offset = "0x629540", VA = "0x1062A740", Slot = "4")]
      public override void Begin(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FD0")]
      [Address(RVA = "0x62A850", Offset = "0x629650", VA = "0x1062A850")]
      public State_CheckPreviewState()
      {
      }
    }

    [Token(Token = "0x200247B")]
    private class State_PauseState : State<GachaWindow>
    {
      [Token(Token = "0x6009FD1")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FD2")]
      [Address(RVA = "0x62AFC0", Offset = "0x629DC0", VA = "0x1062AFC0")]
      public State_PauseState()
      {
      }
    }

    [Token(Token = "0x200247C")]
    private class State_ToGachaResult : State<GachaWindow>
    {
      [Token(Token = "0x6009FD3")]
      [Address(RVA = "0x62B880", Offset = "0x62A680", VA = "0x1062B880", Slot = "4")]
      public override void Begin(GachaWindow self)
      {
      }

      [Token(Token = "0x6009FD4")]
      [Address(RVA = "0x62B8E0", Offset = "0x62A6E0", VA = "0x1062B8E0")]
      public State_ToGachaResult()
      {
      }
    }

    [Token(Token = "0x200247D")]
    [Serializable]
    public class BackGround
    {
      [Token(Token = "0x400A678")]
      [FieldOffset(Offset = "0x8")]
      public CanvasGroup RootCanvasGroup;
      [Token(Token = "0x400A679")]
      [FieldOffset(Offset = "0xC")]
      public RawImage BackGroundLeft;
      [Token(Token = "0x400A67A")]
      [FieldOffset(Offset = "0x10")]
      public RawImage BackGroundRight;

      [Token(Token = "0x1700164E")]
      public bool IsTextureSet
      {
        [Token(Token = "0x6009FD5"), Address(RVA = "0x61C3D0", Offset = "0x61B1D0", VA = "0x1061C3D0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6009FD6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BackGround()
      {
      }
    }

    [Token(Token = "0x200247E")]
    private class BackGroundTexture
    {
      [Token(Token = "0x1700164F")]
      public Texture2D left
      {
        [Token(Token = "0x6009FD7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (Texture2D) null;
        }
        [Token(Token = "0x6009FD8"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
        {
        }
      }

      [Token(Token = "0x17001650")]
      public Texture2D right
      {
        [Token(Token = "0x6009FD9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (Texture2D) null;
        }
        [Token(Token = "0x6009FDA"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
        {
        }
      }

      [Token(Token = "0x6009FDB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BackGroundTexture()
      {
      }
    }

    [Token(Token = "0x200247F")]
    private class BackGroundTextureGroup
    {
      [Token(Token = "0x400A67D")]
      [FieldOffset(Offset = "0x8")]
      private string image_iname;
      [Token(Token = "0x400A67E")]
      [FieldOffset(Offset = "0xC")]
      public GachaWindow.BackGroundTexture[] backgrounds;

      [Token(Token = "0x17001651")]
      public string ImageIname
      {
        [Token(Token = "0x6009FDC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001652")]
      public bool IsEnableData
      {
        [Token(Token = "0x6009FDD"), Address(RVA = "0x61C3B0", Offset = "0x61B1B0", VA = "0x1061C3B0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6009FDE")]
      [Address(RVA = "0x61C380", Offset = "0x61B180", VA = "0x1061C380")]
      public void Setup(string iname, GachaWindow.BackGroundTexture[] bgs)
      {
      }

      [Token(Token = "0x6009FDF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BackGroundTextureGroup()
      {
      }
    }

    [Token(Token = "0x2002480")]
    public enum eGachaBGParts
    {
      [Token(Token = "0x400A680")] LEFT,
      [Token(Token = "0x400A681")] RIGHT,
      [Token(Token = "0x400A682")] MAX,
    }

    [Token(Token = "0x2002481")]
    [Serializable]
    public class OptionParts
    {
      [Token(Token = "0x400A683")]
      [FieldOffset(Offset = "0x8")]
      public GameObject OptionRoot;
      [Token(Token = "0x400A684")]
      [FieldOffset(Offset = "0xC")]
      public GameObject StepupBase;
      [Token(Token = "0x400A685")]
      [FieldOffset(Offset = "0x10")]
      public Text StepupNumText;
      [Token(Token = "0x400A686")]
      [FieldOffset(Offset = "0x14")]
      public GameObject LimitBase;
      [Token(Token = "0x400A687")]
      [FieldOffset(Offset = "0x18")]
      public Text LimitNumText;

      [Token(Token = "0x6009FE0")]
      [Address(RVA = "0x629BF0", Offset = "0x6289F0", VA = "0x10629BF0")]
      public void Refresh(GachaTopParamNew param)
      {
      }

      [Token(Token = "0x6009FE1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public OptionParts()
      {
      }
    }

    [Token(Token = "0x2002482")]
    [Serializable]
    public class BonusIcon
    {
      [Token(Token = "0x400A688")]
      [FieldOffset(Offset = "0x8")]
      public GameObject Root;
      [Token(Token = "0x400A689")]
      [FieldOffset(Offset = "0xC")]
      public GameObject ItemIcon;
      [Token(Token = "0x400A68A")]
      [FieldOffset(Offset = "0x10")]
      public GameObject UnitIcon;
      [Token(Token = "0x400A68B")]
      [FieldOffset(Offset = "0x14")]
      public GameObject ArtifactIcon;
      [Token(Token = "0x400A68C")]
      [FieldOffset(Offset = "0x18")]
      public GameObject ConceptCardIcon;
      [Token(Token = "0x400A68D")]
      [FieldOffset(Offset = "0x1C")]
      public GameObject CrystalIcon;

      [Token(Token = "0x6009FE2")]
      [Address(RVA = "0x61C4C0", Offset = "0x61B2C0", VA = "0x1061C4C0")]
      public void Reset()
      {
      }

      [Token(Token = "0x6009FE3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BonusIcon()
      {
      }
    }
  }
}
