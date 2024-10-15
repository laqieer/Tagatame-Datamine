// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitSelectList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015D5")]
  [FlowNode.NodeType("System/Unit/ReqUnitSelectList", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqUnitSelectList : FlowNode_Network
  {
    [Token(Token = "0x4004F5B")]
    [FieldOffset(Offset = "0x20")]
    public UnitSelectListData mUnitSelectListData;

    [Token(Token = "0x60059C1")]
    [Address(RVA = "0x12E3830", Offset = "0x12E2630", VA = "0x112E3830", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059C2")]
    [Address(RVA = "0x12E2F80", Offset = "0x12E1D80", VA = "0x112E2F80")]
    private Json_UnitSelectResponse DummyResponse() => (Json_UnitSelectResponse) null;

    [Token(Token = "0x60059C3")]
    [Address(RVA = "0x12E2ED0", Offset = "0x12E1CD0", VA = "0x112E2ED0")]
    private void Deserialize(Json_UnitSelectResponse json)
    {
    }

    [Token(Token = "0x60059C4")]
    [Address(RVA = "0x12E39F0", Offset = "0x12E27F0", VA = "0x112E39F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059C5")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60059C6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitSelectList()
    {
    }
  }
}
