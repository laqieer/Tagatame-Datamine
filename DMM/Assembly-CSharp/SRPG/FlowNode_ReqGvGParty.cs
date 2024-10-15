// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200171E")]
  [FlowNode.NodeType("GvG/Req/GvGParty", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGParty : FlowNode_Network
  {
    [Token(Token = "0x400534A")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400534B")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E2C")]
    [Address(RVA = "0x132A250", Offset = "0x1329050", VA = "0x1132A250", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E2D")]
    [Address(RVA = "0x132A8F0", Offset = "0x13296F0", VA = "0x1132A8F0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E2E")]
    [Address(RVA = "0x132A320", Offset = "0x1329120", VA = "0x1132A320", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E2F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGParty()
    {
    }

    [Token(Token = "0x200171F")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400534C")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGParty.Response body;

      [Token(Token = "0x6005E30")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
