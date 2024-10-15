// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsActiveGameObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001877")]
  [FlowNode.NodeType("Common/IsActiveGameObject", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Active", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "NotActive", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_IsActiveGameObject : FlowNode
  {
    [Token(Token = "0x40057C0")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.DropTarget(typeof (GameObject), true)]
    [FlowNode.ShowInInfo]
    public GameObject Target;
    [Token(Token = "0x40057C1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool CheckActiveInHierarchy;
    [Token(Token = "0x40057C2")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x40057C3")]
    private const int PIN_OUT_ACTIVE = 101;
    [Token(Token = "0x40057C4")]
    private const int PIN_OUT_NOT_ACTIVE = 102;

    [Token(Token = "0x6006294")]
    [Address(RVA = "0x3070E0", Offset = "0x305EE0", VA = "0x103070E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006295")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsActiveGameObject()
    {
    }
  }
}
