// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBoxReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200130D")]
  [FlowNode.NodeType("Gacha/Box/Reset", 32741)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(201, "リセット条件未達成", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "開催期間外", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(203, "キーイベントが閉じられている", FlowNode.PinTypes.Output, 203)]
  [AddComponentMenu("")]
  [FlowNode.Pin(200, "BOXが存在しない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqBoxReset : FlowNode_Network
  {
    [Token(Token = "0x40046B6")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40046B7")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x40046B8")]
    private const int PIN_OT_NOT_EXIST_BOX = 200;
    [Token(Token = "0x40046B9")]
    private const int PIN_OT_NOT_RESET_BOX = 201;
    [Token(Token = "0x40046BA")]
    private const int PIN_OT_OUT_OF_PERIOD = 202;
    [Token(Token = "0x40046BB")]
    private const int PIN_OT_KEY_CLOSE = 203;

    [Token(Token = "0x6005067")]
    [Address(RVA = "0x12578D0", Offset = "0x12566D0", VA = "0x112578D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005068")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005069")]
    [Address(RVA = "0x12579E0", Offset = "0x12567E0", VA = "0x112579E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600506A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBoxReset()
    {
    }
  }
}
