// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGPGSRelateAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016A3")]
  [FlowNode.Pin(200, "Failed", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("GPGS/ReqRelateAccount", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGPGSRelateAccount : FlowNode_Network
  {
    [Token(Token = "0x400523A")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400523B")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x400523C")]
    private const int PIN_OUT_FAILED = 200;

    [Token(Token = "0x6005CC2")]
    [Address(RVA = "0x1308EF0", Offset = "0x1307CF0", VA = "0x11308EF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CC3")]
    [Address(RVA = "0x1308E80", Offset = "0x1307C80", VA = "0x11308E80")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005CC4")]
    [Address(RVA = "0x1309090", Offset = "0x1307E90", VA = "0x11309090")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CC5")]
    [Address(RVA = "0x1308F60", Offset = "0x1307D60", VA = "0x11308F60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CC6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGPGSRelateAccount()
    {
    }

    [Token(Token = "0x20016A4")]
    [MessagePackObject(true)]
    [Serializable]
    public class RelateAccountResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400523D")]
      [FieldOffset(Offset = "0x28")]
      public ReqGPGSRelateAccount.Response body;

      [Token(Token = "0x6005CC7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public RelateAccountResponse()
      {
      }
    }
  }
}
