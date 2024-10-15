// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetInspSkillTargetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200173E")]
  [FlowNode.NodeType("InspSkill/SetTargetData", 32741)]
  [FlowNode.Pin(0, "Set", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Done", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_SetInspSkillTargetData : FlowNode
  {
    [Token(Token = "0x4005397")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    public FlowNode_SetInspSkillTargetData.SetType setType;
    [Token(Token = "0x4005398")]
    [FieldOffset(Offset = "0x1C")]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    [FlowNode.ShowInInfo]
    public GameObject target;

    [Token(Token = "0x6005E8C")]
    [Address(RVA = "0x1344740", Offset = "0x1343540", VA = "0x11344740", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E8D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetInspSkillTargetData()
    {
    }

    [Token(Token = "0x200173F")]
    public enum SetType
    {
      [Token(Token = "0x400539A")] TargetArtifact,
      [Token(Token = "0x400539B")] TargetInspirationSkill,
      [Token(Token = "0x400539C")] MixArtifact,
      [Token(Token = "0x400539D")] ClearTargetArtifact,
      [Token(Token = "0x400539E")] ClearTargetInspirationSkill,
      [Token(Token = "0x400539F")] ClearMixArtifact,
    }
  }
}
