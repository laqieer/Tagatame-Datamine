// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_CoopJoinRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001775")]
  [FlowNode.Pin(303, "Repelled Block List", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(2, "Join Room by ID", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "Join Room Line", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "Join Room Invitation", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(301, "No Room", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(1, "Join Room", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(302, "Rune Storage FUll", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(304, "No Match Version", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(305, "Maintenance", FlowNode.PinTypes.Output, 305)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/API/Coop/JoinRoom", 32741)]
  public class FlowNode_MP_API_CoopJoinRoom : FlowNode_Network
  {
    [Token(Token = "0x4005441")]
    private const int PIN_IN_JOIN_ROOM = 1;
    [Token(Token = "0x4005442")]
    private const int PIN_IN_JOIN_ROOM_BY_ID = 2;
    [Token(Token = "0x4005443")]
    private const int PIN_IN_JOIN_ROOM_LINE = 3;
    [Token(Token = "0x4005444")]
    private const int PIN_IN_JOIN_ROOM_INVITATION = 4;
    [Token(Token = "0x4005445")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005446")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x4005447")]
    private const int PIN_OUT_NO_ROOM = 301;
    [Token(Token = "0x4005448")]
    private const int PIN_OUT_IS_RUNE_STORAGE_FULL = 302;
    [Token(Token = "0x4005449")]
    private const int PIN_OUT_REPELLED_BLOCK_LIST = 303;
    [Token(Token = "0x400544A")]
    private const int PIN_OUT_NO_MATCH_VERSION = 304;
    [Token(Token = "0x400544B")]
    private const int PIN_OUT_MAINTENANCE = 305;

    [Token(Token = "0x6005F24")]
    [Address(RVA = "0x1332210", Offset = "0x1331010", VA = "0x11332210", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F25")]
    [Address(RVA = "0x1332760", Offset = "0x1331560", VA = "0x11332760", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F26")]
    [Address(RVA = "0x1332D90", Offset = "0x1331B90", VA = "0x11332D90")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F27")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_CoopJoinRoom()
    {
    }
  }
}
