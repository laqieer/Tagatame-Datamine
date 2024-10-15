// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvG
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016FA")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GvG/Req/GvG", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGvG : FlowNode_Network
  {
    [Token(Token = "0x40052F7")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052F8")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DB6")]
    [Address(RVA = "0x132B6F0", Offset = "0x132A4F0", VA = "0x1132B6F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DB7")]
    [Address(RVA = "0x132BEA0", Offset = "0x132ACA0", VA = "0x1132BEA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DB8")]
    [Address(RVA = "0x132B870", Offset = "0x132A670", VA = "0x1132B870", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DB9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvG()
    {
    }

    [Token(Token = "0x20016FB")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052F9")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvG.Response body;

      [Token(Token = "0x6005DBA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
