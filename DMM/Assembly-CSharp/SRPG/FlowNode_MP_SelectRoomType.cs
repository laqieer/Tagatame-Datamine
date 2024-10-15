// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_SelectRoomType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017E4")]
  [FlowNode.Pin(2, "Versus", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "Tower", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Coop", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/SelectRoomType", 32741)]
  [FlowNode.Pin(4, "RankMatch", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_MP_SelectRoomType : FlowNode
  {
    [Token(Token = "0x400560B")]
    private const int PIN_IN_SELECT_COOP = 1;
    [Token(Token = "0x400560C")]
    private const int PIN_IN_SELECT_VERSUS = 2;
    [Token(Token = "0x400560D")]
    private const int PIN_IN_SELECT_TOWER = 3;
    [Token(Token = "0x400560E")]
    private const int PIN_IN_SELECT_RANKMATCH = 4;
    [Token(Token = "0x400560F")]
    private const int PIN_OUT_SET = 11;

    [Token(Token = "0x60060C0")]
    [Address(RVA = "0x1359D00", Offset = "0x1358B00", VA = "0x11359D00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060C1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_SelectRoomType()
    {
    }
  }
}
