// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactEvolutionSlider
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
  [Token(Token = "0x2001FE2")]
  public class ArtifactEvolutionSlider : MonoBehaviour
  {
    [Token(Token = "0x4008761")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ArtifactWindow mArtifactWindow;
    [Token(Token = "0x4008762")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x4008763")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ArtifactEvolutionSliderContent mContent;
    [Token(Token = "0x4008764")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button mAutoMaxBtn;
    [Token(Token = "0x4008765")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mAllClearBtn;
    [Token(Token = "0x4008766")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mNeedCountTxt;
    [Token(Token = "0x4008767")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mMaxCountTxt;
    [Token(Token = "0x4008768")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Color mNeedCountColorOk;
    [Token(Token = "0x4008769")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Color mNeedCountColorNg;
    [Token(Token = "0x400876A")]
    [FieldOffset(Offset = "0x48")]
    private ArtifactData mArtifactData;
    [Token(Token = "0x400876B")]
    [FieldOffset(Offset = "0x4C")]
    private List<ArtifactEvolutionSliderContent> mContentList;
    [Token(Token = "0x400876C")]
    [FieldOffset(Offset = "0x50")]
    private int mNeedNum;
    [Token(Token = "0x400876D")]
    [FieldOffset(Offset = "0x54")]
    private int mSelectNum;

    [Token(Token = "0x6008370")]
    [Address(RVA = "0x440330", Offset = "0x43F130", VA = "0x10440330")]
    private void Start()
    {
    }

    [Token(Token = "0x6008371")]
    [Address(RVA = "0x43F280", Offset = "0x43E080", VA = "0x1043F280")]
    public void Init(ArtifactData target)
    {
    }

    [Token(Token = "0x6008372")]
    [Address(RVA = "0x43FF10", Offset = "0x43ED10", VA = "0x1043FF10")]
    private void OnSelectUseNumChanged(ArtifactEvolutionSliderContent content, float value)
    {
    }

    [Token(Token = "0x6008373")]
    [Address(RVA = "0x43FC50", Offset = "0x43EA50", VA = "0x1043FC50")]
    private void OnClickMaxBtn(GameObject go)
    {
    }

    [Token(Token = "0x6008374")]
    [Address(RVA = "0x43FAE0", Offset = "0x43E8E0", VA = "0x1043FAE0")]
    private void OnClickClear(GameObject go)
    {
    }

    [Token(Token = "0x6008375")]
    [Address(RVA = "0x440530", Offset = "0x43F330", VA = "0x10440530")]
    private void UpdateButtonIntaractableAll()
    {
    }

    [Token(Token = "0x6008376")]
    [Address(RVA = "0x43EEE0", Offset = "0x43DCE0", VA = "0x1043EEE0")]
    private int[] GetMaxToggleSetting() => (int[]) null;

    [Token(Token = "0x6008377")]
    [Address(RVA = "0x4408A0", Offset = "0x43F6A0", VA = "0x104408A0")]
    private void UpdateMaxToggleSetting()
    {
    }

    [Token(Token = "0x6008378")]
    [Address(RVA = "0x43FAC0", Offset = "0x43E8C0", VA = "0x1043FAC0")]
    public bool IsNeedMaterialOk() => new bool();

    [Token(Token = "0x6008379")]
    [Address(RVA = "0x43F000", Offset = "0x43DE00", VA = "0x1043F000")]
    public ReqArtifactAddRare.Materials[] GetSelectMaterialData()
    {
      return (ReqArtifactAddRare.Materials[]) null;
    }

    [Token(Token = "0x600837A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactEvolutionSlider()
    {
    }
  }
}
