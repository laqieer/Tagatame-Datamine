// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AppVer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001367")]
  [FlowNode.NodeType("System/Version/AppVersion", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Default", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_AppVer : FlowNode
  {
    [Token(Token = "0x40047A4")]
    [FieldOffset(Offset = "0x18")]
    [FlexibleArray]
    public string[] Versions;

    [Token(Token = "0x6005167")]
    [Address(RVA = "0x1266620", Offset = "0x1265420", VA = "0x11266620", Slot = "9")]
    public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

    [Token(Token = "0x6005168")]
    [Address(RVA = "0x1266750", Offset = "0x1265550", VA = "0x11266750", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005169")]
    [Address(RVA = "0x12667E0", Offset = "0x12655E0", VA = "0x112667E0")]
    public FlowNode_AppVer()
    {
    }
  }
}
