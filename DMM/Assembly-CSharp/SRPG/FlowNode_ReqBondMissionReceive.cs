// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBondMissionReceive
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
  [Token(Token = "0x2001300")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Bond/Req/BondMissionReceive", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqBondMissionReceive : FlowNode_Network
  {
    [Token(Token = "0x4004695")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004696")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005041")]
    [Address(RVA = "0x12551C0", Offset = "0x1253FC0", VA = "0x112551C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005042")]
    [Address(RVA = "0x12558A0", Offset = "0x12546A0", VA = "0x112558A0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005043")]
    [Address(RVA = "0x12553E0", Offset = "0x12541E0", VA = "0x112553E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005044")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBondMissionReceive()
    {
    }

    [Token(Token = "0x2001301")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004697")]
      [FieldOffset(Offset = "0x28")]
      public ReqBondMissionReceive.Response body;

      [Token(Token = "0x6005045")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
