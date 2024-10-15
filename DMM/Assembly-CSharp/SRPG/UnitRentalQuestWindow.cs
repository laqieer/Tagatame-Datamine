// Decompiled with JetBrains decompiler
// Type: SRPG.UnitRentalQuestWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CEF")]
  [AddComponentMenu("UI/UnitRental/UnitRentalQuestWindow")]
  [FlowNode.Pin(10, "リスト切り替え", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "クエストが選択された", FlowNode.PinTypes.Output, 100)]
  public class UnitRentalQuestWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DF5F")]
    [FieldOffset(Offset = "0xC")]
    public Transform QuestList;
    [Token(Token = "0x400DF60")]
    [FieldOffset(Offset = "0x10")]
    public GameObject QuestItemTemplate;
    [Token(Token = "0x400DF61")]
    [FieldOffset(Offset = "0x14")]
    public GameObject QuestDisableItemTemplate;
    [Token(Token = "0x400DF62")]
    [FieldOffset(Offset = "0x18")]
    public GameObject QuestDetailTemplate;
    [Token(Token = "0x400DF63")]
    [FieldOffset(Offset = "0x1C")]
    public string DisableFlagName;
    [Token(Token = "0x400DF64")]
    [FieldOffset(Offset = "0x20")]
    public GameObject CharacterImage;
    [Token(Token = "0x400DF65")]
    [FieldOffset(Offset = "0x24")]
    private List<QuestParam> mQuestList;
    [Token(Token = "0x400DF66")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> mQuestListItems;
    [Token(Token = "0x400DF67")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mQuestDetail;
    [Token(Token = "0x400DF68")]
    [FieldOffset(Offset = "0x30")]
    private bool mListRefreshing;
    [Token(Token = "0x400DF69")]
    [FieldOffset(Offset = "0x31")]
    private bool mIsRestore;
    [Token(Token = "0x400DF6A")]
    [FieldOffset(Offset = "0x34")]
    private UnitData CurrentUnit;
    [Token(Token = "0x400DF6B")]
    [FieldOffset(Offset = "0x38")]
    private UnitRentalParam RentalParam;

    [Token(Token = "0x17001B7D")]
    public bool IsRestore
    {
      [Token(Token = "0x600D11E"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D11F"), Address(RVA = "0x9728A0", Offset = "0x9716A0", VA = "0x109728A0")] set
      {
      }
    }

    [Token(Token = "0x600D120")]
    [Address(RVA = "0x9C1E70", Offset = "0x9C0C70", VA = "0x109C1E70")]
    private void Start()
    {
    }

    [Token(Token = "0x600D121")]
    [Address(RVA = "0x9C1520", Offset = "0x9C0320", VA = "0x109C1520")]
    private void CreateQuestList()
    {
    }

    [Token(Token = "0x600D122")]
    [Address(RVA = "0x9C1DA0", Offset = "0x9C0BA0", VA = "0x109C1DA0")]
    private void RefreshQuestList()
    {
    }

    [Token(Token = "0x600D123")]
    [Address(RVA = "0x9C1B90", Offset = "0x9C0990", VA = "0x109C1B90")]
    private void OnQuestSelect(GameObject button)
    {
    }

    [Token(Token = "0x600D124")]
    [Address(RVA = "0x9C19C0", Offset = "0x9C07C0", VA = "0x109C19C0")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600D125")]
    [Address(RVA = "0x9C1A60", Offset = "0x9C0860", VA = "0x109C1A60")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600D126")]
    [Address(RVA = "0x9C1500", Offset = "0x9C0300", VA = "0x109C1500", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D127")]
    [Address(RVA = "0x9C1F40", Offset = "0x9C0D40", VA = "0x109C1F40")]
    public UnitRentalQuestWindow()
    {
    }
  }
}
