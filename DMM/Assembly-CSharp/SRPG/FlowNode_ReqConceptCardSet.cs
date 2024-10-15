// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014DC")]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardSet", 32741)]
  [FlowNode.Pin(0, "装備", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "装備した", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ReqConceptCardSet : FlowNode_Network
  {
    [Token(Token = "0x4004C82")]
    private const int INPUT_CONCEPT_CARD_SET = 0;
    [Token(Token = "0x4004C83")]
    private const int OUTPUT_CONCEPT_CARD_SET = 100;
    [Token(Token = "0x4004C84")]
    [FieldOffset(Offset = "0x20")]
    private long[] mEquipCardIds;
    [Token(Token = "0x4004C85")]
    [FieldOffset(Offset = "0x28")]
    private long mTargetUnitId;

    [Token(Token = "0x60056CB")]
    [Address(RVA = "0x12C4450", Offset = "0x12C3250", VA = "0x112C4450")]
    public void SetEquipParam(long[] equip_card_iids, long unit_iid)
    {
    }

    [Token(Token = "0x60056CC")]
    [Address(RVA = "0x12C4480", Offset = "0x12C3280", VA = "0x112C4480")]
    public void SetReleaseParam(long[] equip_card_iids)
    {
    }

    [Token(Token = "0x60056CD")]
    [Address(RVA = "0x12C43B0", Offset = "0x12C31B0", VA = "0x112C43B0")]
    private void ResetParam()
    {
    }

    [Token(Token = "0x60056CE")]
    [Address(RVA = "0x12C3FE0", Offset = "0x12C2DE0", VA = "0x112C3FE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056CF")]
    [Address(RVA = "0x12C4270", Offset = "0x12C3070", VA = "0x112C4270", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056D0")]
    [Address(RVA = "0x12C4710", Offset = "0x12C3510", VA = "0x112C4710")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x60056D1")]
    [Address(RVA = "0x12C44B0", Offset = "0x12C32B0", VA = "0x112C44B0")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x60056D2")]
    [Address(RVA = "0x12C3F80", Offset = "0x12C2D80", VA = "0x112C3F80")]
    private void ConceptCardSetResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60056D3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardSet()
    {
    }

    [Token(Token = "0x20014DD")]
    [MessagePackObject(true)]
    public class MP_SetConceptCard_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004C86")]
      [FieldOffset(Offset = "0x28")]
      public ReqSetConceptCard_OverWrite.Response body;

      [Token(Token = "0x60056D4")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_SetConceptCard_OverWriteResponse()
      {
      }
    }
  }
}
