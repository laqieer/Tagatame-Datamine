// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ContinueWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013B1")]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.NodeType("UI/ContinueWindow", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_ContinueWindow : FlowNode
  {
    [Token(Token = "0x600526A")]
    [Address(RVA = "0x1272D00", Offset = "0x1271B00", VA = "0x11272D00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600526B")]
    [Address(RVA = "0xF49830", Offset = "0xF48630", VA = "0x10F49830")]
    private void OnDecide(GameObject dialog)
    {
    }

    [Token(Token = "0x600526C")]
    [Address(RVA = "0x1272E30", Offset = "0x1271C30", VA = "0x11272E30")]
    private void OnCancel(GameObject dialog)
    {
    }

    [Token(Token = "0x600526D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ContinueWindow()
    {
    }
  }
}
