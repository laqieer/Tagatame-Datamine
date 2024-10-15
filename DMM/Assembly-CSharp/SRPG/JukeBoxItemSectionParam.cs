// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxItemSectionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002495")]
  public class JukeBoxItemSectionParam : ContentSource.Param
  {
    [Token(Token = "0x400A6F5")]
    [FieldOffset(Offset = "0x10")]
    public JukeBoxSectionParam SectionParam;
    [Token(Token = "0x400A6F6")]
    [FieldOffset(Offset = "0x14")]
    public UnityAction OnClickAction;
    [Token(Token = "0x400A6F7")]
    [FieldOffset(Offset = "0x18")]
    private List<JukeBoxItemSectionNode> mNodeList;
    [Token(Token = "0x400A6F8")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsCurrent;
    [Token(Token = "0x400A6F9")]
    [FieldOffset(Offset = "0x1D")]
    private bool mNewFlag;

    [Token(Token = "0x600A07D")]
    [Address(RVA = "0x629640", Offset = "0x628440", VA = "0x10629640", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600A07E")]
    [Address(RVA = "0x629560", Offset = "0x628360", VA = "0x10629560", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600A07F")]
    [Address(RVA = "0x6296E0", Offset = "0x6284E0", VA = "0x106296E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A080")]
    [Address(RVA = "0x629840", Offset = "0x628640", VA = "0x10629840")]
    public void SetCurrent(bool is_active)
    {
    }

    [Token(Token = "0x600A081")]
    [Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")]
    public bool IsCurrent() => new bool();

    [Token(Token = "0x600A082")]
    [Address(RVA = "0x6299E0", Offset = "0x6287E0", VA = "0x106299E0")]
    public void SetNewBadge(bool is_new)
    {
    }

    [Token(Token = "0x600A083")]
    [Address(RVA = "0x629B80", Offset = "0x628980", VA = "0x10629B80")]
    public JukeBoxItemSectionParam()
    {
    }
  }
}
