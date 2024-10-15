// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqShopLineup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200158C")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Shop/ReqShopLineup", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqShopLineup : FlowNode_Network
  {
    [Token(Token = "0x4004E6B")]
    [FieldOffset(Offset = "0x20")]
    private EShopType mShopType;
    [Token(Token = "0x4004E6C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject Target;

    [Token(Token = "0x60058D0")]
    [Address(RVA = "0x12DAF20", Offset = "0x12D9D20", VA = "0x112DAF20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058D1")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60058D2")]
    [Address(RVA = "0x12DB100", Offset = "0x12D9F00", VA = "0x112DB100", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058D3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqShopLineup()
    {
    }
  }
}
