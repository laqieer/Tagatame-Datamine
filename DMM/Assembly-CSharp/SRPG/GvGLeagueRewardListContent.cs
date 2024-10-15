// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueRewardListContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025E6")]
  [AddComponentMenu("UI/GvG/GvGLeagueRewardListContent")]
  public class GvGLeagueRewardListContent : MonoBehaviour
  {
    [Token(Token = "0x400B001")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RewardListItem item;
    [Token(Token = "0x400B002")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray image;
    [Token(Token = "0x400B003")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400B004")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mMapNameText;
    [Token(Token = "0x400B005")]
    private const int RANK_MAX = 3;

    [Token(Token = "0x600A880")]
    [Address(RVA = "0x6B9190", Offset = "0x6B7F90", VA = "0x106B9190")]
    public bool SetUpArea(string league) => new bool();

    [Token(Token = "0x600A881")]
    [Address(RVA = "0x6B9260", Offset = "0x6B8060", VA = "0x106B9260")]
    public bool SetUpLeague() => new bool();

    [Token(Token = "0x600A882")]
    [Address(RVA = "0x6B8F50", Offset = "0x6B7D50", VA = "0x106B8F50")]
    private void CreateList(RewardListItem listItem, List<GvGRewardDetailParam> rewards)
    {
    }

    [Token(Token = "0x600A883")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGLeagueRewardListContent()
    {
    }
  }
}
