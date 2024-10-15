// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_DecideLINE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017A8")]
  [FlowNode.Pin(101, "Canceled", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Decided", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Decide", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("MultiPlay/Line/DecideLINE", 58751)]
  [FlowNode.Pin(1, "Cancel", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_DecideLINE : FlowNode
  {
    [Token(Token = "0x400553B")]
    private const int PIN_IN_DECIDE = 0;
    [Token(Token = "0x400553C")]
    private const int PIN_IN_CANCEL = 1;
    [Token(Token = "0x400553D")]
    private const int PIN_OUT_DICIDED = 100;
    [Token(Token = "0x400553E")]
    private const int PIN_OUT_CANCELED = 101;

    [Token(Token = "0x6005FF3")]
    [Address(RVA = "0x134B3A0", Offset = "0x134A1A0", VA = "0x1134B3A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FF4")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_DecideLINE()
    {
    }
  }
}
