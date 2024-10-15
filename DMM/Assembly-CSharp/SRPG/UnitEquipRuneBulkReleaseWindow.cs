// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEquipRuneBulkReleaseWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F6")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "選択ユニットの全装備刻印を一括解除", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(21, "入力：CANCEL", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(51, "画面更新", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(11, "入力：OK", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(112, "全ユニット対象確認画面へ", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(231, "TOGGLE変更", FlowNode.PinTypes.Output, 231)]
  [FlowNode.Pin(999, "閉じる", FlowNode.PinTypes.Output, 999)]
  [FlowNode.Pin(41, "通信完了", FlowNode.PinTypes.Input, 41)]
  public class UnitEquipRuneBulkReleaseWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CBD9")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400CBDA")]
    private const int PIN_IN_OK = 11;
    [Token(Token = "0x400CBDB")]
    private const int PIN_IN_CANCEL = 21;
    [Token(Token = "0x400CBDC")]
    private const int PIN_IN_BULK_EQUIP_API = 41;
    [Token(Token = "0x400CBDD")]
    private const int PIN_IN_REFRESH = 51;
    [Token(Token = "0x400CBDE")]
    private const int PIN_OUT_BULK_RELEASE = 111;
    [Token(Token = "0x400CBDF")]
    private const int PIN_OUT_ALL_UNIT = 112;
    [Token(Token = "0x400CBE0")]
    private const int PIN_OUT_CHANGE_TOGGLE = 231;
    [Token(Token = "0x400CBE1")]
    private const int PIN_OUT_CLOSE = 999;
    [Token(Token = "0x400CBE2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool mIsSave;
    [Token(Token = "0x400CBE3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CBE4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400CBE5")]
    [FieldOffset(Offset = "0x18")]
    private UnitEquipRuneBulkReleaseWindowModel mModel;

    [Token(Token = "0x600BF42")]
    [Address(RVA = "0x869F20", Offset = "0x868D20", VA = "0x10869F20")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BF43")]
    [Address(RVA = "0x86A120", Offset = "0x868F20", VA = "0x1086A120")]
    public void SaveSVB()
    {
    }

    [Token(Token = "0x600BF44")]
    [Address(RVA = "0x86A090", Offset = "0x868E90", VA = "0x1086A090")]
    public void Refresh(bool interactable = false)
    {
    }

    [Token(Token = "0x600BF45")]
    [Address(RVA = "0x869D70", Offset = "0x868B70", VA = "0x10869D70")]
    public void CheckToggle()
    {
    }

    [Token(Token = "0x600BF46")]
    [Address(RVA = "0x86A000", Offset = "0x868E00", VA = "0x1086A000")]
    public void OnToggle(Toggle toggle)
    {
    }

    [Token(Token = "0x600BF47")]
    [Address(RVA = "0x869ED0", Offset = "0x868CD0", VA = "0x10869ED0")]
    public void Close(bool flag = false)
    {
    }

    [Token(Token = "0x600BF48")]
    [Address(RVA = "0x86A1D0", Offset = "0x868FD0", VA = "0x1086A1D0")]
    public void UpdateRuneManager()
    {
    }

    [Token(Token = "0x600BF49")]
    [Address(RVA = "0x8699B0", Offset = "0x8687B0", VA = "0x108699B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BF4A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitEquipRuneBulkReleaseWindow()
    {
    }
  }
}
