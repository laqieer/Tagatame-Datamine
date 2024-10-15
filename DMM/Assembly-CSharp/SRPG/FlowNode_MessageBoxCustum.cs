// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MessageBoxCustum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001431")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("UI/MessageBoxCustum", 32741)]
  [FlowNode.Pin(1, "Closed", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_MessageBoxCustum : FlowNode
  {
    [Token(Token = "0x4004ACA")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePath(typeof (GameObject))]
    public string ResourcePath;
    [Token(Token = "0x4004ACB")]
    [FieldOffset(Offset = "0x1C")]
    public string Caption;
    [Token(Token = "0x4004ACC")]
    [FieldOffset(Offset = "0x20")]
    public string Text;
    [Token(Token = "0x4004ACD")]
    [FieldOffset(Offset = "0x24")]
    public bool systemModal;
    [Token(Token = "0x4004ACE")]
    [FieldOffset(Offset = "0x28")]
    public int systemModalPriority;
    [Token(Token = "0x4004ACF")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject parent;
    [Token(Token = "0x4004AD0")]
    [FieldOffset(Offset = "0x30")]
    public string parentName;
    [Token(Token = "0x4004AD1")]
    [FieldOffset(Offset = "0x34")]
    public bool unscaledTime;
    [Token(Token = "0x4004AD2")]
    [FieldOffset(Offset = "0x35")]
    public bool richTag;
    [Token(Token = "0x4004AD3")]
    [FieldOffset(Offset = "0x38")]
    private GameObject winGO;

    [Token(Token = "0x6005450")]
    [Address(RVA = "0x128ECF0", Offset = "0x128DAF0", VA = "0x1128ECF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005451")]
    [Address(RVA = "0x128EA10", Offset = "0x128D810", VA = "0x1128EA10")]
    private GameObject CreatePrefab(
      string resource_path,
      string title,
      string msg,
      UIUtility.DialogResultEvent ok_event_listener,
      GameObject go_parent,
      bool system_modal,
      int system_modal_priority)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6005452")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MessageBoxCustum()
    {
    }
  }
}
