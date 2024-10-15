// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusMakeRoomLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200178E")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/LINE/MakeRoom", 32741)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(303, "FailedMakeRoom", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(304, "VersusNotPhotonID", FlowNode.PinTypes.Output, 304)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MP_API_VersusMakeRoomLine : FlowNode_Network
  {
    [Token(Token = "0x40054C2")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054C3")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054C4")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054C5")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054C6")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;
    [Token(Token = "0x40054C7")]
    private const int PIN_OUT_FAILED_MAKE_ROOM = 303;
    [Token(Token = "0x40054C8")]
    private const int PIN_OUT_VERSUS_NOT_PHOTON_ID = 304;

    [Token(Token = "0x6005F90")]
    [Address(RVA = "0x13391F0", Offset = "0x1337FF0", VA = "0x113391F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F91")]
    [Address(RVA = "0x13396E0", Offset = "0x13384E0", VA = "0x113396E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F92")]
    [Address(RVA = "0x13392E0", Offset = "0x13380E0", VA = "0x113392E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F93")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusMakeRoomLine()
    {
    }
  }
}
