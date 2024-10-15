// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBoxDrawStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200130A")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Gacha/Box/DrawStatus", 32741)]
  [FlowNode.Pin(201, "開催期間外", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "BOXが存在しない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(202, "キーイベントが閉じられている", FlowNode.PinTypes.Output, 202)]
  public class FlowNode_ReqBoxDrawStatus : FlowNode_Network
  {
    [Token(Token = "0x40046A4")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40046A5")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x40046A6")]
    private const int PIN_OT_NOT_EXIST_BOX = 200;
    [Token(Token = "0x40046A7")]
    private const int PIN_OT_OUT_OF_PERIOD = 201;
    [Token(Token = "0x40046A8")]
    private const int PIN_OT_KEY_CLOSE = 202;

    [Token(Token = "0x600505B")]
    [Address(RVA = "0x12565E0", Offset = "0x12553E0", VA = "0x112565E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600505C")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x600505D")]
    [Address(RVA = "0x12566F0", Offset = "0x12554F0", VA = "0x112566F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600505E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBoxDrawStatus()
    {
    }
  }
}
