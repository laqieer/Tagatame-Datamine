// Decompiled with JetBrains decompiler
// Type: SRPG.QuestResultTreasureNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028C4")]
  public class QuestResultTreasureNode : ContentNode
  {
    [Token(Token = "0x400C36B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject TreasureListItem;
    [Token(Token = "0x400C36C")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject TreasureListUnit;
    [Token(Token = "0x400C36D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject TreasureListArtifact;
    [Token(Token = "0x400C36E")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject TreasureListConceptCard;
    [Token(Token = "0x400C36F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject NewIcon;
    [Token(Token = "0x400C370")]
    [FieldOffset(Offset = "0x44")]
    private QuestResultTreasureParam mParam;
    [Token(Token = "0x400C371")]
    [FieldOffset(Offset = "0x48")]
    private GameObject mDispNewIcon;

    [Token(Token = "0x600B849")]
    [Address(RVA = "0x7F2E70", Offset = "0x7F1C70", VA = "0x107F2E70")]
    public void Setup(QuestResultTreasureParam _param)
    {
    }

    [Token(Token = "0x600B84A")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public QuestResultTreasureNode()
    {
    }
  }
}
