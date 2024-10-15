// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ClearMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001399")]
  [FlowNode.Pin(101, "Start", FlowNode.PinTypes.Input, 101)]
  [FlowNode.NodeType("Master/ClearMasterParam", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "End", FlowNode.PinTypes.Output, 1001)]
  public class FlowNode_ClearMasterParam : FlowNode
  {
    [Token(Token = "0x4004865")]
    private const int PIN_INPUT_START = 101;
    [Token(Token = "0x4004866")]
    private const int PIN_OUTPUT_END = 1001;

    [Token(Token = "0x600521E")]
    [Address(RVA = "0x126E870", Offset = "0x126D670", VA = "0x1126E870", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600521F")]
    [Address(RVA = "0x126E7D0", Offset = "0x126D5D0", VA = "0x1126E7D0")]
    private void Clear()
    {
    }

    [Token(Token = "0x6005220")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ClearMasterParam()
    {
    }
  }
}
