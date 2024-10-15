// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002135")]
  [AddComponentMenu("UI/ChallengeMissionRewardItem")]
  public class ChallengeMissionRewardItem : MonoBehaviour
  {
    [Token(Token = "0x4009091")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ImageItem;
    [Token(Token = "0x4009092")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ImageExp;
    [Token(Token = "0x4009093")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ImageGold;
    [Token(Token = "0x4009094")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ImageStamina;
    [Token(Token = "0x4009095")]
    [FieldOffset(Offset = "0x1C")]
    public Text TextReward;
    [Token(Token = "0x4009096")]
    [FieldOffset(Offset = "0x20")]
    public ConceptCardIcon ConceptCardObject;
    [Token(Token = "0x4009097")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ImageUnit;

    [Token(Token = "0x6008B5E")]
    [Address(RVA = "0x4F4390", Offset = "0x4F3190", VA = "0x104F4390")]
    private void ResetAll()
    {
    }

    [Token(Token = "0x6008B5F")]
    [Address(RVA = "0x4F4950", Offset = "0x4F3750", VA = "0x104F4950")]
    public void SetGold(int num)
    {
    }

    [Token(Token = "0x6008B60")]
    [Address(RVA = "0x4F4840", Offset = "0x4F3640", VA = "0x104F4840")]
    public void SetEXP(int exp)
    {
    }

    [Token(Token = "0x6008B61")]
    [Address(RVA = "0x4F4C90", Offset = "0x4F3A90", VA = "0x104F4C90")]
    public void SetStamina(int stamina)
    {
    }

    [Token(Token = "0x6008B62")]
    [Address(RVA = "0x4F4550", Offset = "0x4F3350", VA = "0x104F4550")]
    public void SetCoin(int coin)
    {
    }

    [Token(Token = "0x6008B63")]
    [Address(RVA = "0x4F4A40", Offset = "0x4F3840", VA = "0x104F4A40")]
    public void SetItem(string iname, int num)
    {
    }

    [Token(Token = "0x6008B64")]
    [Address(RVA = "0x4F46C0", Offset = "0x4F34C0", VA = "0x104F46C0")]
    public void SetConceptCard(string iname, int num)
    {
    }

    [Token(Token = "0x6008B65")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChallengeMissionRewardItem()
    {
    }
  }
}
