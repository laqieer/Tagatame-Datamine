// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_InitUseDLC
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200140A")]
  [FlowNode.Pin(101, "Start", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1001, "End", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("SRPG/InitUseDLC", 32741)]
  public class FlowNode_InitUseDLC : FlowNode
  {
    [Token(Token = "0x4004A37")]
    private const int PIN_INPUT_START = 101;
    [Token(Token = "0x4004A38")]
    private const int PIN_OUTPUT_END = 1001;

    [Token(Token = "0x60053CC")]
    [Address(RVA = "0x1285500", Offset = "0x1284300", VA = "0x11285500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053CD")]
    [Address(RVA = "0x1285330", Offset = "0x1284130", VA = "0x11285330")]
    private void Init()
    {
    }

    [Token(Token = "0x60053CE")]
    [Address(RVA = "0x1285530", Offset = "0x1284330", VA = "0x11285530")]
    private void Save(bool use_dlc)
    {
    }

    [Token(Token = "0x60053CF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_InitUseDLC()
    {
    }
  }
}
