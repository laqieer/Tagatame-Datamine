// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SavedTrophyProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015FA")]
  [FlowNode.NodeType("Trophy/SavedTrophyProgress", 32741)]
  [FlowNode.Pin(0, "Success", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(1, "LoadTrophyProgress", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "UpdateByGameManager", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  public class FlowNode_SavedTrophyProgress : FlowNode
  {
    [Token(Token = "0x6005A73")]
    [Address(RVA = "0x12F2F30", Offset = "0x12F1D30", VA = "0x112F2F30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A74")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SavedTrophyProgress()
    {
    }
  }
}
