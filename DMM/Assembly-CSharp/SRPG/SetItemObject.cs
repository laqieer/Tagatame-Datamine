// Decompiled with JetBrains decompiler
// Type: SRPG.SetItemObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200110C")]
  [AddComponentMenu("Common/SetItemObject")]
  public class SetItemObject : MonoBehaviour
  {
    [Token(Token = "0x4003D9B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public GameObject UnitIcon;
    [Token(Token = "0x4003D9C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public GameObject AwardIcon;
    [Token(Token = "0x4003D9D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public GameObject ArtifactIcon;
    [Token(Token = "0x4003D9E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject GoldIcon;
    [Token(Token = "0x4003D9F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public GameObject CoinIcon;
    [Token(Token = "0x4003DA0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public GameObject ItemIcon;
    [Token(Token = "0x4003DA1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public GameObject CardIcon;
    [Token(Token = "0x4003DA2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text ItemDesc;

    [Token(Token = "0x6004854")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6004855")]
    [Address(RVA = "0x11F4CD0", Offset = "0x11F3AD0", VA = "0x111F4CD0")]
    public void SetupConceptCard(ConceptCardData concept_card_data)
    {
    }

    [Token(Token = "0x6004856")]
    [Address(RVA = "0x11F41B0", Offset = "0x11F2FB0", VA = "0x111F41B0")]
    public void SetIconActive(GiftTypes gift_type)
    {
    }

    [Token(Token = "0x6004857")]
    [Address(RVA = "0x11F4590", Offset = "0x11F3390", VA = "0x111F4590")]
    public void SetItemDesc(GiftTypes gift_type, string name, int num)
    {
    }

    [Token(Token = "0x6004858")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SetItemObject()
    {
    }
  }
}
