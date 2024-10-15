// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UpdateParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200166A")]
  [FlowNode.NodeType("System/Party/UpdateParty", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1801, "Illegal", FlowNode.PinTypes.Output, 1801)]
  [FlowNode.Pin(1802, "NoMatchVersion", FlowNode.PinTypes.Output, 1802)]
  [FlowNode.Pin(1803, "MultiMaintenance", FlowNode.PinTypes.Output, 1803)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(1800, "NoUnit", FlowNode.PinTypes.Output, 1800)]
  public class FlowNode_UpdateParty : FlowNode_Network
  {
    [Token(Token = "0x400516F")]
    [FieldOffset(Offset = "0x20")]
    public bool SetCurrent;

    [Token(Token = "0x6005C0D")]
    [Address(RVA = "0x1314F50", Offset = "0x1313D50", VA = "0x11314F50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C0E")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C0F")]
    [Address(RVA = "0x1315240", Offset = "0x1314040", VA = "0x11315240", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C10")]
    [Address(RVA = "0x12D6EB0", Offset = "0x12D5CB0", VA = "0x112D6EB0")]
    public FlowNode_UpdateParty()
    {
    }
  }
}
