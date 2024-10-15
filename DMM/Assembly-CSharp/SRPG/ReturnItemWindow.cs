// Decompiled with JetBrains decompiler
// Type: SRPG.ReturnItemWindow
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
  [Token(Token = "0x200294D")]
  [AddComponentMenu("UI/ReturnItemWindow")]
  public class ReturnItemWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C704")]
    [FieldOffset(Offset = "0xC")]
    public Transform ItemLayout;
    [Token(Token = "0x400C705")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C706")]
    [FieldOffset(Offset = "0x14")]
    public Text Title;
    [Token(Token = "0x400C707")]
    [FieldOffset(Offset = "0x18")]
    public List<ItemData> ReturnItems;

    [Token(Token = "0x600BAD0")]
    [Address(RVA = "0x8246B0", Offset = "0x8234B0", VA = "0x108246B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAD1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BAD2")]
    [Address(RVA = "0x824850", Offset = "0x823650", VA = "0x10824850")]
    private void Start()
    {
    }

    [Token(Token = "0x600BAD3")]
    [Address(RVA = "0x8246D0", Offset = "0x8234D0", VA = "0x108246D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BAD4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ReturnItemWindow()
    {
    }
  }
}
