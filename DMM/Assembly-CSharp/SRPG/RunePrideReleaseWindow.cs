// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideReleaseWindow
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
  [Token(Token = "0x2002A42")]
  [FlowNode.Pin(2, "解放通信開始", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "代用アイテム確認", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(1, "解放ボタンタップ", FlowNode.PinTypes.Input, 1)]
  public class RunePrideReleaseWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CD78")]
    private const int PIN_INPUT_RELEASE_BUTTON = 1;
    [Token(Token = "0x400CD79")]
    private const int PIN_OUTPUT_RELEASE_CONNECT = 2;
    [Token(Token = "0x400CD7A")]
    private const int PIN_OUTPUT_REPLACE_ITEM = 3;
    [Token(Token = "0x400CD7B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CD7C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RunePrideNeedItemListView ViewObj;
    [Token(Token = "0x400CD7D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour SerializeValue;
    [Token(Token = "0x400CD7E")]
    [FieldOffset(Offset = "0x18")]
    private RunePrideBaseNeedItemWindowModel mModel;
    [Token(Token = "0x400CD7F")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData mUnitData;
    [Token(Token = "0x400CD80")]
    [FieldOffset(Offset = "0x20")]
    private string mTargetIname;
    [Token(Token = "0x400CD81")]
    [FieldOffset(Offset = "0x24")]
    private List<string> mSubInames;
    [Token(Token = "0x400CD82")]
    [FieldOffset(Offset = "0x28")]
    private int mReplaceNum;

    [Token(Token = "0x600C0B1")]
    [Address(RVA = "0x892240", Offset = "0x891040", VA = "0x10892240", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C0B2")]
    [Address(RVA = "0x892380", Offset = "0x891180", VA = "0x10892380")]
    public void SetUp(UnitData _unit_data)
    {
    }

    [Token(Token = "0x600C0B3")]
    [Address(RVA = "0x892300", Offset = "0x891100", VA = "0x10892300")]
    private void Draw()
    {
    }

    [Token(Token = "0x600C0B4")]
    [Address(RVA = "0x892600", Offset = "0x891400", VA = "0x10892600")]
    private void StartConnectRunePrideRelease()
    {
    }

    [Token(Token = "0x600C0B5")]
    [Address(RVA = "0x8926C0", Offset = "0x8914C0", VA = "0x108926C0")]
    public RunePrideReleaseWindow()
    {
    }
  }
}
