// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelSquareComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A2C")]
  [FlowNode.NodeType("RunePride/RunePridePanelSquareComponent", 32741)]
  [FlowNode.Pin(10, "マスの表示更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "解放アニメーション開始", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(21, "表示更新完了", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(11, "演出完了", FlowNode.PinTypes.Input, 11)]
  public class RunePridePanelSquareComponent : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CCD6")]
    private const int PIN_INPUT_UPDATE = 10;
    [Token(Token = "0x400CCD7")]
    private const int PIN_INPUT_FINISH = 11;
    [Token(Token = "0x400CCD8")]
    private const int PIN_OUTPUT_START_ANIMATION = 20;
    [Token(Token = "0x400CCD9")]
    private const int PIN_OUTPUT_UPDATE_END = 21;
    [Token(Token = "0x400CCDA")]
    [FieldOffset(Offset = "0xC")]
    private Action<int> selectCallback;
    [Token(Token = "0x400CCDB")]
    [FieldOffset(Offset = "0x10")]
    private Action finishAnimationCallback;
    [Token(Token = "0x400CCDC")]
    [FieldOffset(Offset = "0x14")]
    private RunePridePanelSquareModel model;
    [Token(Token = "0x400CCDD")]
    [FieldOffset(Offset = "0x18")]
    [Header("マスタの設定とかみ合うように注意してマスのIDを設定")]
    [SerializeField]
    private int squareId;
    [Token(Token = "0x400CCDE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ExhibitList exhibitList;
    [Token(Token = "0x400CCDF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400CCE0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform centeringTarget;
    [Token(Token = "0x400CCE1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject releaseAnimationObject;

    [Token(Token = "0x170019CA")]
    public int SquareId
    {
      [Token(Token = "0x600C035"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170019CB")]
    public RunePridePanelSquareModel Model
    {
      [Token(Token = "0x600C036"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (RunePridePanelSquareModel) null;
      }
    }

    [Token(Token = "0x170019CC")]
    public Transform CenteringTransform
    {
      [Token(Token = "0x600C037"), Address(RVA = "0x88A070", Offset = "0x888E70", VA = "0x1088A070")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600C038")]
    [Address(RVA = "0x889990", Offset = "0x888790", VA = "0x10889990")]
    public void Initialize(
      RunePridePanelSquareModel model,
      RunePridePanelController controller,
      Action<int> selectCallback,
      Action finishAnimationCallback)
    {
    }

    [Token(Token = "0x600C039")]
    [Address(RVA = "0x889E80", Offset = "0x888C80", VA = "0x10889E80")]
    private void OnSelect()
    {
    }

    [Token(Token = "0x600C03A")]
    [Address(RVA = "0x889EC0", Offset = "0x888CC0", VA = "0x10889EC0")]
    private void Render()
    {
    }

    [Token(Token = "0x600C03B")]
    [Address(RVA = "0x889F70", Offset = "0x888D70", VA = "0x10889F70")]
    public void UpdateModelOnSelect(bool isSelect)
    {
    }

    [Token(Token = "0x600C03C")]
    [Address(RVA = "0x889FA0", Offset = "0x888DA0", VA = "0x10889FA0")]
    public void UpdateModelSelectable(bool isSelectable)
    {
    }

    [Token(Token = "0x600C03D")]
    [Address(RVA = "0x889FD0", Offset = "0x888DD0", VA = "0x10889FD0")]
    public void UpdateModelSetReleasedPrevIdIndex(int prevIdIndex)
    {
    }

    [Token(Token = "0x600C03E")]
    [Address(RVA = "0x88A030", Offset = "0x888E30", VA = "0x1088A030")]
    public void UpdatetModelOnRelease()
    {
    }

    [Token(Token = "0x600C03F")]
    [Address(RVA = "0x889F40", Offset = "0x888D40", VA = "0x10889F40")]
    public void UpdateModelAnotherRouteReleased(bool isAnotherRoute)
    {
    }

    [Token(Token = "0x600C040")]
    [Address(RVA = "0x88A000", Offset = "0x888E00", VA = "0x1088A000")]
    public void UpdateModelStarOver(bool isStarOver)
    {
    }

    [Token(Token = "0x600C041")]
    [Address(RVA = "0x889920", Offset = "0x888720", VA = "0x10889920", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C042")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePridePanelSquareComponent()
    {
    }
  }
}
