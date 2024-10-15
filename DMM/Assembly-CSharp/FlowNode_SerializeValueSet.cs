// Decompiled with JetBrains decompiler
// Type: FlowNode_SerializeValueSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000212")]
[AddComponentMenu("")]
[FlowNode.Pin(110, "次へ", FlowNode.PinTypes.Output, 110)]
[FlowNode.NodeType("SerializeValue/Set", 32741)]
[FlowNode.Pin(100, "設定", FlowNode.PinTypes.Input, 100)]
public class FlowNode_SerializeValueSet : FlowNode
{
  [Token(Token = "0x4000914")]
  public const int INPUT_SET = 100;
  [Token(Token = "0x4000915")]
  public const int OUTPUT_SETED = 110;
  [Token(Token = "0x4000916")]
  [FieldOffset(Offset = "0x18")]
  public FlowNode_SerializeValueSet.ValueType m_Type;
  [Token(Token = "0x4000917")]
  [FieldOffset(Offset = "0x1C")]
  public SerializeValueBehaviour m_Object;
  [Token(Token = "0x4000918")]
  [FieldOffset(Offset = "0x20")]
  public List<FlowNode_SerializeValueSet.Value> m_Values;

  [Token(Token = "0x6000B6A")]
  [Address(RVA = "0x107E240", Offset = "0x107D040", VA = "0x1107E240", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000B6B")]
  [Address(RVA = "0x107E6C0", Offset = "0x107D4C0", VA = "0x1107E6C0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B6C")]
  [Address(RVA = "0x107EA30", Offset = "0x107D830", VA = "0x1107EA30")]
  public FlowNode_SerializeValueSet()
  {
  }

  [Token(Token = "0x2000213")]
  public enum ValueType
  {
    [Token(Token = "0x400091A")] RefObject,
    [Token(Token = "0x400091B")] Global,
    [Token(Token = "0x400091C")] ButtonEventArg,
  }

  [Token(Token = "0x2000214")]
  [Serializable]
  public class Value
  {
    [Token(Token = "0x400091D")]
    [FieldOffset(Offset = "0x8")]
    public string m_Key;
    [Token(Token = "0x400091E")]
    [FieldOffset(Offset = "0xC")]
    public SerializeValue.PropertyType m_PropertyType;
    [Token(Token = "0x400091F")]
    [FieldOffset(Offset = "0x10")]
    public SerializeValue m_Value;

    [Token(Token = "0x6000B6D")]
    [Address(RVA = "0x108B380", Offset = "0x108A180", VA = "0x1108B380")]
    public Value()
    {
    }
  }
}
