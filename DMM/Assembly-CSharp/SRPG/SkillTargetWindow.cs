// Decompiled with JetBrains decompiler
// Type: SRPG.SkillTargetWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200112D")]
  [AddComponentMenu("Common/SkillTargetWindow")]
  public class SkillTargetWindow : MonoBehaviour
  {
    [Token(Token = "0x4003E8F")]
    [FieldOffset(Offset = "0xC")]
    public SkillTargetWindow.TargetSelectEvent OnTargetSelect;
    [Token(Token = "0x4003E90")]
    [FieldOffset(Offset = "0x10")]
    public SkillTargetWindow.CancelEvent OnCancel;
    [Token(Token = "0x4003E91")]
    [FieldOffset(Offset = "0x14")]
    private WindowController mWC;

    [Token(Token = "0x6004967")]
    [Address(RVA = "0x11FC240", Offset = "0x11FB040", VA = "0x111FC240")]
    private void Start()
    {
    }

    [Token(Token = "0x6004968")]
    [Address(RVA = "0x11FC1D0", Offset = "0x11FAFD0", VA = "0x111FC1D0")]
    public void Show()
    {
    }

    [Token(Token = "0x6004969")]
    [Address(RVA = "0x11FC160", Offset = "0x11FAF60", VA = "0x111FC160")]
    public void Hide()
    {
    }

    [Token(Token = "0x600496A")]
    [Address(RVA = "0x11FC0C0", Offset = "0x11FAEC0", VA = "0x111FC0C0")]
    public void ForceHide()
    {
    }

    [Token(Token = "0x600496B")]
    [Address(RVA = "0x11FC290", Offset = "0x11FB090", VA = "0x111FC290")]
    public void UnitSelected()
    {
    }

    [Token(Token = "0x600496C")]
    [Address(RVA = "0x11FC130", Offset = "0x11FAF30", VA = "0x111FC130")]
    public void GridSelected()
    {
    }

    [Token(Token = "0x600496D")]
    [Address(RVA = "0x11FC090", Offset = "0x11FAE90", VA = "0x111FC090")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600496E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SkillTargetWindow()
    {
    }

    [Token(Token = "0x200112E")]
    public delegate void TargetSelectEvent(bool grid);

    [Token(Token = "0x200112F")]
    public delegate void CancelEvent();
  }
}
