// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchRankingAward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002923")]
  [AddComponentMenu("UI/RankMatchRankingAward")]
  public class RankMatchRankingAward : SRPG_ListBase
  {
    [Token(Token = "0x400C60F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RankMatchClassListItem ListItem;

    [Token(Token = "0x600BA1F")]
    [Address(RVA = "0x816E90", Offset = "0x815C90", VA = "0x10816E90", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600BA20")]
    [Address(RVA = "0x438D60", Offset = "0x437B60", VA = "0x10438D60")]
    public RankMatchRankingAward()
    {
    }
  }
}
