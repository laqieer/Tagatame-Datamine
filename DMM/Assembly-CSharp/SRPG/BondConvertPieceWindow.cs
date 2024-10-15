// Decompiled with JetBrains decompiler
// Type: SRPG.BondConvertPieceWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002092")]
  [AddComponentMenu("UI/Bond/BondConvertPieceWindow")]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class BondConvertPieceWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008C6F")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008C70")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;
    [Token(Token = "0x4008C71")]
    private const string SVB_NEED_ITEM_ICON = "reward_icon";
    [Token(Token = "0x4008C72")]
    private const string SVB_NEED_ITEM_ICON_COMON = "reward_icon_common";
    [Token(Token = "0x4008C73")]
    private const string SVB_NEED_PIECE_SHORTAGE = "piece_shortage";
    [Token(Token = "0x4008C74")]
    private const string SVB_NEED_CONVERT_MATERIAL = "convert_material";
    [Token(Token = "0x4008C75")]
    private const string SVB_NEED_NAME_AND_COUNT = "name_cross_count";
    [Token(Token = "0x4008C76")]
    private const string SVB_HAVE_PIECE_AMOUNT = "sub_piece_amount";
    [Token(Token = "0x4008C77")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mContentRoot;
    [Token(Token = "0x4008C78")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour mContentTemplate;

    [Token(Token = "0x600879C")]
    [Address(RVA = "0x490980", Offset = "0x48F780", VA = "0x10490980", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600879D")]
    [Address(RVA = "0x491360", Offset = "0x490160", VA = "0x10491360")]
    private void Start()
    {
    }

    [Token(Token = "0x600879E")]
    [Address(RVA = "0x491090", Offset = "0x48FE90", VA = "0x10491090")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600879F")]
    [Address(RVA = "0x4909A0", Offset = "0x48F7A0", VA = "0x104909A0")]
    public bool CreateContent(
      string origin_item,
      string convert_iname,
      ref int need_amount,
      ref Dictionary<string, int> materials)
    {
      return new bool();
    }

    [Token(Token = "0x60087A0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BondConvertPieceWindow()
    {
    }
  }
}
