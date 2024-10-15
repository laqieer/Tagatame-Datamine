// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqItemSelectList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001533")]
  [FlowNode.NodeType("Mail/ReqItemSelectList", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqItemSelectList : FlowNode_Network
  {
    [Token(Token = "0x4004D8C")]
    [FieldOffset(Offset = "0x20")]
    public GetItemWindow mGetItemWindow;

    [Token(Token = "0x60057C3")]
    [Address(RVA = "0x12D4940", Offset = "0x12D3740", VA = "0x112D4940", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057C4")]
    [Address(RVA = "0x12D46C0", Offset = "0x12D34C0", VA = "0x112D46C0")]
    private Json_ItemSelectResponse DummyResponse() => (Json_ItemSelectResponse) null;

    [Token(Token = "0x60057C5")]
    [Address(RVA = "0x12D4630", Offset = "0x12D3430", VA = "0x112D4630")]
    private void Deserialize(Json_ItemSelectResponse json)
    {
    }

    [Token(Token = "0x60057C6")]
    [Address(RVA = "0x12D4B00", Offset = "0x12D3900", VA = "0x112D4B00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057C7")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60057C8")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqItemSelectList()
    {
    }
  }
}
