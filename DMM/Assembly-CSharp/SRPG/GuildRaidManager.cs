// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidManager
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
  [Token(Token = "0x200257C")]
  [FlowNode.Pin(203, "GuildRaid Stage Info View", FlowNode.PinTypes.Output, 203)]
  [AddComponentMenu("UI/GuildRaid/GuildRaidManager")]
  [FlowNode.Pin(901, "Error", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(302, "Training Scene Period Reload", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "GuildRaid Training Stage Info View", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(202, "GuildRaid Stage Info", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(11, "Start Challenge", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "Finish Initialize", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(15, "OpenWebview", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(14, "BackArea", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "NextArea", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(12, "Selected GuildRaid", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(102, "Beat Effect Start", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class GuildRaidManager : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400AD4E")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AD4F")]
    public const int PIN_INPUT_CHALLENGE = 11;
    [Token(Token = "0x400AD50")]
    public const int PIN_INPUT_SELECTED = 12;
    [Token(Token = "0x400AD51")]
    public const int PIN_INPUT_NEXTAREA = 13;
    [Token(Token = "0x400AD52")]
    public const int PIN_INPUT_BACKAREA = 14;
    [Token(Token = "0x400AD53")]
    public const int PIN_INPUT_OPEN_WEBVIEW = 15;
    [Token(Token = "0x400AD54")]
    public const int PIN_OUTPUT_FINISH_INIT = 101;
    [Token(Token = "0x400AD55")]
    public const int PIN_OUTPUT_BEAT_EFFECT = 102;
    [Token(Token = "0x400AD56")]
    public const int PIN_OUTPUT_TO_DETAIL = 202;
    [Token(Token = "0x400AD57")]
    public const int PIN_OUTPUT_TO_VIEW = 203;
    [Token(Token = "0x400AD58")]
    public const int PIN_OUTPUT_TO_TRAINING = 301;
    [Token(Token = "0x400AD59")]
    public const int PIN_OUTPUT_TRAINING_RELOAD = 302;
    [Token(Token = "0x400AD5A")]
    public const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400AD5B")]
    public const int DEFAULT_BOSSCOUNT = 5;
    [Token(Token = "0x400AD5C")]
    public const int START_ROUND = 1;
    [Token(Token = "0x400AD5D")]
    [FieldOffset(Offset = "0x0")]
    private static GuildRaidManager mInstance;
    [Token(Token = "0x400AD85")]
    [FieldOffset(Offset = "0xAC")]
    public int CurrentRankingPage;
    [Token(Token = "0x400AD86")]
    [FieldOffset(Offset = "0xB0")]
    public int CurrentRankingPageTotal;
    [Token(Token = "0x400AD89")]
    [FieldOffset(Offset = "0xBC")]
    public int PreviousRankingPage;
    [Token(Token = "0x400AD8A")]
    [FieldOffset(Offset = "0xC0")]
    public int PreviousRankingPageTotal;
    [Token(Token = "0x400AD8D")]
    [FieldOffset(Offset = "0xCC")]
    public GuildRaidManager.GuildRaidRankingType mRankingType;
    [Token(Token = "0x400AD8E")]
    [FieldOffset(Offset = "0xD0")]
    public int CurrentRankingPortPage;
    [Token(Token = "0x400AD8F")]
    [FieldOffset(Offset = "0xD4")]
    public int CurrentRankingPortPageTotal;
    [Token(Token = "0x400AD92")]
    [FieldOffset(Offset = "0xE0")]
    public int PreviousRankingPortPage;
    [Token(Token = "0x400AD93")]
    [FieldOffset(Offset = "0xE4")]
    public int PreviousRankingPortPageTotal;
    [Token(Token = "0x400AD96")]
    [FieldOffset(Offset = "0xF0")]
    public int RankingPortBossPage;
    [Token(Token = "0x400AD97")]
    [FieldOffset(Offset = "0xF4")]
    public int RankingPortBossId;
    [Token(Token = "0x400AD98")]
    [FieldOffset(Offset = "0xF8")]
    public int RankingPortBossPageTotal;
    [Token(Token = "0x400AD9A")]
    [FieldOffset(Offset = "0x100")]
    public int RankingDamageSummaryPage;
    [Token(Token = "0x400AD9B")]
    [FieldOffset(Offset = "0x104")]
    public int RankingDamageSummaryPageTotal;
    [Token(Token = "0x400AD9D")]
    [FieldOffset(Offset = "0x10C")]
    public int RankingDamageRoundPage;
    [Token(Token = "0x400AD9E")]
    [FieldOffset(Offset = "0x110")]
    public int RankingDamageRoundBossId;
    [Token(Token = "0x400AD9F")]
    [FieldOffset(Offset = "0x114")]
    public int RankingDamageRoundRound;
    [Token(Token = "0x400ADA0")]
    [FieldOffset(Offset = "0x118")]
    public int RankingDamageRoundPageTotal;
    [Token(Token = "0x400ADA7")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private GuildRaidArea mAreaPrefab;
    [Token(Token = "0x400ADA8")]
    [FieldOffset(Offset = "0x144")]
    [SerializeField]
    private Transform mAreaTransform;
    [Token(Token = "0x400ADA9")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private GameObject mPeriodTextParent;
    [Token(Token = "0x400ADAA")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    private Text mPeriodText;
    [Token(Token = "0x400ADAB")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private Text mLapText;
    [Token(Token = "0x400ADAC")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    private Button mRefreshButton;
    [Token(Token = "0x400ADAD")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Slider mBpSlider;
    [Token(Token = "0x400ADAE")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    private GameObject mBpSliderLine;
    [Token(Token = "0x400ADAF")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private GameObject mApSliderType;
    [Token(Token = "0x400ADB0")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    private GameObject mApLoopAp;
    [Token(Token = "0x400ADB1")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private GameObject mApLoopPlus;
    [Token(Token = "0x400ADB2")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    private GameObject mApLoopEnd;
    [Token(Token = "0x400ADB3")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private GameObject mApLoopBpRemain;
    [Token(Token = "0x400ADB4")]
    [FieldOffset(Offset = "0x174")]
    [SerializeField]
    private GameObject mApLoopBpEternal;
    [Token(Token = "0x400ADB5")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private GameObject mWebviewButton;
    [Token(Token = "0x400ADB6")]
    [FieldOffset(Offset = "0x17C")]
    [SerializeField]
    private GameObject mWebviewButtonAnimObj;
    [Token(Token = "0x400ADB7")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private List<GameObject> mTrainingObjectList;
    [Token(Token = "0x400ADB8")]
    [FieldOffset(Offset = "0x184")]
    [SerializeField]
    private GameObject mMyReportTrainingBtn;
    [Token(Token = "0x400ADB9")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private GuildRaidTrainingScrollablePulldown mPullDownMenu;
    [Token(Token = "0x400ADBA")]
    [FieldOffset(Offset = "0x18C")]
    [SerializeField]
    private Text mPullDownName;
    [Token(Token = "0x400ADBB")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private GameObject mWebviewTrainingBtn;
    [Token(Token = "0x400ADBC")]
    [FieldOffset(Offset = "0x194")]
    private bool isFirstUpdate;

    [Token(Token = "0x17001722")]
    public static GuildRaidManager Instance
    {
      [Token(Token = "0x600A5F4"), Address(RVA = "0x6854F0", Offset = "0x6842F0", VA = "0x106854F0")] get
      {
        return (GuildRaidManager) null;
      }
    }

    [Token(Token = "0x17001723")]
    public int PeriodId
    {
      [Token(Token = "0x600A5F5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5F6"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17001724")]
    public bool CurrentGuildRaidFinish
    {
      [Token(Token = "0x600A5F7"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600A5F8"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
      {
      }
    }

    [Token(Token = "0x17001725")]
    public int CurrentRound
    {
      [Token(Token = "0x600A5F9"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5FA"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17001726")]
    public int TrialRound
    {
      [Token(Token = "0x600A5FB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5FC"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] set
      {
      }
    }

    [Token(Token = "0x17001727")]
    public int CurrentAreaNo
    {
      [Token(Token = "0x600A5FD"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5FE"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x17001728")]
    public int CurrentBossId
    {
      [Token(Token = "0x600A5FF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A600"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] private set
      {
      }
    }

    [Token(Token = "0x17001729")]
    public int ViewBossId
    {
      [Token(Token = "0x600A601"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600A602"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x1700172A")]
    public int AreaBossCount
    {
      [Token(Token = "0x600A603"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x600A604"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] private set
      {
      }
    }

    [Token(Token = "0x1700172B")]
    public int CurrentBp
    {
      [Token(Token = "0x600A605"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A606"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] private set
      {
      }
    }

    [Token(Token = "0x1700172C")]
    public int MaxBp
    {
      [Token(Token = "0x600A607"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A608"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] private set
      {
      }
    }

    [Token(Token = "0x1700172D")]
    public int ChallengedBp
    {
      [Token(Token = "0x600A609"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
      [Token(Token = "0x600A60A"), Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")] private set
      {
      }
    }

    [Token(Token = "0x1700172E")]
    public int CurrentAp
    {
      [Token(Token = "0x600A60B"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A60C"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] private set
      {
      }
    }

    [Token(Token = "0x1700172F")]
    public int DefaultBp
    {
      [Token(Token = "0x600A60D"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x600A60E"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] private set
      {
      }
    }

    [Token(Token = "0x17001730")]
    public int MaxAp
    {
      [Token(Token = "0x600A60F"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A610"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x17001731")]
    public int RefreshWaitSec
    {
      [Token(Token = "0x600A611"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A612"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
      {
      }
    }

    [Token(Token = "0x17001732")]
    public GuildRaidArea CurrentArea
    {
      [Token(Token = "0x600A613"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (GuildRaidArea) null;
      }
      [Token(Token = "0x600A614"), Address(RVA = "0x288230", Offset = "0x287030", VA = "0x10288230")] private set
      {
      }
    }

    [Token(Token = "0x17001733")]
    public GuildRaidData CurrentData
    {
      [Token(Token = "0x600A615"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (GuildRaidData) null;
      }
      [Token(Token = "0x600A616"), Address(RVA = "0x2B4CC0", Offset = "0x2B3AC0", VA = "0x102B4CC0")] private set
      {
      }
    }

    [Token(Token = "0x17001734")]
    public List<GuildRaidBossInfo> CurrentBossInfoList
    {
      [Token(Token = "0x600A617"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return (List<GuildRaidBossInfo>) null;
      }
      [Token(Token = "0x600A618"), Address(RVA = "0x6855E0", Offset = "0x6843E0", VA = "0x106855E0")] private set
      {
      }
    }

    [Token(Token = "0x17001735")]
    public GuildRaidBossInfo SelectBossInfo
    {
      [Token(Token = "0x600A619"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (GuildRaidBossInfo) null;
      }
      [Token(Token = "0x600A61A"), Address(RVA = "0x53E300", Offset = "0x53D100", VA = "0x1053E300")] private set
      {
      }
    }

    [Token(Token = "0x17001736")]
    public int CurrentOrder
    {
      [Token(Token = "0x600A61B"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
      [Token(Token = "0x600A61C"), Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")] private set
      {
      }
    }

    [Token(Token = "0x17001737")]
    public bool IsForcedDeck
    {
      [Token(Token = "0x600A61D"), Address(RVA = "0x3EA310", Offset = "0x3E9110", VA = "0x103EA310")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001738")]
    public bool IsBeatEffect
    {
      [Token(Token = "0x600A61E"), Address(RVA = "0x685520", Offset = "0x684320", VA = "0x10685520")] get
      {
        return new bool();
      }
      [Token(Token = "0x600A61F"), Address(RVA = "0x6856A0", Offset = "0x6844A0", VA = "0x106856A0")] private set
      {
      }
    }

    [Token(Token = "0x17001739")]
    public int BeatEffectBossId
    {
      [Token(Token = "0x600A620"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A621"), Address(RVA = "0x374A70", Offset = "0x373870", VA = "0x10374A70")] private set
      {
      }
    }

    [Token(Token = "0x1700173A")]
    public GuildRaidManager.GuildRaidBpHealType BpHealType
    {
      [Token(Token = "0x600A622"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new GuildRaidManager.GuildRaidBpHealType();
      }
      [Token(Token = "0x600A623"), Address(RVA = "0x352460", Offset = "0x351260", VA = "0x10352460")] private set
      {
      }
    }

    [Token(Token = "0x1700173B")]
    public int HealBp
    {
      [Token(Token = "0x600A624"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return new int();
      }
      [Token(Token = "0x600A625"), Address(RVA = "0x370630", Offset = "0x36F430", VA = "0x10370630")] private set
      {
      }
    }

    [Token(Token = "0x1700173C")]
    public int PortRankingRank
    {
      [Token(Token = "0x600A626"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A627"), Address(RVA = "0x55F7A0", Offset = "0x55E5A0", VA = "0x1055F7A0")] private set
      {
      }
    }

    [Token(Token = "0x1700173D")]
    public List<GuildRaidChallengingPlayer> CurrentBossChallengingPlayerList
    {
      [Token(Token = "0x600A628"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (List<GuildRaidChallengingPlayer>) null;
      }
      [Token(Token = "0x600A629"), Address(RVA = "0x288B00", Offset = "0x287900", VA = "0x10288B00")] private set
      {
      }
    }

    [Token(Token = "0x1700173E")]
    public GuildRaidBattleType BattleType
    {
      [Token(Token = "0x600A62A"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return new GuildRaidBattleType();
      }
      [Token(Token = "0x600A62B"), Address(RVA = "0x5FE320", Offset = "0x5FD120", VA = "0x105FE320")] set
      {
      }
    }

    [Token(Token = "0x1700173F")]
    public List<UnitData> ForcedDeck
    {
      [Token(Token = "0x600A62C"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600A62D"), Address(RVA = "0x550160", Offset = "0x54EF60", VA = "0x10550160")] private set
      {
      }
    }

    [Token(Token = "0x17001740")]
    public List<string> UsedUnitInameList
    {
      [Token(Token = "0x600A62E"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x600A62F"), Address(RVA = "0x5A4130", Offset = "0x5A2F30", VA = "0x105A4130")] private set
      {
      }
    }

    [Token(Token = "0x17001741")]
    public DateTime RefreshWaitStarted
    {
      [Token(Token = "0x600A630"), Address(RVA = "0x6855A0", Offset = "0x6843A0", VA = "0x106855A0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A631"), Address(RVA = "0x685830", Offset = "0x684630", VA = "0x10685830")] private set
      {
      }
    }

    [Token(Token = "0x17001742")]
    public bool IsReceiveMail
    {
      [Token(Token = "0x600A632"), Address(RVA = "0x685530", Offset = "0x684330", VA = "0x10685530")] get
      {
        return new bool();
      }
      [Token(Token = "0x600A633"), Address(RVA = "0x6856B0", Offset = "0x6844B0", VA = "0x106856B0")] private set
      {
      }
    }

    [Token(Token = "0x17001743")]
    public List<GuildRaidMailListItem> MailCurrentPageItemList
    {
      [Token(Token = "0x600A634"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return (List<GuildRaidMailListItem>) null;
      }
      [Token(Token = "0x600A635"), Address(RVA = "0x2B6120", Offset = "0x2B4F20", VA = "0x102B6120")] private set
      {
      }
    }

    [Token(Token = "0x17001744")]
    public GuildRaidMailOption MailCurrentOption
    {
      [Token(Token = "0x600A636"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (GuildRaidMailOption) null;
      }
      [Token(Token = "0x600A637"), Address(RVA = "0x6856D0", Offset = "0x6844D0", VA = "0x106856D0")] private set
      {
      }
    }

    [Token(Token = "0x17001745")]
    public int MailCurrentPage
    {
      [Token(Token = "0x600A638"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return new int();
      }
      [Token(Token = "0x600A639"), Address(RVA = "0x6856F0", Offset = "0x6844F0", VA = "0x106856F0")] private set
      {
      }
    }

    [Token(Token = "0x17001746")]
    public List<int> MailReceivingIdList
    {
      [Token(Token = "0x600A63A"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600A63B"), Address(RVA = "0x685730", Offset = "0x684530", VA = "0x10685730")] private set
      {
      }
    }

    [Token(Token = "0x17001747")]
    public List<GuildRaidMailListItem> MailReceiveItemList
    {
      [Token(Token = "0x600A63C"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (List<GuildRaidMailListItem>) null;
      }
      [Token(Token = "0x600A63D"), Address(RVA = "0x685710", Offset = "0x684510", VA = "0x10685710")] private set
      {
      }
    }

    [Token(Token = "0x17001748")]
    public List<int> MailToGiftItemIdList
    {
      [Token(Token = "0x600A63E"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600A63F"), Address(RVA = "0x685750", Offset = "0x684550", VA = "0x10685750")] private set
      {
      }
    }

    [Token(Token = "0x17001749")]
    public int BtlTrun
    {
      [Token(Token = "0x600A640"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A641"), Address(RVA = "0x6855C0", Offset = "0x6843C0", VA = "0x106855C0")] private set
      {
      }
    }

    [Token(Token = "0x1700174A")]
    public bool IsNeedGuildRaidReq
    {
      [Token(Token = "0x600A642"), Address(RVA = "0x5FC050", Offset = "0x5FAE50", VA = "0x105FC050")] get
      {
        return new bool();
      }
      [Token(Token = "0x600A643"), Address(RVA = "0x5FC150", Offset = "0x5FAF50", VA = "0x105FC150")] private set
      {
      }
    }

    [Token(Token = "0x1700174B")]
    public List<GuildRaidRanking> CurrentRankingList
    {
      [Token(Token = "0x600A644"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (List<GuildRaidRanking>) null;
      }
      [Token(Token = "0x600A645"), Address(RVA = "0x685600", Offset = "0x684400", VA = "0x10685600")] private set
      {
      }
    }

    [Token(Token = "0x1700174C")]
    public GuildRaidRanking CurrentRankingSelf
    {
      [Token(Token = "0x600A646"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return (GuildRaidRanking) null;
      }
      [Token(Token = "0x600A647"), Address(RVA = "0x685660", Offset = "0x684460", VA = "0x10685660")] private set
      {
      }
    }

    [Token(Token = "0x1700174D")]
    public List<GuildRaidRanking> PreviousRankingList
    {
      [Token(Token = "0x600A648"), Address(RVA = "0x5FBFF0", Offset = "0x5FADF0", VA = "0x105FBFF0")] get
      {
        return (List<GuildRaidRanking>) null;
      }
      [Token(Token = "0x600A649"), Address(RVA = "0x5FC070", Offset = "0x5FAE70", VA = "0x105FC070")] private set
      {
      }
    }

    [Token(Token = "0x1700174E")]
    public GuildRaidRanking PreviousRankingSelf
    {
      [Token(Token = "0x600A64A"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return (GuildRaidRanking) null;
      }
      [Token(Token = "0x600A64B"), Address(RVA = "0x45A300", Offset = "0x459100", VA = "0x1045A300")] private set
      {
      }
    }

    [Token(Token = "0x1700174F")]
    public List<GuildRaidRankingMember> CurrentRankingPortList
    {
      [Token(Token = "0x600A64C"), Address(RVA = "0x6854B0", Offset = "0x6842B0", VA = "0x106854B0")] get
      {
        return (List<GuildRaidRankingMember>) null;
      }
      [Token(Token = "0x600A64D"), Address(RVA = "0x685620", Offset = "0x684420", VA = "0x10685620")] private set
      {
      }
    }

    [Token(Token = "0x17001750")]
    public GuildRaidRankingMember CurrentRankingPortSelf
    {
      [Token(Token = "0x600A64E"), Address(RVA = "0x6854C0", Offset = "0x6842C0", VA = "0x106854C0")] get
      {
        return (GuildRaidRankingMember) null;
      }
      [Token(Token = "0x600A64F"), Address(RVA = "0x685640", Offset = "0x684440", VA = "0x10685640")] private set
      {
      }
    }

    [Token(Token = "0x17001751")]
    public List<GuildRaidRankingMember> PreviousRankingPortList
    {
      [Token(Token = "0x600A650"), Address(RVA = "0x45A220", Offset = "0x459020", VA = "0x1045A220")] get
      {
        return (List<GuildRaidRankingMember>) null;
      }
      [Token(Token = "0x600A651"), Address(RVA = "0x45A2E0", Offset = "0x4590E0", VA = "0x1045A2E0")] private set
      {
      }
    }

    [Token(Token = "0x17001752")]
    public GuildRaidRankingMember PreviousRankingPortSelf
    {
      [Token(Token = "0x600A652"), Address(RVA = "0x6718F0", Offset = "0x6706F0", VA = "0x106718F0")] get
      {
        return (GuildRaidRankingMember) null;
      }
      [Token(Token = "0x600A653"), Address(RVA = "0x6857B0", Offset = "0x6845B0", VA = "0x106857B0")] private set
      {
      }
    }

    [Token(Token = "0x17001753")]
    public List<GuildRaidRankingMember> RankingPortBossList
    {
      [Token(Token = "0x600A654"), Address(RVA = "0x685590", Offset = "0x684390", VA = "0x10685590")] get
      {
        return (List<GuildRaidRankingMember>) null;
      }
      [Token(Token = "0x600A655"), Address(RVA = "0x685810", Offset = "0x684610", VA = "0x10685810")] private set
      {
      }
    }

    [Token(Token = "0x17001754")]
    public List<GuildRaidRankingDamage> RankingDamageSummaryList
    {
      [Token(Token = "0x600A656"), Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x106718E0")] get
      {
        return (List<GuildRaidRankingDamage>) null;
      }
      [Token(Token = "0x600A657"), Address(RVA = "0x6857F0", Offset = "0x6845F0", VA = "0x106857F0")] private set
      {
      }
    }

    [Token(Token = "0x17001755")]
    public List<GuildRaidRankingDamage> RankingDamageRoundList
    {
      [Token(Token = "0x600A658"), Address(RVA = "0x685580", Offset = "0x684380", VA = "0x10685580")] get
      {
        return (List<GuildRaidRankingDamage>) null;
      }
      [Token(Token = "0x600A659"), Address(RVA = "0x6857D0", Offset = "0x6845D0", VA = "0x106857D0")] private set
      {
      }
    }

    [Token(Token = "0x17001756")]
    public DateTime PeriodBeginAt
    {
      [Token(Token = "0x600A65A"), Address(RVA = "0x685540", Offset = "0x684340", VA = "0x10685540")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A65B"), Address(RVA = "0x685770", Offset = "0x684570", VA = "0x10685770")] private set
      {
      }
    }

    [Token(Token = "0x17001757")]
    public DateTime PeriodEndAt
    {
      [Token(Token = "0x600A65C"), Address(RVA = "0x685560", Offset = "0x684360", VA = "0x10685560")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A65D"), Address(RVA = "0x685790", Offset = "0x684590", VA = "0x10685790")] private set
      {
      }
    }

    [Token(Token = "0x17001758")]
    public DateTime EntranceEndAt
    {
      [Token(Token = "0x600A65E"), Address(RVA = "0x6854D0", Offset = "0x6842D0", VA = "0x106854D0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600A65F"), Address(RVA = "0x685680", Offset = "0x684480", VA = "0x10685680")] private set
      {
      }
    }

    [Token(Token = "0x17001759")]
    public int SelectedPeriodIndex
    {
      [Token(Token = "0x600A660"), Address(RVA = "0x349630", Offset = "0x348430", VA = "0x10349630")] get
      {
        return new int();
      }
      [Token(Token = "0x600A661"), Address(RVA = "0x685850", Offset = "0x684650", VA = "0x10685850")] private set
      {
      }
    }

    [Token(Token = "0x1700175A")]
    public List<GuildRaidTrainingPeriod> TrainingDataList
    {
      [Token(Token = "0x600A662"), Address(RVA = "0x5B2840", Offset = "0x5B1640", VA = "0x105B2840")] get
      {
        return (List<GuildRaidTrainingPeriod>) null;
      }
      [Token(Token = "0x600A663"), Address(RVA = "0x685870", Offset = "0x684670", VA = "0x10685870")] private set
      {
      }
    }

    [Token(Token = "0x600A664")]
    [Address(RVA = "0x681000", Offset = "0x67FE00", VA = "0x10681000")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A665")]
    [Address(RVA = "0x681990", Offset = "0x680790", VA = "0x10681990")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A666")]
    [Address(RVA = "0x6852A0", Offset = "0x6840A0", VA = "0x106852A0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A667")]
    [Address(RVA = "0x680C80", Offset = "0x67FA80", VA = "0x10680C80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A668")]
    [Address(RVA = "0x681B40", Offset = "0x680940", VA = "0x10681B40")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A669")]
    [Address(RVA = "0x682C60", Offset = "0x681A60", VA = "0x10682C60")]
    public void SetUpObjectsByTrainingMode()
    {
    }

    [Token(Token = "0x600A66A")]
    [Address(RVA = "0x684990", Offset = "0x683790", VA = "0x10684990")]
    private void SetupPullDownButton()
    {
    }

    [Token(Token = "0x600A66B")]
    [Address(RVA = "0x681150", Offset = "0x67FF50", VA = "0x10681150")]
    private void CallBackOnPullDownMenu(int value)
    {
    }

    [Token(Token = "0x600A66C")]
    [Address(RVA = "0x681210", Offset = "0x680010", VA = "0x10681210")]
    private void CallBackOnPullDownSelf(bool value)
    {
    }

    [Token(Token = "0x600A66D")]
    [Address(RVA = "0x682B40", Offset = "0x681940", VA = "0x10682B40")]
    public void SetPullDownSelection(int value)
    {
    }

    [Token(Token = "0x600A66E")]
    [Address(RVA = "0x682F80", Offset = "0x681D80", VA = "0x10682F80")]
    public static void SettingRoundTrialByCurrent()
    {
    }

    [Token(Token = "0x600A66F")]
    [Address(RVA = "0x681710", Offset = "0x680510", VA = "0x10681710")]
    public bool IsPeriodEndAt() => new bool();

    [Token(Token = "0x600A670")]
    [Address(RVA = "0x683740", Offset = "0x682540", VA = "0x10683740")]
    public void SetupCurrentData(JSON_GuildRaidCurrent json)
    {
    }

    [Token(Token = "0x600A671")]
    [Address(RVA = "0x6844D0", Offset = "0x6832D0", VA = "0x106844D0")]
    public void SetupPrevData(JSON_GuildRaidPrev json)
    {
    }

    [Token(Token = "0x600A672")]
    [Address(RVA = "0x683420", Offset = "0x682220", VA = "0x10683420")]
    public void SetupBossInfo(JSON_GuildRaidBossInfo json)
    {
    }

    [Token(Token = "0x600A673")]
    [Address(RVA = "0x683140", Offset = "0x681F40", VA = "0x10683140")]
    public void SetupBossInfoList(JSON_GuildRaidBossInfo[] json)
    {
    }

    [Token(Token = "0x600A674")]
    [Address(RVA = "0x55F7A0", Offset = "0x55E5A0", VA = "0x1055F7A0")]
    public void SetupRankingRank(int rank)
    {
    }

    [Token(Token = "0x600A675")]
    [Address(RVA = "0x683630", Offset = "0x682430", VA = "0x10683630")]
    public void SetupChallengingPlayers(JSON_GuildRaidChallengingPlayer[] json)
    {
    }

    [Token(Token = "0x600A676")]
    [Address(RVA = "0x683000", Offset = "0x681E00", VA = "0x10683000")]
    public void SetupBattlePoint(JSON_GuildRaidBattlePoint json)
    {
    }

    [Token(Token = "0x600A677")]
    [Address(RVA = "0x683BF0", Offset = "0x6829F0", VA = "0x10683BF0")]
    public void SetupForcedDeck(Json_Unit[] json, JSON_PlayerBuff _player_buff)
    {
    }

    [Token(Token = "0x600A678")]
    [Address(RVA = "0x684FA0", Offset = "0x683DA0", VA = "0x10684FA0")]
    public void SetupSelectedUnits(string[] json)
    {
    }

    [Token(Token = "0x600A679")]
    [Address(RVA = "0x684F40", Offset = "0x683D40", VA = "0x10684F40")]
    public void SetupRefreshWaitSec(int refreshWaitSec)
    {
    }

    [Token(Token = "0x600A67A")]
    [Address(RVA = "0x683F20", Offset = "0x682D20", VA = "0x10683F20")]
    public void SetupIsReceiveMail(int receiveMailCount)
    {
    }

    [Token(Token = "0x600A67B")]
    [Address(RVA = "0x6842B0", Offset = "0x6830B0", VA = "0x106842B0")]
    public void SetupMail(JSON_GuildRaidMail json)
    {
    }

    [Token(Token = "0x600A67C")]
    [Address(RVA = "0x683F40", Offset = "0x682D40", VA = "0x10683F40")]
    public void SetupMailReceived(JSON_GuildRaidMailListItem[] json)
    {
    }

    [Token(Token = "0x600A67D")]
    [Address(RVA = "0x684200", Offset = "0x683000", VA = "0x10684200")]
    public void SetupMailToGiftList(int[] ids)
    {
    }

    [Token(Token = "0x600A67E")]
    [Address(RVA = "0x683870", Offset = "0x682670", VA = "0x10683870")]
    public void SetupCurrentRankingList(JSON_GuildRaidRanking[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A67F")]
    [Address(RVA = "0x683B50", Offset = "0x682950", VA = "0x10683B50")]
    public void SetupCurrentRankingSelf(JSON_GuildRaidRanking json)
    {
    }

    [Token(Token = "0x600A680")]
    [Address(RVA = "0x6844F0", Offset = "0x6832F0", VA = "0x106844F0")]
    public void SetupPreviousRankingList(JSON_GuildRaidRanking[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A681")]
    [Address(RVA = "0x6848F0", Offset = "0x6836F0", VA = "0x106848F0")]
    public void SetupPreviousRankingSelf(JSON_GuildRaidRanking json)
    {
    }

    [Token(Token = "0x600A682")]
    [Address(RVA = "0x683990", Offset = "0x682790", VA = "0x10683990")]
    public void SetupCurrentRankingPortList(JSON_GuildRaidRankingMember[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A683")]
    [Address(RVA = "0x683AB0", Offset = "0x6828B0", VA = "0x10683AB0")]
    public void SetupCurrentRankingPortSelf(JSON_GuildRaidRankingMember json)
    {
    }

    [Token(Token = "0x600A684")]
    [Address(RVA = "0x684730", Offset = "0x683530", VA = "0x10684730")]
    public void SetupPreviousRankingPortList(JSON_GuildRaidRankingMember[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A685")]
    [Address(RVA = "0x684850", Offset = "0x683650", VA = "0x10684850")]
    public void SetupPreviousRankingPortSelf(JSON_GuildRaidRankingMember json)
    {
    }

    [Token(Token = "0x600A686")]
    [Address(RVA = "0x684610", Offset = "0x683410", VA = "0x10684610")]
    public void SetupPreviousRankingPortBoss(JSON_GuildRaidRankingMember[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A687")]
    [Address(RVA = "0x684E20", Offset = "0x683C20", VA = "0x10684E20")]
    public void SetupRankingDamageSummary(JSON_GuildRaidRankingDamage[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A688")]
    [Address(RVA = "0x684D00", Offset = "0x683B00", VA = "0x10684D00")]
    public void SetupRankingDamageRound(JSON_GuildRaidRankingDamage[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A689")]
    [Address(RVA = "0x683D90", Offset = "0x682B90", VA = "0x10683D90")]
    public void SetupGuildRaidTrainingPeriods(JSON_GuildRaidTrainingPeriod[] jsons)
    {
    }

    [Token(Token = "0x600A68A")]
    [Address(RVA = "0x683D70", Offset = "0x682B70", VA = "0x10683D70")]
    public void SetupGuildRaidTrainingCurrentData()
    {
    }

    [Token(Token = "0x600A68B")]
    [Address(RVA = "0x680F20", Offset = "0x67FD20", VA = "0x10680F20")]
    public void AddMailReceivingIdList(int giftId)
    {
    }

    [Token(Token = "0x600A68C")]
    [Address(RVA = "0x6829C0", Offset = "0x6817C0", VA = "0x106829C0")]
    public void ResetMailReceivingIdList()
    {
    }

    [Token(Token = "0x600A68D")]
    [Address(RVA = "0x685170", Offset = "0x683F70", VA = "0x10685170")]
    private void SwitchArea(int round_index)
    {
    }

    [Token(Token = "0x600A68E")]
    [Address(RVA = "0x6850E0", Offset = "0x683EE0", VA = "0x106850E0")]
    public void StartChallenge()
    {
    }

    [Token(Token = "0x600A68F")]
    [Address(RVA = "0x681090", Offset = "0x67FE90", VA = "0x10681090")]
    public GuildRaidBossParam BeatedGuildRaidBossList(int round, int area_no)
    {
      return (GuildRaidBossParam) null;
    }

    [Token(Token = "0x600A690")]
    [Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")]
    public bool IsFinishGuildRaid() => new bool();

    [Token(Token = "0x600A691")]
    [Address(RVA = "0x681660", Offset = "0x680460", VA = "0x10681660")]
    public bool IsLastArea() => new bool();

    [Token(Token = "0x600A692")]
    [Address(RVA = "0x685040", Offset = "0x683E40", VA = "0x10685040")]
    public void ShowDetail(GuildRaidBossParam bossParam)
    {
    }

    [Token(Token = "0x600A693")]
    [Address(RVA = "0x681260", Offset = "0x680060", VA = "0x10681260")]
    public int GetBossNo(GuildRaidBossParam bossParam) => new int();

    [Token(Token = "0x600A694")]
    [Address(RVA = "0x681AF0", Offset = "0x6808F0", VA = "0x10681AF0")]
    public void ReSetRefreshWaitSec()
    {
    }

    [Token(Token = "0x600A695")]
    [Address(RVA = "0x682BD0", Offset = "0x6819D0", VA = "0x10682BD0")]
    public void SetRefreshButton()
    {
    }

    [Token(Token = "0x600A696")]
    [Address(RVA = "0x6818B0", Offset = "0x6806B0", VA = "0x106818B0")]
    public bool IsRefreshConfirm() => new bool();

    [Token(Token = "0x600A697")]
    [Address(RVA = "0x6817B0", Offset = "0x6805B0", VA = "0x106817B0")]
    public bool IsRefreshConfirmBossData() => new bool();

    [Token(Token = "0x600A698")]
    [Address(RVA = "0x6815A0", Offset = "0x6803A0", VA = "0x106815A0")]
    public bool IsCloseSchedule() => new bool();

    [Token(Token = "0x600A699")]
    [Address(RVA = "0x6813E0", Offset = "0x6801E0", VA = "0x106813E0")]
    public bool IsBossChallenge(GuildRaidBossInfo info) => new bool();

    [Token(Token = "0x600A69A")]
    [Address(RVA = "0x6814C0", Offset = "0x6802C0", VA = "0x106814C0")]
    public bool IsBossTrial(GuildRaidBossInfo info) => new bool();

    [Token(Token = "0x600A69B")]
    [Address(RVA = "0x682A50", Offset = "0x681850", VA = "0x10682A50")]
    public void SetAreaBossOverflow(int cnt)
    {
    }

    [Token(Token = "0x600A69C")]
    [Address(RVA = "0x682A70", Offset = "0x681870", VA = "0x10682A70")]
    public static void SetNotifyPush(int cnt = 0)
    {
    }

    [Token(Token = "0x600A69D")]
    [Address(RVA = "0x681280", Offset = "0x680080", VA = "0x10681280", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600A69E")]
    [Address(RVA = "0x6819D0", Offset = "0x6807D0", VA = "0x106819D0")]
    public void OpenWebview()
    {
    }

    [Token(Token = "0x600A69F")]
    [Address(RVA = "0x685400", Offset = "0x684200", VA = "0x10685400")]
    public GuildRaidManager()
    {
    }

    [Token(Token = "0x200257D")]
    public enum GuildRaidScheduleType
    {
      [Token(Token = "0x400ADBE")] Open,
      [Token(Token = "0x400ADBF")] Close,
      [Token(Token = "0x400ADC0")] OpenSchedule,
      [Token(Token = "0x400ADC1")] CloseSchedule,
    }

    [Token(Token = "0x200257E")]
    public enum GuildRaidRankingType
    {
      [Token(Token = "0x400ADC3")] Current,
      [Token(Token = "0x400ADC4")] Previous,
    }

    [Token(Token = "0x200257F")]
    public enum GuildRaidApDrawType
    {
      [Token(Token = "0x400ADC6")] Slider,
      [Token(Token = "0x400ADC7")] Loop,
    }

    [Token(Token = "0x2002580")]
    public enum GuildRaidBpHealType
    {
      [Token(Token = "0x400ADC9")] Normal,
      [Token(Token = "0x400ADCA")] Nothing,
      [Token(Token = "0x400ADCB")] Eternal,
    }
  }
}
