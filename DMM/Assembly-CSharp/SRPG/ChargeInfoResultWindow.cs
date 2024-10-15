// Decompiled with JetBrains decompiler
// Type: SRPG.ChargeInfoResultWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200214C")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Skip", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "Close", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("UI/ChargeInfoResultWindow")]
  public class ChargeInfoResultWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40090FB")]
    private const int INPUT_REFRESH = 0;
    [Token(Token = "0x40090FC")]
    private const int INPUT_SKIP = 10;
    [Token(Token = "0x40090FD")]
    private const int OUTPUT_CLOSE = 20;
    [Token(Token = "0x40090FE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x40090FF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject UnitTemplate;
    [Token(Token = "0x4009100")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ArtifactTemplate;
    [Token(Token = "0x4009101")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ConceptCardTemplate;
    [Token(Token = "0x4009102")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject CoinTemplate;
    [Token(Token = "0x4009103")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject GoldTemplate;
    [Token(Token = "0x4009104")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string CheckAnimState;
    [Token(Token = "0x4009105")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string SkipAnimTrigger;
    [Token(Token = "0x4009106")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private string SkipToAnimState;
    [Token(Token = "0x4009107")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject BackGround;
    [Token(Token = "0x4009108")]
    [FieldOffset(Offset = "0x34")]
    private List<FirstChargeReward> m_Rewards;
    [Token(Token = "0x4009109")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> m_IconObj;
    [Token(Token = "0x400910A")]
    [FieldOffset(Offset = "0x3C")]
    private Animator m_WindowAnim;
    [Token(Token = "0x400910B")]
    [FieldOffset(Offset = "0x40")]
    private bool m_IsRefresh;
    [Token(Token = "0x400910C")]
    [FieldOffset(Offset = "0x41")]
    private bool m_IsClosed;

    [Token(Token = "0x6008BC4")]
    [Address(RVA = "0x4F8E30", Offset = "0x4F7C30", VA = "0x104F8E30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008BC5")]
    [Address(RVA = "0x4F8E80", Offset = "0x4F7C80", VA = "0x104F8E80")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008BC6")]
    [Address(RVA = "0x4FA400", Offset = "0x4F9200", VA = "0x104FA400")]
    private void Update()
    {
    }

    [Token(Token = "0x6008BC7")]
    [Address(RVA = "0x4F91B0", Offset = "0x4F7FB0", VA = "0x104F91B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008BC8")]
    [Address(RVA = "0x4FA260", Offset = "0x4F9060", VA = "0x104FA260")]
    private void SkipIconAnimation()
    {
    }

    [Token(Token = "0x6008BC9")]
    [Address(RVA = "0x4F9090", Offset = "0x4F7E90", VA = "0x104F9090")]
    private void CheckIconAnimation()
    {
    }

    [Token(Token = "0x6008BCA")]
    [Address(RVA = "0x4FA1D0", Offset = "0x4F8FD0", VA = "0x104FA1D0")]
    public void SetUp(FirstChargeReward[] _rewards)
    {
    }

    [Token(Token = "0x6008BCB")]
    [Address(RVA = "0x4F9E30", Offset = "0x4F8C30", VA = "0x104F9E30")]
    private GameObject SetItem(string _iname, int _num) => (GameObject) null;

    [Token(Token = "0x6008BCC")]
    [Address(RVA = "0x4F9FB0", Offset = "0x4F8DB0", VA = "0x104F9FB0")]
    private GameObject SetUnit(string _iname) => (GameObject) null;

    [Token(Token = "0x6008BCD")]
    [Address(RVA = "0x4F9D00", Offset = "0x4F8B00", VA = "0x104F9D00")]
    private GameObject SetGold(int _num = 0) => (GameObject) null;

    [Token(Token = "0x6008BCE")]
    [Address(RVA = "0x4F99C0", Offset = "0x4F87C0", VA = "0x104F99C0")]
    private GameObject SetCoin(int _num = 0) => (GameObject) null;

    [Token(Token = "0x6008BCF")]
    [Address(RVA = "0x4F98E0", Offset = "0x4F86E0", VA = "0x104F98E0")]
    private void SetBitmapText(GameObject _obj, string _name, int _num)
    {
    }

    [Token(Token = "0x6008BD0")]
    [Address(RVA = "0x4F9680", Offset = "0x4F8480", VA = "0x104F9680")]
    private GameObject SetArtifact(string _iname) => (GameObject) null;

    [Token(Token = "0x6008BD1")]
    [Address(RVA = "0x4F9AF0", Offset = "0x4F88F0", VA = "0x104F9AF0")]
    private GameObject SetConceptCard(string _iname) => (GameObject) null;

    [Token(Token = "0x6008BD2")]
    [Address(RVA = "0x4F95D0", Offset = "0x4F83D0", VA = "0x104F95D0")]
    private void SetAnimatorTrigger(GameObject _obj, string _name)
    {
    }

    [Token(Token = "0x6008BD3")]
    [Address(RVA = "0x4FA530", Offset = "0x4F9330", VA = "0x104FA530")]
    public ChargeInfoResultWindow()
    {
    }
  }
}
