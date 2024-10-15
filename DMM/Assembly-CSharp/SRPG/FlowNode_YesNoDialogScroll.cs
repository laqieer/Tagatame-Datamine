// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_YesNoDialogScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001671")]
  [FlowNode.NodeType("UI/YesNoDialogScroll", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_YesNoDialogScroll : FlowNode
  {
    [Token(Token = "0x40051A5")]
    public const int PIN_IN_OPEN = 10;
    [Token(Token = "0x40051A6")]
    public const int PIN_IN_FORCE_CLOSE = 11;
    [Token(Token = "0x40051A7")]
    public const int PIN_OUT_YES = 1;
    [Token(Token = "0x40051A8")]
    public const int PIN_OUT_NO = 2;
    [Token(Token = "0x40051A9")]
    public const int PIN_OUT_OPENED = 100;
    [Token(Token = "0x40051AA")]
    public const int PIN_OUT_FORCECLOSED = 101;
    [Token(Token = "0x40051AB")]
    [FieldOffset(Offset = "0x18")]
    public string Title;
    [Token(Token = "0x40051AC")]
    [FieldOffset(Offset = "0x1C")]
    public string Text;
    [Token(Token = "0x40051AD")]
    [FieldOffset(Offset = "0x20")]
    public bool systemModal;
    [Token(Token = "0x40051AE")]
    [FieldOffset(Offset = "0x24")]
    public int systemModalPriority;
    [Token(Token = "0x40051AF")]
    [FieldOffset(Offset = "0x28")]
    public GameObject parent;
    [Token(Token = "0x40051B0")]
    [FieldOffset(Offset = "0x2C")]
    public string parentName;
    [Token(Token = "0x40051B1")]
    [FieldOffset(Offset = "0x30")]
    public bool richTag;
    [Token(Token = "0x40051B2")]
    [FieldOffset(Offset = "0x31")]
    public bool unscaledTime;
    [Token(Token = "0x40051B3")]
    [FieldOffset(Offset = "0x34")]
    public string yesText;
    [Token(Token = "0x40051B4")]
    [FieldOffset(Offset = "0x38")]
    public string noText;
    [Token(Token = "0x40051B5")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject winGO;

    [Token(Token = "0x6005C28")]
    [Address(RVA = "0x1316C60", Offset = "0x1315A60", VA = "0x11316C60", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005C29")]
    [Address(RVA = "0x1316D20", Offset = "0x1315B20", VA = "0x11316D20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C2A")]
    [Address(RVA = "0x1317150", Offset = "0x1315F50", VA = "0x11317150")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x6005C2B")]
    [Address(RVA = "0x13170D0", Offset = "0x1315ED0", VA = "0x113170D0")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005C2C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_YesNoDialogScroll()
    {
    }
  }
}
