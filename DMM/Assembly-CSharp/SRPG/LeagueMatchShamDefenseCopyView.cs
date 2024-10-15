// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchShamDefenseCopyView
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
  [Token(Token = "0x20026B0")]
  [FlowNode.Pin(1001, "ERROR", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(102, "模擬戦コピーOK", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "防衛コピーOK", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "OK選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(2, "次回選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "次々回選択", FlowNode.PinTypes.Input, 3)]
  public class LeagueMatchShamDefenseCopyView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B529")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B52A")]
    private const int PIN_IN_NEXT_SELECT = 2;
    [Token(Token = "0x400B52B")]
    private const int PIN_IN_NEXT2_SELECT = 3;
    [Token(Token = "0x400B52C")]
    private const int PIN_IN_OK = 11;
    [Token(Token = "0x400B52D")]
    private const int PIN_OUT_DEFENSE = 101;
    [Token(Token = "0x400B52E")]
    private const int PIN_OUT_SHAM = 102;
    [Token(Token = "0x400B52F")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B530")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B531")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mAttackTimeExhibitList;
    [Token(Token = "0x400B532")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B533")]
    [FieldOffset(Offset = "0x18")]
    private bool isDefenseCopy;
    [Token(Token = "0x400B534")]
    [FieldOffset(Offset = "0x1C")]
    private LeagueMatchShamDefenseCopyModel model;
    [Token(Token = "0x400B535")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchAttackTimeModel mAttackTimeModel;

    [Token(Token = "0x600ACF3")]
    [Address(RVA = "0x70D130", Offset = "0x70BF30", VA = "0x1070D130", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ACF4")]
    [Address(RVA = "0x70D350", Offset = "0x70C150", VA = "0x1070D350")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600ACF5")]
    [Address(RVA = "0x70D560", Offset = "0x70C360", VA = "0x1070D560")]
    private void RefreshTabTime()
    {
    }

    [Token(Token = "0x600ACF6")]
    [Address(RVA = "0x70D7E0", Offset = "0x70C5E0", VA = "0x1070D7E0")]
    private void SelectNextToggl()
    {
    }

    [Token(Token = "0x600ACF7")]
    [Address(RVA = "0x70D710", Offset = "0x70C510", VA = "0x1070D710")]
    private void SelectNext2Toggl()
    {
    }

    [Token(Token = "0x600ACF8")]
    [Address(RVA = "0x70D6F0", Offset = "0x70C4F0", VA = "0x1070D6F0")]
    private void SelecOK()
    {
    }

    [Token(Token = "0x600ACF9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchShamDefenseCopyView()
    {
    }
  }
}
