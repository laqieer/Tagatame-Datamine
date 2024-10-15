// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGPGSCheckRelateAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200169C")]
  [FlowNode.Pin(200, "False", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "True", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("GPGS/ReqCheckRelate", 32741)]
  public class FlowNode_ReqGPGSCheckRelateAccount : FlowNode_Network
  {
    [Token(Token = "0x400522A")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400522B")]
    private const int PIN_OUT_TRUE = 100;
    [Token(Token = "0x400522C")]
    private const int PIN_OUT_FALSE = 200;

    [Token(Token = "0x6005CB0")]
    [Address(RVA = "0x1308790", Offset = "0x1307590", VA = "0x11308790", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CB1")]
    [Address(RVA = "0x1308720", Offset = "0x1307520", VA = "0x11308720")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005CB2")]
    [Address(RVA = "0x1308990", Offset = "0x1307790", VA = "0x11308990")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CB3")]
    [Address(RVA = "0x13087E0", Offset = "0x13075E0", VA = "0x113087E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CB4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGPGSCheckRelateAccount()
    {
    }

    [Token(Token = "0x200169D")]
    [MessagePackObject(true)]
    [Serializable]
    public class CheckRelateAccountResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400522D")]
      [FieldOffset(Offset = "0x28")]
      public ReqGPGSCheckRelate.Response body;

      [Token(Token = "0x6005CB5")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public CheckRelateAccountResponse()
      {
      }
    }
  }
}
