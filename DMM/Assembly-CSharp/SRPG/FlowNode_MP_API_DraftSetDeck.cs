// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_DraftSetDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001784")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("MultiPlay/API/DraftMath/SetDeck", 32741)]
  [FlowNode.Pin(101, "Failure", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_API_DraftSetDeck : FlowNode_Network
  {
    [Token(Token = "0x4005485")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005486")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005487")]
    private const int PIN_OUT_FAILURE = 101;

    [Token(Token = "0x6005F5F")]
    [Address(RVA = "0x1334BC0", Offset = "0x13339C0", VA = "0x11334BC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F60")]
    [Address(RVA = "0x1334DC0", Offset = "0x1333BC0", VA = "0x11334DC0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F61")]
    [Address(RVA = "0x1334CE0", Offset = "0x1333AE0", VA = "0x11334CE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F62")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_DraftSetDeck()
    {
    }
  }
}
