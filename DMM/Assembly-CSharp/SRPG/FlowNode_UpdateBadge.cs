// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UpdateBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D4")]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("UI/UpdateBadge", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_UpdateBadge : FlowNode
  {
    [Token(Token = "0x400A219")]
    [FieldOffset(Offset = "0x18")]
    public GameManager.BadgeTypes type;

    [Token(Token = "0x6009BCB")]
    [Address(RVA = "0x5EF4D0", Offset = "0x5EE2D0", VA = "0x105EF4D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009BCC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_UpdateBadge()
    {
    }
  }
}
