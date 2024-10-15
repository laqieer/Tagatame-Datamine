// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016FD")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGBattle", 32741)]
  public class FlowNode_ReqGvGBattle : FlowNode_Network
  {
    [Token(Token = "0x40052FD")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40052FE")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005DBF")]
    [Address(RVA = "0x13233F0", Offset = "0x13221F0", VA = "0x113233F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DC0")]
    [Address(RVA = "0x1323E20", Offset = "0x1322C20", VA = "0x11323E20")]
    private void Success()
    {
    }

    [Token(Token = "0x6005DC1")]
    [Address(RVA = "0x1323600", Offset = "0x1322400", VA = "0x11323600", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005DC2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGBattle()
    {
    }

    [Token(Token = "0x20016FE")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40052FF")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGBattle.Response body;

      [Token(Token = "0x6005DC3")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
