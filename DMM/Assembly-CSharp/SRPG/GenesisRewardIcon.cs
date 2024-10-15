// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisRewardIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024FD")]
  [AddComponentMenu("UI/Genesis/GenesisRewardIcon")]
  public class GenesisRewardIcon : MonoBehaviour
  {
    [Token(Token = "0x400A903")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardUnit;
    [Token(Token = "0x400A904")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardItem;
    [Token(Token = "0x400A905")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRewardCard;
    [Token(Token = "0x400A906")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardArtifact;
    [Token(Token = "0x400A907")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRewardAward;
    [Token(Token = "0x400A908")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRewardGold;
    [Token(Token = "0x400A909")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRewardCoin;

    [Token(Token = "0x600A275")]
    [Address(RVA = "0x648C60", Offset = "0x647A60", VA = "0x10648C60")]
    public void Initialize(GiftData reward)
    {
    }

    [Token(Token = "0x600A276")]
    [Address(RVA = "0x648760", Offset = "0x647560", VA = "0x10648760")]
    public void Initialize(GenesisRewardDataParam reward)
    {
    }

    [Token(Token = "0x600A277")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisRewardIcon()
    {
    }
  }
}
