// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqDrawCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001349")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("DrawCard/Req/GetStatus", 32741)]
  [FlowNode.Pin(201, "OutOfPeriod", FlowNode.PinTypes.Output, 201)]
  public class FlowNode_ReqDrawCard : FlowNode_Network
  {
    [Token(Token = "0x4004769")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400476A")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400476B")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 201;

    [Token(Token = "0x6005118")]
    [Address(RVA = "0x125F5E0", Offset = "0x125E3E0", VA = "0x1125F5E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005119")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x600511A")]
    [Address(RVA = "0x125F6A0", Offset = "0x125E4A0", VA = "0x1125F6A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600511B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqDrawCard()
    {
    }

    [Token(Token = "0x200134A")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400476C")]
      [FieldOffset(Offset = "0x28")]
      public ReqDrawCard.Response body;

      [Token(Token = "0x600511C")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
