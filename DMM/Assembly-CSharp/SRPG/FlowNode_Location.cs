// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Location
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001427")]
  [FlowNode.NodeType("Common/Location", 32741)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_Location : FlowNode
  {
    [Token(Token = "0x4004A9A")]
    [FieldOffset(Offset = "0x18")]
    private Location m_Location;

    [Token(Token = "0x6005422")]
    [Address(RVA = "0x128D1C0", Offset = "0x128BFC0", VA = "0x1128D1C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6005423")]
    [Address(RVA = "0x128D0C0", Offset = "0x128BEC0", VA = "0x1128D0C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6005424")]
    [Address(RVA = "0x128CD80", Offset = "0x128BB80", VA = "0x1128CD80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005425")]
    [Address(RVA = "0x128CFF0", Offset = "0x128BDF0", VA = "0x1128CFF0")]
    private void OnSuccess(Location gps)
    {
    }

    [Token(Token = "0x6005426")]
    [Address(RVA = "0x128CF50", Offset = "0x128BD50", VA = "0x1128CF50")]
    private void OnFailed(Location gps)
    {
    }

    [Token(Token = "0x6005427")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Location()
    {
    }
  }
}
