// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetScrollPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001624")]
  [FlowNode.NodeType("UI/SetScrollPosition")]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_SetScrollPosition : FlowNode
  {
    [Token(Token = "0x400503D")]
    [FieldOffset(Offset = "0x18")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400503E")]
    [FieldOffset(Offset = "0x1C")]
    public Vector2 NormalizedPosition;

    [Token(Token = "0x6005B05")]
    [Address(RVA = "0x12FBCE0", Offset = "0x12FAAE0", VA = "0x112FBCE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B06")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetScrollPosition()
    {
    }
  }
}
