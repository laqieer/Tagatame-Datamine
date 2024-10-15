// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLearnAbilityWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C6C")]
  [AddComponentMenu("UI/UnitLearnAbilityWindow")]
  public class UnitLearnAbilityWindow : MonoBehaviour
  {
    [Token(Token = "0x400DBF0")]
    [FieldOffset(Offset = "0xC")]
    public List<AbilityData> AbilityList;
    [Token(Token = "0x400DBF1")]
    [FieldOffset(Offset = "0x10")]
    public Transform LearnAbilityParent;
    [Token(Token = "0x400DBF2")]
    [FieldOffset(Offset = "0x14")]
    public GameObject LearnAbilityTemplate;
    [Token(Token = "0x400DBF3")]
    [FieldOffset(Offset = "0x18")]
    public GameObject LearnAbilitySkillTemplate;

    [Token(Token = "0x600CDD5")]
    [Address(RVA = "0x98A4D0", Offset = "0x9892D0", VA = "0x1098A4D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CDD6")]
    [Address(RVA = "0x98A310", Offset = "0x989110", VA = "0x1098A310")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600CDD7")]
    [Address(RVA = "0x98A1D0", Offset = "0x988FD0", VA = "0x1098A1D0")]
    private UnitLearnAbilityElement CreateListItem(Transform parent, AbilityData ability)
    {
      return (UnitLearnAbilityElement) null;
    }

    [Token(Token = "0x600CDD8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitLearnAbilityWindow()
    {
    }
  }
}
