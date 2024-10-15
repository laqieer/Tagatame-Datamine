// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLimitBreakBonusContentLvMax
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002225")]
  [AddComponentMenu("UI/ConceptCardLimitBreakBonusContentLvMax")]
  public class ConceptCardLimitBreakBonusContentLvMax : MonoBehaviour
  {
    [Token(Token = "0x4009712")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mParamTemplate;
    [Token(Token = "0x4009713")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mAwakeIconImageArray;
    [Token(Token = "0x4009714")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mAwakeIconBgArray;
    [Token(Token = "0x4009715")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StatusList mParamStatusList;
    [Token(Token = "0x4009716")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private StatusList mBonusStatusList;
    [Token(Token = "0x4009717")]
    [FieldOffset(Offset = "0x20")]
    private int mCreatedCount;

    [Token(Token = "0x600910C")]
    [Address(RVA = "0x5474B0", Offset = "0x5462B0", VA = "0x105474B0")]
    public void Setup(ConceptCardParam param, bool is_enable)
    {
    }

    [Token(Token = "0x600910D")]
    [Address(RVA = "0x546FB0", Offset = "0x545DB0", VA = "0x10546FB0")]
    private void CreateExAbilityBonus(string iname, bool is_enable)
    {
    }

    [Token(Token = "0x600910E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardLimitBreakBonusContentLvMax()
    {
    }
  }
}
