// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingRewardContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002324")]
  [AddComponentMenu("UI/Duel/DuelRankingRewardContent")]
  public class DuelRankingRewardContent : MonoBehaviour
  {
    [Token(Token = "0x4009CF1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mIcon_Root;
    [Token(Token = "0x4009CF2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mRankingImages;
    [Token(Token = "0x4009CF3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRankingSingleTxt;
    [Token(Token = "0x4009CF4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRankingMultiStartTxt;
    [Token(Token = "0x4009CF5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRankingMultiEndTxt;
    [Token(Token = "0x4009CF6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRankingSingleRoot;
    [Token(Token = "0x4009CF7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRankingMultiRoot;
    [Token(Token = "0x4009CF8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mRankingMultiEndSub;

    [Token(Token = "0x6009731")]
    [Address(RVA = "0x59B1C0", Offset = "0x599FC0", VA = "0x1059B1C0")]
    public void Setup(DuelRankingReward ranking_reward, DuelRewardIconTemplate icon_template)
    {
    }

    [Token(Token = "0x6009732")]
    [Address(RVA = "0x59ADF0", Offset = "0x599BF0", VA = "0x1059ADF0")]
    private void SetRanking(int min, int max)
    {
    }

    [Token(Token = "0x6009733")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelRankingRewardContent()
    {
    }
  }
}
