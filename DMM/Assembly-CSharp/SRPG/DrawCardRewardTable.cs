// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardRewardTable
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
  [Token(Token = "0x2002300")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/DrawCard/DrawCardRewardTable")]
  public class DrawCardRewardTable : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009C44")]
    private const int INPUT_PIN_REFRESH = 1;
    [Token(Token = "0x4009C45")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x4009C46")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public Button PopupButton;
    [Token(Token = "0x4009C47")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public float RewardItemScale;
    [Token(Token = "0x4009C48")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public float RewardItemRotate;
    [Token(Token = "0x4009C49")]
    [FieldOffset(Offset = "0x1C")]
    private List<DrawCardParam.CardData> mRewardCardList;
    [Token(Token = "0x4009C4A")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mRewardItems;

    [Token(Token = "0x6009692")]
    [Address(RVA = "0x5946B0", Offset = "0x5934B0", VA = "0x105946B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009693")]
    [Address(RVA = "0x5946D0", Offset = "0x5934D0", VA = "0x105946D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009694")]
    [Address(RVA = "0x5947E0", Offset = "0x5935E0", VA = "0x105947E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009695")]
    [Address(RVA = "0x594780", Offset = "0x593580", VA = "0x10594780")]
    public GameObject GetLastItemObject() => (GameObject) null;

    [Token(Token = "0x6009696")]
    [Address(RVA = "0x594A80", Offset = "0x593880", VA = "0x10594A80")]
    public DrawCardRewardTable()
    {
    }
  }
}
