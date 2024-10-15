// Decompiled with JetBrains decompiler
// Type: FlowNode_VariableSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200022D")]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/VariableSet", 32741)]
[FlowNode.Pin(0, "Default", FlowNode.PinTypes.Output, 0)]
public class FlowNode_VariableSet : FlowNode
{
  [Token(Token = "0x4000967")]
  private const int PIN_OUTPUT = 0;
  [Token(Token = "0x4000968")]
  private const int PIN_INPUT_START_INDEX = 10;
  [Token(Token = "0x4000969")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public string Name;
  [Token(Token = "0x400096A")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private FlowNode_VariableSet.PinVariables[] mPinList;
  [Token(Token = "0x400096B")]
  [FieldOffset(Offset = "0x20")]
  private FlowNode_VariableSet.PinVariables[] mBackupPinList;
  [Token(Token = "0x400096C")]
  [FieldOffset(Offset = "0x24")]
  private FlowNode.Pin[] mPins;

  [Token(Token = "0x6000BAB")]
  [Address(RVA = "0x1080F10", Offset = "0x107FD10", VA = "0x11080F10", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000BAC")]
  [Address(RVA = "0x1081070", Offset = "0x107FE70", VA = "0x11081070")]
  protected void Start()
  {
  }

  [Token(Token = "0x6000BAD")]
  [Address(RVA = "0x1080FE0", Offset = "0x107FDE0", VA = "0x11080FE0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BAE")]
  [Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000BAF")]
  [Address(RVA = "0x1081080", Offset = "0x107FE80", VA = "0x11081080")]
  private void UpdateCache()
  {
  }

  [Token(Token = "0x6000BB0")]
  [Address(RVA = "0x1080F30", Offset = "0x107FD30", VA = "0x11080F30", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000BB1")]
  [Address(RVA = "0x1081180", Offset = "0x107FF80", VA = "0x11081180")]
  public FlowNode_VariableSet()
  {
  }

  [Token(Token = "0x200022E")]
  [Serializable]
  private class PinVariables
  {
    [Token(Token = "0x400096D")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    [HideInInspector]
    public FlowNode.Pin pin;
    [Token(Token = "0x400096E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public string value;

    [Token(Token = "0x6000BB2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PinVariables()
    {
    }
  }
}
