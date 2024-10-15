// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactStoneLottery
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
  [Token(Token = "0x2001499")]
  [FlowNode.NodeType("Artifact/Req/ArtifactStoneLottery", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqArtifactStoneLottery : FlowNode_Network
  {
    [Token(Token = "0x4004BE6")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004BE7")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004BE8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;

    [Token(Token = "0x60055FA")]
    [Address(RVA = "0x12B91D0", Offset = "0x12B7FD0", VA = "0x112B91D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055FB")]
    [Address(RVA = "0x12B98A0", Offset = "0x12B86A0", VA = "0x112B98A0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055FC")]
    [Address(RVA = "0x12B9460", Offset = "0x12B8260", VA = "0x112B9460", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055FD")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactStoneLottery()
    {
    }

    [Token(Token = "0x200149A")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004BE9")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactStoneLottery.Response body;

      [Token(Token = "0x60055FE")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
