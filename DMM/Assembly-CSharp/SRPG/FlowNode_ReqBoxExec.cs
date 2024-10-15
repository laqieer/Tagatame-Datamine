// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBoxExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200130B")]
  [FlowNode.NodeType("Gacha/Box/Exec", 32741)]
  [FlowNode.Pin(0, "IN 単発交換リクエスト", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "IN N回交換リクエスト", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "OT Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "OT BOXが存在しない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "OT コスト不足", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "OT BOXが空", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(203, "OT 開催期間外", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(204, "OT キーイベントが閉じられている", FlowNode.PinTypes.Output, 204)]
  [AddComponentMenu("")]
  public class FlowNode_ReqBoxExec : FlowNode_Network
  {
    [Token(Token = "0x40046A9")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40046AA")]
    private const int PIN_IN_REQUEST_MULTI = 1;
    [Token(Token = "0x40046AB")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x40046AC")]
    private const int PIN_OT_NOT_EXIST_BOX = 200;
    [Token(Token = "0x40046AD")]
    private const int PIN_OT_COST_SHORT = 201;
    [Token(Token = "0x40046AE")]
    private const int PIN_OT_REMAIN_SHORT = 202;
    [Token(Token = "0x40046AF")]
    private const int PIN_OT_OUT_OF_PERIOD = 203;
    [Token(Token = "0x40046B0")]
    private const int PIN_OT_KEY_CLOSE = 204;

    [Token(Token = "0x600505F")]
    [Address(RVA = "0x1256AD0", Offset = "0x12558D0", VA = "0x11256AD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005060")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005061")]
    [Address(RVA = "0x1256CC0", Offset = "0x1255AC0", VA = "0x11256CC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005062")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBoxExec()
    {
    }
  }
}
