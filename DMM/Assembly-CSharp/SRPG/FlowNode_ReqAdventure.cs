// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D7")]
  [FlowNode.Pin(200, "OutOfPeriod", FlowNode.PinTypes.Output, 200)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Adventure/Req/AdventureTop", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqAdventure : FlowNode_Network
  {
    [Token(Token = "0x4004637")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004638")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004639")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 200;

    [Token(Token = "0x6004FC9")]
    [Address(RVA = "0x124C0C0", Offset = "0x124AEC0", VA = "0x1124C0C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FCA")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FCB")]
    [Address(RVA = "0x124C180", Offset = "0x124AF80", VA = "0x1124C180", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FCC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventure()
    {
    }

    [Token(Token = "0x20012D8")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400463A")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventure.Response body;

      [Token(Token = "0x6004FCE")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
