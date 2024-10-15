// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002248")]
  [AddComponentMenu("UI/ConceptCardSlot")]
  public class ConceptCardSlot : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4009820")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Disabled;
    [Token(Token = "0x4009821")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(10f)]
    private GameObject OverlayImage;
    [Token(Token = "0x4009822")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject EnableGroupEffect;
    [Token(Token = "0x4009823")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject SettableIcon;
    [Token(Token = "0x4009824")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData LeaderUnit;

    [Token(Token = "0x6009212")]
    [Address(RVA = "0x556C30", Offset = "0x555A30", VA = "0x10556C30")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009213")]
    [Address(RVA = "0x556CB0", Offset = "0x555AB0", VA = "0x10556CB0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6009214")]
    [Address(RVA = "0x556C40", Offset = "0x555A40", VA = "0x10556C40")]
    private void SetSlotDisabled()
    {
    }

    [Token(Token = "0x6009215")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void SetLeaderUnit(UnitData leader)
    {
    }

    [Token(Token = "0x6009216")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSlot()
    {
    }
  }
}
