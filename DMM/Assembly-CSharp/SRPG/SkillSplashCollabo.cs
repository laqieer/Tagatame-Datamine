// Decompiled with JetBrains decompiler
// Type: SRPG.SkillSplashCollabo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200112C")]
  [AddComponentMenu("Common/SkillSplashCollabo")]
  public class SkillSplashCollabo : MonoBehaviour
  {
    [Token(Token = "0x4003E87")]
    [FieldOffset(Offset = "0xC")]
    [Description("スプラッシュ表示を閉じるのに使用するトリガーの名前")]
    public string EndTrigger;
    [Token(Token = "0x4003E88")]
    [FieldOffset(Offset = "0x10")]
    [Description("スプラッシュ表示が閉じられた状態のステートの名前、この状態になると先へ進みます")]
    public string EndStateName;
    [Token(Token = "0x4003E89")]
    [FieldOffset(Offset = "0x14")]
    public RawImage[] UnitImages2_main_Images;
    [Token(Token = "0x4003E8A")]
    [FieldOffset(Offset = "0x18")]
    public RawImage[] UnitImages2_sub_Images;
    [Token(Token = "0x4003E8B")]
    [FieldOffset(Offset = "0x1C")]
    public RawImage[] UnitEyeImages_main_Images;
    [Token(Token = "0x4003E8C")]
    [FieldOffset(Offset = "0x20")]
    public RawImage[] UnitEyeImages_sub_Images;
    [Token(Token = "0x4003E8D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x4003E8E")]
    [FieldOffset(Offset = "0x28")]
    private bool mClose;

    [Token(Token = "0x6004962")]
    [Address(RVA = "0x11FB9C0", Offset = "0x11FA7C0", VA = "0x111FB9C0")]
    public void SetCharaImages(
      Texture2D u2_main_tex,
      Texture2D u2_sub_tex,
      Texture2D ue_main_tex,
      Texture2D ue_sub_tex)
    {
    }

    [Token(Token = "0x6004963")]
    [Address(RVA = "0x11FB9B0", Offset = "0x11FA7B0", VA = "0x111FB9B0")]
    public void Close()
    {
    }

    [Token(Token = "0x6004964")]
    [Address(RVA = "0x11FBB20", Offset = "0x11FA920", VA = "0x111FBB20")]
    private void Start()
    {
    }

    [Token(Token = "0x6004965")]
    [Address(RVA = "0x11FBBA0", Offset = "0x11FA9A0", VA = "0x111FBBA0")]
    private void Update()
    {
    }

    [Token(Token = "0x6004966")]
    [Address(RVA = "0x11FBCD0", Offset = "0x11FAAD0", VA = "0x111FBCD0")]
    public SkillSplashCollabo()
    {
    }
  }
}
