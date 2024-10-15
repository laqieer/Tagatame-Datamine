// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqInspSkillEquip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001738")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("InspSkill/Req/Equip", 32741)]
  public class FlowNode_ReqInspSkillEquip : FlowNode_Network
  {
    [Token(Token = "0x4005389")]
    protected const int PIN_INPUT_REQUEST = 1;
    [Token(Token = "0x400538A")]
    protected const int PIN_OUTPUT_SUCCESS = 101;

    [Token(Token = "0x6005E77")]
    [Address(RVA = "0x132C620", Offset = "0x132B420", VA = "0x1132C620", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E78")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E79")]
    [Address(RVA = "0x132C860", Offset = "0x132B660", VA = "0x1132C860", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E7A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqInspSkillEquip()
    {
    }
  }
}
