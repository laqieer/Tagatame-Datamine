// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001790")]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/Start", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_API_VersusStart : FlowNode_Network
  {
    [Token(Token = "0x40054CE")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054CF")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054D0")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054D1")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054D2")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;

    [Token(Token = "0x6005F9A")]
    [Address(RVA = "0x13486F0", Offset = "0x13474F0", VA = "0x113486F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F9B")]
    [Address(RVA = "0x1348D30", Offset = "0x1347B30", VA = "0x11348D30")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F9C")]
    [Address(RVA = "0x1348880", Offset = "0x1347680", VA = "0x11348880", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F9D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusStart()
    {
    }
  }
}
