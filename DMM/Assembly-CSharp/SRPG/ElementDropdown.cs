// Decompiled with JetBrains decompiler
// Type: SRPG.ElementDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200233B")]
  public class ElementDropdown : Pulldown
  {
    [Token(Token = "0x4009DD1")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    private Image ElementIcon;

    [Token(Token = "0x60097CB")]
    [Address(RVA = "0x5A9700", Offset = "0x5A8500", VA = "0x105A9700", Slot = "46")]
    protected override void UpdateSelection()
    {
    }

    [Token(Token = "0x60097CC")]
    [Address(RVA = "0x5A9670", Offset = "0x5A8470", VA = "0x105A9670", Slot = "42")]
    protected override PulldownItem SetupPulldownItem(GameObject itemObject) => (PulldownItem) null;

    [Token(Token = "0x60097CD")]
    [Address(RVA = "0x5A95A0", Offset = "0x5A83A0", VA = "0x105A95A0")]
    public PulldownItem AddItem(string label, Sprite sprite, int value) => (PulldownItem) null;

    [Token(Token = "0x60097CE")]
    [Address(RVA = "0x5A9800", Offset = "0x5A8600", VA = "0x105A9800")]
    public ElementDropdown()
    {
    }
  }
}
