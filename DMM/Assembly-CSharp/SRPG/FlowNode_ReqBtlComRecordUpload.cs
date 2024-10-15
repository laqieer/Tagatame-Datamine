// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlComRecordUpload
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014AD")]
  [FlowNode.Pin(103, "クエストクリア編成情報アップロード制限中", FlowNode.PinTypes.Output, 13)]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "クエストクリア編成情報機能メンテナンス中", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(101, "Failed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqBtlCom/ReqBtlComRecordUpload", 32741)]
  public class FlowNode_ReqBtlComRecordUpload : FlowNode_Network
  {
    [Token(Token = "0x6005635")]
    [Address(RVA = "0x12BC800", Offset = "0x12BB600", VA = "0x112BC800", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005636")]
    [Address(RVA = "0x1299BD0", Offset = "0x12989D0", VA = "0x11299BD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005637")]
    [Address(RVA = "0x12BC9C0", Offset = "0x12BB7C0", VA = "0x112BC9C0")]
    private void RequestUpload()
    {
    }

    [Token(Token = "0x6005638")]
    [Address(RVA = "0x12BC870", Offset = "0x12BB670", VA = "0x112BC870", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005639")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlComRecordUpload()
    {
    }
  }
}
