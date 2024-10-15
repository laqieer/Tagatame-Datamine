// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGNodeDeclare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001712")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("GvG/Req/GvGNodeDeclare", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGNodeDeclare : FlowNode_Network
  {
    [Token(Token = "0x400532C")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400532D")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E04")]
    [Address(RVA = "0x1325F00", Offset = "0x1324D00", VA = "0x11325F00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E05")]
    [Address(RVA = "0x13267B0", Offset = "0x13255B0", VA = "0x113267B0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E06")]
    [Address(RVA = "0x1326110", Offset = "0x1324F10", VA = "0x11326110", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E07")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGNodeDeclare()
    {
    }

    [Token(Token = "0x2001713")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400532E")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGNodeDeclare.Response body;

      [Token(Token = "0x6005E08")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
