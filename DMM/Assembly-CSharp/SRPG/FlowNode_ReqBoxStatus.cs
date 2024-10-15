// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBoxStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200130E")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Gacha/Box/Status", 32741)]
  [FlowNode.Pin(200, "BOXが存在しない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "開催期間外", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "キーイベントが閉じられている", FlowNode.PinTypes.Output, 202)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqBoxStatus : FlowNode_Network
  {
    [Token(Token = "0x40046BC")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40046BD")]
    private const int PIN_OT_SUCCESS = 100;
    [Token(Token = "0x40046BE")]
    private const int PIN_OT_NOT_EXIST_BOX = 200;
    [Token(Token = "0x40046BF")]
    private const int PIN_OT_OUT_OF_PERIOD = 201;
    [Token(Token = "0x40046C0")]
    private const int PIN_OT_KEY_CLOSE = 202;
    [Token(Token = "0x40046C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsAdvanceEvent;

    [Token(Token = "0x600506B")]
    [Address(RVA = "0x1257E30", Offset = "0x1256C30", VA = "0x11257E30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600506C")]
    [Address(RVA = "0x1256AB0", Offset = "0x12558B0", VA = "0x11256AB0")]
    private void Success()
    {
    }

    [Token(Token = "0x600506D")]
    [Address(RVA = "0x1257E00", Offset = "0x1256C00", VA = "0x11257E00")]
    private void NotExistBox()
    {
    }

    [Token(Token = "0x600506E")]
    [Address(RVA = "0x12580A0", Offset = "0x1256EA0", VA = "0x112580A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600506F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBoxStatus()
    {
    }
  }
}
