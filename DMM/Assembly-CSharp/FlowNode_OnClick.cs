// Decompiled with JetBrains decompiler
// Type: FlowNode_OnClick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001EE")]
[FlowNode.Pin(1, "Clicked", FlowNode.PinTypes.Output, 0)]
[FlowNode.NodeType("Event/OnClickButton", 58751)]
[AddComponentMenu("")]
public class FlowNode_OnClick : FlowNodePersistent
{
  [Token(Token = "0x4000896")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (Button), true)]
  public Button Target;
  [Token(Token = "0x4000897")]
  [FieldOffset(Offset = "0x1C")]
  private Button mBound;

  [Token(Token = "0x6000AFB")]
  [Address(RVA = "0x107A090", Offset = "0x1078E90", VA = "0x1107A090")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AFC")]
  [Address(RVA = "0x1079F50", Offset = "0x1078D50", VA = "0x11079F50")]
  private void Bind()
  {
  }

  [Token(Token = "0x6000AFD")]
  [Address(RVA = "0x107A070", Offset = "0x1078E70", VA = "0x1107A070")]
  private void OnClick()
  {
  }

  [Token(Token = "0x6000AFE")]
  [Address(RVA = "0x107A050", Offset = "0x1078E50", VA = "0x1107A050", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AFF")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OnClick()
  {
  }
}
