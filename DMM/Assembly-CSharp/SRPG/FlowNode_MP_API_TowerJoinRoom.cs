// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_TowerJoinRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001794")]
  [FlowNode.Pin(305, "Maintenance", FlowNode.PinTypes.Output, 305)]
  [FlowNode.Pin(306, "Rune Storage FUll", FlowNode.PinTypes.Output, 306)]
  [AddComponentMenu("")]
  [FlowNode.Pin(302, "Cannot Challenge", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "No Room", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(1, "Join Room", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(4, "Join Room Invitation", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "Join Room List", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Join Room by ID", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(303, "Repelled Block List", FlowNode.PinTypes.Output, 303)]
  [FlowNode.NodeType("MultiPlay/API/Tower/JoinRoom", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(304, "No Match Version", FlowNode.PinTypes.Output, 304)]
  public class FlowNode_MP_API_TowerJoinRoom : FlowNode_Network
  {
    [Token(Token = "0x40054E5")]
    private const int PIN_IN_JOIN_ROOM = 1;
    [Token(Token = "0x40054E6")]
    private const int PIN_IN_JOIN_ROOM_BY_ID = 2;
    [Token(Token = "0x40054E7")]
    private const int PIN_IN_JOIN_ROOM_LIST = 3;
    [Token(Token = "0x40054E8")]
    private const int PIN_IN_JOIN_ROOM_INVITATION = 4;
    [Token(Token = "0x40054E9")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054EA")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054EB")]
    private const int PIN_OUT_NO_ROOM = 301;
    [Token(Token = "0x40054EC")]
    private const int PIN_OUT_CANNOT_CHALLENGE = 302;
    [Token(Token = "0x40054ED")]
    private const int PIN_OUT_REPELLED_BLOCK_LIST = 303;
    [Token(Token = "0x40054EE")]
    private const int PIN_OUT_NO_MATCH_VERSION = 304;
    [Token(Token = "0x40054EF")]
    private const int PIN_OUT_MAINTENANCE = 305;
    [Token(Token = "0x40054F0")]
    private const int PIN_OUT_IS_RUNE_STORAGE_FULL = 306;

    [Token(Token = "0x6005FAE")]
    [Address(RVA = "0x1346020", Offset = "0x1344E20", VA = "0x11346020", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FAF")]
    [Address(RVA = "0x13464A0", Offset = "0x13452A0", VA = "0x113464A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FB0")]
    [Address(RVA = "0x1346B40", Offset = "0x1345940", VA = "0x11346B40")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FB1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_TowerJoinRoom()
    {
    }
  }
}
