// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002130")]
  [FlowNode.Pin(1025, "塔へ移動", FlowNode.PinTypes.Output, 1401)]
  [FlowNode.Pin(1027, "初心者イベントクエスト選択へ移動", FlowNode.PinTypes.Output, 1501)]
  [FlowNode.Pin(1028, "初心者の館へ移動", FlowNode.PinTypes.Output, 1502)]
  [FlowNode.Pin(1029, "真理念装へ移動", FlowNode.PinTypes.Output, 1601)]
  [FlowNode.Pin(1031, "お知らせへ移動", FlowNode.PinTypes.Output, 1603)]
  [FlowNode.Pin(1032, "フレンド画面へ移動", FlowNode.PinTypes.Output, 1604)]
  [FlowNode.Pin(1033, "ホームへ移動", FlowNode.PinTypes.Output, 1605)]
  [FlowNode.Pin(1035, "創世編へ移動", FlowNode.PinTypes.Output, 1606)]
  [FlowNode.Pin(1038, "レイドへ移動", FlowNode.PinTypes.Output, 1038)]
  [FlowNode.Pin(1037, "アルケミィポートへ移動", FlowNode.PinTypes.Output, 1037)]
  [FlowNode.Pin(1039, "ポートレイドへ移動", FlowNode.PinTypes.Output, 1039)]
  [FlowNode.Pin(1043, "派遣クエストへ移動", FlowNode.PinTypes.Output, 1701)]
  [FlowNode.Pin(1044, "ポイントクエストへ移動", FlowNode.PinTypes.Output, 1702)]
  [FlowNode.Pin(1045, "ポイントクエストTOPへ移動", FlowNode.PinTypes.Output, 1703)]
  [FlowNode.Pin(1046, "ワールドレイドへ移動", FlowNode.PinTypes.Output, 1704)]
  [FlowNode.Pin(1047, "PvEへ移動", FlowNode.PinTypes.Output, 1705)]
  [AddComponentMenu("UI/ChallengeMissionProgress")]
  [FlowNode.Pin(1024, "武具進化画面へ移動", FlowNode.PinTypes.Output, 1304)]
  [FlowNode.Pin(1036, "新イベントへ移動", FlowNode.PinTypes.Output, 1607)]
  [FlowNode.Pin(1023, "武具強化画面へ移動", FlowNode.PinTypes.Output, 1302)]
  [FlowNode.Pin(1030, "カルマへ移動", FlowNode.PinTypes.Output, 1602)]
  [FlowNode.Pin(1041, "ポートショップへ移動", FlowNode.PinTypes.Output, 1211)]
  [FlowNode.Pin(1006, "エリートクエスト選択へ移動", FlowNode.PinTypes.Output, 1007)]
  [FlowNode.Pin(1005, "マルチプレイへ移動", FlowNode.PinTypes.Output, 1006)]
  [FlowNode.Pin(1003, "装備強化画面へ移動", FlowNode.PinTypes.Output, 1005)]
  [FlowNode.Pin(1022, "武具錬成画面へ移動", FlowNode.PinTypes.Output, 1301)]
  [FlowNode.Pin(1002, "アビリティ強化画面へ移動", FlowNode.PinTypes.Output, 1004)]
  [FlowNode.Pin(1004, "ゴールド購入画面へ移動", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1007, "イベントクエスト選択へ移動", FlowNode.PinTypes.Output, 1008)]
  [FlowNode.Pin(1001, "クエスト選択へ移動", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(100, "キャンセル", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "ヘルプ表示", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "パネル表示", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Close", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1000, "ガチャへ移動", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1008, "アリーナへ移動", FlowNode.PinTypes.Output, 1009)]
  [FlowNode.Pin(1026, "対戦へ移動", FlowNode.PinTypes.Output, 1402)]
  [FlowNode.Pin(1009, "ユニット強化画面へ移動", FlowNode.PinTypes.Output, 1101)]
  [FlowNode.Pin(1010, "ユニットアビリティセット画面へ移動", FlowNode.PinTypes.Output, 1102)]
  [FlowNode.Pin(1011, "ユニットジョブ画面へ移動", FlowNode.PinTypes.Output, 1103)]
  [FlowNode.Pin(1012, "ユニット選択へ移動", FlowNode.PinTypes.Output, 1104)]
  [FlowNode.Pin(1040, "限定ショップへ移動", FlowNode.PinTypes.Output, 1210)]
  [FlowNode.Pin(1021, "武具の店へ移動", FlowNode.PinTypes.Output, 1209)]
  [FlowNode.Pin(1020, "魂の交換所へ移動", FlowNode.PinTypes.Output, 1208)]
  [FlowNode.Pin(1019, "マルチ交換所へ移動", FlowNode.PinTypes.Output, 1207)]
  [FlowNode.Pin(1018, "闘技場交換所へ移動", FlowNode.PinTypes.Output, 1206)]
  [FlowNode.Pin(1013, "アンナの店へ移動", FlowNode.PinTypes.Output, 1201)]
  [FlowNode.Pin(1017, "ツアーの店へ移動", FlowNode.PinTypes.Output, 1205)]
  [FlowNode.Pin(1016, "ソウルショップへ移動", FlowNode.PinTypes.Output, 1204)]
  [FlowNode.Pin(1015, "ルイザの店へ移動", FlowNode.PinTypes.Output, 1203)]
  [FlowNode.Pin(1014, "マリアの店へ移動", FlowNode.PinTypes.Output, 1202)]
  [FlowNode.Pin(1042, "新闘技場へ移動", FlowNode.PinTypes.Output, 1010)]
  public class ChallengeMissionProgress : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009035")]
    public const int PIN_OPEN = 0;
    [Token(Token = "0x4009036")]
    public const int PIN_CLOSE = 1;
    [Token(Token = "0x4009037")]
    public const int PIN_REFRESH = 2;
    [Token(Token = "0x4009038")]
    public const int PIN_SHOW_PANEL = 10;
    [Token(Token = "0x4009039")]
    public const int PIN_SHOW_HELP = 11;
    [Token(Token = "0x400903A")]
    public const int PIN_CANCEL = 100;
    [Token(Token = "0x400903B")]
    public const int PIN_GOTO_GACHA = 1000;
    [Token(Token = "0x400903C")]
    public const int PIN_GOTO_QUEST = 1001;
    [Token(Token = "0x400903D")]
    public const int PIN_GOTO_ABILITY = 1002;
    [Token(Token = "0x400903E")]
    public const int PIN_GOTO_SOUBI = 1003;
    [Token(Token = "0x400903F")]
    public const int PIN_GOTO_BUYGOLD = 1004;
    [Token(Token = "0x4009040")]
    public const int PIN_GOTO_MULTI = 1005;
    [Token(Token = "0x4009041")]
    public const int PIN_GOTO_ELITE = 1006;
    [Token(Token = "0x4009042")]
    public const int PIN_GOTO_EVENT = 1007;
    [Token(Token = "0x4009043")]
    public const int PIN_GOTO_ARENA = 1008;
    [Token(Token = "0x4009044")]
    public const int PIN_GOTO_UNIT_STR = 1009;
    [Token(Token = "0x4009045")]
    public const int PIN_GOTO_ABILITYSET = 1010;
    [Token(Token = "0x4009046")]
    public const int PIN_GOTO_UNIT_JOB = 1011;
    [Token(Token = "0x4009047")]
    public const int PIN_GOTO_UNIT = 1012;
    [Token(Token = "0x4009048")]
    public const int PIN_GOTO_SHOP_NORMAL = 1013;
    [Token(Token = "0x4009049")]
    public const int PIN_GOTO_SHOP_TABI = 1014;
    [Token(Token = "0x400904A")]
    public const int PIN_GOTO_SHOP_KIMAGRE = 1015;
    [Token(Token = "0x400904B")]
    public const int PIN_GOTO_SHOP_MONOZUKI = 1016;
    [Token(Token = "0x400904C")]
    public const int PIN_GOTO_SHOP_TOUR = 1017;
    [Token(Token = "0x400904D")]
    public const int PIN_GOTO_SHOP_ARENA = 1018;
    [Token(Token = "0x400904E")]
    public const int PIN_GOTO_SHOP_MULTI = 1019;
    [Token(Token = "0x400904F")]
    public const int PIN_GOTO_SHOP_KAKERA = 1020;
    [Token(Token = "0x4009050")]
    public const int PIN_GOTO_SHOP_ARTIFACT = 1021;
    [Token(Token = "0x4009051")]
    public const int PIN_GOTO_ATF_TRANS = 1022;
    [Token(Token = "0x4009052")]
    public const int PIN_GOTO_ATF_STRTH = 1023;
    [Token(Token = "0x4009053")]
    public const int PIN_GOTO_ATF_EVOLT = 1024;
    [Token(Token = "0x4009054")]
    public const int PIN_GOTO_TOWER = 1025;
    [Token(Token = "0x4009055")]
    public const int PIN_GOTO_VERSUS = 1026;
    [Token(Token = "0x4009056")]
    public const int PIN_GOTO_EVENT_BEGINEER = 1027;
    [Token(Token = "0x4009057")]
    public const int PIN_GOTO_BEGINNERTOP = 1028;
    [Token(Token = "0x4009058")]
    public const int PIN_GOTO_CONCEPTCARD = 1029;
    [Token(Token = "0x4009059")]
    public const int PIN_GOTO_ORDEAL = 1030;
    [Token(Token = "0x400905A")]
    public const int PIN_GOTO_NEWS = 1031;
    [Token(Token = "0x400905B")]
    public const int PIN_GOTO_FRIEND = 1032;
    [Token(Token = "0x400905C")]
    public const int PIN_GOTO_HOME = 1033;
    [Token(Token = "0x400905D")]
    public const int PIN_GOTO_GENESIS = 1035;
    [Token(Token = "0x400905E")]
    public const int PIN_GOTO_ADVANCE = 1036;
    [Token(Token = "0x400905F")]
    public const int PIN_GOTO_GUILD = 1037;
    [Token(Token = "0x4009060")]
    public const int PIN_GOTO_RAIDBOSS = 1038;
    [Token(Token = "0x4009061")]
    public const int PIN_GOTO_GUILDRAIDBOSS = 1039;
    [Token(Token = "0x4009062")]
    public const int PIN_GOTO_SHOP_LIMITED = 1040;
    [Token(Token = "0x4009063")]
    public const int PIN_GOTO_SHOP_PORT = 1041;
    [Token(Token = "0x4009064")]
    public const int PIN_GOTO_DUEL = 1042;
    [Token(Token = "0x4009065")]
    public const int PIN_GOTO_ADVENTURE = 1043;
    [Token(Token = "0x4009066")]
    public const int PIN_GOTO_POINTQUEST = 1044;
    [Token(Token = "0x4009067")]
    public const int PIN_GOTO_POINTQUEST_TOP = 1045;
    [Token(Token = "0x4009068")]
    public const int PIN_GOTO_WORLDRAID = 1046;
    [Token(Token = "0x4009069")]
    public const int PIN_GOTO_LEAGUEMATCH = 1047;
    [Token(Token = "0x400906A")]
    [FieldOffset(Offset = "0xC")]
    public Button ButtonHelp;
    [Token(Token = "0x400906B")]
    [FieldOffset(Offset = "0x10")]
    public Button ButtonDetail;
    [Token(Token = "0x400906C")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonTry;
    [Token(Token = "0x400906D")]
    [FieldOffset(Offset = "0x18")]
    public Button ButtonReward;
    [Token(Token = "0x400906E")]
    [FieldOffset(Offset = "0x1C")]
    public RawImage ImageItem;
    [Token(Token = "0x400906F")]
    [FieldOffset(Offset = "0x20")]
    public RawImage ImageExp;
    [Token(Token = "0x4009070")]
    [FieldOffset(Offset = "0x24")]
    public RawImage ImageGold;
    [Token(Token = "0x4009071")]
    [FieldOffset(Offset = "0x28")]
    public RawImage ImageAp;
    [Token(Token = "0x4009072")]
    [FieldOffset(Offset = "0x2C")]
    public Text TextReward;
    [Token(Token = "0x4009073")]
    [FieldOffset(Offset = "0x30")]
    public Image HelpIcon;
    [Token(Token = "0x4009074")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject ItemIcon;
    [Token(Token = "0x4009075")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject ConceptCard;
    [Token(Token = "0x4009076")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject UnitIcon;
    [Token(Token = "0x4009077")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool IsBGTouchHide;
    [Token(Token = "0x4009078")]
    [FieldOffset(Offset = "0x44")]
    private readonly string EVENT_CHALLENGE_ICON_SHOW;
    [Token(Token = "0x4009079")]
    [FieldOffset(Offset = "0x48")]
    private readonly string EVENT_CHALLENGE_ICON_HIDE;
    [Token(Token = "0x400907A")]
    [FieldOffset(Offset = "0x4C")]
    private bool mShowingOverlay;

    [Token(Token = "0x6008B32")]
    [Address(RVA = "0x4EA940", Offset = "0x4E9740", VA = "0x104EA940", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008B33")]
    [Address(RVA = "0x4ED210", Offset = "0x4EC010", VA = "0x104ED210")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008B34")]
    [Address(RVA = "0x4ED1C0", Offset = "0x4EBFC0", VA = "0x104ED1C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6008B35")]
    [Address(RVA = "0x4EA9D0", Offset = "0x4E97D0", VA = "0x104EA9D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008B36")]
    [Address(RVA = "0x4ECF90", Offset = "0x4EBD90", VA = "0x104ECF90")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008B37")]
    [Address(RVA = "0x4EE190", Offset = "0x4ECF90", VA = "0x104EE190")]
    private void Update()
    {
    }

    [Token(Token = "0x6008B38")]
    [Address(RVA = "0x4EB7C0", Offset = "0x4EA5C0", VA = "0x104EB7C0")]
    private bool IsIncludeObject(GameObject value) => new bool();

    [Token(Token = "0x6008B39")]
    [Address(RVA = "0x4EDB80", Offset = "0x4EC980", VA = "0x104EDB80")]
    private void Refresh(bool fromRefresh)
    {
    }

    [Token(Token = "0x6008B3A")]
    [Address(RVA = "0x4ED260", Offset = "0x4EC060", VA = "0x104ED260")]
    private void RefreshRewardIcon(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B3B")]
    [Address(RVA = "0x4EB890", Offset = "0x4EA690", VA = "0x104EB890")]
    private void OnClickDetail()
    {
    }

    [Token(Token = "0x6008B3C")]
    [Address(RVA = "0x4EB8B0", Offset = "0x4EA6B0", VA = "0x104EB8B0")]
    private void OnClickHelp()
    {
    }

    [Token(Token = "0x6008B3D")]
    [Address(RVA = "0x4EAD30", Offset = "0x4E9B30", VA = "0x104EAD30")]
    private void GotoQuest(string questID)
    {
    }

    [Token(Token = "0x6008B3E")]
    [Address(RVA = "0x4EBA70", Offset = "0x4EA870", VA = "0x104EBA70")]
    private void OnClickTry()
    {
    }

    [Token(Token = "0x6008B3F")]
    [Address(RVA = "0x4EB230", Offset = "0x4EA030", VA = "0x104EB230")]
    private bool GotoQuests(QuestParam[] quests) => new bool();

    [Token(Token = "0x6008B40")]
    [Address(RVA = "0x4EB3F0", Offset = "0x4EA1F0", VA = "0x104EB3F0")]
    private bool GotoQuests(string iname) => new bool();

    [Token(Token = "0x6008B41")]
    [Address(RVA = "0x4EB290", Offset = "0x4EA090", VA = "0x104EB290")]
    private bool GotoQuests(QuestParam quest) => new bool();

    [Token(Token = "0x6008B42")]
    [Address(RVA = "0x4EAC00", Offset = "0x4E9A00", VA = "0x104EAC00")]
    private void GotoQuestMode(QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x6008B43")]
    [Address(RVA = "0x4EB450", Offset = "0x4EA250", VA = "0x104EB450")]
    private void GotoShop(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B44")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void MsgBoxJumpToQuest(GameObject go)
    {
    }

    [Token(Token = "0x6008B45")]
    [Address(RVA = "0x4EE3F0", Offset = "0x4ED1F0", VA = "0x104EE3F0")]
    public ChallengeMissionProgress()
    {
    }
  }
}
