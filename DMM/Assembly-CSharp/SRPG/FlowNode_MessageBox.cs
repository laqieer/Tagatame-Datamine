// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MessageBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001430")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Closed", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("UI/MessageBox", 32741)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  public class FlowNode_MessageBox : FlowNode
  {
    [Token(Token = "0x4004AC1")]
    [FieldOffset(Offset = "0x18")]
    public string Caption;
    [Token(Token = "0x4004AC2")]
    [FieldOffset(Offset = "0x1C")]
    public string Text;
    [Token(Token = "0x4004AC3")]
    [FieldOffset(Offset = "0x20")]
    public bool systemModal;
    [Token(Token = "0x4004AC4")]
    [FieldOffset(Offset = "0x24")]
    public int systemModalPriority;
    [Token(Token = "0x4004AC5")]
    [FieldOffset(Offset = "0x28")]
    public GameObject parent;
    [Token(Token = "0x4004AC6")]
    [FieldOffset(Offset = "0x2C")]
    public string parentName;
    [Token(Token = "0x4004AC7")]
    [FieldOffset(Offset = "0x30")]
    public bool unscaledTime;
    [Token(Token = "0x4004AC8")]
    [FieldOffset(Offset = "0x31")]
    public bool richTag;
    [Token(Token = "0x4004AC9")]
    [FieldOffset(Offset = "0x34")]
    private GameObject winGO;

    [Token(Token = "0x600544D")]
    [Address(RVA = "0x128F400", Offset = "0x128E200", VA = "0x1128F400", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600544E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MessageBox()
    {
    }
  }
}
