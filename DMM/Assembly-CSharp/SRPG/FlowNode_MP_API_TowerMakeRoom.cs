// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_TowerMakeRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001795")]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("MultiPlay/API/Tower/MakeRoom", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(306, "No Match Version", FlowNode.PinTypes.Output, 306)]
  [FlowNode.Pin(305, "Fail Room ID", FlowNode.PinTypes.Output, 305)]
  [FlowNode.Pin(304, "Out of Date", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(307, "Maintenance", FlowNode.PinTypes.Output, 307)]
  [FlowNode.Pin(302, "Failed Make Room", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(301, "Illegal Comment", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Make Room", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(303, "Rune Storage FUll", FlowNode.PinTypes.Output, 303)]
  public class FlowNode_MP_API_TowerMakeRoom : FlowNode_Network
  {
    [Token(Token = "0x40054F1")]
    private const int PIN_IN_MAKE_ROOM = 1;
    [Token(Token = "0x40054F2")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40054F3")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x40054F4")]
    private const int PIN_OUT_ILLEGAL_COMMENT = 301;
    [Token(Token = "0x40054F5")]
    private const int PIN_OUT_FAILED_MAKE_ROOM = 302;
    [Token(Token = "0x40054F6")]
    private const int PIN_OUT_IS_RUNE_STORAGE_FULL = 303;
    [Token(Token = "0x40054F7")]
    private const int PIN_OUT_OUT_OF_DATE_QUEST = 304;
    [Token(Token = "0x40054F8")]
    private const int PIN_OUT_FAIL_ROOM_ID = 305;
    [Token(Token = "0x40054F9")]
    private const int PIN_OUT_NO_MATCH_VERSION = 306;
    [Token(Token = "0x40054FA")]
    private const int PIN_OUT_MAINTENANCE = 307;

    [Token(Token = "0x6005FB3")]
    [Address(RVA = "0x1346BD0", Offset = "0x13459D0", VA = "0x11346BD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FB4")]
    [Address(RVA = "0x1347060", Offset = "0x1345E60", VA = "0x11347060", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005FB5")]
    [Address(RVA = "0x1347790", Offset = "0x1346590", VA = "0x11347790")]
    private void Success()
    {
    }

    [Token(Token = "0x6005FB6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_TowerMakeRoom()
    {
    }
  }
}
