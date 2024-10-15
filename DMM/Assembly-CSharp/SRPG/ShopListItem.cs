// Decompiled with JetBrains decompiler
// Type: SRPG.ShopListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A88")]
  public class ShopListItem : ContentNode
  {
    [Token(Token = "0x400CEF6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button button;

    [Token(Token = "0x600C239")]
    [Address(RVA = "0x8B00D0", Offset = "0x8AEED0", VA = "0x108B00D0", Slot = "18")]
    public virtual void SetData(ShopListItemModel model, Action<ShopListItemModel> onSelectCallback)
    {
    }

    [Token(Token = "0x600C23A")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public ShopListItem()
    {
    }
  }
}
