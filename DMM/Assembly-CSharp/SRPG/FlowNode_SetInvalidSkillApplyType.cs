// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetInvalidSkillApplyType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001745")]
  [FlowNode.NodeType("SetInvalidSkillApplyType", 13618982)]
  [FlowNode.Pin(0, "SetApplyType", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "CheckPartyEditor", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(20, "Failure", FlowNode.PinTypes.Output, 20)]
  public class FlowNode_SetInvalidSkillApplyType : FlowNode
  {
    [Token(Token = "0x40053B0")]
    private const int PIN_IN_SET_APPLY_TYPE = 0;
    [Token(Token = "0x40053B1")]
    private const int PIN_IN_CHECK_PARTY_EDITOR = 1;
    [Token(Token = "0x40053B2")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x40053B3")]
    private const int PIN_OUT_FAILURE = 20;
    [Token(Token = "0x40053B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EInvalidSkillApplyType InvalidSkillApplyType;
    [Token(Token = "0x40053B5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject UnitToolTip;

    [Token(Token = "0x6005E9C")]
    [Address(RVA = "0x1344CE0", Offset = "0x1343AE0", VA = "0x11344CE0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005E9D")]
    [Address(RVA = "0x1344DD0", Offset = "0x1343BD0", VA = "0x11344DD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E9E")]
    [Address(RVA = "0x1344AB0", Offset = "0x13438B0", VA = "0x11344AB0")]
    private void CheckPartyEditorType()
    {
    }

    [Token(Token = "0x6005E9F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetInvalidSkillApplyType()
    {
    }
  }
}
