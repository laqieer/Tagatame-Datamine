// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalEquipSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002283")]
  public class CrystalEquipSlot : GenericSlot
  {
    [Token(Token = "0x4009927")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SRPG_Button Lock;
    [Token(Token = "0x4009928")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CrystalIcon Icon;
    [Token(Token = "0x4009929")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject Plus;

    [Token(Token = "0x170014B6")]
    public CrystalData.ESlotIndex SlotIndex
    {
      [Token(Token = "0x6009377"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new CrystalData.ESlotIndex();
      }
      [Token(Token = "0x6009378"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] private set
      {
      }
    }

    [Token(Token = "0x6009379")]
    [Address(RVA = "0x569BB0", Offset = "0x5689B0", VA = "0x10569BB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600937A")]
    [Address(RVA = "0x569CF0", Offset = "0x568AF0", VA = "0x10569CF0")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600937B")]
    [Address(RVA = "0x51C8D0", Offset = "0x51B6D0", VA = "0x1051C8D0")]
    private void OnLockClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600937C")]
    [Address(RVA = "0x569DE0", Offset = "0x568BE0", VA = "0x10569DE0")]
    public void SetPlusImage(bool isVisible)
    {
    }

    [Token(Token = "0x600937D")]
    [Address(RVA = "0x569CD0", Offset = "0x568AD0", VA = "0x10569CD0")]
    public CrystalData GetCrystalData() => (CrystalData) null;

    [Token(Token = "0x600937E")]
    [Address(RVA = "0x569D30", Offset = "0x568B30", VA = "0x10569D30")]
    public void SetCrystalData(int _slot_index, CrystalData _data)
    {
    }

    [Token(Token = "0x600937F")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public CrystalEquipSlot()
    {
    }
  }
}
