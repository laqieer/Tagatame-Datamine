// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobEquipConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C48")]
  [AddComponentMenu("UI/UnitJobEquipConfirm")]
  public class UnitJobEquipConfirm : MonoBehaviour
  {
    [Token(Token = "0x400DB38")]
    [FieldOffset(Offset = "0xC")]
    public Text AllEquipConfirm;
    [Token(Token = "0x400DB39")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RankMaxEquipAttention;
    [Token(Token = "0x400DB3A")]
    [FieldOffset(Offset = "0x14")]
    public Text CostText;
    [Token(Token = "0x400DB3B")]
    [FieldOffset(Offset = "0x18")]
    public Transform ListTransform;
    [Token(Token = "0x400DB3C")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ListItem;
    [Token(Token = "0x400DB3D")]
    [FieldOffset(Offset = "0x20")]
    public Transform CommonListTransform;
    [Token(Token = "0x400DB3E")]
    [FieldOffset(Offset = "0x24")]
    public GameObject CommonListItem;
    [Token(Token = "0x400DB3F")]
    [FieldOffset(Offset = "0x28")]
    public SRPG_Button YesButton;
    [Token(Token = "0x400DB40")]
    [FieldOffset(Offset = "0x2C")]
    public Text NoGoldWarningText;
    [Token(Token = "0x400DB41")]
    [FieldOffset(Offset = "0x30")]
    public UnitJobEquipConfirm.OnAccept OnAllEquipAccept;
    [Token(Token = "0x400DB42")]
    [FieldOffset(Offset = "0x34")]
    public UnitJobEquipConfirm.AllInAccept OnAllInAccept;
    [Token(Token = "0x400DB43")]
    [FieldOffset(Offset = "0x38")]
    private int target_rank;
    [Token(Token = "0x400DB44")]
    [FieldOffset(Offset = "0x3C")]
    private bool can_jobmaster;
    [Token(Token = "0x400DB45")]
    [FieldOffset(Offset = "0x3D")]
    private bool can_jobmax;
    [Token(Token = "0x400DB47")]
    [FieldOffset(Offset = "0x40")]
    public UnitJobEquipConfirm.SetFlag SetCommonFlag;
    [Token(Token = "0x400DB48")]
    [FieldOffset(Offset = "0x44")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DB49")]
    [FieldOffset(Offset = "0x48")]
    private NeedEquipItemList NeedEquipList;
    [Token(Token = "0x400DB4A")]
    [FieldOffset(Offset = "0x4C")]
    public Scrollbar Scroll;
    [Token(Token = "0x400DB4B")]
    [FieldOffset(Offset = "0x50")]
    private bool IsSoul;
    [Token(Token = "0x400DB4C")]
    [FieldOffset(Offset = "0x54")]
    public RectTransform ListRectTranceform;
    [Token(Token = "0x400DB4D")]
    [FieldOffset(Offset = "0x58")]
    public ScrollRect ScrollParent;
    [Token(Token = "0x400DB4E")]
    [FieldOffset(Offset = "0x5C")]
    private float DecelerationRate;

    [Token(Token = "0x17001B21")]
    public bool IsAllIn
    {
      [Token(Token = "0x600CD1F"), Address(RVA = "0x5F9550", Offset = "0x5F8350", VA = "0x105F9550")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CD20"), Address(RVA = "0x6FC490", Offset = "0x6FB290", VA = "0x106FC490")] set
      {
      }
    }

    [Token(Token = "0x600CD21")]
    [Address(RVA = "0x97E3E0", Offset = "0x97D1E0", VA = "0x1097E3E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CD22")]
    [Address(RVA = "0x97E370", Offset = "0x97D170", VA = "0x1097E370")]
    public IEnumerator ScrollInit() => (IEnumerator) null;

    [Token(Token = "0x600CD23")]
    [Address(RVA = "0x97DFB0", Offset = "0x97CDB0", VA = "0x1097DFB0")]
    public ItemData CreateItemData(string iname, int num) => (ItemData) null;

    [Token(Token = "0x600CD24")]
    [Address(RVA = "0x97E050", Offset = "0x97CE50", VA = "0x1097E050")]
    public void OnAllAccept()
    {
    }

    [Token(Token = "0x600CD25")]
    [Address(RVA = "0x97E1F0", Offset = "0x97CFF0", VA = "0x1097E1F0")]
    public void OnNeedEquip()
    {
    }

    [Token(Token = "0x600CD26")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitJobEquipConfirm()
    {
    }

    [Token(Token = "0x2002C49")]
    public delegate void OnAccept();

    [Token(Token = "0x2002C4A")]
    public delegate void AllInAccept();

    [Token(Token = "0x2002C4B")]
    public delegate void SetFlag(bool flag);
  }
}
