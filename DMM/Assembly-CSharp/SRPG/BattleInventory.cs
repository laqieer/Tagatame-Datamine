// Decompiled with JetBrains decompiler
// Type: SRPG.BattleInventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002080")]
  [AddComponentMenu("UI/BattleInventory")]
  public class BattleInventory : MonoBehaviour
  {
    [Token(Token = "0x4008C03")]
    [FieldOffset(Offset = "0xC")]
    public BattleInventory.SelectEvent OnSelectItem;
    [Token(Token = "0x4008C04")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform ListParent;
    [Token(Token = "0x4008C05")]
    [FieldOffset(Offset = "0x14")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x4008C06")]
    [FieldOffset(Offset = "0x18")]
    public ListItemEvents EmptySlotTemplate;
    [Token(Token = "0x4008C07")]
    [FieldOffset(Offset = "0x1C")]
    public bool DisplayEmptySlots;
    [Token(Token = "0x4008C08")]
    [FieldOffset(Offset = "0x20")]
    public GameObject EmptyLabel;
    [Token(Token = "0x4008C09")]
    [FieldOffset(Offset = "0x24")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x4008C0A")]
    [FieldOffset(Offset = "0x28")]
    public ItemData[] mInventory;

    [Token(Token = "0x6008742")]
    [Address(RVA = "0x4888C0", Offset = "0x4876C0", VA = "0x104888C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008743")]
    [Address(RVA = "0x4882F0", Offset = "0x4870F0", VA = "0x104882F0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008744")]
    [Address(RVA = "0x488A90", Offset = "0x487890", VA = "0x10488A90")]
    public BattleInventory()
    {
    }

    [Token(Token = "0x2002081")]
    public delegate void SelectEvent(ItemData item);
  }
}
