// Decompiled with JetBrains decompiler
// Type: SRPG.MailList2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002700")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "メールリスト空", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/MailList2")]
  public class MailList2 : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B7C4")]
    private const int PIN_ID_REFRESH = 1;
    [Token(Token = "0x400B7C5")]
    private const int PIN_ID_LIST_EMPTY = 10;
    [Token(Token = "0x400B7C6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400B7C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ListExtras ScrollView;
    [Token(Token = "0x400B7C8")]
    [FieldOffset(Offset = "0x14")]
    private List<GameObject> mMailListItems;

    [Token(Token = "0x600AECC")]
    [Address(RVA = "0x5DD920", Offset = "0x5DC720", VA = "0x105DD920")]
    private void ActivateOutputLinks(int pinID)
    {
    }

    [Token(Token = "0x600AECD")]
    [Address(RVA = "0x731B50", Offset = "0x730950", VA = "0x10731B50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AECE")]
    [Address(RVA = "0x731BD0", Offset = "0x7309D0", VA = "0x10731BD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AECF")]
    [Address(RVA = "0x731E00", Offset = "0x730C00", VA = "0x10731E00")]
    private void Start()
    {
    }

    [Token(Token = "0x600AED0")]
    [Address(RVA = "0x731E00", Offset = "0x730C00", VA = "0x10731E00")]
    private void InitializeList()
    {
    }

    [Token(Token = "0x600AED1")]
    [Address(RVA = "0x731C60", Offset = "0x730A60", VA = "0x10731C60")]
    private GameObject CreateListItem() => (GameObject) null;

    [Token(Token = "0x600AED2")]
    [Address(RVA = "0x732080", Offset = "0x730E80", VA = "0x10732080")]
    private void UpdateItems()
    {
    }

    [Token(Token = "0x600AED3")]
    [Address(RVA = "0x731E70", Offset = "0x730C70", VA = "0x10731E70")]
    private void OnRefresh()
    {
    }

    [Token(Token = "0x600AED4")]
    [Address(RVA = "0x731EF0", Offset = "0x730CF0", VA = "0x10731EF0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AED5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MailList2()
    {
    }
  }
}
