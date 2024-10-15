// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactStoneConvert
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
  [Token(Token = "0x2001497")]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Artifact/Req/ArtifactStoneConvert", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqArtifactStoneConvert : FlowNode_Network
  {
    [Token(Token = "0x4004BE2")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BE3")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004BE4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x60055F5")]
    [Address(RVA = "0x12B8C80", Offset = "0x12B7A80", VA = "0x112B8C80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055F6")]
    [Address(RVA = "0x12B9160", Offset = "0x12B7F60", VA = "0x112B9160")]
    private void Success()
    {
    }

    [Token(Token = "0x60055F7")]
    [Address(RVA = "0x12B8E20", Offset = "0x12B7C20", VA = "0x112B8E20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055F8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactStoneConvert()
    {
    }

    [Token(Token = "0x2001498")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004BE5")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactStoneConvert.Response body;

      [Token(Token = "0x60055F9")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
