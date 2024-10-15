// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckSelectedQuestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001388")]
  [FlowNode.Pin(1008, "GPS", FlowNode.PinTypes.Output, 1008)]
  [FlowNode.Pin(1023, "ポイントイベント", FlowNode.PinTypes.Output, 1023)]
  [FlowNode.Pin(1007, "塔", FlowNode.PinTypes.Output, 1007)]
  [FlowNode.Pin(1004, "フリー", FlowNode.PinTypes.Output, 1004)]
  [FlowNode.Pin(1003, "チュートリアル", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1002, "闘技場", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1001, "ストーリー", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(0, "判定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/CheckSelectedQuestType", 32741)]
  [FlowNode.Pin(1005, "イベント", FlowNode.PinTypes.Output, 1005)]
  [FlowNode.Pin(1009, "Exクエスト", FlowNode.PinTypes.Output, 1009)]
  [FlowNode.Pin(1010, "初心者", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(1011, "試練", FlowNode.PinTypes.Output, 1011)]
  [FlowNode.Pin(1022, "竜神編", FlowNode.PinTypes.Output, 1022)]
  [FlowNode.Pin(1012, "レイド", FlowNode.PinTypes.Output, 1012)]
  [FlowNode.Pin(1014, "創世編ボス", FlowNode.PinTypes.Output, 1014)]
  [FlowNode.Pin(1015, "新イベントストーリー", FlowNode.PinTypes.Output, 1015)]
  [FlowNode.Pin(1016, "新イベントボス", FlowNode.PinTypes.Output, 1016)]
  [FlowNode.Pin(1019, "ギルドレイド", FlowNode.PinTypes.Output, 1019)]
  [FlowNode.Pin(2001, "[マルチ]", FlowNode.PinTypes.Output, 2001)]
  [FlowNode.Pin(2002, "[マルチ]塔", FlowNode.PinTypes.Output, 2002)]
  [FlowNode.Pin(2003, "[マルチ]GPS", FlowNode.PinTypes.Output, 2003)]
  [FlowNode.Pin(3001, "[PvP]フリー", FlowNode.PinTypes.Output, 3001)]
  [FlowNode.Pin(3002, "[PvP]タワーマッチ", FlowNode.PinTypes.Output, 3002)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1024, "リーグマッチ", FlowNode.PinTypes.Output, 1024)]
  [FlowNode.Pin(1013, "創世編ストーリー", FlowNode.PinTypes.Output, 1013)]
  [FlowNode.Pin(1006, "キャラクター", FlowNode.PinTypes.Output, 1006)]
  [FlowNode.Pin(3003, "[PvP]ランクマッチ", FlowNode.PinTypes.Output, 3003)]
  [FlowNode.Pin(1021, "戦闘力クエスト", FlowNode.PinTypes.Output, 1021)]
  public class FlowNode_CheckSelectedQuestType : FlowNode
  {
    [Token(Token = "0x4004811")]
    public const int INPUT_CHECK = 0;
    [Token(Token = "0x4004812")]
    public const int OUTPUT_STORY = 1001;
    [Token(Token = "0x4004813")]
    public const int OUTPUT_ARENA = 1002;
    [Token(Token = "0x4004814")]
    public const int OUTPUT_TUTORIAL = 1003;
    [Token(Token = "0x4004815")]
    public const int OUTPUT_FREE = 1004;
    [Token(Token = "0x4004816")]
    public const int OUTPUT_EVENT = 1005;
    [Token(Token = "0x4004817")]
    public const int OUTPUT_CHARACTER = 1006;
    [Token(Token = "0x4004818")]
    public const int OUTPUT_TOWER = 1007;
    [Token(Token = "0x4004819")]
    public const int OUTPUT_GPS = 1008;
    [Token(Token = "0x400481A")]
    public const int OUTPUT_EXTRA = 1009;
    [Token(Token = "0x400481B")]
    public const int OUTPUT_BEGINNER = 1010;
    [Token(Token = "0x400481C")]
    public const int OUTPUT_ORDEAL = 1011;
    [Token(Token = "0x400481D")]
    public const int OUTPUT_RAID = 1012;
    [Token(Token = "0x400481E")]
    public const int OUTPUT_GENESIS_STORY = 1013;
    [Token(Token = "0x400481F")]
    public const int OUTPUT_GENESIS_BOSS = 1014;
    [Token(Token = "0x4004820")]
    public const int OUTPUT_ADVANCE_STORY = 1015;
    [Token(Token = "0x4004821")]
    public const int OUTPUT_ADVANCE_BOSS = 1016;
    [Token(Token = "0x4004822")]
    public const int OUTPUT_UNIT_RENTAL = 1017;
    [Token(Token = "0x4004823")]
    public const int OUTPUT_GUILD_RAID = 1019;
    [Token(Token = "0x4004824")]
    public const int OUTPUT_GVG = 1020;
    [Token(Token = "0x4004825")]
    public const int OUTPUT_COMBATPOWER = 1021;
    [Token(Token = "0x4004826")]
    public const int OUTPUT_DRAGONGOD = 1022;
    [Token(Token = "0x4004827")]
    public const int OUTPUT_POINTEVENT = 1023;
    [Token(Token = "0x4004828")]
    public const int OUTPUT_LEAGUEMATCH = 1024;
    [Token(Token = "0x4004829")]
    public const int OUTPUT_MULTI = 2001;
    [Token(Token = "0x400482A")]
    public const int OUTPUT_MULTITOWER = 2002;
    [Token(Token = "0x400482B")]
    public const int OUTPUT_MULTIGPS = 2003;
    [Token(Token = "0x400482C")]
    public const int OUTPUT_VERSUSFREE = 3001;
    [Token(Token = "0x400482D")]
    public const int OUTPUT_VERSUSRANK = 3002;
    [Token(Token = "0x400482E")]
    public const int OUTPUT_RANKMATCH = 3003;
    [Token(Token = "0x400482F")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    [SerializeField]
    private FlowNode_CheckSelectedQuestType.eDataType m_TargetDataType;

    [Token(Token = "0x60051E7")]
    [Address(RVA = "0x126CC20", Offset = "0x126BA20", VA = "0x1126CC20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051E8")]
    [Address(RVA = "0x126C940", Offset = "0x126B740", VA = "0x1126C940")]
    private QuestTypes GetQuestTypeAuto() => new QuestTypes();

    [Token(Token = "0x60051E9")]
    [Address(RVA = "0x126CC00", Offset = "0x126BA00", VA = "0x1126CC00")]
    private QuestTypes GetQuestType(QuestParam questParam) => new QuestTypes();

    [Token(Token = "0x60051EA")]
    [Address(RVA = "0x126CA60", Offset = "0x126B860", VA = "0x1126CA60")]
    private QuestTypes GetQuestTypeByChapter(ChapterParam chapterParam) => new QuestTypes();

    [Token(Token = "0x60051EB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckSelectedQuestType()
    {
    }

    [Token(Token = "0x2001389")]
    public enum eDataType
    {
      [Token(Token = "0x4004831")] GlobalVars_SelectedChapter,
      [Token(Token = "0x4004832")] GlobalVars_SelectedArchiveID,
      [Token(Token = "0x4004833")] GlobalVars_SelectedQuestID,
    }
  }
}
