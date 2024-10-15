// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_CoopGetRoomList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001774")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/API/Coop/GetRoomList", 32741)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(301, "Player Lv Short", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "Repelled Block List", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(303, "No Match Version", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(3, "Get Room Invitation", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Get Room Line", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(4, "Get GPS Room List", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(1, "Get Room List", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(304, "Maintenance", FlowNode.PinTypes.Output, 304)]
  public class FlowNode_MP_API_CoopGetRoomList : FlowNode_Network
  {
    [Token(Token = "0x4005437")]
    private const int PIN_IN_GET_ROOM_LIST = 1;
    [Token(Token = "0x4005438")]
    private const int PIN_IN_GET_ROOM_LINE = 2;
    [Token(Token = "0x4005439")]
    private const int PIN_IN_GET_ROOM_INVITATION = 3;
    [Token(Token = "0x400543A")]
    private const int PIN_IN_GET_ROOM_LISTGPS = 4;
    [Token(Token = "0x400543B")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400543C")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x400543D")]
    private const int PIN_OUT_PLAYER_LV_SHORT = 301;
    [Token(Token = "0x400543E")]
    private const int PIN_OUT_REPELLED_BLOCK_LIST = 302;
    [Token(Token = "0x400543F")]
    private const int PIN_OUT_NO_MATCH_VERSION = 303;
    [Token(Token = "0x4005440")]
    private const int PIN_OUT_MAINTENANCE = 304;

    [Token(Token = "0x6005F1F")]
    [Address(RVA = "0x1331940", Offset = "0x1330740", VA = "0x11331940", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F20")]
    [Address(RVA = "0x1331CB0", Offset = "0x1330AB0", VA = "0x11331CB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F21")]
    [Address(RVA = "0x1332180", Offset = "0x1330F80", VA = "0x11332180")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F22")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_CoopGetRoomList()
    {
    }
  }
}
