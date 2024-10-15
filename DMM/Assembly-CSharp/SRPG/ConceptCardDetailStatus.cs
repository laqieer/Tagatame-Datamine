// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021F6")]
  [AddComponentMenu("UI/ConceptCardDetailStatus")]
  public class ConceptCardDetailStatus : ConceptCardDetailBase
  {
    [Token(Token = "0x4009592")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mParentObject;
    [Token(Token = "0x4009593")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mStatusBaseItem;
    [Token(Token = "0x4009594")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mInstantiateItems;
    [Token(Token = "0x4009595")]
    [FieldOffset(Offset = "0x1C")]
    private int mAddExp;
    [Token(Token = "0x4009596")]
    [FieldOffset(Offset = "0x20")]
    private int mAddAwakeLv;
    [Token(Token = "0x4009597")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsEnhance;

    [Token(Token = "0x6008FA3")]
    [Address(RVA = "0x52B5C0", Offset = "0x52A3C0", VA = "0x1052B5C0", Slot = "6")]
    public override void SetParam(
      ConceptCardData card_data,
      int addExp,
      int addTrust,
      int addAwakeLv,
      bool isExtra)
    {
    }

    [Token(Token = "0x6008FA4")]
    [Address(RVA = "0x52B290", Offset = "0x52A090", VA = "0x1052B290", Slot = "7")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6008FA5")]
    [Address(RVA = "0x52B070", Offset = "0x529E70", VA = "0x1052B070")]
    private ConceptCardEffectsParam GetBaseEffectParam() => (ConceptCardEffectsParam) null;

    [Token(Token = "0x6008FA6")]
    [Address(RVA = "0x52B160", Offset = "0x529F60", VA = "0x1052B160")]
    private void InitStatusItems()
    {
    }

    [Token(Token = "0x6008FA7")]
    [Address(RVA = "0x52AEE0", Offset = "0x529CE0", VA = "0x1052AEE0")]
    private GameObject CreateStatusItem(int index) => (GameObject) null;

    [Token(Token = "0x6008FA8")]
    [Address(RVA = "0x52B660", Offset = "0x52A460", VA = "0x1052B660")]
    public ConceptCardDetailStatus()
    {
    }
  }
}
