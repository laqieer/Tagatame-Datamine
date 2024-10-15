// Decompiled with JetBrains decompiler
// Type: SRPG.HotDeal_Banner
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
  [Token(Token = "0x200263A")]
  [AddComponentMenu("UI/HotDeal/HotDeal_Banner")]
  public class HotDeal_Banner : MonoBehaviour
  {
    [Token(Token = "0x400B282")]
    [FieldOffset(Offset = "0xC")]
    private HotDealInfo m_info;
    [Token(Token = "0x400B283")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private LText m_title;
    [Token(Token = "0x400B284")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private HotDeal_Timer m_timer;
    [Token(Token = "0x400B285")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_price;
    [Token(Token = "0x400B286")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Header("購入ボタン")]
    private Button m_BuyButton;
    [Token(Token = "0x400B287")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("未確認商品")]
    private GameObject m_FoundBadge;
    [Token(Token = "0x400B288")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [Header("ヘルプボタン")]
    private Button m_HelpButton;
    [Token(Token = "0x400B289")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("詳細表示用のprefab")]
    private GameObject m_BuyCoinItemDetailWindow;
    [Token(Token = "0x400B28A")]
    [FieldOffset(Offset = "0x2C")]
    [Header("アイテムアイコンのRewardListItem")]
    [SerializeField]
    private RewardListItem m_RewardListItem;
    [Token(Token = "0x400B28B")]
    [FieldOffset(Offset = "0x30")]
    [Header("発生期間中再表示しない")]
    [SerializeField]
    private Toggle m_CheckToggle;
    [Token(Token = "0x400B28C")]
    [FieldOffset(Offset = "0x34")]
    private List<RewardListItem> m_RewardList;

    [Token(Token = "0x600AA8C")]
    [Address(RVA = "0x6E0500", Offset = "0x6DF300", VA = "0x106E0500")]
    private void Start()
    {
    }

    [Token(Token = "0x600AA8D")]
    [Address(RVA = "0x6E0660", Offset = "0x6DF460", VA = "0x106E0660")]
    private void Update()
    {
    }

    [Token(Token = "0x600AA8E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AA8F")]
    [Address(RVA = "0x6E0020", Offset = "0x6DEE20", VA = "0x106E0020")]
    internal void SetUp(HotDealInfo _info)
    {
    }

    [Token(Token = "0x600AA90")]
    [Address(RVA = "0x6E0420", Offset = "0x6DF220", VA = "0x106E0420")]
    private void SetupBuyButtonListener()
    {
    }

    [Token(Token = "0x600AA91")]
    [Address(RVA = "0x6DFF80", Offset = "0x6DED80", VA = "0x106DFF80")]
    private void RemoveBuyButtonListener()
    {
    }

    [Token(Token = "0x600AA92")]
    [Address(RVA = "0x6DFAB0", Offset = "0x6DE8B0", VA = "0x106DFAB0")]
    private void CreateHotDealItemIconList()
    {
    }

    [Token(Token = "0x600AA93")]
    [Address(RVA = "0x6DFC70", Offset = "0x6DEA70", VA = "0x106DFC70")]
    private void OnClickBuyButton()
    {
    }

    [Token(Token = "0x600AA94")]
    [Address(RVA = "0x6DFD40", Offset = "0x6DEB40", VA = "0x106DFD40")]
    public void OnClickHelpButton()
    {
    }

    [Token(Token = "0x600AA95")]
    [Address(RVA = "0x6DFC00", Offset = "0x6DEA00", VA = "0x106DFC00")]
    public void DrawFoundBadge()
    {
    }

    [Token(Token = "0x600AA96")]
    [Address(RVA = "0x6DFEC0", Offset = "0x6DECC0", VA = "0x106DFEC0")]
    private void OnValueChange(bool value)
    {
    }

    [Token(Token = "0x600AA97")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HotDeal_Banner()
    {
    }
  }
}
