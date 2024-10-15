// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015AC")]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("Tower/Req/ReqTower", 32741)]
  public class FlowNode_ReqTower : FlowNode_Network
  {
    [Token(Token = "0x6005933")]
    [Address(RVA = "0x12E1B00", Offset = "0x12E0900", VA = "0x112E1B00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005934")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005935")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005936")]
    [Address(RVA = "0x12E1C70", Offset = "0x12E0A70", VA = "0x112E1C70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005937")]
    [Address(RVA = "0x12E1AB0", Offset = "0x12E08B0", VA = "0x112E1AB0")]
    private void Deserialize(JSON_ReqTowerResuponse json)
    {
    }

    [Token(Token = "0x6005938")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTower()
    {
    }
  }
}
