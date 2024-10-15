// Decompiled with JetBrains decompiler
// Type: FlowNode_SerializeValueSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000215")]
[AddComponentMenu("")]
[FlowNode.NodeType("SerializeValue/Switch", 32741)]
[FlowNode.Pin(100, "スイッチ分岐", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(9999, "DEFAULT", FlowNode.PinTypes.Output, 9999)]
public class FlowNode_SerializeValueSwitch : FlowNode
{
  [Token(Token = "0x4000920")]
  public const int INPUT_OPERATOR = 100;
  [Token(Token = "0x4000921")]
  public const int OUTPUT_TOP = 200;
  [Token(Token = "0x4000922")]
  public const int OUTPUT_DEFAULT = 9999;
  [Token(Token = "0x4000923")]
  [FieldOffset(Offset = "0x18")]
  public FlowNode_SerializeValueSwitch.Value m_Value;
  [Token(Token = "0x4000924")]
  [FieldOffset(Offset = "0x1C")]
  public List<FlowNode_SerializeValueSwitch.Case> m_Case;
  [Token(Token = "0x4000925")]
  [FieldOffset(Offset = "0x20")]
  public SerializeValue.PropertyType m_PropertyType;

  [Token(Token = "0x6000B6E")]
  [Address(RVA = "0x107EBC0", Offset = "0x107D9C0", VA = "0x1107EBC0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B6F")]
  [Address(RVA = "0x107EAA0", Offset = "0x107D8A0", VA = "0x1107EAA0", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000B70")]
  [Address(RVA = "0x107EDA0", Offset = "0x107DBA0", VA = "0x1107EDA0")]
  public FlowNode_SerializeValueSwitch()
  {
  }

  [Token(Token = "0x2000216")]
  public enum ValueType
  {
    [Token(Token = "0x4000927")] Direct,
    [Token(Token = "0x4000928")] RefObject,
    [Token(Token = "0x4000929")] ButtonEventArg,
  }

  [Token(Token = "0x2000217")]
  [Serializable]
  public class Value
  {
    [Token(Token = "0x400092A")]
    [FieldOffset(Offset = "0x8")]
    public FlowNode_SerializeValueSwitch.ValueType m_Type;
    [Token(Token = "0x400092B")]
    [FieldOffset(Offset = "0xC")]
    public SerializeValueBehaviour m_Object;
    [Token(Token = "0x400092C")]
    [FieldOffset(Offset = "0x10")]
    public string m_Key;
    [Token(Token = "0x400092D")]
    [FieldOffset(Offset = "0x14")]
    public SerializeValue m_Value;

    [Token(Token = "0x6000B71")]
    [Address(RVA = "0x108B410", Offset = "0x108A210", VA = "0x1108B410")]
    public Value()
    {
    }

    [Token(Token = "0x6000B72")]
    [Address(RVA = "0x108B0E0", Offset = "0x1089EE0", VA = "0x1108B0E0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6000B73")]
    [Address(RVA = "0x108B130", Offset = "0x1089F30", VA = "0x1108B130")]
    public SerializeValue Get() => (SerializeValue) null;
  }

  [Token(Token = "0x2000218")]
  [Serializable]
  public class Case
  {
    [Token(Token = "0x400092E")]
    [FieldOffset(Offset = "0x8")]
    public int m_Pin;
    [Token(Token = "0x400092F")]
    [FieldOffset(Offset = "0xC")]
    public FlowNode_SerializeValueSwitch.ValueType m_Type;
    [Token(Token = "0x4000930")]
    [FieldOffset(Offset = "0x10")]
    public SerializeValueBehaviour m_Object;
    [Token(Token = "0x4000931")]
    [FieldOffset(Offset = "0x14")]
    public string m_Key;
    [Token(Token = "0x4000932")]
    [FieldOffset(Offset = "0x18")]
    public SerializeValue m_Value;

    [Token(Token = "0x1700015C")]
    public bool isValid
    {
      [Token(Token = "0x6000B74"), Address(RVA = "0x1076860", Offset = "0x1075660", VA = "0x11076860")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000B75")]
    [Address(RVA = "0x10767F0", Offset = "0x10755F0", VA = "0x110767F0")]
    public Case()
    {
    }

    [Token(Token = "0x6000B76")]
    [Address(RVA = "0x1076600", Offset = "0x1075400", VA = "0x11076600")]
    public void Clear()
    {
    }

    [Token(Token = "0x6000B77")]
    [Address(RVA = "0x1076660", Offset = "0x1075460", VA = "0x11076660")]
    public SerializeValue Get() => (SerializeValue) null;

    [Token(Token = "0x6000B78")]
    [Address(RVA = "0x1076650", Offset = "0x1075450", VA = "0x11076650")]
    public int GetPinId() => new int();

    [Token(Token = "0x6000B79")]
    [Address(RVA = "0x1076750", Offset = "0x1075550", VA = "0x11076750")]
    public FlowNode.Pin ToPin(SerializeValue.PropertyType propertyType) => (FlowNode.Pin) null;
  }
}
