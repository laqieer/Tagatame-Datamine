// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_YesNoDialogAddMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001670")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Opened", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ForceClosed", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "ForceClose", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("UI/YesNoDialogAddMessage", 32741)]
  public class FlowNode_YesNoDialogAddMessage : FlowNode
  {
    [Token(Token = "0x4005193")]
    [FieldOffset(Offset = "0x18")]
    public string Title;
    [Token(Token = "0x4005194")]
    [FieldOffset(Offset = "0x1C")]
    public string Text;
    [Token(Token = "0x4005195")]
    [FieldOffset(Offset = "0x20")]
    public bool systemModal;
    [Token(Token = "0x4005196")]
    [FieldOffset(Offset = "0x24")]
    public int systemModalPriority;
    [Token(Token = "0x4005197")]
    [FieldOffset(Offset = "0x28")]
    public GameObject parent;
    [Token(Token = "0x4005198")]
    [FieldOffset(Offset = "0x2C")]
    public string parentName;
    [Token(Token = "0x4005199")]
    [FieldOffset(Offset = "0x30")]
    public bool richTag;
    [Token(Token = "0x400519A")]
    [FieldOffset(Offset = "0x31")]
    public bool unscaledTime;
    [Token(Token = "0x400519B")]
    [FieldOffset(Offset = "0x34")]
    public string yesText;
    [Token(Token = "0x400519C")]
    [FieldOffset(Offset = "0x38")]
    public string noText;
    [Token(Token = "0x400519D")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject winGO;
    [Token(Token = "0x400519E")]
    private const int STARTADDPIN = 1000;
    [Token(Token = "0x400519F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [HeaderBar("文章を追加する際に改行をいれるかどうか")]
    private bool m_txtAddLine;
    [Token(Token = "0x40051A0")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private string m_TxtSeparator;
    [Token(Token = "0x40051A1")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int m_Num;
    [Token(Token = "0x40051A2")]
    [FieldOffset(Offset = "0x4C")]
    [HideInInspector]
    [SerializeField]
    private FlowNode.Pin[] m_Pins;
    [Token(Token = "0x40051A3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [HideInInspector]
    private string[] addText;
    [Token(Token = "0x40051A4")]
    [FieldOffset(Offset = "0x54")]
    private string m_AddText;

    [Token(Token = "0x6005C21")]
    [Address(RVA = "0x13163E0", Offset = "0x13151E0", VA = "0x113163E0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005C22")]
    [Address(RVA = "0x13164A0", Offset = "0x13152A0", VA = "0x113164A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C23")]
    [Address(RVA = "0x13162D0", Offset = "0x13150D0", VA = "0x113162D0")]
    private void AddTextCheck(string str)
    {
    }

    [Token(Token = "0x6005C24")]
    [Address(RVA = "0x1316B50", Offset = "0x1315950", VA = "0x11316B50")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x6005C25")]
    [Address(RVA = "0x1316AB0", Offset = "0x13158B0", VA = "0x11316AB0")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005C26")]
    [Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0", Slot = "9")]
    public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

    [Token(Token = "0x6005C27")]
    [Address(RVA = "0x1316BF0", Offset = "0x13159F0", VA = "0x11316BF0")]
    public FlowNode_YesNoDialogAddMessage()
    {
    }
  }
}
