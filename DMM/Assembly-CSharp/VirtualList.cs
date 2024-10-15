// Decompiled with JetBrains decompiler
// Type: VirtualList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000306")]
[AddComponentMenu("UI/VirtualList")]
public class VirtualList : UIBehaviour
{
  [Token(Token = "0x4000C6E")]
  [FieldOffset(Offset = "0xC")]
  public ScrollRect ScrollRect;
  [Token(Token = "0x4000C6F")]
  [FieldOffset(Offset = "0x10")]
  public Vector2 ItemSize;
  [Token(Token = "0x4000C70")]
  [FieldOffset(Offset = "0x18")]
  private List<int> mItems;
  [Token(Token = "0x4000C71")]
  [FieldOffset(Offset = "0x1C")]
  private List<VirtualList.ItemContainer> mItemObjects;
  [Token(Token = "0x4000C72")]
  [FieldOffset(Offset = "0x20")]
  private bool mBoundsChanging;
  [Token(Token = "0x4000C73")]
  [FieldOffset(Offset = "0x21")]
  private bool mDestroyed;
  [Token(Token = "0x4000C74")]
  [FieldOffset(Offset = "0x24")]
  private float mLastScrollPosition;
  [Token(Token = "0x4000C75")]
  [FieldOffset(Offset = "0x28")]
  private int mNumVisibleItems;
  [Token(Token = "0x4000C76")]
  [FieldOffset(Offset = "0x2C")]
  private bool mInitialized;
  [Token(Token = "0x4000C77")]
  [FieldOffset(Offset = "0x30")]
  public VirtualList.GetItemObjectEvent OnGetItemObject;
  [Token(Token = "0x4000C78")]
  [FieldOffset(Offset = "0x34")]
  public VirtualList.ListEvent OnPostListUpdate;

  [Token(Token = "0x6000FB1")]
  [Address(RVA = "0x12AF900", Offset = "0x12AE700", VA = "0x112AF900")]
  public void AddItem(int id)
  {
  }

  [Token(Token = "0x6000FB2")]
  [Address(RVA = "0x12B0C60", Offset = "0x12AFA60", VA = "0x112B0C60")]
  public void RemoveItem(int id)
  {
  }

  [Token(Token = "0x6000FB3")]
  [Address(RVA = "0x12AFA60", Offset = "0x12AE860", VA = "0x112AFA60")]
  public void ClearItems()
  {
  }

  [Token(Token = "0x170001D6")]
  public int NumVisibleItems
  {
    [Token(Token = "0x6000FB4"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170001D7")]
  public int NumItems
  {
    [Token(Token = "0x6000FB5"), Address(RVA = "0x12B1410", Offset = "0x12B0210", VA = "0x112B1410")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170001D8")]
  private float HorizontalNormalizedPosition
  {
    [Token(Token = "0x6000FB6"), Address(RVA = "0x12B1350", Offset = "0x12B0150", VA = "0x112B1350")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x6000FB7")]
  [Address(RVA = "0x12B0B60", Offset = "0x12AF960", VA = "0x112B0B60")]
  public void Refresh(bool resetScrollPos = false)
  {
  }

  [Token(Token = "0x6000FB8")]
  [Address(RVA = "0x12AFFB0", Offset = "0x12AEDB0", VA = "0x112AFFB0")]
  public RectTransform FindItem(int itemID) => (RectTransform) null;

  [Token(Token = "0x6000FB9")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "4")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000FBA")]
  [Address(RVA = "0x12B10F0", Offset = "0x12AFEF0", VA = "0x112B10F0", Slot = "6")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000FBB")]
  [Address(RVA = "0x12B01D0", Offset = "0x12AEFD0", VA = "0x112B01D0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000FBC")]
  [Address(RVA = "0x12B0390", Offset = "0x12AF190", VA = "0x112B0390", Slot = "10")]
  protected override void OnRectTransformDimensionsChange()
  {
  }

  [Token(Token = "0x6000FBD")]
  [Address(RVA = "0x12B0400", Offset = "0x12AF200", VA = "0x112B0400")]
  private void OnSrollRectChange(Vector2 pos)
  {
  }

  [Token(Token = "0x6000FBE")]
  [Address(RVA = "0x12B01C0", Offset = "0x12AEFC0", VA = "0x112B01C0")]
  private bool IsDiscarding() => new bool();

  [Token(Token = "0x170001D9")]
  private bool IsHorizontal
  {
    [Token(Token = "0x6000FBF"), Address(RVA = "0x12B13F0", Offset = "0x12B01F0", VA = "0x112B13F0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000FC0")]
  [Address(RVA = "0x12AF980", Offset = "0x12AE780", VA = "0x112AF980")]
  private int CalcPitch() => new int();

  [Token(Token = "0x6000FC1")]
  [Address(RVA = "0x12B09B0", Offset = "0x12AF7B0", VA = "0x112B09B0")]
  private void RecalcBounds()
  {
  }

  [Token(Token = "0x6000FC2")]
  [Address(RVA = "0x12B0E80", Offset = "0x12AFC80", VA = "0x112B0E80")]
  private void ReserveItems(int maxItems)
  {
  }

  [Token(Token = "0x6000FC3")]
  [Address(RVA = "0x12AFAA0", Offset = "0x12AE8A0", VA = "0x112AFAA0")]
  private void DisableAllItems()
  {
  }

  [Token(Token = "0x6000FC4")]
  [Address(RVA = "0x12B00A0", Offset = "0x12AEEA0", VA = "0x112B00A0")]
  public void ForceUpdateItems()
  {
  }

  [Token(Token = "0x6000FC5")]
  [Address(RVA = "0x12B0420", Offset = "0x12AF220", VA = "0x112B0420")]
  private void Rebuild()
  {
  }

  [Token(Token = "0x6000FC6")]
  [Address(RVA = "0x12AFDD0", Offset = "0x12AEBD0", VA = "0x112AFDD0")]
  private int FindItemAtPosition(int itemID, float x, float y) => new int();

  [Token(Token = "0x6000FC7")]
  [Address(RVA = "0x12AFF10", Offset = "0x12AED10", VA = "0x112AFF10")]
  private VirtualList.ItemContainer FindItemContainer(int itemID)
  {
    return (VirtualList.ItemContainer) null;
  }

  [Token(Token = "0x6000FC8")]
  [Address(RVA = "0x12AFBA0", Offset = "0x12AE9A0", VA = "0x112AFBA0")]
  private void FillContainer(VirtualList.ItemContainer container, int itemID)
  {
  }

  [Token(Token = "0x6000FC9")]
  [Address(RVA = "0x12B0CE0", Offset = "0x12AFAE0", VA = "0x112B0CE0")]
  private void ReparentItems()
  {
  }

  [Token(Token = "0x6000FCA")]
  [Address(RVA = "0x12B1240", Offset = "0x12B0040", VA = "0x112B1240")]
  private void SwapFast(VirtualList.ItemContainer a, VirtualList.ItemContainer b)
  {
  }

  [Token(Token = "0x6000FCB")]
  [Address(RVA = "0x12B1290", Offset = "0x12B0090", VA = "0x112B1290")]
  public VirtualList()
  {
  }

  [Token(Token = "0x2000307")]
  public delegate RectTransform GetItemObjectEvent(int item, int old, RectTransform current);

  [Token(Token = "0x2000308")]
  public delegate void ListEvent();

  [Token(Token = "0x2000309")]
  private class ItemContainer : MonoBehaviour
  {
    [Token(Token = "0x4000C79")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform RectTr;
    [Token(Token = "0x4000C7A")]
    [FieldOffset(Offset = "0x10")]
    public int ItemID;
    [Token(Token = "0x4000C7B")]
    [FieldOffset(Offset = "0x14")]
    public RectTransform Body;

    [Token(Token = "0x6000FD4")]
    [Address(RVA = "0x12A1400", Offset = "0x12A0200", VA = "0x112A1400")]
    private void Awake()
    {
    }

    [Token(Token = "0x6000FD5")]
    [Address(RVA = "0x12A1480", Offset = "0x12A0280", VA = "0x112A1480")]
    public void SetBodyActive(bool active)
    {
    }

    [Token(Token = "0x6000FD6")]
    [Address(RVA = "0x91A340", Offset = "0x919140", VA = "0x1091A340")]
    public ItemContainer()
    {
    }
  }
}
