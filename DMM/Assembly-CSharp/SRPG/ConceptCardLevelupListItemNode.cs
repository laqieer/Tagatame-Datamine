// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLevelupListItemNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C5")]
  public class ConceptCardLevelupListItemNode : ContentNode
  {
    [Token(Token = "0x4009418")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ConceptCardLevelUpListItem LevelupListItem;
    [Token(Token = "0x4009419")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private ConceptCardLimitUpListItem LimitupListItem;

    [Token(Token = "0x6008E74")]
    [Address(RVA = "0x51A090", Offset = "0x518E90", VA = "0x1051A090")]
    public void Setup(ConceptCardLevelupListItemParam param)
    {
    }

    [Token(Token = "0x6008E75")]
    [Address(RVA = "0x51A220", Offset = "0x519020", VA = "0x1051A220")]
    public void Setup(ConceptCardLimitupListItemParam param)
    {
    }

    [Token(Token = "0x6008E76")]
    [Address(RVA = "0x519E80", Offset = "0x518C80", VA = "0x10519E80")]
    public void Reset()
    {
    }

    [Token(Token = "0x6008E77")]
    [Address(RVA = "0x519F30", Offset = "0x518D30", VA = "0x10519F30")]
    public void SetInputLock(bool is_lock)
    {
    }

    [Token(Token = "0x6008E78")]
    [Address(RVA = "0x519FE0", Offset = "0x518DE0", VA = "0x10519FE0")]
    public void SetSliderValue(int value)
    {
    }

    [Token(Token = "0x6008E79")]
    [Address(RVA = "0x519CA0", Offset = "0x518AA0", VA = "0x10519CA0")]
    public ConceptCardData GetConceptCardData() => (ConceptCardData) null;

    [Token(Token = "0x6008E7A")]
    [Address(RVA = "0x519D90", Offset = "0x518B90", VA = "0x10519D90")]
    public int GetUpCount() => new int();

    [Token(Token = "0x6008E7B")]
    [Address(RVA = "0x519E10", Offset = "0x518C10", VA = "0x10519E10")]
    public int GetUseNum() => new int();

    [Token(Token = "0x6008E7C")]
    [Address(RVA = "0x519D10", Offset = "0x518B10", VA = "0x10519D10")]
    public (int, bool) GetSelected() => ();

    [Token(Token = "0x6008E7D")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public ConceptCardLevelupListItemNode()
    {
    }
  }
}
