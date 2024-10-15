// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetExistsAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200186D")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Flow/Node/System/SetExistsAccount", 32741)]
  public class FlowNode_SetExistsAccount : FlowNode
  {
    [Token(Token = "0x40057A2")]
    private const int PIN_IN = 1;
    [Token(Token = "0x40057A3")]
    private const int PIN_OUT = 100;

    [Token(Token = "0x6006277")]
    [Address(RVA = "0x315980", Offset = "0x314780", VA = "0x10315980", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006278")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetExistsAccount()
    {
    }
  }
}
