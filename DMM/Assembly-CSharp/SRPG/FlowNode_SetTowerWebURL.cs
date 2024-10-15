// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetTowerWebURL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001629")]
  [FlowNode.Pin(0, "Set", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Tower/SetTowerWebURL", 32741)]
  [FlowNode.Pin(1, "Succes", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(2, "Error", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_SetTowerWebURL : FlowNode
  {
    [Token(Token = "0x400504D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string URL;
    [Token(Token = "0x400504E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string Value;

    [Token(Token = "0x6005B11")]
    [Address(RVA = "0x12FC3B0", Offset = "0x12FB1B0", VA = "0x112FC3B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B12")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetTowerWebURL()
    {
    }
  }
}
