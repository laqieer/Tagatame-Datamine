// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002003")]
  public class ArtifactIconNode : ContentNode
  {
    [Token(Token = "0x4008896")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ArtifactIcon Icon;
    [Token(Token = "0x4008897")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private SwitchingBadge mSwitchingBadge;
    [Token(Token = "0x4008898")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public GameObject RecommendObject;
    [Token(Token = "0x4008899")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public GameObject SelectObject;
    [Token(Token = "0x400889A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public GameObject EmptyObject;
    [Token(Token = "0x400889B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public GameObject mGvGUsedItem;
    [Token(Token = "0x400889C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mGvGUsedText;
    [Token(Token = "0x400889D")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mOrganization;
    [Token(Token = "0x400889E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mBeforeUsed;
    [Token(Token = "0x400889F")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mLevelObject;
    [Token(Token = "0x40088A0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private SortBadge mSortBadge;

    [Token(Token = "0x600843D")]
    [Address(RVA = "0x44CDA0", Offset = "0x44BBA0", VA = "0x1044CDA0")]
    public void Setup(ArtifactData arti_data)
    {
    }

    [Token(Token = "0x600843E")]
    [Address(RVA = "0x44CEE0", Offset = "0x44BCE0", VA = "0x1044CEE0")]
    public void Setup(ArtifactParam arti_param)
    {
    }

    [Token(Token = "0x600843F")]
    [Address(RVA = "0x44BFB0", Offset = "0x44ADB0", VA = "0x1044BFB0")]
    public void Empty(bool is_enmpty)
    {
    }

    [Token(Token = "0x6008440")]
    [Address(RVA = "0x44C0B0", Offset = "0x44AEB0", VA = "0x1044C0B0")]
    public void Enable(bool enable)
    {
    }

    [Token(Token = "0x6008441")]
    [Address(RVA = "0x44CBF0", Offset = "0x44B9F0", VA = "0x1044CBF0")]
    public void SetSpecialDisplay(bool disp)
    {
    }

    [Token(Token = "0x6008442")]
    [Address(RVA = "0x44C400", Offset = "0x44B200", VA = "0x1044C400")]
    public void Select(bool select)
    {
    }

    [Token(Token = "0x6008443")]
    [Address(RVA = "0x44C270", Offset = "0x44B070", VA = "0x1044C270")]
    public void Recommend(bool is_recommend)
    {
    }

    [Token(Token = "0x6008444")]
    [Address(RVA = "0x44CC80", Offset = "0x44BA80", VA = "0x1044CC80")]
    public void SetUsedActive(bool is_enable)
    {
    }

    [Token(Token = "0x6008445")]
    [Address(RVA = "0x44C6F0", Offset = "0x44B4F0", VA = "0x1044C6F0")]
    public void SetOrganization(ArtifactData data)
    {
    }

    [Token(Token = "0x6008446")]
    [Address(RVA = "0x44C4C0", Offset = "0x44B2C0", VA = "0x1044C4C0")]
    public bool SetBeforeUsed(ArtifactData data) => new bool();

    [Token(Token = "0x6008447")]
    [Address(RVA = "0x44C960", Offset = "0x44B760", VA = "0x1044C960")]
    public void SetSortData(ArtifactData data)
    {
    }

    [Token(Token = "0x6008448")]
    [Address(RVA = "0x44C1A0", Offset = "0x44AFA0", VA = "0x1044C1A0")]
    private void LeagueMatchUsed(bool isEnable)
    {
    }

    [Token(Token = "0x6008449")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public ArtifactIconNode()
    {
    }
  }
}
