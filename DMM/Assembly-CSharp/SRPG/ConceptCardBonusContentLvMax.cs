// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardBonusContentLvMax
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021D9")]
  [AddComponentMenu("UI/ConceptCardBonusContentLvMax")]
  public class ConceptCardBonusContentLvMax : MonoBehaviour
  {
    [Token(Token = "0x4009490")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mParamTemplate;
    [Token(Token = "0x4009491")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mAwakeIconImageArray;
    [Token(Token = "0x4009492")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mAwakeIconBgArray;
    [Token(Token = "0x4009493")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StatusList mParamStatusList;
    [Token(Token = "0x4009494")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private StatusList mBonusStatusList;
    [Token(Token = "0x4009495")]
    [FieldOffset(Offset = "0x20")]
    private int mCreatedCount;

    [Token(Token = "0x6008EE8")]
    [Address(RVA = "0x522580", Offset = "0x521380", VA = "0x10522580")]
    public void Setup(
      ConceptCardEffectsParam[] effect_params,
      int lv,
      int lv_cap,
      int awake_count_cap,
      bool is_enable,
      ConceptCardBonusWindow.eViewType view_type)
    {
    }

    [Token(Token = "0x6008EE9")]
    [Address(RVA = "0x521F30", Offset = "0x520D30", VA = "0x10521F30")]
    private void CreateCardSkillBonus(
      ConceptCardEffectsParam[] effect_params,
      int lv,
      int lv_cap,
      int awake_count_cap,
      bool is_enable)
    {
    }

    [Token(Token = "0x6008EEA")]
    [Address(RVA = "0x521B40", Offset = "0x520940", VA = "0x10521B40")]
    private void CreateAbilityBonus(
      ConceptCardEffectsParam[] effect_params,
      int lv,
      int lv_cap,
      int awake_count_cap,
      bool is_enable)
    {
    }

    [Token(Token = "0x6008EEB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardBonusContentLvMax()
    {
    }
  }
}
