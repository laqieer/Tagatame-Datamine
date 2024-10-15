// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_PvPCheckEnableTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001785")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Success", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("MultiPlay/API/PvP/CheckEnableTime", 32741)]
  [FlowNode.Pin(12, "Failure", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_PvPCheckEnableTime : FlowNode_Network
  {
    [Token(Token = "0x4005488")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005489")]
    private const int PIN_OUT_SUCCESS = 11;
    [Token(Token = "0x400548A")]
    private const int PIN_OUT_FAILURE = 12;

    [Token(Token = "0x6005F63")]
    [Address(RVA = "0x1334E30", Offset = "0x1333C30", VA = "0x11334E30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F64")]
    [Address(RVA = "0x13350D0", Offset = "0x1333ED0", VA = "0x113350D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F65")]
    [Address(RVA = "0x1334ED0", Offset = "0x1333CD0", VA = "0x11334ED0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F66")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_PvPCheckEnableTime()
    {
    }
  }
}
