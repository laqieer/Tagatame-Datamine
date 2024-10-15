// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckTutrial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200138F")]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "Skip", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "CheckTutrial", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Check/CheckTutrial")]
  public class FlowNode_CheckTutrial : FlowNode
  {
    [Token(Token = "0x60051FE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x60051FF")]
    [Address(RVA = "0x126DBD0", Offset = "0x126C9D0", VA = "0x1126DBD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005200")]
    [Address(RVA = "0x126DCE0", Offset = "0x126CAE0", VA = "0x1126DCE0")]
    private void OnSelect(bool yes)
    {
    }

    [Token(Token = "0x6005201")]
    [Address(RVA = "0x126DC90", Offset = "0x126CA90", VA = "0x1126DC90")]
    private void OnPlayTutorial()
    {
    }

    [Token(Token = "0x6005202")]
    [Address(RVA = "0x126DD80", Offset = "0x126CB80", VA = "0x1126DD80")]
    private void OnSkipTutorial()
    {
    }

    [Token(Token = "0x6005203")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckTutrial()
    {
    }
  }
}
