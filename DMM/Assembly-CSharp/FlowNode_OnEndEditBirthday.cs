// Decompiled with JetBrains decompiler
// Type: FlowNode_OnEndEditBirthday
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001F2")]
[AddComponentMenu("")]
[FlowNode.Pin(1, "Invalid", FlowNode.PinTypes.Output, 0)]
[FlowNode.Pin(0, "Valid", FlowNode.PinTypes.Output, 0)]
[FlowNode.NodeType("Event/OnEndEditBirthday", 58751)]
public class FlowNode_OnEndEditBirthday : FlowNodePersistent
{
  [Token(Token = "0x4000899")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.DropTarget(typeof (InputField), true)]
  [FlowNode.ShowInInfo]
  public InputField TargetYear;
  [Token(Token = "0x400089A")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.DropTarget(typeof (InputField), true)]
  [FlowNode.ShowInInfo]
  public InputField TargetMonth;
  [Token(Token = "0x400089B")]
  [FieldOffset(Offset = "0x20")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (InputField), true)]
  public InputField TargetDay;
  [Token(Token = "0x400089C")]
  [FieldOffset(Offset = "0x24")]
  [FlowNode.DropTarget(typeof (InputField), true)]
  public Button ok;

  [Token(Token = "0x6000B0B")]
  [Address(RVA = "0x107A880", Offset = "0x1079680", VA = "0x1107A880")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B0C")]
  [Address(RVA = "0x107A200", Offset = "0x1079000", VA = "0x1107A200", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000B0D")]
  [Address(RVA = "0x107A400", Offset = "0x1079200", VA = "0x1107A400")]
  private void OnEndEditYear(InputField field)
  {
  }

  [Token(Token = "0x6000B0E")]
  [Address(RVA = "0x107A390", Offset = "0x1079190", VA = "0x1107A390")]
  private void OnEndEditMonth(InputField field)
  {
  }

  [Token(Token = "0x6000B0F")]
  [Address(RVA = "0x107A320", Offset = "0x1079120", VA = "0x1107A320")]
  private void OnEndEditDay(InputField field)
  {
  }

  [Token(Token = "0x6000B10")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B11")]
  [Address(RVA = "0x107A470", Offset = "0x1079270", VA = "0x1107A470")]
  private void OutputResult()
  {
  }

  [Token(Token = "0x6000B12")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OnEndEditBirthday()
  {
  }
}
