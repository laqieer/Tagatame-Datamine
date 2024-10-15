// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBondLevelUp
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
  [Token(Token = "0x20012FC")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Bond/Req/BondLevelUp", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqBondLevelUp : FlowNode_Network
  {
    [Token(Token = "0x400468F")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004690")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x6005037")]
    [Address(RVA = "0x1254AE0", Offset = "0x12538E0", VA = "0x11254AE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005038")]
    [Address(RVA = "0x1255150", Offset = "0x1253F50", VA = "0x11255150")]
    private void Success()
    {
    }

    [Token(Token = "0x6005039")]
    [Address(RVA = "0x1254D20", Offset = "0x1253B20", VA = "0x11254D20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600503A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBondLevelUp()
    {
    }

    [Token(Token = "0x20012FD")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004691")]
      [FieldOffset(Offset = "0x28")]
      public ReqBondLvUp.Response body;

      [Token(Token = "0x600503B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
