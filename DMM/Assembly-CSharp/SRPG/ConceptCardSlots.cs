// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSlots
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200224B")]
  [AddComponentMenu("UI/ConceptCardSlots")]
  public class ConceptCardSlots : MonoBehaviour
  {
    [Token(Token = "0x4009828")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string CONCEPT_CARD_EQUIP_WINDOW_PREFAB_PATH;
    [Token(Token = "0x4009829")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenericSlot[] mConceptCardSlots;
    [Token(Token = "0x400982A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardIcon[] mConceptCardIcons;
    [Token(Token = "0x400982B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mToolTipRoot;
    [Token(Token = "0x400982C")]
    [FieldOffset(Offset = "0x18")]
    private UnitData mUnit;
    [Token(Token = "0x400982D")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsEditMode;
    [Token(Token = "0x400982E")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mConceptCardSelector;

    [Token(Token = "0x6009223")]
    [Address(RVA = "0x557CA0", Offset = "0x556AA0", VA = "0x10557CA0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009224")]
    [Address(RVA = "0x557CA0", Offset = "0x556AA0", VA = "0x10557CA0")]
    private void InitializeSlots()
    {
    }

    [Token(Token = "0x6009225")]
    [Address(RVA = "0x558000", Offset = "0x556E00", VA = "0x10558000")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009226")]
    [Address(RVA = "0x558470", Offset = "0x557270", VA = "0x10558470")]
    public void Refresh(bool editMode)
    {
    }

    [Token(Token = "0x6009227")]
    [Address(RVA = "0x558340", Offset = "0x557140", VA = "0x10558340")]
    private void RefreshSlots(
      GenericSlot slot,
      ConceptCardIcon icon,
      ConceptCardData card,
      bool is_locked,
      bool editMode)
    {
    }

    [Token(Token = "0x6009228")]
    [Address(RVA = "0x558050", Offset = "0x556E50", VA = "0x10558050")]
    private void OnEquipCardSlot(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x6009229")]
    [Address(RVA = "0x557DC0", Offset = "0x556BC0", VA = "0x10557DC0")]
    private void OnCloseEquipConceptCardWindow()
    {
    }

    [Token(Token = "0x600922A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSlots()
    {
    }

    [Token(Token = "0x600922B")]
    [Address(RVA = "0x558610", Offset = "0x557410", VA = "0x10558610")]
    static ConceptCardSlots()
    {
    }
  }
}
