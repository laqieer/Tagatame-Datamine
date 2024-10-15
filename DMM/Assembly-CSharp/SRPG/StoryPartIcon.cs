// Decompiled with JetBrains decompiler
// Type: SRPG.StoryPartIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B06")]
  [AddComponentMenu("UI/StoryPartIcon")]
  public class StoryPartIcon : MonoBehaviour
  {
    [Token(Token = "0x400D1F2")]
    private const string ANIMATION_RELEASE_NAME = "open";
    [Token(Token = "0x400D1F3")]
    [FieldOffset(Offset = "0xC")]
    private StoryPartIcon.EndUnlockAnimStoryPart OnEndUnlockAnimation;
    [Token(Token = "0x400D1F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject MainIcon;
    [Token(Token = "0x400D1F5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Animator UnlockAnimator;
    [Token(Token = "0x400D1F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image LockCover;
    [Token(Token = "0x400D1F7")]
    [FieldOffset(Offset = "0x1C")]
    private bool mLockFlag;
    [Token(Token = "0x400D1F8")]
    [FieldOffset(Offset = "0x1D")]
    private bool mIsPlayingUnlockAnim;

    [Token(Token = "0x600C4EB")]
    [Address(RVA = "0x8D8870", Offset = "0x8D7670", VA = "0x108D8870")]
    public bool Setup(bool unlock_flag, eStoryPart story_part, bool is_unlock_anim) => new bool();

    [Token(Token = "0x600C4EC")]
    [Address(RVA = "0x8D8720", Offset = "0x8D7520", VA = "0x108D8720")]
    public bool PlayUnlockAnim(StoryPartIcon.EndUnlockAnimStoryPart callback) => new bool();

    [Token(Token = "0x600C4ED")]
    [Address(RVA = "0x8D8970", Offset = "0x8D7770", VA = "0x108D8970")]
    private void Update()
    {
    }

    [Token(Token = "0x600C4EE")]
    [Address(RVA = "0x8D8650", Offset = "0x8D7450", VA = "0x108D8650")]
    private bool IsPlayingReleaseAnim() => new bool();

    [Token(Token = "0x600C4EF")]
    [Address(RVA = "0x8D87F0", Offset = "0x8D75F0", VA = "0x108D87F0")]
    private void ReleaseIcon()
    {
    }

    [Token(Token = "0x600C4F0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryPartIcon()
    {
    }

    [Token(Token = "0x2002B07")]
    public delegate void EndUnlockAnimStoryPart();
  }
}
