// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRankEffView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026B6")]
  [FlowNode.Pin(100, "up演出", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "down演出", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchRankEffView")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class LeagueMatchRankEffView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B57F")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B580")]
    private const int PIN_OUT_UP_EFF = 100;
    [Token(Token = "0x400B581")]
    private const int PIN_OUT_DOWN_EFF = 101;
    [Token(Token = "0x400B582")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList _exhibitList;
    [Token(Token = "0x400B583")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B584")]
    [FieldOffset(Offset = "0x14")]
    private LeagueMatchRankEffModel _leagueMatchRankEffModel;

    [Token(Token = "0x600AD25")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD26")]
    [Address(RVA = "0x70AE10", Offset = "0x709C10", VA = "0x1070AE10", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD27")]
    [Address(RVA = "0x70AF90", Offset = "0x709D90", VA = "0x1070AF90")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD28")]
    [Address(RVA = "0x70B110", Offset = "0x709F10", VA = "0x1070B110")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD29")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRankEffView()
    {
    }
  }
}
