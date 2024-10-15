// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusMakeRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200178D")]
  [FlowNode.Pin(303, "FailedMakeRoom", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(304, "VersusNotPhotonID", FlowNode.PinTypes.Output, 304)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/MakeRoom", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [AddComponentMenu("")]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  public class FlowNode_MP_API_VersusMakeRoom : FlowNode_Network
  {
    [Token(Token = "0x40054BB")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054BC")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054BD")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054BE")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054BF")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;
    [Token(Token = "0x40054C0")]
    private const int PIN_OUT_FAILED_MAKE_ROOM = 303;
    [Token(Token = "0x40054C1")]
    private const int PIN_OUT_VERSUS_NOT_PHOTON_ID = 304;

    [Token(Token = "0x6005F8B")]
    [Address(RVA = "0x1339750", Offset = "0x1338550", VA = "0x11339750", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F8C")]
    [Address(RVA = "0x1339EE0", Offset = "0x1338CE0", VA = "0x11339EE0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F8D")]
    [Address(RVA = "0x1339970", Offset = "0x1338770", VA = "0x11339970", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F8E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusMakeRoom()
    {
    }
  }
}
