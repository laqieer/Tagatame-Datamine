// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_QuestApCondNotifyPush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001696")]
  [FlowNode.Pin(201, "Output", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(102, "NotifyNoPush", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "NotifyPush", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("System/QuestApCondNotifyPush", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_QuestApCondNotifyPush : FlowNode
  {
    [Token(Token = "0x4005215")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x4005216")]
    private const int PIN_OUT_PUSH = 101;
    [Token(Token = "0x4005217")]
    private const int PIN_OUT_NO_PUSH = 102;
    [Token(Token = "0x4005218")]
    private const int PIN_OUT_OUTPUT = 201;

    [Token(Token = "0x6005CA0")]
    [Address(RVA = "0x1308370", Offset = "0x1307170", VA = "0x11308370", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CA1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_QuestApCondNotifyPush()
    {
    }
  }
}
