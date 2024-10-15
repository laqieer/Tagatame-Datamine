// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetBoolPlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200160F")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/PlayerPrefs/SetBoolPlayerPrefs", 32741)]
  [FlowNode.Pin(1, "SetTrue", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "SetFalse", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "Finish", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "Result", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_SetBoolPlayerPrefs : FlowNode
  {
    [Token(Token = "0x4004FFE")]
    [FieldOffset(Offset = "0x18")]
    public string Name;
    [Token(Token = "0x4004FFF")]
    private const int SET_FALSE = 0;
    [Token(Token = "0x4005000")]
    private const int SET_TRUE = 1;

    [Token(Token = "0x6005ACE")]
    [Address(RVA = "0x12F8CC0", Offset = "0x12F7AC0", VA = "0x112F8CC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005ACF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetBoolPlayerPrefs()
    {
    }
  }
}
