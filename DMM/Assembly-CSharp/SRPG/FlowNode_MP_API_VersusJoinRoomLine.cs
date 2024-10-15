// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_VersusJoinRoomLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200178C")]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(303, "No Room", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(304, "No Photon ID", FlowNode.PinTypes.Output, 304)]
  [FlowNode.NodeType("MultiPlay/API/PvP/Versus/LINE/JoinRoom", 32741)]
  [FlowNode.Pin(305, "No LINE Room", FlowNode.PinTypes.Output, 305)]
  [AddComponentMenu("")]
  [FlowNode.Pin(301, "NoMatchVersion", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "MultiMaintenance", FlowNode.PinTypes.Output, 302)]
  public class FlowNode_MP_API_VersusJoinRoomLine : FlowNode_Network
  {
    [Token(Token = "0x40054B3")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40054B4")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054B5")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054B6")]
    private const int PIN_OUT_NO_MATCH_VERSION = 301;
    [Token(Token = "0x40054B7")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 302;
    [Token(Token = "0x40054B8")]
    private const int PIN_OUT_NO_ROOM = 303;
    [Token(Token = "0x40054B9")]
    private const int PIN_OUT_VERSUS_NOT_PHOTON_ID = 304;
    [Token(Token = "0x40054BA")]
    private const int PIN_OUT_VERSUS_NOT_LINE_ROOM = 305;

    [Token(Token = "0x6005F85")]
    [Address(RVA = "0x13380E0", Offset = "0x1336EE0", VA = "0x113380E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F86")]
    [Address(RVA = "0x13388E0", Offset = "0x13376E0", VA = "0x113388E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F87")]
    [Address(RVA = "0x1338070", Offset = "0x1336E70", VA = "0x11338070")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005F88")]
    [Address(RVA = "0x13382C0", Offset = "0x13370C0", VA = "0x113382C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F89")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_VersusJoinRoomLine()
    {
    }
  }
}
