// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SelectGachaInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015FD")]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "SelectDetailOnly", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "SelectDetailAndRate", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("SRPG/Gacha/SelectGachaInfo", 32741)]
  public class FlowNode_SelectGachaInfo : FlowNode
  {
    [Token(Token = "0x4004FC3")]
    private const int PIN_IN_INPUT = 0;
    [Token(Token = "0x4004FC4")]
    private const int PIN_OT_SELECT_DETAIL_ONLY = 10;
    [Token(Token = "0x4004FC5")]
    private const int PIN_OT_SELECT_DETAIL_RATE = 11;

    [Token(Token = "0x6005A7E")]
    [Address(RVA = "0x12F2FC0", Offset = "0x12F1DC0", VA = "0x112F2FC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A7F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SelectGachaInfo()
    {
    }
  }
}
