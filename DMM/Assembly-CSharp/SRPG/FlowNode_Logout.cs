// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Logout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200176D")]
  [FlowNode.NodeType("Flow/Node/FlowNode_Logout", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_Logout : FlowNode
  {
    [Token(Token = "0x4005427")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005428")]
    private const int PIN_OUT = 100;

    [Token(Token = "0x6005F0D")]
    [Address(RVA = "0x13313F0", Offset = "0x13301F0", VA = "0x113313F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F0E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Logout()
    {
    }
  }
}
