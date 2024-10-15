// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_SetRoomVersusDraftMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001799")]
  [FlowNode.NodeType("MultiPlay/Draft/SetRoomVersusDraftMode", 32741)]
  [FlowNode.Pin(1, "Set Normal", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Finish", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "Set Draft", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_MP_SetRoomVersusDraftMode : FlowNode
  {
    [Token(Token = "0x400550A")]
    private const int PIN_IN_SET_NORMAL = 1;
    [Token(Token = "0x400550B")]
    private const int PIN_IN_SET_DRAFT = 2;
    [Token(Token = "0x400550C")]
    private const int PIN_OUT_FINISH = 101;

    [Token(Token = "0x6005FC3")]
    [Address(RVA = "0x1352CC0", Offset = "0x1351AC0", VA = "0x11352CC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FC4")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_SetRoomVersusDraftMode()
    {
    }
  }
}
