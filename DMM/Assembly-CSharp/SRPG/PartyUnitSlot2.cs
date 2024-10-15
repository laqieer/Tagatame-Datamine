// Decompiled with JetBrains decompiler
// Type: SRPG.PartyUnitSlot2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027CB")]
  [AddComponentMenu("UI/PartyUnitSlot2")]
  public class PartyUnitSlot2 : MonoBehaviour
  {
    [Token(Token = "0x400BC8A")]
    [FieldOffset(Offset = "0xC")]
    public PartyUnitSlot2.SelectEvent OnSelect;
    [Token(Token = "0x400BC8B")]
    [FieldOffset(Offset = "0x10")]
    public SRPG_Button SelectButton;
    [Token(Token = "0x400BC8C")]
    [FieldOffset(Offset = "0x14")]
    public GameObject[] HideIfEmpty;
    [Token(Token = "0x400BC8D")]
    [FieldOffset(Offset = "0x18")]
    public RectTransform Empty;
    [Token(Token = "0x400BC8E")]
    [FieldOffset(Offset = "0x1C")]
    public RectTransform NonEmpty;
    [Token(Token = "0x400BC8F")]
    [FieldOffset(Offset = "0x20")]
    private UnitData mUnit;

    [Token(Token = "0x600B2DA")]
    [Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x107AE540")]
    private void Awake()
    {
    }

    [Token(Token = "0x1700189D")]
    public UnitData Unit
    {
      [Token(Token = "0x600B2DB"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x600B2DC")]
    [Address(RVA = "0x7AE5F0", Offset = "0x7AD3F0", VA = "0x107AE5F0")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B2DD")]
    [Address(RVA = "0x7AE640", Offset = "0x7AD440", VA = "0x107AE640")]
    public void SetUnitData(UnitData unit)
    {
    }

    [Token(Token = "0x600B2DE")]
    [Address(RVA = "0x7AE840", Offset = "0x7AD640", VA = "0x107AE840")]
    public PartyUnitSlot2()
    {
    }

    [Token(Token = "0x20027CC")]
    public delegate void SelectEvent(PartyUnitSlot2 slot);
  }
}
