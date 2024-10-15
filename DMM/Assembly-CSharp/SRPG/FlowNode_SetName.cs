// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001620")]
  [FlowNode.NodeType("System/Player/SetName", 32741)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Failure", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(3, "Rename", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_SetName : FlowNode_Network
  {
    [Token(Token = "0x6005AFC")]
    [Address(RVA = "0x12FB3F0", Offset = "0x12FA1F0", VA = "0x112FB3F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AFD")]
    [Address(RVA = "0x12FB9B0", Offset = "0x12FA7B0", VA = "0x112FB9B0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005AFE")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005AFF")]
    [Address(RVA = "0x12FB660", Offset = "0x12FA460", VA = "0x112FB660", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005B00")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_SetName()
    {
    }
  }
}
