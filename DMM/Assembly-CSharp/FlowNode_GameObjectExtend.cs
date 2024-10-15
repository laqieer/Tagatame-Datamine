// Decompiled with JetBrains decompiler
// Type: FlowNode_GameObjectExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D9")]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/GameObjectExtend", 32741)]
public class FlowNode_GameObjectExtend : FlowNode
{
  [Token(Token = "0x4000858")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo(true)]
  public Component Target;

  [Token(Token = "0x6000AAE")]
  [Address(RVA = "0xF4D5C0", Offset = "0xF4C3C0", VA = "0x10F4D5C0", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000AAF")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "11")]
  public override bool OnDragUpdate(object[] objectReferences) => new bool();

  [Token(Token = "0x6000AB0")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "12")]
  public override bool OnDragPerform(object[] objectReferences) => new bool();

  [Token(Token = "0x6000AB1")]
  [Address(RVA = "0xF4D6E0", Offset = "0xF4C4E0", VA = "0x10F4D6E0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AB2")]
  [Address(RVA = "0xF4D780", Offset = "0xF4C580", VA = "0x10F4D780", Slot = "5")]
  public override void OnActivate(int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x6000AB3")]
  [Address(RVA = "0xF4D4F0", Offset = "0xF4C2F0", VA = "0x10F4D4F0")]
  public static void ActivateOutputLinks(Component caller, int pinID)
  {
  }

  [Token(Token = "0x6000AB4")]
  [Address(RVA = "0xF4D420", Offset = "0xF4C220", VA = "0x10F4D420")]
  public static void ActivateOutputLinks(Component caller, int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x6000AB5")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_GameObjectExtend()
  {
  }
}
