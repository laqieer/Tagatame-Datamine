// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGHalfTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200170C")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGHalfTime", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGHalfTime : FlowNode_Network
  {
    [Token(Token = "0x400531C")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400531D")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DED")]
    [Address(RVA = "0x1324D70", Offset = "0x1323B70", VA = "0x11324D70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DEE")]
    [Address(RVA = "0x1325480", Offset = "0x1324280", VA = "0x11325480")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DEF")]
    [Address(RVA = "0x1324F00", Offset = "0x1323D00", VA = "0x11324F00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DF0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGHalfTime()
    {
    }

    [Token(Token = "0x200170D")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400531E")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGHalfTime.Response body;

      [Token(Token = "0x6005DF1")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
