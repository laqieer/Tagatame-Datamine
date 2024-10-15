// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002360")]
  [AddComponentMenu("UI/Event2dFade")]
  public class Event2dFade : MonoBehaviour
  {
    [Token(Token = "0x4009E8A")]
    [FieldOffset(Offset = "0xC")]
    public RawImage mImage;
    [Token(Token = "0x4009E8B")]
    [FieldOffset(Offset = "0x10")]
    private Color mCurrentColor;
    [Token(Token = "0x4009E8C")]
    [FieldOffset(Offset = "0x20")]
    private Color mStartColor;
    [Token(Token = "0x4009E8D")]
    [FieldOffset(Offset = "0x30")]
    private Color mEndColor;
    [Token(Token = "0x4009E8E")]
    [FieldOffset(Offset = "0x40")]
    private float mCurrentTime;
    [Token(Token = "0x4009E8F")]
    [FieldOffset(Offset = "0x44")]
    private float mDuration;
    [Token(Token = "0x4009E90")]
    [FieldOffset(Offset = "0x48")]
    private bool mInitialized;

    [Token(Token = "0x17001546")]
    private static Event2dFade Instance
    {
      [Token(Token = "0x6009877"), Address(RVA = "0x5B0E00", Offset = "0x5AFC00", VA = "0x105B0E00")] get
      {
        return (Event2dFade) null;
      }
      [Token(Token = "0x6009878"), Address(RVA = "0x5B0E50", Offset = "0x5AFC50", VA = "0x105B0E50")] set
      {
      }
    }

    [Token(Token = "0x6009879")]
    [Address(RVA = "0x5B0BC0", Offset = "0x5AF9C0", VA = "0x105B0BC0")]
    public static Event2dFade Find() => (Event2dFade) null;

    [Token(Token = "0x600987A")]
    [Address(RVA = "0x5B09E0", Offset = "0x5AF7E0", VA = "0x105B09E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600987B")]
    [Address(RVA = "0x5B0BF0", Offset = "0x5AF9F0", VA = "0x105B0BF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x17001547")]
    public bool IsFading
    {
      [Token(Token = "0x600987C"), Address(RVA = "0x5B0E30", Offset = "0x5AFC30", VA = "0x105B0E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600987D")]
    [Address(RVA = "0x5B0AB0", Offset = "0x5AF8B0", VA = "0x105B0AB0")]
    public void FadeTo(Color dest, float time)
    {
    }

    [Token(Token = "0x600987E")]
    [Address(RVA = "0x5B0CA0", Offset = "0x5AFAA0", VA = "0x105B0CA0")]
    private void Update()
    {
    }

    [Token(Token = "0x600987F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public Event2dFade()
    {
    }
  }
}
