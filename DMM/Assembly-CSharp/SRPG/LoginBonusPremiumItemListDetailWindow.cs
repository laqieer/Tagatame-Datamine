// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusPremiumItemListDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026EA")]
  [AddComponentMenu("UI/LoginBonusPremiumItemListDetailWindow")]
  public class LoginBonusPremiumItemListDetailWindow : MonoBehaviour
  {
    [Token(Token = "0x400B6FF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform LimitedItemList;
    [Token(Token = "0x400B700")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemBase;
    [Token(Token = "0x400B701")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private string IconNamePath;
    [Token(Token = "0x400B702")]
    [FieldOffset(Offset = "0x18")]
    private Json_PremiumLoginBonus mPremiumLoginBonus;
    [Token(Token = "0x400B703")]
    [FieldOffset(Offset = "0x1C")]
    private int mLoginBonusIndex;

    [Token(Token = "0x600AE47")]
    [Address(RVA = "0x722220", Offset = "0x721020", VA = "0x10722220")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AE48")]
    [Address(RVA = "0x721C70", Offset = "0x720A70", VA = "0x10721C70")]
    private void MakeTopItemIcon()
    {
    }

    [Token(Token = "0x600AE49")]
    [Address(RVA = "0x721450", Offset = "0x720250", VA = "0x10721450")]
    private void MakeItemIconInPacking()
    {
    }

    [Token(Token = "0x600AE4A")]
    [Address(RVA = "0x722350", Offset = "0x721150", VA = "0x10722350")]
    public LoginBonusPremiumItemListDetailWindow()
    {
    }
  }
}
