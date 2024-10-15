// Decompiled with JetBrains decompiler
// Type: FlowNode_GameObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D7")]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/GameObject", 32741)]
public class FlowNode_GameObject : FlowNode
{
  [Token(Token = "0x4000857")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo(true)]
  public Component Target;

  [Token(Token = "0x6000AA6")]
  [Address(RVA = "0xF4DA00", Offset = "0xF4C800", VA = "0x10F4DA00", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000AA7")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "11")]
  public override bool OnDragUpdate(object[] objectReferences) => new bool();

  [Token(Token = "0x6000AA8")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "12")]
  public override bool OnDragPerform(object[] objectReferences) => new bool();

  [Token(Token = "0x6000AA9")]
  [Address(RVA = "0xF4DB20", Offset = "0xF4C920", VA = "0x10F4DB20", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AAA")]
  [Address(RVA = "0xF4D930", Offset = "0xF4C730", VA = "0x10F4D930")]
  public static void ActivateOutputLinks(Component caller, int pinID)
  {
  }

  [Token(Token = "0x6000AAB")]
  [Address(RVA = "0xF4D860", Offset = "0xF4C660", VA = "0x10F4D860")]
  public static void ActivateOutputLinks(Component caller, int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x6000AAC")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_GameObject()
  {
  }
}
