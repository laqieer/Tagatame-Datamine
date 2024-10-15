// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBondMission
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
  [Token(Token = "0x20012FE")]
  [FlowNode.NodeType("Bond/Req/BondMission", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqBondMission : FlowNode_Network
  {
    [Token(Token = "0x4004692")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004693")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x600503C")]
    [Address(RVA = "0x1255910", Offset = "0x1254710", VA = "0x11255910", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600503D")]
    [Address(RVA = "0x1255D80", Offset = "0x1254B80", VA = "0x11255D80")]
    private void Success()
    {
    }

    [Token(Token = "0x600503E")]
    [Address(RVA = "0x12559E0", Offset = "0x12547E0", VA = "0x112559E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600503F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBondMission()
    {
    }

    [Token(Token = "0x20012FF")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004694")]
      [FieldOffset(Offset = "0x28")]
      public ReqBondMission.Response body;

      [Token(Token = "0x6005040")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
