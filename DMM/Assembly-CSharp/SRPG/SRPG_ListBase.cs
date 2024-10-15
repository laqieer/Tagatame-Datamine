// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_ListBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200113A")]
  [AddComponentMenu("Common/SRPG_ListBase")]
  public class SRPG_ListBase : MonoBehaviour
  {
    [Token(Token = "0x4003ECB")]
    [FieldOffset(Offset = "0xC")]
    private Transform mItemBodyPool;
    [Token(Token = "0x4003ECC")]
    [FieldOffset(Offset = "0x10")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x4003ECD")]
    [FieldOffset(Offset = "0x14")]
    private ScrollRect mScrollRect;
    [Token(Token = "0x4003ECE")]
    [FieldOffset(Offset = "0x18")]
    private RectTransform mTransform;
    [Token(Token = "0x4003ECF")]
    [FieldOffset(Offset = "0x1C")]
    private RectTransform mScrollRectTransform;

    [Token(Token = "0x60049CD")]
    [Address(RVA = "0x1204FE0", Offset = "0x1203DE0", VA = "0x11204FE0")]
    public void AddItem(ListItemEvents item)
    {
    }

    [Token(Token = "0x60049CE")]
    [Address(RVA = "0x1205050", Offset = "0x1203E50", VA = "0x11205050")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x17000810")]
    protected bool IsEmpty
    {
      [Token(Token = "0x60049CF"), Address(RVA = "0x1205D00", Offset = "0x1204B00", VA = "0x11205D00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000811")]
    protected ListItemEvents[] Items
    {
      [Token(Token = "0x60049D0"), Address(RVA = "0x1205D40", Offset = "0x1204B40", VA = "0x11205D40")] get
      {
        return (ListItemEvents[]) null;
      }
    }

    [Token(Token = "0x60049D1")]
    [Address(RVA = "0x12052A0", Offset = "0x12040A0", VA = "0x112052A0")]
    private void InitPool()
    {
    }

    [Token(Token = "0x60049D2")]
    [Address(RVA = "0x1205260", Offset = "0x1204060", VA = "0x11205260", Slot = "4")]
    protected virtual ScrollRect GetScrollRect() => (ScrollRect) null;

    [Token(Token = "0x60049D3")]
    [Address(RVA = "0x1205210", Offset = "0x1204010", VA = "0x11205210", Slot = "5")]
    protected virtual RectTransform GetRectTransform() => (RectTransform) null;

    [Token(Token = "0x60049D4")]
    [Address(RVA = "0x1205B90", Offset = "0x1204990", VA = "0x11205B90", Slot = "6")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x60049D5")]
    [Address(RVA = "0x1205A00", Offset = "0x1204800", VA = "0x11205A00", Slot = "7")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x60049D6")]
    [Address(RVA = "0x1205310", Offset = "0x1204110", VA = "0x11205310", Slot = "8")]
    protected virtual void LateUpdate()
    {
    }

    [Token(Token = "0x60049D7")]
    [Address(RVA = "0x1205C80", Offset = "0x1204A80", VA = "0x11205C80")]
    public SRPG_ListBase()
    {
    }
  }
}
