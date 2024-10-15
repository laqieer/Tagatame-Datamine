// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactStoneConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001495")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Artifact/Req/ArtifactStoneConfirm", 32741)]
  public class FlowNode_ReqArtifactStoneConfirm : FlowNode_Network
  {
    [Token(Token = "0x4004BDF")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BE0")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60055F0")]
    [Address(RVA = "0x12B87A0", Offset = "0x12B75A0", VA = "0x112B87A0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60055F1")]
    [Address(RVA = "0x12B8C10", Offset = "0x12B7A10", VA = "0x112B8C10")]
    private void Success()
    {
    }

    [Token(Token = "0x60055F2")]
    [Address(RVA = "0x12B8910", Offset = "0x12B7710", VA = "0x112B8910", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055F3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactStoneConfirm()
    {
    }

    [Token(Token = "0x2001496")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004BE1")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactStoneConfirm.Response body;

      [Token(Token = "0x60055F4")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
