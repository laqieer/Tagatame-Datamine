// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002115")]
  [AddComponentMenu("UI/BuyCoinItemDetail")]
  public class BuyCoinItemDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008F5A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemDetailWindow;
    [Token(Token = "0x4008F5B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ArtifactDetailWindow;
    [Token(Token = "0x4008F5C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ConceptCardDetail;
    [Token(Token = "0x4008F5D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text DetailTitle;
    [Token(Token = "0x4008F5E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject ItemIcon;
    [Token(Token = "0x4008F5F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RewardListItem ItemIconList;

    [Token(Token = "0x6008A94")]
    [Address(RVA = "0x4E31A0", Offset = "0x4E1FA0", VA = "0x104E31A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008A95")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008A96")]
    [Address(RVA = "0x4E27A0", Offset = "0x4E15A0", VA = "0x104E27A0")]
    public void OnButtonItem(GameObject go)
    {
    }

    [Token(Token = "0x6008A97")]
    [Address(RVA = "0x4E2490", Offset = "0x4E1290", VA = "0x104E2490")]
    public void OnButtonAtrifact(GameObject go)
    {
    }

    [Token(Token = "0x6008A98")]
    [Address(RVA = "0x4E25C0", Offset = "0x4E13C0", VA = "0x104E25C0")]
    public void OnButtonConceptCard(GameObject go)
    {
    }

    [Token(Token = "0x6008A99")]
    [Address(RVA = "0x4E28F0", Offset = "0x4E16F0", VA = "0x104E28F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008A9A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BuyCoinItemDetail()
    {
    }
  }
}
