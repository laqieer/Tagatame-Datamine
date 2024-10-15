// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckTutorialPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200138E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(13, "チュートリアルスキップ終了", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "チュートリアルスキップ中召喚後(未確定)", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "チュートリアルスキップ中召喚完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "チュートリアルスキップ中召喚前", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "チュートリアル召喚後(未確定)", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "チュートリアル召喚前", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Tutorial/CheckPhase(進行状況確認)", 32741)]
  [FlowNode.Pin(3, "召喚完了済み", FlowNode.PinTypes.Output, 3)]
  public class FlowNode_CheckTutorialPhase : FlowNode
  {
    [Token(Token = "0x4004845")]
    private const int PIN_IN_CHECK = 0;
    [Token(Token = "0x4004846")]
    private const int PIN_OT_BEFORE_GACHA = 1;
    [Token(Token = "0x4004847")]
    private const int PIN_OT_AFTER_GACHA = 2;
    [Token(Token = "0x4004848")]
    private const int PIN_OT_PREV_VERSION_GACHA = 3;
    [Token(Token = "0x4004849")]
    private const int PIN_OT_TUTORIALSKIP_BEFORE_GACHA = 10;
    [Token(Token = "0x400484A")]
    private const int PIN_OT_TUTORIALSKIP_AFTER_GACHA = 11;
    [Token(Token = "0x400484B")]
    private const int PIN_OT_TUTORIALSKIP_PENDING_GACHA = 12;
    [Token(Token = "0x400484C")]
    private const int PIN_OT_TUTORIALSKIP_FINISHED = 13;

    [Token(Token = "0x60051FC")]
    [Address(RVA = "0x126D990", Offset = "0x126C790", VA = "0x1126D990", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051FD")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckTutorialPhase()
    {
    }
  }
}
