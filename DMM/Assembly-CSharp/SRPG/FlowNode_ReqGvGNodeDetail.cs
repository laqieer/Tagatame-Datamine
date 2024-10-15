// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGNodeDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001718")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GvG/Req/GvGNodeDetail", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGvGNodeDetail : FlowNode_Network
  {
    [Token(Token = "0x400533B")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400533C")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E18")]
    [Address(RVA = "0x1327370", Offset = "0x1326170", VA = "0x11327370", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E19")]
    [Address(RVA = "0x1327C20", Offset = "0x1326A20", VA = "0x11327C20")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E1A")]
    [Address(RVA = "0x1327610", Offset = "0x1326410", VA = "0x11327610", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E1B")]
    [Address(RVA = "0x1327C90", Offset = "0x1326A90", VA = "0x11327C90")]
    public static JSON_GvGPartyUnit _CreateTestUnit(long iid, string unitIname)
    {
      return (JSON_GvGPartyUnit) null;
    }

    [Token(Token = "0x6005E1C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGNodeDetail()
    {
    }

    [Token(Token = "0x2001719")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400533D")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGNodeDetail.Response body;

      [Token(Token = "0x6005E1D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
