// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_DraftSelectBan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001781")]
  [FlowNode.Pin(101, "Failure", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/API/DraftMath/SelectBan", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_DraftSelectBan : FlowNode_Network
  {
    [Token(Token = "0x400547C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400547D")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x400547E")]
    private const int PIN_OUT_FAILURE = 101;

    [Token(Token = "0x6005F53")]
    [Address(RVA = "0x1334450", Offset = "0x1333250", VA = "0x11334450", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F54")]
    [Address(RVA = "0x1334610", Offset = "0x1333410", VA = "0x11334610")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F55")]
    [Address(RVA = "0x1334530", Offset = "0x1333330", VA = "0x11334530", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F56")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_DraftSelectBan()
    {
    }
  }
}
