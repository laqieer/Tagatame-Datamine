﻿// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NetworkRetryWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001440")]
  [FlowNode.NodeType("Common/NetworkRetryWindow", 32741)]
  [FlowNode.Pin(0, "Create", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_NetworkRetryWindow : FlowNode
  {
    [Token(Token = "0x4004AF1")]
    [FieldOffset(Offset = "0x18")]
    public GameObject Window;

    [Token(Token = "0x60054A7")]
    [Address(RVA = "0x1291180", Offset = "0x128FF80", VA = "0x11291180", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054A8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_NetworkRetryWindow()
    {
    }
  }
}