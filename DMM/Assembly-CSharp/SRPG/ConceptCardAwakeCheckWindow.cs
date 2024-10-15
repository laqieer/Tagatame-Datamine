// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardAwakeCheckWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021D7")]
  [AddComponentMenu("UI/ConceptCardAwakeCheckWindow")]
  public class ConceptCardAwakeCheckWindow : MonoBehaviour
  {
    [Token(Token = "0x4009483")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform ListParent;
    [Token(Token = "0x4009484")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ListItemTemplate;
    [Token(Token = "0x4009485")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject StarStatusParent;
    [Token(Token = "0x4009486")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject AfterStarStatus;
    [Token(Token = "0x4009487")]
    [FieldOffset(Offset = "0x1C")]
    private ConceptCardData mCurrentConceptCard;
    [Token(Token = "0x4009488")]
    [FieldOffset(Offset = "0x20")]
    private int mUpCount;
    [Token(Token = "0x4009489")]
    [FieldOffset(Offset = "0x24")]
    private int mCurrentAwakeCount;

    [Token(Token = "0x6008EDF")]
    [Address(RVA = "0x521630", Offset = "0x520430", VA = "0x10521630")]
    private void Start()
    {
    }

    [Token(Token = "0x6008EE0")]
    [Address(RVA = "0x520EB0", Offset = "0x51FCB0", VA = "0x10520EB0")]
    private void CreateItemIcon()
    {
    }

    [Token(Token = "0x6008EE1")]
    [Address(RVA = "0x5215A0", Offset = "0x5203A0", VA = "0x105215A0")]
    private void SetupText()
    {
    }

    [Token(Token = "0x6008EE2")]
    [Address(RVA = "0x521250", Offset = "0x520050", VA = "0x10521250")]
    private void RefreshAwakeIcons(int add_awake_count)
    {
    }

    [Token(Token = "0x6008EE3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardAwakeCheckWindow()
    {
    }
  }
}
