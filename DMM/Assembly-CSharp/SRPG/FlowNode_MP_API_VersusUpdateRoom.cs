// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusUpdateRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001792")]
  [AddComponentMenu("")]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(303, "No Room", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/UpdateRoom", 32741)]
  public class FlowNode_MP_API_VersusUpdateRoom : FlowNode_Network
  {
    [Token(Token = "0x40054D8")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054D9")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054DA")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054DB")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054DC")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;
    [Token(Token = "0x40054DD")]
    private const int PIN_OUT_NO_ROOM = 303;

    [Token(Token = "0x6005FA4")]
    [Address(RVA = "0x13495D0", Offset = "0x13483D0", VA = "0x113495D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FA5")]
    [Address(RVA = "0x1349A60", Offset = "0x1348860", VA = "0x11349A60")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FA6")]
    [Address(RVA = "0x13496D0", Offset = "0x13484D0", VA = "0x113496D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FA7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusUpdateRoom()
    {
    }
  }
}
