// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSlotsEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200224D")]
  [AddComponentMenu("UI/ConceptCardSlotsEx")]
  public class ConceptCardSlotsEx : MonoBehaviour
  {
    [Token(Token = "0x4009831")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string CONCEPT_CARD_EQUIP_WINDOW_PREFAB_PATH;
    [Token(Token = "0x4009832")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenericSlotEx[] mConceptCardSlots;
    [Token(Token = "0x4009833")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardIconEx[] mConceptCardIcons;
    [Token(Token = "0x4009834")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private UnitToolTipWindowEx mUnitToolTipWindow;
    [Token(Token = "0x4009835")]
    [FieldOffset(Offset = "0x18")]
    private GameObject mConceptCardSelector;
    [Token(Token = "0x4009836")]
    [FieldOffset(Offset = "0x1C")]
    private ConceptCardSlotsExModel mModel;

    [Token(Token = "0x600922F")]
    [Address(RVA = "0x557180", Offset = "0x555F80", VA = "0x10557180")]
    private void Start()
    {
    }

    [Token(Token = "0x6009230")]
    [Address(RVA = "0x557180", Offset = "0x555F80", VA = "0x10557180")]
    private void InitializeSlots()
    {
    }

    [Token(Token = "0x6009231")]
    [Address(RVA = "0x5574D0", Offset = "0x5562D0", VA = "0x105574D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009232")]
    [Address(RVA = "0x5572B0", Offset = "0x5560B0", VA = "0x105572B0")]
    public void Initialize(UnitData unitData, bool editMode, bool isHide = false)
    {
    }

    [Token(Token = "0x6009233")]
    [Address(RVA = "0x557BB0", Offset = "0x5569B0", VA = "0x10557BB0")]
    public void SetupModel(UnitData unitData, bool editMode, bool isHide = false)
    {
    }

    [Token(Token = "0x6009234")]
    [Address(RVA = "0x557AF0", Offset = "0x5568F0", VA = "0x10557AF0")]
    public void Refresh(bool editMode)
    {
    }

    [Token(Token = "0x6009235")]
    [Address(RVA = "0x5579A0", Offset = "0x5567A0", VA = "0x105579A0")]
    public void Refresh(UnitData unitData, bool editMode)
    {
    }

    [Token(Token = "0x6009236")]
    [Address(RVA = "0x557830", Offset = "0x556630", VA = "0x10557830")]
    private void RefreshSlots(
      GenericSlotEx slot,
      ConceptCardIconEx icon,
      ConceptCardData card,
      bool is_locked,
      bool editMode)
    {
    }

    [Token(Token = "0x6009237")]
    [Address(RVA = "0x557520", Offset = "0x556320", VA = "0x10557520")]
    private void OnEquipCardSlot(GenericSlotEx slot, bool interactable)
    {
    }

    [Token(Token = "0x6009238")]
    [Address(RVA = "0x557460", Offset = "0x556260", VA = "0x10557460")]
    private void OnCloseEquipConceptCardWindow()
    {
    }

    [Token(Token = "0x6009239")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSlotsEx()
    {
    }

    [Token(Token = "0x600923A")]
    [Address(RVA = "0x557C50", Offset = "0x556A50", VA = "0x10557C50")]
    static ConceptCardSlotsEx()
    {
    }
  }
}
