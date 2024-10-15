// Decompiled with JetBrains decompiler
// Type: FlowNode_SerializeValueGroupSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200020B")]
[FlowNode.NodeType("SerializeValue/GroupSet", 32741)]
[FlowNode.Pin(100, "設定", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(110, "次へ", FlowNode.PinTypes.Output, 110)]
[AddComponentMenu("")]
public class FlowNode_SerializeValueGroupSet : FlowNode
{
  [Token(Token = "0x40008F3")]
  public const int INPUT_SET = 100;
  [Token(Token = "0x40008F4")]
  public const int OUTPUT_SETED = 110;
  [Token(Token = "0x40008F5")]
  [FieldOffset(Offset = "0x18")]
  public FlowNode_SerializeValueGroupSet.ValueType m_Type;
  [Token(Token = "0x40008F6")]
  [FieldOffset(Offset = "0x1C")]
  public SerializeValueBehaviour m_Object;
  [Token(Token = "0x40008F7")]
  [FieldOffset(Offset = "0x20")]
  public List<FlowNode_SerializeValueGroupSet.Value> m_Values;

  [Token(Token = "0x6000B61")]
  [Address(RVA = "0x107E240", Offset = "0x107D040", VA = "0x1107E240", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000B62")]
  [Address(RVA = "0x107E250", Offset = "0x107D050", VA = "0x1107E250", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B63")]
  [Address(RVA = "0x107E550", Offset = "0x107D350", VA = "0x1107E550")]
  public FlowNode_SerializeValueGroupSet()
  {
  }

  [Token(Token = "0x200020C")]
  public enum ValueType
  {
    [Token(Token = "0x40008F9")] RefObject,
    [Token(Token = "0x40008FA")] ButtonEventArg,
  }

  [Token(Token = "0x200020D")]
  [Serializable]
  public class Value
  {
    [Token(Token = "0x40008FB")]
    [FieldOffset(Offset = "0x8")]
    public int m_Group;
    [Token(Token = "0x40008FC")]
    [FieldOffset(Offset = "0xC")]
    public SerializeValue.PropertyType m_PropertyType;
    [Token(Token = "0x40008FD")]
    [FieldOffset(Offset = "0x10")]
    public SerializeValue m_Value;

    [Token(Token = "0x6000B64")]
    [Address(RVA = "0x108B310", Offset = "0x108A110", VA = "0x1108B310")]
    public Value()
    {
    }
  }
}
