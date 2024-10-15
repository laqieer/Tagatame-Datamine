// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardIconEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002214")]
  public class ConceptCardIconEx : MonoBehaviour
  {
    [Token(Token = "0x4009699")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400969A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mRarityParent;
    [Token(Token = "0x400969B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRarityTemp;
    [Token(Token = "0x400969C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool mIsIncludeOverWrite;
    [Token(Token = "0x400969D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueList mVisibleList;
    [Token(Token = "0x400969E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button mButton;
    [Token(Token = "0x400969F")]
    [FieldOffset(Offset = "0x24")]
    private ConceptCardIconExModel mModel;

    [Token(Token = "0x1700146A")]
    public ConceptCardData ConceptCardData
    {
      [Token(Token = "0x6009089"), Address(RVA = "0x53A050", Offset = "0x538E50", VA = "0x1053A050")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x1700146B")]
    public ConceptCardParam ConceptCardParam
    {
      [Token(Token = "0x600908A"), Address(RVA = "0x53A070", Offset = "0x538E70", VA = "0x1053A070")] get
      {
        return (ConceptCardParam) null;
      }
    }

    [Token(Token = "0x1700146C")]
    public bool IsIncludeOverWrite
    {
      [Token(Token = "0x600908B"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] set
      {
      }
      [Token(Token = "0x600908C"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600908D")]
    [Address(RVA = "0x5397A0", Offset = "0x5385A0", VA = "0x105397A0")]
    public void Initialize(ConceptCardParam param)
    {
    }

    [Token(Token = "0x600908E")]
    [Address(RVA = "0x539880", Offset = "0x538680", VA = "0x10539880")]
    public void Initialize(ConceptCardData data)
    {
    }

    [Token(Token = "0x600908F")]
    [Address(RVA = "0x539820", Offset = "0x538620", VA = "0x10539820")]
    public void Initialize(UnitData unitData, ConceptCardData.ESlotIndex slotIndex)
    {
    }

    [Token(Token = "0x6009090")]
    [Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")]
    public void Initialize(ConceptCardIconExModel model)
    {
    }

    [Token(Token = "0x6009091")]
    [Address(RVA = "0x53A040", Offset = "0x538E40", VA = "0x1053A040")]
    public void Setup(ConceptCardData data)
    {
    }

    [Token(Token = "0x6009092")]
    [Address(RVA = "0x539A10", Offset = "0x538810", VA = "0x10539A10")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009093")]
    [Address(RVA = "0x5399F0", Offset = "0x5387F0", VA = "0x105399F0")]
    public void Refresh(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x6009094")]
    [Address(RVA = "0x539AF0", Offset = "0x5388F0", VA = "0x10539AF0")]
    public void SetDisplay()
    {
    }

    [Token(Token = "0x6009095")]
    [Address(RVA = "0x539D30", Offset = "0x538B30", VA = "0x10539D30")]
    public void SetRarity()
    {
    }

    [Token(Token = "0x6009096")]
    [Address(RVA = "0x53A020", Offset = "0x538E20", VA = "0x1053A020")]
    public void SetVisible(ConceptCardIconExModel.VisibleKey key, bool isFlag)
    {
    }

    [Token(Token = "0x6009097")]
    [Address(RVA = "0x539AA0", Offset = "0x5388A0", VA = "0x10539AA0")]
    public void ResetIcon()
    {
    }

    [Token(Token = "0x6009098")]
    [Address(RVA = "0x53A000", Offset = "0x538E00", VA = "0x1053A000")]
    public void SetTrustText(int trust)
    {
    }

    [Token(Token = "0x6009099")]
    [Address(RVA = "0x539CF0", Offset = "0x538AF0", VA = "0x10539CF0")]
    public void SetNoRewardTrustText()
    {
    }

    [Token(Token = "0x600909A")]
    [Address(RVA = "0x539AD0", Offset = "0x5388D0", VA = "0x10539AD0")]
    public void SetCardNum(int num)
    {
    }

    [Token(Token = "0x600909B")]
    [Address(RVA = "0x539D10", Offset = "0x538B10", VA = "0x10539D10")]
    public void SetNotSellFlag(bool flag)
    {
    }

    [Token(Token = "0x600909C")]
    [Address(RVA = "0x539FE0", Offset = "0x538DE0", VA = "0x10539FE0")]
    public void SetRecommendFlag(bool flag)
    {
    }

    [Token(Token = "0x600909D")]
    [Address(RVA = "0x539900", Offset = "0x538700", VA = "0x10539900")]
    public void RefreshEnableParam(bool enable)
    {
    }

    [Token(Token = "0x600909E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardIconEx()
    {
    }
  }
}
