// Decompiled with JetBrains decompiler
// Type: FlowNode_VariableSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200022F")]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/VariableSwitch", 32741)]
[FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(10, "Default", FlowNode.PinTypes.Output, 10)]
public class FlowNode_VariableSwitch : FlowNode
{
  [Token(Token = "0x400096F")]
  private const int PIN_INPUT = 0;
  [Token(Token = "0x4000970")]
  private const int PIN_OUTPUT_DEFAULT = 10;
  [Token(Token = "0x4000971")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public string Name;
  [Token(Token = "0x4000972")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private FlowNode_VariableSwitch.PinVariables[] mPinList;
  [Token(Token = "0x4000973")]
  [FieldOffset(Offset = "0x20")]
  private FlowNode_VariableSwitch.PinVariables[] mBackupPinList;
  [Token(Token = "0x4000974")]
  [FieldOffset(Offset = "0x24")]
  private FlowNode.Pin[] mPins;

  [Token(Token = "0x6000BB3")]
  [Address(RVA = "0x1081210", Offset = "0x1080010", VA = "0x11081210", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000BB4")]
  [Address(RVA = "0x10813B0", Offset = "0x10801B0", VA = "0x110813B0")]
  protected void Start()
  {
  }

  [Token(Token = "0x6000BB5")]
  [Address(RVA = "0x10812E0", Offset = "0x10800E0", VA = "0x110812E0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BB6")]
  [Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000BB7")]
  [Address(RVA = "0x10813C0", Offset = "0x10801C0", VA = "0x110813C0")]
  private void UpdateCache()
  {
  }

  [Token(Token = "0x6000BB8")]
  [Address(RVA = "0x1081230", Offset = "0x1080030", VA = "0x11081230", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000BB9")]
  [Address(RVA = "0x10814C0", Offset = "0x10802C0", VA = "0x110814C0")]
  public FlowNode_VariableSwitch()
  {
  }

  [Token(Token = "0x2000230")]
  [Serializable]
  private class PinVariables
  {
    [Token(Token = "0x4000975")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    [HideInInspector]
    public FlowNode.Pin pin;
    [Token(Token = "0x4000976")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public string value;

    [Token(Token = "0x6000BBA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PinVariables()
    {
    }
  }
}
