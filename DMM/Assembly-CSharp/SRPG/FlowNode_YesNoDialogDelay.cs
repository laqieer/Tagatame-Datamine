// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_YesNoDialogDelay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001343")]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("FlowNode_YesNoDialogDelay", 32741)]
  public class FlowNode_YesNoDialogDelay : FlowNode
  {
    [Token(Token = "0x4004745")]
    public const int PIN_IN_OPEN = 10;
    [Token(Token = "0x4004746")]
    public const int PIN_IN_FORCE_CLOSE = 11;
    [Token(Token = "0x4004747")]
    public const int PIN_OUT_YES = 1;
    [Token(Token = "0x4004748")]
    public const int PIN_OUT_NO = 2;
    [Token(Token = "0x4004749")]
    public const int PIN_OUT_OPENED = 100;
    [Token(Token = "0x400474A")]
    public const int PIN_OUT_FORCECLOSED = 101;
    [Token(Token = "0x400474B")]
    [FieldOffset(Offset = "0x18")]
    public string Title;
    [Token(Token = "0x400474C")]
    [FieldOffset(Offset = "0x1C")]
    public string Text;
    [Token(Token = "0x400474D")]
    [FieldOffset(Offset = "0x20")]
    public bool systemModal;
    [Token(Token = "0x400474E")]
    [FieldOffset(Offset = "0x24")]
    public int systemModalPriority;
    [Token(Token = "0x400474F")]
    [FieldOffset(Offset = "0x28")]
    public GameObject parent;
    [Token(Token = "0x4004750")]
    [FieldOffset(Offset = "0x2C")]
    public string parentName;
    [Token(Token = "0x4004751")]
    [FieldOffset(Offset = "0x30")]
    public bool richTag;
    [Token(Token = "0x4004752")]
    [FieldOffset(Offset = "0x31")]
    public bool unscaledTime;
    [Token(Token = "0x4004753")]
    [FieldOffset(Offset = "0x34")]
    public string yesText;
    [Token(Token = "0x4004754")]
    [FieldOffset(Offset = "0x38")]
    public string noText;
    [Token(Token = "0x4004755")]
    [FieldOffset(Offset = "0x3C")]
    public float yesDelay;
    [Token(Token = "0x4004756")]
    [FieldOffset(Offset = "0x40")]
    public float noDelay;
    [Token(Token = "0x4004757")]
    [FieldOffset(Offset = "0x44")]
    public TextAnchor textAnchor;
    [Token(Token = "0x4004758")]
    [FieldOffset(Offset = "0x48")]
    private GameObject winGO;

    [Token(Token = "0x6005106")]
    [Address(RVA = "0x1263DA0", Offset = "0x1262BA0", VA = "0x11263DA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005107")]
    [Address(RVA = "0x1263F90", Offset = "0x1262D90", VA = "0x11263F90")]
    private void OpenDialog()
    {
    }

    [Token(Token = "0x6005108")]
    [Address(RVA = "0x1263C10", Offset = "0x1262A10", VA = "0x11263C10")]
    private void ForceClose()
    {
    }

    [Token(Token = "0x6005109")]
    [Address(RVA = "0x1263CE0", Offset = "0x1262AE0", VA = "0x11263CE0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x600510A")]
    [Address(RVA = "0x1263F10", Offset = "0x1262D10", VA = "0x11263F10")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x600510B")]
    [Address(RVA = "0x1263E90", Offset = "0x1262C90", VA = "0x11263E90")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x600510C")]
    [Address(RVA = "0x12642A0", Offset = "0x12630A0", VA = "0x112642A0")]
    public FlowNode_YesNoDialogDelay()
    {
    }
  }
}
