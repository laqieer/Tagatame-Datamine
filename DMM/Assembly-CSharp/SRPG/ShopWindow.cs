// Decompiled with JetBrains decompiler
// Type: SRPG.ShopWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AB7")]
  [FlowNode.Pin(2, "換金(1度だけ表示)", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/ShopWindow")]
  [FlowNode.Pin(11, "退店", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "ゲリラショップへ遷移", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(10, "換金", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "ユニットが選択された", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(13, "欠片変換ウィンドウへ遷移", FlowNode.PinTypes.Output, 13)]
  public class ShopWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D05D")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x400D05E")]
    private const int PIN_IN_SELL = 2;
    [Token(Token = "0x400D05F")]
    private const int PIN_IN_UNIT_SELECTED = 3;
    [Token(Token = "0x400D060")]
    private const int PIN_OUT_SELL = 10;
    [Token(Token = "0x400D061")]
    private const int PIN_OUT_EXIT = 11;
    [Token(Token = "0x400D062")]
    private const int PIN_OUT_GOTO_GUERRILLA = 12;
    [Token(Token = "0x400D063")]
    private const int PIN_OUT_GOTO_PIECE_EXCHANGE = 13;
    [Token(Token = "0x400D064")]
    [FieldOffset(Offset = "0xC")]
    public RawImage ImgBackGround;
    [Token(Token = "0x400D065")]
    [FieldOffset(Offset = "0x10")]
    public RawImage ImgNPC;
    [Token(Token = "0x400D066")]
    [FieldOffset(Offset = "0x14")]
    public EShopType[] NpcRandArray;
    [Token(Token = "0x400D067")]
    [FieldOffset(Offset = "0x18")]
    public ShopWindow.ChangeButton[] ChangeButtons;
    [Token(Token = "0x400D068")]
    [FieldOffset(Offset = "0x1C")]
    [Space(16f)]
    public ImageArray NamePlateImages;
    [Token(Token = "0x400D069")]
    [FieldOffset(Offset = "0x20")]
    public GameObject GuerrillaShopBanner;
    [Token(Token = "0x400D06A")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ImgPathPrefix;
    [Token(Token = "0x400D06B")]
    [FieldOffset(Offset = "0x24")]
    private bool alreadyShowExchange;
    [Token(Token = "0x400D06C")]
    [FieldOffset(Offset = "0x28")]
    public LevelLock[] ShopLevelLock;

    [Token(Token = "0x600C316")]
    [Address(RVA = "0x8B7B80", Offset = "0x8B6980", VA = "0x108B7B80")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C317")]
    [Address(RVA = "0x8B7990", Offset = "0x8B6790", VA = "0x108B7990", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C318")]
    [Address(RVA = "0x8B7EF0", Offset = "0x8B6CF0", VA = "0x108B7EF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C319")]
    [Address(RVA = "0x8B8060", Offset = "0x8B6E60", VA = "0x108B8060")]
    private void ShowExchangeDialog()
    {
    }

    [Token(Token = "0x600C31A")]
    [Address(RVA = "0x5E30A0", Offset = "0x5E1EA0", VA = "0x105E30A0")]
    private bool OnGoOutShop() => new bool();

    [Token(Token = "0x600C31B")]
    [Address(RVA = "0x8B80D0", Offset = "0x8B6ED0", VA = "0x108B80D0")]
    private void ShowExchangePieceDialog()
    {
    }

    [Token(Token = "0x600C31C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopWindow()
    {
    }

    [Token(Token = "0x600C31D")]
    [Address(RVA = "0x8B81D0", Offset = "0x8B6FD0", VA = "0x108B81D0")]
    static ShopWindow()
    {
    }

    [Token(Token = "0x2002AB8")]
    [Serializable]
    public class ChangeButton
    {
      [Token(Token = "0x400D06D")]
      [FieldOffset(Offset = "0x8")]
      public EShopType shopType;
      [Token(Token = "0x400D06E")]
      [FieldOffset(Offset = "0xC")]
      public Button button;

      [Token(Token = "0x600C31E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ChangeButton()
      {
      }
    }
  }
}
