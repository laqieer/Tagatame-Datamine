// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardBonusContentAwake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021D8")]
  [AddComponentMenu("UI/ConceptCardBonusContentAwake")]
  public class ConceptCardBonusContentAwake : MonoBehaviour
  {
    [Token(Token = "0x400948A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mSkillParamTemplate;
    [Token(Token = "0x400948B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mAwakeIconImageArray;
    [Token(Token = "0x400948C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mAwakeIconBgArray;
    [Token(Token = "0x400948D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray mProgressLine;
    [Token(Token = "0x400948E")]
    [FieldOffset(Offset = "0x1C")]
    private int mCreatedCount;
    [Token(Token = "0x400948F")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsEnable;

    [Token(Token = "0x1700142A")]
    public bool IsEnable
    {
      [Token(Token = "0x6008EE4"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008EE5")]
    [Address(RVA = "0x521710", Offset = "0x520510", VA = "0x10521710")]
    public void Setup(
      ConceptCardEffectsParam[] effect_params,
      int awake_count,
      int awake_count_cap,
      bool is_enable)
    {
    }

    [Token(Token = "0x6008EE6")]
    [Address(RVA = "0x5216C0", Offset = "0x5204C0", VA = "0x105216C0")]
    public void SetProgressLineImage(bool is_enable, bool is_active = true)
    {
    }

    [Token(Token = "0x6008EE7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardBonusContentAwake()
    {
    }
  }
}
