// Decompiled with JetBrains decompiler
// Type: SRPG.MailList
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
  [Token(Token = "0x20026FE")]
  [AddComponentMenu("UI/リスト/メール")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class MailList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B7B7")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B7B8")]
    [FieldOffset(Offset = "0x10")]
    [Description("リストアイテムとして使用するゲームオブジェクト(受け取り期限なし)")]
    public GameObject ItemForeverTemplate;
    [Token(Token = "0x400B7B9")]
    [FieldOffset(Offset = "0x14")]
    public Toggle ToggleRead;
    [Token(Token = "0x400B7BA")]
    [FieldOffset(Offset = "0x18")]
    public Toggle ToggleUnRead;
    [Token(Token = "0x400B7BB")]
    [FieldOffset(Offset = "0x1C")]
    public Button ButtonReadAll;
    [Token(Token = "0x400B7BC")]
    [FieldOffset(Offset = "0x20")]
    public int MaxReadCount;
    [Token(Token = "0x400B7BD")]
    [FieldOffset(Offset = "0x24")]
    public ListExtras ScrollView;
    [Token(Token = "0x400B7BE")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> mUnreadMails;
    [Token(Token = "0x400B7BF")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> mReadMails;
    [Token(Token = "0x400B7C0")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mItems;
    [Token(Token = "0x400B7C1")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<GiftTypes, int> currentNums;

    [Token(Token = "0x600AEBB")]
    [Address(RVA = "0x72C490", Offset = "0x72B290", VA = "0x1072C490", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AEBC")]
    [Address(RVA = "0x72C560", Offset = "0x72B360", VA = "0x1072C560")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AEBD")]
    [Address(RVA = "0x72DEE0", Offset = "0x72CCE0", VA = "0x1072DEE0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AEBE")]
    [Address(RVA = "0x72E2A0", Offset = "0x72D0A0", VA = "0x1072E2A0")]
    private void UpdateItems()
    {
    }

    [Token(Token = "0x600AEBF")]
    [Address(RVA = "0x72E220", Offset = "0x72D020", VA = "0x1072E220")]
    private void ToggleReadAll()
    {
    }

    [Token(Token = "0x600AEC0")]
    [Address(RVA = "0x72D690", Offset = "0x72C490", VA = "0x1072D690")]
    private void OnRefresh()
    {
    }

    [Token(Token = "0x600AEC1")]
    [Address(RVA = "0x72D890", Offset = "0x72C690", VA = "0x1072D890")]
    private void OnShowRead(bool isActive)
    {
    }

    [Token(Token = "0x600AEC2")]
    [Address(RVA = "0x72DB60", Offset = "0x72C960", VA = "0x1072DB60")]
    private void OnShowUnRead(bool isActive)
    {
    }

    [Token(Token = "0x600AEC3")]
    [Address(RVA = "0x72D6B0", Offset = "0x72C4B0", VA = "0x1072D6B0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AEC4")]
    [Address(RVA = "0x72DE20", Offset = "0x72CC20", VA = "0x1072DE20")]
    private void RefreshCurrentNums()
    {
    }

    [Token(Token = "0x600AEC5")]
    [Address(RVA = "0x72C4B0", Offset = "0x72B2B0", VA = "0x1072C4B0")]
    private void AddCurrentNum(GiftRecieveItemData data)
    {
    }

    [Token(Token = "0x600AEC6")]
    [Address(RVA = "0x72C830", Offset = "0x72B630", VA = "0x1072C830")]
    private bool CheckRecievable(RewardData reward) => new bool();

    [Token(Token = "0x600AEC7")]
    [Address(RVA = "0x72CE20", Offset = "0x72BC20", VA = "0x1072CE20")]
    private void OnAllReadAccept()
    {
    }

    [Token(Token = "0x600AEC8")]
    [Address(RVA = "0x72CA20", Offset = "0x72B820", VA = "0x1072CA20")]
    private ArtifactData CreateArtifactData(string iname) => (ArtifactData) null;

    [Token(Token = "0x600AEC9")]
    [Address(RVA = "0x72CB20", Offset = "0x72B920", VA = "0x1072CB20")]
    private RewardData GiftDataToRewardData(GiftData[] giftDatas) => (RewardData) null;

    [Token(Token = "0x600AECA")]
    [Address(RVA = "0x72ECE0", Offset = "0x72DAE0", VA = "0x1072ECE0")]
    public MailList()
    {
    }

    [Token(Token = "0x20026FF")]
    private class ItemListEntity
    {
      [Token(Token = "0x400B7C2")]
      [FieldOffset(Offset = "0x8")]
      public int Num;
      [Token(Token = "0x400B7C3")]
      [FieldOffset(Offset = "0xC")]
      public ItemData Item;

      [Token(Token = "0x600AECB")]
      [Address(RVA = "0x731B20", Offset = "0x730920", VA = "0x10731B20")]
      public ItemListEntity(int Num, ItemData Item)
      {
      }
    }
  }
}
