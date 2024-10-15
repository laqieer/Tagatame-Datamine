// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Fade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013E8")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Fade In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "Finished", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("UI/Fade", 32741)]
  [FlowNode.Pin(100, "Fade Out", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_Fade : FlowNode
  {
    [Token(Token = "0x600535F")]
    [Address(RVA = "0x1280000", Offset = "0x127EE00", VA = "0x11280000", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005360")]
    [Address(RVA = "0x127FF80", Offset = "0x127ED80", VA = "0x1127FF80")]
    private void Update()
    {
    }

    [Token(Token = "0x6005361")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Fade()
    {
    }
  }
}
