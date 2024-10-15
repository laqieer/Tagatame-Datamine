// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGachaList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014F9")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "ToCheckPending(引き直し召喚チェック)", FlowNode.PinTypes.Output, 3)]
  [FlowNode.NodeType("Network/gacha", 32741)]
  [FlowNode.Pin(2, "Failure", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_ReqGachaList : FlowNode_Network
  {
    [Token(Token = "0x4004CC8")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004CC9")]
    private const int PIN_OT_REQUEST_SUCCESS = 1;
    [Token(Token = "0x4004CCA")]
    private const int PIN_OT_REQUEST_FAILURE = 2;
    [Token(Token = "0x4004CCB")]
    private const int PIN_OT_TO_GACHA_PENDING = 3;
    [Token(Token = "0x4004CCC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsSetGachaOption;

    [Token(Token = "0x6005730")]
    [Address(RVA = "0x12CD6D0", Offset = "0x12CC4D0", VA = "0x112CD6D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005731")]
    [Address(RVA = "0x12CD670", Offset = "0x12CC470", VA = "0x112CD670")]
    private ReqGacha.RequestParam CreateRequestParam(bool is_option = false)
    {
      return (ReqGacha.RequestParam) null;
    }

    [Token(Token = "0x6005732")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005733")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005734")]
    [Address(RVA = "0x1273D70", Offset = "0x1272B70", VA = "0x11273D70")]
    private void ToCheckPending()
    {
    }

    [Token(Token = "0x6005735")]
    [Address(RVA = "0x12CD810", Offset = "0x12CC610", VA = "0x112CD810", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005736")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGachaList()
    {
    }
  }
}
