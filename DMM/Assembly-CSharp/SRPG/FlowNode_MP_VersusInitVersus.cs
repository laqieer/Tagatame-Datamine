// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusInitVersus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017ED")]
  [FlowNode.NodeType("MultiPlay/Versus/Init", 32741)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MP_VersusInitVersus : FlowNode
  {
    [Token(Token = "0x4005628")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4005629")]
    private const int PIN_OUT_SUCCESS = 101;

    [Token(Token = "0x60060D8")]
    [Address(RVA = "0x135A780", Offset = "0x1359580", VA = "0x1135A780", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060D9")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusInitVersus()
    {
    }
  }
}
