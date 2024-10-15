// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchSeasonRewardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200292A")]
  [AddComponentMenu("UI/RankMatchSeasonRewardList")]
  public class RankMatchSeasonRewardList : SRPG_ListBase
  {
    [Token(Token = "0x400C634")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RankMatchClassListItem ListItem;

    [Token(Token = "0x600BA38")]
    [Address(RVA = "0x818300", Offset = "0x817100", VA = "0x10818300", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600BA39")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RankMatchSeasonRewardList()
    {
    }
  }
}
