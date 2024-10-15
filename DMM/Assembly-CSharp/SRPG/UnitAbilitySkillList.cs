// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilitySkillList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BB6")]
  [AddComponentMenu("UI/UnitAbilitySkillList")]
  public class UnitAbilitySkillList : MonoBehaviour
  {
    [Token(Token = "0x400D6A7")]
    [FieldOffset(Offset = "0xC")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x400D6A8")]
    [FieldOffset(Offset = "0x10")]
    public ScrollRect ScrollViewRect;
    [Token(Token = "0x400D6A9")]
    [FieldOffset(Offset = "0x14")]
    public UnitAbilitySkillList.SelectSkillEvent OnSelectSkill;
    [Token(Token = "0x400D6AA")]
    [FieldOffset(Offset = "0x18")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x400D6AB")]
    [FieldOffset(Offset = "0x1C")]
    private Unit mUnit;

    [Token(Token = "0x600C8F0")]
    [Address(RVA = "0x91B7B0", Offset = "0x91A5B0", VA = "0x1091B7B0")]
    public void Start()
    {
    }

    [Token(Token = "0x600C8F1")]
    [Address(RVA = "0x91AD90", Offset = "0x919B90", VA = "0x1091AD90")]
    public void Refresh(Unit self)
    {
    }

    [Token(Token = "0x600C8F2")]
    [Address(RVA = "0x91ADC0", Offset = "0x919BC0", VA = "0x1091ADC0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C8F3")]
    [Address(RVA = "0x91B780", Offset = "0x91A580", VA = "0x1091B780")]
    private void SelectSkill(SkillData skill)
    {
    }

    [Token(Token = "0x600C8F4")]
    [Address(RVA = "0x91ACB0", Offset = "0x919AB0", VA = "0x1091ACB0")]
    private void DestroyItems()
    {
    }

    [Token(Token = "0x600C8F5")]
    [Address(RVA = "0x91B890", Offset = "0x91A690", VA = "0x1091B890")]
    public UnitAbilitySkillList()
    {
    }

    [Token(Token = "0x2002BB7")]
    public delegate void SelectSkillEvent(SkillData skill);
  }
}
