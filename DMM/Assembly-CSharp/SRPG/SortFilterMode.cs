// Decompiled with JetBrains decompiler
// Type: SRPG.SortFilterMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AEB")]
  [AddComponentMenu("UI/SortFilterMode")]
  public class SortFilterMode : MonoBehaviour, ISortableList
  {
    [Token(Token = "0x400D16E")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Ascending;
    [Token(Token = "0x400D16F")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Descending;
    [Token(Token = "0x400D170")]
    [FieldOffset(Offset = "0x14")]
    public GameObject FilterOn;
    [Token(Token = "0x400D171")]
    [FieldOffset(Offset = "0x18")]
    public GameObject FilterOff;

    [Token(Token = "0x600C426")]
    [Address(RVA = "0x8CD210", Offset = "0x8CC010", VA = "0x108CD210", Slot = "4")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x600C427")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SortFilterMode()
    {
    }
  }
}
