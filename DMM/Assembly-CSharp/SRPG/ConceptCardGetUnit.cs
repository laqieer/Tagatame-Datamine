// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardGetUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200220F")]
  [AddComponentMenu("UI/ConceptCardGetUnit")]
  [FlowNode.Pin(100, "ユニットのレアリティ再設定完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "ユニットのレアリティ再設定", FlowNode.PinTypes.Input, 0)]
  public class ConceptCardGetUnit : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400965F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Animator m_ConceptCardAnimator;
    [Token(Token = "0x4009660")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Animator m_UnitAnimator;
    [Token(Token = "0x4009661")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RawImage m_ConceptCardImage;
    [Token(Token = "0x4009662")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray m_ConceptCardFrame;
    [Token(Token = "0x4009663")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RawImage m_UnitImage;
    [Token(Token = "0x4009664")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage m_UnitBlurImage;
    [Token(Token = "0x4009665")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text m_UnitTextDescription;
    [Token(Token = "0x4009666")]
    [FieldOffset(Offset = "0x28")]
    private int m_UnitRarity;

    [Token(Token = "0x17001466")]
    private AnimatorStateInfo animatorStateInfo
    {
      [Token(Token = "0x6009053"), Address(RVA = "0x5394E0", Offset = "0x5382E0", VA = "0x105394E0")] get
      {
        return new AnimatorStateInfo();
      }
    }

    [Token(Token = "0x6009054")]
    [Address(RVA = "0x539400", Offset = "0x538200", VA = "0x10539400")]
    public static LoadRequest StartLoadPrefab() => (LoadRequest) null;

    [Token(Token = "0x6009055")]
    [Address(RVA = "0x538EA0", Offset = "0x537CA0", VA = "0x10538EA0")]
    public void Setup(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x6009056")]
    [Address(RVA = "0x539470", Offset = "0x538270", VA = "0x10539470")]
    private IEnumerator WaitConceptCardEffectEnd() => (IEnumerator) null;

    [Token(Token = "0x6009057")]
    [Address(RVA = "0x538D40", Offset = "0x537B40", VA = "0x10538D40")]
    private void SetSummonAnimationType(ConceptCardGetUnit.SummonAnimationType type)
    {
    }

    [Token(Token = "0x6009058")]
    [Address(RVA = "0x538CC0", Offset = "0x537AC0", VA = "0x10538CC0")]
    private void SetConceptCardRarity(int value)
    {
    }

    [Token(Token = "0x6009059")]
    [Address(RVA = "0x538E20", Offset = "0x537C20", VA = "0x10538E20")]
    private void SetUnitRarity(int value)
    {
    }

    [Token(Token = "0x600905A")]
    [Address(RVA = "0x538BB0", Offset = "0x5379B0", VA = "0x10538BB0")]
    private void ResetConceptCardAnimationState()
    {
    }

    [Token(Token = "0x600905B")]
    [Address(RVA = "0x538B80", Offset = "0x537980", VA = "0x10538B80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600905C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardGetUnit()
    {
    }

    [Token(Token = "0x2002210")]
    private enum SummonAnimationType
    {
      [Token(Token = "0x4009668")] Shard,
      [Token(Token = "0x4009669")] Item,
      [Token(Token = "0x400966A")] Card,
    }
  }
}
