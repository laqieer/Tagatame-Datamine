// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_SendLINE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017A9")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Sent", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "Send", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/Line/SendLINE", 32741)]
  [FlowNode.Pin(2, "Send Versus", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_MP_SendLINE : FlowNode
  {
    [Token(Token = "0x400553F")]
    private const int PIN_IN_SEND = 1;
    [Token(Token = "0x4005540")]
    private const int PIN_IN_SEND_VERSUS = 2;
    [Token(Token = "0x4005541")]
    private const int PIN_OUT_SENT = 11;

    [Token(Token = "0x6005FF5")]
    [Address(RVA = "0x1352820", Offset = "0x1351620", VA = "0x11352820", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FF6")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_SendLINE()
    {
    }
  }
}
