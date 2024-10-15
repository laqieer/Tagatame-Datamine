// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraLearnSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B30")]
  [AddComponentMenu("UI/TobiraLearnSkill")]
  public class TobiraLearnSkill : MonoBehaviour
  {
    [Token(Token = "0x400D2DF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_LearnSkillName;
    [Token(Token = "0x400D2E0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_LearnSkillEffect;

    [Token(Token = "0x600C5A9")]
    [Address(RVA = "0x8E3320", Offset = "0x8E2120", VA = "0x108E3320")]
    public void Setup(AbilityData newAbility)
    {
    }

    [Token(Token = "0x600C5AA")]
    [Address(RVA = "0x8E3280", Offset = "0x8E2080", VA = "0x108E3280")]
    public void Setup(SkillData skill)
    {
    }

    [Token(Token = "0x600C5AB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TobiraLearnSkill()
    {
    }
  }
}
