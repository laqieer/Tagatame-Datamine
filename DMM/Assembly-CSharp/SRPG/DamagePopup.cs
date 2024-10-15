// Decompiled with JetBrains decompiler
// Type: SRPG.DamagePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C74")]
  [AddComponentMenu("Battle/DamagePopup")]
  public class DamagePopup : MonoBehaviour
  {
    [Token(Token = "0x40021B1")]
    [FieldOffset(Offset = "0xC")]
    public Sprite[] DigitSprites;
    [Token(Token = "0x40021B2")]
    [FieldOffset(Offset = "0x10")]
    public int Value;
    [Token(Token = "0x40021B3")]
    [FieldOffset(Offset = "0x14")]
    public float Spacing;
    [Token(Token = "0x40021B4")]
    [FieldOffset(Offset = "0x18")]
    public float PopMin;
    [Token(Token = "0x40021B5")]
    [FieldOffset(Offset = "0x1C")]
    public float PopMax;
    [Token(Token = "0x40021B6")]
    [FieldOffset(Offset = "0x20")]
    public float Gravity;
    [Token(Token = "0x40021B7")]
    [FieldOffset(Offset = "0x24")]
    public float Resititution;
    [Token(Token = "0x40021B8")]
    [FieldOffset(Offset = "0x28")]
    public float KeepVisible;
    [Token(Token = "0x40021B9")]
    [FieldOffset(Offset = "0x2C")]
    public float FadeTime;
    [Token(Token = "0x40021BA")]
    [FieldOffset(Offset = "0x30")]
    public Color DigitColor;
    [Token(Token = "0x40021BB")]
    [FieldOffset(Offset = "0x40")]
    private DamagePopup.Digit[] mDigits;
    [Token(Token = "0x40021BC")]
    [FieldOffset(Offset = "0x44")]
    private float mFadeTime;

    [Token(Token = "0x6003119")]
    [Address(RVA = "0x101FCD0", Offset = "0x101EAD0", VA = "0x1101FCD0")]
    private void Start()
    {
    }

    [Token(Token = "0x600311A")]
    [Address(RVA = "0x1020200", Offset = "0x101F000", VA = "0x11020200")]
    private void Update()
    {
    }

    [Token(Token = "0x600311B")]
    [Address(RVA = "0x1020560", Offset = "0x101F360", VA = "0x11020560")]
    public DamagePopup()
    {
    }

    [Token(Token = "0x2000C75")]
    private struct Digit
    {
      [Token(Token = "0x40021BD")]
      [FieldOffset(Offset = "0x0")]
      public RectTransform Transform;
      [Token(Token = "0x40021BE")]
      [FieldOffset(Offset = "0x4")]
      public Image Image;
      [Token(Token = "0x40021BF")]
      [FieldOffset(Offset = "0x8")]
      public Vector2 Position;
      [Token(Token = "0x40021C0")]
      [FieldOffset(Offset = "0x10")]
      public float Velocity;
    }
  }
}
