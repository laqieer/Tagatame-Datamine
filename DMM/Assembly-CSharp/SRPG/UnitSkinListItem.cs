// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSkinListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CF1")]
  public class UnitSkinListItem : ListItemEvents
  {
    [Token(Token = "0x400DF6C")]
    [FieldOffset(Offset = "0x38")]
    public ListItemEvents.ListItemEvent OnSelectAll;
    [Token(Token = "0x400DF6D")]
    [FieldOffset(Offset = "0x3C")]
    public ListItemEvents.ListItemEvent OnRemoveAll;
    [Token(Token = "0x400DF6E")]
    [FieldOffset(Offset = "0x40")]
    public SRPG_Button Button;
    [Token(Token = "0x400DF6F")]
    [FieldOffset(Offset = "0x44")]
    public GameObject Lock;

    [Token(Token = "0x600D12A")]
    [Address(RVA = "0x9C2100", Offset = "0x9C0F00", VA = "0x109C2100")]
    public void SelectAll()
    {
    }

    [Token(Token = "0x600D12B")]
    [Address(RVA = "0x916010", Offset = "0x914E10", VA = "0x10916010")]
    public void RemoveAll()
    {
    }

    [Token(Token = "0x600D12C")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public UnitSkinListItem()
    {
    }
  }
}
