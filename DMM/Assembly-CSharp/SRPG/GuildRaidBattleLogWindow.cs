// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBattleLogWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200256A")]
  [FlowNode.Pin(101, "Request Next", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/GuildRaid/GuildRaidBattleLogWindow")]
  [FlowNode.Pin(12, "Window Close", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(2, "Reload", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(11, "Window Open", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Initialize Top", FlowNode.PinTypes.Input, 1)]
  public class GuildRaidBattleLogWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400ACC7")]
    public const int PIN_INPUT_INIT_TOP = 1;
    [Token(Token = "0x400ACC8")]
    public const int PIN_INPUT_RELOAD = 2;
    [Token(Token = "0x400ACC9")]
    public const int PIN_INPUT_WINDOW_OPEN = 11;
    [Token(Token = "0x400ACCA")]
    public const int PIN_INPUT_WINDOW_CLOSE = 12;
    [Token(Token = "0x400ACCB")]
    public const int PIN_OUTPUT_REQUEST_NEXT = 101;
    [Token(Token = "0x400ACCC")]
    [FieldOffset(Offset = "0x0")]
    private static GuildRaidBattleLogWindow mInstance;
    [Token(Token = "0x400ACCE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int WindowHeightMin;
    [Token(Token = "0x400ACCF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int WindowHeightMax;
    [Token(Token = "0x400ACD0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_ScrollRect Scroll;
    [Token(Token = "0x400ACD1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject ScrollBar;
    [Token(Token = "0x400ACD2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform ScrollContent;
    [Token(Token = "0x400ACD3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject LogTemplate;
    [Token(Token = "0x400ACD4")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> LogList;
    [Token(Token = "0x400ACD5")]
    [FieldOffset(Offset = "0x2C")]
    private bool IsLoading;
    [Token(Token = "0x400ACD6")]
    [FieldOffset(Offset = "0x2D")]
    private bool IsOpen;
    [Token(Token = "0x400ACD7")]
    private const int LogCountByOneAPI = 20;
    [Token(Token = "0x400ACD8")]
    [FieldOffset(Offset = "0x30")]
    public int CurrentPage;
    [Token(Token = "0x400ACD9")]
    [FieldOffset(Offset = "0x34")]
    public int NextPage;

    [Token(Token = "0x1700171B")]
    public static GuildRaidBattleLogWindow Instance
    {
      [Token(Token = "0x600A5A4"), Address(RVA = "0x67ABD0", Offset = "0x6799D0", VA = "0x1067ABD0")] get
      {
        return (GuildRaidBattleLogWindow) null;
      }
    }

    [Token(Token = "0x1700171C")]
    public List<GuildRaidBattleLog> BattleLogList
    {
      [Token(Token = "0x600A5A5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidBattleLog>) null;
      }
      [Token(Token = "0x600A5A6"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600A5A7")]
    [Address(RVA = "0x67A340", Offset = "0x679140", VA = "0x1067A340")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A5A8")]
    [Address(RVA = "0x67A750", Offset = "0x679550", VA = "0x1067A750")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A5A9")]
    [Address(RVA = "0x67AA10", Offset = "0x679810", VA = "0x1067AA10")]
    private void Update()
    {
    }

    [Token(Token = "0x600A5AA")]
    [Address(RVA = "0x67A150", Offset = "0x678F50", VA = "0x1067A150", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A5AB")]
    [Address(RVA = "0x67A3F0", Offset = "0x6791F0", VA = "0x1067A3F0")]
    private void Init(bool isTop = false)
    {
    }

    [Token(Token = "0x600A5AC")]
    [Address(RVA = "0x67A930", Offset = "0x679730", VA = "0x1067A930")]
    public void SetupBattleLog(JSON_GuildRaidBattleLog json)
    {
    }

    [Token(Token = "0x600A5AD")]
    [Address(RVA = "0x67A800", Offset = "0x679600", VA = "0x1067A800")]
    public void SetupBattleLog(JSON_GuildRaidBattleLog[] json, bool isOverwrite = false)
    {
    }

    [Token(Token = "0x600A5AE")]
    [Address(RVA = "0x67A790", Offset = "0x679590", VA = "0x1067A790")]
    private IEnumerator Open() => (IEnumerator) null;

    [Token(Token = "0x600A5AF")]
    [Address(RVA = "0x67A380", Offset = "0x679180", VA = "0x1067A380")]
    private IEnumerator Close() => (IEnumerator) null;

    [Token(Token = "0x600A5B0")]
    [Address(RVA = "0x67AB50", Offset = "0x679950", VA = "0x1067AB50")]
    public GuildRaidBattleLogWindow()
    {
    }
  }
}
