// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_YesNoDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200166F")]
  [FlowNode.NodeType("UI/YesNoDialog", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_YesNoDialog : FlowNode
  {
    [Token(Token = "0x4005188")]
    [FieldOffset(Offset = "0x18")]
    public string Title;
    [Token(Token = "0x4005189")]
    [FieldOffset(Offset = "0x1C")]
    public string Text;
    [Token(Token = "0x400518A")]
    [FieldOffset(Offset = "0x20")]
    public bool systemModal;
    [Token(Token = "0x400518B")]
    [FieldOffset(Offset = "0x24")]
    public int systemModalPriority;
    [Token(Token = "0x400518C")]
    [FieldOffset(Offset = "0x28")]
    public GameObject parent;
    [Token(Token = "0x400518D")]
    [FieldOffset(Offset = "0x2C")]
    public string parentName;
    [Token(Token = "0x400518E")]
    [FieldOffset(Offset = "0x30")]
    public bool richTag;
    [Token(Token = "0x400518F")]
    [FieldOffset(Offset = "0x31")]
    public bool unscaledTime;
    [Token(Token = "0x4005190")]
    [FieldOffset(Offset = "0x34")]
    public string yesText;
    [Token(Token = "0x4005191")]
    [FieldOffset(Offset = "0x38")]
    public string noText;
    [Token(Token = "0x4005192")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject winGO;

    [Token(Token = "0x6005C1C")]
    [Address(RVA = "0x13171D0", Offset = "0x1315FD0", VA = "0x113171D0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005C1D")]
    [Address(RVA = "0x1317290", Offset = "0x1316090", VA = "0x11317290", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C1E")]
    [Address(RVA = "0x13177E0", Offset = "0x13165E0", VA = "0x113177E0")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x6005C1F")]
    [Address(RVA = "0x1317760", Offset = "0x1316560", VA = "0x11317760")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005C20")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_YesNoDialog()
    {
    }
  }
}
