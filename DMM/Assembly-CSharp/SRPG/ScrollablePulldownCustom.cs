// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollablePulldownCustom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A61")]
  public class ScrollablePulldownCustom : ScrollablePulldownBase
  {
    [Token(Token = "0x400CE3E")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public GameObject PulldownItemTemplate;
    [Token(Token = "0x400CE3F")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private bool KeepOpenUp;
    [Token(Token = "0x400CE40")]
    [FieldOffset(Offset = "0xFC")]
    [BitMask]
    public CriticalSections CSMask;
    [Token(Token = "0x400CE41")]
    [FieldOffset(Offset = "0x100")]
    [HeaderBar("▼テキストスクロールの設定")]
    [SerializeField]
    private bool IsOpenResetScrollText;

    [Token(Token = "0x600C167")]
    [Address(RVA = "0x8A36C0", Offset = "0x8A24C0", VA = "0x108A36C0")]
    public new void ClosePulldown(bool se = true)
    {
    }

    [Token(Token = "0x600C168")]
    [Address(RVA = "0x8A3B10", Offset = "0x8A2910", VA = "0x108A3B10", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C169")]
    [Address(RVA = "0x8A3740", Offset = "0x8A2540", VA = "0x108A3740", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C16A")]
    [Address(RVA = "0x8A32B0", Offset = "0x8A20B0", VA = "0x108A32B0")]
    public PulldownItem AddItem(string label, int value, bool is_lock = false)
    {
      return (PulldownItem) null;
    }

    [Token(Token = "0x600C16B")]
    [Address(RVA = "0x8A35C0", Offset = "0x8A23C0", VA = "0x108A35C0")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x600C16C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "42")]
    public override void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C16D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "44")]
    public override void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C16E")]
    [Address(RVA = "0x8A3850", Offset = "0x8A2650", VA = "0x108A3850", Slot = "32")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C16F")]
    [Address(RVA = "0x8A36F0", Offset = "0x8A24F0", VA = "0x108A36F0")]
    private bool IsCriticalSectionActive() => new bool();

    [Token(Token = "0x600C170")]
    [Address(RVA = "0x8A38F0", Offset = "0x8A26F0", VA = "0x108A38F0")]
    public void ResetScrollText()
    {
    }

    [Token(Token = "0x600C171")]
    [Address(RVA = "0x5EB590", Offset = "0x5EA390", VA = "0x105EB590")]
    public ScrollablePulldownCustom()
    {
    }
  }
}
