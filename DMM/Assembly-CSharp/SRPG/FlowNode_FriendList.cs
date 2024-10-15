// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_FriendList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013EF")]
  [FlowNode.NodeType("Network/FriendList", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Request(フレンド申請も含む)", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  public class FlowNode_FriendList : FlowNode_Network
  {
    [Token(Token = "0x40049DF")]
    [FieldOffset(Offset = "0x20")]
    private bool IsFollower;

    [Token(Token = "0x600537D")]
    [Address(RVA = "0x1280D00", Offset = "0x127FB00", VA = "0x11280D00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600537E")]
    [Address(RVA = "0x107A1E0", Offset = "0x1078FE0", VA = "0x1107A1E0")]
    private void Success()
    {
    }

    [Token(Token = "0x600537F")]
    [Address(RVA = "0x1280E10", Offset = "0x127FC10", VA = "0x11280E10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005380")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_FriendList()
    {
    }
  }
}
