// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardIconBattleResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002213")]
  [AddComponentMenu("UI/ConceptCardIconBattleResult")]
  public class ConceptCardIconBattleResult : ConceptCardIcon
  {
    [Token(Token = "0x4009695")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject UnitBody;
    [Token(Token = "0x4009696")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private GameObject BlackCover;
    [Token(Token = "0x4009697")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject ConceptCardBody;
    [Token(Token = "0x4009698")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    private Animator TrustUpAnimator;

    [Token(Token = "0x6009085")]
    [Address(RVA = "0x539600", Offset = "0x538400", VA = "0x10539600")]
    public void ShowStartAnimation(bool isTrustUp)
    {
    }

    [Token(Token = "0x6009086")]
    [Address(RVA = "0x539530", Offset = "0x538330", VA = "0x10539530")]
    public void ShowAnimationAfter()
    {
    }

    [Token(Token = "0x6009087")]
    [Address(RVA = "0x539720", Offset = "0x538520", VA = "0x10539720")]
    public void StartTrustUpAnimation()
    {
    }

    [Token(Token = "0x6009088")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardIconBattleResult()
    {
    }
  }
}
