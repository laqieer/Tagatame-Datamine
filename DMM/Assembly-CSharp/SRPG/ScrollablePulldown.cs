// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollablePulldown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A5C")]
  public class ScrollablePulldown : ScrollablePulldownBase
  {
    [Token(Token = "0x400CE26")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    private GameObject PulldownItemTemplate;

    [Token(Token = "0x600C142")]
    [Address(RVA = "0x8A4400", Offset = "0x8A3200", VA = "0x108A4400", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C143")]
    [Address(RVA = "0x8A42F0", Offset = "0x8A30F0", VA = "0x108A42F0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C144")]
    [Address(RVA = "0x8A3ED0", Offset = "0x8A2CD0", VA = "0x108A3ED0")]
    public PulldownItem AddItem(string label, int value, bool is_lock = false, bool is_reverse = false)
    {
      return (PulldownItem) null;
    }

    [Token(Token = "0x600C145")]
    [Address(RVA = "0x8A3B70", Offset = "0x8A2970", VA = "0x108A3B70")]
    public PulldownItemExpansionPurchase AddExpansionPurchaseItem(
      string label,
      int value,
      bool is_lock = false,
      bool is_period = false,
      string periode_text = "")
    {
      return (PulldownItemExpansionPurchase) null;
    }

    [Token(Token = "0x600C146")]
    [Address(RVA = "0x8A41F0", Offset = "0x8A2FF0", VA = "0x108A41F0")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x600C147")]
    [Address(RVA = "0x5EB590", Offset = "0x5EA390", VA = "0x105EB590")]
    public ScrollablePulldown()
    {
    }
  }
}
