// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGPGSDisrelateAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016A0")]
  [FlowNode.NodeType("GPGS/ReqDisrelateAccount", 32741)]
  [FlowNode.Pin(200, "Failed", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGPGSDisrelateAccount : FlowNode_Network
  {
    [Token(Token = "0x4005233")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005234")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005235")]
    private const int PIN_OUT_FAILED = 200;

    [Token(Token = "0x6005CBB")]
    [Address(RVA = "0x1308C70", Offset = "0x1307A70", VA = "0x11308C70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CBC")]
    [Address(RVA = "0x1308E10", Offset = "0x1307C10", VA = "0x11308E10")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CBD")]
    [Address(RVA = "0x1308CC0", Offset = "0x1307AC0", VA = "0x11308CC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CBE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGPGSDisrelateAccount()
    {
    }

    [Token(Token = "0x20016A1")]
    [MessagePackObject(true)]
    [Serializable]
    public class DisrelateAccountResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005236")]
      [FieldOffset(Offset = "0x28")]
      public ReqGPGSDisrelateAccount.Response body;

      [Token(Token = "0x6005CBF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public DisrelateAccountResponse()
      {
      }
    }
  }
}
