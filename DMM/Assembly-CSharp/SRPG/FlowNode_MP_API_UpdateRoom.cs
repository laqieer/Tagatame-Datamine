// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_UpdateRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200177E")]
  [FlowNode.Pin(302, "No Room", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(304, "MultiMaintenance", FlowNode.PinTypes.Output, 304)]
  [FlowNode.Pin(303, "No Match Version", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(301, "Illegal Comment", FlowNode.PinTypes.Output, 301)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Failure", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(3, "Update Comment", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Pass Release", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Pass Lock", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/UpdateRoom", 32741)]
  public class FlowNode_MP_API_UpdateRoom : FlowNode_Network
  {
    [Token(Token = "0x400546D")]
    private const int PIN_IN_PASS_LOCK = 1;
    [Token(Token = "0x400546E")]
    private const int PIN_IN_PASS_RELEASE = 2;
    [Token(Token = "0x400546F")]
    private const int PIN_IN_UPDATE_COMMENT = 3;
    [Token(Token = "0x4005470")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005471")]
    private const int PIN_OUT_FAILURE = 201;
    [Token(Token = "0x4005472")]
    private const int PIN_OUT_ILLEGAL_COMMENT = 301;
    [Token(Token = "0x4005473")]
    private const int PIN_OUT_NO_ROOM = 302;
    [Token(Token = "0x4005474")]
    private const int PIN_OUT_NO_MATCH_VERSION = 303;
    [Token(Token = "0x4005475")]
    private const int PIN_OUT_MULTI_MAINTENANCE = 304;

    [Token(Token = "0x6005F49")]
    [Address(RVA = "0x13378C0", Offset = "0x13366C0", VA = "0x113378C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F4A")]
    [Address(RVA = "0x1337D00", Offset = "0x1336B00", VA = "0x11337D00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F4B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_UpdateRoom()
    {
    }
  }
}
