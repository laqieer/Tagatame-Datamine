// Decompiled with JetBrains decompiler
// Type: FlowNode_GUIEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001DD")]
[AddComponentMenu("")]
[FlowNode.Pin(200, "Opened", FlowNode.PinTypes.Output, 200)]
[FlowNode.NodeType("Common/GUIEX", 32741)]
[FlowNode.Pin(210, "Closed", FlowNode.PinTypes.Output, 210)]
public class FlowNode_GUIEx : FlowNode_GUI
{
  [Token(Token = "0x4000864")]
  [FieldOffset(Offset = "0x54")]
  public bool m_ButtonEventArg;
  [Token(Token = "0x4000865")]
  [FieldOffset(Offset = "0x58")]
  public FlowNode_GUIEx.ValueType m_Type;
  [Token(Token = "0x4000866")]
  [FieldOffset(Offset = "0x5C")]
  public SerializeValueBehaviour m_Object;
  [Token(Token = "0x4000867")]
  [FieldOffset(Offset = "0x60")]
  public SerializeValueList m_ValueList;

  [Token(Token = "0x6000ACA")]
  [Address(RVA = "0xF4AEA0", Offset = "0xF49CA0", VA = "0x10F4AEA0", Slot = "15")]
  protected override void OnInstanceCreate()
  {
  }

  [Token(Token = "0x6000ACB")]
  [Address(RVA = "0xF4B170", Offset = "0xF49F70", VA = "0x10F4B170")]
  public FlowNode_GUIEx()
  {
  }

  [Token(Token = "0x20001DE")]
  public enum ValueType
  {
    [Token(Token = "0x4000869")] Direct,
    [Token(Token = "0x400086A")] RefObject,
  }
}
