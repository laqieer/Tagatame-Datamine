// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBondReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001302")]
  [FlowNode.NodeType("Bond/Req/BondRest", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqBondReset : FlowNode_Network
  {
    [Token(Token = "0x4004698")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004699")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005046")]
    [Address(RVA = "0x1255DF0", Offset = "0x1254BF0", VA = "0x11255DF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005047")]
    [Address(RVA = "0x1256570", Offset = "0x1255370", VA = "0x11256570")]
    private void Success()
    {
    }

    [Token(Token = "0x6005048")]
    [Address(RVA = "0x1255F90", Offset = "0x1254D90", VA = "0x11255F90", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005049")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBondReset()
    {
    }

    [Token(Token = "0x2001303")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400469A")]
      [FieldOffset(Offset = "0x28")]
      public ReqBondRest.Response body;

      [Token(Token = "0x600504A")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
