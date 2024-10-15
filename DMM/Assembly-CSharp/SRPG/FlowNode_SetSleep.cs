// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetSleep
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001627")]
  [FlowNode.NodeType("Common/SetSleep", 32741)]
  [FlowNode.Pin(100, "On", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "Off", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_SetSleep : FlowNode
  {
    [Token(Token = "0x17000993")]
    private int On
    {
      [Token(Token = "0x6005B0B"), Address(RVA = "0x12FC290", Offset = "0x12FB090", VA = "0x112FC290")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000994")]
    private int Off
    {
      [Token(Token = "0x6005B0C"), Address(RVA = "0x12FC280", Offset = "0x12FB080", VA = "0x112FC280")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B0D")]
    [Address(RVA = "0x12FC200", Offset = "0x12FB000", VA = "0x112FC200", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B0E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetSleep()
    {
    }
  }
}
