// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsDuringPeriod_HotDeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200130F")]
  [FlowNode.NodeType("BuyCoin/IsDuringPeriod/HotDeal", 32741)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "OK", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "NG", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_IsDuringPeriod_HotDeal : FlowNode
  {
    [Token(Token = "0x40046C2")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40046C3")]
    private const int PIN_OUTPUT_OK = 10;
    [Token(Token = "0x40046C4")]
    private const int PIN_OUTPUT_NG = 11;

    [Token(Token = "0x6005070")]
    [Address(RVA = "0x124F830", Offset = "0x124E630", VA = "0x1124F830", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005071")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsDuringPeriod_HotDeal()
    {
    }
  }
}
