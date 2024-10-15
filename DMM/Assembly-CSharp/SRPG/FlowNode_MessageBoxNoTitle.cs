// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MessageBoxNoTitle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001432")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/MessageBoxNoTitle", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Closed", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_MessageBoxNoTitle : FlowNode
  {
    [Token(Token = "0x4004AD4")]
    [FieldOffset(Offset = "0x18")]
    public string Text;
    [Token(Token = "0x4004AD5")]
    [FieldOffset(Offset = "0x1C")]
    public bool systemModal;
    [Token(Token = "0x4004AD6")]
    [FieldOffset(Offset = "0x20")]
    public int systemModalPriority;
    [Token(Token = "0x4004AD7")]
    [FieldOffset(Offset = "0x24")]
    public GameObject parent;
    [Token(Token = "0x4004AD8")]
    [FieldOffset(Offset = "0x28")]
    public string parentName;
    [Token(Token = "0x4004AD9")]
    [FieldOffset(Offset = "0x2C")]
    public bool unscaledTime;
    [Token(Token = "0x4004ADA")]
    [FieldOffset(Offset = "0x2D")]
    public bool richTag;
    [Token(Token = "0x4004ADB")]
    [FieldOffset(Offset = "0x30")]
    private GameObject winGO;

    [Token(Token = "0x6005454")]
    [Address(RVA = "0x128F090", Offset = "0x128DE90", VA = "0x1128F090", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005455")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MessageBoxNoTitle()
    {
    }
  }
}
