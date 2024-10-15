// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200219D")]
  [AddComponentMenu("UI/CoinBuyUseBonusContent")]
  public class CoinBuyUseBonusContent : MonoBehaviour
  {
    [Token(Token = "0x40092DC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardIconParent;
    [Token(Token = "0x40092DD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mReceiveButton;
    [Token(Token = "0x40092DE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mTitleText;
    [Token(Token = "0x40092DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mCurrentValueText;
    [Token(Token = "0x40092E0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mTargetValueText;
    [Token(Token = "0x40092E1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageArray mBackgroundImageArray;
    [Token(Token = "0x40092E2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mReceivedImage;
    [Token(Token = "0x40092E3")]
    [FieldOffset(Offset = "0x28")]
    private CoinBuyUseBonusParam mBonusParam;
    [Token(Token = "0x40092E4")]
    [FieldOffset(Offset = "0x2C")]
    private CoinBuyUseBonusContentParam mContentParam;

    [Token(Token = "0x6008D44")]
    [Address(RVA = "0x50DDC0", Offset = "0x50CBC0", VA = "0x1050DDC0")]
    public void Refresh(CoinBuyUseBonusParam bonus_param, CoinBuyUseBonusContentParam content_param)
    {
    }

    [Token(Token = "0x6008D45")]
    [Address(RVA = "0x50DCF0", Offset = "0x50CAF0", VA = "0x1050DCF0")]
    public void OnClickReceiveReward()
    {
    }

    [Token(Token = "0x6008D46")]
    [Address(RVA = "0x50EA00", Offset = "0x50D800", VA = "0x1050EA00")]
    private void SetParam_Item(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D47")]
    [Address(RVA = "0x50E8D0", Offset = "0x50D6D0", VA = "0x1050E8D0")]
    private void SetParam_Gold(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D48")]
    [Address(RVA = "0x50E600", Offset = "0x50D400", VA = "0x1050E600")]
    private void SetParam_Coin(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D49")]
    [Address(RVA = "0x50E300", Offset = "0x50D100", VA = "0x1050E300")]
    private void SetParam_Artifact(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D4A")]
    [Address(RVA = "0x50EB70", Offset = "0x50D970", VA = "0x1050EB70")]
    private void SetParam_Unit(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D4B")]
    [Address(RVA = "0x50E730", Offset = "0x50D530", VA = "0x1050E730")]
    private void SetParam_ConceptCard(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D4C")]
    [Address(RVA = "0x50E4A0", Offset = "0x50D2A0", VA = "0x1050E4A0")]
    private void SetParam_Award(CoinBuyUseBonusItemParam reward)
    {
    }

    [Token(Token = "0x6008D4D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CoinBuyUseBonusContent()
    {
    }
  }
}
