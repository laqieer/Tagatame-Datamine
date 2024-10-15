// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayVersusGradientFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002793")]
  [AddComponentMenu("UI/MultiPlayVersusGradientFade")]
  public class MultiPlayVersusGradientFade : MonoBehaviour
  {
    [Token(Token = "0x400BAE5")]
    private const string STATE_FADE_IN = "FadeIn";
    [Token(Token = "0x400BAE6")]
    private const string STATE_FADE_OUT = "FadeOut";
    [Token(Token = "0x400BAE7")]
    private const string STATE_FADE_IN_FINISH = "FadeInFinish";
    [Token(Token = "0x400BAE8")]
    private const string STATE_FADE_OUT_FINISH = "FadeOutFinish";
    [Token(Token = "0x400BAE9")]
    [FieldOffset(Offset = "0xC")]
    private bool mFading;
    [Token(Token = "0x400BAEA")]
    [FieldOffset(Offset = "0x10")]
    private Animator mAnimator;
    [Token(Token = "0x400BAEB")]
    [FieldOffset(Offset = "0x14")]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x400BAEC")]
    [FieldOffset(Offset = "0x18")]
    private string mStateName;

    [Token(Token = "0x17001883")]
    public static MultiPlayVersusGradientFade Instance
    {
      [Token(Token = "0x600B18B"), Address(RVA = "0x75A420", Offset = "0x759220", VA = "0x1075A420")] get
      {
        return (MultiPlayVersusGradientFade) null;
      }
      [Token(Token = "0x600B18C"), Address(RVA = "0x75A450", Offset = "0x759250", VA = "0x1075A450")] private set
      {
      }
    }

    [Token(Token = "0x17001884")]
    public bool Fading
    {
      [Token(Token = "0x600B18D"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B18E")]
    [Address(RVA = "0x75A0A0", Offset = "0x758EA0", VA = "0x1075A0A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B18F")]
    [Address(RVA = "0x75A2C0", Offset = "0x7590C0", VA = "0x1075A2C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B190")]
    [Address(RVA = "0x75A1C0", Offset = "0x758FC0", VA = "0x1075A1C0")]
    public void FadeIn()
    {
    }

    [Token(Token = "0x600B191")]
    [Address(RVA = "0x75A230", Offset = "0x759030", VA = "0x1075A230")]
    public void FadeOut()
    {
    }

    [Token(Token = "0x600B192")]
    [Address(RVA = "0x75A370", Offset = "0x759170", VA = "0x1075A370")]
    private void Update()
    {
    }

    [Token(Token = "0x600B193")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayVersusGradientFade()
    {
    }
  }
}
