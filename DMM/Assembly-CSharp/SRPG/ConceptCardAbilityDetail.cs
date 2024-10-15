// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardAbilityDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021D2")]
  [AddComponentMenu("UI/ConceptCardAbilityDetail")]
  public class ConceptCardAbilityDetail : MonoBehaviour
  {
    [Token(Token = "0x4009472")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mAbilityName;
    [Token(Token = "0x4009473")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mDescriptionText;

    [Token(Token = "0x6008ECA")]
    [Address(RVA = "0x520750", Offset = "0x51F550", VA = "0x10520750")]
    private void Start()
    {
    }

    [Token(Token = "0x6008ECB")]
    [Address(RVA = "0x5200E0", Offset = "0x51EEE0", VA = "0x105200E0")]
    public void SetData(ConceptCardSkillDatailData data)
    {
    }

    [Token(Token = "0x6008ECC")]
    [Address(RVA = "0x520390", Offset = "0x51F190", VA = "0x10520390")]
    public void SetSkillData(ConceptCardEquipEffect effect)
    {
    }

    [Token(Token = "0x6008ECD")]
    [Address(RVA = "0x51FFC0", Offset = "0x51EDC0", VA = "0x1051FFC0")]
    public void SetAbilityData(ConceptCardEquipEffect effect)
    {
    }

    [Token(Token = "0x6008ECE")]
    [Address(RVA = "0x520120", Offset = "0x51EF20", VA = "0x10520120")]
    public void SetGroup(ConceptCardSkillDatailData data)
    {
    }

    [Token(Token = "0x6008ECF")]
    [Address(RVA = "0x5206E0", Offset = "0x51F4E0", VA = "0x105206E0")]
    public void SetText(Text text, string str)
    {
    }

    [Token(Token = "0x6008ED0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardAbilityDetail()
    {
    }
  }
}
