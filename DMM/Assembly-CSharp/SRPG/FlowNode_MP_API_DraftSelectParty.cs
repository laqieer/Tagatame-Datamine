// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_DraftSelectParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001782")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("MultiPlay/API/DraftMath/SelectParty", 32741)]
  [FlowNode.Pin(101, "Failure", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_DraftSelectParty : FlowNode_Network
  {
    [Token(Token = "0x400547F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005480")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005481")]
    private const int PIN_OUT_FAILURE = 101;

    [Token(Token = "0x6005F57")]
    [Address(RVA = "0x1334680", Offset = "0x1333480", VA = "0x11334680", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F58")]
    [Address(RVA = "0x1334870", Offset = "0x1333670", VA = "0x11334870")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F59")]
    [Address(RVA = "0x1334790", Offset = "0x1333590", VA = "0x11334790", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F5A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_DraftSelectParty()
    {
    }
  }
}
