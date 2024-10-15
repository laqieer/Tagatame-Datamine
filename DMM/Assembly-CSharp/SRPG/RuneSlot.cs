// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029EC")]
  [AddComponentMenu("UI/Rune/RuneSlot")]
  public class RuneSlot : MonoBehaviour
  {
    [Token(Token = "0x400CBAC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mSelectedGO;
    [Token(Token = "0x400CBAD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mSlotNumberImageArray;
    [Token(Token = "0x400CBAE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mEquipGO;
    [Token(Token = "0x400CBAF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mNoEquipGO;
    [Token(Token = "0x400CBB0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400CBB1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mEquipEffect;
    [Token(Token = "0x400CBB2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool mIsCopy;
    [Token(Token = "0x400CBB3")]
    [FieldOffset(Offset = "0x28")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400CBB4")]
    [FieldOffset(Offset = "0x2C")]
    private RuneSlotIndex mSlotIndex;

    [Token(Token = "0x170019BD")]
    public BindRuneData RuneData
    {
      [Token(Token = "0x600BF0E"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (BindRuneData) null;
      }
    }

    [Token(Token = "0x600BF0F")]
    [Address(RVA = "0x8670B0", Offset = "0x865EB0", VA = "0x108670B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BF10")]
    [Address(RVA = "0x867260", Offset = "0x866060", VA = "0x10867260")]
    public void Initialize(BindRuneData rune_data, RuneSlotIndex slot_index, bool is_play_effect = true)
    {
    }

    [Token(Token = "0x600BF11")]
    [Address(RVA = "0x867550", Offset = "0x866350", VA = "0x10867550")]
    private void Refresh(bool is_play_effect = true)
    {
    }

    [Token(Token = "0x600BF12")]
    [Address(RVA = "0x8676A0", Offset = "0x8664A0", VA = "0x108676A0")]
    public void Selected(bool is_selected)
    {
    }

    [Token(Token = "0x600BF13")]
    [Address(RVA = "0x867510", Offset = "0x866310", VA = "0x10867510")]
    private void RefreshSlotNumber(RuneSlotIndex slot_index)
    {
    }

    [Token(Token = "0x600BF14")]
    [Address(RVA = "0x8674C0", Offset = "0x8662C0", VA = "0x108674C0")]
    private void RefreshSlotEquip(bool is_equip)
    {
    }

    [Token(Token = "0x600BF15")]
    [Address(RVA = "0x867410", Offset = "0x866210", VA = "0x10867410")]
    private void PlayEquipEffect()
    {
    }

    [Token(Token = "0x600BF16")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneSlot()
    {
    }
  }
}
