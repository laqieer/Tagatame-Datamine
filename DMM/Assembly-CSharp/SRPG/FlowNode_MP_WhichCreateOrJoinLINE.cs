// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_WhichCreateOrJoinLINE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017AA")]
  [AddComponentMenu("")]
  [FlowNode.Pin(12, "Is Join", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "Is Create", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "Which Create or Join", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/Line/WhichCreateOrJoinLINE", 32741)]
  public class FlowNode_MP_WhichCreateOrJoinLINE : FlowNode
  {
    [Token(Token = "0x4005542")]
    private const int PIN_IN_WHICH_CREATE_OR_JOIN = 1;
    [Token(Token = "0x4005543")]
    private const int PIN_OUT_IS_CREATE = 11;
    [Token(Token = "0x4005544")]
    private const int PIN_OUT_IS_JOIN = 12;

    [Token(Token = "0x6005FF7")]
    [Address(RVA = "0x1353640", Offset = "0x1352440", VA = "0x11353640", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FF8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_WhichCreateOrJoinLINE()
    {
    }
  }
}
