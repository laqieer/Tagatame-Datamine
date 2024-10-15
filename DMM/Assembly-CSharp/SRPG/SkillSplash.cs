// Decompiled with JetBrains decompiler
// Type: SRPG.SkillSplash
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200112B")]
  [AddComponentMenu("Common/SkillSplash")]
  public class SkillSplash : MonoBehaviour
  {
    [Token(Token = "0x4003E80")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x4003E81")]
    [FieldOffset(Offset = "0x10")]
    public bool NoLoop;
    [Token(Token = "0x4003E82")]
    [FieldOffset(Offset = "0x14")]
    [Description("スプラッシュ表示を閉じるのに使用するトリガーの名前")]
    public string EndTrigger;
    [Token(Token = "0x4003E83")]
    [FieldOffset(Offset = "0x18")]
    [Description("スプラッシュ表示が閉じられた状態のステートの名前、この状態になると先へ進みます")]
    public string EndStateName;
    [Token(Token = "0x4003E84")]
    [FieldOffset(Offset = "0x1C")]
    public RawImage[] Chara_01_Images;
    [Token(Token = "0x4003E85")]
    [FieldOffset(Offset = "0x20")]
    public RawImage[] Chara_02_Images;
    [Token(Token = "0x4003E86")]
    [FieldOffset(Offset = "0x24")]
    private bool mClose;

    [Token(Token = "0x600495D")]
    [Address(RVA = "0x11FBD40", Offset = "0x11FAB40", VA = "0x111FBD40")]
    public void SetCharaImages(Texture2D newTexture1, Texture2D newTexture2)
    {
    }

    [Token(Token = "0x600495E")]
    [Address(RVA = "0xFE58F0", Offset = "0xFE46F0", VA = "0x10FE58F0")]
    public void Close()
    {
    }

    [Token(Token = "0x600495F")]
    [Address(RVA = "0x11FBE60", Offset = "0x11FAC60", VA = "0x111FBE60")]
    private void Start()
    {
    }

    [Token(Token = "0x6004960")]
    [Address(RVA = "0x11FBEF0", Offset = "0x11FACF0", VA = "0x111FBEF0")]
    private void Update()
    {
    }

    [Token(Token = "0x6004961")]
    [Address(RVA = "0x11FC020", Offset = "0x11FAE20", VA = "0x111FC020")]
    public SkillSplash()
    {
    }
  }
}
