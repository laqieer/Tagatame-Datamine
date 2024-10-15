// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestPortRankingContentNode
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
  [Token(Token = "0x200282E")]
  public class PointQuestPortRankingContentNode : ContentNode
  {
    [Token(Token = "0x400BF86")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400BF87")]
    private const int mRankingOutRange = 0;
    [Token(Token = "0x400BF88")]
    [FieldOffset(Offset = "0x34")]
    private PointQuestPortRankingContentNodeModel mModel;

    [Token(Token = "0x170018DE")]
    public PointQuestPortRankingContentNodeModel Model
    {
      [Token(Token = "0x600B557"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (PointQuestPortRankingContentNodeModel) null;
      }
    }

    [Token(Token = "0x600B558")]
    [Address(RVA = "0x7BC530", Offset = "0x7BB330", VA = "0x107BC530")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600B559")]
    [Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")]
    public void SetModel(PointQuestPortRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600B55A")]
    [Address(RVA = "0x7BC5F0", Offset = "0x7BB3F0", VA = "0x107BC5F0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B55B")]
    [Address(RVA = "0x7BC470", Offset = "0x7BB270", VA = "0x107BC470")]
    public static void CallBack(ContentNode node, PointQuestPortRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600B55C")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public PointQuestPortRankingContentNode()
    {
    }
  }
}
