// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestPersonRankingContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200282D")]
  public class PointQuestPersonRankingContentNode : ContentNode
  {
    [Token(Token = "0x400BF83")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400BF84")]
    private const int mRankingOutRange = 0;
    [Token(Token = "0x400BF85")]
    [FieldOffset(Offset = "0x34")]
    private PointQuestPersonRankingContentNodeModel mModel;

    [Token(Token = "0x170018DD")]
    public PointQuestPersonRankingContentNodeModel Model
    {
      [Token(Token = "0x600B551"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (PointQuestPersonRankingContentNodeModel) null;
      }
    }

    [Token(Token = "0x600B552")]
    [Address(RVA = "0x7BC210", Offset = "0x7BB010", VA = "0x107BC210")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600B553")]
    [Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")]
    public void SetModel(PointQuestPersonRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600B554")]
    [Address(RVA = "0x7BC2D0", Offset = "0x7BB0D0", VA = "0x107BC2D0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B555")]
    [Address(RVA = "0x7BC150", Offset = "0x7BAF50", VA = "0x107BC150")]
    public static void CallBack(ContentNode node, PointQuestPersonRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600B556")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public PointQuestPersonRankingContentNode()
    {
    }
  }
}
