// Decompiled with JetBrains decompiler
// Type: SRPG.EquipConceptCardSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C8")]
  [AddComponentMenu("UI/ConceptCard/EquipConceptCardSlot")]
  public class EquipConceptCardSlot : GenericSlot
  {
    [Token(Token = "0x4009425")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SRPG_Button Lock;
    [Token(Token = "0x4009426")]
    [FieldOffset(Offset = "0x28")]
    private int m_SlotIndex;
    [Token(Token = "0x4009427")]
    [FieldOffset(Offset = "0x2C")]
    private ConceptCardData m_ConceptCardData;

    [Token(Token = "0x17001423")]
    public int slotIndex
    {
      [Token(Token = "0x6008E90"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x6008E91"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
    }

    [Token(Token = "0x17001424")]
    public ConceptCardData conceptCardData
    {
      [Token(Token = "0x6008E92"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (ConceptCardData) null;
      }
      [Token(Token = "0x6008E93"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x6008E94")]
    [Address(RVA = "0x51C770", Offset = "0x51B570", VA = "0x1051C770")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008E95")]
    [Address(RVA = "0x51C890", Offset = "0x51B690", VA = "0x1051C890")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008E96")]
    [Address(RVA = "0x51C8D0", Offset = "0x51B6D0", VA = "0x1051C8D0")]
    private void OnLockClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008E97")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public EquipConceptCardSlot()
    {
    }
  }
}
