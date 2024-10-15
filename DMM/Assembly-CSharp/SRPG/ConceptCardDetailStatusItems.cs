// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailStatusItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021F7")]
  [AddComponentMenu("UI/ConceptCardDetailStatusItems")]
  public class ConceptCardDetailStatusItems : MonoBehaviour
  {
    [Token(Token = "0x4009598")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mGroupNameField;
    [Token(Token = "0x4009599")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private StatusList mStatusList;
    [Token(Token = "0x400959A")]
    [FieldOffset(Offset = "0x14")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x400959B")]
    [FieldOffset(Offset = "0x18")]
    private ConceptCardEffectsParam mConceptCardEffectsParam;
    [Token(Token = "0x400959C")]
    [FieldOffset(Offset = "0x1C")]
    private int mAddExp;
    [Token(Token = "0x400959D")]
    [FieldOffset(Offset = "0x20")]
    private int mAddAwakeLv;
    [Token(Token = "0x400959E")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsEnhance;
    [Token(Token = "0x400959F")]
    [FieldOffset(Offset = "0x25")]
    private bool mIsBaseParam;

    [Token(Token = "0x6008FA9")]
    [Address(RVA = "0x52AE90", Offset = "0x529C90", VA = "0x1052AE90")]
    public void SetParam(
      ConceptCardData conceptCardData,
      ConceptCardEffectsParam conceptCardEffectsParam,
      int addExp,
      int addAwakeLv,
      bool isEnhance,
      bool isBaseParam)
    {
    }

    [Token(Token = "0x6008FAA")]
    [Address(RVA = "0x52AE30", Offset = "0x529C30", VA = "0x1052AE30")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008FAB")]
    [Address(RVA = "0x52AC90", Offset = "0x529A90", VA = "0x1052AC90")]
    private void RefreshEquipTarget(ConceptCardEffectsParam equipParam)
    {
    }

    [Token(Token = "0x6008FAC")]
    [Address(RVA = "0x52A930", Offset = "0x529730", VA = "0x1052A930")]
    private bool RefreshEquipParam(
      ConceptCardData conceptCardData,
      ConceptCardEffectsParam equipParam)
    {
      return new bool();
    }

    [Token(Token = "0x6008FAD")]
    [Address(RVA = "0x52A7C0", Offset = "0x5295C0", VA = "0x1052A7C0")]
    public bool IsValueEmpty(BaseStatus paramAdd, BaseStatus paramMul) => new bool();

    [Token(Token = "0x6008FAE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetailStatusItems()
    {
    }
  }
}
