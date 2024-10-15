// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ShopTelop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200162E")]
  [FlowNode.NodeType("SRPG/ShopTelop", 32741)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(10, "SetText", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ShopTelop : FlowNode
  {
    [Token(Token = "0x400505E")]
    [FieldOffset(Offset = "0x18")]
    public string Text;
    [Token(Token = "0x400505F")]
    [FieldOffset(Offset = "0x1C")]
    public string ShopTelopGameObjectID;

    [Token(Token = "0x6005B1F")]
    [Address(RVA = "0x12FCAB0", Offset = "0x12FB8B0", VA = "0x112FCAB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B20")]
    [Address(RVA = "0x12FCBD0", Offset = "0x12FB9D0", VA = "0x112FCBD0")]
    public FlowNode_ShopTelop()
    {
    }
  }
}
