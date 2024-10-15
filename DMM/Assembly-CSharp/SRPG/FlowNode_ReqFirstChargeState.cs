// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqFirstChargeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014F0")]
  [FlowNode.NodeType("Network/ReqFirstChargeState", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_ReqFirstChargeState : FlowNode_Network
  {
    [Token(Token = "0x4004CB2")]
    private const int INPUT_REQUEST = 0;
    [Token(Token = "0x4004CB3")]
    private const int OUTPUT_SUCCESS = 10;
    [Token(Token = "0x4004CB4")]
    private const int OUTPUT_FAILED = 11;

    [Token(Token = "0x600570D")]
    [Address(RVA = "0x12C7730", Offset = "0x12C6530", VA = "0x112C7730", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600570E")]
    [Address(RVA = "0x12C79E0", Offset = "0x12C67E0", VA = "0x112C79E0")]
    private void _Success()
    {
    }

    [Token(Token = "0x600570F")]
    [Address(RVA = "0x12C7980", Offset = "0x12C6780", VA = "0x112C7980")]
    private void _Failed()
    {
    }

    [Token(Token = "0x6005710")]
    [Address(RVA = "0x12C77E0", Offset = "0x12C65E0", VA = "0x112C77E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005711")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqFirstChargeState()
    {
    }

    [Token(Token = "0x20014F1")]
    public class JSON_FirstChargeState
    {
      [Token(Token = "0x4004CB5")]
      [FieldOffset(Offset = "0x8")]
      public int charge_bonus;

      [Token(Token = "0x6005712")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_FirstChargeState()
      {
      }
    }
  }
}
