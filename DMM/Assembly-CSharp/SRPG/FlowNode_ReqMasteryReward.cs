// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMasteryReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001770")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("DoorMastery/Req/MasteryReward", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqMasteryReward : FlowNode_Network
  {
    [Token(Token = "0x400542C")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400542D")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005F14")]
    [Address(RVA = "0x1343710", Offset = "0x1342510", VA = "0x11343710", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F15")]
    [Address(RVA = "0x1343CA0", Offset = "0x1342AA0", VA = "0x11343CA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005F16")]
    [Address(RVA = "0x13437E0", Offset = "0x13425E0", VA = "0x113437E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F17")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMasteryReward()
    {
    }

    [Token(Token = "0x2001771")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400542E")]
      [FieldOffset(Offset = "0x28")]
      public ReqMasteryReward.Response body;

      [Token(Token = "0x6005F18")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
