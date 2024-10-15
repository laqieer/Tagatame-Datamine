// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLearnAbilityElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C6B")]
  [AddComponentMenu("UI/UnitLearnAbilityElement")]
  public class UnitLearnAbilityElement : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DBED")]
    [FieldOffset(Offset = "0xC")]
    public Transform SkillParent;
    [Token(Token = "0x400DBEE")]
    [FieldOffset(Offset = "0x10")]
    public GameObject SkillTemplate;
    [Token(Token = "0x400DBEF")]
    [FieldOffset(Offset = "0x14")]
    private List<GameObject> mSkills;

    [Token(Token = "0x600CDD1")]
    [Address(RVA = "0x98A160", Offset = "0x988F60", VA = "0x1098A160")]
    public void Start()
    {
    }

    [Token(Token = "0x600CDD2")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CDD3")]
    [Address(RVA = "0x989E90", Offset = "0x988C90", VA = "0x10989E90")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CDD4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitLearnAbilityElement()
    {
    }
  }
}
