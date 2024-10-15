// Decompiled with JetBrains decompiler
// Type: SRPG.QuestListV2_MultiPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028A4")]
  [AddComponentMenu("Multi/クエスト一覧")]
  [FlowNode.Pin(0, "表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(50, "鍵なし", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(51, "鍵あり", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(101, "選択された", FlowNode.PinTypes.Output, 101)]
  public class QuestListV2_MultiPlay : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C29C")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C29D")]
    [FieldOffset(Offset = "0x10")]
    [Description("詳細画面として使用するゲームオブジェクト")]
    public GameObject DetailTemplate;
    [Token(Token = "0x400C29E")]
    [FieldOffset(Offset = "0x14")]
    private GameObject mDetailInfo;
    [Token(Token = "0x400C29F")]
    [FieldOffset(Offset = "0x18")]
    public ScrollRect ScrollRect;

    [Token(Token = "0x600B7B6")]
    [Address(RVA = "0x7E6A20", Offset = "0x7E5820", VA = "0x107E6A20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B7B7")]
    [Address(RVA = "0x7E6C30", Offset = "0x7E5A30", VA = "0x107E6C30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B7B8")]
    [Address(RVA = "0x7E78B0", Offset = "0x7E66B0", VA = "0x107E78B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B7B9")]
    [Address(RVA = "0x7E7780", Offset = "0x7E6580", VA = "0x107E7780")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B7BA")]
    [Address(RVA = "0x7E72F0", Offset = "0x7E60F0", VA = "0x107E72F0")]
    private void RefreshItems()
    {
    }

    [Token(Token = "0x600B7BB")]
    [Address(RVA = "0x7E7070", Offset = "0x7E5E70", VA = "0x107E7070")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600B7BC")]
    [Address(RVA = "0x7E6E70", Offset = "0x7E5C70", VA = "0x107E6E70")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B7BD")]
    [Address(RVA = "0x7E6F10", Offset = "0x7E5D10", VA = "0x107E6F10")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B7BE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestListV2_MultiPlay()
    {
    }
  }
}
