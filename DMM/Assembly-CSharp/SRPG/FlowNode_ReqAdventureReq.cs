// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventureReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012E3")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(203, "AdventureUse", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(204, "SallyNotCond", FlowNode.PinTypes.Output, 204)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Adventure/Req/AdventureReq", 32741)]
  [FlowNode.Pin(200, "OutOfPeriod", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqAdventureReq : FlowNode_Network
  {
    [Token(Token = "0x4004651")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004652")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004653")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 200;
    [Token(Token = "0x4004654")]
    protected const int PIN_OUT_SALLY_OF_UNIT = 201;
    [Token(Token = "0x4004655")]
    protected const int PIN_OUT_ADVENTURE_USE = 203;
    [Token(Token = "0x4004656")]
    protected const int PIN_OUT_SALLY_NOT_COND = 204;

    [Token(Token = "0x6004FEC")]
    [Address(RVA = "0x1250AC0", Offset = "0x124F8C0", VA = "0x11250AC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FED")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FEE")]
    [Address(RVA = "0x1250C20", Offset = "0x124FA20", VA = "0x11250C20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FEF")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventureReq()
    {
    }

    [Token(Token = "0x20012E4")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004657")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventureReq.Response body;

      [Token(Token = "0x6004FF4")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
