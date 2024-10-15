// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F7")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("FlowNode_ReqPlayerInfo", 32741)]
  [FlowNode.Pin(200, "Failed", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqPlayerInfo : FlowNode_Network
  {
    [Token(Token = "0x4005651")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005652")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005653")]
    private const int PIN_OUT_FAILED = 200;

    [Token(Token = "0x60060EB")]
    [Address(RVA = "0x135C550", Offset = "0x135B350", VA = "0x1135C550", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060EC")]
    [Address(RVA = "0x135C900", Offset = "0x135B700", VA = "0x1135C900")]
    private void Success()
    {
    }

    [Token(Token = "0x60060ED")]
    [Address(RVA = "0x135C620", Offset = "0x135B420", VA = "0x1135C620", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60060EE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPlayerInfo()
    {
    }

    [Token(Token = "0x20017F8")]
    [MessagePackObject(true)]
    [Serializable]
    public class PlayerInfoResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005654")]
      [FieldOffset(Offset = "0x28")]
      public ReqPlayerInfo.Response body;

      [Token(Token = "0x60060F0")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public PlayerInfoResponse()
      {
      }
    }
  }
}
