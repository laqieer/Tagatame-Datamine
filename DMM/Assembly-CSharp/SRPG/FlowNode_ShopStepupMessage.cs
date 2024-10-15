// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ShopStepupMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200162D")]
  [FlowNode.NodeType("Shop/ShopStepupMessage", 32741)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Finished", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_ShopStepupMessage : FlowNode
  {
    [Token(Token = "0x6005B1C")]
    [Address(RVA = "0x12FC730", Offset = "0x12FB530", VA = "0x112FC730", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B1D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ShopStepupMessage()
    {
    }
  }
}
