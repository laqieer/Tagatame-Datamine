// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardCheckWindow
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
  [Token(Token = "0x20021DC")]
  [AddComponentMenu("UI/ConceptCardCheckWindow")]
  public class ConceptCardCheckWindow : MonoBehaviour
  {
    [Token(Token = "0x40094A1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform ListParent;
    [Token(Token = "0x40094A2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ListItemTemplate;
    [Token(Token = "0x40094A3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text GetExp;
    [Token(Token = "0x40094A4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text UsedZenny;
    [Token(Token = "0x40094A5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text GetTrust;
    [Token(Token = "0x40094A6")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, int> mSelectedCard;
    [Token(Token = "0x40094A7")]
    [FieldOffset(Offset = "0x24")]
    private List<ConceptCardIcon> mConceptCardIcon;

    [Token(Token = "0x6008EEE")]
    [Address(RVA = "0x5232F0", Offset = "0x5220F0", VA = "0x105232F0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008EEF")]
    [Address(RVA = "0x522D10", Offset = "0x521B10", VA = "0x10522D10")]
    private void CreateMakeCardIcon()
    {
    }

    [Token(Token = "0x6008EF0")]
    [Address(RVA = "0x523110", Offset = "0x521F10", VA = "0x10523110")]
    private void SetupText()
    {
    }

    [Token(Token = "0x6008EF1")]
    [Address(RVA = "0x523310", Offset = "0x522110", VA = "0x10523310")]
    public ConceptCardCheckWindow()
    {
    }
  }
}
