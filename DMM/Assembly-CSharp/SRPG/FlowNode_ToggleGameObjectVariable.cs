// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ToggleGameObjectVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001648")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Variable", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Toggle/GameObjectVariable", 32741)]
  [FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_ToggleGameObjectVariable : FlowNode
  {
    [Token(Token = "0x40050F1")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    public GameObject Target;
    [Token(Token = "0x40050F2")]
    [FieldOffset(Offset = "0x1C")]
    public FlowNode_ToggleGameObjectVariable.VariableType variable_type;
    [Token(Token = "0x40050F3")]
    [FieldOffset(Offset = "0x20")]
    public FlowNode_ToggleGameObjectVariable.EnableType enable_type;

    [Token(Token = "0x6005B9B")]
    [Address(RVA = "0x130F850", Offset = "0x130E650", VA = "0x1130F850", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B9C")]
    [Address(RVA = "0x130F960", Offset = "0x130E760", VA = "0x1130F960")]
    public void SetupVisible()
    {
    }

    [Token(Token = "0x6005B9D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ToggleGameObjectVariable()
    {
    }

    [Token(Token = "0x2001649")]
    public enum VariableType
    {
      [Token(Token = "0x40050F5")] None,
      [Token(Token = "0x40050F6")] IsEventQuest,
      [Token(Token = "0x40050F7")] Hide,
      [Token(Token = "0x40050F8")] Show,
    }

    [Token(Token = "0x200164A")]
    public enum EnableType
    {
      [Token(Token = "0x40050FA")] None,
      [Token(Token = "0x40050FB")] IsEventQuest,
      [Token(Token = "0x40050FC")] Disable,
      [Token(Token = "0x40050FD")] Enable,
    }
  }
}
