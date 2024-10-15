// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckPremiumUser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001384")]
  [AddComponentMenu("")]
  [FlowNode.Pin(20, "Not Premium", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(10, "Premium", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/Battle/Speed/BattleSpeedEditorOption", 32741)]
  public class FlowNode_CheckPremiumUser : FlowNode
  {
    [Token(Token = "0x60051DB")]
    [Address(RVA = "0x126C1D0", Offset = "0x126AFD0", VA = "0x1126C1D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051DC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckPremiumUser()
    {
    }
  }
}
