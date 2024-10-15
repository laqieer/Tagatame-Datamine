// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactStoneOpen
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
  [Token(Token = "0x200149B")]
  [FlowNode.NodeType("Artifact/Req/ArtifactStoneOpen", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqArtifactStoneOpen : FlowNode_Network
  {
    [Token(Token = "0x4004BEA")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BEB")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004BEC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x60055FF")]
    [Address(RVA = "0x12B9910", Offset = "0x12B8710", VA = "0x112B9910", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005600")]
    [Address(RVA = "0x12B9EA0", Offset = "0x12B8CA0", VA = "0x112B9EA0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005601")]
    [Address(RVA = "0x12B9B40", Offset = "0x12B8940", VA = "0x112B9B40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005602")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactStoneOpen()
    {
    }

    [Token(Token = "0x200149C")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004BED")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactStoneOpen.Response body;

      [Token(Token = "0x6005603")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
