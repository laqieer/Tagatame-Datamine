// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqFggDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014EB")]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Success", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "RequestRelease", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "RequestAdd", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Network/fgg_device", 32741)]
  public class FlowNode_ReqFggDevice : FlowNode_Network
  {
    [Token(Token = "0x4004CA5")]
    [FieldOffset(Offset = "0x20")]
    public string HikkoshiFgGMailAddress;
    [Token(Token = "0x4004CA6")]
    [FieldOffset(Offset = "0x24")]
    public string HikkoshiFgGPassword;

    [Token(Token = "0x17000940")]
    private FlowNode_ReqFggDevice.API m_Api
    {
      [Token(Token = "0x60056FF"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new FlowNode_ReqFggDevice.API();
      }
      [Token(Token = "0x6005700"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
    }

    [Token(Token = "0x6005701")]
    [Address(RVA = "0x12C6F20", Offset = "0x12C5D20", VA = "0x112C6F20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005702")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Success()
    {
    }

    [Token(Token = "0x6005703")]
    [Address(RVA = "0x12C6F00", Offset = "0x12C5D00", VA = "0x112C6F00")]
    private void Failure(int pinID)
    {
    }

    [Token(Token = "0x6005704")]
    [Address(RVA = "0x12C71B0", Offset = "0x12C5FB0", VA = "0x112C71B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005705")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqFggDevice()
    {
    }

    [Token(Token = "0x20014EC")]
    private enum API
    {
      [Token(Token = "0x4004CA9")] Add,
      [Token(Token = "0x4004CAA")] Release,
    }
  }
}
