// Decompiled with JetBrains decompiler
// Type: FlowNode_OnEndEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001F1")]
[FlowNode.Pin(1, "Edited", FlowNode.PinTypes.Output, 0)]
[AddComponentMenu("")]
[FlowNode.NodeType("Event/OnEndEdit", 58751)]
public class FlowNode_OnEndEdit : FlowNodePersistent
{
  [Token(Token = "0x4000898")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.DropTarget(typeof (InputField), true)]
  [FlowNode.ShowInInfo]
  public InputField Target;

  [Token(Token = "0x6000B05")]
  [Address(RVA = "0x107AD10", Offset = "0x1079B10", VA = "0x1107AD10")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B06")]
  [Address(RVA = "0x107ABE0", Offset = "0x10799E0", VA = "0x1107ABE0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000B07")]
  [Address(RVA = "0x107AC70", Offset = "0x1079A70", VA = "0x1107AC70")]
  private void OnEndEdit(InputField field)
  {
  }

  [Token(Token = "0x6000B08")]
  [Address(RVA = "0x107A050", Offset = "0x1078E50", VA = "0x1107A050", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B09")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OnEndEdit()
  {
  }
}
