// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestBonusContent
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
  [Token(Token = "0x20027FC")]
  public class PointQuestBonusContent : MonoBehaviour
  {
    [Token(Token = "0x400BE52")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mUnitIconTemplate;
    [Token(Token = "0x400BE53")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mConceptCardIconTemplate;
    [Token(Token = "0x400BE54")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRateText;
    [Token(Token = "0x400BE55")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> UnitList;
    [Token(Token = "0x400BE56")]
    [FieldOffset(Offset = "0x1C")]
    private List<PointQuestEventBonuses> BonusParamList;
    [Token(Token = "0x400BE57")]
    [FieldOffset(Offset = "0x20")]
    private int mRate;

    [Token(Token = "0x170018BB")]
    public int Rate
    {
      [Token(Token = "0x600B480"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B481")]
    [Address(RVA = "0x7B0A30", Offset = "0x7AF830", VA = "0x107B0A30")]
    public void Setup(PointQuestEventBonuses bonus_param)
    {
    }

    [Token(Token = "0x600B482")]
    [Address(RVA = "0x7B06B0", Offset = "0x7AF4B0", VA = "0x107B06B0")]
    public void Add(PointQuestEventBonuses bonus_param)
    {
    }

    [Token(Token = "0x600B483")]
    [Address(RVA = "0x7B09C0", Offset = "0x7AF7C0", VA = "0x107B09C0")]
    public bool IsMatchType(PointQuestBonusPartyType type) => new bool();

    [Token(Token = "0x600B484")]
    [Address(RVA = "0x7B0B70", Offset = "0x7AF970", VA = "0x107B0B70")]
    public PointQuestBonusContent()
    {
    }
  }
}
