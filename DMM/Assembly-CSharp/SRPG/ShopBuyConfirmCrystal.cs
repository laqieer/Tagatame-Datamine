// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuyConfirmCrystal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A8D")]
  [AddComponentMenu("UI/ShopBuyConfirmCrystal")]
  public class ShopBuyConfirmCrystal : MonoBehaviour
  {
    [Token(Token = "0x400CF08")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTextName;
    [Token(Token = "0x400CF09")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mHave;
    [Token(Token = "0x400CF0A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalIcon mCrystalIcon;

    [Token(Token = "0x600C249")]
    [Address(RVA = "0x8A73A0", Offset = "0x8A61A0", VA = "0x108A73A0")]
    public void Setup(CrystalData _data, CrystalParam _param)
    {
    }

    [Token(Token = "0x600C24A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopBuyConfirmCrystal()
    {
    }
  }
}
