// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRankingWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200260E")]
  [FlowNode.Pin(101, "防衛ランキング切り替え", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "撃破ランキング初期化", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "撃破ランキング切り替え", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(12, "防衛ランキング初期化", FlowNode.PinTypes.Input, 12)]
  [AddComponentMenu("UI/GvG/GvGRankingWindow")]
  [FlowNode.Pin(10, "ランキング初期化", FlowNode.PinTypes.Input, 10)]
  public class GvGRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B125")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400B126")]
    private const int PIN_INPUT_BEATINIT = 11;
    [Token(Token = "0x400B127")]
    private const int PIN_INPUT_DEFENSEINIT = 12;
    [Token(Token = "0x400B128")]
    private const int PIN_OUTPUT_BEATCHANGE = 100;
    [Token(Token = "0x400B129")]
    private const int PIN_OUTPUT_DEFENSECHANGE = 101;
    [Token(Token = "0x400B12A")]
    [FieldOffset(Offset = "0x0")]
    private static GvGRankingWindow mInstance;
    [Token(Token = "0x400B12B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRankingRoot;
    [Token(Token = "0x400B12C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mBeatRankingRoot;
    [Token(Token = "0x400B12D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mDefenseRankingRoot;
    [Token(Token = "0x400B12E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GvGRankingContent mRankingTemplate;
    [Token(Token = "0x400B12F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GvGBeatRankingWindowContent mBeatRankingTemplate;
    [Token(Token = "0x400B130")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GvGDefenseRankingWindowContent mDefenseRankingTemplate;
    [Token(Token = "0x400B131")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRankingTab;
    [Token(Token = "0x400B132")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mBeatRankingTab;
    [Token(Token = "0x400B133")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mDefenseRankingTab;
    [Token(Token = "0x400B134")]
    [FieldOffset(Offset = "0x30")]
    private GvGRankingData mGvGRanking;
    [Token(Token = "0x400B135")]
    [FieldOffset(Offset = "0x34")]
    private GameObject SelectTab;
    [Token(Token = "0x400B136")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> beatList;
    [Token(Token = "0x400B137")]
    [FieldOffset(Offset = "0x3C")]
    private List<GameObject> defenseList;
    [Token(Token = "0x400B138")]
    private const int DEFAULT_PAGEINIT = 1;

    [Token(Token = "0x170017DE")]
    public static GvGRankingWindow Instance
    {
      [Token(Token = "0x600A9A8"), Address(RVA = "0x6CFD70", Offset = "0x6CEB70", VA = "0x106CFD70")] get
      {
        return (GvGRankingWindow) null;
      }
    }

    [Token(Token = "0x170017DF")]
    public int mBeatRankingPage
    {
      [Token(Token = "0x600A9A9"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A9AA"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x170017E0")]
    public int mDefenseRankingPage
    {
      [Token(Token = "0x600A9AB"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A9AC"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
      {
      }
    }

    [Token(Token = "0x600A9AD")]
    [Address(RVA = "0x6CECF0", Offset = "0x6CDAF0", VA = "0x106CECF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A9AE")]
    [Address(RVA = "0x6CF950", Offset = "0x6CE750", VA = "0x106CF950")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A9AF")]
    [Address(RVA = "0x6CEC60", Offset = "0x6CDA60", VA = "0x106CEC60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A9B0")]
    [Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x106CF8F0")]
    private void Init()
    {
    }

    [Token(Token = "0x600A9B1")]
    [Address(RVA = "0x6CF990", Offset = "0x6CE790", VA = "0x106CF990")]
    public void OnSelectTab(GameObject go)
    {
    }

    [Token(Token = "0x600A9B2")]
    [Address(RVA = "0x6CF670", Offset = "0x6CE470", VA = "0x106CF670")]
    private void CreateRanking()
    {
    }

    [Token(Token = "0x600A9B3")]
    [Address(RVA = "0x6CEDB0", Offset = "0x6CDBB0", VA = "0x106CEDB0")]
    private void CreateBeatRanking()
    {
    }

    [Token(Token = "0x600A9B4")]
    [Address(RVA = "0x6CF210", Offset = "0x6CE010", VA = "0x106CF210")]
    private void CreateDefenseRanking()
    {
    }

    [Token(Token = "0x600A9B5")]
    [Address(RVA = "0x6CFB90", Offset = "0x6CE990", VA = "0x106CFB90")]
    private void SetChangeTab(GvGRankingWindow.GvGRankingTab tab)
    {
    }

    [Token(Token = "0x600A9B6")]
    [Address(RVA = "0x6CFCB0", Offset = "0x6CEAB0", VA = "0x106CFCB0")]
    public void SetRankingData(JSON_GvGRankingData[] guilds)
    {
    }

    [Token(Token = "0x600A9B7")]
    [Address(RVA = "0x6CFB00", Offset = "0x6CE900", VA = "0x106CFB00")]
    public void SetBeatRankingData(JSON_GvGScoreRanking[] beats, int beatPage)
    {
    }

    [Token(Token = "0x600A9B8")]
    [Address(RVA = "0x6CFC20", Offset = "0x6CEA20", VA = "0x106CFC20")]
    public void SetDefenseRankingData(JSON_GvGScoreRanking[] defenses, int defensePage)
    {
    }

    [Token(Token = "0x600A9B9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGRankingWindow()
    {
    }

    [Token(Token = "0x200260F")]
    private enum GvGRankingTab
    {
      [Token(Token = "0x400B13C")] Normal,
      [Token(Token = "0x400B13D")] Beat,
      [Token(Token = "0x400B13E")] Defense,
    }
  }
}
