// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusIsCPU
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017EF")]
  [FlowNode.NodeType("MultiPlay/Versus/IsCPU", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(201, "Yes", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "No", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(1, "Is CPU", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_VersusIsCPU : FlowNode
  {
    [Token(Token = "0x400562D")]
    private const int PIN_IN_IS_CPU = 1;
    [Token(Token = "0x400562E")]
    private const int PIN_OUT_YES = 201;
    [Token(Token = "0x400562F")]
    private const int PIN_OUT_NO = 202;

    [Token(Token = "0x60060DC")]
    [Address(RVA = "0x135A910", Offset = "0x1359710", VA = "0x1135A910", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060DD")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusIsCPU()
    {
    }
  }
}
