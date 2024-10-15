// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLearnSkillWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C6D")]
  [AddComponentMenu("UI/UnitLearnSkillWindow")]
  public class UnitLearnSkillWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DBF4")]
    [FieldOffset(Offset = "0xC")]
    public List<SkillParam> Skills;
    [Token(Token = "0x400DBF5")]
    [FieldOffset(Offset = "0x10")]
    public Transform SkillParent;
    [Token(Token = "0x400DBF6")]
    [FieldOffset(Offset = "0x14")]
    public GameObject SkillTemplate;

    [Token(Token = "0x600CDD9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CDDA")]
    [Address(RVA = "0x98A5A0", Offset = "0x9893A0", VA = "0x1098A5A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CDDB")]
    [Address(RVA = "0x98A610", Offset = "0x989410", VA = "0x1098A610")]
    private void Start()
    {
    }

    [Token(Token = "0x600CDDC")]
    [Address(RVA = "0x98A610", Offset = "0x989410", VA = "0x1098A610")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600CDDD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitLearnSkillWindow()
    {
    }
  }
}
