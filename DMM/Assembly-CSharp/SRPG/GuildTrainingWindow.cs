// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingWindow
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
  [Token(Token = "0x2002545")]
  [FlowNode.Pin(10, "ユニット選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "ユニット解除", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(20, "ポップアップを開く", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(21, "ポップアップを閉じる", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(31, "Page:Next", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ユニットリストを開く", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ユニットセット", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "トレーニング終了", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "受け取り報酬表示", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(105, "エネルギー補充", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(106, "期間外ユニットが発生", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(901, "予期せぬエラー検知", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(30, "Page:Prev", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(3, "課金要素の更新", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(201, "Update", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  public class GuildTrainingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AAE6")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AAE7")]
    private const int PIN_INPUT_UPDATE_VIEW = 2;
    [Token(Token = "0x400AAE8")]
    private const int PIN_INPUT_EXPANSION_UPDATE = 3;
    [Token(Token = "0x400AAE9")]
    private const int PIN_INPUT_SELECT_UNIT = 10;
    [Token(Token = "0x400AAEA")]
    private const int PIN_INPUT_REMOVE_UNIT = 11;
    [Token(Token = "0x400AAEB")]
    private const int PIN_INPUT_OPEN_POPUP = 20;
    [Token(Token = "0x400AAEC")]
    private const int PIN_INPUT_CLOSE_POPUP = 21;
    [Token(Token = "0x400AAED")]
    private const int PIN_INPUT_PREV_PAGE = 30;
    [Token(Token = "0x400AAEE")]
    private const int PIN_INPUT_NEXT_PAGE = 31;
    [Token(Token = "0x400AAEF")]
    private const int PIN_OUTPUT_INIT_FINISH = 100;
    [Token(Token = "0x400AAF0")]
    private const int PIN_OUTPUT_OPEN_UNIT_LIST = 101;
    [Token(Token = "0x400AAF1")]
    private const int PIN_OUTPUT_SET_UNIT = 102;
    [Token(Token = "0x400AAF2")]
    private const int PIN_OUTPUT_TRAINING_FINISH = 103;
    [Token(Token = "0x400AAF3")]
    private const int PIN_OUTPUT_VIEW_REWARD = 104;
    [Token(Token = "0x400AAF4")]
    private const int PIN_OUTPUT_OPEN_ENERGY_CHARGE = 105;
    [Token(Token = "0x400AAF5")]
    private const int PIN_OUTPUT_PERIOD_OUT_UNIT = 106;
    [Token(Token = "0x400AAF6")]
    private const int PIN_OUTPUT_EXPANSION_UPDATE = 201;
    [Token(Token = "0x400AAF7")]
    private const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400AAF8")]
    [FieldOffset(Offset = "0xC")]
    private readonly float UNIT_LIST_CAMPAIGN_INTERBAL;
    [Token(Token = "0x400AAF9")]
    [FieldOffset(Offset = "0x10")]
    private readonly long INDEFINITE_PERIOD;
    [Token(Token = "0x400AAFA")]
    [FieldOffset(Offset = "0x18")]
    private readonly int DEFAULT_VALUE;
    [Token(Token = "0x400AAFB")]
    [FieldOffset(Offset = "0x1C")]
    private readonly string CAMPAIGN_LIMIT_TEXT;
    [Token(Token = "0x400AAFC")]
    [FieldOffset(Offset = "0x20")]
    private readonly string CAMPAIGN_CONJUNCTION_TEXT;
    [Token(Token = "0x400AAFD")]
    [FieldOffset(Offset = "0x24")]
    private readonly string CAMPAIGN_CREATE_TIME_SHORTENING_TEXT;
    [Token(Token = "0x400AAFE")]
    [FieldOffset(Offset = "0x28")]
    private readonly string CAMPAIGN_ITEM_ENERGY_INCREASE_TEXT;
    [Token(Token = "0x400AAFF")]
    [FieldOffset(Offset = "0x2C")]
    private readonly string CAMPAIGN_CONJUNCTION_TEXT2;
    [Token(Token = "0x400AB00")]
    [FieldOffset(Offset = "0x30")]
    private readonly string PAGE_DEFAULT_NAME;
    [Token(Token = "0x400AB01")]
    [FieldOffset(Offset = "0x34")]
    private readonly string PULLDOWN_TEXT;
    [Token(Token = "0x400AB02")]
    [FieldOffset(Offset = "0x38")]
    private readonly string PULLDOWN_DEFAULT_TEXT;
    [Token(Token = "0x400AB03")]
    [FieldOffset(Offset = "0x3C")]
    private readonly string PULLDOWN_TEMPLATE_TEXT;
    [Token(Token = "0x400AB04")]
    [FieldOffset(Offset = "0x40")]
    private readonly string ADD_FRAME_TEXT;
    [Token(Token = "0x400AB05")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SerializeValueBehaviour SVBParty;
    [Token(Token = "0x400AB06")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform mUnitSlotParant;
    [Token(Token = "0x400AB07")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mNotificationSetting;
    [Token(Token = "0x400AB08")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text mEnergyRestTimeTxt;
    [Token(Token = "0x400AB09")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private BitmapText mNowEnergyTxt;
    [Token(Token = "0x400AB0A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private BitmapText mMaxEnergyTxt;
    [Token(Token = "0x400AB0B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Slider mEnergyBar;
    [Token(Token = "0x400AB0C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mEnergyChargeBtnBadge;
    [Token(Token = "0x400AB0D")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GuildTrainingTitleStatus mTrainingTitleEff;
    [Token(Token = "0x400AB0E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Toggle mPushEnergyLimitToggle;
    [Token(Token = "0x400AB0F")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GuildTrainingPullDown mPagePullDown;
    [Token(Token = "0x400AB10")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject mUnLockWindowParent;
    [Token(Token = "0x400AB11")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private RectTransform mUnLockWindow;
    [Token(Token = "0x400AB12")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text mUnLockText;
    [Token(Token = "0x400AB13")]
    [FieldOffset(Offset = "0x7C")]
    [HeaderBar("▼基準時間")]
    [SerializeField]
    private float mCalcCostTime;
    [Token(Token = "0x400AB14")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    [HeaderBar("▼文字カラー")]
    [Space(5f)]
    private Color RestTimeFontRed;
    [Token(Token = "0x400AB15")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Color RestTimeFontYellow;
    [Token(Token = "0x400AB16")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Color BarNowEnergyEnable;
    [Token(Token = "0x400AB17")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Color BarNowEnergyDisable;
    [Token(Token = "0x400AB18")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject mLockAddFrameGo;
    [Token(Token = "0x400AB19")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    private GameObject mAddFrameGo;
    [Token(Token = "0x400AB1A")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text mAddFrameText;
    [Token(Token = "0x400AB1B")]
    [FieldOffset(Offset = "0xCC")]
    [HeaderBar("▼プルダウンに機能名＋ページ数で表示するかのフラグ")]
    [Space(5f)]
    [SerializeField]
    private bool mIsPullDownExpantionNameFlag;
    [Token(Token = "0x400AB1C")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject mEnergyCover;
    [Token(Token = "0x400AB1D")]
    [FieldOffset(Offset = "0xD4")]
    [HeaderBar("▼ページ表記関連")]
    [SerializeField]
    [Space(5f)]
    private GameObject mNowAndMaxPageDisplayGo;
    [Token(Token = "0x400AB1E")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text mNowPageText;
    [Token(Token = "0x400AB1F")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    private Text mMaxPageText;
    [Token(Token = "0x400AB20")]
    [FieldOffset(Offset = "0x0")]
    private static GuildTrainingWindow mInstance;
    [Token(Token = "0x400AB21")]
    [FieldOffset(Offset = "0xE0")]
    private List<GuildTrainingData> mGuildTrainingDatas;
    [Token(Token = "0x400AB22")]
    [FieldOffset(Offset = "0xE4")]
    private List<GuildTrainingReward> mGuildTrainingRewards;
    [Token(Token = "0x400AB23")]
    [FieldOffset(Offset = "0xE8")]
    private string[] mRemoveUnitInames;
    [Token(Token = "0x400AB24")]
    [FieldOffset(Offset = "0xEC")]
    private GuildTrainingEnergy mGuildTrainingEnergy;
    [Token(Token = "0x400AB25")]
    [FieldOffset(Offset = "0xF0")]
    private GuildFacilityEffectParam mGuildFacilityEffect;
    [Token(Token = "0x400AB26")]
    [FieldOffset(Offset = "0xF4")]
    private List<GuildTrainingCampaign> mEnableCampaignList;
    [Token(Token = "0x400AB27")]
    [FieldOffset(Offset = "0xF8")]
    private List<GuildTrainingUnit> mTrainingUnitDatas;
    [Token(Token = "0x400AB28")]
    [FieldOffset(Offset = "0x100")]
    private DateTime mDataReceiveTime;
    [Token(Token = "0x400AB29")]
    [FieldOffset(Offset = "0x108")]
    private DateTime mStartClientDate;
    [Token(Token = "0x400AB2A")]
    [FieldOffset(Offset = "0x110")]
    private bool mInitialized;
    [Token(Token = "0x400AB2B")]
    [FieldOffset(Offset = "0x111")]
    private bool mInitCheckPop;
    [Token(Token = "0x400AB2C")]
    [FieldOffset(Offset = "0x114")]
    private GuildTrainingUnitSlot[] mUnitSlots;
    [Token(Token = "0x400AB2D")]
    [FieldOffset(Offset = "0x118")]
    private int mEnergyMax;
    [Token(Token = "0x400AB2E")]
    [FieldOffset(Offset = "0x11C")]
    private int mTrainingUnitNum;
    [Token(Token = "0x400AB2F")]
    [FieldOffset(Offset = "0x120")]
    private bool mIsPopupOpen;
    [Token(Token = "0x400AB30")]
    [FieldOffset(Offset = "0x124")]
    private float mCost;
    [Token(Token = "0x400AB31")]
    [FieldOffset(Offset = "0x128")]
    private int mOneHourEnergyCost;
    [Token(Token = "0x400AB32")]
    [FieldOffset(Offset = "0x130")]
    private DateTime mTrainingEndTime;
    [Token(Token = "0x400AB33")]
    [FieldOffset(Offset = "0x138")]
    private string mTimeFormat;
    [Token(Token = "0x400AB34")]
    [FieldOffset(Offset = "0x13C")]
    private bool mIsUpdateBefore;
    [Token(Token = "0x400AB35")]
    [FieldOffset(Offset = "0x140")]
    private int mSelectSlot;
    [Token(Token = "0x400AB36")]
    [FieldOffset(Offset = "0x148")]
    private long mSelectUnitIid;
    [Token(Token = "0x400AB37")]
    [FieldOffset(Offset = "0x150")]
    private UnitListRootWindow.ListData mListData;
    [Token(Token = "0x400AB38")]
    [FieldOffset(Offset = "0x154")]
    private UnitListRootWindow.TabRegister mRegister;
    [Token(Token = "0x400AB39")]
    [FieldOffset(Offset = "0x158")]
    private int mPageSlotNum;
    [Token(Token = "0x400AB3A")]
    [FieldOffset(Offset = "0x15C")]
    private int mCurrentPage;
    [Token(Token = "0x400AB3B")]
    [FieldOffset(Offset = "0x160")]
    private List<GuildTrainingPage> mPageData;
    [Token(Token = "0x400AB3C")]
    [FieldOffset(Offset = "0x164")]
    private Dictionary<string, List<GuildTrainingData>> mGuildTrainingSlotDataDic;
    [Token(Token = "0x400AB3D")]
    [FieldOffset(Offset = "0x168")]
    private Dictionary<string, List<GuildTrainingUnit>> mGuildTrainingUnitDataDic;
    [Token(Token = "0x400AB3E")]
    [FieldOffset(Offset = "0x16C")]
    private Dictionary<ExpansionPurchaseParam.eType, GuildTrainingExpantionData> mGuildTrainingExpantionDataDic;
    [Token(Token = "0x400AB3F")]
    [FieldOffset(Offset = "0x170")]
    private DateTime mEnergyEmptyDate;
    [Token(Token = "0x400AB40")]
    [FieldOffset(Offset = "0x178")]
    private bool mIsStopEnergyEmptyDate;
    [Token(Token = "0x400AB41")]
    [FieldOffset(Offset = "0x179")]
    private bool mIsCampaign;
    [Token(Token = "0x400AB42")]
    [FieldOffset(Offset = "0x17A")]
    private bool mIsTrainingFinishAPI;
    [Token(Token = "0x400AB43")]
    [FieldOffset(Offset = "0x180")]
    private double mTotalEnergyCost;
    [Token(Token = "0x400AB44")]
    [FieldOffset(Offset = "0x188")]
    private TimeSpan mEnergyLimitTime;
    [Token(Token = "0x400AB45")]
    [FieldOffset(Offset = "0x190")]
    private int mNowEnergy;
    [Token(Token = "0x400AB46")]
    [FieldOffset(Offset = "0x194")]
    private bool mIsAddFrameExpantion;
    [Token(Token = "0x400AB47")]
    [FieldOffset(Offset = "0x195")]
    private bool mIsTrainingTimeExpantion;
    [Token(Token = "0x400AB48")]
    [FieldOffset(Offset = "0x196")]
    private bool mIsEnergyRecoveryUpExpantion;

    [Token(Token = "0x170016F1")]
    public double TotalEnergyCost
    {
      [Token(Token = "0x600A456"), Address(RVA = "0x66A5D0", Offset = "0x6693D0", VA = "0x1066A5D0")] get
      {
        return new double();
      }
    }

    [Token(Token = "0x170016F2")]
    public TimeSpan EnergyLimitTime
    {
      [Token(Token = "0x600A457"), Address(RVA = "0x66A470", Offset = "0x669270", VA = "0x1066A470")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x170016F3")]
    public int NowEnergy
    {
      [Token(Token = "0x600A458"), Address(RVA = "0x66A5A0", Offset = "0x6693A0", VA = "0x1066A5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016F4")]
    public bool IsAddFrameExpantion
    {
      [Token(Token = "0x600A459"), Address(RVA = "0x66A570", Offset = "0x669370", VA = "0x1066A570")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016F5")]
    public bool IsTrainingTimeExpantion
    {
      [Token(Token = "0x600A45A"), Address(RVA = "0x66A590", Offset = "0x669390", VA = "0x1066A590")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016F6")]
    public bool IsEnergyRecoveryUpExpantion
    {
      [Token(Token = "0x600A45B"), Address(RVA = "0x66A580", Offset = "0x669380", VA = "0x1066A580")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016F7")]
    public static GuildTrainingWindow Instance
    {
      [Token(Token = "0x600A45C"), Address(RVA = "0x66A540", Offset = "0x669340", VA = "0x1066A540")] get
      {
        return (GuildTrainingWindow) null;
      }
    }

    [Token(Token = "0x170016F8")]
    public DateTime CampaignAnimeDate
    {
      [Token(Token = "0x600A45D"), Address(RVA = "0x66A430", Offset = "0x669230", VA = "0x1066A430")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A45E"), Address(RVA = "0x66A5E0", Offset = "0x6693E0", VA = "0x1066A5E0")] private set
      {
      }
    }

    [Token(Token = "0x170016F9")]
    public DateTime DataReceiveTime
    {
      [Token(Token = "0x600A45F"), Address(RVA = "0x66A450", Offset = "0x669250", VA = "0x1066A450")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170016FA")]
    public DateTime StartClientDate
    {
      [Token(Token = "0x600A460"), Address(RVA = "0x66A5B0", Offset = "0x6693B0", VA = "0x1066A5B0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600A461")]
    [Address(RVA = "0x665310", Offset = "0x664110", VA = "0x10665310")]
    public DateTime GetSlotTime() => new DateTime();

    [Token(Token = "0x600A462")]
    [Address(RVA = "0x664C80", Offset = "0x663A80", VA = "0x10664C80")]
    public GuildTrainingExpantionData GetExpantionData(ExpansionPurchaseParam.eType type)
    {
      return (GuildTrainingExpantionData) null;
    }

    [Token(Token = "0x600A463")]
    [Address(RVA = "0x663960", Offset = "0x662760", VA = "0x10663960")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A464")]
    [Address(RVA = "0x666E60", Offset = "0x665C60", VA = "0x10666E60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A465")]
    [Address(RVA = "0x669F40", Offset = "0x668D40", VA = "0x10669F40")]
    private void Update()
    {
    }

    [Token(Token = "0x600A466")]
    [Address(RVA = "0x663720", Offset = "0x662520", VA = "0x10663720", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A467")]
    [Address(RVA = "0x665C30", Offset = "0x664A30", VA = "0x10665C30")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600A468")]
    [Address(RVA = "0x669C70", Offset = "0x668A70", VA = "0x10669C70")]
    private void UpdateView(bool is_update_time = true)
    {
    }

    [Token(Token = "0x600A469")]
    [Address(RVA = "0x669670", Offset = "0x668470", VA = "0x10669670")]
    private void UpdateEnergyTime()
    {
    }

    [Token(Token = "0x600A46A")]
    [Address(RVA = "0x669980", Offset = "0x668780", VA = "0x10669980")]
    private void UpdateViewEnergyTime()
    {
    }

    [Token(Token = "0x600A46B")]
    [Address(RVA = "0x663E50", Offset = "0x662C50", VA = "0x10663E50")]
    private void CheckPopup()
    {
    }

    [Token(Token = "0x600A46C")]
    [Address(RVA = "0x666110", Offset = "0x664F10", VA = "0x10666110")]
    private bool IsCheckPeriodOut() => new bool();

    [Token(Token = "0x600A46D")]
    [Address(RVA = "0x664790", Offset = "0x663590", VA = "0x10664790")]
    public string GetCampaignText() => (string) null;

    [Token(Token = "0x600A46E")]
    [Address(RVA = "0x664D50", Offset = "0x663B50", VA = "0x10664D50")]
    public string GetLockCampaignText(bool isReload = false) => (string) null;

    [Token(Token = "0x600A46F")]
    [Address(RVA = "0x6645F0", Offset = "0x6633F0", VA = "0x106645F0")]
    private string GetCampaignPeriod() => (string) null;

    [Token(Token = "0x600A470")]
    [Address(RVA = "0x664460", Offset = "0x663260", VA = "0x10664460")]
    private string GetCampaignExpantionText() => (string) null;

    [Token(Token = "0x600A471")]
    [Address(RVA = "0x663A80", Offset = "0x662880", VA = "0x10663A80")]
    private int CalcTrainingUnitNum(DateTime now) => new int();

    [Token(Token = "0x600A472")]
    [Address(RVA = "0x663A10", Offset = "0x662810", VA = "0x10663A10")]
    private float CalcCostValue(DateTime date) => new float();

    [Token(Token = "0x600A473")]
    [Address(RVA = "0x663D30", Offset = "0x662B30", VA = "0x10663D30")]
    private int CalcUseCost(DateTime now_date, DateTime base_date) => new int();

    [Token(Token = "0x600A474")]
    [Address(RVA = "0x664E70", Offset = "0x663C70", VA = "0x10664E70")]
    public int GetMaxEnergy() => new int();

    [Token(Token = "0x600A475")]
    [Address(RVA = "0x664E90", Offset = "0x663C90", VA = "0x10664E90")]
    public int GetNowEnergy() => new int();

    [Token(Token = "0x600A476")]
    [Address(RVA = "0x6665B0", Offset = "0x6653B0", VA = "0x106665B0")]
    public bool IsEnableTrainingSetting(string unit_iname) => new bool();

    [Token(Token = "0x600A477")]
    [Address(RVA = "0x666960", Offset = "0x665760", VA = "0x10666960")]
    public bool IsTrainingUnitPeriodOut(string unit_iname) => new bool();

    [Token(Token = "0x600A478")]
    [Address(RVA = "0x666690", Offset = "0x665490", VA = "0x10666690")]
    public bool IsLimitedUnit(string unit_iname) => new bool();

    [Token(Token = "0x600A479")]
    [Address(RVA = "0x666400", Offset = "0x665200", VA = "0x10666400")]
    public int IsEnableCampaign(string unit_iname, bool is_time_campaign) => new int();

    [Token(Token = "0x600A47A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void SetNotification()
    {
    }

    [Token(Token = "0x600A47B")]
    [Address(RVA = "0x664A20", Offset = "0x663820", VA = "0x10664A20")]
    private UnitData[] GetCurrentUnitList() => (UnitData[]) null;

    [Token(Token = "0x600A47C")]
    [Address(RVA = "0x6678E0", Offset = "0x6666E0", VA = "0x106678E0")]
    public void SetCurrentSlotNum(int _slot_num, Transform unit_slot)
    {
    }

    [Token(Token = "0x600A47D")]
    [Address(RVA = "0x6693B0", Offset = "0x6681B0", VA = "0x106693B0")]
    public void SetUnitListData(UnitListRootWindow.ListData _list_data)
    {
    }

    [Token(Token = "0x600A47E")]
    [Address(RVA = "0x667570", Offset = "0x666370", VA = "0x10667570")]
    private void SelectUnit()
    {
    }

    [Token(Token = "0x600A47F")]
    [Address(RVA = "0x6674A0", Offset = "0x6662A0", VA = "0x106674A0")]
    private void RemoveUnit()
    {
    }

    [Token(Token = "0x600A480")]
    [Address(RVA = "0x668CB0", Offset = "0x667AB0", VA = "0x10668CB0")]
    public void SetServerData(
      Json_GuildTrainingData[] training_slots,
      Json_GuildTrainingEnergy energy,
      Json_GuildTrainingReward[] rewards,
      string[] remove_units,
      long receive_time)
    {
    }

    [Token(Token = "0x600A481")]
    [Address(RVA = "0x664D40", Offset = "0x663B40", VA = "0x10664D40")]
    public List<GuildTrainingReward> GetGuildTrainingRewards() => (List<GuildTrainingReward>) null;

    [Token(Token = "0x600A482")]
    [Address(RVA = "0x6653E0", Offset = "0x6641E0", VA = "0x106653E0")]
    public void InitGuildTrainingRewards()
    {
    }

    [Token(Token = "0x600A483")]
    [Address(RVA = "0x664CE0", Offset = "0x663AE0", VA = "0x10664CE0")]
    public GuildTrainingPage GetGuildTrainingPage() => (GuildTrainingPage) null;

    [Token(Token = "0x170016FB")]
    public string GetSetPage
    {
      [Token(Token = "0x600A484"), Address(RVA = "0x66A490", Offset = "0x669290", VA = "0x1066A490")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016FC")]
    public int GetSetSlotNo
    {
      [Token(Token = "0x600A485"), Address(RVA = "0x66A4F0", Offset = "0x6692F0", VA = "0x1066A4F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016FD")]
    public long GetSetUnitIid
    {
      [Token(Token = "0x600A486"), Address(RVA = "0x66A520", Offset = "0x669320", VA = "0x1066A520")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x600A487")]
    [Address(RVA = "0x665410", Offset = "0x664210", VA = "0x10665410")]
    private void InitializePagePullDown()
    {
    }

    [Token(Token = "0x600A488")]
    [Address(RVA = "0x667000", Offset = "0x665E00", VA = "0x10667000")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x600A489")]
    [Address(RVA = "0x666C50", Offset = "0x665A50", VA = "0x10666C50")]
    public void NextPage()
    {
    }

    [Token(Token = "0x600A48A")]
    [Address(RVA = "0x666CB0", Offset = "0x665AB0", VA = "0x10666CB0")]
    private void OnClickPagePullDownItem(int num)
    {
    }

    [Token(Token = "0x600A48B")]
    [Address(RVA = "0x667050", Offset = "0x665E50", VA = "0x10667050")]
    private bool RefreshSlot(int nowEnergy, bool isUpdateTime) => new bool();

    [Token(Token = "0x600A48C")]
    [Address(RVA = "0x665050", Offset = "0x663E50", VA = "0x10665050")]
    private List<GuildTrainingData> GetPageData(int page) => (List<GuildTrainingData>) null;

    [Token(Token = "0x600A48D")]
    [Address(RVA = "0x668510", Offset = "0x667310", VA = "0x10668510")]
    private void SetPageData()
    {
    }

    [Token(Token = "0x600A48E")]
    [Address(RVA = "0x664350", Offset = "0x663150", VA = "0x10664350")]
    private List<GuildTrainingPage> GetAddPageList(string iname, int list_count, int one_page_slot)
    {
      return (List<GuildTrainingPage>) null;
    }

    [Token(Token = "0x600A48F")]
    [Address(RVA = "0x666BC0", Offset = "0x6659C0", VA = "0x10666BC0")]
    private bool IsUpdatePageTime() => new bool();

    [Token(Token = "0x600A490")]
    [Address(RVA = "0x668020", Offset = "0x666E20", VA = "0x10668020")]
    private void SetExpantionExistenceFlag()
    {
    }

    [Token(Token = "0x600A491")]
    [Address(RVA = "0x669480", Offset = "0x668280", VA = "0x10669480")]
    private void SetupExpantionDataDictionary()
    {
    }

    [Token(Token = "0x600A492")]
    [Address(RVA = "0x66A240", Offset = "0x669040", VA = "0x1066A240")]
    public GuildTrainingWindow()
    {
    }
  }
}
