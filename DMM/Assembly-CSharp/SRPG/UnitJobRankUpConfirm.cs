// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobRankUpConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C56")]
  [FlowNode.Pin(2, "画面更新", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/UnitJobRankUpConfirm")]
  [FlowNode.Pin(3, "チェックボックスクリック", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class UnitJobRankUpConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DB75")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400DB76")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400DB77")]
    private const int PIN_IN_TOGGLE = 3;
    [Token(Token = "0x400DB78")]
    [FieldOffset(Offset = "0xC")]
    public Text AllEquipConfirm;
    [Token(Token = "0x400DB79")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RankMaxEquipAttention;
    [Token(Token = "0x400DB7A")]
    [FieldOffset(Offset = "0x14")]
    public Text CostText;
    [Token(Token = "0x400DB7B")]
    [FieldOffset(Offset = "0x18")]
    public Transform ListTransform;
    [Token(Token = "0x400DB7C")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ListItem;
    [Token(Token = "0x400DB7D")]
    [FieldOffset(Offset = "0x20")]
    public Transform CommonListTransform;
    [Token(Token = "0x400DB7E")]
    [FieldOffset(Offset = "0x24")]
    public GameObject CommonListItem;
    [Token(Token = "0x400DB7F")]
    [FieldOffset(Offset = "0x28")]
    public SRPG_Button YesButton;
    [Token(Token = "0x400DB80")]
    [FieldOffset(Offset = "0x2C")]
    public Text NoGoldWarningText;
    [Token(Token = "0x400DB81")]
    [FieldOffset(Offset = "0x30")]
    public UnitJobRankUpConfirm.OnAccept OnAllEquipAccept;
    [Token(Token = "0x400DB82")]
    [FieldOffset(Offset = "0x34")]
    public UnitJobRankUpConfirm.AllInAccept OnAllInAccept;
    [Token(Token = "0x400DB83")]
    [FieldOffset(Offset = "0x38")]
    private int target_rank;
    [Token(Token = "0x400DB84")]
    [FieldOffset(Offset = "0x3C")]
    private bool can_jobmaster;
    [Token(Token = "0x400DB85")]
    [FieldOffset(Offset = "0x3D")]
    private bool can_jobmax;
    [Token(Token = "0x400DB87")]
    [FieldOffset(Offset = "0x40")]
    public UnitJobRankUpConfirm.SetFlag SetCommonFlag;
    [Token(Token = "0x400DB88")]
    [FieldOffset(Offset = "0x44")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DB89")]
    [FieldOffset(Offset = "0x48")]
    private NeedEquipItemList NeedEquipList;
    [Token(Token = "0x400DB8A")]
    [FieldOffset(Offset = "0x4C")]
    public Scrollbar Scroll;
    [Token(Token = "0x400DB8B")]
    [FieldOffset(Offset = "0x50")]
    private bool IsSoul;
    [Token(Token = "0x400DB8C")]
    [FieldOffset(Offset = "0x54")]
    public RectTransform ListRectTranceform;
    [Token(Token = "0x400DB8D")]
    [FieldOffset(Offset = "0x58")]
    public ScrollRect ScrollParent;
    [Token(Token = "0x400DB8E")]
    [FieldOffset(Offset = "0x5C")]
    private float DecelerationRate;
    [Token(Token = "0x400DB8F")]
    [FieldOffset(Offset = "0x60")]
    public GameObject JobInfo;
    [Token(Token = "0x400DB90")]
    [FieldOffset(Offset = "0x64")]
    public Text TargetJobLv;
    [Token(Token = "0x400DB91")]
    [FieldOffset(Offset = "0x68")]
    public Text MaxJobLv;
    [Token(Token = "0x400DB92")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject toggleGroup;
    [Token(Token = "0x400DB93")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x400DB94")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Color jobLv_UpColor;
    [Token(Token = "0x400DB95")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private Color jobLv_NomalColor;
    [Token(Token = "0x400DB96")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private GameObject nonelist;
    [Token(Token = "0x400DB97")]
    [FieldOffset(Offset = "0x98")]
    private List<GameObject> equipsList;
    [Token(Token = "0x400DB98")]
    [FieldOffset(Offset = "0x9C")]
    private List<GameObject> consumesList;
    [Token(Token = "0x400DB99")]
    [FieldOffset(Offset = "0xA0")]
    private List<GameObject> commonNeedList;

    [Token(Token = "0x17001B24")]
    public bool IsAllIn
    {
      [Token(Token = "0x600CD67"), Address(RVA = "0x5F9550", Offset = "0x5F8350", VA = "0x105F9550")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CD68"), Address(RVA = "0x6FC490", Offset = "0x6FB290", VA = "0x106FC490")] set
      {
      }
    }

    [Token(Token = "0x600CD69")]
    [Address(RVA = "0x980E90", Offset = "0x97FC90", VA = "0x10980E90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CD6A")]
    [Address(RVA = "0x981020", Offset = "0x97FE20", VA = "0x10981020")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600CD6B")]
    [Address(RVA = "0x9817D0", Offset = "0x9805D0", VA = "0x109817D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600CD6C")]
    [Address(RVA = "0x982A80", Offset = "0x981880", VA = "0x10982A80")]
    public IEnumerator ScrollInit() => (IEnumerator) null;

    [Token(Token = "0x600CD6D")]
    [Address(RVA = "0x980F80", Offset = "0x97FD80", VA = "0x10980F80")]
    public ItemData CreateItemData(string iname, int num) => (ItemData) null;

    [Token(Token = "0x600CD6E")]
    [Address(RVA = "0x9813F0", Offset = "0x9801F0", VA = "0x109813F0")]
    public void OnAllAccept()
    {
    }

    [Token(Token = "0x600CD6F")]
    [Address(RVA = "0x981590", Offset = "0x980390", VA = "0x10981590")]
    public void OnNeedEquip()
    {
    }

    [Token(Token = "0x600CD70")]
    [Address(RVA = "0x981720", Offset = "0x980520", VA = "0x10981720")]
    private void OnValueChanged()
    {
    }

    [Token(Token = "0x600CD71")]
    [Address(RVA = "0x982B40", Offset = "0x981940", VA = "0x10982B40")]
    public UnitJobRankUpConfirm()
    {
    }

    [Token(Token = "0x2002C57")]
    public delegate void OnAccept(int target_rank, bool can_jobmaster, bool can_jobmax);

    [Token(Token = "0x2002C58")]
    public delegate void AllInAccept(int current_rank, int target_rank);

    [Token(Token = "0x2002C59")]
    public delegate void SetFlag(bool flag);
  }
}
