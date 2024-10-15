// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_WhatRoomType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017E7")]
  [FlowNode.NodeType("MultiPlay/WhatRoomType", 32741)]
  [FlowNode.Pin(1, "Test", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Coop", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Versus", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "Tower", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(14, "RankMatch", FlowNode.PinTypes.Output, 14)]
  [AddComponentMenu("")]
  public class FlowNode_MP_WhatRoomType : FlowNode
  {
    [Token(Token = "0x4005616")]
    private const int PIN_IN_TEST = 1;
    [Token(Token = "0x4005617")]
    private const int PIN_OUT_IS_COOP = 11;
    [Token(Token = "0x4005618")]
    private const int PIN_OUT_IS_VERSUS = 12;
    [Token(Token = "0x4005619")]
    private const int PIN_OUT_IS_TOWER = 13;
    [Token(Token = "0x400561A")]
    private const int PIN_OUT_IS_RANKMATCH = 14;

    [Token(Token = "0x60060C6")]
    [Address(RVA = "0x135B100", Offset = "0x1359F00", VA = "0x1135B100", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060C7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_WhatRoomType()
    {
    }
  }
}
