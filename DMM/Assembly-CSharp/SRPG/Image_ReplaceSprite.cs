// Decompiled with JetBrains decompiler
// Type: SRPG.Image_ReplaceSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002644")]
  public class Image_ReplaceSprite : Image
  {
    [Token(Token = "0x400B2BF")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public string mMasterIname;
    [Token(Token = "0x400B2C0")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public SpriteSheet mSpriteSheet;
    [Token(Token = "0x400B2C1")]
    [FieldOffset(Offset = "0xB8")]
    private int mCheckTime;

    [Token(Token = "0x600AACF")]
    [Address(RVA = "0x6E29D0", Offset = "0x6E17D0", VA = "0x106E29D0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600AAD0")]
    [Address(RVA = "0x6E2A70", Offset = "0x6E1870", VA = "0x106E2A70")]
    private void Update()
    {
    }

    [Token(Token = "0x600AAD1")]
    [Address(RVA = "0x6E2800", Offset = "0x6E1600", VA = "0x106E2800")]
    private void ReplaceSprite()
    {
    }

    [Token(Token = "0x600AAD2")]
    [Address(RVA = "0x6E2580", Offset = "0x6E1380", VA = "0x106E2580")]
    private void ReplaceSprite(SRPG.ReplaceSprite replace_sprite)
    {
    }

    [Token(Token = "0x600AAD3")]
    [Address(RVA = "0x6E2330", Offset = "0x6E1130", VA = "0x106E2330")]
    private bool IsPeriod(string startTime, string endTime) => new bool();

    [Token(Token = "0x600AAD4")]
    [Address(RVA = "0x6E2B50", Offset = "0x6E1950", VA = "0x106E2B50")]
    public Image_ReplaceSprite()
    {
    }
  }
}
