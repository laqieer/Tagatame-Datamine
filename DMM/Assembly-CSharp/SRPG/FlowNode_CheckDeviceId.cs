// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckDeviceId
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200137D")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1002, "Disable", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(101, "Start", FlowNode.PinTypes.Input, 101)]
  [FlowNode.NodeType("SRPG/CheckDeviceId", 32741)]
  [FlowNode.Pin(1001, "Enable", FlowNode.PinTypes.Output, 1001)]
  public class FlowNode_CheckDeviceId : FlowNode
  {
    [Token(Token = "0x40047EC")]
    private const int PIN_INPUT_START = 101;
    [Token(Token = "0x40047ED")]
    private const int PIN_OUTPUT_ENABLE = 1001;
    [Token(Token = "0x40047EE")]
    private const int PIN_OUTPUT_DISABLE = 1002;

    [Token(Token = "0x60051BD")]
    [Address(RVA = "0x126B6A0", Offset = "0x126A4A0", VA = "0x1126B6A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051BE")]
    [Address(RVA = "0x126B640", Offset = "0x126A440", VA = "0x1126B640")]
    private void Check()
    {
    }

    [Token(Token = "0x60051BF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckDeviceId()
    {
    }
  }
}
