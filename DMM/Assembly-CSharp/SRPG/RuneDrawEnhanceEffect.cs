// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEnhanceEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200298A")]
  [AddComponentMenu("UI/Rune/RuneDrawEnhanceEffect")]
  public class RuneDrawEnhanceEffect : MonoBehaviour
  {
    [Token(Token = "0x400C89B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray[] mTitleImage;
    [Token(Token = "0x400C89C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mSwitchObj_success;
    [Token(Token = "0x400C89D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mSwitchObj_miss;
    [Token(Token = "0x400C89E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage mSuccessBg_left;
    [Token(Token = "0x400C89F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RawImage mSuccessBg_right;
    [Token(Token = "0x400C8A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage mMissBg_left;
    [Token(Token = "0x400C8A1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RawImage mMissBg_right;
    [Token(Token = "0x400C8A2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400C8A3")]
    private const string ENHANCE_EFFECT_BG_IMAGE_LEFT = "UI/Rune/RuneBG_005_00";
    [Token(Token = "0x400C8A4")]
    private const string ENHANCE_EFFECT_BG_IMAGE_RIGHT = "UI/Rune/RuneBG_005_01";
    [Token(Token = "0x400C8A5")]
    [FieldOffset(Offset = "0x2C")]
    private readonly string[] AnimatorTrigger;
    [Token(Token = "0x400C8A6")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsEnhanceSuccess;

    [Token(Token = "0x17001983")]
    public bool IsEnhanceSuccess
    {
      [Token(Token = "0x600BC34"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BC35")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC36")]
    [Address(RVA = "0x83E2B0", Offset = "0x83D0B0", VA = "0x1083E2B0")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x600BC37")]
    [Address(RVA = "0x83E5A0", Offset = "0x83D3A0", VA = "0x1083E5A0")]
    public void SetDrawParam(bool is_success)
    {
    }

    [Token(Token = "0x600BC38")]
    [Address(RVA = "0x83E360", Offset = "0x83D160", VA = "0x1083E360")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC39")]
    [Address(RVA = "0x83E1D0", Offset = "0x83CFD0", VA = "0x1083E1D0")]
    private void LoadBgImages(bool is_success)
    {
    }

    [Token(Token = "0x600BC3A")]
    [Address(RVA = "0x83E5C0", Offset = "0x83D3C0", VA = "0x1083E5C0")]
    public RuneDrawEnhanceEffect()
    {
    }

    [Token(Token = "0x200298B")]
    private enum Result
    {
      [Token(Token = "0x400C8A8")] Miss,
      [Token(Token = "0x400C8A9")] Success,
    }
  }
}
