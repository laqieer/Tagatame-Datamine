// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalEquipUnitListWindow
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
  [Token(Token = "0x20022C3")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "例外エラー", FlowNode.PinTypes.Output, 1001)]
  public class CrystalEquipUnitListWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x4009ACD")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009ACE")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x4009ACF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit ContentExhibit;
    [Token(Token = "0x4009AD0")]
    [FieldOffset(Offset = "0x10")]
    private List<CrystalEquipUnitListWindowModel> mWindowModels;

    [Token(Token = "0x6009543")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009544")]
    [Address(RVA = "0x57F8F0", Offset = "0x57E6F0", VA = "0x1057F8F0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6009545")]
    [Address(RVA = "0x57F990", Offset = "0x57E790", VA = "0x1057F990")]
    public void Initialize(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x6009546")]
    [Address(RVA = "0x5800A0", Offset = "0x57EEA0", VA = "0x105800A0")]
    private void ModelSetUp(List<long> owners, List<CrystalWindow.CrystalUseContents> useDataList)
    {
    }

    [Token(Token = "0x6009547")]
    [Address(RVA = "0x57F910", Offset = "0x57E710", VA = "0x1057F910")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009548")]
    [Address(RVA = "0x580510", Offset = "0x57F310", VA = "0x10580510")]
    public CrystalEquipUnitListWindow()
    {
    }
  }
}
