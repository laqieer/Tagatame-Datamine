// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RaidFriendRescueCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200146D")]
  [FlowNode.Pin(11, "Friend ERROR", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("Raid/FriendCheck", 32741)]
  [FlowNode.Pin(0, "check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Friend OK", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_RaidFriendRescueCheck : FlowNode
  {
    [Token(Token = "0x4004B91")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int m_friendNum;

    [Token(Token = "0x6005566")]
    [Address(RVA = "0x129BC60", Offset = "0x129AA60", VA = "0x1129BC60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005567")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RaidFriendRescueCheck()
    {
    }
  }
}
