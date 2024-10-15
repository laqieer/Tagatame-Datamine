// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_WhichRoomTypeLINE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017AB")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/Line/WhichRoomTypeLINE", 32741)]
  [FlowNode.Pin(0, "Check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(102, "Tower", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(100, "Coop", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "Versus", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MP_WhichRoomTypeLINE : FlowNode
  {
    [Token(Token = "0x4005545")]
    private const int PIN_IN_CHECK = 0;
    [Token(Token = "0x4005546")]
    private const int PIN_OUT_COOP = 100;
    [Token(Token = "0x4005547")]
    private const int PIN_OUT_VERSUS = 101;
    [Token(Token = "0x4005548")]
    private const int PIN_OUT_TOWER = 102;

    [Token(Token = "0x6005FF9")]
    [Address(RVA = "0x1353700", Offset = "0x1352500", VA = "0x11353700", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FFA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_WhichRoomTypeLINE()
    {
    }
  }
}
