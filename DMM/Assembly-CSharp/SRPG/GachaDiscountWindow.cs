// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDiscountWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002426")]
  [AddComponentMenu("UI/GachaDiscountWindow")]
  [FlowNode.Pin(11, "Selected", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "Initalized", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Initalize", FlowNode.PinTypes.Input, 0)]
  public class GachaDiscountWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A3C1")]
    private const int PIN_IN_INIT = 0;
    [Token(Token = "0x400A3C2")]
    private const int PIN_OT_INIT = 1;
    [Token(Token = "0x400A3C3")]
    private const int PIN_OT_SELECT = 11;
    [Token(Token = "0x400A3C4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform m_RootObject;
    [Token(Token = "0x400A3C5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject m_TemplateObject;
    [Token(Token = "0x400A3C6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_EmptyObject;
    [Token(Token = "0x400A3C7")]
    [FieldOffset(Offset = "0x0")]
    public static ItemData m_SelectItemData;

    [Token(Token = "0x6009DA9")]
    [Address(RVA = "0x5FFEB0", Offset = "0x5FECB0", VA = "0x105FFEB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009DAA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009DAB")]
    [Address(RVA = "0x6006E0", Offset = "0x5FF4E0", VA = "0x106006E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009DAC")]
    [Address(RVA = "0x600620", Offset = "0x5FF420", VA = "0x10600620")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009DAD")]
    [Address(RVA = "0x6005E0", Offset = "0x5FF3E0", VA = "0x106005E0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6009DAE")]
    [Address(RVA = "0x6003F0", Offset = "0x5FF1F0", VA = "0x106003F0")]
    private bool Init() => new bool();

    [Token(Token = "0x6009DAF")]
    [Address(RVA = "0x5FFFC0", Offset = "0x5FEDC0", VA = "0x105FFFC0")]
    private void CreateItemList(ItemData[] items)
    {
    }

    [Token(Token = "0x6009DB0")]
    [Address(RVA = "0x5FFF10", Offset = "0x5FED10", VA = "0x105FFF10")]
    private static int ComparaEndAt(ItemData item1, ItemData item2) => new int();

    [Token(Token = "0x6009DB1")]
    [Address(RVA = "0x600660", Offset = "0x5FF460", VA = "0x10600660")]
    private void Select(string iname)
    {
    }

    [Token(Token = "0x6009DB2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaDiscountWindow()
    {
    }
  }
}
