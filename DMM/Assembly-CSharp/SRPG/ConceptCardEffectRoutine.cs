// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEffectRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021F8")]
  public class ConceptCardEffectRoutine
  {
    [Token(Token = "0x40095A0")]
    private const string mLeveUpPrefabPath = "UI/ConceptCardLevelup";
    [Token(Token = "0x40095A1")]
    private const string mAwakePrefabPath = "UI/ConceptCardLimitUp";
    [Token(Token = "0x40095A2")]
    private const string mTrustMasterPrefabPath = "UI/ConceptCardTrustMaster";
    [Token(Token = "0x40095A3")]
    private const string mTrustMasterRewardPrefabPath = "UI/ConceptCardTrustMasterReward";
    [Token(Token = "0x40095A4")]
    private const string mGroupSkillPowerUpPrefabPath = "UI/ConceptCardSkillPowerUp";
    [Token(Token = "0x40095A5")]
    private const string mGroupMaxPowerUpPrefabPath = "UI/ConceptCardMaxPowerUp";
    [Token(Token = "0x40095A6")]
    private const string mGroupMaxPowerResultPrefabPath = "UI/ConceptCardMaxPowerUpGroupSkillList";
    [Token(Token = "0x40095A7")]
    private const string mExtraRarityOpenPrefabPath = "UI/ConceptCard/ConceptCardExtraRarityOpen";

    [Token(Token = "0x6008FAF")]
    [Address(RVA = "0x52D8A0", Offset = "0x52C6A0", VA = "0x1052D8A0")]
    public IEnumerator PlayLevelup(Canvas overlayCanvas) => (IEnumerator) null;

    [Token(Token = "0x6008FB0")]
    [Address(RVA = "0x52D690", Offset = "0x52C490", VA = "0x1052D690")]
    public IEnumerator PlayAwake(Canvas overlayCanvas) => (IEnumerator) null;

    [Token(Token = "0x6008FB1")]
    [Address(RVA = "0x52D990", Offset = "0x52C790", VA = "0x1052D990")]
    public IEnumerator PlayTrustMaster(Canvas overlayCanvas, ConceptCardData data)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008FB2")]
    [Address(RVA = "0x52D910", Offset = "0x52C710", VA = "0x1052D910")]
    public IEnumerator PlayTrustMasterReward(Canvas overlayCanvas, ConceptCardData data)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008FB3")]
    [Address(RVA = "0x52D810", Offset = "0x52C610", VA = "0x1052D810")]
    public IEnumerator PlayGroupSkilPowerUp(
      Canvas overlayCanvas,
      ConceptCardData data,
      ConceptCardEffectRoutine.EffectAltData altData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008FB4")]
    [Address(RVA = "0x52D780", Offset = "0x52C580", VA = "0x1052D780")]
    public IEnumerator PlayGroupSkilMaxPowerUp(
      Canvas overlayCanvas,
      ConceptCardData data,
      ConceptCardEffectRoutine.EffectAltData altData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008FB5")]
    [Address(RVA = "0x52D700", Offset = "0x52C500", VA = "0x1052D700")]
    public IEnumerator PlayExtraRarity(Canvas overlayCanvas, ConceptCardData data)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008FB6")]
    [Address(RVA = "0x52D5F0", Offset = "0x52C3F0", VA = "0x1052D5F0")]
    private IEnumerator EffectRoutine(
      Canvas overlayCanvas,
      string path,
      ConceptCardEffectRoutine.EffectType type = ConceptCardEffectRoutine.EffectType.DEFAULT,
      ConceptCardData data = null,
      ConceptCardEffectRoutine.EffectAltData altData = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008FB7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardEffectRoutine()
    {
    }

    [Token(Token = "0x20021F9")]
    public enum EffectType
    {
      [Token(Token = "0x40095A9")] DEFAULT,
      [Token(Token = "0x40095AA")] TRUST_MASTER,
      [Token(Token = "0x40095AB")] TRUST_MASTER_REWARD,
      [Token(Token = "0x40095AC")] GROUP_SKILL_POWER_UP,
      [Token(Token = "0x40095AD")] GROUP_SKILL_MAX_POWER_UP,
      [Token(Token = "0x40095AE")] EXTRA_RARITY,
    }

    [Token(Token = "0x20021FA")]
    public class EffectAltData
    {
      [Token(Token = "0x40095AF")]
      [FieldOffset(Offset = "0x8")]
      public int prevAwakeCount;
      [Token(Token = "0x40095B0")]
      [FieldOffset(Offset = "0xC")]
      public int prevLevel;

      [Token(Token = "0x6008FB8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EffectAltData()
      {
      }
    }
  }
}
