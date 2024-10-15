// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusBindPhotonPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017E8")]
  [FlowNode.NodeType("MultiPlay/Versus/BindPhotonPlayer", 32741)]
  [FlowNode.Pin(1, "Bind", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_MP_VersusBindPhotonPlayer : FlowNode
  {
    [Token(Token = "0x400561B")]
    private const int PIN_IN_BIND = 1;
    [Token(Token = "0x400561C")]
    private const int PIN_OUT = 11;
    [Token(Token = "0x400561D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Target;
    [Token(Token = "0x400561E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool IsSelf;

    [Token(Token = "0x60060C8")]
    [Address(RVA = "0x135A0F0", Offset = "0x1358EF0", VA = "0x1135A0F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060C9")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusBindPhotonPlayer()
    {
    }
  }
}
