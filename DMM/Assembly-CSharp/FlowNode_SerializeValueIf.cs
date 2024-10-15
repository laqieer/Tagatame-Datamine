// Decompiled with JetBrains decompiler
// Type: FlowNode_SerializeValueIf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200020E")]
[FlowNode.Pin(120, "偽", FlowNode.PinTypes.Output, 120)]
[FlowNode.NodeType("SerializeValue/If", 32741)]
[FlowNode.Pin(100, "条件分岐", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(110, "真", FlowNode.PinTypes.Output, 110)]
[AddComponentMenu("")]
public class FlowNode_SerializeValueIf : FlowNode
{
  [Token(Token = "0x40008FE")]
  public const int INPUT_OPERATOR = 100;
  [Token(Token = "0x40008FF")]
  public const int OUTPUT_SUCCESS = 110;
  [Token(Token = "0x4000900")]
  public const int OUTPUT_FAILURE = 120;
  [Token(Token = "0x4000901")]
  [FieldOffset(Offset = "0x18")]
  public FlowNode_SerializeValueIf.Value m_Value1;
  [Token(Token = "0x4000902")]
  [FieldOffset(Offset = "0x1C")]
  public FlowNode_SerializeValueIf.Value m_Value2;
  [Token(Token = "0x4000903")]
  [FieldOffset(Offset = "0x20")]
  public SerializeValue.PropertyType m_PropertyType;
  [Token(Token = "0x4000904")]
  [FieldOffset(Offset = "0x24")]
  public FlowNode_SerializeValueIf.Operator m_Operator;

  [Token(Token = "0x6000B65")]
  [Address(RVA = "0x107E5C0", Offset = "0x107D3C0", VA = "0x1107E5C0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B66")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_SerializeValueIf()
  {
  }

  [Token(Token = "0x200020F")]
  public enum ValueType
  {
    [Token(Token = "0x4000906")] Direct,
    [Token(Token = "0x4000907")] RefObject,
    [Token(Token = "0x4000908")] ButtonEventArg,
  }

  [Token(Token = "0x2000210")]
  public enum Operator
  {
    [Token(Token = "0x400090A")] Equal,
    [Token(Token = "0x400090B")] NotEqual,
    [Token(Token = "0x400090C")] Greater,
    [Token(Token = "0x400090D")] EqualGreater,
    [Token(Token = "0x400090E")] Less,
    [Token(Token = "0x400090F")] EqualLess,
  }

  [Token(Token = "0x2000211")]
  [Serializable]
  public class Value
  {
    [Token(Token = "0x4000910")]
    [FieldOffset(Offset = "0x8")]
    public FlowNode_SerializeValueIf.ValueType m_Type;
    [Token(Token = "0x4000911")]
    [FieldOffset(Offset = "0xC")]
    public SerializeValueBehaviour m_Object;
    [Token(Token = "0x4000912")]
    [FieldOffset(Offset = "0x10")]
    public string m_Key;
    [Token(Token = "0x4000913")]
    [FieldOffset(Offset = "0x14")]
    public SerializeValue m_Value;

    [Token(Token = "0x6000B67")]
    [Address(RVA = "0x108B0E0", Offset = "0x1089EE0", VA = "0x1108B0E0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6000B68")]
    [Address(RVA = "0x108B220", Offset = "0x108A020", VA = "0x1108B220")]
    public SerializeValue Get() => (SerializeValue) null;

    [Token(Token = "0x6000B69")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Value()
    {
    }
  }
}
