// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TriggerGlobalEventMultiInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001658")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Common/TriggerGlobalEventMultiInput", 32741)]
  [FlowNode.Pin(1000, "Output", FlowNode.PinTypes.Output, 1000)]
  public class FlowNode_TriggerGlobalEventMultiInput : FlowNode
  {
    [Token(Token = "0x4005121")]
    private const int PIN_INPUT_DEFAULT = 0;
    [Token(Token = "0x4005122")]
    private const int PIN_OUTPUT = 1000;
    [Token(Token = "0x4005123")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_TriggerGlobalEventMultiInput.PinValues[] mPinList;
    [Token(Token = "0x4005124")]
    [FieldOffset(Offset = "0x1C")]
    private FlowNode_TriggerGlobalEventMultiInput.PinValues[] mBackupPinList;
    [Token(Token = "0x4005125")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode.Pin[] mPins;
    [Token(Token = "0x4005126")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool mForceSceneChange;

    [Token(Token = "0x6005BC0")]
    [Address(RVA = "0x1310F20", Offset = "0x130FD20", VA = "0x11310F20", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6005BC1")]
    [Address(RVA = "0x1311010", Offset = "0x130FE10", VA = "0x11311010")]
    protected void Start()
    {
    }

    [Token(Token = "0x6005BC2")]
    [Address(RVA = "0x1310F40", Offset = "0x130FD40", VA = "0x11310F40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BC3")]
    [Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0", Slot = "9")]
    public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

    [Token(Token = "0x6005BC4")]
    [Address(RVA = "0x1311020", Offset = "0x130FE20", VA = "0x11311020")]
    private void UpdateCache()
    {
    }

    [Token(Token = "0x6005BC5")]
    [Address(RVA = "0x1311120", Offset = "0x130FF20", VA = "0x11311120")]
    public FlowNode_TriggerGlobalEventMultiInput()
    {
    }

    [Token(Token = "0x2001659")]
    [Serializable]
    private class PinValues
    {
      [Token(Token = "0x4005127")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      [HideInInspector]
      public FlowNode.Pin pin;
      [Token(Token = "0x4005128")]
      [FieldOffset(Offset = "0xC")]
      [SerializeField]
      public string value;

      [Token(Token = "0x6005BC6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PinValues()
      {
      }
    }
  }
}
