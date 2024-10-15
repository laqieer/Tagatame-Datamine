// Decompiled with JetBrains decompiler
// Type: SRPG.AllUnitEquipBulkReleaseConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002355")]
  [FlowNode.Pin(999, "閉じる", FlowNode.PinTypes.Output, 999)]
  [FlowNode.Pin(11, "描画更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(31, "入力：閉じる", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(101, "初期化", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(111, "API実行へ", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(21, "入力：OK", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class AllUnitEquipBulkReleaseConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009E4B")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4009E4C")]
    private const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x4009E4D")]
    private const int PIN_IN_OK = 21;
    [Token(Token = "0x4009E4E")]
    private const int PIN_IN_CLOSE = 31;
    [Token(Token = "0x4009E4F")]
    private const int PIN_OUT_INIT = 101;
    [Token(Token = "0x4009E50")]
    private const int PIN_OUT_API = 111;
    [Token(Token = "0x4009E51")]
    private const int PIN_OUT_CLOSE = 999;
    [Token(Token = "0x4009E52")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x4009E53")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x4009E54")]
    [FieldOffset(Offset = "0x14")]
    private AllUnitEquipBulkReleaseConfirmWindowModel mModel;

    [Token(Token = "0x600984F")]
    [Address(RVA = "0x5A80F0", Offset = "0x5A6EF0", VA = "0x105A80F0")]
    public void Setup()
    {
    }

    [Token(Token = "0x6009850")]
    [Address(RVA = "0x5A7F90", Offset = "0x5A6D90", VA = "0x105A7F90")]
    public void Initialize(BulkReleaseWindow.Type type, long id, bool isLeagueMatchPeriod)
    {
    }

    [Token(Token = "0x6009851")]
    [Address(RVA = "0x5A8060", Offset = "0x5A6E60", VA = "0x105A8060")]
    public void Refresh(bool intaractable = false)
    {
    }

    [Token(Token = "0x6009852")]
    [Address(RVA = "0x5A7F00", Offset = "0x5A6D00", VA = "0x105A7F00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009853")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AllUnitEquipBulkReleaseConfirmWindow()
    {
    }
  }
}
