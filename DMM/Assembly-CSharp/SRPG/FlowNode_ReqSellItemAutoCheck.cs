// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSellItemAutoCheck
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
  [Token(Token = "0x200158A")]
  [FlowNode.NodeType("System/Shop/ReqSellItemAutoCheck", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Not Find Item", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Find Item", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqSellItemAutoCheck : FlowNode_Network
  {
    [Token(Token = "0x4004E66")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004E67")]
    private const int PIN_OUT_FINDITEM = 100;
    [Token(Token = "0x4004E68")]
    private const int PIN_OUT_NOTFIND = 101;
    [Token(Token = "0x4004E69")]
    [FieldOffset(Offset = "0x20")]
    private bool isFindItems;

    [Token(Token = "0x60058CB")]
    [Address(RVA = "0x12DAA30", Offset = "0x12D9830", VA = "0x112DAA30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058CC")]
    [Address(RVA = "0x12DAEA0", Offset = "0x12D9CA0", VA = "0x112DAEA0")]
    private void Success()
    {
    }

    [Token(Token = "0x60058CD")]
    [Address(RVA = "0x12DAB20", Offset = "0x12D9920", VA = "0x112DAB20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058CE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSellItemAutoCheck()
    {
    }

    [Token(Token = "0x200158B")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004E6A")]
      [FieldOffset(Offset = "0x28")]
      public ReqSellItemAutoCheck.Response body;

      [Token(Token = "0x60058CF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
