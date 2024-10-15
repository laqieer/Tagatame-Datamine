// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AddUnitExp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001362")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Unit/AddUnitExp", 32741)]
  public class FlowNode_AddUnitExp : FlowNode_Network
  {
    [Token(Token = "0x6005159")]
    [Address(RVA = "0x1265770", Offset = "0x1264570", VA = "0x11265770", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600515A")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600515B")]
    [Address(RVA = "0x1265A60", Offset = "0x1264860", VA = "0x11265A60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600515C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_AddUnitExp()
    {
    }
  }
}
