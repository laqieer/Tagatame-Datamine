// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusJoinRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200178B")]
  [FlowNode.Pin(303, "No Room", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/JoinRoom", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(304, "No Photon ID", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [AddComponentMenu("")]
  [FlowNode.Pin(305, "No LINE Room", FlowNode.PinTypes.Output, 305)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  public class FlowNode_MP_API_VersusJoinRoom : FlowNode_Network
  {
    [Token(Token = "0x40054AB")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054AC")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054AD")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054AE")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054AF")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;
    [Token(Token = "0x40054B0")]
    private const int PIN_OUT_NO_ROOM = 303;
    [Token(Token = "0x40054B1")]
    private const int PIN_OUT_VERSUS_NOT_PHOTON_ID = 304;
    [Token(Token = "0x40054B2")]
    private const int PIN_OUT_VERSUS_NOT_LINE_ROOM = 305;

    [Token(Token = "0x6005F7F")]
    [Address(RVA = "0x13389C0", Offset = "0x13377C0", VA = "0x113389C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F80")]
    [Address(RVA = "0x1339180", Offset = "0x1337F80", VA = "0x11339180")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F81")]
    [Address(RVA = "0x1338950", Offset = "0x1337750", VA = "0x11338950")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005F82")]
    [Address(RVA = "0x1338B60", Offset = "0x1337960", VA = "0x11338B60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F83")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusJoinRoom()
    {
    }
  }
}
