// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiStoneEffect_ExchangeConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF1")]
  [FlowNode.Pin(852, "画面ロック:OFF", FlowNode.PinTypes.Output, 852)]
  [FlowNode.Pin(851, "画面ロック:ON", FlowNode.PinTypes.Output, 851)]
  [FlowNode.Pin(751, "武具詳細へ", FlowNode.PinTypes.Output, 751)]
  [FlowNode.Pin(651, "変換APIへ", FlowNode.PinTypes.Output, 651)]
  [FlowNode.Pin(551, "閉じる", FlowNode.PinTypes.Output, 551)]
  [FlowNode.Pin(401, "武具確認画面へ切り替え", FlowNode.PinTypes.Input, 401)]
  [FlowNode.Pin(351, "武具確認画面へ", FlowNode.PinTypes.Output, 351)]
  [FlowNode.Pin(311, "レアリティ確認：決定", FlowNode.PinTypes.Input, 311)]
  [FlowNode.Pin(301, "レアリティ確認切り替え", FlowNode.PinTypes.Input, 301)]
  [FlowNode.Pin(251, "→レアリティ確認へ", FlowNode.PinTypes.Output, 251)]
  [FlowNode.Pin(212, "ダイアログ：NO", FlowNode.PinTypes.Input, 212)]
  [FlowNode.Pin(211, "ダイアログ：YES", FlowNode.PinTypes.Input, 211)]
  [FlowNode.Pin(151, "武具一覧：キャンセル", FlowNode.PinTypes.Input, 151)]
  [FlowNode.Pin(111, "武具一覧：決定", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(312, "レアリティ確認：キャンセル", FlowNode.PinTypes.Input, 312)]
  public class ArtiStoneEffect_ExchangeConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087D0")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x40087D1")]
    private const int PIN_INPUT_ARTIFACT_OK = 111;
    [Token(Token = "0x40087D2")]
    private const int PIN_INPUT_CANCEL = 151;
    [Token(Token = "0x40087D3")]
    private const int PIN_INPUT_YESNO_DIALOG_YES = 211;
    [Token(Token = "0x40087D4")]
    private const int PIN_INPUT_YESNO_DIALOG_NO = 212;
    [Token(Token = "0x40087D5")]
    private const int PIN_OUTPUT_RARITY_CHECK_CHANGE = 251;
    [Token(Token = "0x40087D6")]
    private const int PIN_INPUT_RARITY_CHECK = 301;
    [Token(Token = "0x40087D7")]
    private const int PIN_INPUT_RARITY_OK = 311;
    [Token(Token = "0x40087D8")]
    private const int PIN_INPUT_RARITY_CANCEL = 312;
    [Token(Token = "0x40087D9")]
    private const int PIN_OUTPUT_RARITY_CANCEL = 351;
    [Token(Token = "0x40087DA")]
    private const int PIN_INPUT_ARTIFACT_CHECK = 401;
    [Token(Token = "0x40087DB")]
    private const int PIN_OUTPUT_CANCEL = 551;
    [Token(Token = "0x40087DC")]
    private const int PIN_OUTPUT_API = 651;
    [Token(Token = "0x40087DD")]
    private const int PIN_OUTPUT_DETAIL = 751;
    [Token(Token = "0x40087DE")]
    private const int PIN_INPUT_CANVAS_LOCK_ON = 851;
    [Token(Token = "0x40087DF")]
    private const int PIN_INPUT_CANVAS_LOCK_OFF = 852;
    [Token(Token = "0x40087E0")]
    public const string ARTIFACT_EXCHANGE_DATA_LIST = "ARTIFACT_EXCHANGE_DATA_LIST";
    [Token(Token = "0x40087E1")]
    public const string ARTIFACT_EXCHANGE_ID_LIST = "ARTIFACT_EXCHANGE_ID_LIST";
    [Token(Token = "0x40087E2")]
    public const string ARTIFACT_EXCHANGE_ITEM_ADD_VALUE = "ARTIFACT_EXCHANGE_ITEM_ADD_VALUE";
    [Token(Token = "0x40087E3")]
    public const string CHECK_DIALOG_MESSAGE_TITLE_TEXT = "sys.ARTIFACT_STONEEFFECT_EXCHANGE_CONFIRM_TITLE";
    [Token(Token = "0x40087E4")]
    public const string CHECK_DIALOG_MESSAGE_TEXT = "sys.ARTIFACT_STONEEFFECT_EXCHANGE_DIALOG_MAIN_TEXT";
    [Token(Token = "0x40087E5")]
    public const string CHECK_DIALOG_MESSAGE_YES_TEXT = "sys.ARTIFACT_STONEEFFECT_EXCHANGE_DIALOG_YES";
    [Token(Token = "0x40087E6")]
    public const string CHECK_DIALOG_MESSAGE_NO_TEXT = "sys.ARTIFACT_STONEEFFECT_EXCHANGE_DIALOG_NO";
    [Token(Token = "0x40087E7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40087E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x40087E9")]
    [FieldOffset(Offset = "0x14")]
    private ArtiStoneEffect_ExchangeConfirmModel mModel;

    [Token(Token = "0x60083D6")]
    [Address(RVA = "0x446A30", Offset = "0x445830", VA = "0x10446A30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083D7")]
    [Address(RVA = "0x446E90", Offset = "0x445C90", VA = "0x10446E90")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60083D8")]
    [Address(RVA = "0x446DD0", Offset = "0x445BD0", VA = "0x10446DD0")]
    public void InitializeModel(List<ArtifactData> artifacts)
    {
    }

    [Token(Token = "0x60083D9")]
    [Address(RVA = "0x4472E0", Offset = "0x4460E0", VA = "0x104472E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60083DA")]
    [Address(RVA = "0x447070", Offset = "0x445E70", VA = "0x10447070")]
    public void OpenCheckDialog()
    {
    }

    [Token(Token = "0x60083DB")]
    [Address(RVA = "0x447000", Offset = "0x445E00", VA = "0x10447000")]
    public void IsRarityCheck()
    {
    }

    [Token(Token = "0x60083DC")]
    [Address(RVA = "0x446DA0", Offset = "0x445BA0", VA = "0x10446DA0")]
    public void ChangeWindow(bool is_artifact)
    {
    }

    [Token(Token = "0x60083DD")]
    [Address(RVA = "0x447360", Offset = "0x446160", VA = "0x10447360")]
    public void SetupAPI()
    {
    }

    [Token(Token = "0x60083DE")]
    [Address(RVA = "0x446CA0", Offset = "0x445AA0", VA = "0x10446CA0")]
    public void ArtifactDetail(ArtifactIconBlockContentNode content)
    {
    }

    [Token(Token = "0x60083DF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_ExchangeConfirm()
    {
    }
  }
}
