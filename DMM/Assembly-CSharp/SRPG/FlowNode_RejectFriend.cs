// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RejectFriend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200147B")]
  [FlowNode.Pin(10, "ひとり拒否", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "すべて拒否", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(20, "ひとり拒否成功", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(21, "すべて拒否成功", FlowNode.PinTypes.Output, 21)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Friend/RejectFriend", 32741)]
  public class FlowNode_RejectFriend : FlowNode_Network
  {
    [Token(Token = "0x4004BBC")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsRemoveAll;
    [Token(Token = "0x4004BBD")]
    [FieldOffset(Offset = "0x24")]
    private string remove_fuid;

    [Token(Token = "0x6005592")]
    [Address(RVA = "0x129F1D0", Offset = "0x129DFD0", VA = "0x1129F1D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005593")]
    [Address(RVA = "0x129F5E0", Offset = "0x129E3E0", VA = "0x1129F5E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005594")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RejectFriend()
    {
    }
  }
}
