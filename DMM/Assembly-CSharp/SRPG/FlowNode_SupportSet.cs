// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SupportSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001644")]
  [FlowNode.NodeType("System/Player/SupportSet", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_SupportSet : FlowNode_Network
  {
    [Token(Token = "0x40050DE")]
    [FieldOffset(Offset = "0x20")]
    public GameObject UnitParent;

    [Token(Token = "0x6005B88")]
    [Address(RVA = "0x130EF60", Offset = "0x130DD60", VA = "0x1130EF60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005B89")]
    [Address(RVA = "0x130EE30", Offset = "0x130DC30", VA = "0x1130EE30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B8A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnUnitSelect(long uniqueID)
    {
    }

    [Token(Token = "0x6005B8B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_SupportSet()
    {
    }
  }
}
