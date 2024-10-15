// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptLeaderSkillSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014E3")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "リーダースキルを切り替えた", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "リーダースキルを切り替え", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptLeaderSkillSet", 32741)]
  public class FlowNode_ReqConceptLeaderSkillSet : FlowNode_Network
  {
    [Token(Token = "0x4004C92")]
    private const int INPUT_CONCEPT_LEADER_SKILL_SWITCH = 0;
    [Token(Token = "0x4004C93")]
    private const int OUTPUT_CONCEPT_LEADER_SKILL_SWITCH = 100;

    [Token(Token = "0x60056E4")]
    [Address(RVA = "0x12C5710", Offset = "0x12C4510", VA = "0x112C5710", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056E5")]
    [Address(RVA = "0x12C5B80", Offset = "0x12C4980", VA = "0x112C5B80", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056E6")]
    [Address(RVA = "0x12C3F80", Offset = "0x12C2D80", VA = "0x112C3F80")]
    private void ConceptLeaderSkillSetResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60056E7")]
    [Address(RVA = "0x12C5F20", Offset = "0x12C4D20", VA = "0x112C5F20")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x60056E8")]
    [Address(RVA = "0x12C5CC0", Offset = "0x12C4AC0", VA = "0x112C5CC0")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x60056E9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptLeaderSkillSet()
    {
    }

    [Token(Token = "0x20014E4")]
    [MessagePackObject(true)]
    public class MP_SetConceptLeaderSkill_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004C94")]
      [FieldOffset(Offset = "0x28")]
      public ReqSetConceptLeaderSkill_OverWrite.Response body;

      [Token(Token = "0x60056EA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_SetConceptLeaderSkill_OverWriteResponse()
      {
      }
    }
  }
}
