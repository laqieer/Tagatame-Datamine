// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MoveGameObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001433")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Common/MoveGameObject", 32741)]
  public class FlowNode_MoveGameObject : FlowNode
  {
    [Token(Token = "0x4004ADC")]
    [FieldOffset(Offset = "0x18")]
    public GameObject Target;
    [Token(Token = "0x4004ADD")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject Destination;
    [Token(Token = "0x4004ADE")]
    [FieldOffset(Offset = "0x20")]
    public float Time;
    [Token(Token = "0x4004ADF")]
    [FieldOffset(Offset = "0x24")]
    public ObjectAnimator.CurveType InterpolationMode;

    [Token(Token = "0x6005457")]
    [Address(RVA = "0x128FC80", Offset = "0x128EA80", VA = "0x1128FC80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005458")]
    [Address(RVA = "0x128FDC0", Offset = "0x128EBC0", VA = "0x1128FDC0")]
    public FlowNode_MoveGameObject()
    {
    }
  }
}
