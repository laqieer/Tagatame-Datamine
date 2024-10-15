// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_AutoRejoinRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017CF")]
  [FlowNode.NodeType("MultiPlay/AutoRejoinRoom", 32741)]
  [FlowNode.Pin(1, "Exec", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Failure", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_MP_AutoRejoinRoom : FlowNode
  {
    [Token(Token = "0x400559C")]
    private const int PIN_IN_EXECUTE = 1;
    [Token(Token = "0x400559D")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x400559E")]
    private const int PIN_OUT_FAILURE = 11;

    [Token(Token = "0x6006069")]
    [Address(RVA = "0x1349AD0", Offset = "0x13488D0", VA = "0x11349AD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600606A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_AutoRejoinRoom()
    {
    }
  }
}
