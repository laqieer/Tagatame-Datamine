﻿// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_DraftSelectUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001783")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "Failure", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/DraftMath/SelectUnit", 32741)]
  public class FlowNode_MP_API_DraftSelectUnit : FlowNode_Network
  {
    [Token(Token = "0x4005482")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005483")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005484")]
    private const int PIN_OUT_FAILURE = 101;

    [Token(Token = "0x6005F5B")]
    [Address(RVA = "0x13348E0", Offset = "0x13336E0", VA = "0x113348E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F5C")]
    [Address(RVA = "0x1334B50", Offset = "0x1333950", VA = "0x11334B50")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F5D")]
    [Address(RVA = "0x13349C0", Offset = "0x13337C0", VA = "0x113349C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F5E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_DraftSelectUnit()
    {
    }
  }
}