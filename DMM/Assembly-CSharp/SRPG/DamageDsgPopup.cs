// Decompiled with JetBrains decompiler
// Type: SRPG.DamageDsgPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C71")]
  [AddComponentMenu("Battle/DamageDsgPopup")]
  public class DamageDsgPopup : MonoBehaviour
  {
    [Token(Token = "0x4002199")]
    [FieldOffset(Offset = "0xC")]
    public Sprite[] DigitSprites;
    [Token(Token = "0x400219A")]
    [FieldOffset(Offset = "0x10")]
    public Sprite BillionSprite;
    [Token(Token = "0x400219B")]
    [FieldOffset(Offset = "0x14")]
    public Sprite TrillionSprite;
    [Token(Token = "0x400219C")]
    [FieldOffset(Offset = "0x18")]
    public GameObject GoDispDigit;
    [Token(Token = "0x400219D")]
    [FieldOffset(Offset = "0x1C")]
    public float Spacing;
    [Token(Token = "0x400219E")]
    [FieldOffset(Offset = "0x20")]
    public float SpacingUnit;
    [Token(Token = "0x400219F")]
    [FieldOffset(Offset = "0x24")]
    public float DispTime;
    [Token(Token = "0x40021A0")]
    [FieldOffset(Offset = "0x28")]
    public float FadeTime;
    [Token(Token = "0x40021A1")]
    [FieldOffset(Offset = "0x2C")]
    public float DelayTime;
    [Token(Token = "0x40021A2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int mValue;
    [Token(Token = "0x40021A3")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Color mDigitColor;
    [Token(Token = "0x40021A4")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private eDamageDispType mDamageDispType;
    [Token(Token = "0x40021A5")]
    [FieldOffset(Offset = "0x48")]
    private List<DamageDsgPopup.Digit> mDigitLists;
    [Token(Token = "0x40021A6")]
    [FieldOffset(Offset = "0x4C")]
    private DamageDsgPopup.Digit mNumUnit;
    [Token(Token = "0x40021A7")]
    [FieldOffset(Offset = "0x50")]
    private float mPassedTime;
    [Token(Token = "0x40021A8")]
    [FieldOffset(Offset = "0x54")]
    private float mPassedFadeTime;
    [Token(Token = "0x40021A9")]
    [FieldOffset(Offset = "0x58")]
    private bool mIsInitialized;

    [Token(Token = "0x600310D")]
    [Address(RVA = "0x101F0E0", Offset = "0x101DEE0", VA = "0x1101F0E0")]
    public void Setup(int value, Color color, eDamageDispType damage_disp_type)
    {
    }

    [Token(Token = "0x600310E")]
    [Address(RVA = "0x101FC60", Offset = "0x101EA60", VA = "0x1101FC60")]
    private IEnumerator startDelayAnm() => (IEnumerator) null;

    [Token(Token = "0x600310F")]
    [Address(RVA = "0x101FA20", Offset = "0x101E820", VA = "0x1101FA20")]
    private void Update()
    {
    }

    [Token(Token = "0x6003110")]
    [Address(RVA = "0x101FBC0", Offset = "0x101E9C0", VA = "0x1101FBC0")]
    public DamageDsgPopup()
    {
    }

    [Token(Token = "0x2000C72")]
    private class Digit
    {
      [Token(Token = "0x40021AA")]
      [FieldOffset(Offset = "0x8")]
      public RectTransform mTransform;
      [Token(Token = "0x40021AB")]
      [FieldOffset(Offset = "0xC")]
      public Image mImage;
      [Token(Token = "0x40021AC")]
      [FieldOffset(Offset = "0x10")]
      public Vector2 mPosition;

      [Token(Token = "0x6003111")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Digit()
      {
      }
    }
  }
}
