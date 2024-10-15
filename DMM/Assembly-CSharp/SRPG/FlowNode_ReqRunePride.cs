// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRunePride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200185C")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("RunePride/Req/ReqRunePride", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqRunePride : FlowNode_Network
  {
    [Token(Token = "0x4005761")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005762")]
    private const int PIN_OUT_SUCCESS = 100;

    [Token(Token = "0x600624B")]
    [Address(RVA = "0x30B780", Offset = "0x30A580", VA = "0x1030B780", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600624C")]
    [Address(RVA = "0x30BB90", Offset = "0x30A990", VA = "0x1030BB90")]
    private void Success()
    {
    }

    [Token(Token = "0x600624D")]
    [Address(RVA = "0x30B880", Offset = "0x30A680", VA = "0x1030B880", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600624E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRunePride()
    {
    }

    [Token(Token = "0x200185D")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005763")]
      [FieldOffset(Offset = "0x28")]
      public ReqRunePride.Response body;

      [Token(Token = "0x600624F")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
