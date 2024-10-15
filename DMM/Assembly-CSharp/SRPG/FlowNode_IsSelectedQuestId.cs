// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsSelectedQuestId
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001811")]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "Not Selected", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "Selected", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Story/IsSelectedQuestId", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_IsSelectedQuestId : FlowNode
  {
    [Token(Token = "0x4005695")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x4005696")]
    private const int PIN_OUT_SELECTED = 100;
    [Token(Token = "0x4005697")]
    private const int PIN_OUT_NOT_SELECTED = 110;

    [Token(Token = "0x600613C")]
    [Address(RVA = "0x1359810", Offset = "0x1358610", VA = "0x11359810", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600613D")]
    [Address(RVA = "0x1359740", Offset = "0x1358540", VA = "0x11359740")]
    private bool IsSelected() => new bool();

    [Token(Token = "0x600613E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsSelectedQuestId()
    {
    }
  }
}
