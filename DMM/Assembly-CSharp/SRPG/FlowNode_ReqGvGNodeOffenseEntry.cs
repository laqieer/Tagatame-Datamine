// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGNodeOffenseEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200171B")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGNodeOffenseEntry", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGvGNodeOffenseEntry : FlowNode_Network
  {
    [Token(Token = "0x4005341")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005342")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005343")]
    [FieldOffset(Offset = "0x20")]
    public bool IsSetGvGParty;
    [Token(Token = "0x4005344")]
    [FieldOffset(Offset = "0x21")]
    public bool isForce;

    [Token(Token = "0x6005E22")]
    [Address(RVA = "0x13280E0", Offset = "0x1326EE0", VA = "0x113280E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E23")]
    [Address(RVA = "0x1328BA0", Offset = "0x13279A0", VA = "0x11328BA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E24")]
    [Address(RVA = "0x1328370", Offset = "0x1327170", VA = "0x11328370", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E25")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGNodeOffenseEntry()
    {
    }

    [Token(Token = "0x200171C")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005345")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGNodeOffenseEntry.Response body;

      [Token(Token = "0x6005E26")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
