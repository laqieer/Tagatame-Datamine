// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200219E")]
  [AddComponentMenu("UI/CoinBuyUseBonusIcon")]
  public class CoinBuyUseBonusIcon : MonoBehaviour
  {
    [Token(Token = "0x40092E5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button mIcon;
    [Token(Token = "0x40092E6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mBadge;
    [Token(Token = "0x40092E7")]
    [FieldOffset(Offset = "0x14")]
    private CoinBuyUseBonusParam[] mBonusParams;
    [Token(Token = "0x40092E8")]
    [FieldOffset(Offset = "0x18")]
    private bool mNeedWaitHomeApi;
    [Token(Token = "0x40092E9")]
    [FieldOffset(Offset = "0x0")]
    private static CoinBuyUseBonusIcon mInstance;

    [Token(Token = "0x170013EB")]
    public static CoinBuyUseBonusIcon Instance
    {
      [Token(Token = "0x6008D4E"), Address(RVA = "0x50EF10", Offset = "0x50DD10", VA = "0x1050EF10")] get
      {
        return (CoinBuyUseBonusIcon) null;
      }
    }

    [Token(Token = "0x6008D4F")]
    [Address(RVA = "0x50ECD0", Offset = "0x50DAD0", VA = "0x1050ECD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008D50")]
    [Address(RVA = "0x50EDB0", Offset = "0x50DBB0", VA = "0x1050EDB0")]
    public void RefreshBadge()
    {
    }

    [Token(Token = "0x6008D51")]
    [Address(RVA = "0x50EE80", Offset = "0x50DC80", VA = "0x1050EE80")]
    private void Update()
    {
    }

    [Token(Token = "0x6008D52")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CoinBuyUseBonusIcon()
    {
    }
  }
}
