// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RestoreMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015F2")]
  [FlowNode.NodeType("Scene/SetRestoreMenu", 32741)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_RestoreMenu : FlowNode
  {
    [Token(Token = "0x4004FA0")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    public RestorePoints RestorePoint;

    [Token(Token = "0x6005A28")]
    [Address(RVA = "0x12EB930", Offset = "0x12EA730", VA = "0x112EB930", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A29")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RestoreMenu()
    {
    }
  }
}
