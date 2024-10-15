// Decompiled with JetBrains decompiler
// Type: SRPG.FilterDispatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B4")]
  [AddComponentMenu("UI/FilterDispatcher")]
  public class FilterDispatcher : MonoBehaviour, ISortableList
  {
    [Token(Token = "0x400A144")]
    [FieldOffset(Offset = "0xC")]
    public GameObject[] Targets;

    [Token(Token = "0x6009A86")]
    [Address(RVA = "0x5EA470", Offset = "0x5E9270", VA = "0x105EA470", Slot = "4")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x6009A87")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public FilterDispatcher()
    {
    }
  }
}
