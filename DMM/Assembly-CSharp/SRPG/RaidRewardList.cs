// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002902")]
  [AddComponentMenu("UI/RaidRewardList")]
  public class RaidRewardList : SRPG_ListBase
  {
    [Token(Token = "0x400C57F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RaidRewardListItem mListItem;
    [Token(Token = "0x400C580")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RaidRewardListItem mListItemAdd;
    [Token(Token = "0x400C581")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject GuildCaution;
    [Token(Token = "0x400C582")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RaidRewardList.RaidRewardSelect mRewardType;

    [Token(Token = "0x600B9AE")]
    [Address(RVA = "0x80C1D0", Offset = "0x80AFD0", VA = "0x1080C1D0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B9AF")]
    [Address(RVA = "0x80BC40", Offset = "0x80AA40", VA = "0x1080BC40")]
    private void CreateList(
      RaidRewardListItem ListItem,
      List<RaidReward> rewards,
      RaidRewardList.RaidRewardSelectType type = RaidRewardList.RaidRewardSelectType.All)
    {
    }

    [Token(Token = "0x600B9B0")]
    [Address(RVA = "0x80C030", Offset = "0x80AE30", VA = "0x1080C030")]
    private void GetEmblem(GameObject obj, string name)
    {
    }

    [Token(Token = "0x600B9B1")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RaidRewardList()
    {
    }

    [Token(Token = "0x2002903")]
    private enum RaidRewardSelect
    {
      [Token(Token = "0x400C584")] Player,
      [Token(Token = "0x400C585")] Guild,
    }

    [Token(Token = "0x2002904")]
    private enum RaidRewardSelectType
    {
      [Token(Token = "0x400C587")] All,
      [Token(Token = "0x400C588")] GuildReward,
      [Token(Token = "0x400C589")] Else,
    }
  }
}
