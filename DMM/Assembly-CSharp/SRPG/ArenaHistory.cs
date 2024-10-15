// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD6")]
  [AddComponentMenu("UI/ArenaHistory")]
  public class ArenaHistory : SRPG_ListBase
  {
    [Token(Token = "0x40086FA")]
    [FieldOffset(Offset = "0x20")]
    public ListItemEvents ListItem_Normal;
    [Token(Token = "0x40086FB")]
    [FieldOffset(Offset = "0x24")]
    public ListItemEvents ListItem_Self;
    [Token(Token = "0x40086FC")]
    [FieldOffset(Offset = "0x28")]
    public GameObject DetailWindow;

    [Token(Token = "0x600831E")]
    [Address(RVA = "0x438CD0", Offset = "0x437AD0", VA = "0x10438CD0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600831F")]
    [Address(RVA = "0x438A70", Offset = "0x437870", VA = "0x10438A70")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008320")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x6008321")]
    [Address(RVA = "0x438970", Offset = "0x437770", VA = "0x10438970")]
    private void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x6008322")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public ArenaHistory()
    {
    }
  }
}
