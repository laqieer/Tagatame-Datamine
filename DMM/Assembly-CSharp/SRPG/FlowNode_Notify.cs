// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Notify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001446")]
  [FlowNode.Pin(10, "output", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Notify/Notify", 32741)]
  public class FlowNode_Notify : FlowNode
  {
    [Token(Token = "0x4004AFC")]
    [FieldOffset(Offset = "0x18")]
    public GameObject NotifyListTemplate;

    [Token(Token = "0x60054BB")]
    [Address(RVA = "0x12935A0", Offset = "0x12923A0", VA = "0x112935A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054BC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Notify()
    {
    }
  }
}
