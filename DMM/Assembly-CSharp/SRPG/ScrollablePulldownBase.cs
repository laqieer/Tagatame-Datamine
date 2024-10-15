// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollablePulldownBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A5F")]
  public abstract class ScrollablePulldownBase : 
    Selectable,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IEndDragHandler
  {
    [Token(Token = "0x400CE2B")]
    [FieldOffset(Offset = "0xB0")]
    public ScrollablePulldownBase.SelectItemEvent OnSelectionChangeDelegate;
    [Token(Token = "0x400CE2C")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    protected List<PulldownItem> Items;
    [Token(Token = "0x400CE2D")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    protected RectTransform ItemHolder;
    [Token(Token = "0x400CE2E")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    protected ScrollRect ScrollRect;
    [Token(Token = "0x400CE2F")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text SelectionText;
    [Token(Token = "0x400CE30")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    private GameObject BackGround;
    [Token(Token = "0x400CE31")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private string OpenSE;
    [Token(Token = "0x400CE32")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    private string CloseSE;
    [Token(Token = "0x400CE33")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private string SelectSE;
    [Token(Token = "0x400CE34")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    private bool ForceOpen;
    [Token(Token = "0x400CE35")]
    [FieldOffset(Offset = "0xD5")]
    [SerializeField]
    private bool SizeAdjustable;
    [Token(Token = "0x400CE36")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private int MinItemCount;
    [Token(Token = "0x400CE37")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    private int MaxItemCount;
    [Token(Token = "0x400CE38")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private int ItemHeight;
    [Token(Token = "0x400CE39")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    private bool IsAutoPositionItemHolder;
    [Token(Token = "0x400CE3A")]
    [FieldOffset(Offset = "0xE8")]
    private int mPrevSelectionIndex;
    [Token(Token = "0x400CE3B")]
    [FieldOffset(Offset = "0xEC")]
    private int mSelectionIndex;
    [Token(Token = "0x400CE3C")]
    [FieldOffset(Offset = "0xF0")]
    private bool mOpened;
    [Token(Token = "0x400CE3D")]
    [FieldOffset(Offset = "0xF1")]
    private bool mTrackTouchPosititon;

    [Token(Token = "0x170019DA")]
    protected bool IsOpenWindow
    {
      [Token(Token = "0x600C14C"), Address(RVA = "0x8A30B0", Offset = "0x8A1EB0", VA = "0x108A30B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C14D")]
    [Address(RVA = "0x8A2E70", Offset = "0x8A1C70", VA = "0x108A2E70", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C14E")]
    [Address(RVA = "0x8A26F0", Offset = "0x8A14F0", VA = "0x108A26F0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C14F")]
    [Address(RVA = "0x8A2BE0", Offset = "0x8A19E0", VA = "0x108A2BE0")]
    protected void ResetAllStatus()
    {
    }

    [Token(Token = "0x600C150")]
    [Address(RVA = "0x8A24D0", Offset = "0x8A12D0", VA = "0x108A24D0")]
    public void ClearSelection()
    {
    }

    [Token(Token = "0x170019DB")]
    public int Selection
    {
      [Token(Token = "0x600C151"), Address(RVA = "0x6718F0", Offset = "0x6706F0", VA = "0x106718F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600C152"), Address(RVA = "0x8A3100", Offset = "0x8A1F00", VA = "0x108A3100")] set
      {
      }
    }

    [Token(Token = "0x170019DC")]
    public int PrevSelection
    {
      [Token(Token = "0x600C153"), Address(RVA = "0x809540", Offset = "0x808340", VA = "0x10809540")] set
      {
      }
      [Token(Token = "0x600C154"), Address(RVA = "0x45A220", Offset = "0x459020", VA = "0x1045A220")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C155")]
    [Address(RVA = "0x8A2C00", Offset = "0x8A1A00", VA = "0x108A2C00")]
    private bool SelectNearestItem(PointerEventData e) => new bool();

    [Token(Token = "0x600C156")]
    [Address(RVA = "0x8A2F00", Offset = "0x8A1D00", VA = "0x108A2F00")]
    protected void TriggerItemChange()
    {
    }

    [Token(Token = "0x600C157")]
    [Address(RVA = "0x8A28D0", Offset = "0x8A16D0", VA = "0x108A28D0")]
    private void OnPulldownMenuTouch(BaseEventData eventData)
    {
    }

    [Token(Token = "0x600C158")]
    [Address(RVA = "0x8A2880", Offset = "0x8A1680", VA = "0x108A2880", Slot = "32")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C159")]
    [Address(RVA = "0x8A2970", Offset = "0x8A1770", VA = "0x108A2970")]
    public void OpenPulldown()
    {
    }

    [Token(Token = "0x600C15A")]
    [Address(RVA = "0x8A24F0", Offset = "0x8A12F0", VA = "0x108A24F0")]
    public void ClosePulldown(bool se = true)
    {
    }

    [Token(Token = "0x600C15B")]
    [Address(RVA = "0x8A27C0", Offset = "0x8A15C0", VA = "0x108A27C0", Slot = "42")]
    public virtual void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C15C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "43")]
    public virtual void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C15D")]
    [Address(RVA = "0x8A27F0", Offset = "0x8A15F0", VA = "0x108A27F0", Slot = "44")]
    public virtual void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C15E")]
    [Address(RVA = "0x8A2640", Offset = "0x8A1440", VA = "0x108A2640")]
    public PulldownItem GetItemAt(int index) => (PulldownItem) null;

    [Token(Token = "0x170019DD")]
    public int ItemCount
    {
      [Token(Token = "0x600C15F"), Address(RVA = "0x8A30C0", Offset = "0x8A1EC0", VA = "0x108A30C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C160")]
    [Address(RVA = "0x8A25D0", Offset = "0x8A13D0", VA = "0x108A25D0")]
    public PulldownItem GetCurrentSelection() => (PulldownItem) null;

    [Token(Token = "0x600C161")]
    [Address(RVA = "0x8A26A0", Offset = "0x8A14A0", VA = "0x108A26A0")]
    public int IndexOf(PulldownItem item) => new int();

    [Token(Token = "0x600C162")]
    [Address(RVA = "0x8A2FE0", Offset = "0x8A1DE0", VA = "0x108A2FE0")]
    protected ScrollablePulldownBase()
    {
    }

    [Token(Token = "0x2002A60")]
    public delegate void SelectItemEvent(int value);
  }
}
