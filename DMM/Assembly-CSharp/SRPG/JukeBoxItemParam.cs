// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002493")]
  public class JukeBoxItemParam : ContentSource.Param
  {
    [Token(Token = "0x400A6E5")]
    [FieldOffset(Offset = "0x10")]
    public JukeBoxWindow.JukeBoxData ItemData;
    [Token(Token = "0x400A6E6")]
    [FieldOffset(Offset = "0x14")]
    public UnityAction OnClickAction;
    [Token(Token = "0x400A6E7")]
    [FieldOffset(Offset = "0x18")]
    public UnityAction OnClickActionLock;
    [Token(Token = "0x400A6E8")]
    [FieldOffset(Offset = "0x1C")]
    public UnityAction LongTapAction;
    [Token(Token = "0x400A6E9")]
    [FieldOffset(Offset = "0x20")]
    private JukeBoxItemNode mNode;
    [Token(Token = "0x400A6EA")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsCurrent;
    [Token(Token = "0x400A6EB")]
    [FieldOffset(Offset = "0x25")]
    private bool mNewFlag;
    [Token(Token = "0x400A6EC")]
    [FieldOffset(Offset = "0x26")]
    private bool mMylistFlag;

    [Token(Token = "0x600A067")]
    [Address(RVA = "0x628F50", Offset = "0x627D50", VA = "0x10628F50", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600A068")]
    [Address(RVA = "0x628F20", Offset = "0x627D20", VA = "0x10628F20", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600A069")]
    [Address(RVA = "0x629080", Offset = "0x627E80", VA = "0x10629080")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A06A")]
    [Address(RVA = "0x629110", Offset = "0x627F10", VA = "0x10629110")]
    public void SetCurrent(bool is_active)
    {
    }

    [Token(Token = "0x600A06B")]
    [Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")]
    public bool IsCurrent() => new bool();

    [Token(Token = "0x600A06C")]
    [Address(RVA = "0x6291F0", Offset = "0x627FF0", VA = "0x106291F0")]
    public void SetNewBadge(bool is_new)
    {
    }

    [Token(Token = "0x600A06D")]
    [Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")]
    public bool IsNewBadge() => new bool();

    [Token(Token = "0x600A06E")]
    [Address(RVA = "0x629180", Offset = "0x627F80", VA = "0x10629180")]
    public void SetMylistFlag(bool is_mylist)
    {
    }

    [Token(Token = "0x600A06F")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public JukeBoxItemParam()
    {
    }
  }
}
