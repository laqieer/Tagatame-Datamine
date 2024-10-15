// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001791")]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/Status", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MP_API_VersusStatus : FlowNode_Network
  {
    [Token(Token = "0x40054D3")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054D4")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054D5")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054D6")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054D7")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;

    [Token(Token = "0x6005F9F")]
    [Address(RVA = "0x1348DA0", Offset = "0x1347BA0", VA = "0x11348DA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FA0")]
    [Address(RVA = "0x1349560", Offset = "0x1348360", VA = "0x11349560")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FA1")]
    [Address(RVA = "0x1348E70", Offset = "0x1347C70", VA = "0x11348E70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FA2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusStatus()
    {
    }
  }
}
