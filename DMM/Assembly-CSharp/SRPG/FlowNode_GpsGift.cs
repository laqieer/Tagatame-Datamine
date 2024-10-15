// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GpsGift
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013FC")]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "GPSギフト受け取れなかった", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "GPSギフト受け取り済み", FlowNode.PinTypes.Output, 21)]
  [FlowNode.NodeType("System/WebApi/GpsGift", 32741)]
  [FlowNode.Pin(20, "GPSギフト受け取った", FlowNode.PinTypes.Output, 20)]
  public class FlowNode_GpsGift : FlowNode_Network
  {
    [Token(Token = "0x40049F7")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_GpsGift.RecieveStatus m_RecieveStatus;

    [Token(Token = "0x600539D")]
    [Address(RVA = "0x1282140", Offset = "0x1280F40", VA = "0x11282140", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600539E")]
    [Address(RVA = "0x12824D0", Offset = "0x12812D0", VA = "0x112824D0")]
    private void _Success()
    {
    }

    [Token(Token = "0x600539F")]
    [Address(RVA = "0x1282450", Offset = "0x1281250", VA = "0x11282450")]
    private void _Failed()
    {
    }

    [Token(Token = "0x60053A0")]
    [Address(RVA = "0x12822E0", Offset = "0x12810E0", VA = "0x112822E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60053A1")]
    [Address(RVA = "0x12824F0", Offset = "0x12812F0", VA = "0x112824F0")]
    public FlowNode_GpsGift()
    {
    }

    [Token(Token = "0x20013FD")]
    private enum RecieveStatus
    {
      [Token(Token = "0x40049F9")] SUCCESS_RECEIVE,
      [Token(Token = "0x40049FA")] FAILED_RECEIVED,
      [Token(Token = "0x40049FB")] FAILED_NOTRECEIVE,
    }
  }
}
