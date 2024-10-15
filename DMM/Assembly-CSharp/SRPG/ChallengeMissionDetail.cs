// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionDetail
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
  [Token(Token = "0x200212A")]
  [FlowNode.Pin(1024, "武具進化画面へ移動", FlowNode.PinTypes.Output, 1303)]
  [FlowNode.Pin(1025, "FgGID画面へ移動", FlowNode.PinTypes.Output, 1401)]
  [FlowNode.Pin(1026, "塔へ移動", FlowNode.PinTypes.Output, 1402)]
  [FlowNode.Pin(1027, "対戦へ移動", FlowNode.PinTypes.Output, 1403)]
  [FlowNode.Pin(1028, "初心者イベントクエスト選択へ移動", FlowNode.PinTypes.Output, 1501)]
  [FlowNode.Pin(1029, "初心者の館へ移動", FlowNode.PinTypes.Output, 1502)]
  [FlowNode.Pin(1030, "真理念装へ移動", FlowNode.PinTypes.Output, 1601)]
  [FlowNode.Pin(1031, "カルマへ移動", FlowNode.PinTypes.Output, 1602)]
  [FlowNode.Pin(1032, "ホームへ移動", FlowNode.PinTypes.Output, 1603)]
  [FlowNode.Pin(1033, "お知らせへ移動", FlowNode.PinTypes.Output, 1604)]
  [FlowNode.Pin(1034, "フレンド画面へ移動", FlowNode.PinTypes.Output, 1605)]
  [FlowNode.Pin(1036, "新イベントへ移動", FlowNode.PinTypes.Output, 1607)]
  [FlowNode.Pin(1023, "武具強化画面へ移動", FlowNode.PinTypes.Output, 1302)]
  [FlowNode.Pin(1037, "アルケミィポートへ移動", FlowNode.PinTypes.Output, 1608)]
  [FlowNode.Pin(1038, "レイドへ移動", FlowNode.PinTypes.Output, 1609)]
  [FlowNode.Pin(1039, "ポートレイドへ移動", FlowNode.PinTypes.Output, 1610)]
  [FlowNode.Pin(1043, "派遣クエストへ移動", FlowNode.PinTypes.Output, 1701)]
  [FlowNode.Pin(1044, "ポイントクエストへ移動", FlowNode.PinTypes.Output, 1702)]
  [FlowNode.Pin(1045, "ポイントクエストTOPへ移動", FlowNode.PinTypes.Output, 1703)]
  [FlowNode.Pin(1046, "ワールドレイドへ移動", FlowNode.PinTypes.Output, 1704)]
  [FlowNode.Pin(1047, "PVEへ移動", FlowNode.PinTypes.Output, 1705)]
  [AddComponentMenu("UI/ChallengeMissionDetail")]
  [FlowNode.Pin(1035, "創世編へ移動", FlowNode.PinTypes.Output, 1606)]
  [FlowNode.Pin(1022, "武具錬成画面へ移動", FlowNode.PinTypes.Output, 1301)]
  [FlowNode.Pin(100, "キャンセル", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1040, "限定ショップへ移動", FlowNode.PinTypes.Output, 1210)]
  [FlowNode.Pin(1041, "ポートショップへ移動", FlowNode.PinTypes.Output, 1211)]
  [FlowNode.Pin(0, "表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1001, "クエスト選択へ移動", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1004, "ゴールド購入画面へ移動", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1002, "アビリティ強化画面へ移動", FlowNode.PinTypes.Output, 1004)]
  [FlowNode.Pin(1003, "装備強化画面へ移動", FlowNode.PinTypes.Output, 1005)]
  [FlowNode.Pin(1005, "マルチプレイへ移動", FlowNode.PinTypes.Output, 1006)]
  [FlowNode.Pin(1006, "エリートクエスト選択へ移動", FlowNode.PinTypes.Output, 1007)]
  [FlowNode.Pin(1007, "イベントクエスト選択へ移動", FlowNode.PinTypes.Output, 1008)]
  [FlowNode.Pin(1008, "アリーナへ移動", FlowNode.PinTypes.Output, 1009)]
  [FlowNode.Pin(1042, "新闘技場へ移動", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(1009, "ユニット強化画面へ移動", FlowNode.PinTypes.Output, 1101)]
  [FlowNode.Pin(1000, "ガチャへ移動", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1011, "ユニットジョブ画面へ移動", FlowNode.PinTypes.Output, 1103)]
  [FlowNode.Pin(1021, "武具の店へ移動", FlowNode.PinTypes.Output, 1209)]
  [FlowNode.Pin(1010, "ユニットアビリティセット画面へ移動", FlowNode.PinTypes.Output, 1102)]
  [FlowNode.Pin(1019, "マルチ交換所へ移動", FlowNode.PinTypes.Output, 1207)]
  [FlowNode.Pin(1018, "闘技場交換所へ移動", FlowNode.PinTypes.Output, 1206)]
  [FlowNode.Pin(1017, "ツアーの店へ移動", FlowNode.PinTypes.Output, 1205)]
  [FlowNode.Pin(1020, "魂の交換所へ移動", FlowNode.PinTypes.Output, 1208)]
  [FlowNode.Pin(1015, "ルイザの店へ移動", FlowNode.PinTypes.Output, 1203)]
  [FlowNode.Pin(1014, "マリアの店へ移動", FlowNode.PinTypes.Output, 1202)]
  [FlowNode.Pin(1016, "ソウルショップへ移動", FlowNode.PinTypes.Output, 1204)]
  [FlowNode.Pin(1012, "ユニット選択へ移動", FlowNode.PinTypes.Output, 1104)]
  [FlowNode.Pin(1013, "アンナの店へ移動", FlowNode.PinTypes.Output, 1201)]
  public class ChallengeMissionDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008FE7")]
    public const int PIN_OPEN = 0;
    [Token(Token = "0x4008FE8")]
    public const int PIN_CANCEL = 100;
    [Token(Token = "0x4008FE9")]
    public const int PIN_GOTO_GACHA = 1000;
    [Token(Token = "0x4008FEA")]
    public const int PIN_GOTO_QUEST = 1001;
    [Token(Token = "0x4008FEB")]
    public const int PIN_GOTO_ABILITY = 1002;
    [Token(Token = "0x4008FEC")]
    public const int PIN_GOTO_SOUBI = 1003;
    [Token(Token = "0x4008FED")]
    public const int PIN_GOTO_BUYGOLD = 1004;
    [Token(Token = "0x4008FEE")]
    public const int PIN_GOTO_MULTI = 1005;
    [Token(Token = "0x4008FEF")]
    public const int PIN_GOTO_ELITE = 1006;
    [Token(Token = "0x4008FF0")]
    public const int PIN_GOTO_EVENT = 1007;
    [Token(Token = "0x4008FF1")]
    public const int PIN_GOTO_ARENA = 1008;
    [Token(Token = "0x4008FF2")]
    public const int PIN_GOTO_UNIT_STR = 1009;
    [Token(Token = "0x4008FF3")]
    public const int PIN_GOTO_ABILITYSET = 1010;
    [Token(Token = "0x4008FF4")]
    public const int PIN_GOTO_UNIT_JOB = 1011;
    [Token(Token = "0x4008FF5")]
    public const int PIN_GOTO_UNIT = 1012;
    [Token(Token = "0x4008FF6")]
    public const int PIN_GOTO_SHOP_NORMAL = 1013;
    [Token(Token = "0x4008FF7")]
    public const int PIN_GOTO_SHOP_TABI = 1014;
    [Token(Token = "0x4008FF8")]
    public const int PIN_GOTO_SHOP_KIMAGRE = 1015;
    [Token(Token = "0x4008FF9")]
    public const int PIN_GOTO_SHOP_MONOZUKI = 1016;
    [Token(Token = "0x4008FFA")]
    public const int PIN_GOTO_SHOP_TOUR = 1017;
    [Token(Token = "0x4008FFB")]
    public const int PIN_GOTO_SHOP_ARENA = 1018;
    [Token(Token = "0x4008FFC")]
    public const int PIN_GOTO_SHOP_MULTI = 1019;
    [Token(Token = "0x4008FFD")]
    public const int PIN_GOTO_SHOP_KAKERA = 1020;
    [Token(Token = "0x4008FFE")]
    public const int PIN_GOTO_SHOP_ARTIFACT = 1021;
    [Token(Token = "0x4008FFF")]
    public const int PIN_GOTO_ATF_TRANS = 1022;
    [Token(Token = "0x4009000")]
    public const int PIN_GOTO_ATF_STRTH = 1023;
    [Token(Token = "0x4009001")]
    public const int PIN_GOTO_ATF_EVOLT = 1024;
    [Token(Token = "0x4009002")]
    public const int PIN_GOTO_FGGID = 1025;
    [Token(Token = "0x4009003")]
    public const int PIN_GOTO_TOWER = 1026;
    [Token(Token = "0x4009004")]
    public const int PIN_GOTO_VERSUS = 1027;
    [Token(Token = "0x4009005")]
    public const int PIN_GOTO_EVENT_BEGINEER = 1028;
    [Token(Token = "0x4009006")]
    public const int PIN_GOTO_BEGINNERTOP = 1029;
    [Token(Token = "0x4009007")]
    public const int PIN_GOTO_CONCEPTCARD = 1030;
    [Token(Token = "0x4009008")]
    public const int PIN_GOTO_ORDEAL = 1031;
    [Token(Token = "0x4009009")]
    public const int PIN_GOTO_HOME = 1032;
    [Token(Token = "0x400900A")]
    public const int PIN_GOTO_NEWS = 1033;
    [Token(Token = "0x400900B")]
    public const int PIN_GOTO_FRIEND = 1034;
    [Token(Token = "0x400900C")]
    public const int PIN_GOTO_GENESIS = 1035;
    [Token(Token = "0x400900D")]
    public const int PIN_GOTO_ADVANCE = 1036;
    [Token(Token = "0x400900E")]
    public const int PIN_GOTO_GUILD = 1037;
    [Token(Token = "0x400900F")]
    public const int PIN_GOTO_RAIDBOSS = 1038;
    [Token(Token = "0x4009010")]
    public const int PIN_GOTO_GUILDRAIDBOSS = 1039;
    [Token(Token = "0x4009011")]
    public const int PIN_GOTO_SHOP_LIMITED = 1040;
    [Token(Token = "0x4009012")]
    public const int PIN_GOTO_SHOP_PORT = 1041;
    [Token(Token = "0x4009013")]
    public const int PIN_GOTO_DUEL = 1042;
    [Token(Token = "0x4009014")]
    public const int PIN_GOTO_ADVENTURE = 1043;
    [Token(Token = "0x4009015")]
    public const int PIN_GOTO_POINTQUEST = 1044;
    [Token(Token = "0x4009016")]
    public const int PIN_GOTO_POINTQUEST_TOP = 1045;
    [Token(Token = "0x4009017")]
    public const int PIN_GOTO_WORLDRAID = 1046;
    [Token(Token = "0x4009018")]
    public const int PIN_GOTO_LEAGUEMATCH = 1047;
    [Token(Token = "0x4009019")]
    [FieldOffset(Offset = "0xC")]
    public Transform RewardItemHolder;
    [Token(Token = "0x400901A")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RewardItemTemplate;
    [Token(Token = "0x400901B")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonCancel;
    [Token(Token = "0x400901C")]
    [FieldOffset(Offset = "0x18")]
    public Button ButtonTry;
    [Token(Token = "0x400901D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text CloseButtonText;
    [Token(Token = "0x400901E")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mRewardItems;

    [Token(Token = "0x6008B09")]
    [Address(RVA = "0x4E6370", Offset = "0x4E5170", VA = "0x104E6370", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008B0A")]
    [Address(RVA = "0x4E63B0", Offset = "0x4E51B0", VA = "0x104E63B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008B0B")]
    [Address(RVA = "0x4E8A20", Offset = "0x4E7820", VA = "0x104E8A20")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B0C")]
    [Address(RVA = "0x4E71F0", Offset = "0x4E5FF0", VA = "0x104E71F0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008B0D")]
    [Address(RVA = "0x4E8E10", Offset = "0x4E7C10", VA = "0x104E8E10")]
    private void UpdateReward(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B0E")]
    [Address(RVA = "0x4E7170", Offset = "0x4E5F70", VA = "0x104E7170")]
    public static bool IsChallengeable(TrophyParam trophy) => new bool();

    [Token(Token = "0x6008B0F")]
    [Address(RVA = "0x4E8870", Offset = "0x4E7670", VA = "0x104E8870")]
    public static void SetGoToUnitListState(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B10")]
    [Address(RVA = "0x4E8770", Offset = "0x4E7570", VA = "0x104E8770")]
    public static void SetGoToUnitListState(string unitName)
    {
    }

    [Token(Token = "0x6008B11")]
    [Address(RVA = "0x4E8950", Offset = "0x4E7750", VA = "0x104E8950")]
    public static string[] SplitSvalByComma(TrophyParam trophy) => (string[]) null;

    [Token(Token = "0x6008B12")]
    [Address(RVA = "0x44A4A0", Offset = "0x4492A0", VA = "0x1044A4A0")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x6008B13")]
    [Address(RVA = "0x4E6550", Offset = "0x4E5350", VA = "0x104E6550")]
    private void GotoQuest(string questID)
    {
    }

    [Token(Token = "0x6008B14")]
    [Address(RVA = "0x4E7240", Offset = "0x4E6040", VA = "0x104E7240")]
    private void OnTry()
    {
    }

    [Token(Token = "0x6008B15")]
    [Address(RVA = "0x4E6D40", Offset = "0x4E5B40", VA = "0x104E6D40")]
    private bool GotoQuests(QuestParam[] quests) => new bool();

    [Token(Token = "0x6008B16")]
    [Address(RVA = "0x4E6DA0", Offset = "0x4E5BA0", VA = "0x104E6DA0")]
    private bool GotoQuests(string iname) => new bool();

    [Token(Token = "0x6008B17")]
    [Address(RVA = "0x4E6BE0", Offset = "0x4E59E0", VA = "0x104E6BE0")]
    private bool GotoQuests(QuestParam quest) => new bool();

    [Token(Token = "0x6008B18")]
    [Address(RVA = "0x4E6420", Offset = "0x4E5220", VA = "0x104E6420")]
    private void GotoQuestMode(QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x6008B19")]
    [Address(RVA = "0x4E6E00", Offset = "0x4E5C00", VA = "0x104E6E00")]
    private void GotoShop(TrophyParam trophy)
    {
    }

    [Token(Token = "0x6008B1A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void MsgBoxJumpToQuest(GameObject go)
    {
    }

    [Token(Token = "0x6008B1B")]
    [Address(RVA = "0x4E9670", Offset = "0x4E8470", VA = "0x104E9670")]
    public ChallengeMissionDetail()
    {
    }
  }
}
