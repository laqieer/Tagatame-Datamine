// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxItemSectionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002496")]
  public class JukeBoxItemSectionNode : ContentNode
  {
    [Token(Token = "0x400A6FA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray ImageArraySection;
    [Token(Token = "0x400A6FB")]
    [FieldOffset(Offset = "0x34")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoActive;
    [Token(Token = "0x400A6FC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject NewBadge;
    [Token(Token = "0x400A6FD")]
    [FieldOffset(Offset = "0x3C")]
    [Space(5f)]
    [SerializeField]
    private SRPG_Button BtnSelect;
    [Token(Token = "0x400A6FE")]
    [FieldOffset(Offset = "0x40")]
    private JukeBoxItemSectionParam mParam;

    [Token(Token = "0x1700168A")]
    public JukeBoxItemSectionParam Param
    {
      [Token(Token = "0x600A084"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (JukeBoxItemSectionParam) null;
      }
    }

    [Token(Token = "0x600A085")]
    [Address(RVA = "0x6293B0", Offset = "0x6281B0", VA = "0x106293B0")]
    public void Setup(
      JukeBoxItemSectionParam param,
      bool is_current,
      bool is_new,
      UnityAction action = null)
    {
    }

    [Token(Token = "0x600A086")]
    [Address(RVA = "0x6292D0", Offset = "0x6280D0", VA = "0x106292D0")]
    public void SetCurrent(bool is_active)
    {
    }

    [Token(Token = "0x600A087")]
    [Address(RVA = "0x629260", Offset = "0x628060", VA = "0x10629260")]
    public bool IsCurrent() => new bool();

    [Token(Token = "0x600A088")]
    [Address(RVA = "0x629340", Offset = "0x628140", VA = "0x10629340")]
    public void SetNewBadge(bool is_new)
    {
    }

    [Token(Token = "0x600A089")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public JukeBoxItemSectionNode()
    {
    }
  }
}
