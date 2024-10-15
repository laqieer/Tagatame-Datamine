// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SkipFriendSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001632")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(100, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("SRPG/SkipFriendSupport", 32741)]
  public class FlowNode_SkipFriendSupport : FlowNode
  {
    [Token(Token = "0x6005B2C")]
    [Address(RVA = "0x12FCF60", Offset = "0x12FBD60", VA = "0x112FCF60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B2D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SkipFriendSupport()
    {
    }
  }
}
