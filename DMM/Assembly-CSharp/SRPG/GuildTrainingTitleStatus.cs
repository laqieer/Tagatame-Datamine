// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingTitleStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002541")]
  public class GuildTrainingTitleStatus : MonoBehaviour
  {
    [Token(Token = "0x400AABF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private CanvasGroup mTrainingNowEff;
    [Token(Token = "0x400AAC0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CanvasGroup mTrainingEnergyLack;
    [Token(Token = "0x400AAC1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Range(0.001f, 100f)]
    private float mTitleLerpTime;
    [Token(Token = "0x400AAC2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400AAC3")]
    [FieldOffset(Offset = "0x1C")]
    private bool mInitialized;
    [Token(Token = "0x400AAC4")]
    [FieldOffset(Offset = "0x1D")]
    private bool mIsTitleEffEnable;
    [Token(Token = "0x400AAC5")]
    [FieldOffset(Offset = "0x20")]
    private float mTitleLerpStartTime;
    [Token(Token = "0x400AAC6")]
    [FieldOffset(Offset = "0x24")]
    private GuildTrainingTitleStatus.eTrainingState mEState;
    [Token(Token = "0x400AAC7")]
    [FieldOffset(Offset = "0x28")]
    private GuildTrainingTitleStatus.eTrainingState mENextState;
    [Token(Token = "0x400AAC8")]
    [FieldOffset(Offset = "0x2C")]
    private float mStartNowEffAlpha;
    [Token(Token = "0x400AAC9")]
    [FieldOffset(Offset = "0x30")]
    private float mStartEnergyLackAlpha;

    [Token(Token = "0x600A443")]
    [Address(RVA = "0x662300", Offset = "0x661100", VA = "0x10662300")]
    public void Initialize(bool is_enable_energy, bool is_enable_training)
    {
    }

    [Token(Token = "0x600A444")]
    [Address(RVA = "0x662440", Offset = "0x661240", VA = "0x10662440")]
    public void SetNewState(bool is_enable_energy, bool is_enable_training)
    {
    }

    [Token(Token = "0x600A445")]
    [Address(RVA = "0x6620E0", Offset = "0x660EE0", VA = "0x106620E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A446")]
    [Address(RVA = "0x662580", Offset = "0x661380", VA = "0x10662580")]
    private void Update()
    {
    }

    [Token(Token = "0x600A447")]
    [Address(RVA = "0x662290", Offset = "0x661090", VA = "0x10662290")]
    private void Fade(float diff)
    {
    }

    [Token(Token = "0x600A448")]
    [Address(RVA = "0x6621A0", Offset = "0x660FA0", VA = "0x106621A0")]
    private void CanvasGroupFade(
      CanvasGroup canvas_group,
      bool isState,
      float start_alpha,
      float diff)
    {
    }

    [Token(Token = "0x600A449")]
    [Address(RVA = "0x662760", Offset = "0x661560", VA = "0x10662760")]
    public GuildTrainingTitleStatus()
    {
    }

    [Token(Token = "0x2002542")]
    private enum eTrainingState
    {
      [Token(Token = "0x400AACB")] NONE,
      [Token(Token = "0x400AACC")] TRAINING_NOW,
      [Token(Token = "0x400AACD")] ENERGY_LACK,
      [Token(Token = "0x400AACE")] ALL_OFF,
    }
  }
}
