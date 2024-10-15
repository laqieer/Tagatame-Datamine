// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPartyContent
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
  [Token(Token = "0x2002603")]
  [AddComponentMenu("UI/GvG/GvGPartyContent")]
  public class GvGPartyContent : MonoBehaviour
  {
    [Token(Token = "0x400B0E0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool IsSelf;
    [Token(Token = "0x400B0E1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(10f)]
    private string SVB_HpbGaugeName;
    [Token(Token = "0x400B0E2")]
    [FieldOffset(Offset = "0x14")]
    [Space(10f)]
    [SerializeField]
    private string SVB_HDeadName;
    [Token(Token = "0x400B0E3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(10f)]
    private GenericSlot UnitSlotTemplate;
    [Token(Token = "0x400B0E4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GenericSlot ConceptCardSlotTemplate;
    [Token(Token = "0x400B0E5")]
    [FieldOffset(Offset = "0x20")]
    [Space(10f)]
    [SerializeField]
    private Text TeamText;
    [Token(Token = "0x400B0E6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ImageArray RoleImageArray;
    [Token(Token = "0x400B0E7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text PlayerNameText;
    [Token(Token = "0x400B0E8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Slider StaminaSlider;
    [Token(Token = "0x400B0E9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray StaminaImageArray;
    [Token(Token = "0x400B0EA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Space(10f)]
    private GameObject mHpGauge;
    [Token(Token = "0x400B0EB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button UnitSlotEditorButton;
    [Token(Token = "0x400B0EC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button ConceptCardSlotEditorButton;
    [Token(Token = "0x400B0ED")]
    [FieldOffset(Offset = "0x40")]
    [Space(10f)]
    [SerializeField]
    private Text BeatNumText;
    [Token(Token = "0x400B0EF")]
    [FieldOffset(Offset = "0x48")]
    private List<GenericSlot> UnitList;
    [Token(Token = "0x400B0F0")]
    [FieldOffset(Offset = "0x4C")]
    private List<GenericSlot> CardList;

    [Token(Token = "0x170017DC")]
    public GvGParty Party
    {
      [Token(Token = "0x600A954"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (GvGParty) null;
      }
      [Token(Token = "0x600A955"), Address(RVA = "0x2886E0", Offset = "0x2874E0", VA = "0x102886E0")] private set
      {
      }
    }

    [Token(Token = "0x600A956")]
    [Address(RVA = "0x6C6FA0", Offset = "0x6C5DA0", VA = "0x106C6FA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A957")]
    [Address(RVA = "0x6C7C90", Offset = "0x6C6A90", VA = "0x106C7C90")]
    public bool Setup(GvGNodeData node, int number, GvGParty party) => new bool();

    [Token(Token = "0x600A958")]
    [Address(RVA = "0x6C7010", Offset = "0x6C5E10", VA = "0x106C7010")]
    public bool SetupParty(GvGNodeData node, int number, GvGParty party) => new bool();

    [Token(Token = "0x600A959")]
    [Address(RVA = "0x6C7CB0", Offset = "0x6C6AB0", VA = "0x106C7CB0")]
    public GvGPartyContent()
    {
    }
  }
}
