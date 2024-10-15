// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideSerializeListKey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011C3")]
  public class RunePrideSerializeListKey
  {
    [Token(Token = "0x4004086")]
    public const string PANEL_INAME = "PanelIname";
    [Token(Token = "0x4004087")]
    public const string SELECT_PANEL = "SelectPanel";
    [Token(Token = "0x4004088")]
    public const string REMOVE_PANELS = "RemovePanels";
    [Token(Token = "0x4004089")]
    public const string PANEL_CAN_OPEN = "PanelCanOpen";
    [Token(Token = "0x400408A")]
    public const string RELEASE_PANELS = "ReleasePanels";
    [Token(Token = "0x400408B")]
    public const string UNIT_DATA = "UNIT_DATA";
    [Token(Token = "0x400408C")]
    public const string POTENTIAL_PARAM = "POTENTIAL_PARAM";
    [Token(Token = "0x400408D")]
    public const string POTENTIAL_SLOT_STATE = "POTENTIAL_SLOT_STATE";
    [Token(Token = "0x400408E")]
    public const string POTENTIAL_STATUS_INAME = "POTENTIAL_STATUS_INAME";
    [Token(Token = "0x400408F")]
    public const string BONUS_INAME = "BONUS_INAME";
    [Token(Token = "0x4004090")]
    public const string POTENTIAL_SLOT_INDEX = "POTENTIAL_SLOT_INDEX";
    [Token(Token = "0x4004091")]
    public const string REPLACE_TARGET_ITEM_INAME = "REPLACE_TARGET_ITEM_INAME";
    [Token(Token = "0x4004092")]
    public const string REPLACE_SUB_ITEM_INAME = "REPLACE_SUB_ITEM_INAME";
    [Token(Token = "0x4004093")]
    public const string REPLACE_NUM = "REPLACE_NUM";
    [Token(Token = "0x4004094")]
    public const string REPLACE_REQ_DATA = "REPLACE_REQ_DATA";
    [Token(Token = "0x4004095")]
    public const string ITEM_LIST_PARAM = "ITEM_LIST_PARAM";
    [Token(Token = "0x4004096")]
    public const string IS_SELECTOR_CONFIRM = "IS_SELECTOR_CONFIRM";

    [Token(Token = "0x6004B3D")]
    [Address(RVA = "0x1203870", Offset = "0x1202670", VA = "0x11203870")]
    public static void SetPeplaceData(
      ref SerializeValueBehaviour data,
      string _target_iname,
      List<string> _sub_inames,
      int _replace_num,
      SerializeValueList _req_data)
    {
    }

    [Token(Token = "0x6004B3E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideSerializeListKey()
    {
    }
  }
}
