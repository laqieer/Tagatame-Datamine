// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ResetScrollPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015F0")]
  [FlowNode.NodeType("UI/ResetScrollPosition", 32741)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ResetScrollPosition : FlowNode
  {
    [Token(Token = "0x4004F9A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect ScrollParent;
    [Token(Token = "0x4004F9B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform ResetTransform;
    [Token(Token = "0x4004F9C")]
    [FieldOffset(Offset = "0x20")]
    private float mDecelerationRate;

    [Token(Token = "0x6005A1E")]
    [Address(RVA = "0x12EB570", Offset = "0x12EA370", VA = "0x112EB570", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A1F")]
    [Address(RVA = "0x12EB730", Offset = "0x12EA530", VA = "0x112EB730")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x6005A20")]
    [Address(RVA = "0x12EB6C0", Offset = "0x12EA4C0", VA = "0x112EB6C0")]
    private IEnumerator RefreshScrollRect() => (IEnumerator) null;

    [Token(Token = "0x6005A21")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ResetScrollPosition()
    {
    }
  }
}
