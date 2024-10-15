// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_ToggleButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AFA")]
  [AddComponentMenu("UI/Toggle Button (SRPG)")]
  public class SRPG_ToggleButton : SRPG_Button
  {
    [Token(Token = "0x400D1B9")]
    [FieldOffset(Offset = "0xC0")]
    private bool mIsOn;
    [Token(Token = "0x400D1BA")]
    [FieldOffset(Offset = "0xC1")]
    public bool AutoToggle;

    [Token(Token = "0x17001A2C")]
    public bool IsOn
    {
      [Token(Token = "0x600C4AB"), Address(RVA = "0x8D1B30", Offset = "0x8D0930", VA = "0x108D1B30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C4AC"), Address(RVA = "0x8D1B40", Offset = "0x8D0940", VA = "0x108D1B40")] set
      {
      }
    }

    [Token(Token = "0x600C4AD")]
    [Address(RVA = "0x8D1A50", Offset = "0x8D0850", VA = "0x108D1A50", Slot = "26")]
    protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
    {
    }

    [Token(Token = "0x600C4AE")]
    [Address(RVA = "0x8D1AA0", Offset = "0x8D08A0", VA = "0x108D1AA0", Slot = "41")]
    public override void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C4AF")]
    [Address(RVA = "0x8D1B20", Offset = "0x8D0920", VA = "0x108D1B20")]
    public SRPG_ToggleButton()
    {
    }
  }
}
