// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBoxLineup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200130C")]
  [AddComponentMenu("")]
  [FlowNode.Pin(202, "キーイベントが閉じられている", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "開催期間外", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Gacha/Box/Lineup", 32741)]
  [FlowNode.Pin(200, "BOXが存在しない", FlowNode.PinTypes.Output, 200)]
  public class FlowNode_ReqBoxLineup : FlowNode_Network
  {
    [Token(Token = "0x40046B1")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40046B2")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x40046B3")]
    private const int PIN_OT_NOT_EXIST_BOX = 200;
    [Token(Token = "0x40046B4")]
    private const int PIN_OT_OUT_OF_PERIOD = 201;
    [Token(Token = "0x40046B5")]
    private const int PIN_OT_KEY_CLOSE = 202;

    [Token(Token = "0x6005063")]
    [Address(RVA = "0x1257480", Offset = "0x1256280", VA = "0x11257480", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005064")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005065")]
    [Address(RVA = "0x1257590", Offset = "0x1256390", VA = "0x11257590", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005066")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBoxLineup()
    {
    }
  }
}
