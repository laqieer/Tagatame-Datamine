// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_TowerGetRoomList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001793")]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("MultiPlay/API/Tower/GetRoomList", 32741)]
  [FlowNode.Pin(1, "Get Room List", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(301, "Player Lv Short", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "Repelled Block List", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(303, "No Match Version", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(304, "Maintenance", FlowNode.PinTypes.Output, 304)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_TowerGetRoomList : FlowNode_Network
  {
    [Token(Token = "0x40054DE")]
    private const int PIN_IN_GET_ROOM_LIST = 1;
    [Token(Token = "0x40054DF")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054E0")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054E1")]
    private const int PIN_OUT_PLAYER_LV_SHORT = 301;
    [Token(Token = "0x40054E2")]
    private const int PIN_OUT_REPELLED_BLOCK_LIST = 302;
    [Token(Token = "0x40054E3")]
    private const int PIN_OUT_NO_MATCH_VERSION = 303;
    [Token(Token = "0x40054E4")]
    private const int PIN_OUT_MAINTENANCE = 304;

    [Token(Token = "0x6005FA9")]
    [Address(RVA = "0x1345990", Offset = "0x1344790", VA = "0x11345990", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FAA")]
    [Address(RVA = "0x1345AC0", Offset = "0x13448C0", VA = "0x11345AC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FAB")]
    [Address(RVA = "0x1345F90", Offset = "0x1344D90", VA = "0x11345F90")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FAC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_TowerGetRoomList()
    {
    }
  }
}
