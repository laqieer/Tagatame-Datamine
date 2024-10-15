// Decompiled with JetBrains decompiler
// Type: SRPG.SupportElementList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B0A")]
  [AddComponentMenu("UI/SupportElementList")]
  public class SupportElementList : MonoBehaviour
  {
    [Token(Token = "0x400D20C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string CARDLIST_WINDOW_PATH;
    [Token(Token = "0x400D20D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] m_SupportUnits;
    [Token(Token = "0x400D20E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GenericSlot[] mConceptCards;
    [Token(Token = "0x400D20F")]
    [FieldOffset(Offset = "0x18")]
    private GameObject mCardSelectWindow;

    [Token(Token = "0x600C4FE")]
    [Address(RVA = "0x8D97B0", Offset = "0x8D85B0", VA = "0x108D97B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C4FF")]
    [Address(RVA = "0x8D98C0", Offset = "0x8D86C0", VA = "0x108D98C0")]
    public void Clear()
    {
    }

    [Token(Token = "0x600C500")]
    [Address(RVA = "0x8D9D70", Offset = "0x8D8B70", VA = "0x108D9D70")]
    public void Refresh(int element, UnitData unit)
    {
    }

    [Token(Token = "0x600C501")]
    [Address(RVA = "0x8DA2C0", Offset = "0x8D90C0", VA = "0x108DA2C0")]
    public void Refresh(long[] uniqs)
    {
    }

    [Token(Token = "0x600C502")]
    [Address(RVA = "0x8D9BB0", Offset = "0x8D89B0", VA = "0x108D9BB0")]
    public void Refresh(UnitData[] units)
    {
    }

    [Token(Token = "0x600C503")]
    [Address(RVA = "0x8D9930", Offset = "0x8D8730", VA = "0x108D9930")]
    private void OnCardSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600C504")]
    [Address(RVA = "0x8DA4C0", Offset = "0x8D92C0", VA = "0x108DA4C0")]
    public SupportElementList()
    {
    }
  }
}
