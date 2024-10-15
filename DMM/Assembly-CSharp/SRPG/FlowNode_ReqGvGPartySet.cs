// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGvGPartySet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001727")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GvG/Req/GvGPartySet", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGvGPartySet : FlowNode_Network
  {
    [Token(Token = "0x400535B")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400535C")]
    protected const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005E46")]
    [Address(RVA = "0x1329960", Offset = "0x1328760", VA = "0x11329960", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E47")]
    [Address(RVA = "0x132A1E0", Offset = "0x1328FE0", VA = "0x1132A1E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E48")]
    [Address(RVA = "0x1329BE0", Offset = "0x13289E0", VA = "0x11329BE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E49")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGvGPartySet()
    {
    }

    [Token(Token = "0x2001728")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400535D")]
      [FieldOffset(Offset = "0x28")]
      public ReqGvGPartySet.Response body;

      [Token(Token = "0x6005E4A")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
