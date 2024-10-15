// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SaveUseDLC
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015FC")]
  [FlowNode.NodeType("SRPG/SaveUseDLC", 32741)]
  [FlowNode.Pin(101, "Save", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1001, "End", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("")]
  public class FlowNode_SaveUseDLC : FlowNode
  {
    [Token(Token = "0x4004FBF")]
    private const int PIN_INPUT_SAVE = 101;
    [Token(Token = "0x4004FC0")]
    private const int PIN_OUTPUT_END = 1001;
    [Token(Token = "0x4004FC1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int NewValue;
    [Token(Token = "0x4004FC2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool IsWritePrefs;

    [Token(Token = "0x6005A7B")]
    [Address(RVA = "0x12F2CD0", Offset = "0x12F1AD0", VA = "0x112F2CD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A7C")]
    [Address(RVA = "0x12F2E00", Offset = "0x12F1C00", VA = "0x112F2E00")]
    private void Save()
    {
    }

    [Token(Token = "0x6005A7D")]
    [Address(RVA = "0x12F2F10", Offset = "0x12F1D10", VA = "0x112F2F10")]
    public FlowNode_SaveUseDLC()
    {
    }
  }
}
