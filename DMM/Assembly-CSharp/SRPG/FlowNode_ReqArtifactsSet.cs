// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactsSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001492")]
  [FlowNode.NodeType("System/ReqArtifact/ReqArtifactsSet", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "装備武具に変更発生", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_ReqArtifactsSet : FlowNode_Network
  {
    [Token(Token = "0x4004BD9")]
    private const int PIN_INPUT_REQUEST = 0;
    [Token(Token = "0x4004BDA")]
    private const int PIN_OUTPUT_SUCCESS = 1;
    [Token(Token = "0x4004BDB")]
    private const int PIN_OUTPUT_ARTIFACT_DIFF = 2;
    [Token(Token = "0x4004BDC")]
    [FieldOffset(Offset = "0x20")]
    private UnitData unit;

    [Token(Token = "0x60055E6")]
    [Address(RVA = "0x12BA4B0", Offset = "0x12B92B0", VA = "0x112BA4B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055E7")]
    [Address(RVA = "0x12BB430", Offset = "0x12BA230", VA = "0x112BB430")]
    private void Success(bool is_need_refresh_event = true)
    {
    }

    [Token(Token = "0x60055E8")]
    [Address(RVA = "0x12BAB70", Offset = "0x12B9970", VA = "0x112BAB70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055E9")]
    [Address(RVA = "0x12BAF80", Offset = "0x12B9D80", VA = "0x112BAF80")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x60055EA")]
    [Address(RVA = "0x12BACA0", Offset = "0x12B9AA0", VA = "0x112BACA0")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x60055EB")]
    [Address(RVA = "0x12BA2B0", Offset = "0x12B90B0", VA = "0x112BA2B0")]
    private bool IsDiffEquipArtifacts(long job_iid, List<long> artifacts_iid) => new bool();

    [Token(Token = "0x60055EC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactsSet()
    {
    }

    [Token(Token = "0x2001493")]
    [MessagePackObject(true)]
    public class MP_ArtifactSet_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004BDD")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactSet_OverWrite.Response body;

      [Token(Token = "0x60055ED")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ArtifactSet_OverWriteResponse()
      {
      }
    }
  }
}
