// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_CoopMakeRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001776")]
  [FlowNode.Pin(306, "No Match Version", FlowNode.PinTypes.Output, 306)]
  [FlowNode.Pin(304, "Not Area Quest", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(307, "Maintenance", FlowNode.PinTypes.Output, 307)]
  [AddComponentMenu("")]
  [FlowNode.Pin(305, "Archive not Opened", FlowNode.PinTypes.Output, 305)]
  [FlowNode.Pin(302, "Failed Make Room", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(301, "Illegal Comment", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.NodeType("MultiPlay/API/Coop/MakeRoom", 32741)]
  [FlowNode.Pin(1, "Make Room", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(303, "Out of Date", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(2, "Make Room Line", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_MP_API_CoopMakeRoom : FlowNode_Network
  {
    [Token(Token = "0x400544C")]
    private const int PIN_IN_MAKE_ROOM = 1;
    [Token(Token = "0x400544D")]
    private const int PIN_IN_MAKE_ROOM_LINE = 2;
    [Token(Token = "0x400544E")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400544F")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x4005450")]
    private const int PIN_OUT_ILLEGAL_COMMENT = 301;
    [Token(Token = "0x4005451")]
    private const int PIN_OUT_FAILED_MAKE_ROOM = 302;
    [Token(Token = "0x4005452")]
    private const int PIN_OUT_OUT_OF_DATE_QUEST = 303;
    [Token(Token = "0x4005453")]
    private const int PIN_OUT_NOT_AREA_QUEST = 304;
    [Token(Token = "0x4005454")]
    private const int PIN_OUT_QUEST_ARCHIVE_NOT_OPENED = 305;
    [Token(Token = "0x4005455")]
    private const int PIN_OUT_NO_MATCH_VERSION = 306;
    [Token(Token = "0x4005456")]
    private const int PIN_OUT_MAINTENANCE = 307;

    [Token(Token = "0x6005F29")]
    [Address(RVA = "0x1332E20", Offset = "0x1331C20", VA = "0x11332E20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F2A")]
    [Address(RVA = "0x13335B0", Offset = "0x13323B0", VA = "0x113335B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F2B")]
    [Address(RVA = "0x1333CE0", Offset = "0x1332AE0", VA = "0x11333CE0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F2C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_CoopMakeRoom()
    {
    }
  }
}
