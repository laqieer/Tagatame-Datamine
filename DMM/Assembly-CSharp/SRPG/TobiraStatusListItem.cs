// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraStatusListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B33")]
  [AddComponentMenu("UI/TobiraStatusListItem")]
  public class TobiraStatusListItem : MonoBehaviour
  {
    [Token(Token = "0x400D2E5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_TextTobiraName;
    [Token(Token = "0x400D2E6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray m_IconTobira;
    [Token(Token = "0x400D2E7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_ObjectDetail;
    [Token(Token = "0x400D2E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_ObjectLock;
    [Token(Token = "0x400D2E9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject m_ObjectCommingSoon;
    [Token(Token = "0x400D2EA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TobiraLearnSkill m_TobiraLearnSkillTemplate;
    [Token(Token = "0x400D2EB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RectTransform m_TobiraLearnSkillParent;
    [Token(Token = "0x400D2EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StatusList m_StatusList;
    [Token(Token = "0x400D2ED")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject m_TobiraLvMaxObject;
    [Token(Token = "0x400D2EE")]
    [FieldOffset(Offset = "0x30")]
    private TobiraParam.Category m_Category;
    [Token(Token = "0x400D2EF")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject m_PlusConceptCardSlot;
    [Token(Token = "0x400D2F0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject m_UnlockTruthEquipment;
    [Token(Token = "0x400D2F1")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject m_Decrease_effect;
    [Token(Token = "0x400D2F2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Color m_DecreaseTextColor;

    [Token(Token = "0x600C5B3")]
    [Address(RVA = "0x8E4450", Offset = "0x8E3250", VA = "0x108E4450")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5B4")]
    [Address(RVA = "0x8E3A20", Offset = "0x8E2820", VA = "0x108E3A20")]
    public void Setup(TobiraData tobiraData)
    {
    }

    [Token(Token = "0x600C5B5")]
    [Address(RVA = "0x8E4240", Offset = "0x8E3040", VA = "0x108E4240")]
    public void Setup(TobiraParam param)
    {
    }

    [Token(Token = "0x600C5B6")]
    [Address(RVA = "0x8E39D0", Offset = "0x8E27D0", VA = "0x108E39D0")]
    public void SetTobiraLvIsMax(bool isMax)
    {
    }

    [Token(Token = "0x600C5B7")]
    [Address(RVA = "0x8E3910", Offset = "0x8E2710", VA = "0x108E3910")]
    private TobiraLearnSkill CreateListItem() => (TobiraLearnSkill) null;

    [Token(Token = "0x600C5B8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TobiraStatusListItem()
    {
    }
  }
}
