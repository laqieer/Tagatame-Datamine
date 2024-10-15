// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_FgGBtn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013EA")]
  [FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("FgGID/FgGBtn", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_FgGBtn : FlowNode
  {
    [Token(Token = "0x40049CF")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    public string ParameterName;
    [Token(Token = "0x40049D0")]
    [FieldOffset(Offset = "0x1C")]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    [FlowNode.ShowInInfo]
    public GameObject Target;
    [Token(Token = "0x40049D1")]
    [FieldOffset(Offset = "0x20")]
    public bool UpdateAnimator;

    [Token(Token = "0x6005365")]
    [Address(RVA = "0x1280110", Offset = "0x127EF10", VA = "0x11280110", Slot = "10")]
    public override string GetCaption() => (string) null;

    [Token(Token = "0x6005366")]
    [Address(RVA = "0x1280160", Offset = "0x127EF60", VA = "0x11280160", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005367")]
    [Address(RVA = "0x12802E0", Offset = "0x127F0E0", VA = "0x112802E0")]
    public FlowNode_FgGBtn()
    {
    }
  }
}
