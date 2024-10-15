// Decompiled with JetBrains decompiler
// Type: SRPG.RewardWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002953")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/RewardWindow")]
  public class RewardWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C720")]
    [FieldOffset(Offset = "0xC")]
    public bool RefreshOnStart;
    [Token(Token = "0x400C721")]
    [FieldOffset(Offset = "0xD")]
    public bool UseGlobalVar;
    [Token(Token = "0x400C722")]
    [FieldOffset(Offset = "0xE")]
    public bool UseBindDataOnly;
    [Token(Token = "0x400C723")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ExpRow;
    [Token(Token = "0x400C724")]
    [FieldOffset(Offset = "0x14")]
    public GameObject GoldRow;
    [Token(Token = "0x400C725")]
    [FieldOffset(Offset = "0x18")]
    public GameObject CoinRow;
    [Token(Token = "0x400C726")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ArenaMedalRow;
    [Token(Token = "0x400C727")]
    [FieldOffset(Offset = "0x20")]
    public GameObject MultiCoinRow;
    [Token(Token = "0x400C728")]
    [FieldOffset(Offset = "0x24")]
    public GameObject KakeraCoinRow;
    [Token(Token = "0x400C729")]
    [FieldOffset(Offset = "0x28")]
    public GameObject StaminaRow;
    [Token(Token = "0x400C72A")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ItemSeparator;
    [Token(Token = "0x400C72B")]
    [FieldOffset(Offset = "0x30")]
    public GameObject ItemList;
    [Token(Token = "0x400C72C")]
    [FieldOffset(Offset = "0x34")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C72D")]
    [FieldOffset(Offset = "0x38")]
    public GameObject EventCoinTemplate;
    [Token(Token = "0x400C72E")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject ArtifactTemplate;
    [Token(Token = "0x400C72F")]
    [FieldOffset(Offset = "0x40")]
    public GameObject ArtifactTemplate2;
    [Token(Token = "0x400C730")]
    [FieldOffset(Offset = "0x44")]
    public GameObject UnitTemplate;
    [Token(Token = "0x400C731")]
    [FieldOffset(Offset = "0x48")]
    public GameObject ConceptCardTemplate;
    [Token(Token = "0x400C732")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject Caution;
    [Token(Token = "0x400C733")]
    [FieldOffset(Offset = "0x50")]
    public GameObject CrystalTemplate;
    [Token(Token = "0x400C734")]
    [FieldOffset(Offset = "0x54")]
    protected List<GameObject> mItems;

    [Token(Token = "0x600BAE7")]
    [Address(RVA = "0x827520", Offset = "0x826320", VA = "0x10827520", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAE8")]
    [Address(RVA = "0x827550", Offset = "0x826350", VA = "0x10827550")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BAE9")]
    [Address(RVA = "0x828D00", Offset = "0x827B00", VA = "0x10828D00")]
    private void Start()
    {
    }

    [Token(Token = "0x600BAEA")]
    [Address(RVA = "0x828360", Offset = "0x827160", VA = "0x10828360", Slot = "5")]
    public virtual void Refresh()
    {
    }

    [Token(Token = "0x600BAEB")]
    [Address(RVA = "0x827E30", Offset = "0x826C30", VA = "0x10827E30")]
    private void RefreshItems(RewardData reward, Transform itemParent, GameObject template)
    {
    }

    [Token(Token = "0x600BAEC")]
    [Address(RVA = "0x827790", Offset = "0x826590", VA = "0x10827790")]
    private void RefreshArtifacts(RewardData reward, Transform itemParent, GameObject template)
    {
    }

    [Token(Token = "0x600BAED")]
    [Address(RVA = "0x827990", Offset = "0x826790", VA = "0x10827990")]
    private void RefreshConceptCards(RewardData reward, Transform itemParent, GameObject template)
    {
    }

    [Token(Token = "0x600BAEE")]
    [Address(RVA = "0x828110", Offset = "0x826F10", VA = "0x10828110")]
    private void RefreshUnits(RewardData reward, Transform itemParent, GameObject template)
    {
    }

    [Token(Token = "0x600BAEF")]
    [Address(RVA = "0x827BE0", Offset = "0x8269E0", VA = "0x10827BE0")]
    private void RefreshCrystal(RewardData _data, Transform _parent, GameObject _template)
    {
    }

    [Token(Token = "0x600BAF0")]
    [Address(RVA = "0x8274B0", Offset = "0x8262B0", VA = "0x108274B0")]
    public RewardWindow()
    {
    }
  }
}
