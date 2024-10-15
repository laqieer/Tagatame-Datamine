// Decompiled with JetBrains decompiler
// Type: SRPG.UnitToolTipWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D21")]
  [AddComponentMenu("UI/UnitToolTipWindow")]
  public class UnitToolTipWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E0CB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public string PATH_RUNE_INVENTORY_WINDOW;
    [Token(Token = "0x400E0CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public GameObject mRuneButton;
    [Token(Token = "0x400E0CD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public GameObject mAutoSkillButton;
    [Token(Token = "0x400E0CE")]
    [FieldOffset(Offset = "0x18")]
    private RuneInventory mRuneInventoryWindow;
    [Token(Token = "0x400E0CF")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData mUnit;

    [Token(Token = "0x600D235")]
    [Address(RVA = "0x9D58A0", Offset = "0x9D46A0", VA = "0x109D58A0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600D236")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x17001B94")]
    public RuneInventory RuneInventoryWindow
    {
      [Token(Token = "0x600D237"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
      [Token(Token = "0x600D238"), Address(RVA = "0x9D6240", Offset = "0x9D5040", VA = "0x109D6240")] get
      {
        return (RuneInventory) null;
      }
    }

    [Token(Token = "0x600D239")]
    [Address(RVA = "0x9D5EF0", Offset = "0x9D4CF0", VA = "0x109D5EF0")]
    public void SetVisibleAutoSkillButton(bool visible)
    {
    }

    [Token(Token = "0x600D23A")]
    [Address(RVA = "0x9D5D90", Offset = "0x9D4B90", VA = "0x109D5D90")]
    public void SetIntaractableAutoSkillButton(bool intaractable)
    {
    }

    [Token(Token = "0x600D23B")]
    [Address(RVA = "0x9D5FE0", Offset = "0x9D4DE0", VA = "0x109D5FE0")]
    public void SetVisibleRuneButton(bool visible)
    {
    }

    [Token(Token = "0x600D23C")]
    [Address(RVA = "0x9D5DE0", Offset = "0x9D4BE0", VA = "0x109D5DE0")]
    public void SetIntaractableRuneButton(bool intaractable)
    {
    }

    [Token(Token = "0x600D23D")]
    [Address(RVA = "0x9D5B90", Offset = "0x9D4990", VA = "0x109D5B90")]
    public void OnSelectRune()
    {
    }

    [Token(Token = "0x600D23E")]
    [Address(RVA = "0x9D5970", Offset = "0x9D4770", VA = "0x109D5970")]
    private void OnCloseRuneInventoryWindow()
    {
    }

    [Token(Token = "0x600D23F")]
    [Address(RVA = "0x9D61E0", Offset = "0x9D4FE0", VA = "0x109D61E0")]
    public UnitToolTipWindow()
    {
    }
  }
}
