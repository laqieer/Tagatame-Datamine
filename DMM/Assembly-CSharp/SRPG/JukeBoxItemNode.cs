// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxItemNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002494")]
  public class JukeBoxItemNode : 
    ContentNode,
    IGameParameter,
    IPointerDownHandler,
    IEventSystemHandler,
    IHoldGesture
  {
    [Token(Token = "0x400A6ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text TextMusic;
    [Token(Token = "0x400A6EE")]
    [FieldOffset(Offset = "0x34")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoActive;
    [Token(Token = "0x400A6EF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject NewBadge;
    [Token(Token = "0x400A6F0")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject Mylist;
    [Token(Token = "0x400A6F1")]
    [FieldOffset(Offset = "0x40")]
    [Space(5f)]
    [SerializeField]
    private SRPG_Button BtnSelect;
    [Token(Token = "0x400A6F2")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoLocked;
    [Token(Token = "0x400A6F3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SRPG_Button BtnLock;
    [Token(Token = "0x400A6F4")]
    [FieldOffset(Offset = "0x4C")]
    private JukeBoxItemParam mParam;

    [Token(Token = "0x17001688")]
    public JukeBoxItemParam Param
    {
      [Token(Token = "0x600A070"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (JukeBoxItemParam) null;
      }
    }

    [Token(Token = "0x600A071")]
    [Address(RVA = "0x628BB0", Offset = "0x6279B0", VA = "0x10628BB0")]
    public void Setup(
      JukeBoxItemParam param,
      bool is_current,
      bool is_new,
      bool is_mylist,
      UnityAction action = null,
      UnityAction lock_action = null,
      UnityAction long_tap_action = null)
    {
    }

    [Token(Token = "0x600A072")]
    [Address(RVA = "0x628A60", Offset = "0x627860", VA = "0x10628A60")]
    public void SetCurrent(bool is_active)
    {
    }

    [Token(Token = "0x600A073")]
    [Address(RVA = "0x628850", Offset = "0x627650", VA = "0x10628850")]
    public bool IsCurrent() => new bool();

    [Token(Token = "0x600A074")]
    [Address(RVA = "0x628B40", Offset = "0x627940", VA = "0x10628B40")]
    public void SetNewBadge(bool is_new)
    {
    }

    [Token(Token = "0x600A075")]
    [Address(RVA = "0x628AD0", Offset = "0x6278D0", VA = "0x10628AD0")]
    public void SetMylist(bool is_mylist)
    {
    }

    [Token(Token = "0x17001689")]
    public virtual bool HasTooltip
    {
      [Token(Token = "0x600A076"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "22")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A077")]
    [Address(RVA = "0x628EB0", Offset = "0x627CB0", VA = "0x10628EB0")]
    protected void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600A078")]
    [Address(RVA = "0x448BE0", Offset = "0x4479E0", VA = "0x10448BE0", Slot = "19")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600A079")]
    [Address(RVA = "0x6288C0", Offset = "0x6276C0", VA = "0x106288C0", Slot = "20")]
    public void OnPointerHoldStart()
    {
    }

    [Token(Token = "0x600A07A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "21")]
    public void OnPointerHoldEnd()
    {
    }

    [Token(Token = "0x600A07B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "18")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600A07C")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public JukeBoxItemNode()
    {
    }
  }
}
