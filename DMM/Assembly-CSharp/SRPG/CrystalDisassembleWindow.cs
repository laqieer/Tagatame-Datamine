// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalDisassembleWindow
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
  [Token(Token = "0x20022B7")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "初期化完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(200, "更新", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(100, "実行ボタンon", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "分解開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1001, "強制的に閉じる", FlowNode.PinTypes.Output, 1001)]
  public class CrystalDisassembleWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009A7A")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009A7B")]
    private const int PIN_OUTPUT_INIT_END = 10;
    [Token(Token = "0x4009A7C")]
    private const int PIN_INPUT_OK = 100;
    [Token(Token = "0x4009A7D")]
    private const int PIN_OUTPUT_EXECUTE = 101;
    [Token(Token = "0x4009A7E")]
    private const int PIN_INPUT_REFRESH = 200;
    [Token(Token = "0x4009A7F")]
    private const int PIN_OUTPUT_FORCE_CLOSE = 1001;
    [Token(Token = "0x4009A80")]
    private const string SVB_ICON_OBJ = "crystal_icon";
    [Token(Token = "0x4009A81")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList GradeUpWindowExhibitList;
    [Token(Token = "0x4009A82")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SRPG_Button DisassembleOk;
    [Token(Token = "0x4009A83")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour ItemTemplate;
    [Token(Token = "0x4009A84")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform ItemRoot;
    [Token(Token = "0x4009A85")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalData mData;
    [Token(Token = "0x4009A86")]
    [FieldOffset(Offset = "0x20")]
    private CrystalDisassembleWindowModel mDisassembleWindowModel;
    [Token(Token = "0x4009A87")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> mItems;

    [Token(Token = "0x60094F8")]
    [Address(RVA = "0x57DF80", Offset = "0x57CD80", VA = "0x1057DF80")]
    private void Start()
    {
    }

    [Token(Token = "0x60094F9")]
    [Address(RVA = "0x57D770", Offset = "0x57C570", VA = "0x1057D770", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60094FA")]
    [Address(RVA = "0x57DDB0", Offset = "0x57CBB0", VA = "0x1057DDB0")]
    public bool SetUp(CrystalData _data) => new bool();

    [Token(Token = "0x60094FB")]
    [Address(RVA = "0x57D9C0", Offset = "0x57C7C0", VA = "0x1057D9C0")]
    private void Draw()
    {
    }

    [Token(Token = "0x60094FC")]
    [Address(RVA = "0x57DB20", Offset = "0x57C920", VA = "0x1057DB20")]
    private void SendRequest()
    {
    }

    [Token(Token = "0x60094FD")]
    [Address(RVA = "0x57DA40", Offset = "0x57C840", VA = "0x1057DA40")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60094FE")]
    [Address(RVA = "0x57DBA0", Offset = "0x57C9A0", VA = "0x1057DBA0")]
    private void SetUpDisplayResultIcons(int num = 1)
    {
    }

    [Token(Token = "0x60094FF")]
    [Address(RVA = "0x57DFE0", Offset = "0x57CDE0", VA = "0x1057DFE0")]
    public CrystalDisassembleWindow()
    {
    }
  }
}
