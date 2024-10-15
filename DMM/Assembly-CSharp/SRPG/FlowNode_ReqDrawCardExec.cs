// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDrawCardExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200134B")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "OutOfPeriod", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("DrawCard/Req/Exec", 32741)]
  public class FlowNode_ReqDrawCardExec : FlowNode_Network
  {
    [Token(Token = "0x400476D")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400476E")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400476F")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 201;

    [Token(Token = "0x600511D")]
    [Address(RVA = "0x125EE40", Offset = "0x125DC40", VA = "0x1125EE40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600511E")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x600511F")]
    [Address(RVA = "0x125EF50", Offset = "0x125DD50", VA = "0x1125EF50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005120")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDrawCardExec()
    {
    }

    [Token(Token = "0x200134C")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004770")]
      [FieldOffset(Offset = "0x28")]
      public ReqDrawCardExec.Response body;

      [Token(Token = "0x6005121")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
