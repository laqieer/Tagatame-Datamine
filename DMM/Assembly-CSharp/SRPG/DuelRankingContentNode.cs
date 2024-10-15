// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002323")]
  public class DuelRankingContentNode : ContentNode
  {
    [Token(Token = "0x4009CE6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray mRankingImages;
    [Token(Token = "0x4009CE7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mSingleRankObj;
    [Token(Token = "0x4009CE8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mSingleRankTxt;
    [Token(Token = "0x4009CE9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mOutRankObj;
    [Token(Token = "0x4009CEA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mUserNameTxt;
    [Token(Token = "0x4009CEB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mUserLevelTxt;
    [Token(Token = "0x4009CEC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mPointTxt;
    [Token(Token = "0x4009CED")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mGuildNameTxt;
    [Token(Token = "0x4009CEE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mGuildNoneObj;
    [Token(Token = "0x4009CEF")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private AwardItem mAwardItem;
    [Token(Token = "0x4009CF0")]
    [FieldOffset(Offset = "0x58")]
    private DuelPlayerData mDuelPlayerData;

    [Token(Token = "0x600972E")]
    [Address(RVA = "0x59A6B0", Offset = "0x5994B0", VA = "0x1059A6B0")]
    public void Setup(DuelPlayerData data, int ranking_view_max, bool is_self = false)
    {
    }

    [Token(Token = "0x600972F")]
    [Address(RVA = "0x59A5B0", Offset = "0x5993B0", VA = "0x1059A5B0")]
    public void OnClickOpenDetail()
    {
    }

    [Token(Token = "0x6009730")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public DuelRankingContentNode()
    {
    }
  }
}
