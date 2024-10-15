// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchMapListSelectComfirmView
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
  [Token(Token = "0x200269F")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(2, "Decide", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "ReqMapSelectShamBattle", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "ReqMapSelect", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "ReqFinish", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(103, "PlacementSet", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "Close", FlowNode.PinTypes.Output, 104)]
  public class LeagueMatchMapListSelectComfirmView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B48D")]
    public const string SVB_KEY_SELECT_MAP_INAME = "SVB_KEY_SELECT_MAP_INAME";
    [Token(Token = "0x400B48E")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B48F")]
    private const int PIN_IN_DECIDE = 2;
    [Token(Token = "0x400B490")]
    private const int PIN_IN_REQ_FINISH = 3;
    [Token(Token = "0x400B491")]
    private const int PIN_OUTPUT_MAP_SELECT = 101;
    [Token(Token = "0x400B492")]
    private const int PIN_OUTPUT_MAP_SELECT_SHAM = 102;
    [Token(Token = "0x400B493")]
    private const int PIN_OUTPUT_PLACEMENT_SET = 103;
    [Token(Token = "0x400B494")]
    private const int PIN_OUTPUT_CLOSE = 104;
    [Token(Token = "0x400B495")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B496")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B497")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B498")]
    [FieldOffset(Offset = "0x14")]
    private LeagueMatchMapModel mMapModels;
    [Token(Token = "0x400B499")]
    [FieldOffset(Offset = "0x18")]
    private string mSelectQuestIname;
    [Token(Token = "0x400B49A")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsShamBattle;

    [Token(Token = "0x600AC86")]
    [Address(RVA = "0x6FC4A0", Offset = "0x6FB2A0", VA = "0x106FC4A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AC87")]
    [Address(RVA = "0x6FC4F0", Offset = "0x6FB2F0", VA = "0x106FC4F0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AC88")]
    [Address(RVA = "0x6FC7F0", Offset = "0x6FB5F0", VA = "0x106FC7F0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x600AC89")]
    [Address(RVA = "0x6FCCB0", Offset = "0x6FBAB0", VA = "0x106FCCB0")]
    private void OnMapSelectFin()
    {
    }

    [Token(Token = "0x600AC8A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchMapListSelectComfirmView()
    {
    }
  }
}
