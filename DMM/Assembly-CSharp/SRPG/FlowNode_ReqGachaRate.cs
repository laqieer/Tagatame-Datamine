// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaRate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014FF")]
  [AddComponentMenu("")]
  [FlowNode.Pin(120, "Failed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(110, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(100, "指定の召喚提供割合取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Gacha/RequestGachaRate", 32741)]
  public class FlowNode_ReqGachaRate : FlowNode_Network
  {
    [Token(Token = "0x4004CE4")]
    public const int PIN_IN_REQUEST = 100;
    [Token(Token = "0x4004CE5")]
    public const int PIN_OT_REQUEST_SUCCESS = 110;
    [Token(Token = "0x4004CE6")]
    public const int PIN_OT_REQUEST_FAILED = 120;

    [Token(Token = "0x6005748")]
    [Address(RVA = "0x12CE450", Offset = "0x12CD250", VA = "0x112CE450", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005749")]
    [Address(RVA = "0x12CE720", Offset = "0x12CD520", VA = "0x112CE720")]
    private void Success()
    {
    }

    [Token(Token = "0x600574A")]
    [Address(RVA = "0x12CE430", Offset = "0x12CD230", VA = "0x112CE430")]
    private void Failure()
    {
    }

    [Token(Token = "0x600574B")]
    [Address(RVA = "0x12CE590", Offset = "0x12CD390", VA = "0x112CE590", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600574C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGachaRate()
    {
    }
  }
}
